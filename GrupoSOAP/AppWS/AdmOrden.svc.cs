using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AppWS.Persistencia;
using AppWS.Dominio;

namespace AppWS
{
 
    public class AdmOrden : IAdmOrden
    {
        private OrdenDAO ordenDAO = null;

        private OrdenDAO OrdenDAO
        {
            get
            {
                if (ordenDAO == null)
                    ordenDAO = new OrdenDAO();
                return ordenDAO;
            }
        }


        public Orden crear(string fecha, string proveedor, string observacion)
        {
            Orden  o = new Orden()
            {
                fecha= fecha,
                proveedor  =  proveedor ,
                observacion  = observacion 
            };
            return OrdenDAO.Crear(o);
        }

        public List<Orden> listar()
        {
            return OrdenDAO.ListarTodos().ToList();
        }
    }
}
