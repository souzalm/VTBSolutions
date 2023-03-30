using Newtonsoft.Json;

namespace TesteVTBSolutionsUm.Dtos
{
    public class Id
    {
        [JsonProperty("$oid")]
        public string oid { get; set; }
    }
}
