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
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla

        private void FrmDocente_Load(object sender, EventArgs e)
        {
            lblNomDocente.Text = Program.cacheUsuarioNombre + " " + Program.cacheUsuarioApellido;
        }

        private void frmDocente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnCrearPrueba_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarPrueba ventanaRegistrarPrueba = new frmRegistrarPrueba();
            ventanaRegistrarPrueba.Show();
        }

        private void btnEditarPregunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditarPregunta ventanaEditarPregunta = new frmEditarPregunta();
            ventanaEditarPregunta.Show();
        }



        private void PanelPregunta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditarPregunta ventanaEditarPregunta = new frmEditarPregunta();
            ventanaEditarPregunta.Show();
        }


        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult cerrarSesion = MessageBox.Show("¿Desea cerrar sesión?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (cerrarSesion == DialogResult.Yes)
            {
                this.Hide();
                frmIniciarSesion ventanaInicioSesion = new frmIniciarSesion();
                ventanaInicioSesion.Show();
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReporteDocente ventanaReporteDocente = new frmReporteDocente();
            ventanaReporteDocente.Show();
        }

        private void btnCrearPregunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarPregunta ventanaRegistrarPregunta = new frmRegistrarPregunta();
            ventanaRegistrarPregunta.Show();
        }

        private void btnEliminarPreguntas_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEliminarPregunta ventanaEliminarPregunta = new frmEliminarPregunta();
            ventanaEliminarPregunta.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult cerrarSesion = MessageBox.Show("¿Desea cerrar sesión?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (cerrarSesion == DialogResult.Yes)
            {
                this.Hide();
                frmIniciarSesion ventanaInicioSesion = new frmIniciarSesion();
                ventanaInicioSesion.Show();
            }
        }

        private void lblNomDocente_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarPerfil_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmEditarPerfilDocente docente = new frmEditarPerfilDocente();
            docente.Show();
        }

        private void PnAbajo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
