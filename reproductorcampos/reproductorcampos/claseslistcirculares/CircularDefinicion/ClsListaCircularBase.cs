using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reproductorcampos.claseslistcirculares.CircularDefinicion
{
    class ClsListaCircularBase
    {
        public Nodos lc;
        public Nodos firs;

        public ClsListaCircularBase()
        {
            lc = null;
            firs = null;
        }

        public ClsListaCircularBase insertarCircular(string entrada)
        {
            Nodos nuevo;
            nuevo = new Nodos(entrada);


            if (lc != null)//lista no vacia
            {
                nuevo.enlace = lc.enlace;
                lc.enlace = nuevo;

            }
            lc = nuevo;
            return this;
        }

        public ClsListaCircularBase insertar(string entrada)
        {
            //Nodo nuevo;
            //nuevo = new Nodo(entrada);

            //if (lc != null)//lista no vacia
            //{
            //    nuevo.enlace = lc.enlace;
            //    lc.enlace = nuevo;

            //}
            //lc = nuevo;
            //return this;

            //Nodo_C nuevo;
            //nuevo = new Nodo_C(name);
            //if (primero == null)
            //{
            //    primero = nuevo;
            //    primero.enlace = primero;
            //    ultimo = primero;
            //}
            //else
            //{
            //    ultimo.enlace = nuevo;
            //    nuevo.enlace = primero;
            //    ultimo = nuevo;

            //}
            Nodos nuevo;
            nuevo = new Nodos(entrada);
            if (lc == null)
            {
                lc = nuevo;
                lc.enlace = lc;
                this.firs = lc;
            }
            else
            {
                this.firs.enlace = nuevo;
                nuevo.enlace = lc;
                this.firs = nuevo;

            }
            return this;

        }

        public void eliminar(string entrada)
        {
            Nodos actual;
            bool encontrado = false;
            //bucle de búsqueda
            actual = lc;
            while ((actual.enlace != lc) && (!encontrado))
            {
                encontrado = (actual.enlace.dato == entrada);
                if (!encontrado)
                {
                    actual = actual.enlace;
                }
            }

            encontrado = (actual.enlace.dato == entrada);
            // Enlace de nodo anterior con el siguiente
            if (encontrado)
            {
                Nodos p;
                p = actual.enlace; // Nodo a eliminar
                if (lc == lc.enlace) // Lista con un solo nodo
                {
                    lc = null;
                }
                else
                {
                    if (p == lc)
                    {
                        lc = actual; // Se borra el elemento referenciado por lc,
                                     // el nuevo acceso a la lista es el anterior
                    }
                    actual.enlace = p.enlace;
                }
                p = null;
            }
        }

        public void recorrer()
        {
            Nodos p;
            if (lc != null)
            {
                p = lc.enlace; // siguiente nodo al de acceso
                do
                {
                    Console.WriteLine("\t" + p.dato);
                    p = p.enlace;
                } while (p != lc.enlace);
            }
            else
            {
                Console.WriteLine("\t Lista Circular vacía.");
            }
        }

    }
}
