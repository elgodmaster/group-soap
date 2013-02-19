using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppWSTest.PedidoWS;

namespace AppWSTest
{
    [TestClass]
    public class PedidoServicesTest
    {
        [TestMethod]
        public void CrearPedidoTest()
        {
            PedidoWS.AdmPedidoClient proxy = new PedidoWS.AdmPedidoClient();
            //Asesor asesorEnviado = new Asesor();

            Pedido pedidoEsperado = proxy.crear("shuaman2", "20-02-2013", "Alta");
            Assert.AreEqual(pedidoEsperado.Usuario, "shuaman2");
        }


        [TestMethod]
        public void ListarPedidosTest()
        {
            PedidoWS.AdmPedidoClient proxy = new PedidoWS.AdmPedidoClient();

            Pedido[] list = proxy.listar();

            Assert.AreEqual(list.Length, 2);

        }

        [TestMethod]
        public void CrearPedidoDetTest()
        {
            PedidoWS.AdmPedidoClient proxy = new PedidoWS.AdmPedidoClient();
            //Asesor asesorEnviado = new Asesor();

            Pedido_det pedidodetEsperado = proxy.creardet(1,1,"Producto001", 5);
            Assert.AreEqual(pedidodetEsperado.Articulo, "Producto001");
        }


        [TestMethod]
        public void ListarPedidosDetTest()
        {
            PedidoWS.AdmPedidoClient proxy = new PedidoWS.AdmPedidoClient();

            Pedido_det[] list = proxy.listarDetalle();

            Assert.AreEqual(list.Length, 1);

        }



    }
}
