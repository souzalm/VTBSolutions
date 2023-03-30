using Newtonsoft.Json;

namespace TesteVTBSolutionsUm.Dtos
{
    public class CurrentPhaseId
    {
        [JsonProperty("$oid")]
        public string oid { get; set; }
    }
}
