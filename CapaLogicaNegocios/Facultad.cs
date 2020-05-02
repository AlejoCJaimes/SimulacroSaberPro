using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class Facultad
    {
        int id;
        string nombre;
        public Facultad()
        {

        }
        //SETTERS
        public void setId(int id)
        {
            this.id = id;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
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
    }
}
