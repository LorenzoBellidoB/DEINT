using ListadoPersonaDAL;
using ListadoPersonaENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoPersonaBL
{
    public class ListadoBL
    {
        public static List<Persona> listadoPersonaBL()
        {
            List<Persona> miListado = ListadoPersona.GetListadoCompleto();
            //TODO Comprobar si es jueves y antes o no de las 13:30
        
            return miListado;
        }
    }
}
