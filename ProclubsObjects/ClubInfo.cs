using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class ClubInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("clubId")]
        public int? ClubId { get; set; }

        [JsonProperty("regionId")]
        public int? RegionId { get; set; }

        [JsonProperty("teamId")]
        public int? TeamId { get; set; }

        [JsonProperty("customKit")]
        public CustomKit CustomKit { get; set; } = new CustomKit();
    }
}
