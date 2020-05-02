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
    public partial class frmResultados : Form
    {
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        public frmResultados()
        {
            InitializeComponent();
        }


        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEstudiante ventanEstudiante = new frmEstudiante();
            ventanEstudiante.Show();
        }

        private void FrmResultados_Load(object sender, EventArgs e)
        {
            CRUD.mostrarNombrePrueba(lklPrueba1, lklPrueba2, lklPrueba3, lklPrueba4, lklPrueba5, lklPrueba6);
            CRUD.presentarNombreCantidad(lblNombre, lblContador);
        }

        private void LklPrueba1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResulEstuPrueba ventanResultadosPrueba = new frmResulEstuPrueba(lklPrueba1.Text);
            ventanResultadosPrueba.Show();
        }

        private void LklPrueba2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResulEstuPrueba ventanResultadosPrueba = new frmResulEstuPrueba(lklPrueba2.Text);
            ventanResultadosPrueba.Show();
        }

        private void LklPrueba3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResulEstuPrueba ventanResultadosPrueba = new frmResulEstuPrueba(lklPrueba3.Text);
            ventanResultadosPrueba.Show();
        }

        private void LklPrueba4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResulEstuPrueba ventanResultadosPrueba = new frmResulEstuPrueba(lklPrueba4.Text);
            ventanResultadosPrueba.Show();
        }

        private void LklPrueba5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResulEstuPrueba ventanResultadosPrueba = new frmResulEstuPrueba(lklPrueba5.Text);
            ventanResultadosPrueba.Show();
        }

        private void LklPrueba6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmResulEstuPrueba ventanResultadosPrueba = new frmResulEstuPrueba(lklPrueba6.Text);
            ventanResultadosPrueba.Show();
        }

        private void PnPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
