using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class Sede
    {
        int codigo;
        string nombre;
        string numeroDireccion;
        string barrio;
        Ciudad cod_ciudad = new Ciudad();//Llave Foranea
        public Sede()
        {

        }
        //SETTERS
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setNumeroDireccion(string dir_numero)
        {
            this.numeroDireccion = dir_numero;
        }

        public void setBarrio(string barrio)
        {
            this.barrio = barrio;
        }
        public void setCiudad(Ciudad cod_ciudad)
        {
            this.cod_ciudad = cod_ciudad;
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
        public string getNumeroDireccion()
        {
            return numeroDireccion;
        }
        public string getBarrio()
        {
            return barrio;
        }
        public Ciudad getCiudad()
        {
            return cod_ciudad;
        }
    }
}
