using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace AppWS.Dominio
{
    [DataContract]
    public class Aviso
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Mensaje { get; set; }
    }
}