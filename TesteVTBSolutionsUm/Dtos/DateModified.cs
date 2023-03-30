using Newtonsoft.Json;

namespace TesteVTBSolutionsUm.Dtos
{
    public class DateModified
    {
        [JsonProperty("$date")]
        public DateTime date { get; set; }
    }
}
