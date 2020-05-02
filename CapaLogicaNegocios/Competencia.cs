using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class Competencia
    {
        int id;
        string nombre;
        string descripcion;
        public Competencia()
        {

        }
        //SETTER
        public void setId(int id)
        {
            this.id = id;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        //GETTERS
        public int getId()
        {
            return id;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getDescripcion()
        {
            return descripcion;
        }
    }
}
