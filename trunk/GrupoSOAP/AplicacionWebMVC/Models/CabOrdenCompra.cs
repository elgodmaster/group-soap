using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplicacionWebMVC.Models
{
    public class CabOrdenCompra
    {

        public int codigo_oc { get; set; }
        public DateTime fecha { get; set; }
        public int proveedor { get; set; }
        public int observacion{ get; set; }

    }
}