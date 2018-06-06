using System;

namespace ONS.SDK.Domain.Core {
    public class Branch : Model {
        public string SystemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartedAt { get; set; }
        public string Status { get; set; }

        public Branch() {
            this._Metadata = new Metadata() {
                Type="branch"
            };
        }
    }
}