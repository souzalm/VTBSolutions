using Newtonsoft.Json;

namespace TesteVTBSolutionsUm.Dtos
{
    public class DueDate
    {
        [JsonProperty("$date")]
        public DateTime date { get; set; }
    }
}
