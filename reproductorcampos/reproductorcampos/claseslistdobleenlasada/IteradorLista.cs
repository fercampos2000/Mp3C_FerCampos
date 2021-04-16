using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reproductorcampos.claseslistdobleenlasada
{
    class IteradorLista
    {
        public Nodo actual;

        public IteradorLista(ClsListaDoble id)
        {

            actual = id.cabeza;

        }

        public Nodo siguiente()
        {
      
            Nodo a;
            a = actual;
            if (actual != null)
            {
                actual = actual.adelante;
            }
            return a;
        }
    }
}
