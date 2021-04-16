using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reproductorcampos
{
    class Lista
    {
        // nodos para redireccionar
        public Nodo first;
        public Nodo last;

        public Lista()
        {
            //comensaran en lunos
            first = null;
            last = null;

        }

        private int leerEntero()
        {
            Console.WriteLine("Ingrese valor, -1 para finalizar");
            return Int32.Parse(Console.ReadLine());

        }


        //public Nodo buscarPosicion(int posicion)
        //{
        //    Nodo indice;
        //    int i;
        //    if (posicion < 0)
        //    {
        //        return null;
        //    }
        //    indice = first;
        //    for (i = 1; (i < posicion) && (indice != null); i++)
        //    {
        //        indice = indice.enlace;
        //    }
        //    return indice;

        //}
        //busca por posicion
       
        public Nodo searchposition(int index)
        {

            if (index < 0 )
            {
                return null;
            }

            int n = 0;
            Nodo aux = first;
            while (n != index)
            {
                aux = aux.enlace;
                n++;
            }

            return aux;
        }
        //insertar canciones a la lista a la lista
        public void insertarCanciones(String name)
        {
            Nodo dato = new Nodo(name);
            // para insertar la primera cuando la lista esta vacia
            if (first == null)
            {
                first = dato;
                first.enlace = null;
                last = dato;
            }
            //cuando la lista ya tiene datos
            else
            {

                last.enlace = dato;
                dato.enlace = null;
                last = dato;
            }
        }
        //eliminar canciones
        public void deleteMusic(int cancion)
        {
            Nodo actual, anterior;
            bool encontrado;
            //inicializa los apuntadores
            Nodo dato = searchposition(cancion);
            actual = first;
            anterior = null;
            encontrado = false;
            // si la lista no es nula compara el dato a eliminar con el que ya esta en la lista
            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.enlace == dato.enlace);


                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.enlace;
                }
            }//end while

            //enlace del nodo anteior con el siguiente
            if (actual != null)
            {
                //distinguir si es el nodo inicial a cabeza
                //es cualquiera otro nodo de la lista
                //elimina nodo inicial
                if (actual == first)
                {
                    first = actual.enlace;
                }
                //nodo enter medio o final

                else
                {
                    anterior.enlace = actual.enlace;
                }
            }

        }


        //insertar de ultimo
        public Lista insertarUltimo(Nodo ultimo, string entrada)
        {
            ultimo.enlace = new Nodo(entrada);
            ultimo = ultimo.enlace;
            return this;
        }


        public Lista insertarCabeza(Nodo cabeza, string valor)
        {
            cabeza.enlace = new Nodo(valor);
            cabeza = cabeza.enlace;
            return this;
        }

        public Nodo buscarLista(string destino)
        {
            Nodo indice;
            for (indice = first; indice != null; indice = indice.enlace)
            {
                if (destino == indice.dato)
                {
                    return indice;
                }
            }
            return null;
        }

        public void eliminar(string entrada)
        {
            Nodo actual, anterior;
            bool encontrado;
            //inicializa los apuntadores
            actual = first;
            anterior = null;
            encontrado = false;

            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.dato == entrada);

                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.enlace;
                }
            }//end while

            //enlace del nodo anteior con el siguiente
            if (actual != null)
            {
                //distinguir si es el nodo inicial a cabeza
                //es cualquiera otro nodo de la lista
                if (actual == first)
                {
                    first = actual.enlace;
                }
                else
                {
                    anterior.enlace = actual.enlace;
                }
                actual = null;
            }

        }//end metodo

        public Lista insertarLista(string testigo, string entrada)
        {
            Nodo nuevo, anterior;
            anterior = buscarLista(testigo);

            if (anterior != null)
            {
                nuevo = new Nodo(entrada);
                nuevo.enlace = anterior.enlace;
                anterior.enlace = nuevo;
            }
            return this;
        }

        public void visualizar()
        {
            Nodo n;
            int k = 0;
            n = first;
            while (n != null)
            {
                Console.WriteLine(n.dato + " ");
                n = n.enlace;
                k++;
                Console.WriteLine((k % 15 != 0 ? "" : "\n"));
            }
        }
    }
}
