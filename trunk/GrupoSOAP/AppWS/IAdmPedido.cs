using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AppWS.Dominio;

namespace AppWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAdmPedido" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAdmPedido
    {
        [OperationContract]
        Pedido crear(string usuario, string fecha, string prioridad);
        
        [OperationContract]
        List<Pedido> listar();

        [OperationContract]
        Pedido_det creardet(int npedido,int codarticulo,string articulo,int cantidad);

        [OperationContract]
        List<Pedido_det> listarDetalle();


    }
}
