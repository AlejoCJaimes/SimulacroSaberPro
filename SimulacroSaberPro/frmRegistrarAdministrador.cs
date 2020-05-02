using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocios;
using System.Runtime.InteropServices;

namespace SimulacroSaberPro
{
    public partial class frmRegistrarAdministrador : Form
    {
        public frmRegistrarAdministrador()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        private void FrmRegistrarAdministrador_Load(object sender, EventArgs e)
        {
            //Bordeado de los botones
            Utilidades.BorderRedondoButton(btnRegistrar);
            Utilidades.BorderRedondoButton(btnEliminar);
            Utilidades.BorderRedondoButton(btnEditar);
        }

        private void PbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEliminarAdministrador ventanaEliminarAdministrador = new frmEliminarAdministrador();
            ventanaEliminarAdministrador.Show();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbTipoDocumento.SelectedIndex >= 0 && txtNumeroDocumento.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtCorreo.Text != "" && txtClave.Text != "" && txtConfirmarClave.Text != "" && txtTitulo.Text != "")
            {
                if (Utilidades.comprobarUsuario(txtCorreo.Text) == true)
                {
                    if (Utilidades.comprobarDominioUsuario(txtCorreo.Text) == true)
                    {
                        if (txtClave.Text.Length >= 8)
                        {
                            if (txtClave.Text == txtConfirmarClave.Text)
                            {
                                string clave = txtClave.Text;
                                IEncriptar miEncriptado = new encriptarAdministrador();
                                string encriparClave = miEncriptado.encriptar(clave);
                                int retorno = Persona.agregarAdministrador(cmbTipoDocumento.SelectedItem.ToString(), txtNumeroDocumento.Text, txtNombre.Text, txtApellido.Text, txtTitulo.Text, txtCorreo.Text, encriparClave);
                                if (retorno > 0)
                                {
                                    MessageBox.Show("Administrador Guardado", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    frmAdministrador ventanaAdministrador = new frmAdministrador();
                                    ventanaAdministrador.Show();
                                }
                                else {
                                    MessageBox.Show("Administrador No Guardado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No coinciden contraseñas", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mínimo 8 caracteres", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else {
                        MessageBox.Show("Dominio de correo no admitido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Correo no admitido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Llene todos los datos","¡Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdministrador ventanaAdministrador = new frmAdministrador();
            ventanaAdministrador.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditarAdministrador ventanaEditarAdministrador = new frmEditarAdministrador();
            ventanaEditarAdministrador.Show();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            lblMostrarNombre.Text = txtNombre.Text + " " + txtApellido.Text;
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            lblMostrarNombre.Text = txtNombre.Text + " " + txtApellido.Text;
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            lblMostrarCorreo.Text = txtCorreo.Text;
        }

        private void TxtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {

            Utilidades.soloNumeros(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void panelAdministrador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmRegistrarAdministrador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetrasNumeros(e);
        }

        private void txtConfirmarClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetrasNumeros(e);
        }
    }
}
