using CapaLogicaNegocios;
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
    public partial class frmRegistrarPregunta : Form
    {
        public frmRegistrarPregunta()
        {
            InitializeComponent();
            CRUD.mostrarPrueba(cmbPrueba);
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDocente ventanaDocente = new frmDocente();
            ventanaDocente.Show();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
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
            //OPCION 2
            if (cmbPrueba.SelectedIndex >= 0 && txtTitulo.Text != "" && txtEnunciado.Text != "" && txtPregunta.Text != "" && txtOpcion1.Text != "" && txtOpcion2.Text != "" && txtOpcion3.Text != "" && txtOpcion4.Text != "" && cmbCompetencia.SelectedIndex >= 0)
            {
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


                                    
                                    int retorno = Pregunta.agregarPreguntas(txtTitulo.Text, txtEnunciado.Text, txtPregunta.Text, txtOpcion1.Text, txtOpcion2.Text, txtOpcion3.Text, txtOpcion4.Text, cmbCompetencia.SelectedItem.ToString(), respuestaCorrecta);
                                    int retornoRelacion = Pregunta.ingresarPruebaPregunta(cmbPrueba.SelectedItem.ToString(), txtPregunta.Text);
          
                                    if (retorno > 0 && retornoRelacion > 0)
                                    {
                                        MessageBox.Show("Pregunta Guardada.", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        limpiarCajasPrueba();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Pregunta No Guardada.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                    MessageBox.Show("Error al guardar pregunta.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Llene todos los campos.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //opcion 2
           

        }

        private void FrmRegistrarPregunta_Load(object sender, EventArgs e)
        {
            
            CRUD.mostrarCompetencia(cmbCompetencia);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void cmbPrueba_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarCajasPrueba();
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

        private void frmRegistrarPregunta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void limpiarCajasPrueba()
        {
            cmbPrueba.Text = "";
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

        private void cmbCompetencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbPrueba_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbPrueba_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
