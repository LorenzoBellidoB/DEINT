using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClsListadosBl
    {
        public static List<ClsMision> obtenerListadoMisionesBl()
        {
            return ClsListadosDal.obtenerListadoMisionesDal();
        }

        public static List<ClsCandidato> obtenerListadoCandidatosBl(int dificultad)
        {
            List<ClsCandidato> listadoCandidatos = ClsListadosDal.obtenerListadoCandidatosDal();

            List<ClsCandidato> listadoCandidatosFiltrado = new List<ClsCandidato>();

            foreach (ClsCandidato candidato in listadoCandidatos)
            {
                switch (dificultad)
                {
                    case 1 or 2:
                        {
                            if(candidato.Pais == "USA")
                            {
                                listadoCandidatosFiltrado.Add(candidato);
                            }

                            break;
                        }
                    case 3:
                        {
                            if(candidato.Pais == "USA" && DateTime.Now.Year - candidato.FechaNac.Year >= 40)
                            {
                                listadoCandidatosFiltrado.Add(candidato);
                            }
                            break;
                        }
                    case 4:
                        {
                            if (candidato.Pais == "Italia" && DateTime.Now.Year - candidato.FechaNac.Year <= 45)
                            {
                                listadoCandidatosFiltrado.Add(candidato);
                            }
                            break;
                        }
                    case 5:
                        {
                            if (candidato.Pais == "Italia" && DateTime.Now.Year - candidato.FechaNac.Year >= 45 && DateTime.Now.Year - candidato.FechaNac.Year <= 55)
                            {
                                listadoCandidatosFiltrado.Add(candidato);
                            }
                            break;
                        }
                }
            }
            return listadoCandidatosFiltrado;

        }

        public static ClsMision buscarMisionPorIdBl(int idMision)
        {
            return ClsListadosDal.buscarMisionPorIdDal(idMision);
        }

        public static ClsCandidato buscarCandidatoPorIdBl(int idCandidato)
        {
            return ClsListadosDal.buscarCandidatoPorIdDal(idCandidato);
        }
    }
}
