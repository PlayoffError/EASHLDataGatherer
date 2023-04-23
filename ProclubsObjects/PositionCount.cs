using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class PositionCount
    {
        [JsonProperty("forwards")]
        public int? Forwards { get; set; }

        [JsonProperty("goalie")]
        public int? Goalie { get; set; }

        [JsonProperty("defenseMen")]
        public int? DefenseMen { get; set; }
    }
}
