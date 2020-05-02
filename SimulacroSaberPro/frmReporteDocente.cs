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

namespace SimulacroSaberPro
{
    public partial class frmReporteDocente : Form
    {
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        public frmReporteDocente()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDocente ventanaDocente = new frmDocente();
            ventanaDocente.Show();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void FrmReporteDocente_Load(object sender, EventArgs e)
        {
            CRUD.mostrarNombrePrueba(lklPrueba1, lklPrueba2, lklPrueba3, lklPrueba4, lklPrueba5, lklPrueba6);
            txtConsulta1.Text = CRUD.preguntaMasPrueba();
            txtPosturaEstudiante.Text = CRUD.enunciadoMasPreguntas();
        }

        private void LklPrueba1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResultadosPrueba ventanaResultadosPrueba = new frmResultadosPrueba(lklPrueba1.Text);
            ventanaResultadosPrueba.Show();
        }

        private void LklPrueba2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResultadosPrueba ventanaResultadosPrueba = new frmResultadosPrueba(lklPrueba2.Text);
            ventanaResultadosPrueba.Show();
        }

        private void LklPrueba3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResultadosPrueba ventanaResultadosPrueba = new frmResultadosPrueba(lklPrueba3.Text);
            ventanaResultadosPrueba.Show();
        }

        private void LklPrueba4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResultadosPrueba ventanaResultadosPrueba = new frmResultadosPrueba(lklPrueba4.Text);
            ventanaResultadosPrueba.Show();
        }

        private void LklPrueba5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResultadosPrueba ventanaResultadosPrueba = new frmResultadosPrueba(lklPrueba5.Text);
            ventanaResultadosPrueba.Show();
        }

        private void LklPrueba6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResultadosPrueba ventanaResultadosPrueba = new frmResultadosPrueba(lklPrueba6.Text);
            ventanaResultadosPrueba.Show();
        }

        private void pbBuscar_Click(object sender, EventArgs e)
        {
            dtgvConsulta2.DataSource = CRUD.resultadoEstudiantes(txtconsulta2.Text);
        }

        private void PbBuscarRango_Click(object sender, EventArgs e)
        {
            dtgvcomsulta3.DataSource = CRUD.devolverRango(txtperiodo1.Text,txtperiodo2.Text);
        }

        private void PnPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmReporteDocente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
