using ENT;
using DTO;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace DAL
{
    public class Services
    {

        public static async Task<List<ClsPokemon>> getPokemons(int ultimoId, int limite)

        {

            //Pido la cadena de la Uri al método estático

            string miCadenaUrl = ClsUriBase.getMiCadenaUri();

            Uri miUri = new Uri($"{miCadenaUrl}?offset={ultimoId}&limit={limite}");

            List<ClsPokemon> listadoPokemon = new List<ClsPokemon>();

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

                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(textoJsonRespuesta);

                    listadoPokemon = apiResponse.Results;
                }

            }

            catch (Exception ex)

            {

                throw ex;

            }

            return listadoPokemon;

        }

    }
}
