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
            List<Persona> miListado;
            List<Persona> completo = ListadoPersona.GetListadoCompleto();

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                if (DateTime.Now.Hour <= 13 && DateTime.Now.Minute == 30)
                {
                    miListado = completo.Take(5).ToList();
                }
                else
                {
                    miListado = completo.Skip(Math.Max(0, completo.Count - 5)).ToList();
                }
            }
            else
            {
                miListado = completo;
            }
                return miListado;
        }
    }
}
