using CapaLogicaNegocios;
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

namespace SimulacroSaberPro
{
    public partial class frmEditarPregunta : Form
    {
        public frmEditarPregunta()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        private void frmEditarPregunta_Load(object sender, EventArgs e)
        {
            CRUD.mostrarPrueba(cmbPrueba);
            CRUD.mostrarCompetencia(cmbCompetencia);
        }

        private void cmbPrueba_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CRUD.mostrarPregunta(cmbPregunta, cmbPrueba.SelectedItem.ToString());
                limpiarCajasPrueba();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (cmbPrueba.SelectedIndex >= 0 && cmbPregunta.SelectedIndex >= 0 && txtTitulo.Text != "" && txtEnunciado.Text != "" && txtPregunta.Text != "" && txtOpcion1.Text != "" && txtOpcion2.Text != "" && txtOpcion3.Text != "" && txtOpcion4.Text != "" && cmbCompetencia.SelectedIndex >= 0)
            {
                int respuestaCorrecta = 0;
                if (rbRespuesta1.Checked == true)
                {
                    respuestaCorrecta = 1;
                }
                else if (rbRespuesta2.Checked == true)
                {
                    respuestaCorrecta = 2;
                }
                else if (rbRespuesta3.Checked == true)
                {
                    respuestaCorrecta = 3;
                }
                else
                {
                    respuestaCorrecta = 4;
                }

                if (txtOpcion1.Text != txtOpcion2.Text && txtOpcion1.Text != txtOpcion3.Text && txtOpcion1.Text != txtOpcion4.Text)
                {
                    if (txtOpcion2.Text != txtOpcion1.Text && txtOpcion2.Text != txtOpcion3.Text && txtOpcion2.Text != txtOpcion4.Text)
                    {
                        if (txtOpcion3.Text != txtOpcion1.Text && txtOpcion3.Text != txtOpcion2.Text && txtOpcion3.Text != txtOpcion4.Text)
                        {
                            if (txtOpcion4.Text != txtOpcion1.Text && txtOpcion4.Text != txtOpcion2.Text && txtOpcion4.Text != txtOpcion3.Text)
                            {
                                try
                                {
                                    int retorno = Pregunta.actualizarPregunta(cmbPregunta.SelectedItem.ToString(), txtTitulo.Text, txtEnunciado.Text, txtPregunta.Text, cmbCompetencia.SelectedItem.ToString(), txtOpcion1.Text, txtOpcion2.Text, txtOpcion3.Text, txtOpcion4.Text, respuestaCorrecta);
                                    if (retorno > 0)
                                    {
                                        MessageBox.Show("Pregunta editada.");
                                        cmbPrueba.Text = "";
                                        limpiarCajasPrueba();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Pregunta no editada.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Escoja una prueba y una pregunta.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Las opciones deben ser diferentes.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Las opciones deben ser diferentes.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las opciones deben ser diferentes.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Las opciones deben ser diferentes.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Llene todos los datos.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPregunta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                limpiarCajasPregunta();
                CRUD.camposEditarPregunta(cmbPregunta.SelectedItem.ToString(), txtTitulo, txtEnunciado, txtPregunta, cmbCompetencia, txtOpcion1, txtOpcion2, txtOpcion3, txtOpcion4, rbRespuesta1, rbRespuesta2, rbRespuesta3, rbRespuesta4);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una pregunta");
            }

        }

        private void cmbCompetencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDocente ventanaDocente = new frmDocente();
            ventanaDocente.Show();
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

        private void cmbPregunta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbPrueba_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void frmEditarPregunta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void limpiarCajasPrueba()
        {
            cmbPregunta.Text = "";
            txtTitulo.Text = "";
            txtEnunciado.Text = "";
            txtPregunta.Text = "";
            txtOpcion1.Text = "";
            txtOpcion2.Text = "";
            txtOpcion3.Text = "";
            txtOpcion4.Text = "";
            rbRespuesta1.Checked = true;
            rbRespuesta2.Checked = false;
            rbRespuesta3.Checked = false;
            rbRespuesta4.Checked = false;
            cmbCompetencia.Text = "";
        }
        public void limpiarCajasPregunta()
        {
            txtTitulo.Text = "";
            txtEnunciado.Text = "";
            txtPregunta.Text = "";
            txtOpcion1.Text = "";
            txtOpcion2.Text = "";
            txtOpcion3.Text = "";
            txtOpcion4.Text = "";
            rbRespuesta1.Checked = true;
            rbRespuesta2.Checked = false;
            rbRespuesta3.Checked = false;
            rbRespuesta4.Checked = false;
            cmbCompetencia.Text = "";
        }
    }
}
