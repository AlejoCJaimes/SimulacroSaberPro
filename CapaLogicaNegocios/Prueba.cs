using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogicaNegocios
{
    public class Prueba
    {
        int numeroPrueba;
        string fechaCreacion;
        string titulo;

        //SETTERS
        public void setNumeroPrueba(int numeroPrueba)
        {
            this.numeroPrueba = numeroPrueba;
        }
        public void setFechaCreacion(string fechaCreacion)
        {
            this.fechaCreacion = fechaCreacion;
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        //GETTERS
        public int getNumeroPrueba(int numeroPrueba)
        {
            return numeroPrueba;
        }
        public string getFechaCreacion(string fechaCreacion)
        {
            return fechaCreacion;
        }
        public string getTitulo(string titulo)
        {
            return titulo;
        }

        //UTILIDADES BASE DE DATOS
        static CD_Conexion conexion = CD_Conexion.getInstancia();

        public static int agregarPrueba(int numeroPrueba, string fecha, string titulo)
        {
            int retorno = 0;
            try
            {
                Prueba prueba = new Prueba();

                prueba.setNumeroPrueba(numeroPrueba);
                prueba.setFechaCreacion(fecha);
                prueba.setTitulo(titulo);

                MySqlCommand insertarPrueba = new MySqlCommand("INSERT INTO `prueba` (`NumPrueba`, `Fecha_creacion`, `Titulo`) VALUES('" + numeroPrueba + "', '" + fecha + "', '" + titulo + "');", conexion.getConnection());

                retorno = insertarPrueba.ExecuteNonQuery();
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
