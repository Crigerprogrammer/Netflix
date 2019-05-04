using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Netflix.Pages
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Id_Categoria { get; set; }
        public string Imagen { get; set; }
        public string Trailer { get; set; }
        public string ObtenerCategoria()
        {
            switch(Id_Categoria)
            {
                case 0:
                    return "Drama";
                case 1:
                    return "Accion y Aventuras";
                case 2:
                    return "Niños";
            }
            return "";
        }

    }
}