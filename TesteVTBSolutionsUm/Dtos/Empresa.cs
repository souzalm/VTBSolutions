using Newtonsoft.Json;

namespace TesteVTBSolutionsUm.Dtos
{
    public class Empresa
    {
        [JsonProperty("$oid")]
        public string oid { get; set; }
    }
}
