using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace ProclubsObjects
{
    public class Match
    {
        [JsonProperty("matchId")]
        public string MatchId { get; set; } = string.Empty;

        [JsonProperty("timestamp")]
        public int? Timestamp { get; set; }

        [JsonProperty("timeAgo")]
        public TimeAgo TimeAgo { get; set; } = new TimeAgo();

        [JsonProperty("clubs")]
        public Dictionary<string,ClubFromMatch> Clubs { get; set; } = new Dictionary<string, ClubFromMatch>();

        [JsonProperty("players")]
        public Dictionary<string, Dictionary<string, PlayerFromMatch>> Players { get; set; } = new Dictionary<string, Dictionary<string, PlayerFromMatch>>();

        [JsonProperty("aggregate")]
        public Dictionary<string, MatchAggregate> MatchAggregates { get; set; } = new Dictionary<string, MatchAggregate>();
    }
}
