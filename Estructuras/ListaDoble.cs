using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netflix.Estructuras 
{
    public class ListaDoble<Item> : IEnumerable<Item>
    {
        private NodoDoble primero;
        private NodoDoble ultimo;
        int n;
        //Constructor Vacio
        public ListaDoble()
        {
            
        }
        private class NodoDoble
        {
            public Item item;
            public NodoDoble siguiente;
            public NodoDoble anterior;
        }
        public Item RemoverInicio()
        {
            if (EstaVacia()) throw new InvalidOperationException("List Underflow");
            Item item;
            if (Tamaño() == 1)
            {
                item = primero.item;
                primero = null;
                ultimo = null;
            }
            else {
                item = primero.item;
                primero = primero.siguiente;
                primero.anterior = null;
            }
            n--;
            return item;
        }
        public Item RemoverFinal()
        {
            if (EstaVacia()) throw new InvalidOperationException("List Underflow");
            Item item;
            if (Tamaño() == 1)
            {
                item = ultimo.item;
                ultimo = null;
                primero = ultimo;
            }
            else {
                item = ultimo.item;
                ultimo = ultimo.anterior;
                ultimo.siguiente = null;
            }
            n--;
            return item;
        }
        public void Remover(Item item)
        {
            if (EstaVacia()) throw new InvalidOperationException("List is Empty");

            NodoDoble cabeza = primero;

            // if primero element in list equals to item, Remover
            if (cabeza.item.Equals(item))
            {
                primero = primero.siguiente;
                if (primero != null) primero.anterior = null;
                n--;
            }

            while (cabeza.siguiente != null)
            {
                if (cabeza.siguiente.item.Equals(item))
                {
                    cabeza.siguiente = cabeza.siguiente.siguiente;
                    if (cabeza.siguiente != null) cabeza.siguiente.anterior = cabeza;
                    else ultimo = cabeza;
                    n--;
                    continue;
                }
                cabeza = cabeza.siguiente;
            }
        }
        //Metodo para Agregar al final de la lista
        public void Add(Item item)
        {
            AgregarFinal(item);
        }
        public void Agregar(Item item)
        {
            AgregarFinal(item);
        }
        public void AgregarInicio(Item item)
        {
            if (EstaVacia())
            {
                primero = new NodoDoble();
                primero.item = item;
                primero.siguiente = null;
                primero.anterior = null;
                ultimo = primero;
            }
            else {
                NodoDoble oldprimero = primero;
                primero = new NodoDoble();
                primero.item = item;
                primero.siguiente = oldprimero;
                primero.anterior = null;
                oldprimero.anterior = primero;
            }
            n++;
        }
        public void AgregarFinal(Item item)
        {
            if (EstaVacia())
            {
                ultimo = new NodoDoble();
                ultimo.item = item;
                ultimo.siguiente = null;
                ultimo.anterior = null;
                primero = ultimo;
            }
            else {
                NodoDoble oldultimo = ultimo;
                ultimo = new NodoDoble();
                ultimo.item = item;
                ultimo.siguiente = null;
                ultimo.anterior = oldultimo;
                oldultimo.siguiente = ultimo;
            }
            n++;
        }
        //Metodo para saber si la lista doble esta vacia
        public bool EstaVacia() { return primero == null; }
        //Metodo para saber el tamaño de la lista doble
        public int Tamaño() { return n; }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        // Este codigo sirve para poder recorrer la listadoble
        public IEnumerator<Item> GetEnumerator()
        {
            NodoDoble actual = primero;
            int size = n;

            while (actual != null)
            {
                yield return actual.item;
                actual = actual.siguiente;
            }
        }

    }
}

