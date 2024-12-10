using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClsListadoBl
    {
        /// <summary>
        /// Obtiene los candidatos para las rondas de manera aleatoria 
        /// </summary>
        /// <param name="rondas">Numero de rondas por partida</param>
        /// <returns>Devuelve una lista de candidatos aleatorios</returns>
        public static List<ClsCandidato> obtenerCandidatosAleatoriosRondasBl(int rondas)
        {
            List<ClsCandidato> listadoCandidatos = ClsListadoDal.obtenerCandidatos();

            List<ClsCandidato> candidatosAleatorios = new List<ClsCandidato>();

            candidatosAleatorios = listadoCandidatos.OrderBy(x => Guid.NewGuid()).Take(rondas).ToList();

            return candidatosAleatorios;
        }

		public static List<ClsCandidato> obtenerCandidatosParaPreguntaBl(int opciones, int idCandidato)
        {

            List<ClsCandidato> listadoCandidatos = ClsListadoDal.obtenerCandidatos();


        }
    }
}
