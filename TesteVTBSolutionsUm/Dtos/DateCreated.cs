﻿using Newtonsoft.Json;

namespace TesteVTBSolutionsUm.Dtos
{
    public class DateCreated
    {
        [JsonProperty("$date")]
        public DateTime date { get; set; }
    }
}