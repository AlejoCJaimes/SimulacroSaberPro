using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaLogicaNegocios;

namespace SimulacroSaberPro
{
    public partial class frmEditarAdministrador : Form
    {
        public frmEditarAdministrador()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarAdministrador ventanaRegistrarAdministrador = new frmRegistrarAdministrador();
            ventanaRegistrarAdministrador.Show();
        }
        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void TxtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloNumeros(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }
        private void FrmEditarAdministrador_Load(object sender, EventArgs e)
        {
            dtgvAdministrador.DataSource = Persona.vistaAdministrador();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEditarClave.Text == txtConfirmarClave.Text)
                {
                    if (txtEditarTitulo.Text != "" && cmbEditarEstado.SelectedIndex >= 0 && cmbEditarTipoDocumento.SelectedIndex >= 0 && txtEditarNumeroDocumento.Text != "" && txtEditarNombre.Text != "" && txtEditarApellido.Text != "" && txtEditarCorreo.Text != "" && txtEditarClave.Text != "" && cmbEditarTipoDocumento.SelectedItem.ToString() == "Cédula de Ciudadania" || cmbEditarTipoDocumento.SelectedItem.ToString() == "Cédula de Extranjeria" || cmbEditarTipoDocumento.SelectedItem.ToString() == "Otro")
                    {
                        if (dtgvAdministrador.CurrentCell.ColumnIndex == 1)
                        {
                                string clave = txtEditarClave.Text;
                                IEncriptar miEncriptado = new encriptarAdministrador();
                                string encriparClave = miEncriptado.encriptar(clave);
                                string documento = dtgvAdministrador.CurrentCell.Value.ToString();

                                int retorno = Persona.actualizarPersona(documento, cmbEditarTipoDocumento.SelectedItem.ToString(), txtEditarNumeroDocumento.Text, txtEditarNombre.Text, txtEditarApellido.Text, txtEditarTitulo.Text, txtEditarCorreo.Text, encriparClave, cmbEditarEstado.SelectedIndex);

                                if (retorno > 0)
                                {
                                    MessageBox.Show("Administrador editado.", "!Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dtgvAdministrador.DataSource = Persona.vistaAdministrador();
                                    limpiarCajas();
                                }
                                else
                                {
                                    MessageBox.Show("Administrador no editado.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene los campos.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No coinciden contraseñas.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error al editar administrador.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TxtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            dtgvAdministrador.DataSource = Persona.vistaAdministradorDocumento(txtNumeroDocumento.Text);
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            dtgvAdministrador.DataSource = Persona.vistaAdministradorCorreo(txtCorreo.Text);
        }

        private void DtgvAdministrador_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string documento = dtgvAdministrador.CurrentCell.Value.ToString();
            CRUD.camposEditarAdministrador(documento, cmbEditarTipoDocumento, txtEditarNumeroDocumento, txtEditarNombre, txtEditarApellido, txtEditarTitulo, txtEditarCorreo, txtEditarClave, cmbEditarEstado);

        }

        private void CmbEditarTipoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TxtEditarNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloNumeros(e);
        }

        private void TxtEditarApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void TxtEditarNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void cmbEditarEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmEditarAdministrador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbInformacion_MouseHover(object sender, EventArgs e)
        {
            lblInformacion.Visible = true;
        }

        private void pbInformacion_MouseLeave(object sender, EventArgs e)
        {
            lblInformacion.Visible = false;
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseSesion_Click(object sender, EventArgs e)
        {
            DialogResult cerrarSesion = MessageBox.Show("¿Desea cerrar sesión?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (cerrarSesion == DialogResult.Yes)
            {
                this.Hide();
                frmIniciarSesion ventanaIniciarSesion = new frmIniciarSesion();
                ventanaIniciarSesion.Show();
            }
        }

        private void dtgvAdministrador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string documento = dtgvAdministrador.CurrentCell.Value.ToString();
            CRUD.camposEditarAdministrador(documento, cmbEditarTipoDocumento, txtEditarNumeroDocumento, txtEditarNombre, txtEditarApellido, txtEditarTitulo, txtEditarCorreo, txtEditarClave, cmbEditarEstado);
        }

        public void limpiarCajas()
        {
            txtCorreo.Text = "";
            txtNumeroDocumento.Text = "";
            cmbEditarTipoDocumento.Text = "";
            txtEditarNumeroDocumento.Text = "";
            txtEditarCorreo.Text = "";
            txtEditarNombre.Text = "";
            txtEditarApellido.Text = "";
            txtEditarClave.Text = "";
            txtEditarTitulo.Text = "";
            cmbEditarEstado.Text = "";
            txtConfirmarClave.Text = "";
        }

        private void txtEditarClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetrasNumeros(e);
        }

        private void txtConfirmarClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetrasNumeros(e);
        }
    }
}
