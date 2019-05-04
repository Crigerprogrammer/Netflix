using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Netflix.Estructuras 
{
    public class Cola<Tipo> : IEnumerable<Tipo> {
        public Nodo primero;
        public Nodo ultimo;
        public int n;
        public class Nodo
        {
            public Tipo dato;
            public Nodo siguiente;
            public Nodo(Tipo dato)
            {
                this.dato = dato;
            }
        }
        //Metodo para descolar 
        public Tipo Descolar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("Overflow en la cola");

            Tipo dato = primero.dato;
            primero = primero.siguiente;
            n--;
            if (EstaVacia()) ultimo = null;
            return dato;
        }
        //Metodo para Encolar
        public void Encolar(Tipo dato)
        {
            Nodo viejoultimo = ultimo;
            ultimo = new Nodo(dato);
            ultimo.siguiente = null;
            n++;
            if (EstaVacia()) primero = ultimo;
            else viejoultimo.siguiente = ultimo;
        }
        //Metodo para saber si la cola esta vacia
        public bool EstaVacia() { return primero == null;  }
        //Metodo para saber el tamaño de la cola
        public int Tamaño() { return n; }
        //Re escritura del metodo ToString
        public override string ToString()
        {
            Nodo actual = primero;
            string salida = "";

            while (actual != null)
            {
                salida += actual.dato.ToString() + "  ";
                actual = actual.siguiente;
            }

            return salida;
        }
        public IEnumerator<Tipo> GetEnumerator()
        {
            Nodo actual = primero;

            while (actual != null)
            {
                yield return actual.dato;
                actual = actual.siguiente;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
