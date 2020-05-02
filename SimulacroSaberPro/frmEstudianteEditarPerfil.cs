using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocios;

namespace SimulacroSaberPro
{
    public partial class frmEstudianteEditarPerfil : Form
    {
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        public frmEstudianteEditarPerfil()
        {
            InitializeComponent();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloNumeros(e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == txtConfirmarClave.Text)
            {
                if (txtNombre.Text != "" && txtApellido.Text != "" && txtClave.Text != "" && txtDireccion.Text != "" && txtBarrio.Text != "" && txtTelefono.Text != "")
                {
                    string clave = txtClave.Text;
                    IEncriptar miEncriptado = new encriptarEstudiante();
                    string encriparClave = miEncriptado.encriptar(clave);
                    int retorno = CRUD.actualizarPerfilEstudiante(txtNombre.Text,txtApellido.Text,encriparClave,txtDireccion.Text,txtBarrio.Text,txtTelefono.Text);
                    if (retorno == 1) {
                        MessageBox.Show("Editado correctamente", "¡Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.cacheUsuarioNombre = txtNombre.Text;
                        Program.cacheUsuarioApellido = txtApellido.Text;
                        this.Hide();
                        frmEstudiante ventanaEstudiante = new frmEstudiante();
                        ventanaEstudiante.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Llene todos los campos", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmEstudianteEditarPerfil_Load(object sender, EventArgs e)
        {
            CRUD.camposEditarPerfilEstudiante(txtNombre, txtApellido, txtClave, txtDireccion, txtBarrio, txtTelefono);
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetrasNumeros(e);
        }

        private void txtConfirmarClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetrasNumeros(e);
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEstudiante ventanaEstudiante = new frmEstudiante();
            ventanaEstudiante.Show();
        }

        private void PbPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmEstudianteEditarPerfil_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
