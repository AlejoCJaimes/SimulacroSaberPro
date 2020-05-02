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
    public partial class frmRegistrarPrueba : Form
    {

        public frmRegistrarPrueba()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        private void PbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FrmPrueba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FrmPrueba_Load(object sender, EventArgs e)
        {
            int ano = DateTime.Now.Year;
            for (int i = ano; i >= 1900; i--)
            {
                cmbAno.Items.Add(i);
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDocente ventanaDocente = new frmDocente();
            ventanaDocente.Show();
        }

        private void TxtNumeroPrueba_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloNumeros(e);
        }

        private void BtnCrearPregunta_Click_1(object sender, EventArgs e)
        {
            string fecha = cmbAno.SelectedItem.ToString() + "-" + (cbmMes.SelectedIndex + 1).ToString() + "-" + cmbDia.SelectedItem.ToString();

            if (Convert.ToInt16(txtNumeroPrueba.Text) > 0 && Convert.ToInt16(txtNumeroPrueba.Text) <= 6)
            {
                if (txtTitulo.Text != "" && cmbAno.SelectedIndex >= 0 && cbmMes.SelectedIndex >= 0 && cmbDia.SelectedIndex >= 0)
                {
                    int retorno = Prueba.agregarPrueba(Convert.ToInt32(txtNumeroPrueba.Text), fecha, txtTitulo.Text);
                    if (retorno > 0)
                    {
                        MessageBox.Show("Prueba creada.", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frmDocente ventanaDocente = new frmDocente();
                        ventanaDocente.Show();
                    }
                    else
                    {
                        MessageBox.Show("Prueba no creada.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Llene todos los campos.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Número de prueba fuera de los límites (0 - 6)", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void PbPrueba_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
