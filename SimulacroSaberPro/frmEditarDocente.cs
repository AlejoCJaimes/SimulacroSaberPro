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
    public partial class frmEditarDocente : Form
    {
        public frmEditarDocente()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        private void frmEditarDocente_Load(object sender, EventArgs e)
        {
            dtgvDocente.DataSource = Persona.vistaDocente();
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            
            dtgvDocente.DataSource = Persona.vistaDocenteDocumento(txtNumeroDocumento.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirmarClave.Text == txtEditarClave.Text)
                {
                    if (txtEditarTitulo.Text != "" && cmbEditarEstado.SelectedIndex >= 0 && cmbEditarTipoDocumento.SelectedIndex >= 0 && txtEditarNumeroDocumento.Text != "" && txtEditarNombre.Text != "" && txtEditarApellido.Text != "" && txtEditarCorreo.Text != "" && txtEditarClave.Text != "" && cmbEditarTipoDocumento.SelectedItem.ToString() == "Cédula de Ciudadania" || cmbEditarTipoDocumento.SelectedItem.ToString() == "Cédula de Extranjeria" || cmbEditarTipoDocumento.SelectedItem.ToString() == "Otro")
                    {
                        if (dtgvDocente.CurrentCell.ColumnIndex == 1)
                        {
                            string clave = txtEditarClave.Text;
                            IEncriptar miEncriptado = new encriptarDocente();
                            string encriparClave = miEncriptado.encriptar(clave);
                            string documento = dtgvDocente.CurrentCell.Value.ToString();
                            int retorno = Persona.actualizarPersona(documento, cmbEditarTipoDocumento.SelectedItem.ToString(), txtEditarNumeroDocumento.Text, txtEditarNombre.Text, txtEditarApellido.Text, txtEditarTitulo.Text, txtEditarCorreo.Text, encriparClave, cmbEditarEstado.SelectedIndex); ;

                            if (retorno > 0)
                            {
                                MessageBox.Show("Docente editado.", "!Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dtgvDocente.DataSource = Persona.vistaDocente();
                                limpiarCajas();
                            }
                            else
                            {
                                MessageBox.Show("Docente no editado.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene todos los campos.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Las contraseñas no coinciden.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Docente no editado.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            dtgvDocente.DataSource = Persona.vistaDocenteCorreo(txtCorreo.Text);
        }

        private void dtgvAdministrador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvDocente.CurrentRow.Index >= 0)
            {
                if (dtgvDocente.CurrentCell.ColumnIndex == 1)
                {
                    string documento = dtgvDocente.CurrentCell.Value.ToString();
                    CRUD.camposEditarDocente(documento, cmbEditarTipoDocumento, txtEditarNumeroDocumento, txtEditarNombre, txtEditarApellido, txtEditarTitulo, txtEditarCorreo, txtEditarClave, cmbEditarEstado);
                }
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarDocente ventanaRegistrarDocente = new frmRegistrarDocente();
            ventanaRegistrarDocente.Show();
        }

        private void frmEditarDocente_MouseDown(object sender, MouseEventArgs e)
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

        private void cmbEditarTipoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEditarEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
