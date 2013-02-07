using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacionWebMVC.Models;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace AplicacionWebMVC.Controllers
{
    public class ProveedorController : Controller
    {
        //
        // GET: /Proveedor/

        public ActionResult Index()
        {
            return View(Listar());
        }

        private List<Proveedor> Listar()
        {
            List<Proveedor> lstProveedor;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:2518/AdmProveedor.svc/Proveedores");
            req.Method = "LIST";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string proveedorJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            lstProveedor = js.Deserialize<List<Proveedor>>(proveedorJson);
            return lstProveedor;
        }

        private List<Proveedor> Ini()
        {
            List<Proveedor> lstProveedor = new List<Proveedor>();
            lstProveedor.Add(new Proveedor()
            {
                Codigo = 1, Nombre = "Proveedor 01", Ruc = "10000000000", Telefono = "1000000", 
                Fax = "10000000", Direccion = "Av. 100", NombreContacto = "Contacto 01", TelefonoContacto = "10000001"
            });
            lstProveedor.Add(new Proveedor()
            {
                Codigo = 2, Nombre = "Proveedor 02", Ruc = "20000000000", Telefono = "2000000",
                Fax = "20000000", Direccion = "Av. 200", NombreContacto = "Contacto 02", TelefonoContacto = "20000002"
            });
            lstProveedor.Add(new Proveedor()
            {
                Codigo = 3, Nombre = "Proveedor 03", Ruc = "30000000000", Telefono = "3000000",
                Fax = "30000000", Direccion = "Av. 300", NombreContacto = "Contacto 03", TelefonoContacto = "30000003"
            });

            return lstProveedor;
        }

        private Proveedor obtenerProveedor(int id)
        {
            Proveedor o;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:2518/AdmProveedor.svc/Proveedores/"+id);
            req.Method = "GET";
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string proveedorJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            o = js.Deserialize<Proveedor>(proveedorJson);
            return o;
        }

        //
        // GET: /Proveedor/Details/5

        public ActionResult Details(int id)
        {
            Proveedor model = obtenerProveedor(id);
            return View(model);
        }

        //
        // GET: /Proveedor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Proveedor/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                string postdata = "{\"Nombre\":\"" + collection["Nombre"] + "\",\"Ruc\":\"" + collection["Ruc"] + "\",\"Direccion\":\"" + collection["Direccion"] + "\",\"Telefono\":\"" + collection["Telefono"] +"\",\"Fax\":\"" + collection["Fax"] + "\",\"NombreContacto\":\"" + collection["NombreContacto"] + "\",\"TelefonoContacto\":\"" + collection["TelefonoContacto"] + "\"}";
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:2518/AdmProveedor.svc/Proveedores");
                req.Method = "POST";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string proveedorJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Proveedor proveedorCreado = js.Deserialize<Proveedor>(proveedorJson);
                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }
        
        //
        // GET: /Proveedor/Edit/5
 
        public ActionResult Edit(int id)
        {
            Proveedor model = obtenerProveedor(id);
            return View(model);
        }

        //
        // POST: /Proveedor/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                string postdata = "{\"Codigo\":\"" + collection["Codigo"] + "\",\"Nombre\":\"" + collection["Nombre"] + "\",\"Ruc\":\"" + collection["Ruc"] + "\",\"Direccion\":\"" + collection["Direccion"] + "\",\"Telefono\":\"" + collection["Telefono"] + "\",\"Fax\":\"" + collection["Fax"] + "\",\"NombreContacto\":\"" + collection["NombreContacto"] + "\",\"TelefonoContacto\":\"" + collection["TelefonoContacto"] + "\"}";

                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:2518/AdmProveedor.svc/Proveedores");
                req.Method = "PUT";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string proveedorJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Proveedor proveedorModificado = js.Deserialize<Proveedor>(proveedorJson);
                return RedirectToAction("Index");
             }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Proveedor/Delete/5
 
        public ActionResult Delete(int id)
        {
            Proveedor model = obtenerProveedor(id);
            return View(model);
        }

        //
        // POST: /Proveedor/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
