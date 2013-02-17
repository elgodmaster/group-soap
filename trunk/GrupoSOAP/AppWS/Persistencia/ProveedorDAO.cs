using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppWS.Dominio;
using NHibernate;
using NHibernate.Criterion;

namespace AppWS.Persistencia
{
    public class ProveedorDAO : BaseDAO<Proveedor, int, string>
    {
        public Proveedor EncontrarProveedor(Proveedor o)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICriteria criteria = sesion.CreateCriteria(typeof(Proveedor));
                criteria.Add(Restrictions.Eq("Ruc", o.Ruc));
                //criteria.Add(Restrictions.Eq("Nombre", o.Nombre));
                //criteria.Add(Restrictions.Eq("NombreContacto", o.NombreContacto));
                //criteria.Add(Restrictions.Eq("TelefonoContacto", o.TelefonoContacto));
                List<Proveedor> list = criteria.List<Proveedor>().ToList();
                if (list.Count() > 0) {
                    return list.ElementAt(0);
                }else{
                    return null;
                }
                
            }
        }

    }
}