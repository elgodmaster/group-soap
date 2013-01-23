using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOAPServices.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=(local); Initial Catalog=BD_WS;Integrated Security=SSPI;";
        }
    }
}
