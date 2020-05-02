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
using CapaLogicaNegocios;

namespace SimulacroSaberPro
{
    public partial class frmEliminarPregunta : Form
    {
        public frmEliminarPregunta()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDocente ventanaDocente = new frmDocente();
            ventanaDocente.Show();
        }

        private void frmEliminarPregunta_Load(object sender, EventArgs e)
        {
            CRUD.mostrarPrueba(cmbPrueba);
        }

        private void cmbPrueba_SelectedIndexChanged(object sender, EventArgs e)
        {
            CRUD.mostrarPregunta(cmbPregunta, cmbPrueba.SelectedItem.ToString());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea eliminar la pregunta?", "¡Cuidado!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                Pregunta.eliminarPregunta(cmbPregunta.SelectedItem.ToString());
                MessageBox.Show("Pregunta eliminada.", "!Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                frmDocente ventanaDocente = new frmDocente();
                ventanaDocente.Show();
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void frmEliminarPregunta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
