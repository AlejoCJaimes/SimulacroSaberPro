using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class Ciudad
    {
        int codigo;
        string nombre;
        Departamento codDpto = new Departamento(); //Llave Foranea
        public Ciudad()
        {

        }
        //SETTER
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setCodDpto(Departamento codDpto)
        {
            this.codDpto = codDpto;
        }
        //GETTERS
        public int getCodigo()
        {
            return codigo;
        }
        public string getNombre()
        {
            return nombre;
        }
        public Departamento getCodDpto()
        {
            return codDpto;
        }

        //UTILIDADES BASE DE DATOS
        static CD_Conexion conexion = CD_Conexion.getInstancia();
        public static int verCodigoCiudad(string nombre)
        {
            int codigo = -1;
            try
            {
                MySqlCommand buscarCodigo = new MySqlCommand("SELECT codigo FROM `ciudad` WHERE nombre = '" + nombre + "';", conexion.getConnection());

                MySqlDataReader codCiudad = buscarCodigo.ExecuteReader();
                if (codCiudad.Read())
                {
                    codigo = Convert.ToInt32(codCiudad["Codigo"]);
                }
                conexion.offConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return codigo;
        }
    }
}
