using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ONS.SDK.Domain.Base;

namespace ONS.SDK.Domain.ProcessMemmory {
    
    /// <summary>
    /// Representa os dados de fork para criação de branch na memória de processamento.
    /// </summary>
    public class Fork: Model {

        public static string StatusOpen = "open";

        public static string OwnerAnonymous = "anonymous";

        public Fork() {
            this.Status = StatusOpen;
            this.Owner = OwnerAnonymous;
            this.StartedAt = DateTime.Now;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("startedAt")]
        public DateTime? StartedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }
    }
}