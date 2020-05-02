using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_Conexion
    {
        private static CD_Conexion instancia; 
            private MySqlConnection conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=simulacro_udi;");
        //private MySqlConnection conexion = new MySqlConnection("server=remotemysql.com;database=ohQNnCd7W7;Uid=ohQNnCd7W7;pwd=Vo4S86g6HL;"); internet
        //private MySqlConnection conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=saberpro;"); local

        private CD_Conexion()
        {

        }

        public static CD_Conexion getInstancia()
        {

            if (instancia == null)
            {
                instancia = new CD_Conexion();
            }

            return instancia;
        }

        public MySqlConnection getConnection()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }


            return conexion;
        }

        public MySqlConnection offConnection()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }


            return conexion;
        }
    }
}
