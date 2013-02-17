using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebMVC.Models
{
    public class Orden
    {
        public int codigo { get; set; }
        public String fecha { get; set; }
        public String proveedor { get; set; }
        public String observacion { get; set; }
    }
}