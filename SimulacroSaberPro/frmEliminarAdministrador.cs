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
    public partial class frmEliminarAdministrador : Form
    {
        public frmEliminarAdministrador()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarAdministrador ventanaRegistrarAdministrador = new frmRegistrarAdministrador();
            ventanaRegistrarAdministrador.Show();
        }

        private void FrmEliminarAdministrador_Load(object sender, EventArgs e)
        {
            dtgvAdministrador.DataSource = Persona.vistaAdministrador();
        }


        private void TxtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            dtgvAdministrador.DataSource = Persona.vistaAdministradorDocumento(txtNumeroDocumento.Text);
        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {
            dtgvAdministrador.DataSource = Persona.vistaAdministradorCorreo(txtCorreo.Text);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Persona.verificarAdministradores() > 1)
                {
                    if (dtgvAdministrador.CurrentCell.ColumnIndex == 1)
                    {
                        string documento = dtgvAdministrador.CurrentCell.Value.ToString();
                        DialogResult opcion = MessageBox.Show("¿Desea eliminar el usuario?", "¡Cuidado!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (opcion == DialogResult.Yes)
                        {
                            Persona.eliminarPersona(documento);
                            MessageBox.Show("Usuario eliminado.", "!Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            limpiarCajas();
                            dtgvAdministrador.DataSource = Persona.vistaAdministrador();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error al eliminar. Mínimo un administrador por lista.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuario no eliminado.", "!Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Console.WriteLine(ex);
            }

        }

        private void TxtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloNumeros(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void frmEliminarAdministrador_MouseDown(object sender, MouseEventArgs e)
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
            txtNumeroDocumento.Text = "";
            txtCorreo.Text = "";
        }
    }
}
