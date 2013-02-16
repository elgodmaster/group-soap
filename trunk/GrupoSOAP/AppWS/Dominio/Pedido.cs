using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace AppWS.Dominio
{
    [DataContract]
    public class Pedido
    {
        [DataMember]
        public int NPedido { get; set; }
        [DataMember]
        public String Usuario { get; set; }
        [DataMember]
        public String FechaRegistro { get; set; }
        [DataMember]
        public String Prioridad { get; set; }

    }
}