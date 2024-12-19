using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsProducto
    {
        #region Atributos
        private int id;
        private string nombre;
        private double precio;
        #endregion

        #region Propiedades
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        #endregion
    }
}
