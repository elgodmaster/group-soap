using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AppWS.Dominio;
using AppWS.Persistencia;
using System.Net;

namespace AppWS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdmProveedor" in code, svc and config file together.
    public class AdmProveedor : IAdmProveedor
    {

        private ProveedorDAO proveedorDAO = null;

        private ProveedorDAO ProveedorDAO
        {
            get
            {
                if (proveedorDAO == null)
                    proveedorDAO = new ProveedorDAO();
                return proveedorDAO;
            }
        }


        public Proveedor CrearProveedor(Proveedor proveedorACrear)
        {
            Proveedor existe = ProveedorDAO.EncontrarProveedor(proveedorACrear);
            if (existe != null)
            {
                throw new WebFaultException<Error>(
                    new Error() {
                        Codigo = "ERR01",
                        Mensaje = "El Ruc o el Nombre del proveedor ingresado ya existe!"
                    }, HttpStatusCode.InternalServerError);

            }
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
