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
    public partial class frmEditarEstudiante : Form
    {
        public frmEditarEstudiante()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            dtgvEstudiante.DataSource = Estudiante.vistaEstudianteDocumento(txtNumeroDocumento.Text);
        }

        private void frmEditarEstudiante_Load(object sender, EventArgs e)
        {
            dtgvEstudiante.DataSource = Estudiante.vistaEstudiante();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirmarClave.Text == txtEditarClave.Text)
                {
                    if (cmbEditarTipoDocumento.SelectedIndex >= 0 && txtEditarNumeroDocumento.Text != "" && txtEditarNombre.Text != "" && txtEditarApellido.Text != "" && txtEditarCorreo.Text != "" && txtEditarClave.Text != "" && cmbEditarTipoDocumento.SelectedItem.ToString() == "Cédula de Ciudadania" || cmbEditarTipoDocumento.SelectedItem.ToString() == "Cédula de Extranjeria" || cmbEditarTipoDocumento.SelectedItem.ToString() == "Otro")
                    {
                        if (dtgvEstudiante.CurrentCell.ColumnIndex == 1)
                        {
                            string documento = dtgvEstudiante.CurrentCell.Value.ToString();
                            string clave = txtEditarClave.Text;
                            IEncriptar miEncriptado = new encriptarEstudiante();
                            string encriparClave = miEncriptado.encriptar(clave);
                            int retorno = Estudiante.actualizarEstudiante(documento, cmbEditarTipoDocumento.SelectedItem.ToString(), txtEditarNumeroDocumento.Text, txtEditarNombre.Text, txtEditarApellido.Text, txtEditarCorreo.Text, encriparClave, txtEditarNumeroDireccion.Text, txtEditarBarrio.Text, txtEditarTelefono.Text, cmbEditarGenero.SelectedItem.ToString()); ;

                            if (retorno > 0)
                            {
                                MessageBox.Show("Estudiante editado.", "!Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dtgvEstudiante.DataSource = Estudiante.vistaEstudiante();
                                limpiarCajas();
                            }
                            else
                            {
                                MessageBox.Show("Estudiante no editado.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Las contraseñas no coinciden.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al editar.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            dtgvEstudiante.DataSource = Estudiante.vistaEstudianteCorreo(txtCorreo.Text);
        }

        private void dtgvEstudiante_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvEstudiante.CurrentRow.Index >= 0)
            {
                if (dtgvEstudiante.CurrentCell.ColumnIndex == 1)
                {
                    string documento = dtgvEstudiante.CurrentCell.Value.ToString();
                    CRUD.camposEditarEstudiante(documento, cmbEditarTipoDocumento, txtEditarNumeroDocumento, txtEditarNombre, txtEditarApellido, txtEditarCorreo, txtEditarClave, txtEditarNumeroDireccion, txtEditarBarrio, txtEditarTelefono, cmbEditarGenero);
                }
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarEstudiante ventanaRegistrarEstudiante = new frmRegistrarEstudiante();
            ventanaRegistrarEstudiante.Show();
        }

        private void frmEditarEstudiante_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbInformacion_MouseLeave(object sender, EventArgs e)
        {
            lblInformacion.Visible = false;
        }

        private void pbInformacion_MouseHover(object sender, EventArgs e)
        {
            lblInformacion.Visible = true;
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
                frmIniciarSesion ventanaInicioSesion = new frmIniciarSesion();
                ventanaInicioSesion.Show();
            }
        }

        private void cmbEditarTipoDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEditarGenero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public void limpiarCajas()
        {
            txtCorreo.Text = "";
            txtNumeroDocumento.Text = "";
            cmbEditarTipoDocumento.Text = "";
            txtEditarNumeroDocumento.Text = "";
            txtEditarCorreo.Text = "";
            txtEditarNumeroDireccion.Text = "";
            txtEditarNombre.Text = "";
            txtEditarApellido.Text = "";
            txtEditarClave.Text = "";
            txtEditarBarrio.Text = "";
            txtEditarTelefono.Text = "";
            cmbEditarGenero.Text = "";
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
