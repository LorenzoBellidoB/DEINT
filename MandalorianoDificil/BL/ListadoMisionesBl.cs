using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ListadoMisionesBl
    {
        // A partir de las 19:00 solo se mostraran las recompensas superiores 10000
		public static List<ClsMision> obtenerListadoMisionesBl()
        {
            List<ClsMision> listadoMisiones = ListadoMisionesDal.obtenerListadoMisionesDal();

            List<ClsMision> listadoMisionesAux = new List<ClsMision>();
            if(DateTime.Now.Hour >= 19)
            {
                foreach(ClsMision mision in listadoMisiones)
                {
                    if(mision.Recompensa > 10000)
                    {
                        listadoMisionesAux.Add(mision);
                    }
                }
            }
            return listadoMisionesAux;
            
        }

        public static ClsMision obtenerMisionPorIdBl(int idMision)
        {
            return ListadoMisionesDal.obtenerMisionPorIdBl(idMision);
        }
    }
}
