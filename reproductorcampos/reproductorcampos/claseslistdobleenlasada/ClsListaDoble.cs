using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reproductorcampos.claseslistdobleenlasada
{
    class ClsListaDoble
    {
        public Nodo cabeza;
        public Nodo ultimo;

        public ClsListaDoble()
        {
            cabeza = null;
        }

        public ClsListaDoble insertarcabezaLista(string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            nuevo.adelante = cabeza;

            if (cabeza != null)
            {
                cabeza.atras = nuevo;
            }
            cabeza = nuevo;
            return this;
        }

        public ClsListaDoble insertardespues(Nodo anterior, string entrada)
        {
            Nodo nuevo;
            nuevo = new Nodo(entrada);
            nuevo.adelante = anterior.adelante;

            if (anterior.adelante != null)
            {
                anterior.adelante.atras = nuevo;
            }
            anterior.adelante = nuevo;
            nuevo.atras = anterior;
            return this;
        }


        public void eliminar(string entrada)
        {
            Nodo actual;
            actual = cabeza;
            bool encontrado = false;
            //bucle de busqueda

            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.dato == entrada);
                if (!encontrado)
                {
                    actual = actual.adelante;

                }
            }
            //enlace del nodo anterior con el siguiente

            if (actual != null)
            {
                //distinguir entre nodo cabeza del resto de la lista
                if (actual == cabeza)
                {
                    cabeza = actual.adelante;
                    if (actual.adelante != null)
                    {
                        actual.adelante.atras = null;
                    }
                }
                else if (actual.adelante != null)///no es el ultimo nodo
                {
                    actual.atras.adelante = actual.adelante;
                    actual.adelante.atras = actual.atras;
                }
                else//ultimo nodo
                {
                    actual.atras.adelante = null;

                }
                actual = null;
            }
        }

        public void visualizar()
        {
            Nodo n;
            n = cabeza;
            while (n != null)
            {
                Console.WriteLine(n.dato + "\n");
                n = n.adelante;
            }
        }
    }
}
