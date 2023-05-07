using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class MatchAggregate
    {
        [JsonProperty("class")]
        public int? Class { get; set; }

        [JsonProperty("glbrksavepct")]
        public double? Glbrksavepct { get; set; }

        [JsonProperty("glbrksaves")]
        public int? Glbrksaves { get; set; }

        [JsonProperty("glbrkshots")]
        public int? Glbrkshots { get; set; }

        [JsonProperty("gldsaves")]
        public int? Gldsaves { get; set; }

        [JsonProperty("glga")]
        public int? Glga { get; set; }

        [JsonProperty("glgaa")]
        public double? Glgaa { get; set; }

        [JsonProperty("glpensavepct")]
        public double? Glpensavepct { get; set; }

        [JsonProperty("glpensaves")]
        public int? Glpensaves { get; set; }

        [JsonProperty("glpenshots")]
        public int? Glpenshots { get; set; }

        [JsonProperty("glpkclearzone")]
        public int? Glpkclearzone { get; set; }

        [JsonProperty("glpokechecks")]
        public int? Glpokechecks { get; set; }

        [JsonProperty("glsavepct")]
        public double? Glsavepct { get; set; }

        [JsonProperty("glsaves")]
        public int? Glsaves { get; set; }

        [JsonProperty("glshots")]
        public int? Glshots { get; set; }

        [JsonProperty("glsoperiods")]
        public int? Glsoperiods { get; set; }

        [JsonProperty("isGuest")]
        public int? IsGuest { get; set; }

        [JsonProperty("opponentClubId")]
        public int? OpponentClubId { get; set; }

        [JsonProperty("opponentScore")]
        public int? OpponentScore { get; set; }

        [JsonProperty("opponentTeamId")]
        public int? OpponentTeamId { get; set; }

        [JsonProperty("player_dnf")]
        public int? PlayerDnf { get; set; }

        [JsonProperty("playerLevel")]
        public int? PlayerLevel { get; set; }

        [JsonProperty("pNhlOnlineGameType")]
        public int? PNhlOnlineGameType { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("posSorted")]
        public int? PosSorted { get; set; }

        [JsonProperty("ratingDefense")]
        public double? RatingDefense { get; set; }

        [JsonProperty("ratingOffense")]
        public double? RatingOffense { get; set; }

        [JsonProperty("ratingTeamplay")]
        public double? RatingTeamplay { get; set; }

        [JsonProperty("score")]
        public int? Score { get; set; }

        [JsonProperty("skassists")]
        public int? Skassists { get; set; }

        [JsonProperty("skbs")]
        public int? Skbs { get; set; }

        [JsonProperty("skdeflections")]
        public int? Skdeflections { get; set; }

        [JsonProperty("skfol")]
        public int? Skfol { get; set; }

        [JsonProperty("skfopct")]
        public double? Skfopct { get; set; }

        [JsonProperty("skfow")]
        public int? Skfow { get; set; }

        [JsonProperty("skgiveaways")]
        public int? Skgiveaways { get; set; }

        [JsonProperty("skgoals")]
        public int? Skgoals { get; set; }

        [JsonProperty("skgwg")]
        public int? Skgwg { get; set; }

        [JsonProperty("skhits")]
        public int? Skhits { get; set; }

        [JsonProperty("skinterceptions")]
        public int? Skinterceptions { get; set; }

        [JsonProperty("skpassattempts")]
        public int? Skpassattempts { get; set; }

        [JsonProperty("skpasses")]
        public int? Skpasses { get; set; }

        [JsonProperty("skpasspct")]
        public double? Skpasspct { get; set; }

        [JsonProperty("skpenaltiesdrawn")]
        public int? Skpenaltiesdrawn { get; set; }

        [JsonProperty("skpim")]
        public int? Skpim { get; set; }

        [JsonProperty("skpkclearzone")]
        public int? Skpkclearzone { get; set; }

        [JsonProperty("skplusmin")]
        public int? Skplusmin { get; set; }

        [JsonProperty("skpossession")]
        public int? Skpossession { get; set; }

        [JsonProperty("skppg")]
        public int? Skppg { get; set; }

        [JsonProperty("sksaucerpasses")]
        public int? Sksaucerpasses { get; set; }

        [JsonProperty("skshg")]
        public int? Skshg { get; set; }

        [JsonProperty("skshotattempts")]
        public int? Skshotattempts { get; set; }

        [JsonProperty("skshotonnetpct")]
        public double? Skshotonnetpct { get; set; }

        [JsonProperty("skshotpct")]
        public double? Skshotpct { get; set; }

        [JsonProperty("skshots")]
        public int? Skshots { get; set; }

        [JsonProperty("sktakeaways")]
        public int? Sktakeaways { get; set; }

        [JsonProperty("teamId")]
        public int? TeamId { get; set; }

        [JsonProperty("teamSide")]
        public int? TeamSide { get; set; }

        [JsonProperty("toi")]
        public int? Toi { get; set; }

        [JsonProperty("toiseconds")]
        public int? Toiseconds { get; set; }
    }
}
