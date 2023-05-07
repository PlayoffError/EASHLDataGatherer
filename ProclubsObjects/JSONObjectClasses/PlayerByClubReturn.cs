using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class PlayerByClubReturn
    {
        [JsonProperty("members")]
        public List<MemberByClub> Members { get; set; } = new List<MemberByClub>();

        [JsonProperty("positionCount")]
        public PositionCount PositionCount { get; set; } = new PositionCount();
    }
}
