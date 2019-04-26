using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
    La clase Categoria
    Esta clase representa las diferentes categorías que existirán en tu aplicación, tales
    como Drama, Acción, etc.
    
    Cuenta con dos atributos:
        nombre -> Es el nombre que recibe la categoría e indica el tipo de peliculas que 
                  almacenará
        listaPeliculas -> Es una lista doble en la cual se van a almacenar las peliculas
    
    Esta clase cuenta con un metodo llamado crearCategoría, cuyo unico parametro es el nombre
    de la categoría, como por ejemplo "drama". Este método retorna una instancia del objeto Categoria
    e inicializa su lista de peliculas. 
     
*/


namespace Netflix
{
    public class Categoria
    {
        public string nombre;//atributo nombre
        public ListaDoble listaPeliculas;//atributo lista de peliculas para almacenar

        public Categoria() { //Constructor
            nombre = "";
            listaPeliculas = null;
        }

        public Categoria(string name, ListaDoble content) {//Constructor
            nombre = name;
            listaPeliculas = content;
        }

        public static Categoria crearCategoria(string nombre_) {//Metodo crearCategoria
            Categoria nuevaCategoria = new Categoria();//Crea el objeto
            nuevaCategoria.nombre = nombre_;//Asigna a la nueva categoria el nombre que le mandamos
            ListaDoble nuevaLista = new ListaDoble();//inicializa una lista doble
            nuevaCategoria.listaPeliculas = nuevaLista;//le asigna a la nueva categoria la nueva lista doble
            return nuevaCategoria;//retorna la categoría como un objeto con nombre y lista doble vacía por el momento
        }
    }
}