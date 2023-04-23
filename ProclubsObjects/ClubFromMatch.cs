using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class ClubFromMatch
    {
        [JsonProperty("clubDivision")]
        public string ClubDivision { get; set; } = string.Empty;

        [JsonProperty("cNhlOnlineGameType")]
        public string CNhlOnlineGameType { get; set; } = string.Empty;

        [JsonProperty("garaw")]
        public string Garaw { get; set; } = string.Empty;

        [JsonProperty("gfraw")]
        public string Gfraw { get; set; } = string.Empty;

        [JsonProperty("losses")]
        public string Losses { get; set; } = string.Empty;

        [JsonProperty("memberString")]
        public string MemberString { get; set; } = string.Empty;

        [JsonProperty("opponentClubId")]
        public string OpponentClubId { get; set; } = string.Empty;

        [JsonProperty("opponentScore")]
        public string OpponentScore { get; set; } = string.Empty;

        [JsonProperty("opponentTeamArtAbbr")]
        public string OpponentTeamArtAbbr { get; set; } = string.Empty;

        [JsonProperty("passa")]
        public string Passa { get; set; } = string.Empty;

        [JsonProperty("passc")]
        public string Passc { get; set; } = string.Empty;

        [JsonProperty("ppg")]
        public string Ppg { get; set; } = string.Empty;

        [JsonProperty("ppo")]
        public string Ppo { get; set; } = string.Empty;

        [JsonProperty("result")]
        public string Result { get; set; } = string.Empty;

        [JsonProperty("score")]
        public string Score { get; set; } = string.Empty;

        [JsonProperty("scoreString")]
        public string ScoreString { get; set; } = string.Empty;

        [JsonProperty("shots")]
        public string Shots { get; set; } = string.Empty;

        [JsonProperty("teamArtAbbr")]
        public string TeamArtAbbr { get; set; } = string.Empty;

        [JsonProperty("teamSide")]
        public string TeamSide { get; set; } = string.Empty;

        [JsonProperty("toa")]
        public string Toa { get; set; } = string.Empty;

        [JsonProperty("winnerByDnf")]
        public string WinnerByDnf { get; set; } = string.Empty;

        [JsonProperty("winnerByGoalieDnf")]
        public string WinnerByGoalieDnf { get; set; } = string.Empty;

        [JsonProperty("details")]
        public ClubInfo Details { get; set; } = new ClubInfo();

        [JsonProperty("goals")]
        public string Goals { get; set; } = string.Empty;

        [JsonProperty("goalsAgainst")]
        public string GoalsAgainst { get; set; } = string.Empty;
    }
}
