using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class Club
    {
        [JsonProperty("clubId")]
        public string ClubId { get; set; } = string.Empty;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("rank")]
        public string Rank { get; set; } = string.Empty;

        [JsonProperty("clubname")]
        public string Clubname { get; set; } = string.Empty;

        [JsonProperty("seasons")]
        public int? Seasons { get; set; }

        [JsonProperty("divGroupsWon")]
        public string DivGroupsWon { get; set; } = string.Empty;

        [JsonProperty("leaguesWon")]
        public string LeaguesWon { get; set; } = string.Empty;

        [JsonProperty("divGroupsWon1")]
        public string DivGroupsWon1 { get; set; } = string.Empty;

        [JsonProperty("divGroupsWon2")]
        public string DivGroupsWon2 { get; set; } = string.Empty;

        [JsonProperty("divGroupsWon3")]
        public string DivGroupsWon3 { get; set; } = string.Empty;

        [JsonProperty("divGroupsWon4")]
        public string DivGroupsWon4 { get; set; } = string.Empty;

        [JsonProperty("cupsWon1")]
        public string CupsWon1 { get; set; } = string.Empty;

        [JsonProperty("cupsWon2")]
        public string CupsWon2 { get; set; } = string.Empty;

        [JsonProperty("cupsWon3")]
        public string CupsWon3 { get; set; } = string.Empty;

        [JsonProperty("cupsWon4")]
        public string CupsWon4 { get; set; } = string.Empty;

        [JsonProperty("cupsWon5")]
        public string CupsWon5 { get; set; } = string.Empty;

        [JsonProperty("cupsElim1")]
        public string CupsElim1 { get; set; } = string.Empty;

        [JsonProperty("cupsElim2")]
        public string CupsElim2 { get; set; } = string.Empty;

        [JsonProperty("cupsElim3")]
        public string CupsElim3 { get; set; } = string.Empty;

        [JsonProperty("cupsElim4")]
        public string CupsElim4 { get; set; } = string.Empty;

        [JsonProperty("cupsElim5")]
        public string CupsElim5 { get; set; } = string.Empty;

        [JsonProperty("promotions")]
        public string Promotions { get; set; } = string.Empty;

        [JsonProperty("holds")]
        public string Holds { get; set; } = string.Empty;

        [JsonProperty("relegations")]
        public string Relegations { get; set; } = string.Empty;

        [JsonProperty("rankingPoints")]
        public string RankingPoints { get; set; } = string.Empty;

        [JsonProperty("curCompetition")]
        public string CurCompetition { get; set; } = string.Empty;

        [JsonProperty("prevDivision")]
        public string PrevDivision { get; set; } = string.Empty;

        [JsonProperty("prevGameDivision")]
        public string PrevGameDivision { get; set; } = string.Empty;

        [JsonProperty("bestDivision")]
        public int? BestDivision { get; set; }

        [JsonProperty("bestPoints")]
        public string BestPoints { get; set; } = string.Empty;

        [JsonProperty("curSeasonMov")]
        public string CurSeasonMov { get; set; } = string.Empty;

        [JsonProperty("recentResult0")]
        public string RecentResult0 { get; set; } = string.Empty;

        [JsonProperty("recentResult1")]
        public string RecentResult1 { get; set; } = string.Empty;

        [JsonProperty("recentResult2")]
        public string RecentResult2 { get; set; } = string.Empty;

        [JsonProperty("recentResult3")]
        public string RecentResult3 { get; set; } = string.Empty;

        [JsonProperty("recentResult4")]
        public string RecentResult4 { get; set; } = string.Empty;

        [JsonProperty("recentResult5")]
        public string RecentResult5 { get; set; } = string.Empty;

        [JsonProperty("recentResult6")]
        public string RecentResult6 { get; set; } = string.Empty;

        [JsonProperty("recentResult7")]
        public string RecentResult7 { get; set; } = string.Empty;

        [JsonProperty("recentResult8")]
        public string RecentResult8 { get; set; } = string.Empty;

        [JsonProperty("recentResult9")]
        public string RecentResult9 { get; set; } = string.Empty;

        [JsonProperty("recentOpponent0")]
        public string RecentOpponent0 { get; set; } = string.Empty;

        [JsonProperty("recentOpponent1")]
        public string RecentOpponent1 { get; set; } = string.Empty;

        [JsonProperty("recentOpponent2")]
        public string RecentOpponent2 { get; set; } = string.Empty;

        [JsonProperty("recentOpponent3")]
        public string RecentOpponent3 { get; set; } = string.Empty;

        [JsonProperty("recentOpponent4")]
        public string RecentOpponent4 { get; set; } = string.Empty;

        [JsonProperty("recentOpponent5")]
        public string RecentOpponent5 { get; set; } = string.Empty;

        [JsonProperty("recentOpponent6")]
        public string RecentOpponent6 { get; set; } = string.Empty;

        [JsonProperty("recentOpponent7")]
        public string RecentOpponent7 { get; set; } = string.Empty;

        [JsonProperty("recentOpponent8")]
        public string RecentOpponent8 { get; set; } = string.Empty;

        [JsonProperty("recentOpponent9")]
        public string RecentOpponent9 { get; set; } = string.Empty;

        [JsonProperty("recentScore0")]
        public string RecentScore0 { get; set; } = string.Empty;

        [JsonProperty("recentScore1")]
        public string RecentScore1 { get; set; } = string.Empty;

        [JsonProperty("recentScore2")]
        public string RecentScore2 { get; set; } = string.Empty;

        [JsonProperty("recentScore3")]
        public string RecentScore3 { get; set; } = string.Empty;

        [JsonProperty("recentScore4")]
        public string RecentScore4 { get; set; } = string.Empty;

        [JsonProperty("recentScore5")]
        public string RecentScore5 { get; set; } = string.Empty;

        [JsonProperty("recentScore6")]
        public string RecentScore6 { get; set; } = string.Empty;

        [JsonProperty("recentScore7")]
        public string RecentScore7 { get; set; } = string.Empty;

        [JsonProperty("recentScore8")]
        public string RecentScore8 { get; set; } = string.Empty;

        [JsonProperty("recentScore9")]
        public string RecentScore9 { get; set; } = string.Empty;

        [JsonProperty("wins")]
        public string Wins { get; set; } = string.Empty;

        [JsonProperty("losses")]
        public string Losses { get; set; } = string.Empty;

        [JsonProperty("ties")]
        public string Ties { get; set; } = string.Empty;

        [JsonProperty("otl")]
        public string Otl { get; set; } = string.Empty;

        [JsonProperty("prevSeasonWins")]
        public string PrevSeasonWins { get; set; } = string.Empty;

        [JsonProperty("prevSeasonLosses")]
        public string PrevSeasonLosses { get; set; } = string.Empty;

        [JsonProperty("prevSeasonTies")]
        public string PrevSeasonTies { get; set; } = string.Empty;

        [JsonProperty("prevSeasonOtl")]
        public string PrevSeasonOtl { get; set; } = string.Empty;

        [JsonProperty("goals")]
        public string Goals { get; set; } = string.Empty;

        [JsonProperty("goalsAgainst")]
        public string GoalsAgainst { get; set; } = string.Empty;

        [JsonProperty("starLevel")]
        public string StarLevel { get; set; } = string.Empty;

        [JsonProperty("totalCupsWon")]
        public int? TotalCupsWon { get; set; }

        [JsonProperty("cupsEntered")]
        public string CupsEntered { get; set; } = string.Empty;

        [JsonProperty("cupWinPercent")]
        public string CupWinPercent { get; set; } = string.Empty;

        [JsonProperty("titlesWon")]
        public string TitlesWon { get; set; } = string.Empty;

        [JsonProperty("prevGameWonTitle")]
        public string PrevGameWonTitle { get; set; } = string.Empty;

        [JsonProperty("record")]
        public string Record { get; set; } = string.Empty;

        [JsonProperty("clubfinalsplayed")]
        public string Clubfinalsplayed { get; set; } = string.Empty;

        [JsonProperty("divsWon1")]
        public int? DivsWon1 { get; set; }

        [JsonProperty("divsWon2")]
        public int? DivsWon2 { get; set; }

        [JsonProperty("divsWon3")]
        public int? DivsWon3 { get; set; }

        [JsonProperty("divsWon4")]
        public int? DivsWon4 { get; set; }

        [JsonProperty("currentDivision")]
        public int? CurrentDivision { get; set; }

        [JsonProperty("clubInfo")]
        public ClubInfo ClubInfo { get; set; } = new ClubInfo();

        [JsonProperty("platform")]
        public string Platform { get; set; } = string.Empty;
    }
}
