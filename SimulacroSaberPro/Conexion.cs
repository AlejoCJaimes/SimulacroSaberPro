using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaLogicaNegocios;
using System.Windows.Forms;
using System.Data;

namespace SimulacroSaberPro
{
    class Conexion : Form
    {
        private static Conexion instancia;
        private MySqlConnection conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=simulacro_udi;");
        //private MySqlConnection conexion = new MySqlConnection("server=remotemysql.com;database=ohQNnCd7W7;Uid=ohQNnCd7W7;pwd=Vo4S86g6HL;"); internet
        //private MySqlConnection conexion = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=saberpro;"); local
        private Conexion()
        {

        }

        public static Conexion getInstancia()
        {

            if (instancia == null)
            {
                instancia = new Conexion();
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Conexion
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Conexion";
            this.Load += new System.EventHandler(this.Conexion_Load);
            this.ResumeLayout(false);

        }

        private void Conexion_Load(object sender, EventArgs e)
        {

        }
    }
}
