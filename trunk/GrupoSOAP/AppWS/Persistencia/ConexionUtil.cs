using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppWS.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=GIANI\\SQLEXPRESS;Initial Catalog=BD_WS;Integrated Security=SSPI;";
        }
    }
}