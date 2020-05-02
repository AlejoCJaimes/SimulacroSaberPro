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
    public partial class frmPresentarPrueba : Form
    {
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        int[] guardarRespuestas = new int[4];
        int[] guardarRespuestas2 = new int[4];
        int[] guardarRespuestas3 = new int[4];
        int[] guardarRespuestas4 = new int[4];
        int[] guardarRespuestas5 = new int[4];
        int[] guardarTotalRespuestas = new int[20];
        int indiceOpcionesEstudiante = 0;
        int numeroPrueba;
        static int indicePosicion1 = 0;
        static int indicePosicion2 = 1;
        static int indicePosicion3 = 2;
        static int indicePosicion4 = 3;
        static int indicePosicion5 = 4;
        static int indiceOpcionPosicion1 = 0;
        static int indiceOpcionPosicion2 = 4;
        static int indiceOpcionPosicion3 = 8;
        static int indiceOpcionPosicion4 = 12;
        static int indiceOpcionPosicion5 = 16;
        public frmPresentarPrueba(int numeroPrueba)
        {
            InitializeComponent();
            this.numeroPrueba = numeroPrueba;
        }

        private void frmPresentarPrueba_Load(object sender, EventArgs e)
        {
            CRUD.devolverPregunta(numeroPrueba);
            CRUD.devolverOpciones(numeroPrueba);

            lblTitulo.Text = Program.listaTitulos[indicePosicion1];
            lblEnunciado.Text = Program.listaEnunciados[indicePosicion1];
            lblPregunta.Text = Program.listaPreguntas[indicePosicion1];
            rbOpcion11.Text = Program.listaOpciones[indiceOpcionPosicion1];
            rbOpcion21.Text = Program.listaOpciones[indiceOpcionPosicion1 + 1];
            rbOpcion31.Text = Program.listaOpciones[indiceOpcionPosicion1 + 2];
            rbOpcion41.Text = Program.listaOpciones[indiceOpcionPosicion1 + 3];


            lblTitulo2.Text = Program.listaTitulos[indicePosicion2];
            lblEnunciado2.Text = Program.listaEnunciados[indicePosicion2];
            lblPregunta2.Text = Program.listaPreguntas[indicePosicion2];
            rbOpcion12.Text = Program.listaOpciones[indiceOpcionPosicion2];
            rbOpcion22.Text = Program.listaOpciones[indiceOpcionPosicion2 + 1];
            rbOpcion32.Text = Program.listaOpciones[indiceOpcionPosicion2 + 2];
            rbOpcion42.Text = Program.listaOpciones[indiceOpcionPosicion2 + 3];

            lblTitulo3.Text = Program.listaTitulos[indicePosicion3];
            lblEnunciado3.Text = Program.listaEnunciados[indicePosicion3];
            lblPregunta3.Text = Program.listaPreguntas[indicePosicion3];
            rbOpcion13.Text = Program.listaOpciones[indiceOpcionPosicion3];
            rbOpcion23.Text = Program.listaOpciones[indiceOpcionPosicion3 + 1];
            rbOpcion33.Text = Program.listaOpciones[indiceOpcionPosicion3 + 2];
            rbOpcion43.Text = Program.listaOpciones[indiceOpcionPosicion3 + 3];

            lblTitulo4.Text = Program.listaTitulos[indicePosicion4];
            lblEnunciado4.Text = Program.listaEnunciados[indicePosicion4];
            lblPregunta4.Text = Program.listaPreguntas[indicePosicion4];
            rbOpcion14.Text = Program.listaOpciones[indiceOpcionPosicion4];
            rbOpcion24.Text = Program.listaOpciones[indiceOpcionPosicion4 + 1];
            rbOpcion34.Text = Program.listaOpciones[indiceOpcionPosicion4 + 2];
            rbOpcion44.Text = Program.listaOpciones[indiceOpcionPosicion4 + 3];

            lblTitulo5.Text = Program.listaTitulos[indicePosicion5];
            lblEnunciado5.Text = Program.listaEnunciados[indicePosicion5];
            lblPregunta5.Text = Program.listaPreguntas[indicePosicion5];
            rbOpcion15.Text = Program.listaOpciones[indiceOpcionPosicion5];
            rbOpcion25.Text = Program.listaOpciones[indiceOpcionPosicion5 + 1];
            rbOpcion35.Text = Program.listaOpciones[indiceOpcionPosicion5 + 2];
            rbOpcion45.Text = Program.listaOpciones[indiceOpcionPosicion5 + 3];
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Desea salir de la prueba? Si das SÍ no se guardará tu proceso.", "¡Cuidado!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (decision == DialogResult.Yes)
            {
                Program.listaTitulos.Clear();
                Program.listaEnunciados.Clear();
                Program.listaPreguntas.Clear();
                Program.listaOpciones.Clear();
                indicePosicion1 = 0;
                indicePosicion2 = 1;
                indicePosicion3 = 2;
                indicePosicion4 = 3;
                indicePosicion5 = 4;
                indiceOpcionPosicion1 = 0;
                indiceOpcionPosicion2 = 4;
                indiceOpcionPosicion3 = 8;
                indiceOpcionPosicion4 = 12;
                indiceOpcionPosicion5 = 16;
                this.Hide();
                frmEstudiante ventanaEstudiante = new frmEstudiante();
                ventanaEstudiante.Show();
            }
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            if (indicePosicion1 > 0)
            {
                indiceOpcionesEstudiante--;
                indicePosicion1 -= 5;
                indiceOpcionPosicion1 -= 20;
                lblTitulo.Text = Program.listaTitulos[indicePosicion1];
                lblEnunciado.Text = Program.listaEnunciados[indicePosicion1];
                lblPregunta.Text = Program.listaPreguntas[indicePosicion1];
                rbOpcion11.Text = Program.listaOpciones[indiceOpcionPosicion1];
                rbOpcion21.Text = Program.listaOpciones[indiceOpcionPosicion1 + 1];
                rbOpcion31.Text = Program.listaOpciones[indiceOpcionPosicion1 + 2];
                rbOpcion41.Text = Program.listaOpciones[indiceOpcionPosicion1 + 3];
                if (guardarRespuestas[indiceOpcionesEstudiante] == 0)
                {
                    rbOpcion11.Checked = true;
                }
                else if (guardarRespuestas[indiceOpcionesEstudiante] == 1)
                {
                    rbOpcion21.Checked = true;
                }
                else if (guardarRespuestas[indiceOpcionesEstudiante] == 2)
                {
                    rbOpcion31.Checked = true;
                }
                else if (guardarRespuestas[indiceOpcionesEstudiante] == 3)
                {
                    rbOpcion41.Checked = true;
                }

                indicePosicion2 -= 5;
                indiceOpcionPosicion2 -= 20;
                lblTitulo2.Text = Program.listaTitulos[indicePosicion2];
                lblEnunciado2.Text = Program.listaEnunciados[indicePosicion2];
                lblPregunta2.Text = Program.listaPreguntas[indicePosicion2];
                rbOpcion12.Text = Program.listaOpciones[indiceOpcionPosicion2];
                rbOpcion22.Text = Program.listaOpciones[indiceOpcionPosicion2 + 1];
                rbOpcion32.Text = Program.listaOpciones[indiceOpcionPosicion2 + 2];
                rbOpcion42.Text = Program.listaOpciones[indiceOpcionPosicion2 + 3];
                if (guardarRespuestas2[indiceOpcionesEstudiante] == 0)
                {
                    rbOpcion12.Checked = true;
                }
                else if (guardarRespuestas2[indiceOpcionesEstudiante] == 1)
                {
                    rbOpcion22.Checked = true;
                }
                else if (guardarRespuestas2[indiceOpcionesEstudiante] == 2)
                {
                    rbOpcion32.Checked = true;
                }
                else if (guardarRespuestas2[indiceOpcionesEstudiante] == 3)
                {
                    rbOpcion42.Checked = true;
                }

                indicePosicion3 -= 5;
                indiceOpcionPosicion3 -= 20;
                lblTitulo3.Text = Program.listaTitulos[indicePosicion3];
                lblEnunciado3.Text = Program.listaEnunciados[indicePosicion3];
                lblPregunta3.Text = Program.listaPreguntas[indicePosicion3];
                rbOpcion13.Text = Program.listaOpciones[indiceOpcionPosicion3];
                rbOpcion23.Text = Program.listaOpciones[indiceOpcionPosicion3 + 1];
                rbOpcion33.Text = Program.listaOpciones[indiceOpcionPosicion3 + 2];
                rbOpcion43.Text = Program.listaOpciones[indiceOpcionPosicion3 + 3];
                if (guardarRespuestas3[indiceOpcionesEstudiante] == 0)
                {
                    rbOpcion13.Checked = true;
                }
                else if (guardarRespuestas3[indiceOpcionesEstudiante] == 1)
                {
                    rbOpcion23.Checked = true;
                }
                else if (guardarRespuestas3[indiceOpcionesEstudiante] == 2)
                {
                    rbOpcion33.Checked = true;
                }
                else if (guardarRespuestas3[indiceOpcionesEstudiante] == 3)
                {
                    rbOpcion43.Checked = true;
                }

                indicePosicion4 -= 5;
                indiceOpcionPosicion4 -= 20;
                lblTitulo4.Text = Program.listaTitulos[indicePosicion4];
                lblEnunciado4.Text = Program.listaEnunciados[indicePosicion4];
                lblPregunta4.Text = Program.listaPreguntas[indicePosicion4];
                rbOpcion14.Text = Program.listaOpciones[indiceOpcionPosicion4];
                rbOpcion24.Text = Program.listaOpciones[indiceOpcionPosicion4 + 1];
                rbOpcion34.Text = Program.listaOpciones[indiceOpcionPosicion4 + 2];
                rbOpcion44.Text = Program.listaOpciones[indiceOpcionPosicion4 + 3];
                if (guardarRespuestas4[indiceOpcionesEstudiante] == 0)
                {
                    rbOpcion14.Checked = true;
                }
                else if (guardarRespuestas4[indiceOpcionesEstudiante] == 1)
                {
                    rbOpcion24.Checked = true;
                }
                else if (guardarRespuestas4[indiceOpcionesEstudiante] == 2)
                {
                    rbOpcion34.Checked = true;
                }
                else if (guardarRespuestas4[indiceOpcionesEstudiante] == 3)
                {
                    rbOpcion44.Checked = true;
                }

                indicePosicion5 -= 5;
                indiceOpcionPosicion5 -= 20;
                lblTitulo5.Text = Program.listaTitulos[indicePosicion5];
                lblEnunciado5.Text = Program.listaEnunciados[indicePosicion5];
                lblPregunta5.Text = Program.listaPreguntas[indicePosicion5];
                rbOpcion15.Text = Program.listaOpciones[indiceOpcionPosicion5];
                rbOpcion25.Text = Program.listaOpciones[indiceOpcionPosicion5 + 1];
                rbOpcion35.Text = Program.listaOpciones[indiceOpcionPosicion5 + 2];
                rbOpcion45.Text = Program.listaOpciones[indiceOpcionPosicion5 + 3];
                if (guardarRespuestas5[indiceOpcionesEstudiante] == 0)
                {
                    rbOpcion15.Checked = true;
                }
                else if (guardarRespuestas5[indiceOpcionesEstudiante] == 1)
                {
                    rbOpcion25.Checked = true;
                }
                else if (guardarRespuestas5[indiceOpcionesEstudiante] == 2)
                {
                    rbOpcion35.Checked = true;
                }
                else if (guardarRespuestas5[indiceOpcionesEstudiante] == 3)
                {
                    rbOpcion45.Checked = true;
                }

                if (indicePosicion5 < 19)
                {
                    pbSiguiente.Enabled = true;
                }

            }
            else
            {
                pbAtras.Enabled = false;
            }
        }

        private void pbSiguiente_Click(object sender, EventArgs e)
        {

            if (indicePosicion5 < 19)
            {
                indiceOpcionesEstudiante++;
                indicePosicion1 += 5;
                indiceOpcionPosicion1 += 20;
                lblTitulo.Text = Program.listaTitulos[indicePosicion1];
                lblEnunciado.Text = Program.listaEnunciados[indicePosicion1];
                lblPregunta.Text = Program.listaPreguntas[indicePosicion1];
                rbOpcion11.Text = Program.listaOpciones[indiceOpcionPosicion1];
                rbOpcion21.Text = Program.listaOpciones[indiceOpcionPosicion1 + 1];
                rbOpcion31.Text = Program.listaOpciones[indiceOpcionPosicion1 + 2];
                rbOpcion41.Text = Program.listaOpciones[indiceOpcionPosicion1 + 3];
                if (guardarRespuestas[indiceOpcionesEstudiante] == 0)
                {
                    rbOpcion11.Checked = true;
                }
                else if (guardarRespuestas[indiceOpcionesEstudiante] == 1)
                {
                    rbOpcion21.Checked = true;
                }
                else if (guardarRespuestas[indiceOpcionesEstudiante] == 2)
                {
                    rbOpcion31.Checked = true;
                }
                else if (guardarRespuestas[indiceOpcionesEstudiante] == 3)
                {
                    rbOpcion41.Checked = true;
                }

                indicePosicion2 += 5;
                indiceOpcionPosicion2 += 20;
                lblTitulo2.Text = Program.listaTitulos[indicePosicion2];
                lblEnunciado2.Text = Program.listaEnunciados[indicePosicion2];
                lblPregunta2.Text = Program.listaPreguntas[indicePosicion2];
                rbOpcion12.Text = Program.listaOpciones[indiceOpcionPosicion2];
                rbOpcion22.Text = Program.listaOpciones[indiceOpcionPosicion2 + 1];
                rbOpcion32.Text = Program.listaOpciones[indiceOpcionPosicion2 + 2];
                rbOpcion42.Text = Program.listaOpciones[indiceOpcionPosicion2 + 3];
                if (guardarRespuestas2[indiceOpcionesEstudiante] == 0)
                {
                    rbOpcion12.Checked = true;
                }
                else if (guardarRespuestas2[indiceOpcionesEstudiante] == 1)
                {
                    rbOpcion22.Checked = true;
                }
                else if (guardarRespuestas2[indiceOpcionesEstudiante] == 2)
                {
                    rbOpcion32.Checked = true;
                }
                else if (guardarRespuestas2[indiceOpcionesEstudiante] == 3)
                {
                    rbOpcion42.Checked = true;
                }

                indicePosicion3 += 5;
                indiceOpcionPosicion3 += 20;
                lblTitulo3.Text = Program.listaTitulos[indicePosicion3];
                lblEnunciado3.Text = Program.listaEnunciados[indicePosicion3];
                lblPregunta3.Text = Program.listaPreguntas[indicePosicion3];
                rbOpcion13.Text = Program.listaOpciones[indiceOpcionPosicion3];
                rbOpcion23.Text = Program.listaOpciones[indiceOpcionPosicion3 + 1];
                rbOpcion33.Text = Program.listaOpciones[indiceOpcionPosicion3 + 2];
                rbOpcion43.Text = Program.listaOpciones[indiceOpcionPosicion3 + 3];
                if (guardarRespuestas3[indiceOpcionesEstudiante] == 0)
                {
                    rbOpcion13.Checked = true;
                }
                else if (guardarRespuestas3[indiceOpcionesEstudiante] == 1)
                {
                    rbOpcion23.Checked = true;
                }
                else if (guardarRespuestas3[indiceOpcionesEstudiante] == 2)
                {
                    rbOpcion33.Checked = true;
                }
                else if (guardarRespuestas3[indiceOpcionesEstudiante] == 3)
                {
                    rbOpcion43.Checked = true;
                }


                indicePosicion4 += 5;
                indiceOpcionPosicion4 += 20;
                lblTitulo4.Text = Program.listaTitulos[indicePosicion4];
                lblEnunciado4.Text = Program.listaEnunciados[indicePosicion4];
                lblPregunta4.Text = Program.listaPreguntas[indicePosicion4];
                rbOpcion14.Text = Program.listaOpciones[indiceOpcionPosicion4];
                rbOpcion24.Text = Program.listaOpciones[indiceOpcionPosicion4 + 1];
                rbOpcion34.Text = Program.listaOpciones[indiceOpcionPosicion4 + 2];
                rbOpcion44.Text = Program.listaOpciones[indiceOpcionPosicion4 + 3];
                if (guardarRespuestas4[indiceOpcionesEstudiante] == 0)
                {
                    rbOpcion14.Checked = true;
                }
                else if (guardarRespuestas4[indiceOpcionesEstudiante] == 1)
                {
                    rbOpcion24.Checked = true;
                }
                else if (guardarRespuestas4[indiceOpcionesEstudiante] == 2)
                {
                    rbOpcion34.Checked = true;
                }
                else if (guardarRespuestas4[indiceOpcionesEstudiante] == 3)
                {
                    rbOpcion44.Checked = true;
                }

                indicePosicion5 += 5;
                indiceOpcionPosicion5 += 20;
                lblTitulo5.Text = Program.listaTitulos[indicePosicion5];
                lblEnunciado5.Text = Program.listaEnunciados[indicePosicion5];
                lblPregunta5.Text = Program.listaPreguntas[indicePosicion5];
                rbOpcion15.Text = Program.listaOpciones[indiceOpcionPosicion5];
                rbOpcion25.Text = Program.listaOpciones[indiceOpcionPosicion5 + 1];
                rbOpcion35.Text = Program.listaOpciones[indiceOpcionPosicion5 + 2];
                rbOpcion45.Text = Program.listaOpciones[indiceOpcionPosicion5 + 3];
                if (guardarRespuestas5[indiceOpcionesEstudiante] == 0)
                {
                    rbOpcion15.Checked = true;
                }
                else if (guardarRespuestas5[indiceOpcionesEstudiante] == 1)
                {
                    rbOpcion25.Checked = true;
                }
                else if (guardarRespuestas5[indiceOpcionesEstudiante] == 2)
                {
                    rbOpcion35.Checked = true;
                }
                else if (guardarRespuestas5[indiceOpcionesEstudiante] == 3)
                {
                    rbOpcion45.Checked = true;
                }

                if (indicePosicion1 > 0)
                {
                    pbAtras.Enabled = true;
                }
            }
            else
            {
                pbSiguiente.Enabled = false;
            }
        }

        private void rbOpcion11_Click(object sender, EventArgs e)
        {
            if (rbOpcion11.Checked)
            {
                guardarRespuestas[indiceOpcionesEstudiante] = 0;
            }
        }

        private void rbOpcion21_Click(object sender, EventArgs e)
        {
            if (rbOpcion21.Checked)
            {
                guardarRespuestas[indiceOpcionesEstudiante] = 1;
            }
        }

        private void rbOpcion31_Click(object sender, EventArgs e)
        {
            if (rbOpcion31.Checked)
            {
                guardarRespuestas[indiceOpcionesEstudiante] = 2;
            }
        }

        private void rbOpcion41_Click(object sender, EventArgs e)
        {
            if (rbOpcion41.Checked)
            {
                guardarRespuestas[indiceOpcionesEstudiante] = 3;
            }
        }

        private void rbOpcion12_Click(object sender, EventArgs e)
        {
            if (rbOpcion12.Checked)
            {
                guardarRespuestas2[indiceOpcionesEstudiante] = 0;
            }
        }

        private void rbOpcion22_Click(object sender, EventArgs e)
        {
            if (rbOpcion22.Checked)
            {
                guardarRespuestas2[indiceOpcionesEstudiante] = 1;
            }
        }

        private void rbOpcion32_Click(object sender, EventArgs e)
        {
            if (rbOpcion32.Checked)
            {
                guardarRespuestas2[indiceOpcionesEstudiante] = 2;
            }
        }

        private void rbOpcion42_Click(object sender, EventArgs e)
        {
            if (rbOpcion42.Checked)
            {
                guardarRespuestas2[indiceOpcionesEstudiante] = 3;
            }
        }

        private void rbOpcion13_Click(object sender, EventArgs e)
        {
            if (rbOpcion13.Checked)
            {
                guardarRespuestas3[indiceOpcionesEstudiante] = 0;
            }
        }

        private void rbOpcion23_Click(object sender, EventArgs e)
        {
            if (rbOpcion23.Checked)
            {
                guardarRespuestas3[indiceOpcionesEstudiante] = 1;
            }
        }

        private void rbOpcion33_Click(object sender, EventArgs e)
        {
            if (rbOpcion33.Checked)
            {
                guardarRespuestas3[indiceOpcionesEstudiante] = 2;
            }
        }

        private void rbOpcion43_Click(object sender, EventArgs e)
        {
            if (rbOpcion43.Checked)
            {
                guardarRespuestas3[indiceOpcionesEstudiante] = 3;
            }
        }

        private void rbOpcion14_Click(object sender, EventArgs e)
        {
            if (rbOpcion14.Checked)
            {
                guardarRespuestas4[indiceOpcionesEstudiante] = 0;
            }
        }

        private void rbOpcion24_Click(object sender, EventArgs e)
        {
            if (rbOpcion24.Checked)
            {
                guardarRespuestas4[indiceOpcionesEstudiante] = 1;
            }
        }

        private void rbOpcion34_Click(object sender, EventArgs e)
        {
            if (rbOpcion34.Checked)
            {
                guardarRespuestas4[indiceOpcionesEstudiante] = 2;
            }
        }

        private void rbOpcion44_Click(object sender, EventArgs e)
        {
            if (rbOpcion44.Checked)
            {
                guardarRespuestas4[indiceOpcionesEstudiante] = 3;
            }
        }

        private void rbOpcion15_Click(object sender, EventArgs e)
        {
            if (rbOpcion15.Checked)
            {
                guardarRespuestas5[indiceOpcionesEstudiante] = 0;
            }
        }

        private void rbOpcion25_Click(object sender, EventArgs e)
        {
            if (rbOpcion25.Checked)
            {
                guardarRespuestas5[indiceOpcionesEstudiante] = 1;
            }
        }

        private void rbOpcion35_Click(object sender, EventArgs e)
        {
            if (rbOpcion35.Checked)
            {
                guardarRespuestas5[indiceOpcionesEstudiante] = 2;
            }
        }

        private void rbOpcion45_Click(object sender, EventArgs e)
        {
            if (rbOpcion45.Checked)
            {
                guardarRespuestas5[indiceOpcionesEstudiante] = 3;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int verificar;
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    verificar = guardarRespuestas[i];
                    verificar = guardarRespuestas2[i];
                    verificar = guardarRespuestas3[i];
                    verificar = guardarRespuestas4[i];
                    verificar = guardarRespuestas5[i];
                }
                verificar = 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Por selecciona tus respuestas.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificar = 0;
            }
            if (verificar == 1)
            {
                int interno = 0;
                for (int i = 0; i < 20; i += 5)
                {
                    guardarTotalRespuestas[i] = guardarRespuestas[interno];
                    guardarTotalRespuestas[i + 1] = guardarRespuestas2[interno];
                    guardarTotalRespuestas[i + 2] = guardarRespuestas3[interno];
                    guardarTotalRespuestas[i + 3] = guardarRespuestas4[interno];
                    guardarTotalRespuestas[i + 4] = guardarRespuestas5[interno];
                    interno++;
                }
                int retorno = CRUD.agregarEstudiantePrueba(numeroPrueba);
                int retorno2 = 0;
                int[] idPreguntas = CRUD.devolverIdPregunta(numeroPrueba);
                for (int i = 0; i < 20; i++)
                {
                    retorno2 = CRUD.agregarEstudiantePregunta(guardarTotalRespuestas[i], idPreguntas[i]);
                }
                if (retorno == 1 && retorno2 == 1)
                {
                    MessageBox.Show("Gracias por su participación.", "¡Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frmEstudiante ventanaEstudiante = new frmEstudiante();
                    ventanaEstudiante.Show();
                }
                else {
                    MessageBox.Show("Por selecciona tus respuestas.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void PnSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
