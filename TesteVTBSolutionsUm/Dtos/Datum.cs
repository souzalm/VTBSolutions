using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace TesteVTBSolutionsUm.Dtos
{
    public class Datum
    {
        public Id _id { get; set; }
        public DateCreated DateCreated { get; set; }
        public DateModified DateModified { get; set; }
        public bool Active { get; set; }
        public string CreatedByUser { get; set; }
        public string ModifiedByUser { get; set; }

        [JsonProperty("Nome da Oportunidade")]
        public string NomedaOportunidade { get; set; }
        public object Qualificao { get; set; }
        public object Valor { get; set; }
        public object Observaes { get; set; }
        public List<Contato> Contatos { get; set; }

        [JsonProperty("Produtos / Serviços")]
        public object ProdutosServios { get; set; }
        public double PhaseIndex { get; set; }
        public object Comments { get; set; }
        public bool NotifyCreator { get; set; }
        public bool NotifyAssignedMembers { get; set; }
        public object integrationReferences { get; set; }
        public CurrentPhaseId CurrentPhaseId { get; set; }
        public object StartedDate { get; set; }
        public DueDate DueDate { get; set; }
        public object FinishDate { get; set; }
        public object AssignedForMembers { get; set; }
        public int Priority { get; set; }

        [JsonProperty("611ee98efd5915f2ae005e03")]
        public List<_611ee98efd5915f2ae005e03> _611ee98efd5915f2ae005e03 { get; set; }

        [JsonProperty("611eea44fd5915f2ae005e07")]
        public List<object> _611eea44fd5915f2ae005e07 { get; set; }

    }
}
