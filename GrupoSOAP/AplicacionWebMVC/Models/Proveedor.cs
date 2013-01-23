using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebMVC.Models
{
    public class Proveedor
    {

        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public String Ruc { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
        public String Fax { get; set; }
        public List<Articulo> articulos { get; set; }

    }
}