using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public class Services
    {
        public static async Task<List<ClsPersona>> getPersonas()

        {

            //Pido la cadena de la Uri al método estático

            string miCadenaUrl = ClsUriBase.getMiCadenaUri();

            Uri miUri = new Uri($"{miCadenaUrl}");

            List<ClsPersona> listadoPersona = new List<ClsPersona>();

            HttpClient mihttpClient;

            HttpResponseMessage miCodigoRespuesta;

            string textoJsonRespuesta;

            //Instanciamos el cliente Http

            mihttpClient = new HttpClient();

            try

            {

                miCodigoRespuesta = await mihttpClient.GetAsync(miUri);

                if (miCodigoRespuesta.IsSuccessStatusCode)

                {

                    textoJsonRespuesta = await mihttpClient.GetStringAsync(miUri);

                    mihttpClient.Dispose();

                    //JsonConvert necesita using Newtonsoft.Json;

                    //Es el paquete Nuget de Newtonsoft

                    listadoPersona = JsonConvert.DeserializeObject<List<ClsPersona>>(textoJsonRespuesta);

                }

            }

            catch (Exception ex)

            {

                throw ex;

            }

            return listadoPersona;

        }
        public static async Task<HttpStatusCode> eliminarPersona(int id)

        {

            HttpClient mihttpClient = new HttpClient();

            string datos;

            HttpContent contenido;

            string miCadenaUrl = ClsUriBase.getMiCadenaUri();

            Uri miUri = new Uri($"{miCadenaUrl}/{id}");

            //Usaremos el Status de la respuesta para comprobar si ha borrado

            HttpResponseMessage miRespuesta = new HttpResponseMessage();

            try

            {

                miRespuesta = await mihttpClient.DeleteAsync(miUri);


            }

            catch (Exception ex)

            {

                throw ex;

            }

            return miRespuesta.StatusCode;

        }

    }
}
