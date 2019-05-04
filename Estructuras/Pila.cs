using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Netflix.Estructuras
{
    public class Pila<Tipo> : IEnumerable<Tipo>
    {
        private Nodo primero;
        int n;
        private class Nodo
        {
            public Tipo dato;
            public Nodo siguiente;

            public Nodo(Tipo dato)
            {
                this.dato = dato;
            }
        }
        //Metodo para sacar un dato
        public Tipo Sacar()
        {
            if (EstaVacia()) throw new InvalidOperationException("Underflow de pila.");
            Tipo dato = primero.dato;
            primero = primero.siguiente;
            n--;
            return dato;
        }
        //Metodo para agregar un dato
        public void Empujar(Tipo dato)
        {
            Nodo viejoprimero = primero;
            primero = new Nodo(dato);
            primero.siguiente = viejoprimero;
            n++;
        }
        // Recorre la pila 
        public override string ToString()
        {
            Nodo actual = primero;
            string salida = "";

            while (actual != null)
            {
                salida = actual.dato.ToString() + "  " + salida;
                actual = actual.siguiente;
            }
            return salida;
        }
        public bool EstaVacia() { return primero == null;  }
        public int Tamaño() { return n; }
        // Este codigo sirve para poder recorrer la pila c
        public IEnumerator<Tipo> GetEnumerator()
        {
            Nodo actual= primero;

            while (actual != null)
            {
                yield return actual.dato;
                actual= actual.siguiente;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
