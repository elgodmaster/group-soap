using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AplicacionWebMVC.Models
{
    public class Proveedor
    {

        public int Codigo { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Ruc { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        [Required]
        public string NombreContacto { get; set; }
        [Required]
        public string TelefonoContacto { get; set; }

    }
}