using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace SimulacroSaberPro
{
    class Utilidades
    {

        public Utilidades()
        {

        }
        public static int edad(int ano, int mes, int dia)
        {
            DateTime fechaNacimiento = new DateTime(ano, mes, dia);
            TimeSpan diferenciaFechas = DateTime.Now - fechaNacimiento;
            int edad = (int)(((((int)diferenciaFechas.TotalHours) / 24) / 30.4167) / 12);
            return edad;
        }
        public static bool comprobarUsuario(string usuario)
        {
            bool confirmarUsuario = false;
            string[] dividirUsuario = usuario.Split('@');
            if (dividirUsuario.Length == 2)
            {
                confirmarUsuario = true;
            }
            else
            {
                confirmarUsuario = false;
            }
            return confirmarUsuario;
        }
        public static bool comprobarDominioUsuario(string usuario)
        {
            bool confirmarUsuario = false;
            string[] dividirUsuario = usuario.Split('@');
            if (dividirUsuario[1] == "udi.edu.co")
            {
                confirmarUsuario = true;
            }
            else
            {
                confirmarUsuario = false;
            }
            return confirmarUsuario;
        }
        public static void soloNumeros(KeyPressEventArgs evento)
        {
            if (char.IsDigit(evento.KeyChar))
            {
                evento.Handled = false;
            }
            else if (char.IsControl(evento.KeyChar))
            {
                evento.Handled = false;
            }
            else
            {
                evento.Handled = true;
            }
        }
        public static void soloLetras(KeyPressEventArgs evento)
        {
            if (char.IsLetter(evento.KeyChar))
            {
                evento.Handled = false;
            }
            else if (char.IsControl(evento.KeyChar))
            {
                evento.Handled = false;
            }
            else if (char.IsSeparator(evento.KeyChar))
            {
                evento.Handled = false;
            }
            else
            {
                evento.Handled = true;
            }
        }
        public static void soloLetrasNumeros(KeyPressEventArgs evento)
        {
            if (char.IsLetter(evento.KeyChar))
            {
                evento.Handled = false;
            }
            else if (char.IsControl(evento.KeyChar))
            {
                evento.Handled = false;
            }
            else if (char.IsSeparator(evento.KeyChar))
            {
                evento.Handled = false;
            }
            else if (char.IsDigit(evento.KeyChar))
            {
                evento.Handled = false;
            }
            else 
            {
                evento.Handled = true;
            }
        }
        public static void BorderRedondoButton(Button b)
        {
            Rectangle r = new Rectangle(0, 0, b.Width, b.Height);
            System.Drawing.Drawing2D.GraphicsPath button = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 10;
            button.AddArc(r.X, r.Y, d, d, 180, 90);
            button.AddArc(r.X + r.Width - d, r.Y, d, d, 280, 90);
            button.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            button.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            b.Region = new Region(button);


        }

        public static void BorderElipseButton(Panel b)
        {
            Rectangle r = new Rectangle(0, 0, b.Width, b.Height);
            System.Drawing.Drawing2D.GraphicsPath button = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 10;
            button.AddArc(r.X, r.Y, d, d, 180, 90);
            button.AddArc(r.X + r.Width - d, r.Y, d, d, 280, 90);
            button.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            button.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            b.Region = new Region(button);


        }
        public static void esperar()
        {
            Thread.Sleep(1000);
        }
        static frmCargando ventanaCargando;
        public async static void abrir(Form formDeshabilitar)
        {
            Task oTask = new Task(Utilidades.esperar);
            oTask.Start();
            ventanaCargando = new frmCargando(formDeshabilitar);
            formDeshabilitar.Enabled = false;
            ventanaCargando.Show();
            await oTask;
            //cerrar();
            formDeshabilitar.Enabled = true;
            ventanaCargando.Hide();
        }
        
        /* ENCRIPTAR CON ESTRATEGIA
         string clave = txtClave.Text;

            IEncriptar miEncriptado = new encriptarEstudiante();

            if (txtClave.Text == "docente")
            {
                miEncriptado = new encriptarDocente();
            }
            else if (txtClave.Text == "admin")
            {
                miEncriptado = new encriptarAdministrador();
            }
            else if (txtClave.Text == "estudiante")
            {
                miEncriptado = new encriptarEstudiante();
            }
            string encriparClave = miEncriptado.encriptar(clave);
            MessageBox.Show(encriparClave);
         
         */
    }
}
