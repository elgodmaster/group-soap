using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicacionWebMVC.Models;

namespace AplicacionWebMVC.Controllers
{
    public class ArticuloController : Controller
    {

        AdmProductoWS.AdmProductoClient proxyProducto = new AdmProductoWS.AdmProductoClient();

        public ActionResult Index() //muestra pagina con lista de articulos
        {
            List<Articulo> model = new List<Articulo>();
            AdmProductoWS.Articulo[] lista = proxyProducto.listar();

            foreach (AdmProductoWS.Articulo o in lista)
            {
                model.Add(new Articulo()
                {
                    Codigo = o.Codigo,
                    Nombre = o.Nombre,
                    Descripcion = o.Descripcion,
                    Categoria = new Categoria() { Codigo = o.Categoria.Codigo, Nombre = o.Categoria.Nombre }
                });
            }

            return View(model);
        }

        public ActionResult Details(int id)
        {
            Articulo model = ObtenerArticulo(id);
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            Articulo model = ObtenerArticulo(id);
            return View(model);
        }

        public ActionResult Create() //Muestra pagina para crear datos de creacion 
        {
            return View();
        }

        public ActionResult Delete(int id) //Muestra pagina para confirmar eliminacion
        {
            Articulo model = ObtenerArticulo(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection) //Recibe Datos de formulario y realiza modificacion
        {
            try
            {
                Articulo model = ObtenerArticulo(id);
                model.Nombre = collection["Nombre"];
                model.Descripcion = collection["Descripcion"];

                AdmProductoWS.Articulo o = 
                    proxyProducto.modificar(model.Codigo, model.Nombre, model.Descripcion, model.Categoria.Codigo);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection) //Recibe los datos del formulario y realiza creacion
        {
            try
            {
                AdmProductoWS.Articulo o = 
                    proxyProducto.crear(collection["Nombre"], collection["Descripcion"], int.Parse(collection["Categoria.Codigo"]));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) //realiza la eliminacion
        {
            try
            {
                Articulo model = ObtenerArticulo(id);
                AdmProductoWS.Articulo o = new AdmProductoWS.Articulo() { Codigo = model.Codigo };
                proxyProducto.eliminar(o);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private Articulo ObtenerArticulo(int Codigo)
        {
            Articulo model;
            AdmProductoWS.Articulo o = proxyProducto.obtener(Codigo);

            model = new Articulo()
            {
                Codigo = o.Codigo,
                Nombre = o.Nombre,
                Descripcion = o.Descripcion,
                Categoria = new Categoria() { Codigo = o.Categoria.Codigo, Nombre = o.Categoria.Nombre }
            };

            return model;
        }
        
        /*
        private List<Articulo> CrearArticulos()
        {

            Categoria Aceites = new Categoria() { Codigo = 1, Nombre = "Aceites" };
            Categoria Pastas = new Categoria() { Codigo = 2, Nombre = "Pastas" };

            List<Articulo> articulos = new List<Articulo>();

            articulos.Add(new Articulo() { Codigo = 1, Nombre = "Aceite de Pino", Descripcion = "Aromatizante", Categoria = Aceites });
            articulos.Add(new Articulo() { Codigo = 2, Nombre = "Pasta Rojo", Descripcion = "Color para pintura", Categoria = Pastas });
            articulos.Add(new Articulo() { Codigo = 3, Nombre = "Pasta Ocre", Descripcion = "Color para pintura", Categoria = Pastas });

            return articulos;
        }       
        */
    }
}
