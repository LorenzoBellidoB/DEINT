using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClsListadosDal
    {
        #region Atributos
        private static List<ClsMision> listadoMisiones = new List<ClsMision>
        {
            new ClsMision(1, "Recoger los impuestos en el restaurante", 1),
            new ClsMision(2,"Hacer una oferta que no puedan rechazar al sindicato de basura", 2),
            new ClsMision(3, "Supervisar obres en New Jersey", 3),
            new ClsMision(4,"Convencer al Concejal de urbanismo para conseguir favores", 4),
            new ClsMision(5, "Encargarse del concejal de urbanismo que no se dejó convencer", 5),
            new ClsMision(6, "Llevar la contabilidad del Bada Bing", 1)
        };

        // Listado de candidatos de la familia soprano
        private static List<ClsCandidato> listadoCandidatos = new List<ClsCandidato>
        {
            new ClsCandidato(1,"Vito", "Gordon","Pizza Street","USA","54567686",DateTime.Parse("10/11/1961"), 2500),
            new ClsCandidato(2, "Christopher", "Moltisanti", "St Monti","USA","123456789",DateTime.Parse("22/03/2000"),1500),
            new ClsCandidato(3, "Braulia", "Galliani", "Brooklyn", "USA", "54567686", DateTime.Parse("09/12/1998"), 2000),
            new ClsCandidato(4,"Paulie","Gualtieri","Soprano", "USA", "123456789", DateTime.Parse("24/07/1968"), 20000),
            new ClsCandidato(5,"Estas", "Caputo", "Via Bonna", "Italia", "123456789", DateTime.Parse("02/06/1973"), 14000),
            new ClsCandidato(6,"Toco","LÁcordeone","Via Musica", "Italia","654321890",DateTime.Parse("12/03/1984"), 16000),
            new ClsCandidato(7, "Luigi", "Peperoni", "Piaza Roma", "Italia","123987654", DateTime.Parse("05/04/1999"), 16000),
            new ClsCandidato(8, "Silvio", "Dante", "Town Street", "USA", "123459876", DateTime.Parse("10/01/1966"), 2000)
        };
        #endregion

        #region Métodos
        public static List<ClsMision> obtenerListadoMisionesDal()
        {
            return listadoMisiones;
        }

        public static List<ClsCandidato> obtenerListadoCandidatosDal()
        {
            return listadoCandidatos;
        }

        public static ClsMision buscarMisionPorIdDal(int idMision)
        {
            return listadoMisiones.First(mision => mision.IdMision == idMision);
        }

        public static ClsCandidato buscarCandidatoPorIdDal(int idCandidato)
        {
            return listadoCandidatos.First(candidato => candidato.Id == idCandidato);
        }
        #endregion
    }
}
