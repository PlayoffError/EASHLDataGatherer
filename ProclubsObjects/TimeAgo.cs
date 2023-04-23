using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class TimeAgo
    {
        [JsonProperty("number")]
        public int? Number { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; } = string.Empty;
    }
}
