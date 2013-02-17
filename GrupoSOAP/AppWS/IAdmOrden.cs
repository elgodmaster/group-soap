using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AppWS.Dominio;

namespace AppWS
{

    [ServiceContract]
    public interface IAdmOrden
    {
        [OperationContract]
        Orden crear(string fecha, string proveedor, string observacion);

        [OperationContract]
        List<Orden> listar();
    }
}
