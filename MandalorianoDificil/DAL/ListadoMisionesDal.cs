using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ListadoMisionesDal
    {
        private static List<ClsMision> listadoMisiones = new List<ClsMision>
        {
            new ClsMision(1, "Rescate de Baby Yoda", "Debes hacerte con Grogu y llevárselo a Luke SkyWalker para su entrenamiento.", 15000),
            new ClsMision(2, "Recuperar armadura Beskar", "Tu armadura de Beskar ha sido robada. Debes encontrarla.", 2000),
            new ClsMision(3, "Planeta Sorgon", "Debes llevar a un niño de vuelta a su planeta natal “Sorgon”.", 500),
            new ClsMision(4, "Renacuajos", "Debes llevar a una Dama Rana y sus huevos de Tatooine a la luna del estuario Trask, donde su esposo fertilizará los huevos.", 500)
        };

        public static List<ClsMision> obtenerListadoMisionesDal()
        {
            return listadoMisiones;
        }

        public static ClsMision obtenerMisionPorIdBl(int id)
        {
            return listadoMisiones.First(m => m.IdMision == id);
        }
    }
}
