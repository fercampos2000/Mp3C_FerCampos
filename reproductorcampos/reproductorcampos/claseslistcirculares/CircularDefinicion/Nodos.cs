using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reproductorcampos.claseslistcirculares.CircularDefinicion
{
    public class Nodos
    {
        public string dato;
        public Nodos enlace;

        public Nodos(string entrada)
        {
            dato = entrada;
            enlace = this;
        }
    }
}
