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

namespace SimulacroSaberPro
{
    public partial class frmEstudiante : Form
    {
        public frmEstudiante()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla


        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Program.cacheUsuarioNombre + " " + Program.cacheUsuarioApellido;
        }

        private void frmEstudiante_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (decision == DialogResult.Yes)
            {
                this.Hide();
                frmIniciarSesion ventanaIniciarSesion = new frmIniciarSesion();
                ventanaIniciarSesion.Show();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEstudianteEditarPerfil ventanaEditarPerfil = new frmEstudianteEditarPerfil();
            ventanaEditarPerfil.Show();
        }

        private void btnPresentarPrueba_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSeleccionarPrueba ventanaSeleccionarPrueba = new frmSeleccionarPrueba();
            ventanaSeleccionarPrueba.Show();
            Utilidades.abrir(ventanaSeleccionarPrueba);
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmResultados ventanaResultados = new frmResultados();
            ventanaResultados.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (decision == DialogResult.Yes)
            {
                this.Hide();
                frmIniciarSesion ventanaIniciarSesion = new frmIniciarSesion();
                ventanaIniciarSesion.Show();
            }
        }

        private void btnContexto_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmContexto ventanaContexto = new frmContexto();
            ventanaContexto.Show();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void PnPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnNombre_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnIzquierdo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnInferior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
