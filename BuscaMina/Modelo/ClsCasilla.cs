using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClsCasilla
    {
        #region Atributos
        private bool esBomba;

        private bool revelado = false;

        private string imagen = "noRevelado.png";
        #endregion

        #region Propiedades
        public bool EsBomba { get; set; }
        public bool Revelado { get; set; }
        public string Imagen { get; }
        #endregion
    }
}
