using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsDetalleRecibo
    {
        #region Atributos
        private int id;
        private int idrecibo;
        private int idproducto;
        private int cantidad;
        private double subtotal;
        #endregion

        #region Propiedades
        public int Id { get { return id; } set { id = value; } }
        public int IdRecibo { get { return idrecibo; } set { idrecibo = value; } }
        public int IdProducto { get { return idproducto; } set { idproducto = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public double Subtotal { get { return subtotal; } set { subtotal = value; } }
        #endregion
    }
}
