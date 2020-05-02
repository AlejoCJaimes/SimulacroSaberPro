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
using System.Threading;

namespace SimulacroSaberPro
{
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.cacheUsuarioNombre = "";
            Program.cacheUsuarioApellido = "";
            Program.cacheUsuarioNumeroIdentidad = "";
            Program.cacheUsuarioCorreo = "";
            Utilidades.BorderRedondoButton(btnIngresar);
            txtClave.UseSystemPasswordChar = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            usuario();
        }
        public void usuario()
        {
            //1. Estudiante, 2. Docente, 3. Administrador.
            if (txtUsuario.Text != "" && txtUsuario.Text != "usuario@udi.edu.co" && txtClave.Text != "" && txtClave.Text != "contraseña")
            {
                int retorno = CRUD.iniciarSesion(txtUsuario.Text, txtClave.Text);
                if (retorno == 1)
                {
                    this.Hide();
                    frmEstudiante ventanaEstudiante = new frmEstudiante();
                    ventanaEstudiante.Show();
                    Utilidades.abrir(ventanaEstudiante);
                }
                else if (retorno == 2)
                {
                    this.Hide();
                    frmDocente ventanaDocente = new frmDocente();
                    ventanaDocente.Show();
                    Utilidades.abrir(ventanaDocente);
                }
                else if (retorno == 3)
                {
                    this.Hide();
                    frmAdministrador ventanaAdministrador = new frmAdministrador();
                    ventanaAdministrador.Show();
                    Utilidades.abrir(ventanaAdministrador);
                }
                else if (retorno == -1)
                {
                    lblMensajeError.Visible = true;
                    lblMensajeError.Text = "Usuario inhabilitado";
                }
                else
                {
                    lblMensajeError.Visible = true;
                    lblMensajeError.Text = "Usuario no registrado";
                }
            }
            else
            {
                lblMensajeError.Visible = true;
                lblMensajeError.Text = "Llene todos los campos";
            }
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            lblMensajeError.Visible = false;
            if (txtUsuario.Text == "usuario@udi.edu.co")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;

            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "usuario@udi.edu.co";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void TxtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "contraseña";
                txtClave.ForeColor = Color.White;
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void PicMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblOlvidoClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmOlvidoPassword ventanaOlvidoPassword = new frmOlvidoPassword();
            ventanaOlvidoPassword.Show();
        }

        private void TxtClave_Enter(object sender, EventArgs e)
        {
            lblMensajeError.Visible = false;
            if (txtClave.Text == "contraseña")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.White;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                usuario();
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetrasNumeros(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                usuario();
            }
        }

        private void PbSocial_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PbLogoUdi_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
