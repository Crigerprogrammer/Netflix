using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Netflix.Estructuras;
using System.IO;

namespace Netflix.Pages
{
    public class Data
    {

        public ListaDoble<Pelicula> peliculas = new ListaDoble<Pelicula>
        {
               new Pelicula { Id = 1,
                              Id_Categoria = 1,  
                              Nombre = "Antman", 
                              Imagen = "/wwwroot/img/antman.jpg",
                              Trailer ="https://www.youtube.com/watch?v=8Ni28qTnV8M"},
        };             
        
        //Estructura de Datos para MiLista
        public static Cola<Pelicula> my_list = new Cola<Pelicula>();

        // Estructura de Datos para Continuar Viendo
        public static Pila<Pelicula> continuar = new Pila<Pelicula>();

        //Estructura de Datos para Categorias
        public Lista<Categoria> Categorias = new Lista<Categoria>
        {
            new Categoria() { Id = 0, 
                              NombreCategoria = "Drama" },
            new Categoria() { Id = 1, 
                              NombreCategoria = "Accion y Aventuras" },
            new Categoria() { Id = 2, 
                              NombreCategoria = "Niños" },
        };
        


    }
}