using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/*
 Tiene 6 atributos
 nombre -> Titulo de la pelicula
 año -> año de estreno
 imagen -> apunta al path de la imagen
 categoria -> Una referencia a la categoria
 siguiente-> apuntador al siguiente nodo o siguiente pelicula
 anterior -> apuntador al anterior nodo o anterior pelicula

     */
namespace Netflix
{
   public  class Pelicula
    {
        //atributos, este tiene dos enlaces, por eso es doble xD     
        public string nombre;
        public int año;
        public string imagen;
        public string categoria;
        public Pelicula siguiente;
        public Pelicula anterior;
        //constructor vacio
        public Pelicula()
        {
            nombre = "";
            año = 0;
            imagen = "";
            categoria = "";
            siguiente = null;
            anterior = null;
        }
        //constructor con parametros
        public Pelicula(string nombre_, int año_, string imagen_, string categoria_, Pelicula siguiente_, Pelicula anterior_)
        {
            nombre = nombre_;
            año = año_;
            imagen = imagen_;
            categoria = categoria_;
            siguiente = siguiente_;
            anterior = anterior_;
        }
    }
}