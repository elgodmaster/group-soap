using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOAPServicesTest.AsesoresWS;

namespace SOAPServicesTest
{
    [TestClass]
    public class ServicesTest
    {
        [TestMethod]
        public void CrearAsesorTest()
        {
            AsesoresWS.AsesoresClient proxy = new AsesoresWS.AsesoresClient();
            //Asesor asesorEnviado = new Asesor();

            Asesor asesorEsperado = proxy.CrearAsesor("Monica", "mon@upc.edu.pe", 1);
            Assert.AreEqual(asesorEsperado.Nombre, "Monica");
        }

        [TestMethod]
        public void ObtenerAsesorTest()
        {
            AsesoresWS.AsesoresClient proxy = new AsesoresWS.AsesoresClient();

            Asesor asesorEsperado = proxy.ObtenerAsesor(9);
            Assert.AreEqual(asesorEsperado.Nombre, "Monica");
        }

        [TestMethod]
        public void ModificarAsesorTest()
        {
            AsesoresWS.AsesoresClient proxy = new AsesoresWS.AsesoresClient();
            //Asesor asesorEnviado = new Asesor();

            Asesor asesorEsperado = proxy.ModificarAsesor(9, "Luisa", "luisa@upc.edu.pe", 2);
            Assert.AreEqual(asesorEsperado.Nombre, "Luisa");
        }

        [TestMethod]
        public void EliminarAsesorTest()
        {
            AsesoresWS.AsesoresClient proxy = new AsesoresWS.AsesoresClient();

            int codigoAsesor = 9;

            proxy.EliminaAsesor(codigoAsesor);

            Assert.IsNull(proxy.ObtenerAsesor(codigoAsesor));

        }

        [TestMethod]
        public void ListarAsesorTest()
        {
            AsesoresWS.AsesoresClient proxy = new AsesoresWS.AsesoresClient();
            //Asesor asesorEnviado = new Asesor();

            Asesor[] list = proxy.ListarAsesores();

            Assert.AreEqual(list.Length, 3);

        }
    }
}
