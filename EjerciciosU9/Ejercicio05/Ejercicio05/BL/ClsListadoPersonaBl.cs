using ENT;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClsListadoPersonaBl
    {
        private static List<ClsPersona> listadoPersonasBl = new List<ClsPersona>();

        /// <summary>
        /// Métosdo para obtener un listado de personas según las normas de la empresa
        /// </summary>
        /// <returns>Listado de personas</returns>
        public static List<ClsPersona> ObtenerListadoBl()
        {
            try
            {
                listadoPersonasBl = ClsListadoPersonaDal.ObtenerListadoDal();
                
            }catch(Exception e)
            {
                e.Message.ToString();
            }
                 return listadoPersonasBl;
        }
    }
}
