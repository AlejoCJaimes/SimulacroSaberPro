using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using CapaLogicaNegocios;
using System.Runtime.InteropServices;

namespace SimulacroSaberPro
{
    public partial class frmOlvidoPassword : Form
    {
        public frmOlvidoPassword()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIniciarSesion ventanaPrincipal = new frmIniciarSesion();
            ventanaPrincipal.Show();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            /*var buscarEstudiante = from p in Program.listaEstudiantes
                         where p.getCorreo().Equals(txtCorreo.Text) || p.getNumeroIdentidad().Equals(txtDocumento.Text)
                         select p;
            foreach (Estudiante pal in buscarEstudiante)
            {
                MessageBox.Show(pal.getNombre().ToString()+ " tu contraseña es: " + pal.getClave().ToString());
            }
            var buscarAdministrador = from p in Program.listaAdministradores
                         where p.getCorreo().Equals(txtCorreo.Text) || p.getNumeroIdentidad().Equals(txtDocumento.Text)
                         select p;
            foreach (Administrador pal in buscarAdministrador)
            {
                MessageBox.Show(pal.getNombre().ToString() + " tu contraseña es: " + pal.getClave().ToString());
            }
            var buscarDocente = from p in Program.listaDocentes
                                      where p.getCorreo().Equals(txtCorreo.Text) || p.getNumeroIdentidad().Equals(txtDocumento.Text)
                                      select p;
            foreach (Docente pal in buscarDocente)
            {
                MessageBox.Show(pal.getNombre().ToString() + " tu contraseña es: " + pal.getClave().ToString());
            }*/
            
                
                    System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

                    mmsg.To.Add("simulacrosaberpro.udi@gmail.com");
                    mmsg.Subject = "Olvidé contraseña";
                    mmsg.SubjectEncoding = System.Text.Encoding.UTF8;
                    mmsg.Bcc.Add("simulacrosaberpro.udi@gmail.com");

                    mmsg.Body = "El correo " + txtCorreo.Text + " olvidó su contraseña.";
                    mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                    mmsg.IsBodyHtml = true;
                    mmsg.From = new System.Net.Mail.MailAddress("simulacrosaberpro.udi@gmail.com");

                    System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                    cliente.Credentials = new System.Net.NetworkCredential("simulacrosaberpro.udi@gmail.com", "JJJ123456789");

                    cliente.Host = "smtp.gmail.com";
                    cliente.Port = 587;
                    cliente.EnableSsl = true;

                    try
                    {
                        cliente.Send(mmsg);
                        MessageBox.Show("Mensaje enviado");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al enviar");
                    }
              

            
        }

        private void frmOlvidoPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "usuario@udi.edu.co")
            {
                txtCorreo.Text = "";
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "usuario@udi.edu.co";
            }
        }

        private void frmOlvidoPassword_Load(object sender, EventArgs e)
        {

        }
    }
}