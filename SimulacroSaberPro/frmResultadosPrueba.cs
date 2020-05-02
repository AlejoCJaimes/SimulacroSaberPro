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
    public partial class frmResultadosPrueba : Form
    {
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        string nombrePrueba = "";
        public frmResultadosPrueba(string nombrePrueba)
        {
            InitializeComponent();
            this.nombrePrueba = nombrePrueba;
        }


        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmReporteDocente ventanaReporteDocente = new frmReporteDocente();
            ventanaReporteDocente.Show();
        }

        private void FrmResultadosPrueba_Load(object sender, EventArgs e)
        {
            lblPrueba.Text = lblPrueba.Text + " " + nombrePrueba;
            dtgvconsultaTop.Rows.Clear();
            dtgvconsultaTop.DataSource = CRUD.resultadoTop(nombrePrueba);
        }

        private void FrmResultadosPrueba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PnPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
