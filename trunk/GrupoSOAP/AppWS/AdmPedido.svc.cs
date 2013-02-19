using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AppWS.Persistencia;
using AppWS.Dominio;

namespace AppWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AdmPedido" en el código, en svc y en el archivo de configuración a la vez.
    public class AdmPedido : IAdmPedido
    {
        private PedidoDAO pedidoDAO = null;
        private Pedido_detDAO pedido_detDAO = null;

        private PedidoDAO PedidoDAO
        {
            get
            {
                if (pedidoDAO == null)
                    pedidoDAO = new PedidoDAO();
                return pedidoDAO;
            }
        }

        private Pedido_detDAO Pedido_detDAO
        {
            get
            {
                if (pedido_detDAO == null)
                    pedido_detDAO = new Pedido_detDAO();
                return pedido_detDAO;
            }
        }

        
        public Pedido crear(string usuario, string fecha, string prioridad)
        {
            Pedido o = new Pedido()
            {
                Usuario = usuario,
                FechaRegistro = fecha,
                Prioridad = prioridad
            };
            return PedidoDAO.Crear(o);
        }

        public List<Pedido> listar()
        {
            return PedidoDAO.ListarTodos().ToList();
        }


        public Pedido_det creardet(int npedido, int codarticulo, string articulo, int cantidad)
        {
            Pedido_det o = new Pedido_det()
            {
                NPedido = npedido,
                CodigoArticulo = codarticulo,
                Articulo = articulo,
                Cantidad= cantidad
            };
            return Pedido_detDAO.Crear(o);
        }


        public List<Pedido_det> listarDetalle()
        {
            return Pedido_detDAO.ListarTodos().ToList();
        }
    }
}
