using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClsListadoBl
    {
        public static List<ClsCliente> obtenerTodosClientes()
        {
            return ClsListadosDal.ListadoCompletoClientesDal();
        }

        public static List<ClsProducto> obtenerTodosProductos()
        {
            return ClsListadosDal.ListadoCompletoProductosDal();
        }

        public static List<ClsRecibo> obtenerTodosRecibos() 
        {
            return ClsListadosDal.ListadoCompletoRecibosDal(); 
        }

        public static List<ClsDetalleRecibo> obtenerTodosDetallesRecibos() 
        { 
            return ClsListadosDal.ListadoCompletoDatallesReciboDal(); 
        }
    }
}
