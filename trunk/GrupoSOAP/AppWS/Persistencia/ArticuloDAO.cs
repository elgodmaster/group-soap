using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppWS.Dominio;
using NHibernate;
using NHibernate.Criterion;

namespace AppWS.Persistencia
{
    public class ArticuloDAO : BaseDAO<Articulo, int, string>
    {
        public int EncontrarArticulo(Articulo o)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICriteria criteria = sesion.CreateCriteria(typeof(Articulo));
                criteria.Add(Restrictions.Eq("Nombre", o.Nombre));
               
                return criteria.List<Articulo>().Count();

            }
        }

    }
}