using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace AppWS.Dominio
{

    [DataContract]
    public class Proveedor
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Ruc { get; set; }
        [DataMember]
        public string Direccion { get; set; }
        [DataMember]
        public string Telefono { get; set; }
        [DataMember]
        public string Fax { get; set; }
        [DataMember]
        public string NombreContacto { get; set; }
        [DataMember]
        public string TelefonoContacto { get; set; }

    }

}