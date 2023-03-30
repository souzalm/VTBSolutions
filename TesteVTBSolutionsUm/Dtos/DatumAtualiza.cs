using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.ComponentModel;

namespace TesteVTBSolutionsUm.Dtos
{
    public class DatumAtualiza
    {
        public Id _id { get; set; }
        [JsonIgnore]
        public DateCreated DateCreated { get; set; }
        [JsonIgnore]
        public DateModified DateModified { get; set; }
        [JsonIgnore]
        public bool Active { get; set; }
        [JsonIgnore]
        public string CreatedByUser { get; set; }
        [JsonIgnore]
        public string ModifiedByUser { get; set; }

        [JsonProperty("Nome da Oportunidade")]
        public string NomedaOportunidade { get; set; }
        public object Qualificacao { get; set; }
        public object Valor { get; set; }
        public string Observacoes { get; set; }
        public List<Contato> Contatos { get; set; }

        [JsonProperty("Produtos / Serviços")]
        public object ProdutosServios { get; set; }
        [JsonIgnore]
        public double PhaseIndex { get; set; }
        [JsonIgnore]
        public object Comments { get; set; }
        [JsonIgnore]
        public bool NotifyCreator { get; set; }
        [JsonIgnore]
        public bool NotifyAssignedMembers { get; set; }
        public object IntegrationReferences { get; set; }
        [JsonIgnore]
        public CurrentPhaseId CurrentPhaseId { get; set; }
        [JsonIgnore]
        public DateTime StartedDate { get; set; }
        [JsonIgnore]
        public DueDate DueDate { get; set; }
        
        [JsonIgnore]
        public DateTime FinishDate { get; set; }
        
        [JsonIgnore]
        public object AssignedForMembers { get; set; }
        [JsonIgnore]
        public int Priority { get; set; }

        [JsonProperty("611ee98efd5915f2ae005e03")]
        public List<_611ee98efd5915f2ae005e03> _611ee98efd5915f2ae005e03 { get; set; }

        [JsonIgnore]
        [JsonProperty("611eea44fd5915f2ae005e07")]
        public List<object> _611eea44fd5915f2ae005e07 { get; set; }

    }
}
