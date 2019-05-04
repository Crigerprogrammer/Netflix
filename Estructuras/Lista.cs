using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Netflix.Estructuras 
{
     public class Lista<Tipo> : IEnumerable<Tipo>
     {
         private Nodo primero;
         private Nodo ultimo;
         private int n;

         private class Nodo
         {
             public Tipo dato;
             public Nodo siguiente;

             public Nodo(Tipo dato)
             {
                 this.dato = dato;
             }
         }
         // Sobreescritura del metodo ToString para recorrer una lista
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
         //Metodo Remover
         public Tipo Remover()
         {
             if (EstaVacia())
                 throw new InvalidOperationException("Error en la cola");
             Tipo dato = primero.dato;
             primero = primero.siguiente;
             n--;
             if (EstaVacia()) ultimo = null;
             return dato;
         }
        //Metodo para Agregar en una Lista
        public void Agregar(Tipo dato)
         {
             Nodo viejoultimo = ultimo;
             ultimo = new Nodo(dato);
             ultimo.siguiente = null;
             n++;
             if (EstaVacia()) primero = ultimo;
             else viejoultimo.siguiente = ultimo;
         }
        public void Add(Tipo dato)
        {
            Agregar(dato);
        }
        //Metodo para indicar si la lista esta vacia
         public bool EstaVacia() { return primero == null; }
         //Metodo para indicar el tamaño de la lista
         public int Tamaño() { return n; }
         // Este codigo sirve para poder recorrer 
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
