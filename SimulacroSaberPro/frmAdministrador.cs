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
    public partial class frmAdministrador : Form
    {
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        public frmAdministrador()
        {
            InitializeComponent();
        }
        private void FrmAdministrador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmAdministrador_Load(object sender, EventArgs e)
        {
            //Bordeado de los paneles   
            Utilidades.BorderElipseButton(panelEstudiante);
            Utilidades.BorderElipseButton(panelAdmin);
            Utilidades.BorderElipseButton(panelDocente);

            //Bordeado de los botones
            Utilidades.BorderRedondoButton(btnAdministrador);
            Utilidades.BorderRedondoButton(btnEstudiante);
            Utilidades.BorderRedondoButton(btnDocente);
        }

        private void BtnAdministrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarAdministrador ventanaAdministrador = new frmRegistrarAdministrador();
            ventanaAdministrador.Show();
        }

        private void BtnEstudiante_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarEstudiante ventanaEstudiante = new frmRegistrarEstudiante();
            ventanaEstudiante.Show();
        }

        private void BtnDocente_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarDocente ventanaDocente = new frmRegistrarDocente();
            ventanaDocente.Show();
        }

        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarPrueba ventanaPrueba = new frmRegistrarPrueba();
            ventanaPrueba.Show();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult cerrarSesion = MessageBox.Show("¿Desea cerrar sesión?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (cerrarSesion == DialogResult.Yes) {
                this.Hide();
                frmIniciarSesion ventanaInicioSesion = new frmIniciarSesion();
                ventanaInicioSesion.Show();
            }            
        }

        private void panelAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelEstudiante_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDocente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelPrueba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
