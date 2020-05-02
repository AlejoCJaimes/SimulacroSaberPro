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
    public partial class frmResulEstuPrueba : Form
    {
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        string nombrePrueba = "";
        public frmResulEstuPrueba(string nombrePrueba)
        {
            InitializeComponent();
            this.nombrePrueba = nombrePrueba;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmResultados ventanaEstudiante = new frmResultados();
            ventanaEstudiante.Show();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmResulEstuPrueba_Load(object sender, EventArgs e)
        {
            lblPrueba.Text = lblPrueba.Text + ": " + nombrePrueba;
            lblResultadoLecturaCri.Text = CRUD.resultadosLecturaCritica(nombrePrueba);
            lblResultadoIngles.Text = CRUD.resultadosIngles(nombrePrueba);
            lblResultadoCompetencia.Text = CRUD.resultadosCompetencia(nombrePrueba);
            lblResultadoCuantitativo.Text = CRUD.resultadosCuantitativo(nombrePrueba);
            lblResultadoGlobal.Text = lblResultadoGlobal.Text + " " + CRUD.resultadosTotal(nombrePrueba);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmResulEstuPrueba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
