using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class MemberByName
    {
        [JsonProperty("skplayername")]
        public string Skplayername { get; set; } = string.Empty;

        [JsonProperty("blazeId")]
        public string BlazeId { get; set; } = string.Empty;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("platform")]
        public string Platform { get; set; } = string.Empty;

        [JsonProperty("gamesplayed")]
        public string Gamesplayed { get; set; } = string.Empty;

        [JsonProperty("skgoals")]
        public string Skgoals { get; set; } = string.Empty;

        [JsonProperty("skassists")]
        public string Skassists { get; set; } = string.Empty;

        [JsonProperty("skplusmin")]
        public string Skplusmin { get; set; } = string.Empty;

        [JsonProperty("skpim")]
        public string Skpim { get; set; } = string.Empty;

        [JsonProperty("skhits")]
        public string Skhits { get; set; } = string.Empty;

        [JsonProperty("glgp")]
        public string Glgp { get; set; } = string.Empty;

        [JsonProperty("dgp")]
        public string Dgp { get; set; } = string.Empty;

        [JsonProperty("rwgp")]
        public string Rwgp { get; set; } = string.Empty;

        [JsonProperty("cgp")]
        public string Cgp { get; set; } = string.Empty;

        [JsonProperty("lwgp")]
        public string Lwgp { get; set; } = string.Empty;

        [JsonProperty("glgaa")]
        public string Glgaa { get; set; } = string.Empty;

        [JsonProperty("glga")]
        public string Glga { get; set; } = string.Empty;

        [JsonProperty("glsaves")]
        public string Glsaves { get; set; } = string.Empty;

        [JsonProperty("glsavepct")]
        public string Glsavepct { get; set; } = string.Empty;

        [JsonProperty("glso")]
        public string Glso { get; set; } = string.Empty;

        [JsonProperty("glsoperiods")]
        public string Glsoperiods { get; set; } = string.Empty;

        [JsonProperty("favoritePosition")]
        public string FavoritePosition { get; set; } = string.Empty;
    }
}
