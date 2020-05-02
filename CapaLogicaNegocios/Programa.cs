using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class Programa
    {
        int codigo;
        string nombre;
        Facultad idFacultad = new Facultad(); //llave foranea
        Sede codSede = new Sede(); //llave foranea
        public Programa()
        {

        }
        //SETTERS
        public void setId(int codigo)
        {
            this.codigo = codigo;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setIdFacultad(Facultad idFacultad)
        {
            this.idFacultad = idFacultad;
        }
        public void setCodSede(Sede codSede)
        {
            this.codSede = codSede;
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
        public Facultad getIdFacultad()
        {
            return idFacultad;
        }
        public Sede getCodSede()
        {
            return codSede;
        }

        //UTILIDADES BASE DE DATOS
        static CD_Conexion conexion = CD_Conexion.getInstancia();
        public static int verCodigoPrograma(string nombre)
        {
            int codigo = -1;
            try
            {
                MySqlCommand buscarCodigo = new MySqlCommand("SELECT codigo FROM `programa` WHERE nombre = '" + nombre + "';", conexion.getConnection());
                MySqlDataReader codPrograma = buscarCodigo.ExecuteReader();
                if (codPrograma.Read())
                {
                    codigo = Convert.ToInt32(codPrograma["Codigo"]);
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
