using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionWebMVC.Controllers
{
    public class DetOrdenCompraController : Controller
    {
        //
        // GET: /DetOrdenCompra/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /DetOrdenCompra/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DetOrdenCompra/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /DetOrdenCompra/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /DetOrdenCompra/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DetOrdenCompra/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /DetOrdenCompra/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DetOrdenCompra/Delete/5

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
