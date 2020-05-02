using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using MySql.Data.MySqlClient;

namespace CapaLogicaNegocios
{
    public interface IEncriptar
    {
        string encriptar(string cadena);
    }
    public class Usuario
    {

        int id;
        string correo;
        string clave;
        string rol;
        public Usuario()
        {

        }
        //SETTERS
        public void setId(int id)
        {
            this.id = id;
        }
        public void setCorreo(string correo)
        {
            this.correo = correo;
        }
        public void setClave(string clave)
        {
            this.clave = clave;
        }

        public void setRol(string rol)
        {
            this.rol = rol;
        }
        //GETTERS
        public int getId()
        {
            return id;
        }
        public string getCorreo()
        {
            return correo;
        }
        public string getClave()
        {
            return clave;
        }
        public string getRol()
        {
            return rol;
        }
        static CD_Conexion conexion = CD_Conexion.getInstancia();
        public static bool verificarCorreo(string correo)
        {
            bool retorno = true;
            try
            {
                MySqlCommand buscarCorreo = new MySqlCommand("SELECT correo FROM `usuarios` WHERE correo = '" + correo + "';", conexion.getConnection());
                MySqlDataReader correoUsuario = buscarCorreo.ExecuteReader();
                if (correoUsuario.Read())
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
    }
}
