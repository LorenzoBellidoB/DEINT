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
        /// <summary>
        /// Método para obtener el listado de personas de la API
        /// Pre: None
        /// Post: Devuelve un listado de personas que puede ser nulo si viene vacio
        /// </summary>
        /// <returns>Devuelve un listado de personas</returns>
        public static async Task<List<ClsPersona>> GetPersonas()

        {

            //Pido la cadena de la Uri al método estático

            string miCadenaUrl = ClsUriBase.getMiCadenaPersonas();

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

        /// <summary>
        /// Método para obtener el listado de departamentos de la API
        /// Pre: None
        /// Post: Devuelve un listado de departamentos que puede ser nulo si viene vacio
        /// </summary>
        /// <returns>Devuelve un listado de departamentos</returns>
        public static async Task<List<ClsDepartamento>> GetDepartamentos()

        {

            //Pido la cadena de la Uri al método estático

            string miCadenaUrl = ClsUriBase.getMiCadenaDepartamentos();

            Uri miUri = new Uri($"{miCadenaUrl}");

            List<ClsDepartamento> listadoDepartamentos = new List<ClsDepartamento>();

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

                    listadoDepartamentos = JsonConvert.DeserializeObject<List<ClsDepartamento>>(textoJsonRespuesta);

                }

            }

            catch (Exception ex)

            {

                throw ex;

            }

            return listadoDepartamentos;

        }

        /// <summary>
        /// Metodo para eliminar una persona de la API
        /// Pre: None
        /// Post: Devuelve el codigo de la respuesta
        /// </summary>
        /// <param name="id">Id de la persona</param>
        /// <returns>Devuelve el codigo de la respuesta</returns>
        public static async Task<HttpStatusCode> EliminarPersona(int id)

        {

            HttpClient mihttpClient = new HttpClient();

            string datos;

            HttpContent contenido;

            string miCadenaUrl = ClsUriBase.getMiCadenaPersonas();

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

        /// <summary>
        /// Metodo para crear una persona en la API
        /// Pre: Debe llegar un objeto de tipo persona
        /// Post: Devuelve el codigo de la respuesta
        /// </summary>
        /// <param name="persona">Persona a crear</param>
        /// <returns>Devuelve el codigo de la respuesta</returns>
        public static async Task<HttpStatusCode> CrearPersona(ClsPersona persona)
        {
            HttpClient mihttpClient = new HttpClient();

            string datos;

            HttpContent contenido;

            string miCadenaUrl = ClsUriBase.getMiCadenaPersonas();

            Uri miUri = new Uri($"{miCadenaUrl}");

            //Usaremos el Status de la respuesta para comprobar si ha borrado

            HttpResponseMessage miRespuesta = new HttpResponseMessage();

            try

            {

                datos = JsonConvert.SerializeObject(persona);

                contenido = new StringContent(datos, System.Text.Encoding.UTF8, "application/json");

                miRespuesta = await mihttpClient.PostAsync(miUri, contenido);

            }

            catch (Exception ex)

            {

                throw ex;

            }

            return miRespuesta.StatusCode;
        }

        /// <summary>
        /// Metodo para editar una persona en la API
        /// Pre: Debe llegar un objeto de tipo persona
        /// Post: Devuelve el codigo de la respuesta
        /// </summary>
        /// <param name="persona">Persona a editar</param>
        /// <returns>Devuelve el codigo de la respuesta-+</returns>
        public static async Task<HttpStatusCode> EditarPersona(ClsPersona persona)
        {
            HttpClient mihttpClient = new HttpClient();

            string datos;

            HttpContent contenido;

            string miCadenaUrl = ClsUriBase.getMiCadenaPersonas();

            Uri miUri = new Uri($"{miCadenaUrl}/{persona.Id}");

            //Usaremos el Status de la respuesta para comprobar si ha borrado

            HttpResponseMessage miRespuesta = new HttpResponseMessage();

            try

            {

                datos = JsonConvert.SerializeObject(persona);

                contenido = new StringContent(datos, System.Text.Encoding.UTF8, "application/json");

                miRespuesta = await mihttpClient.PutAsync(miUri, contenido);

            }

            catch (Exception ex)

            {

                throw ex;

            }

            return miRespuesta.StatusCode;
        }

    }
}
