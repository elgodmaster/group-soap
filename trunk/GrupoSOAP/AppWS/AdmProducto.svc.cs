using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AppWS.Dominio;
using AppWS.Persistencia;

namespace AppWS
{

    public class AdmProducto : IAdmProducto
    {
        private ArticuloDAO productoDAO = null;
        private CategoriaDAO categoriaDAO = null;

        private ArticuloDAO ProductoDAO
        {
            get
            {
                if (productoDAO == null)
                    productoDAO = new ArticuloDAO();
                return productoDAO;
            }
        }

        private CategoriaDAO CategoriaDAO
        {
            get
            {
                if (categoriaDAO == null)
                    categoriaDAO = new CategoriaDAO();
                return categoriaDAO;
            }
        }

        public Articulo crear(string nombre, string descripcion, int categoria)
        {
            Categoria oCategoria = CategoriaDAO.Obtener(categoria);
            Articulo o = new Articulo()
            {
                Nombre = nombre,
                Descripcion = descripcion,
                Categoria = oCategoria
            };
            return ProductoDAO.Crear(o);
        }

        public Articulo modificar(int codigo, string nombre, string descripcion, int categoria)
        {
            Categoria oCategoria = CategoriaDAO.Obtener(categoria);
            Articulo o = new Articulo()
            {
                Codigo = codigo,
                Nombre = nombre,
                Descripcion = descripcion,
                Categoria = oCategoria
            };
            return ProductoDAO.Modificar(o);
        }

        public Articulo obtener(int codigo)
        {
            return ProductoDAO.Obtener(codigo);
        }

        public void eliminar(Articulo o)
        {
            ProductoDAO.Eliminar(o);
        }

        public List<Articulo> listar()
        {
            return ProductoDAO.ListarTodos().ToList();
        }

    }
}
