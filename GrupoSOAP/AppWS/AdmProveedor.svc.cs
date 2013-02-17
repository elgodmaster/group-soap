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
using System.Messaging;

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

        string rutaCola = @".\private$\grupoSOAP";

        public Proveedor CrearProveedor(Proveedor proveedorACrear)
        {
            Proveedor existe = ProveedorDAO.EncontrarProveedor(proveedorACrear);
            if (existe != null)
            {
                // Cada vez que ocurra un problema al registrar un proveedor que envíe un mensaje al admin
                if (!MessageQueue.Exists(rutaCola))
                    MessageQueue.Create(rutaCola);
                MessageQueue cola = new MessageQueue(rutaCola);
                Message mensaje = new Message();
                mensaje.Label = "ERR";
                mensaje.Body = new Error()
                {
                    Codigo = "ERR01",
                    Mensaje = "Hubo un error al insertar el proveedor " + proveedorACrear.Ruc + "."
                };
                cola.Send(mensaje);
                // verificar la existencia del mensaje en la cola.


                throw new WebFaultException<Error>(
                    new Error() {
                        Codigo = "ERR01",
                        Mensaje = "El proveedor ingresado ya existe!"
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
