using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClsListadoDal
    {
        private static List<ClsCandidato> listadoCandidatos = new List<ClsCandidato>
        {
            new ClsCandidato(1, "Paulie Gualtieri"),
            new ClsCandidato(2, "Christopher Moltisanti"),
            new ClsCandidato(3,"Silvio Dante"),
            new ClsCandidato(4,"Vito Spatafore"),
            new ClsCandidato(5,"Ralph Cifaretto"),
            new ClsCandidato(6,"Furio Giunta"),
            new ClsCandidato(7,"Carlo Gervasi"),
            new ClsCandidato(8,"Jackie Aprile, Jr."),
            new ClsCandidato(9,"Richie Aprile"),
            new ClsCandidato(10,"Bobby Baccalieri"),
            new ClsCandidato(11,"Phil Leotardo"),
            new ClsCandidato(12,"Big Pussy Bonpensiero"),
            new ClsCandidato(13,"Benny Fazio"),
            new ClsCandidato(14,"Tony Blundetto"),
            new ClsCandidato(15,"Little Paulie Germani")
        };

        public static List<ClsCandidato> obtenerCandidatos()
        {
            return listadoCandidatos;
        }
    }
}
