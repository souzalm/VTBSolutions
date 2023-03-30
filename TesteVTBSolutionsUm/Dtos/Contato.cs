using Newtonsoft.Json;

namespace TesteVTBSolutionsUm.Dtos
{
    public class Contato
    {
        [JsonProperty("$oid")]
        public string oid { get; set; }
    }
}
