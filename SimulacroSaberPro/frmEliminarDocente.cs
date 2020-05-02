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
    public partial class frmEliminarDocente : Form
    {
        public frmEliminarDocente()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarDocente ventanaRegistrarDocente = new frmRegistrarDocente();
            ventanaRegistrarDocente.Show();
        }

        private void frmEliminarDocente_Load(object sender, EventArgs e)
        {
            dtgvDocente.DataSource = Persona.vistaDocente();
        }

        private void txtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            dtgvDocente.DataSource = Persona.vistaDocenteDocumento(txtNumeroDocumento.Text);
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            dtgvDocente.DataSource = Persona.vistaDocenteCorreo(txtCorreo.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvDocente.CurrentCell.ColumnIndex == 1)
            {
                string documento = dtgvDocente.CurrentCell.Value.ToString();
                DialogResult opcion = MessageBox.Show("¿Desea eliminar el usuario?", "¡Cuidado!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (opcion == DialogResult.Yes)
                {
                    Persona.eliminarPersona(documento);
                    MessageBox.Show("Usuario eliminado.", "!Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiarCajas();
                    dtgvDocente.DataSource = Persona.vistaDocente();
                }
            }
        }

        private void frmEliminarDocente_MouseDown(object sender, MouseEventArgs e)
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
        public void limpiarCajas()
        {
            txtNumeroDocumento.Text = "";
            txtCorreo.Text = "";
        }
    }
}
