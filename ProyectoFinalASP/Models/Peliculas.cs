using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoFinalASP.Models
{
    public class Peliculas
    {


        public int id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        //public string direccion { get; set; }
        public  string genero { get; set; }
        public string categoria { get; set; }
        public string  director { get; set; }
        public string idioma { get; set; }
        public string pais { get; set; }

    }
}