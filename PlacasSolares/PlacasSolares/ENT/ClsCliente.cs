using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    /// <summary>
    /// Representa un cliente con propiedades básicas como nombre, descripción y observaciones.
    /// </summary>
    public class ClsCliente
    {
        /// <summary>
        /// Constructor por defecto para la clase <see cref="ClsCliente"/>.
        /// </summary>
        public ClsCliente() { }

        /// <summary>
        /// Constructor que permite inicializar un nuevo cliente con nombre, descripción y observaciones específicas.
        /// </summary>
        /// <param name="nombre">El nombre del cliente.</param>
        /// <param name="descripcion">Descripción breve del cliente.</param>
        /// <param name="observaciones">Observaciones adicionales sobre el cliente.</param>
        public ClsCliente(string nombre, string descripcion, string observaciones)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Observaciones = observaciones;
        }

        /// <summary>
        /// Obtiene o establece el nombre del cliente.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Obtiene o establece una breve descripción del cliente.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Obtiene o establece observaciones adicionales sobre el cliente.
        /// </summary>
        public string Observaciones { get; set; }
    }
}
