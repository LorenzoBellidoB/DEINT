using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ClsCliente
    {
        #region Atributos
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;
        #endregion

        #region Propiedades
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }
        #endregion
    }
}
