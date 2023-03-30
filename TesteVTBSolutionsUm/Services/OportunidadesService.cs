using Newtonsoft.Json;
using System.Net.Http;
using System;
using TesteVTBSolutionsUm.Dtos;
using TesteVTBSolutionsUm.Services.Interfaces;
using Newtonsoft.Json.Linq;

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
                
                int countArray = deserializedDatumArray.Length;

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
    }
}
