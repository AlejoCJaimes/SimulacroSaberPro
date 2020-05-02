using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaLogicaNegocios
{
    public class Persona : Usuario
    {
        string numeroIdentidad;
        string tipoDocumento;
        string nombre;
        string apellido;
        string titulo;
        int estado;
        Usuario id_usuario = new Usuario();//Llave Foranea
        public Persona()
        {

        }

        //SETTERS
        public void setTipoDocumento(string tipoDocumento)
        {
            this.tipoDocumento = tipoDocumento;
        }
        public void setNumeroIdentidad(string numeroIdentidad)
        {
            this.numeroIdentidad = numeroIdentidad;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public void setEstado(int estado)
        {
            this.estado = estado;
        }
        public void setId_Usuario(Usuario id_usuario)
        {
            this.id_usuario = id_usuario;
        }
        //GETTERS
        public string getTipoDocumento()
        {
            return tipoDocumento;
        }
        public string getNumeroIdentidad()
        {
            return numeroIdentidad;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
        public string getTitulo()
        {
            return titulo;
        }
        public int getEstado()
        {
            return estado;
        }
        public Usuario getId_Usuario()
        {
            return id_usuario;
        }

        //UTILIDADES BASE DE DATOS
        static CD_Conexion conexion = CD_Conexion.getInstancia();

        public static bool verificarDocumento(string documento)
        {
            bool retorno = false;
            try
            {
                MySqlCommand buscarDocumento = new MySqlCommand("SELECT Ident_num FROM `persona` WHERE Ident_num = '" + documento + "';", conexion.getConnection());
                MySqlDataReader documentoEstudiante = buscarDocumento.ExecuteReader();
                if (documentoEstudiante.Read())
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return retorno;
        }
        public static int agregarDocente(string tipoDocumento, string numeroDocumento, string nombre, string apellido, string titulo, string correo, string clave)
        {
            int retorno = 0, retornoUsuario = 0, retornoDocente = 0;
            try
            {
                Persona persona = new Persona();
                persona.setTipoDocumento(tipoDocumento);
                persona.setNumeroIdentidad(numeroDocumento);
                persona.setNombre(nombre);
                persona.setApellido(apellido);
                persona.setTitulo(titulo);
                persona.setCorreo(correo);
                persona.setClave(clave);
                persona.setEstado(1);
                persona.setRol("Docente");
                int id = -1;

                if (verificarDocumento(persona.getTipoDocumento()) == false)
                {
                    MySqlCommand insertarUsuario = new MySqlCommand("INSERT INTO `usuarios`(`Id`, `Correo`, `Clave`, `Rol`) VALUES (NULL,'" + persona.getCorreo() + "','" + persona.getClave() + "','" + persona.getRol() + "');", conexion.getConnection());
                    retornoUsuario = insertarUsuario.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand buscarId = new MySqlCommand("SELECT * FROM `usuarios` WHERE correo = '" + persona.getCorreo() + "';", conexion.getConnection());
                    MySqlDataReader idUsuario = buscarId.ExecuteReader();
                    if (idUsuario.Read())
                    {
                        id = Convert.ToInt32(idUsuario["Id"]);
                        conexion.offConnection();
                        MySqlCommand insertarDocente = new MySqlCommand("INSERT INTO `persona`(`Ident_num`, `Tipo_ident`, `Nombre`, `Apellido`, `Titulo`, `Estado`, `idUsuario`) VALUES('" + persona.getNumeroIdentidad() + "', '" + persona.getTipoDocumento() + "', '" + persona.getNombre() + "', '" + persona.getApellido() + "', '" + persona.getTitulo() + "', " + 1 + ", '" + id + "');", conexion.getConnection());
                        retornoDocente = insertarDocente.ExecuteNonQuery();
                        if (retornoUsuario > 0 && retornoDocente > 0)
                        {
                            retorno = 1;
                        }
                        conexion.offConnection();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return retorno;
        }

        public static int agregarAdministrador(string tipoDocumento, string numeroDocumento, string nombre, string apellido, string titulo, string correo, string clave)
        {
            int retorno = 0, retornoUsuario = 0, retornoAdministrador = 0;
            try
            {
                Persona persona = new Persona();
                persona.setTipoDocumento(tipoDocumento);
                persona.setNumeroIdentidad(numeroDocumento);
                persona.setNombre(nombre);
                persona.setApellido(apellido);
                persona.setTitulo(titulo);
                persona.setEstado(1);
                persona.setCorreo(correo);
                persona.setClave(clave);
                persona.setRol("Administrador");
                string id = "";
                if (verificarDocumento(persona.getNumeroIdentidad()) == false)
                {
                    MySqlCommand insertarUsuario = new MySqlCommand("INSERT INTO `usuarios`(`Id`, `Correo`, `Clave`, `Rol`) VALUES (NULL,'" + persona.getCorreo() + "','" + persona.getClave() + "','" + persona.getRol() + "');", conexion.getConnection());
                    retornoUsuario = insertarUsuario.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand buscarId = new MySqlCommand("SELECT * FROM `usuarios` WHERE correo = '" + persona.getCorreo() + "';", conexion.getConnection());
                    MySqlDataReader idUsuario = buscarId.ExecuteReader();
                    if (idUsuario.Read())
                    {
                        id = idUsuario["Id"].ToString();
                        conexion.offConnection();
                        MySqlCommand insertarDocente = new MySqlCommand("INSERT INTO `persona`(`Ident_num`, `Tipo_ident`, `Nombre`, `Apellido`, `Titulo`, `Estado`, `idUsuario`) VALUES('" + persona.getNumeroIdentidad() + "', '" + persona.getTipoDocumento() + "', '" + persona.getNombre() + "', '" + persona.getApellido() + "', '" + persona.getTitulo() + "', " + 1 + ", '" + id + "');", conexion.getConnection());
                        retornoAdministrador = insertarDocente.ExecuteNonQuery();
                        if (retornoUsuario > 0 && retornoAdministrador > 0)
                        {
                            retorno = 1;
                        }
                        conexion.offConnection();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return retorno;
        }

        public static int actualizarPersona(string buscador, string tipoDocumento, string numeroDocumento, string nombre, string apellido, string titulo, string correo, string clave, int estado)
        {
            //variable auxiliar para verificar si el dato se hizo con exito.
            int retorno = 0, retornoUsuario = 0, retornoPersona = 0;

            try
            {
                //Creando Objeto
                Persona persona = new Persona();
                persona.setTipoDocumento(tipoDocumento);
                persona.setNumeroIdentidad(numeroDocumento);
                persona.setNombre(nombre);
                persona.setApellido(apellido);
                persona.setTitulo(titulo);
                persona.setCorreo(correo);
                persona.setClave(clave);
                persona.setEstado(estado);
                string buscadorCorreo = "";
                MySqlCommand buscarCorreo = new MySqlCommand("SELECT * FROM `usuarios` u JOIN persona p ON p.idUsuario = u.id where p.Ident_num = '" + persona.getNumeroIdentidad() + "'", conexion.getConnection());

                MySqlDataReader correoUsuario = buscarCorreo.ExecuteReader();
                if (correoUsuario.Read())
                {
                    buscadorCorreo = correoUsuario["Correo"].ToString();
                }
                conexion.offConnection();
                MySqlCommand actualizarUsuario = new MySqlCommand("UPDATE `usuarios` SET `Correo`='" + persona.getCorreo() + "',`Clave`='" + persona.getClave() + "' WHERE `Correo`='" + buscadorCorreo + "';", conexion.getConnection());

                retornoUsuario = actualizarUsuario.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand actualizarPersona = new MySqlCommand("UPDATE `persona` SET `Ident_num`='" + numeroDocumento + "',`Tipo_ident`='" + tipoDocumento + "',`Nombre`='" + nombre + "',`Apellido`='" + apellido + "',`Titulo`='" + titulo + "',`Estado`= " + estado + " WHERE `Ident_num` = '" + buscador + "';", conexion.getConnection());

                retornoPersona = actualizarPersona.ExecuteNonQuery();
                if (retornoUsuario > 0 || retornoPersona > 0)
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


        public static void eliminarPersona(string numeroDocumento)
        {
            int retornoPersona = 0, retornoUsuario = 0;
            string buscadorCorreo = "";
            try
            {
                MySqlCommand buscarCorreo = new MySqlCommand("SELECT * FROM `usuarios` u JOIN persona p ON p.idUsuario = u.id where p.Ident_num = '" + numeroDocumento + "'", conexion.getConnection());
                MySqlDataReader correoUsuario = buscarCorreo.ExecuteReader();
                if (correoUsuario.Read())
                {
                    buscadorCorreo = correoUsuario["Correo"].ToString();
                }

                conexion.offConnection();
                MySqlCommand eliminarPersona = new MySqlCommand("DELETE FROM `persona` WHERE Ident_num = '" + numeroDocumento + "';", conexion.getConnection());

                retornoPersona = eliminarPersona.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand eliminarUsuario = new MySqlCommand("DELETE FROM `usuarios` WHERE correo = '" + buscadorCorreo + "';", conexion.getConnection());

                retornoUsuario = eliminarUsuario.ExecuteNonQuery();
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static DataTable vistaDocente()
        {
            DataTable registroDocente = new DataTable();
            try
            {
                string consulta = "SELECT p.Tipo_ident as \"Tipo Documento\",p.Ident_num as \"Numero Documento\",p.Nombre,p.Apellido,p.Titulo,u.Correo,p.Estado FROM persona p JOIN usuarios u ON u.Id = p.idUsuario WHERE UPPER(u.Rol) = 'DOCENTE';";
                MySqlDataAdapter cargar = new MySqlDataAdapter(consulta, conexion.getConnection());
                registroDocente.Clear();
                cargar.Fill(registroDocente);
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return registroDocente;
        }

        public static DataTable vistaDocenteCorreo(string correo)
        {
            DataTable registroDocente = new DataTable();
            try
            {
                string consulta = "SELECT p.Tipo_ident as \"Tipo Documento\",p.Ident_num as \"Número Documento\",p.Nombre,p.Apellido,p.Titulo,u.Correo,p.Estado FROM persona p JOIN usuarios u ON u.Id = p.idUsuario WHERE UPPER(u.Rol) = 'DOCENTE' and u.Correo LIKE ('%" + correo + "%');";
                MySqlDataAdapter cargar = new MySqlDataAdapter(consulta, conexion.getConnection());
                registroDocente.Clear();
                cargar.Fill(registroDocente);
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return registroDocente;
        }
        public static DataTable vistaDocenteDocumento(string documento)
        {
            DataTable registroDocente = new DataTable();
            try
            {
                string consulta = "SELECT p.Tipo_ident as \"Tipo Documento\",p.Ident_num as \"Número Documento\",p.Nombre,p.Apellido,p.Titulo,u.Correo,p.Estado FROM persona p JOIN usuarios u ON u.Id = p.idUsuario WHERE UPPER(u.Rol) = 'DOCENTE' and p.Ident_num LIKE ('%" + documento + "%');";
                MySqlDataAdapter cargar = new MySqlDataAdapter(consulta, conexion.getConnection());
                registroDocente.Clear();
                cargar.Fill(registroDocente);
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            return registroDocente;
        }
        public static DataTable vistaAdministrador()
        {
            DataTable registroAdministrador = new DataTable();
            try
            {
                string consulta = "SELECT p.Tipo_ident as \"Tipo Documento\",p.Ident_num as \"Numero Documento\",p.Nombre,p.Apellido,p.Titulo,u.Correo,p.Estado FROM persona p JOIN usuarios u ON u.Id = p.idUsuario WHERE UPPER(u.Rol) = 'ADMINISTRADOR';";
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
        public static DataTable vistaAdministradorCorreo(string correo)
        {
            DataTable registroAdministrador = new DataTable();
            try
            {
                string consulta = "SELECT p.Tipo_ident as \"Tipo Documento\",p.Ident_num as \"Número Documento\",p.Nombre,p.Apellido,p.Titulo,u.Correo,p.Estado FROM persona p JOIN usuarios u ON u.Id = p.idUsuario WHERE UPPER(u.Rol) = 'ADMINISTRADOR' and u.Correo LIKE ('%" + correo + "%');";
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
        public static DataTable vistaAdministradorDocumento(string documento)
        {
            DataTable registroAdministrador = new DataTable();
            try
            {
                string consulta = "SELECT p.Tipo_ident as \"Tipo Documento\",p.Ident_num as \"Número Documento\",p.Nombre,p.Apellido,p.Titulo,u.Correo,p.Estado FROM persona p JOIN usuarios u ON u.Id = p.idUsuario WHERE UPPER(u.Rol) = 'ADMINISTRADOR' and p.Ident_num LIKE ('%" + documento + "%');";
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
        public static int verificarAdministradores()
        {
            int cantidadUsuarios = 0;
            try
            {
                MySqlCommand contador = new MySqlCommand("SELECT count(*) as 'cantidad' FROM `usuarios` where UPPER(rol) LIKE ('ADMINISTRADOR');", conexion.getConnection());
                MySqlDataReader cantidadAdministradores = contador.ExecuteReader();
                if (cantidadAdministradores.Read())
                {
                    cantidadUsuarios = Convert.ToInt16(cantidadAdministradores["cantidad"].ToString());
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return cantidadUsuarios;
        }

    }
}
