using Newtonsoft.Json;
using System.Net.Http;
using System;
using TesteVTBSolutionsUm.Dtos;
using TesteVTBSolutionsUm.Services.Interfaces;
using Newtonsoft.Json.Linq;
using System.Text;

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

        public async Task<Datum[]> FindAll()
        {
            var response = await _httpClient.GetAsync(Url + "?apiKey=" + ApiKey);

            response.EnsureSuccessStatusCode();

            var jsonResult = await response.Content.ReadAsStringAsync();

            JObject jObject = JObject.Parse(jsonResult);

            Datum[] retornoNuloArray = new Datum[1];

            Datum[] deserializedDatumArray;

            if (jObject != null)
            {
                deserializedDatumArray = JsonConvert.DeserializeObject<Datum[]>(jObject.SelectToken("data").ToString());

                return deserializedDatumArray;
            }

            return retornoNuloArray;
        }

        public async Task<Datum> FindBy(string id)
        {
            var response = await _httpClient.GetAsync(Url + $"{id}" + "?apiKey=" + ApiKey);

            response.EnsureSuccessStatusCode();

            var jsonResult = await response.Content.ReadAsStringAsync();

            Datum deserializedOportunidade;

            if (jsonResult != null)
            {
                deserializedOportunidade = JsonConvert.DeserializeObject<Datum>(jsonResult);

                return deserializedOportunidade;
            }

            return new Datum();
        }

        public async Task Create(Datum datum)
        {
            var json = JsonConvert.SerializeObject(datum);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            await _httpClient.PostAsync(Url + "?apiKey=" + ApiKey, content);
        }

        public async Task Update(DatumAtualiza datum)
        {
            var json = JsonConvert.SerializeObject(datum);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            await _httpClient.PatchAsync(Url + $"{datum._id.oid}" + "?apiKey=" + ApiKey, content);
        }

        public async Task<bool> Delete(string id)
        {
            var response = await _httpClient.DeleteAsync(Url + $"{id}" + "?apiKey=" + ApiKey);

            if (response.IsSuccessStatusCode)
                return true;
            else
                return false;
        }
    }
}
