using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace AppWS.Dominio
{
    [DataContract]   
    public class Pedido_det
    {

        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public int NPedido { get; set; }
        [DataMember]
        public int CodigoArticulo { get; set; }
        [DataMember]
        public string Articulo { get; set; }
        [DataMember]
        public int Cantidad { get; set; }



    }
}