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
    public partial class frmRegistrarEstudiante : Form
    {
        public frmRegistrarEstudiante()
        {
            InitializeComponent();
        }
        //Inicio arrastrar pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Fin arrastrar pantalla
        private void FrmRegistrarEstudiante_Load(object sender, EventArgs e)
        {    
            CRUD.mostrarPrograma(cmbPrograma);
            CRUD.mostrarDepartamento(cmbDepartamento);
            int ano = DateTime.Now.Year;
            for (int i=ano; i>=1900;i--) {
                cmbAno.Items.Add(i);
            }
        }
        private void FrmRegistrarEstudiante_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdministrador ventanaAdministrador = new frmAdministrador();
            ventanaAdministrador.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEliminarEstudiante ventanaEliminarEstudiante = new frmEliminarEstudiante();
            ventanaEliminarEstudiante.Show();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEditarEstudiante ventanaEditarEstudiante = new frmEditarEstudiante();
            ventanaEditarEstudiante.Show();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbTipoDocumento.SelectedIndex >= 0 && txtNumeroDocumento.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && cmbDepartamento.SelectedIndex >= 0 && cmbCiudad.SelectedIndex >= 0 && cmbPrograma.SelectedIndex >= 0 && txtTelefono.Text != "" && cmbGenero.SelectedIndex >= 0 && cmbAno.SelectedIndex >= 0 && cmbMes.SelectedIndex >= 0 && cmbDia.SelectedIndex >= 0 && txtCorreo.Text != "" && txtClave.Text != "" && txtConfirmarClave.Text != "" && txtDireccion.Text != "" && txtBarrio.Text != "")
            {
                if (Utilidades.comprobarUsuario(txtCorreo.Text) == true)
                {
                    if (Utilidades.comprobarDominioUsuario(txtCorreo.Text) == true)
                    {
                        if (txtClave.Text.Length >= 8)
                        {
                            if (txtClave.Text == txtConfirmarClave.Text)
                            {
                                string clave = txtClave.Text;
                                IEncriptar miEncriptado = new encriptarEstudiante();
                                string encriparClave = miEncriptado.encriptar(clave);
                                string fecha = cmbAno.SelectedItem.ToString() + "-" + (cmbMes.SelectedIndex+1).ToString() + "-" + cmbDia.SelectedItem.ToString();
                                int retorno = Estudiante.agregarEstudiante(cmbTipoDocumento.SelectedItem.ToString(),txtNumeroDocumento.Text,txtNombre.Text,txtApellido.Text,cmbGenero.SelectedItem.ToString(),txtTelefono.Text,fecha,txtCorreo.Text,encriparClave,txtDireccion.Text,txtBarrio.Text, Ciudad.verCodigoCiudad(cmbCiudad.SelectedItem.ToString()), Programa.verCodigoPrograma(cmbPrograma.SelectedItem.ToString()));
                                if (retorno > 0)
                                {
                                    MessageBox.Show("Estudiante Guardado", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Hide();
                                    frmAdministrador ventanaAdministrador = new frmAdministrador();
                                    ventanaAdministrador.Show();
                                }
                                else {
                                    MessageBox.Show("Estudiante No Guardado", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No coinciden contraseñas", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mínimo 8 caracteres", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else {
                        MessageBox.Show("Dominio de correo no admitido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Correo no admitido", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Llene todos los datos", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            lblMostrarNombre.Text = txtNombre.Text + " " + txtApellido.Text;
        }

        private void TxtApellido_TextChanged(object sender, EventArgs e)
        {
            lblMostrarNombre.Text = txtNombre.Text + " " + txtApellido.Text;
        }

        private void CmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAno.SelectedIndex >= 0 && cmbMes.SelectedIndex >= 0 && cmbDia.SelectedIndex >= 0)
            {
                lblMostrarEdad.Text = Utilidades.edad((int)cmbAno.SelectedItem, cmbMes.SelectedIndex + 1, cmbDia.SelectedIndex + 1).ToString() + " años.";
            }
        }

        private void CmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAno.SelectedIndex >= 0 && cmbMes.SelectedIndex >= 0 && cmbDia.SelectedIndex >= 0)
            {
                lblMostrarEdad.Text = Utilidades.edad((int)cmbAno.SelectedItem, (int)cmbMes.SelectedItem, cmbDia.SelectedIndex + 1).ToString() + " años.";
            }
        }

        private void CmbAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAno.SelectedIndex >= 0 && cmbMes.SelectedIndex >= 0 && cmbDia.SelectedIndex >= 0)
            {
                lblMostrarEdad.Text = Utilidades.edad((int)cmbAno.SelectedItem, cmbMes.SelectedIndex + 1, cmbDia.SelectedIndex + 1).ToString() + " años.";
            }
        }

        private void TxtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloNumeros(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetras(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CRUD.mostrarCiudad(cmbCiudad,cmbDepartamento.SelectedItem.ToString());
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

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetrasNumeros(e);
        }

        private void txtConfirmarClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utilidades.soloLetrasNumeros(e);
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblMostrarEdad_Click(object sender, EventArgs e)
        {

        }

        private void lblMostrarNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblMostrarPrograma_Click(object sender, EventArgs e)
        {
            lblMostrarEdad.Text = cmbPrograma.SelectedIndex.ToString();
        }

        private void cmbPrograma_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblMostrarPrograma.Text = cmbPrograma.SelectedItem.ToString();
        }
    }
}
