using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebMVC.Models
{
    public class Pedido
    {
        public int NPedido { get; set; }
        public String Usuario { get; set; }
        public String FechaRegistro { get; set; }
        public String Prioridad { get; set; }
       // public List<Articulo> articulos { get; set; }
        
    }
}