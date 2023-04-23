using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class PlayerFromMatch
    {
        [JsonProperty("class")]
        public string Class { get; set; } = string.Empty;

        [JsonProperty("glbrksavepct")]
        public string Glbrksavepct { get; set; } = string.Empty;

        [JsonProperty("glbrksaves")]
        public string Glbrksaves { get; set; } = string.Empty;

        [JsonProperty("glbrkshots")]
        public string Glbrkshots { get; set; } = string.Empty;

        [JsonProperty("gldsaves")]
        public string Gldsaves { get; set; } = string.Empty;

        [JsonProperty("glga")]
        public string Glga { get; set; } = string.Empty;

        [JsonProperty("glgaa")]
        public string Glgaa { get; set; } = string.Empty;

        [JsonProperty("glpensavepct")]
        public string Glpensavepct { get; set; } = string.Empty;

        [JsonProperty("glpensaves")]
        public string Glpensaves { get; set; } = string.Empty;

        [JsonProperty("glpenshots")]
        public string Glpenshots { get; set; } = string.Empty;

        [JsonProperty("glpkclearzone")]
        public string Glpkclearzone { get; set; } = string.Empty;

        [JsonProperty("glpokechecks")]
        public string Glpokechecks { get; set; } = string.Empty;

        [JsonProperty("glsavepct")]
        public string Glsavepct { get; set; } = string.Empty;

        [JsonProperty("glsaves")]
        public string Glsaves { get; set; } = string.Empty;

        [JsonProperty("glshots")]
        public string Glshots { get; set; } = string.Empty;

        [JsonProperty("glsoperiods")]
        public string Glsoperiods { get; set; } = string.Empty;

        [JsonProperty("isGuest")]
        public string IsGuest { get; set; } = string.Empty;

        [JsonProperty("opponentClubId")]
        public string OpponentClubId { get; set; } = string.Empty;

        [JsonProperty("opponentScore")]
        public string OpponentScore { get; set; } = string.Empty;

        [JsonProperty("opponentTeamId")]
        public string OpponentTeamId { get; set; } = string.Empty;

        [JsonProperty("player_dnf")]
        public string PlayerDnf { get; set; } = string.Empty;

        [JsonProperty("playerLevel")]
        public string PlayerLevel { get; set; } = string.Empty;

        [JsonProperty("pNhlOnlineGameType")]
        public string PNhlOnlineGameType { get; set; } = string.Empty;

        [JsonProperty("position")]
        public string Position { get; set; } = string.Empty;

        [JsonProperty("posSorted")]
        public string PosSorted { get; set; } = string.Empty;

        [JsonProperty("ratingDefense")]
        public string RatingDefense { get; set; } = string.Empty;

        [JsonProperty("ratingOffense")]
        public string RatingOffense { get; set; } = string.Empty;

        [JsonProperty("ratingTeamplay")]
        public string RatingTeamplay { get; set; } = string.Empty;

        [JsonProperty("score")]
        public string Score { get; set; } = string.Empty;

        [JsonProperty("skassists")]
        public string Skassists { get; set; } = string.Empty;

        [JsonProperty("skbs")]
        public string Skbs { get; set; } = string.Empty;

        [JsonProperty("skdeflections")]
        public string Skdeflections { get; set; } = string.Empty;

        [JsonProperty("skfol")]
        public string Skfol { get; set; } = string.Empty;

        [JsonProperty("skfopct")]
        public string Skfopct { get; set; } = string.Empty;

        [JsonProperty("skfow")]
        public string Skfow { get; set; } = string.Empty;

        [JsonProperty("skgiveaways")]
        public string Skgiveaways { get; set; } = string.Empty;

        [JsonProperty("skgoals")]
        public string Skgoals { get; set; } = string.Empty;

        [JsonProperty("skgwg")]
        public string Skgwg { get; set; } = string.Empty;

        [JsonProperty("skhits")]
        public string Skhits { get; set; } = string.Empty;

        [JsonProperty("skinterceptions")]
        public string Skinterceptions { get; set; } = string.Empty;

        [JsonProperty("skpassattempts")]
        public string Skpassattempts { get; set; } = string.Empty;

        [JsonProperty("skpasses")]
        public string Skpasses { get; set; } = string.Empty;

        [JsonProperty("skpasspct")]
        public string Skpasspct { get; set; } = string.Empty;

        [JsonProperty("skpenaltiesdrawn")]
        public string Skpenaltiesdrawn { get; set; } = string.Empty;

        [JsonProperty("skpim")]
        public string Skpim { get; set; } = string.Empty;

        [JsonProperty("skpkclearzone")]
        public string Skpkclearzone { get; set; } = string.Empty;

        [JsonProperty("skplusmin")]
        public string Skplusmin { get; set; } = string.Empty;

        [JsonProperty("skpossession")]
        public string Skpossession { get; set; } = string.Empty;

        [JsonProperty("skppg")]
        public string Skppg { get; set; } = string.Empty;

        [JsonProperty("sksaucerpasses")]
        public string Sksaucerpasses { get; set; } = string.Empty;

        [JsonProperty("skshg")]
        public string Skshg { get; set; } = string.Empty;

        [JsonProperty("skshotattempts")]
        public string Skshotattempts { get; set; } = string.Empty;

        [JsonProperty("skshotonnetpct")]
        public string Skshotonnetpct { get; set; } = string.Empty;

        [JsonProperty("skshotpct")]
        public string Skshotpct { get; set; } = string.Empty;

        [JsonProperty("skshots")]
        public string Skshots { get; set; } = string.Empty;

        [JsonProperty("sktakeaways")]
        public string Sktakeaways { get; set; } = string.Empty;

        [JsonProperty("teamId")]
        public string TeamId { get; set; } = string.Empty;

        [JsonProperty("teamSide")]
        public string TeamSide { get; set; } = string.Empty;

        [JsonProperty("toi")]
        public string Toi { get; set; } = string.Empty;

        [JsonProperty("toiseconds")]
        public string Toiseconds { get; set; } = string.Empty;

        [JsonProperty("playername")]
        public string Playername { get; set; } = string.Empty;

        [JsonProperty("clientPlatform")]
        public string ClientPlatform { get; set; } = string.Empty;

    }
}
