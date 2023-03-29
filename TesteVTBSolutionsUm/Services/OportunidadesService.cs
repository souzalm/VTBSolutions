using Newtonsoft.Json;
using TesteVTBSolutionsUm.Dtos;
using TesteVTBSolutionsUm.Services.Interfaces;

namespace TesteVTBSolutionsUm.Services
{
    public class OportunidadesService : IOportunidadesService
    {
        private readonly HttpClient _httpClient;
        private string ApiKey { get; set; } = "6421ff47094897945fa11f80";
        private string Url { get; set; } = "https://nocodebackend-nocodebackend-stage.azurewebsites.net/api/v1/workflowdata/642208b8094897945fa1202c/611ee144fd5915f2ae005def/";

        public OportunidadesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /*public async Task<List<OportunidadeDto>> FindAll()
        }
        }*/

        public async Task<OportunidadeDto> FindBy(int id)
        {
            var response = await _httpClient.GetAsync(Url + id + "?apiKey=" + ApiKey);

            response.EnsureSuccessStatusCode();

            var jsonResult = await response.Content.ReadAsStringAsync();

            OportunidadeDto deserializedOportunidade;

            if (jsonResult != null)
            {
                deserializedOportunidade = JsonConvert.DeserializeObject<OportunidadeDto>(jsonResult);
                return deserializedOportunidade;
            }

            return new OportunidadeDto();
        }
    }
}
