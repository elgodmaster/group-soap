using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebMVC.Models
{
    public class Proveedor
    {

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Ruc { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string NombreContacto { get; set; }
        public string TelefonoContacto { get; set; }

    }
}