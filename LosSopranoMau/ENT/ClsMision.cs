using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsMision
    {
        #region Atributos
        private int idMision;
        private string nombre;
        private int dificultad;
        #endregion

        #region Propiedades
        public int IdMision { get{ return idMision; } }
        public string Nombre { get{ return nombre; } set{ nombre = value; } }
        public int Dificultad { get{ return dificultad; } set{ dificultad = value; } }
        #endregion

        #region Constructores
        public ClsMision(int idMision, string nombre, int dificultad)
        {
            this.idMision = idMision;
            this.nombre = nombre;
            this.dificultad = dificultad;
        }
        #endregion
    }
}
