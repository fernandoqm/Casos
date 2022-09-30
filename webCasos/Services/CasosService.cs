using Models.Entities;
using System.Net.Http.Json;
using webCasos.Services.Contracts;

namespace webCasos.Services
{
    public class CasosService: ICasosService
    {
        private readonly HttpClient httpClient;
        public CasosService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<casos>> getItems()
        {
            try
            {
                var response = await this.httpClient.GetAsync("GetCasos");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<casos>();
                    }

                    return await response.Content.ReadFromJsonAsync<IEnumerable<casos>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<casos> getItems(int id_caso)
        {
            try
            {
                var response = await httpClient.GetAsync($"GetCasosId/{id_caso}");
                if (response.IsSuccessStatusCode)
                {
                    if(response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(casos);
                    }

                    return await response.Content.ReadFromJsonAsync<casos>(); 
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<casos> getCasosUsuario(string pUsuario)
        {
            try
            {
                var response = await httpClient.GetAsync($"GetCasoUsuario/{pUsuario}");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(casos);
                    }

                    return await response.Content.ReadFromJsonAsync<casos>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
