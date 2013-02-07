using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace AppWSTest
{
    [TestClass]
    public class ProveedorRestTest
    {
        [TestMethod]
        public void CRUDTestCrear()
        {
            string postdata = "{\"Nombre\":\"Proveedor 06\",\"Ruc\":\"12312312366\",\"Direccion\":\"los olivos\",\"Telefono\":\"4578598\",\"NombreContacto\":\"Marcos\",\"TelefonoContacto\":\"5457859\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:2518/AdmProveedor.svc/Proveedores");
            req.Method = "POST";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            HttpWebResponse res = null;

            try
            {
                res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string proveedorjson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Proveedor proveedorCreado = js.Deserialize<Proveedor>(proveedorjson);
                Assert.AreEqual("Proveedor 06", proveedorCreado.Nombre);
            }
            catch (WebException e)
            {
                HttpWebResponse resError = (HttpWebResponse)e.Response;
                StreamReader readerError = new StreamReader(resError.GetResponseStream());
                string error = readerError.ReadToEnd();
                JavaScriptSerializer jsError = new JavaScriptSerializer();
                string errorObtenido = jsError.Deserialize<string>(error);
                Assert.AreEqual("El Ruc o el Nombre del proveedor ingresado ya existe!", errorObtenido);
            }
        }

        [TestMethod]
        public void CRUDTestModificar()
        {

            string postdata = "{\"Codigo\":2,\"Nombre\":\"PROVEEDOR\",\"Ruc\":\"12457859\",\"Direccion\":\"los olivos\",\"Telefono\":\"4578598\",\"NombreContacto\":\"Marcos\",\"TelefonoContacto\":\"5457859\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:2518/AdmProveedor.svc/Proveedores");
            req.Method = "PUT";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string proveedorjson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Proveedor proveedorModificado = js.Deserialize<Proveedor>(proveedorjson);
            Assert.AreEqual("PROVEEDOR", proveedorModificado.Nombre);

        }

        [TestMethod]
        public void CRUDTestListar()
        {

            
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:2518/AdmProveedor.svc/Proveedores");
            req.Method = "LIST";
    
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string proveedorjson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Proveedor> list = js.Deserialize<List<Proveedor>>(proveedorjson);
            Assert.AreEqual(list.Count(), 4);

        }


    }
}
