using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsRecibo
    {
        #region Atributos
        private int id;
        private DateTime fecha = DateTime.Now;
        private int idCliente;
        private double total;
        #endregion

        #region Propiedades
        public int Id { get{ return id; } set { id = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public int IdCliente { get { return idCliente; } set { idCliente = value; } }
        public double Total { get { return total; } set { total = value; } }    
        #endregion
    }
}
