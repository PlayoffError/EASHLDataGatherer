using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class CustomKit
    {
        [JsonProperty("isCustomTeam")]
        public string IsCustomTeam { get; set; } = string.Empty;

        [JsonProperty("crestAssetId")]
        public string CrestAssetId { get; set; } = string.Empty;

        [JsonProperty("useBaseAsset")]
        public string UseBaseAsset { get; set; } = string.Empty;
    }
}
