using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolares.ViewModels
{
    /// <summary>
    /// ViewModel que maneja el listado de clientes y el cliente seleccionado en la vista de la aplicación.
    /// </summary>
    class ListadoClienteVM
    {
        /// <summary>
        /// Lista de clientes obtenida de la capa de datos (DAL).
        /// </summary>
        public List<ClsCliente> ListaClientes { get; }

        /// <summary>
        /// Cliente actualmente seleccionado en la interfaz de usuario.
        /// </summary>
        public ClsCliente ClienteSeleccionado { get; set; }

        /// <summary>
        /// Constructor de la clase <see cref="ListadoClienteVM"/> que inicializa la lista de clientes 
        /// llamando al método <see cref="ListadoClientes.ListaClientes"/> para obtener los datos desde la capa de datos.
        /// </summary>
        public ListadoClienteVM()
        {
            ListaClientes = ListadoClientes.ListaClientes();
        }
    }
}
