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


        public static List<ClsPersona> ObtenerListadoBl()
        {
            listadoPersonasBl = ClsListadoPersonaDal.ObtenerListadoDal();

            return listadoPersonasBl;
        }
    }
}
