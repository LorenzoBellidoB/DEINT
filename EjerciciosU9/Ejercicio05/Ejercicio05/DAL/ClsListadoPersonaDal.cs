using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClsListadoPersonaDal
    {
        private static List<ClsPersona> ListadoPersonasDal = new List<ClsPersona>();

        /// <summary>
        /// Métosdo para obtener un listado completo de personas
        /// </summary>
        /// <returns>Listado de personas</returns>
        public static List<ClsPersona> ObtenerListadoDal()
        {
            try
            {
                ClsPersona p1 = new ClsPersona("Pepe", "Garcia", DateTime.Parse("01/01/2000"), "https://thispersondoesnotexist.com", "Calle La Campana 1", "643789541");
                ClsPersona p2 = new ClsPersona("Hector", "Arias", DateTime.Parse("01/01/2000"), "https://thispersondoesnotexist.com", "Calle La Campana 2", "643789542");
                ClsPersona p3 = new ClsPersona("Marco", "Holguín", DateTime.Parse("01/01/2000"), "https://thispersondoesnotexist.com", "Calle La Campana 3", "643789543");
                ClsPersona p4 = new ClsPersona("Raul", "Romera", DateTime.Parse("01/01/2000"), "https://thispersondoesnotexist.com", "Calle La Campana 4", "643789544");
                ClsPersona p5 = new ClsPersona("Pablo", "Carbonero", DateTime.Parse("01/01/2000"), "https://thispersondoesnotexist.com", "Calle La Campana 5", "643789545");
                ClsPersona p6 = new ClsPersona("Edu", "Arnesto", DateTime.Parse("01/01/2000"), "https://thispersondoesnotexist.com", "Calle La Campana 6", "643789546");

                ListadoPersonasDal.Add(p1);
                ListadoPersonasDal.Add(p2);
                ListadoPersonasDal.Add(p3);
                ListadoPersonasDal.Add(p4);
                ListadoPersonasDal.Add(p5);
                ListadoPersonasDal.Add(p6);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            return ListadoPersonasDal;
        }

        public static List<ClsPersona> ObtenerListadoBusquedaDal(string busqueda)
        {
            List<ClsPersona> listaBusqueda = new List<ClsPersona>();
            foreach (ClsPersona persona in ListadoPersonasDal)
            {
                if(persona.Nombre.Contains(busqueda) || persona.Apellido.Contains(busqueda))
                {
                    listaBusqueda.Add(persona);
                    
                }
            }
            return listaBusqueda;
        }
    }
}
