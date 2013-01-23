using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAPServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Logo : ILogo
    {
        public string ObtenerLogo(int value)
        {
            return "Universidad Peruana de Ciencias Aplicadas";
        }

    }
}
