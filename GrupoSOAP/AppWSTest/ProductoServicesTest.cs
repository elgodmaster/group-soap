using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppWSTest.ProductoWS;

namespace AppWSTest
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class ProductoServicesTest
    {
        public ProductoServicesTest()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
        
        [TestMethod]
        public void CrearArticuloTest()
        {
            ProductoWS.AdmProductoClient proxy = new ProductoWS.AdmProductoClient();
            //Asesor asesorEnviado = new Asesor();

            Articulo articuloEsperado = proxy.crear("Product06", "Producto Nuevo", 2);
            Assert.AreEqual(articuloEsperado.Nombre, "Product06");
        }

        [TestMethod]
        public void ObtenerArticuloTest()
        {
            ProductoWS.AdmProductoClient proxy = new ProductoWS.AdmProductoClient();

            Articulo articuloEsperado = proxy.obtener(6);
            Assert.AreEqual(articuloEsperado.Nombre, "Product06");
        }

        [TestMethod]
        public void ModificarArticuloTest()
        {
            ProductoWS.AdmProductoClient proxy = new ProductoWS.AdmProductoClient();

            Articulo articuloEsperado = proxy.modificar(6, "Product06", "Producto New", 3);
            Assert.AreEqual(articuloEsperado.Nombre, "Product06");
        }

        [TestMethod]
        public void EliminarArticuloTest()
        {
            ProductoWS.AdmProductoClient proxy = new ProductoWS.AdmProductoClient();

            //int codigoArticulo = 6;
            Articulo articuloEsperado = proxy.obtener(6);

            proxy.eliminar(articuloEsperado);

            Assert.IsNull(proxy.obtener(6));

        }

        [TestMethod]
        public void ListarArticuloTest()
        {
            ProductoWS.AdmProductoClient proxy = new ProductoWS.AdmProductoClient();

            Articulo[] list = proxy.listar();

            Assert.AreEqual(list.Length,5);

        }


    }
}
