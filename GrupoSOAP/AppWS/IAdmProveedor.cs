using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using AppWS.Dominio;

namespace AppWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAdmProveedor" in both code and config file together.
    [ServiceContract]
    public interface IAdmProveedor
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Proveedores", ResponseFormat = WebMessageFormat.Json)]
        Proveedor CrearProveedor(Proveedor proveedorACrear);
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Proveedores/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        Proveedor ObtenerProveedor(string codigo);
        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Proveedores", ResponseFormat = WebMessageFormat.Json)]
        Proveedor ModificarProveedor(Proveedor proveedorAModificar);
        [OperationContract]
        [WebInvoke(Method = "LIST", UriTemplate = "Proveedores", ResponseFormat = WebMessageFormat.Json)]
        List<Proveedor> ListarProveedores();
    }
}
