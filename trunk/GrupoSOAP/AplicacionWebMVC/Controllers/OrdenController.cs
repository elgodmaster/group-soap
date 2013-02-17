using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacionWebMVC.Models;

namespace AplicacionWebMVC.Controllers
{
    public class OrdenController : Controller
    {

        AdmOrdenWS.AdmOrdenClient proxy = new AdmOrdenWS.AdmOrdenClient();

        private Orden ObtenerOrden(int codigo)
        {
            List<Orden> Ordenes = (List<Orden>)Session["ordenes"];

            Orden model =  Ordenes.Single(delegate(Orden orden)
            {
                if (orden.codigo == codigo) return true;
                else return false;
            });

            return model;
        }

        public ActionResult Index()
            {
                List<Orden> model = new List<Orden>();
                AdmOrdenWS.Orden[] lista = proxy.listar();

                foreach (AdmOrdenWS.Orden  o in lista)
                {
                    model.Add(new Orden()
                    {
                        codigo = o.codigo,
                        fecha = o.fecha,
                        proveedor = o.proveedor,
                        observacion = o.observacion
                    });
                }
                return View(model);
        }

        
        public ActionResult Details(int id)
        {
            Orden model = ObtenerOrden(id);
            return View(model);
        }

      

        public ActionResult Create()
        {
            return View();
        } 

      
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                AdmOrdenWS.Orden o =
                   proxy.crear(collection["fecha"], collection["proveedor"], collection["observacion"]);

                return RedirectToAction("Index"); 
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Orden/Edit/5
 
        public ActionResult Edit(int id)
        {
            Orden model = ObtenerOrden(id);
            return View();
        }

        //
        // POST: /Orden/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Orden model = ObtenerOrden(id);
                model.fecha= collection["fecha"];
                model.proveedor  = collection["Proveedor"];
                model.observacion= collection ["Observacion"];

 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Orden/Delete/5
 
        public ActionResult Delete(int id)
        {
            Orden model = ObtenerOrden(id);
            return View();
        }

        //
        // POST: /Orden/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                List<Orden> Ordenes = (List<Orden>)Session["ordenes"];
                Ordenes.Remove(ObtenerOrden(id));

 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
