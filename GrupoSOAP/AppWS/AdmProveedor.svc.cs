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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdmProveedor" in code, svc and config file together.
    public class AdmProveedor : IAdmProveedor
    {

        private ProveedorDAO ProveedorDAO = new ProveedorDAO();


        public Proveedor CrearProveedor(Proveedor proveedorACrear)
        {
            return ProveedorDAO.Crear(proveedorACrear);
        }

        public Proveedor ObtenerProveedor(string codigo)
        {
            return ProveedorDAO.Obtener(int.Parse(codigo));
        }

        public Proveedor ModificarProveedor(Proveedor proveedorAModificar)
        {
            return ProveedorDAO.Modificar(proveedorAModificar);
        }

    
        public List<Proveedor> ListarProveedores()
        {
            return ProveedorDAO.ListarTodos().ToList();
        }
    }
}
