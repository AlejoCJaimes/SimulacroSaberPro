using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacroSaberPro
{
    public partial class frmSeleccionarPrueba : Form
    {
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        public frmSeleccionarPrueba()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEstudiante ventanaEstudiante = new frmEstudiante();
            ventanaEstudiante.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lklPrueba1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int contadorPresentar = CRUD.presentarCantidadPruebas();
            if (contadorPresentar <= 0)
            {
                int cantidad = CRUD.devolverCantidadPreguntasPrueba1();
                if (cantidad == 20)
                {
                    this.Hide();
                    frmPresentarPrueba ventanaPresentarPrueba = new frmPresentarPrueba(1);
                    ventanaPresentarPrueba.Show();
                }
                else
                {
                    MessageBox.Show("Prueba no disponible", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Ya presentaste la prueba", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSeleccionarPrueba_Load(object sender, EventArgs e)
        {
            CRUD.mostrarNombrePrueba(lklPrueba1, lklPrueba2, lklPrueba3, lklPrueba4, lklPrueba5, lklPrueba6);
        }

        private void lklPrueba2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int cantidad = CRUD.devolverCantidadPreguntasPrueba2();
            if (cantidad == 20)
            {
                this.Hide();
                frmPresentarPrueba ventanaPresentarPrueba = new frmPresentarPrueba(2);
                ventanaPresentarPrueba.Show();
            }
            else
            {
                MessageBox.Show("Prueba no disponible", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lklPrueba3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int cantidad = CRUD.devolverCantidadPreguntasPrueba3();
            if (cantidad == 20)
            {
                this.Hide();
                frmPresentarPrueba ventanaPresentarPrueba = new frmPresentarPrueba(3);
                ventanaPresentarPrueba.Show();
            }
            else
            {
                MessageBox.Show("Prueba no disponible", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lklPrueba4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int cantidad = CRUD.devolverCantidadPreguntasPrueba4();
            if (cantidad == 20)
            {
                this.Hide();
                frmPresentarPrueba ventanaPresentarPrueba = new frmPresentarPrueba(4);
                ventanaPresentarPrueba.Show();
            }
            else
            {
                MessageBox.Show("Prueba no disponible", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lklPrueba5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int cantidad = CRUD.devolverCantidadPreguntasPrueba5();
            if (cantidad == 20)
            {
                this.Hide();
                frmPresentarPrueba ventanaPresentarPrueba = new frmPresentarPrueba(5);
                ventanaPresentarPrueba.Show();
            }
            else
            {
                MessageBox.Show("Prueba no disponible", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lklPrueba6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int cantidad = CRUD.devolverCantidadPreguntasPrueba6();
            if (cantidad == 20)
            {
                this.Hide();
                frmPresentarPrueba ventanaPresentarPrueba = new frmPresentarPrueba(6);
                ventanaPresentarPrueba.Show();
            }
            else
            {
                MessageBox.Show("Prueba no disponible", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSeleccionarPrueba_MouseDown(object sender, MouseEventArgs e)
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
