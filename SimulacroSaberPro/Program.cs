using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogicaNegocios;

namespace SimulacroSaberPro
{
    static class Program
    {
        public static List<string> listaPreguntas = new List<string>();
        public static List<string> listaTitulos= new List<string>();
        public static List<string> listaEnunciados = new List<string>();
        public static List<string> listaOpciones = new List<string>();
        public static string cacheUsuarioNombre;
        public static string cacheUsuarioApellido;
        public static string cacheUsuarioNumeroIdentidad;
        public static string cacheUsuarioCorreo;
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmIniciarSesion());
        }
    }
}
