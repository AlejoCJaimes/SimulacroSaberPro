using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocios
{
    public class Enunciado
    {
        int id;
        string titulo;
        string descripcion;
        string grafica;
        public Enunciado()
        {

        }
        //SETTERS
        public void setId(int id)
        {
            this.id = id;
        }
        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public void setGrafica(string grafica)
        {
            this.grafica = grafica;
        }
        //GETTERS
        public int getId()
        {
            return id;
        }
        public string getTitulo()
        {
            return titulo;
        }
        public string getDescripcion()
        {
            return descripcion;
        }
        public string getGrafica()
        {
            return grafica;
        }
    }
}
