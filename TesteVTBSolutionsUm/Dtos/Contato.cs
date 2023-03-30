using Newtonsoft.Json;
using System.ComponentModel;

namespace TesteVTBSolutionsUm.Dtos
{
    public class Contato
    { 
        [JsonProperty("$oid")]
        public string oid { get; set; }
    }
}
