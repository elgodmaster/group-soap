using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacionWebMVC.Models;

namespace AplicacionWebMVC.Controllers
{
    public class PedidoController : Controller
    {

        private List<Pedido> CrearPedidos()
        {

            //Articulo articulo1 = new Articulo() { Codigo = 1, Nombre = "product01" };
            //Articulo articulo2 = new Articulo() { Codigo = 2, Nombre = "product02" };

            List<Pedido> pedidos = new List<Pedido>();

            pedidos.Add(new Pedido() {NPedido = 1, Usuario = "Luisa Vargas", FechaRegistro="26/01/2013", Prioridad="Alta"});
            pedidos.Add(new Pedido() {NPedido = 2, Usuario = "Carlos Rivera", FechaRegistro = "26/01/2013", Prioridad = "Baja"});
            pedidos.Add(new Pedido() {NPedido = 3, Usuario = "Luisa Vargas", FechaRegistro = "26/01/2013", Prioridad = "Alta"});

            return pedidos;
        }


        private Pedido ObtenerPedido(int NPedido)
        {
            List<Pedido> Pedidos = (List<Pedido>)Session["pedidos"];

            Pedido model = Pedidos.Single(delegate(Pedido pedido)
            {

                if (pedido.NPedido == NPedido) return true;
                else return false;
            });

            return model;
        }



        public ActionResult Index()
        {
            if (Session["pedidos"] == null)
                Session["pedidos"] = CrearPedidos();

            List<Pedido> model = (List<Pedido>)Session["pedidos"];
            return View(model);
        }


        public ActionResult Details(int id)
        {
            Pedido model = ObtenerPedido(id);
            return View(model);
        }

        //
        // GET: /Pedido/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Pedido/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {

                List<Pedido> Pedidos = (List<Pedido>)Session["pedidos"];
                Pedidos.Add(new Pedido()
                {
                    NPedido = int.Parse(collection["NPedido"]),
                    Usuario = collection["Usuario"],
                    FechaRegistro = collection["FechaRegistro"],
                    Prioridad = collection["Prioridad"]
                    //Articulos = new Articulo()
                    //{
                    //    Codigo = int.Parse(collection["Articulos.Codigo"]),
                    //    Nombre = collection["Articulos.Nombre"]

                    //}

                });

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Articulo/Edit/5

        public ActionResult Edit(int id) //Muestra pagina con datos a editar
        {
            Pedido model = ObtenerPedido(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection) //Recibe Datos de formulario y realiza modificacion
        {
            try
            {
                Pedido model = ObtenerPedido(id);
                model.Usuario = collection["Usuario"];
                model.Prioridad = collection["Prioridad"];

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {

            Pedido model = ObtenerPedido(id);

            return View(model);
        }

        //
        // POST: /Pedido/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                List<Pedido> Pedidos = (List<Pedido>)Session["pedidos"];
                Pedidos.Remove(ObtenerPedido(id));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
