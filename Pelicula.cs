using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/*
 La clase NodoDoble, de una manera más ideal pudiese ser renombrada como "Pelicula"
 ya que representa eso mismo, una pelicula
 Tiene 4 atributos
 nombre -> Titulo de la pelicula
 anio -> año de estreno
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