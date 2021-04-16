using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reproductorcampos
{
    public class Nodo
    {
        // aqui solo se cambiaron los datos a string
        public string dato;
        public Nodo enlace;

        public Nodo(string x)
        {
            this.dato = x;
           this. enlace = null;
        }

        public Nodo(string x, Nodo n)
        {

            dato = x;
            enlace = n;
        }

        public string getDato()
        {
            return dato;
        }

        public Nodo getEnlace()
        {
            return enlace;
        }

        public void setEnlace(Nodo enlace)
        {
            this.enlace = enlace;
        }
    }
}
