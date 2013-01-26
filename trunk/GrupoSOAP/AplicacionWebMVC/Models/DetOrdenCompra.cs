using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebMVC.Models
{
    public class DetOrdenCompra
    {
        public int codigo_oc { get; set; }
        public int item { get; set; }
        public int producto { get; set; }
        public decimal cantidad { get; set; }
        public string unidad { get; set; } 
    }
}