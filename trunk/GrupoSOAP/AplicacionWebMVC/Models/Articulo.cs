using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace AplicacionWebMVC.Models
{
    [DataContract]
    public class Articulo
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public String Nombre { get; set; }
        [DataMember]
        public String Descripcion { get; set; }
        [DataMember]
        public Categoria Categoria { get; set; }

    }
}