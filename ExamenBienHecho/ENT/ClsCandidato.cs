using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsCandidato
    {
        #region Atributos
        private int id;
        private string nombre;
        #endregion

        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region Constructores
        public ClsCandidato(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
        #endregion
    }
}
