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

        private List<Articulo> CrearArticulos() 
        {

            Categoria Aceites = new Categoria() { Codigo = 1, Nombre = "Aceites" };
            Categoria Pastas = new Categoria() { Codigo = 2, Nombre = "Pastas" };

            List<Articulo> articulos = new List<Articulo>();

            articulos.Add(new Articulo() { Codigo = 1, Nombre = "Aceite de Pino", Descripcion = "Aromatizante", Categorias = Aceites });
            articulos.Add(new Articulo() { Codigo = 2, Nombre = "Pasta Rojo", Descripcion = "Color para pintura", Categorias = Pastas });
            articulos.Add(new Articulo() { Codigo = 3, Nombre = "Pasta Ocre", Descripcion = "Color para pintura", Categorias = Pastas });

            return articulos;
        }

        private Articulo ObtenerArticulo(int Codigo) 
        {
            List<Articulo> Articulos = (List<Articulo>)Session["articulos"];

            Articulo model = Articulos.Single(delegate(Articulo articulo)
            {

                if (articulo.Codigo == Codigo) return true;
                else return false;
            });

            return model;
        }

        
        //
        // GET: /Articulo/

        public ActionResult Index() //muestra pagina con lista de articulos
        {

            if (Session["articulos"] == null)
                Session["articulos"] = CrearArticulos();

            List<Articulo> model = (List<Articulo>)Session["articulos"];
            return View(model);

        }

        //
        // GET: /Articulo/Details/5

        public ActionResult Details(int id)
        {
            Articulo model = ObtenerArticulo(id);
            return View(model);
        } //muestra pagina con datos de un articulo

        //
        // GET: /Articulo/Create

        public ActionResult Create() //Muestra pagina para crear datos de creacion 
        {
            return View();
        } 

        //
        // POST: /Articulo/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection) //Recibe los datos del formulario y realiza creacion
        {
            try
            {

                List<Articulo> Articulos = (List<Articulo>)Session["articulos"];
                Articulos.Add(new Articulo()
                    {
                        Codigo = int.Parse(collection["Codigo"]),
                        Nombre = collection["Nombre"],
                        Descripcion = collection["Descripcion"],
                        Categorias = new Categoria()
                        {
                            Codigo = int.Parse(collection["Categorias.Codigo"]),
                            Nombre = collection["Categorias.Nombre"]

                        }

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
            Articulo model = ObtenerArticulo(id);
            return View(model);
        }

        //
        // POST: /Articulo/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection) //Recibe Datos de formulario y realiza modificacion
        {
            try
            {
                Articulo model = ObtenerArticulo(id);
                model.Nombre = collection["Nombre"];
                model.Descripcion = collection["Descripcion"];

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Articulo/Delete/5       

        public ActionResult Delete(int id) //Muestra pagina para confirmar eliminacion
        {

            Articulo model = ObtenerArticulo(id);
            
            return View(model);
        }

        //
        // POST: /Articulo/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) //realiza la eliminacion
        {
            try
            {
                List<Articulo> Articulos = (List<Articulo>)Session["articulos"];
                Articulos.Remove(ObtenerArticulo(id));

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
