using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class Opciones
    {
        int id;
        string descripcion;
        public Opciones()
        {

        }
        //SETTERS
        public void setId(int id)
        {
            this.id = id;
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
        public string getDescripcion()
        {
            return descripcion;
        }
    }
}
