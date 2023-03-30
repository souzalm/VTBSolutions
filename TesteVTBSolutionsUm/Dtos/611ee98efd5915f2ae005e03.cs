using Newtonsoft.Json;

namespace TesteVTBSolutionsUm.Dtos
{
    public class _611ee98efd5915f2ae005e03
    {
        public Id _id { get; set; }
        public DateCreated DateCreated { get; set; }
        public DateModified DateModified { get; set; }
        public bool Active { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }

        [JsonProperty("E-mail")]
        public string Email { get; set; }
        public string Telefone { get; set; }

        [JsonProperty("Cartão de Visita")]
        public List<object> CartodeVisita { get; set; }
        public Empresa Empresa { get; set; }
    }
}
