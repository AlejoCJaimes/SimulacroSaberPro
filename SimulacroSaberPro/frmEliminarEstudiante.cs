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
    public partial class frmEliminarEstudiante : Form
    {
        public frmEliminarEstudiante()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        private void frmEliminarEstudiante_Load(object sender, EventArgs e)
        {
            dtgvEstudiante.DataSource = Estudiante.vistaEstudiante();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarEstudiante ventanaRegistrarEstudiante = new frmRegistrarEstudiante();
            ventanaRegistrarEstudiante.Show();
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            dtgvEstudiante.DataSource = Estudiante.vistaEstudianteDocumento(txtNumeroDocumento.Text);
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            dtgvEstudiante.DataSource = Estudiante.vistaEstudianteCorreo(txtCorreo.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string documento = dtgvEstudiante.CurrentCell.Value.ToString();
            DialogResult opcion = MessageBox.Show("¿Desea eliminar el usuario?", "¡Cuidado!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                Estudiante.eliminarEstudiante(documento);
                MessageBox.Show("Usuario eliminado.", "!Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiarCajas();
                dtgvEstudiante.DataSource = Estudiante.vistaEstudiante();
            }
        }

        private void frmEliminarEstudiante_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbInformacion_MouseHover(object sender, EventArgs e)
        {
            lblInformacion.Visible = true;
        }

        private void pbInformacion_MouseLeave(object sender, EventArgs e)
        {
            lblInformacion.Visible = false;
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

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void limpiarCajas()
        {
            txtCorreo.Text = "";
            txtNumeroDocumento.Text = "";
        }
    }
}
