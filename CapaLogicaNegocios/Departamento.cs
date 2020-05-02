using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class Departamento
    {
        int codigo;
        string nombre;
        public Departamento()
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
        //GETTERS
        public int getCodigo()
        {
            return codigo;
        }

        public string getNombre()
        {
            return nombre;
        }
    }
}
