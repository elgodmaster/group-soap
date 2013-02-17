using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace AppWS.Dominio
{
    [DataContract]
    public class Orden
    {
        [DataMember]
        public int codigo { get; set; }
        [DataMember]
        public String fecha { get; set; }
        [DataMember]
        public String proveedor { get; set; }
        [DataMember]
        public String observacion { get; set; }

    }
}