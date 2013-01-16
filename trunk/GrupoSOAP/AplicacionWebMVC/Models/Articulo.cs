using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebMVC.Models
{
    public class Articulo
    {

        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public Categoria Categorias { get; set; }

    }
}