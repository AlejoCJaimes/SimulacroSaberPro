using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using MySql.Data.MySqlClient;

namespace CapaLogicaNegocios
{
    public class Estudiante : Usuario
    {
        string numeroIdentidad;
        string tipoDocumento;
        string genero;
        string nombre;
        string apellido;
        DateTime fechaNacimiento;
        string numeroDireccion;
        string barrio;
        string telefono;
        int codPrograma; //Llave Foranea
        int codCiudad; //Llave Foranea
        int idUsuario;  //Llave Foranea

        public Estudiante()
        {

        }

        //SETTERS
        public void setTipoDocumento(string tipoDocumento)
        {
            this.tipoDocumento = tipoDocumento;
        }
        public void setNumeroIdentidad(string ident_numero)
        {
            this.numeroIdentidad = ident_numero;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void setGenero(string genero)
        {
            this.genero = genero;
        }
        public void setFechaNacimiento(DateTime fechanac)
        {
            this.fechaNacimiento = fechanac;
        }
        public void setNumeroDireccion(string numeroDireccion)
        {
            this.numeroDireccion = numeroDireccion;
        }
        public void setBarrio(string barrio)
        {
            this.barrio = barrio;
        }
        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }
        public void setCodPrograma(int codPrograma)
        {
            this.codPrograma = codPrograma;
        }
        public void setCodCiudad(int codCiudad)
        {
            this.codCiudad = codCiudad;
        }
        public void setCodUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
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
        public string getGenero()
        {
            return genero;
        }
        public DateTime getFechaNacimiento()
        {
            return fechaNacimiento;
        }
        public string getNumeroDireccion()
        {
            return numeroDireccion;
        }
        public string getBarrio()
        {
            return barrio;
        }
        public string getTelefono()
        {
            return telefono;
        }
        public int getCodPrograma()
        {
            return codPrograma;
        }
        public int getCodCiudad()
        {
            return codCiudad;
        }
        public int getIdUsuario()
        {
            return idUsuario;
        }

        //UTILIDADES BASE DE DATOS

