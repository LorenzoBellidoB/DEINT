using ENT;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClsListadosDal
    {
        /// <summary>
        /// Devuelve un listado de clientes de la base de datos de azure
        /// </summary>
        /// <returns>listado de clientes</returns>
        public static List<ClsCliente> ListadoCompletoClientesDal()
        {
            List<ClsCliente> clientes = new List<ClsCliente>();

            ClsConexionDal miConexion = new ClsConexionDal();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            ClsCliente oCliente;

            try
            {


                miComando.CommandText = "SELECT * FROM clientes";

                miComando.Connection = miConexion.ObtenerConexion(); ;

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oCliente = new ClsCliente();

                        oCliente.Id = (int)miLector["ID"];

                        oCliente.Nombre = (string)miLector["Nombre"];

                        if (miLector["Direccion"] != System.DBNull.Value)

                        { oCliente.Direccion = (string)miLector["Direccion"]; }

                        if (miLector["Telefono"] != System.DBNull.Value)

                        { oCliente.Telefono = (string)miLector["Telefono"]; }


                        clientes.Add(oCliente);
                    }
                }
                miLector.Close();


            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                miConexion.Desconectar();
            }
            return clientes;
        }

        /// <summary>
        /// Devuelve un listado de productos de la base de datos de azure
        /// </summary>
        /// <returns>listado de productos</returns>
        public static List<ClsProducto> ListadoCompletoProductosDal()
        {
            List<ClsProducto> productos = new List<ClsProducto>();

            ClsConexionDal miConexion = new ClsConexionDal();

            SqlCommand miComando = new SqlCommand();

            SqlDataReader miLector;

            ClsProducto oProducto;

            try
            {

                miComando.CommandText = "SELECT * FROM productos";

                miComando.Connection = miConexion.ObtenerConexion(); ;

                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {
                    while (miLector.Read())
                    {
                        oProducto = new ClsProducto();

                        oProducto.Id = (int)miLector["ID"];

                        oProducto.Nombre = (string)miLector["Nombre"];

                        oProducto.Precio = (double)miLector["Precio"];

                        productos.Add(oProducto);
                    }
                }
                miLector.Close();


            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                miConexion.Desconectar();
            }
            return productos;
        }
    }
}

