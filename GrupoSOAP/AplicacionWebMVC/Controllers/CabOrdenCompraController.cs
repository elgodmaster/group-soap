using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacionWebMVC.Controllers
{
    public class CabOrdenCompraController : Controller
    {
        //
        // GET: /CabOrdenCompra/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /CabOrdenCompra/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /CabOrdenCompra/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /CabOrdenCompra/Create

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
        // GET: /CabOrdenCompra/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /CabOrdenCompra/Edit/5

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
        // GET: /CabOrdenCompra/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /CabOrdenCompra/Delete/5

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
