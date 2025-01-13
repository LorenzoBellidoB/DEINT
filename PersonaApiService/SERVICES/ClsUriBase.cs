using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public class ClsUriBase
    {
        /// <summary>
        /// Metodo para obtener la cadena de la Uri base
        /// </summary>
        /// <returns>Devuelve la cadena de la Uri</returns>
        public static String getMiCadenaUri()
        {
            return "https://lorenzoasp.azurewebsites.net/Api/PersonaApi";
        }
    }
}
