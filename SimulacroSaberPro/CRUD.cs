using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocios;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace SimulacroSaberPro
{
    class CRUD : Form
    {
        static Conexion conexion = Conexion.getInstancia();
        public static void mostrarPrograma(ComboBox cmbPrograma)
        {
            try
            {
                cmbPrograma.Items.Clear();
                MySqlCommand buscar = new MySqlCommand("SELECT Nombre FROM `programa` ORDER BY Nombre;", conexion.getConnection());
                MySqlDataReader leer = buscar.ExecuteReader();
                while (leer.Read())
                {
                    cmbPrograma.Items.Add(leer[0].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void mostrarCompetencia(ComboBox cmbCompetencia)
        {
            try
            {
                cmbCompetencia.Items.Clear();
                MySqlCommand buscar = new MySqlCommand("SELECT UPPER(Nombre) FROM `competencias` ORDER BY Nombre;", conexion.getConnection());
                MySqlDataReader leer = buscar.ExecuteReader();
                while (leer.Read())
                {
                    cmbCompetencia.Items.Add(leer[0].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void mostrarPrueba(ComboBox cmbPrueba)
        {
            try
            {
                cmbPrueba.Items.Clear();
                MySqlCommand buscar = new MySqlCommand("SELECT Titulo FROM `prueba` ORDER BY NumPrueba;", conexion.getConnection());

                MySqlDataReader leer = buscar.ExecuteReader();
                while (leer.Read())
                {
                    cmbPrueba.Items.Add(leer[0].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void mostrarEnunciado(ComboBox cbmEnunciado)
        {
            try
            {
                cbmEnunciado.Items.Clear();
                MySqlCommand buscar = new MySqlCommand("SELECT Titulo FROM `enunciado` ORDER BY Titulo;", conexion.getConnection());

                MySqlDataReader leer = buscar.ExecuteReader();
                while (leer.Read())
                {
                    cbmEnunciado.Items.Add(leer[0].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void mostrarNombrePrueba(LinkLabel prueba1, LinkLabel prueba2, LinkLabel prueba3, LinkLabel prueba4, LinkLabel prueba5, LinkLabel prueba6)
        {
            try
            {
                prueba1.Text = "";
                prueba2.Text = "";
                prueba3.Text = "";
                prueba4.Text = "";
                prueba5.Text = "";
                prueba6.Text = "";
                MySqlCommand buscar = new MySqlCommand("SELECT Titulo FROM `prueba` ORDER BY Titulo;", conexion.getConnection());

                MySqlDataReader leer = buscar.ExecuteReader();
                int i = 1;
                while (leer.Read())
                {
                    if (i == 1)
                    {
                        prueba1.Text = leer[0].ToString();
                    }
                    else if (i == 2)
                    {
                        prueba2.Text = leer[0].ToString();
                    }
                    else if (i == 3)
                    {
                        prueba3.Text = leer[0].ToString();
                    }
                    else if (i == 4)
                    {
                        prueba4.Text = leer[0].ToString();
                    }
                    else if (i == 5)
                    {
                        prueba5.Text = leer[0].ToString();
                    }
                    else
                    {
                        prueba6.Text = leer[0].ToString();
                    }

                    i++;
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void mostrarPregunta(ComboBox cmbPregunta, string numeroPrueba)
        {
            try
            {
                cmbPregunta.Items.Clear();

                MySqlCommand buscar = new MySqlCommand("SELECT UPPER(p.Descripcion) FROM `pregunta` p JOIN pruebapreguntas pp ON pp.IdPregunta = p.Id JOIN prueba pr ON pr.NumPrueba = pp.num_prueba WHERE pr.NumPrueba = '" + numeroPrueba + "' ORDER BY p.Descripcion;", conexion.getConnection());

                MySqlDataReader leer = buscar.ExecuteReader();
                while (leer.Read())
                {
                    cmbPregunta.Items.Add(leer[0].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void mostrarSede(ComboBox cmbSede)
        {
            try
            {
                cmbSede.Items.Clear();

                MySqlCommand buscar = new MySqlCommand("SELECT UPPER(Nombre) FROM `sede` ORDER BY Nombre;", conexion.getConnection());

                MySqlDataReader leer = buscar.ExecuteReader();
                while (leer.Read())
                {
                    cmbSede.Items.Add(leer[0].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void mostrarDepartamento(ComboBox cmbDepartamento)
        {
            try
            {
                cmbDepartamento.Items.Clear();
                MySqlCommand buscar = new MySqlCommand("SELECT UPPER(nombre) FROM `departamento` ORDER BY nombre;", conexion.getConnection());

                MySqlDataReader leer = buscar.ExecuteReader();
                while (leer.Read())
                {
                    cmbDepartamento.Items.Add(leer[0].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void mostrarCiudad(ComboBox cmbCiudad, string departamento)
        {
            try
            {
                cmbCiudad.Items.Clear();

                MySqlCommand buscar = new MySqlCommand("SELECT UPPER(c.nombre) FROM `ciudad` c JOIN departamento d ON d.codigo = c.codDpto WHERE d.Nombre = '" + departamento + "' ORDER BY c.nombre;", conexion.getConnection());

                MySqlDataReader leer = buscar.ExecuteReader();
                while (leer.Read())
                {
                    cmbCiudad.Items.Add(leer[0].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void camposEditarDocente(string documento, ComboBox cmbTipoDocumento, TextBox txtNumeroDocumento, TextBox txtNombre, TextBox txtApellido, TextBox txtTitulo, TextBox txtCorreo, TextBox txtClave, ComboBox cmbEstado)
        {
            try
            {
                MySqlCommand consulta = new MySqlCommand("SELECT p.Tipo_ident as \"Tipo Documento\",p.Ident_num as \"Número Documento\",p.Nombre,p.Apellido,p.Titulo,u.Correo,p.Estado FROM persona p JOIN usuarios u ON u.Id = p.idUsuario WHERE UPPER(u.Rol) = 'DOCENTE' and p.Ident_num = '" + documento + "';", conexion.getConnection());

                MySqlDataReader leer = consulta.ExecuteReader();
                if (leer.Read())
                {
                    cmbTipoDocumento.Text = leer[0].ToString();
                    txtNumeroDocumento.Text = leer[1].ToString();
                    txtNombre.Text = leer[2].ToString();
                    txtApellido.Text = leer[3].ToString();
                    txtTitulo.Text = leer[4].ToString();
                    txtCorreo.Text = leer[5].ToString();
                    if (leer[6].ToString() == "1")
                    {
                        cmbEstado.Text = "Activo";
                    }
                    else
                    {
                        cmbEstado.Text = "Inactivo";
                    }

                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void camposEditarAdministrador(string documento, ComboBox cmbTipoDocumento, TextBox txtNumeroDocumento, TextBox txtNombre, TextBox txtApellido, TextBox txtTitulo, TextBox txtCorreo, TextBox txtClave, ComboBox cmbEstado)
        {

            MySqlCommand consulta = new MySqlCommand("SELECT p.Tipo_ident as \"Tipo Documento\",p.Ident_num as \"Número Documento\",p.Nombre,p.Apellido,p.Titulo,u.Correo,p.Estado FROM persona p JOIN usuarios u ON u.Id = p.idUsuario WHERE UPPER(u.Rol) = 'ADMINISTRADOR' and p.Ident_num = '" + documento + "';", conexion.getConnection());

            MySqlDataReader leer = consulta.ExecuteReader();
            if (leer.Read())
            {
                cmbTipoDocumento.Text = leer[0].ToString();
                txtNumeroDocumento.Text = leer[1].ToString();
                txtNombre.Text = leer[2].ToString();
                txtApellido.Text = leer[3].ToString();
                txtTitulo.Text = leer[4].ToString();
                txtCorreo.Text = leer[5].ToString();
                if (leer[6].ToString() == "1")
                {
                    cmbEstado.Text = "Activo";
                }
                else
                {
                    cmbEstado.Text = "Inactivo";
                }
            }
            conexion.offConnection();


        }
        public static void camposEditarPregunta(string descripcionPregunta, TextBox txtTitulo, TextBox txtEnunciado, TextBox txtPregunta, ComboBox cmbCompetencia, TextBox opcion1, TextBox opcion2, TextBox opcion3, TextBox opcion4, RadioButton opcioncorrecta1, RadioButton opcioncorrecta2, RadioButton opcioncorrecta3, RadioButton opcioncorrecta4)
        {
            int retornoRespuestaCorresta = -1;
            try
            {
                MySqlCommand consulta = new MySqlCommand("select e.Titulo, e.Descripcion, p.Descripcion, c.Nombre FROM enunciado e JOIN pregunta p ON p.Id_Enunciado = e.Id JOIN competencias c ON c.Id = p.idCompetencia where p.Descripcion = '" + descripcionPregunta + "';", conexion.getConnection());
                MySqlDataReader leer = consulta.ExecuteReader();
                if (leer.Read())
                {
                    txtTitulo.Text = leer[0].ToString();
                    txtEnunciado.Text = leer[1].ToString();
                    txtPregunta.Text = leer[2].ToString();
                    cmbCompetencia.Text = leer[3].ToString();
                }
                conexion.offConnection();
                MySqlCommand consultaOpcion1 = new MySqlCommand("select o.descripcion, po.Opc_correcta from opciones o JOIN preguntaopciones po ON po.Id_Opciones = o.Id JOIN pregunta p ON p.Id = po.Id_Pregunta WHERE UPPER(p.Descripcion) LIKE ('" + descripcionPregunta + "');", conexion.getConnection());
                MySqlDataReader leerOpcion1 = consultaOpcion1.ExecuteReader();
                if (leerOpcion1.Read())
                {
                    opcion1.Text = leerOpcion1[0].ToString();
                    retornoRespuestaCorresta = Convert.ToInt32(leerOpcion1[1].ToString());
                    if (retornoRespuestaCorresta == 1)
                    {
                        opcioncorrecta1.Checked = true;
                    }
                }
                conexion.offConnection();
                MySqlCommand consultaOpcion2 = new MySqlCommand("select o.descripcion, po.Opc_correcta from opciones o JOIN preguntaopciones po ON po.Id_Opciones = o.Id JOIN pregunta p ON p.Id = po.Id_Pregunta WHERE UPPER(p.Descripcion) LIKE ('" + descripcionPregunta + "') and UPPER(o.descripcion) NOT LIKE ('" + opcion1.Text + "');", conexion.getConnection());
                MySqlDataReader leerOpcion2 = consultaOpcion2.ExecuteReader();
                if (leerOpcion2.Read())
                {
                    opcion2.Text = leerOpcion2[0].ToString();
                    retornoRespuestaCorresta = Convert.ToInt32(leerOpcion2[1].ToString());
                    if (retornoRespuestaCorresta == 1)
                    {
                        opcioncorrecta2.Checked = true;
                    }
                }
                conexion.offConnection();
                MySqlCommand consultaOpcion3 = new MySqlCommand("select o.descripcion, po.Opc_correcta from opciones o JOIN preguntaopciones po ON po.Id_Opciones = o.Id JOIN pregunta p ON p.Id = po.Id_Pregunta WHERE UPPER(p.Descripcion) LIKE ('" + descripcionPregunta + "') and UPPER(o.descripcion) NOT LIKE ('" + opcion1.Text + "') and UPPER(o.descripcion) NOT LIKE ('" + opcion2.Text + "');", conexion.getConnection());
                MySqlDataReader leerOpcion3 = consultaOpcion3.ExecuteReader();
                if (leerOpcion3.Read())
                {
                    opcion3.Text = leerOpcion3[0].ToString();
                    retornoRespuestaCorresta = Convert.ToInt32(leerOpcion3[1].ToString());
                    if (retornoRespuestaCorresta == 1)
                    {
                        opcioncorrecta3.Checked = true;
                    }
                }
                conexion.offConnection();
                MySqlCommand consultaOpcion4 = new MySqlCommand("select o.descripcion, po.Opc_correcta from opciones o JOIN preguntaopciones po ON po.Id_Opciones = o.Id JOIN pregunta p ON p.Id = po.Id_Pregunta WHERE UPPER(p.Descripcion) LIKE ('" + descripcionPregunta + "') and UPPER(o.descripcion) NOT LIKE ('" + opcion1.Text + "') and UPPER(o.descripcion) NOT LIKE ('" + opcion2.Text + "') and UPPER(o.descripcion) NOT LIKE ('" + opcion3.Text + "');", conexion.getConnection());
                MySqlDataReader leerOpcion4 = consultaOpcion4.ExecuteReader();
                if (leerOpcion4.Read())
                {
                    opcion4.Text = leerOpcion4[0].ToString();
                    retornoRespuestaCorresta = Convert.ToInt32(leerOpcion4[1].ToString());
                    if (retornoRespuestaCorresta == 1)
                    {
                        opcioncorrecta4.Checked = true;
                    }
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void camposEditarEstudiante(string documento, ComboBox cmbTipoDocumento, TextBox txtNumeroDocumento, TextBox txtNombre, TextBox txtApellido, TextBox txtCorreo, TextBox txtClave, TextBox txtDireccion, TextBox txtBarrio, TextBox txtTelefono, ComboBox cmbGenero)
        {
            try
            {

                MySqlCommand consulta = new MySqlCommand("SELECT e.Tipo_ident as \"Tipo Documento\", e.Ident_num as \"Numero Documento\", u.correo, e.Dir_numero, e.Nombre, e.Apellido,  e.Dir_barrio, e.Teléfono, e.Genero FROM estudiante e JOIN usuarios u ON u.id = e.idUsuario WHERE e.Ident_num = " + documento + " and UPPER(u.Rol) = 'ESTUDIANTE';", conexion.getConnection());

                MySqlDataReader leer = consulta.ExecuteReader();
                if (leer.Read())
                {
                    cmbTipoDocumento.Text = leer[0].ToString();
                    txtNumeroDocumento.Text = leer[1].ToString();
                    txtCorreo.Text = leer[2].ToString();
                    txtDireccion.Text = leer[3].ToString();
                    txtNombre.Text = leer[4].ToString();
                    txtApellido.Text = leer[5].ToString();
                    txtBarrio.Text = leer[6].ToString();
                    txtTelefono.Text = leer[7].ToString();
                    cmbGenero.Text = leer[8].ToString();
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static int actualizarPerfilEstudiante(string nombre, string apellido, string clave, string direccion, string barrio, string telefono)
        {
            //Variable auxiliar para verificar si el dato se hizo con exito
            int retorno = 0, retornoUsuario = 0, retornoEstudiante = 0;

            try
            {
                //Creando Objeto
                Estudiante estudiante = new Estudiante();
                estudiante.setNombre(nombre);
                estudiante.setApellido(apellido);
                estudiante.setNumeroDireccion(direccion);
                estudiante.setClave(clave);
                estudiante.setBarrio(barrio);
                estudiante.setTelefono(telefono);
                MySqlCommand actualizarUsuario = new MySqlCommand("UPDATE `usuarios` SET `Clave`='" + estudiante.getClave() + "' where correo = '" + Program.cacheUsuarioCorreo + "';", conexion.getConnection());

                retornoUsuario = actualizarUsuario.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand actualizarEstudiante = new MySqlCommand("UPDATE `estudiante` SET `Nombre`='" + estudiante.getNombre() + "',`Apellido`='" + estudiante.getApellido() + "',`Dir_numero`='" + estudiante.getNumeroDireccion() + "',`Dir_barrio`='" + estudiante.getBarrio() + "',`Teléfono`='" + estudiante.getTelefono() + "' WHERE `Ident_num`='" + Program.cacheUsuarioNumeroIdentidad + "';", conexion.getConnection());

                retornoEstudiante = actualizarEstudiante.ExecuteNonQuery();
                if (retornoUsuario > 0 || retornoEstudiante > 0)
                {
                    retorno = 1;
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            return retorno;
        }

        public static int actualizarPerfilDocente(string nombre, string apellido, string clave, string titulo)
        {
            //Variable auxiliar para verificar si el dato se hizo con exito
            int retorno = 0, retornoUsuario = 0, retornoDocente = 0;

            try
            {
                //Creando Objeto
                Persona docente = new Persona();
                docente.setNombre(nombre);
                docente.setApellido(apellido);
                docente.setTitulo(titulo);
                docente.setClave(clave);
                MySqlCommand actualizarUsuario = new MySqlCommand("UPDATE `usuarios` SET `Clave`='" + docente.getClave() + "' where correo = '" + Program.cacheUsuarioCorreo + "';", conexion.getConnection());

                retornoUsuario = actualizarUsuario.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand actualizarDocente = new MySqlCommand("UPDATE `persona` SET `Nombre`='" + docente.getNombre() + "',`Apellido`='" + docente.getApellido() + "' WHERE `Ident_num`='" + Program.cacheUsuarioNumeroIdentidad + "';", conexion.getConnection());

                retornoDocente = actualizarDocente.ExecuteNonQuery();
                if (retornoUsuario > 0 || retornoDocente > 0)
                {
                    retorno = 1;
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            return retorno;
        }
        public static void camposEditarPerfilEstudiante(TextBox txtNombre, TextBox txtApellido, TextBox txtClave, TextBox txtDireccion, TextBox txtBarrio, TextBox txtTelefono)
        {
            try
            {

                MySqlCommand consulta = new MySqlCommand("SELECT e.Dir_numero, e.Nombre, e.Apellido,  e.Dir_barrio, e.Teléfono FROM estudiante e JOIN usuarios u ON u.id = e.idUsuario WHERE e.Ident_num = " + Program.cacheUsuarioNumeroIdentidad + " and UPPER(u.Rol) = 'ESTUDIANTE';", conexion.getConnection());

                MySqlDataReader leer = consulta.ExecuteReader();
                if (leer.Read())
                {
                    txtDireccion.Text = leer[0].ToString();
                    txtNombre.Text = leer[1].ToString();
                    txtApellido.Text = leer[2].ToString();
                    txtBarrio.Text = leer[3].ToString();
                    txtTelefono.Text = leer[4].ToString();
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void camposEditarPerfilDocente(TextBox txtNombre, TextBox txtApellido, TextBox txtClave, TextBox txtTitulo)
        {
            try
            {

                MySqlCommand consulta = new MySqlCommand("SELECT p.Nombre,p.Apellido,p.Titulo from persona p JOIN usuarios u ON u.id = p.idUsuario WHERE p.Ident_num = " + Program.cacheUsuarioNumeroIdentidad + " and UPPER(u.Rol) = 'DOCENTE';", conexion.getConnection());

                MySqlDataReader leer = consulta.ExecuteReader();
                if (leer.Read())
                {
                    
                    txtNombre.Text = leer[0].ToString();
                    txtApellido.Text = leer[1].ToString();
                    txtTitulo.Text = leer[2].ToString();
                   
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void devolverPregunta(int numeroPrueba)
        {
            MySqlCommand comando = new MySqlCommand("select DISTINCT e.titulo, e.descripcion, p.descripcion from enunciado e JOIN pregunta p ON p.id_enunciado = e.id JOIN preguntaopciones po ON po.Id_Pregunta = p.Id JOIN opciones o ON o.Id = po.Id_Opciones JOIN pruebapreguntas pp ON pp.IdPregunta = p.Id JOIN prueba pr ON pr.NumPrueba = pp.num_prueba where pr.NumPrueba =" + numeroPrueba + ";", conexion.getConnection());
            MySqlDataReader leer = comando.ExecuteReader();
            /*if (leer.Read()) {
                lblTitulo.Text = leer[0].ToString();
                lblEnunciado.Text = leer[1].ToString();
                lblPregunta.Text = leer[2].ToString();
            }*/
            while (leer.Read())
            {
                Program.listaTitulos.Add(leer[0].ToString());
                Program.listaEnunciados.Add(leer[1].ToString());
                Program.listaPreguntas.Add(leer[2].ToString());
            }
            conexion.offConnection();
        }
        public static void devolverOpciones(int numeroPrueba)
        {
            MySqlCommand comando = new MySqlCommand("select o.descripcion from enunciado e JOIN pregunta p ON p.id_enunciado = e.id JOIN preguntaopciones po ON po.Id_Pregunta = p.Id JOIN opciones o ON o.Id = po.Id_Opciones JOIN pruebapreguntas pp ON pp.IdPregunta = p.Id JOIN prueba pr ON pr.NumPrueba = pp.num_prueba where pr.NumPrueba = " + numeroPrueba + ";", conexion.getConnection());
            MySqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                Program.listaOpciones.Add(leer[0].ToString());
            }
            conexion.offConnection();
        }
        public static int devolverCantidadPreguntasPrueba1()
        {
            int cantidad = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand("select count(p.id) as 'cantidad' from enunciado e JOIN pregunta p ON p.id_enunciado = e.id JOIN pruebapreguntas pp ON pp.IdPregunta = p.Id JOIN prueba pr ON pr.NumPrueba = pp.num_prueba where pr.NumPrueba = 1;", conexion.getConnection());
                MySqlDataReader cantidadPreguntas = comando.ExecuteReader();
                if (cantidadPreguntas.Read())
                {
                    cantidad = Convert.ToInt16(cantidadPreguntas["cantidad"].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return cantidad;
        }
        public static int devolverCantidadPreguntasPrueba2()
        {
            int cantidad = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand("select count(p.id) as 'cantidad' from enunciado e JOIN pregunta p ON p.id_enunciado = e.id JOIN pruebapreguntas pp ON pp.IdPregunta = p.Id JOIN prueba pr ON pr.NumPrueba = pp.num_prueba where pr.NumPrueba = 2;", conexion.getConnection());
                MySqlDataReader cantidadPreguntas = comando.ExecuteReader();
                if (cantidadPreguntas.Read())
                {
                    cantidad = Convert.ToInt16(cantidadPreguntas["cantidad"].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return cantidad;
        }
        public static int devolverCantidadPreguntasPrueba3()
        {
            int cantidad = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand("select count(p.id) as 'cantidad' from enunciado e JOIN pregunta p ON p.id_enunciado = e.id JOIN pruebapreguntas pp ON pp.IdPregunta = p.Id JOIN prueba pr ON pr.NumPrueba = pp.num_prueba where pr.NumPrueba = 3;", conexion.getConnection());
                MySqlDataReader cantidadPreguntas = comando.ExecuteReader();
                if (cantidadPreguntas.Read())
                {
                    cantidad = Convert.ToInt16(cantidadPreguntas["cantidad"].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return cantidad;
        }
        public static int devolverCantidadPreguntasPrueba4()
        {
            int cantidad = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand("select count(p.id) as 'cantidad' from enunciado e JOIN pregunta p ON p.id_enunciado = e.id JOIN pruebapreguntas pp ON pp.IdPregunta = p.Id JOIN prueba pr ON pr.NumPrueba = pp.num_prueba where pr.NumPrueba = 4;", conexion.getConnection());
                MySqlDataReader cantidadPreguntas = comando.ExecuteReader();
                if (cantidadPreguntas.Read())
                {
                    cantidad = Convert.ToInt16(cantidadPreguntas["cantidad"].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return cantidad;
        }
        public static int devolverCantidadPreguntasPrueba5()
        {
            int cantidad = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand("select count(p.id) as 'cantidad' from enunciado e JOIN pregunta p ON p.id_enunciado = e.id JOIN pruebapreguntas pp ON pp.IdPregunta = p.Id JOIN prueba pr ON pr.NumPrueba = pp.num_prueba where pr.NumPrueba = 5;", conexion.getConnection());
                MySqlDataReader cantidadPreguntas = comando.ExecuteReader();
                if (cantidadPreguntas.Read())
                {
                    cantidad = Convert.ToInt16(cantidadPreguntas["cantidad"].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return cantidad;
        }
        public static int devolverCantidadPreguntasPrueba6()
        {
            int cantidad = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand("select count(p.id) as 'cantidad' from enunciado e JOIN pregunta p ON p.id_enunciado = e.id JOIN pruebapreguntas pp ON pp.IdPregunta = p.Id JOIN prueba pr ON pr.NumPrueba = pp.num_prueba where pr.NumPrueba = 6;", conexion.getConnection());
                MySqlDataReader cantidadPreguntas = comando.ExecuteReader();
                if (cantidadPreguntas.Read())
                {
                    cantidad = Convert.ToInt16(cantidadPreguntas["cantidad"].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return cantidad;
        }
        public static int iniciarSesion(string correo, string clave)
        {
            int estado = -1;
            string rol = "";
            int retorno = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand("select UPPER(rol) from usuarios where correo = '" + correo + "';", conexion.getConnection());
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    rol = leer[0].ToString();
                }
                conexion.offConnection();
                IEncriptar miEncriptado = new encriptarEstudiante();

                if (rol == "DOCENTE")
                {
                    miEncriptado = new encriptarDocente();
                    MySqlCommand comandoNombreCompleto = new MySqlCommand("select p.nombre, p.apellido, p.Ident_num,u.correo FROM persona p JOIN usuarios u ON u.id = p.idUsuario where u.correo = '" + correo + "';", conexion.getConnection());
                    MySqlDataReader leerNombreCompleto = comandoNombreCompleto.ExecuteReader();
                    if (leerNombreCompleto.Read())
                    {
                        Program.cacheUsuarioNombre = leerNombreCompleto[0].ToString();
                        Program.cacheUsuarioApellido = leerNombreCompleto[1].ToString();
                        Program.cacheUsuarioNumeroIdentidad = leerNombreCompleto[2].ToString();
                        Program.cacheUsuarioCorreo = leerNombreCompleto[3].ToString();

                    }
                    conexion.offConnection();
                    MySqlCommand comandoEstado = new MySqlCommand("select estado from persona where Ident_num LIKE ('" + Program.cacheUsuarioNumeroIdentidad + "');", conexion.getConnection());
                    MySqlDataReader leerEstado = comandoEstado.ExecuteReader();
                    if (leerEstado.Read())
                    {
                        estado = Convert.ToInt32(leerEstado[0]);
                    }
                    conexion.offConnection();
                }
                else if (rol == "ADMINISTRADOR")
                {
                    MySqlCommand comandoNombreCompleto = new MySqlCommand("select p.nombre, p.apellido, p.Ident_num,u.correo FROM persona p JOIN usuarios u ON u.id = p.idUsuario where u.correo = '" + correo + "';", conexion.getConnection());
                    MySqlDataReader leerNombreCompleto = comandoNombreCompleto.ExecuteReader();
                    if (leerNombreCompleto.Read())
                    {
                        Program.cacheUsuarioNombre = leerNombreCompleto[0].ToString();
                        Program.cacheUsuarioApellido = leerNombreCompleto[1].ToString();
                        Program.cacheUsuarioNumeroIdentidad = leerNombreCompleto[2].ToString();
                        Program.cacheUsuarioCorreo = leerNombreCompleto[3].ToString();

                    }
                    conexion.offConnection();
                    miEncriptado = new encriptarAdministrador();
                    MySqlCommand comandoEstado = new MySqlCommand("select estado from persona where Ident_num LIKE ('" + Program.cacheUsuarioNumeroIdentidad + "');", conexion.getConnection());
                    MySqlDataReader leerEstado = comandoEstado.ExecuteReader();
                    if (leerEstado.Read())
                    {
                        estado = Convert.ToInt32(leerEstado[0]);
                    }
                    conexion.offConnection();
                }
                else if (rol == "ESTUDIANTE")
                {
                    miEncriptado = new encriptarEstudiante();
                    MySqlCommand comandoNombreCompleto = new MySqlCommand("select e.nombre, e.apellido, e.Ident_num,u.correo FROM estudiante e JOIN usuarios u ON u.id = e.idUsuario where u.correo = '" + correo + "';", conexion.getConnection());
                    MySqlDataReader leerNombreCompleto = comandoNombreCompleto.ExecuteReader();
                    if (leerNombreCompleto.Read())
                    {
                        Program.cacheUsuarioNombre = leerNombreCompleto[0].ToString();
                        Program.cacheUsuarioApellido = leerNombreCompleto[1].ToString();
                        Program.cacheUsuarioNumeroIdentidad = leerNombreCompleto[2].ToString();
                        Program.cacheUsuarioCorreo = leerNombreCompleto[3].ToString();

                    }
                    conexion.offConnection();
                }
                string encriparClave = miEncriptado.encriptar(clave);
                MySqlCommand comandoClave = new MySqlCommand("select * from usuarios where correo = '" + correo + "' and clave = '" + encriparClave + "';", conexion.getConnection());
                MySqlDataReader leerClave = comandoClave.ExecuteReader();
                if (leerClave.Read())
                {
                    if (rol == "ESTUDIANTE")
                    {
                        retorno = 1;
                    }
                    else if (rol == "DOCENTE")
                    {
                        retorno = 2;
                    }
                    else if (rol == "ADMINISTRADOR")
                    {
                        retorno = 3;
                    }
                }
                conexion.offConnection();
                if (estado == 0) {
                    retorno = -1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return retorno;
        }
        public static int agregarEstudiantePrueba(int numeroPrueba)
        {
            int retorno = 0;

            MySqlCommand ingresarEstudiantePrueba = new MySqlCommand("INSERT INTO `estudianteprueba`(`Id`, `Ident_num_estud`, `NumPrueba`) VALUES (NULL," + Program.cacheUsuarioNumeroIdentidad + "," + numeroPrueba + ");", conexion.getConnection());
            retorno = ingresarEstudiantePrueba.ExecuteNonQuery();
            conexion.offConnection();

            return retorno;
        }
        public static int[] devolverIdPregunta(int numeroPrueba)
        {
            int[] idPregunta = new int[20];
            int i = 0;

            MySqlCommand buscarIdPregunta = new MySqlCommand("select p.id from pregunta p JOIN pruebapreguntas pp ON pp.IdPregunta = p.Id JOIN prueba pr ON pr.NumPrueba = pp.num_prueba where pr.NumPrueba = "+numeroPrueba+";", conexion.getConnection());
            MySqlDataReader leerIdPregunta = buscarIdPregunta.ExecuteReader();
            while (leerIdPregunta.Read()) {
                idPregunta[i] = Convert.ToInt32(leerIdPregunta[0]);
                i++;
            }
            conexion.offConnection();

            return idPregunta;
        }
        public static int agregarEstudiantePregunta(int opcionEstudiante, int numeroPregunta)
        {
            int retorno = 0;

            MySqlCommand ingresarEstudiantePregunta = new MySqlCommand("INSERT INTO `estudiantepregunta`(`Id`, `Opc_estudiante`, `Ident_Estud`, `IdPregunta`) VALUES (NULL," + opcionEstudiante + "," + Program.cacheUsuarioNumeroIdentidad + "," + numeroPregunta + ");", conexion.getConnection());
            retorno = ingresarEstudiantePregunta.ExecuteNonQuery();
            conexion.offConnection();

            return retorno;
        }
        public static void presentarNombreCantidad(Label nombre, Label contador)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("CALL _query_res_est('" + Program.cacheUsuarioNumeroIdentidad + "','','query_1');", conexion.getConnection());
                MySqlDataReader leerNombre = comando.ExecuteReader();
                if (leerNombre.Read())
                {
                    nombre.Text = leerNombre[0].ToString();
                    contador.Text = leerNombre[1].ToString();
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public static int presentarCantidadPruebas()
        {
            int cantidad = 0;
            try
            {
                MySqlCommand comando = new MySqlCommand("CALL _query_res_est('" + Program.cacheUsuarioNumeroIdentidad + "','','query_1');", conexion.getConnection());
                MySqlDataReader leerNombre = comando.ExecuteReader();
                if (leerNombre.Read())
                {
                    cantidad = Convert.ToInt32(leerNombre[1]);
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return cantidad;
        }
        public static string resultadosLecturaCritica(string nombrePrueba)
        {
            string resultado = "";
            try
            {
                MySqlCommand comando = new MySqlCommand("CALL _query_res_est('" + Program.cacheUsuarioNumeroIdentidad + "','" + nombrePrueba + "','query_2_c1');", conexion.getConnection());
                MySqlDataReader leerPreguntasCorrectas = comando.ExecuteReader();
                if (leerPreguntasCorrectas.Read())
                {
                    resultado = leerPreguntasCorrectas[1].ToString() + " / " + leerPreguntasCorrectas[0].ToString();
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return resultado;
        }
        public static string resultadosCuantitativo(string nombrePrueba)
        {
            string resultado = "";
            try
            {
                MySqlCommand comando = new MySqlCommand("CALL _query_res_est('" + Program.cacheUsuarioNumeroIdentidad + "','" + nombrePrueba + "','query_2_c3');", conexion.getConnection());
                MySqlDataReader leerPreguntasCorrectas = comando.ExecuteReader();
                if (leerPreguntasCorrectas.Read())
                {
                    resultado = leerPreguntasCorrectas[1].ToString() + " / " + leerPreguntasCorrectas[0].ToString();
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return resultado;
        }
        public static string resultadosCompetencia(string nombrePrueba)
        {
            string resultado = "";
            try
            {
                MySqlCommand comando = new MySqlCommand("CALL _query_res_est('" + Program.cacheUsuarioNumeroIdentidad + "','" + nombrePrueba + "','query_2_c2');", conexion.getConnection());
                MySqlDataReader leerPreguntasCorrectas = comando.ExecuteReader();
                if (leerPreguntasCorrectas.Read())
                {
                    resultado = leerPreguntasCorrectas[1].ToString() + " / " + leerPreguntasCorrectas[0].ToString();
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return resultado;
        }
        public static string resultadosIngles(string nombrePrueba)
        {
            string resultado = "";
            try
            {
                MySqlCommand comando = new MySqlCommand("CALL _query_res_est('" + Program.cacheUsuarioNumeroIdentidad + "','" + nombrePrueba + "','query_2_c4');", conexion.getConnection());
                MySqlDataReader leerPreguntasCorrectas = comando.ExecuteReader();
                if (leerPreguntasCorrectas.Read())
                {
                    resultado = leerPreguntasCorrectas[1].ToString() + " / " + leerPreguntasCorrectas[0].ToString();
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return resultado;
        }
        public static string resultadosTotal(string nombrePrueba)
        {
            string resultado = "";
            try
            {
                MySqlCommand comando = new MySqlCommand("CALL _query_res_est('','" + nombrePrueba + "','query_3');", conexion.getConnection());
                MySqlDataReader leerPreguntasTotales = comando.ExecuteReader();
                if (leerPreguntasTotales.Read())
                {
                    resultado = leerPreguntasTotales[0].ToString();
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return resultado;
        }
        public static string preguntaMasPrueba()
        {
            string resultado = "";
            try
            {
                MySqlCommand comando = new MySqlCommand("CALL query_res_doc('','','','','query_1');", conexion.getConnection());
                MySqlDataReader leerPreguntasTotales = comando.ExecuteReader();
                if (leerPreguntasTotales.Read())
                {
                    resultado = leerPreguntasTotales[0].ToString();
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return resultado;
        }
        public static string enunciadoMasPreguntas()
        {
            string resultado = "";
            try
            {
                MySqlCommand comando = new MySqlCommand("CALL query_res_doc('','','','','query_2');", conexion.getConnection());
                MySqlDataReader leerPreguntasTotales = comando.ExecuteReader();
                if (leerPreguntasTotales.Read())
                {
                    resultado = leerPreguntasTotales[0].ToString();
                }
                conexion.offConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return resultado;
        }

        public static DataTable resultadoEstudiantes(string nombrePrueba)
        {
            DataTable registroAdministrador = new DataTable();
            string numeroPrueba = "";
            try
            {
                MySqlCommand comandoBuscaId = new MySqlCommand("select NumPrueba from prueba where UPPER(Titulo) LIKE ('" + nombrePrueba + "');", conexion.getConnection());
                MySqlDataReader leerId = comandoBuscaId.ExecuteReader();
                if (leerId.Read())
                {
                    numeroPrueba = leerId[0].ToString();
                }
                conexion.offConnection();
                string consulta = "CALL query_res_doc('" + nombrePrueba + "','','','" + numeroPrueba + "','query_3');";
                MySqlDataAdapter cargar = new MySqlDataAdapter(consulta, conexion.getConnection());
                registroAdministrador.Clear();
                cargar.Fill(registroAdministrador);
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return registroAdministrador;
        }
        public static DataTable devolverRango(string fechaInicio, string fechaFinal)
        {
            DataTable registroTop = new DataTable();
            try
            {
                string consulta = "CALL query_res_doc('','"+fechaInicio+"','"+fechaFinal+"','','query_4')";
                MySqlDataAdapter cargar = new MySqlDataAdapter(consulta, conexion.getConnection());
                registroTop.Clear();
                cargar.Fill(registroTop);
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return registroTop;
        }
        public static DataTable resultadoTop(string nombrePrueba)
        {
            DataTable registroTop = new DataTable();
            try
            {
                string consulta = "CALL query_res_doc('" + nombrePrueba + "','','','','query_5');";
                MySqlDataAdapter cargar = new MySqlDataAdapter(consulta, conexion.getConnection());
                registroTop.Clear();
                cargar.Fill(registroTop);
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return registroTop;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CRUD
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Load);
            this.ResumeLayout(false);

        }

        private void CRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
