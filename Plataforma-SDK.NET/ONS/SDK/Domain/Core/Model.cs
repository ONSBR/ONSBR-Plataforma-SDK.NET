using Newtonsoft.Json;

namespace ONS.SDK.Domain.Core {
    public class Model {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("_metadata")]
        public Metadata _Metadata { get; set; }
    }
}