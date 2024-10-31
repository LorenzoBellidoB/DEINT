using ListadoPersonaENT;
using ListadoPersonaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadoPersonaMaui.ViewModels
{
    internal class MainPageVM
    {
        private List<Persona> listado;

        public List<Persona> Listado
        {
            get {
                listado = ListadoPersona.GetListadoCompleto();
                return listado; 
            }
        }
    }
}