        static CD_Conexion conexion = CD_Conexion.getInstancia();
        public static bool verificarDocumento(string documento)
        {
            bool retorno = false;
            try
            {
                MySqlCommand buscarDocumento = new MySqlCommand("SELECT Ident_num FROM `estudiante` WHERE Ident_num = '" + documento + "';", conexion.getConnection());
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
        public static int agregarEstudiante(string tipoDocumento, string numeroDocumento, string nombre, string apellido, string genero, string telefono, string fecha, string correo, string clave, string direccion, string barrio, int codCiudad, int codPrograma)
        {
            int retorno = 0, retornoUsuario = 0, retornoEstudiante = 0;

            try
            {
                Estudiante estudiante = new Estudiante();
                estudiante.setTipoDocumento(tipoDocumento);
                estudiante.setNumeroIdentidad(numeroDocumento);
                estudiante.setNombre(nombre);
                estudiante.setApellido(apellido);
                estudiante.setGenero(genero);
                estudiante.setNumeroDireccion(direccion);
                estudiante.setBarrio(barrio);
                estudiante.setTelefono(telefono);
                estudiante.setCorreo(correo);
                estudiante.setClave(clave);
                estudiante.setCodCiudad(codCiudad);
                estudiante.setCodPrograma(codPrograma);
                estudiante.setRol("Estudiante");
                string id = "";
                if (verificarDocumento(estudiante.getNumeroIdentidad()) == false)
                {
                    MySqlCommand insertarUsuario = new MySqlCommand("INSERT INTO `usuarios`(`Id`, `Correo`, `Clave`, `Rol`) VALUES (NULL,'" + estudiante.getCorreo() + "','" + estudiante.getClave() + "','" + estudiante.getRol() + "');", conexion.getConnection());
                    retornoUsuario = insertarUsuario.ExecuteNonQuery();
                    conexion.offConnection();
                    MySqlCommand buscarId = new MySqlCommand("SELECT * FROM `usuarios` WHERE correo = '" + estudiante.getCorreo() + "';", conexion.getConnection());
                    MySqlDataReader idUsuario = buscarId.ExecuteReader();
                    if (idUsuario.Read())
                    {
                        id = idUsuario["Id"].ToString();
                        conexion.offConnection();
                        MySqlCommand insertarEstudiante = new MySqlCommand("INSERT INTO `estudiante`(`Ident_num`, `Tipo_ident`, `Genero`, `Nombre`, `Apellido`, `Fecha_nac`, `Dir_numero`, `Dir_barrio`, `Teléfono`, `codPrograma`, `codCiudad`, `idUsuario`) VALUES ('" + estudiante.getNumeroIdentidad() + "','" + estudiante.getTipoDocumento() + "','" + estudiante.getGenero() + "','" + estudiante.getNombre() + "','" + estudiante.getApellido() + "','" + fecha + "','" + estudiante.getNumeroDireccion() + "','" + estudiante.getBarrio() + "','" + estudiante.getTelefono() + "','" + codPrograma + "','" + codCiudad + "','" + id + "');", conexion.getConnection());
                        retornoEstudiante = insertarEstudiante.ExecuteNonQuery();
                        conexion.offConnection();
                    }


                }
                if (retornoUsuario > 0 && retornoEstudiante > 0)
                {
                    retorno = 1;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return retorno;
        }
        public static int actualizarEstudiante(string buscador, string tipoDocumento, string numeroDocumento, string nombre, string apellido, string correo, string clave, string direccion, string barrio, string telefono, string genero)
        {
            //Variable auxiliar para verificar si el dato se hizo con exito
            int retorno = 0, retornoUsuario = 0, retornoEstudiante = 0;

            try
            {
                //Creando Objeto
                Estudiante estudiante = new Estudiante();
                estudiante.setTipoDocumento(tipoDocumento);
                estudiante.setNumeroIdentidad(numeroDocumento);
                estudiante.setNombre(nombre);
                estudiante.setApellido(apellido);
                estudiante.setGenero(genero);
                estudiante.setNumeroDireccion(direccion);
                estudiante.setBarrio(barrio);
                estudiante.setTelefono(telefono);
                estudiante.setCorreo(correo);
                estudiante.setClave(clave);

                string buscadorCorreo = "";
                MySqlCommand buscarCorreo = new MySqlCommand("SELECT * FROM `usuarios` u JOIN estudiante e ON e.idUsuario = u.id where e.Ident_num = '" + estudiante.getNumeroIdentidad() + "'", conexion.getConnection());

                MySqlDataReader correoUsuario = buscarCorreo.ExecuteReader();
                if (correoUsuario.Read())
                {
                    buscadorCorreo = correoUsuario["correo"].ToString();
                }
                conexion.offConnection();
                MySqlCommand actualizarUsuario = new MySqlCommand("UPDATE `usuarios` SET `Correo`='" + estudiante.getCorreo() + "',`Clave`='" + estudiante.getClave() + "' WHERE `Correo`='" + buscadorCorreo + "';", conexion.getConnection());

                retornoUsuario = actualizarUsuario.ExecuteNonQuery();
                conexion.offConnection();
                MySqlCommand actualizarEstudiante = new MySqlCommand("UPDATE `estudiante` SET `Ident_num`='" + estudiante.getNumeroIdentidad() + "',`Tipo_ident`='" + estudiante.getTipoDocumento() + "',`Genero`='" + estudiante.getGenero() + "',`Nombre`='" + estudiante.getNombre() + "',`Apellido`='" + estudiante.getApellido() + "',`Dir_numero`='" + estudiante.getNumeroDireccion() + "',`Dir_barrio`='" + estudiante.getBarrio() + "',`Teléfono`='" + estudiante.getTelefono() + "' WHERE `Ident_num`='" + buscador + "';", conexion.getConnection());

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

        public static void eliminarEstudiante(string numeroDocumento)
        {
            int retornoEstudiante = 0, retornoUsuario = 0;
            string buscadorCorreo = "";
            try
            {
                MySqlCommand buscarCorreo = new MySqlCommand("SELECT * FROM `usuarios` u JOIN estudiante e ON e.idUsuario = u.id where e.Ident_num = '" + numeroDocumento + "'", conexion.getConnection());
                MySqlDataReader correoUsuario = buscarCorreo.ExecuteReader();
                if (correoUsuario.Read())
                {
                    buscadorCorreo = correoUsuario["Correo"].ToString();
                }
                conexion.offConnection();
                MySqlCommand eliminarEstudiante = new MySqlCommand("DELETE FROM `estudiante` WHERE Ident_num = '" + numeroDocumento + "';", conexion.getConnection());

                retornoEstudiante = eliminarEstudiante.ExecuteNonQuery();
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

        public static DataTable vistaEstudiante()
        {
            DataTable registroAdministrador = new DataTable();
            try
            {
                string consulta = "SELECT e.Tipo_ident as \"Tipo Documento\",e.Ident_num as \"Numero Documento\",e.nombre,e.Apellido,e.Teléfono as Telefono,u.correo FROM `estudiante` e  JOIN usuarios u ON u.Id = e.idUsuario WHERE UPPER(u.Rol) = 'ESTUDIANTE';";
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
        public static DataTable vistaEstudianteCorreo(string correo)
        {
            DataTable registroAdministrador = new DataTable();
            try
            {
                string consulta = "SELECT e.Tipo_ident as \"Tipo Documento\",e.Ident_num as \"Numero Documento\",e.nombre,e.Apellido,e.Teléfono,u.correo FROM `estudiante` e  JOIN usuarios u ON u.Id = e.idUsuario WHERE UPPER(u.Rol) = 'ESTUDIANTE' and u.Correo LIKE ('%" + correo + "%');";
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
        public static DataTable vistaEstudianteDocumento(string documento)
        {
            DataTable registroAdministrador = new DataTable();
            try
            {
                string consulta = "SELECT e.Tipo_ident as \"Tipo Documento\",e.Ident_num as \"Numero Documento\",e.nombre,e.Apellido,e.Teléfono,u.correo FROM `estudiante` e  JOIN usuarios u ON u.Id = e.idUsuario WHERE UPPER(u.Rol) = 'ESTUDIANTE' and e.Ident_num LIKE ('%" + documento + "%');";
                MySqlDataAdapter cargar = new MySqlDataAdapter(consulta, conexion.getConnection());
                registroAdministrador.Clear();
                cargar.Fill(registroAdministrador);
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
            return registroAdministrador;
        }
    }
}
