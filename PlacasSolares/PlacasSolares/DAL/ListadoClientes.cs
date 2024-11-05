using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Clase que representa una lista de clientes.
    /// </summary>
    public class ListadoClientes
    {
        /// <summary>
        /// Método que genera y devuelve una lista predefinida de clientes.
        /// </summary>
        /// <returns>Una lista de objetos <see cref="ClsCliente"/> predefinidos.</returns>
        public static List<ClsCliente> ListaClientes()
        {
            // Inicializa la lista de clientes
            List<ClsCliente> listado = new List<ClsCliente>();

            // Definición de clientes individuales
            ClsCliente c1 = new ClsCliente();
            c1.Nombre = "Eduardo Arnesto";
            c1.Descripcion = "Mu Buencha";
            c1.Observaciones = "No tan buencha";

            ClsCliente c2 = new ClsCliente();
            c2.Nombre = "Hector Arias";
            c2.Descripcion = "Mu Buencha";
            c2.Observaciones = "No tan buencha";

            ClsCliente c3 = new ClsCliente();
            c3.Nombre = "Marco Holguin";
            c3.Descripcion = "Mu Buencha";
            c3.Observaciones = "No tan buencha";

            // Agrega clientes a la lista usando el constructor de ClsCliente
            listado.Add(new ClsCliente("Eduardo Arnesto", "Mu Buencha", "No tan buencha"));
            listado.Add(new ClsCliente("Hector Arias", "Mu Buencha", "No tan buencha"));
            listado.Add(new ClsCliente("Marco Holguin", "Mu Buencha", "No tan buencha"));

            return listado;
        }
    }
}
