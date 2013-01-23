using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AppWS.Dominio;

namespace AppWS
{
    [ServiceContract]
    public interface IAdmProducto
    {
        [OperationContract]
        Articulo crear(string nombre, string descripcion, int categoria);
        [OperationContract]
        Articulo modificar(int codigo, string nombre, string descripcion, int categoria);
        [OperationContract]
        Articulo obtener(int codigo);
        [OperationContract]
        void eliminar(Articulo o);
        [OperationContract]
        List<Articulo> listar();
    }

}
