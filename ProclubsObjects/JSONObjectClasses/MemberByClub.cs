using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class MemberByClub
    {
        [JsonProperty("wins")]
        public string Wins { get; set; } = string.Empty;

        [JsonProperty("losses")]
        public string Losses { get; set; } = string.Empty;

        [JsonProperty("otl")]
        public string Otl { get; set; } = string.Empty;

        [JsonProperty("winnerByDnf")]
        public string WinnerByDnf { get; set; } = string.Empty;

        [JsonProperty("record")]
        public string Record { get; set; } = string.Empty;

        [JsonProperty("skwins")]
        public string Skwins { get; set; } = string.Empty;

        [JsonProperty("sklosses")]
        public string Sklosses { get; set; } = string.Empty;

        [JsonProperty("skotl")]
        public string Skotl { get; set; } = string.Empty;

        [JsonProperty("skwinnerByDnf")]
        public string SkwinnerByDnf { get; set; } = string.Empty;

        [JsonProperty("skgoals")]
        public string Skgoals { get; set; } = string.Empty;

        [JsonProperty("skassists")]
        public string Skassists { get; set; } = string.Empty;

        [JsonProperty("skpoints")]
        public string Skpoints { get; set; } = string.Empty;

        [JsonProperty("skpointspg")]
        public string Skpointspg { get; set; } = string.Empty;

        [JsonProperty("skgwg")]
        public string Skgwg { get; set; } = string.Empty;

        [JsonProperty("skplusmin")]
        public string Skplusmin { get; set; } = string.Empty;

        [JsonProperty("sktoi")]
        public string Sktoi { get; set; } = string.Empty;

        [JsonProperty("skpim")]
        public string Skpim { get; set; } = string.Empty;

        [JsonProperty("skppg")]
        public string Skppg { get; set; } = string.Empty;

        [JsonProperty("skshg")]
        public string Skshg { get; set; } = string.Empty;

        [JsonProperty("skpenaltyshotgoals")]
        public string Skpenaltyshotgoals { get; set; } = string.Empty;

        [JsonProperty("skpenaltyattempts")]
        public string Skpenaltyattempts { get; set; } = string.Empty;

        [JsonProperty("skpenaltyshotpct")]
        public string Skpenaltyshotpct { get; set; } = string.Empty;

        [JsonProperty("skoffsides")]
        public string Skoffsides { get; set; } = string.Empty;

        [JsonProperty("skoffsidespg")]
        public string Skoffsidespg { get; set; } = string.Empty;

        [JsonProperty("skfights")]
        public string Skfights { get; set; } = string.Empty;

        [JsonProperty("skfightswon")]
        public string Skfightswon { get; set; } = string.Empty;

        [JsonProperty("skfo")]
        public string Skfo { get; set; } = string.Empty;

        [JsonProperty("skfow")]
        public string Skfow { get; set; } = string.Empty;

        [JsonProperty("skfol")]
        public string Skfol { get; set; } = string.Empty;

        [JsonProperty("skfop")]
        public string Skfop { get; set; } = string.Empty;

        [JsonProperty("skhits")]
        public string Skhits { get; set; } = string.Empty;

        [JsonProperty("skhitspg")]
        public string Skhitspg { get; set; } = string.Empty;

        [JsonProperty("skbs")]
        public string Skbs { get; set; } = string.Empty;

        [JsonProperty("skshots")]
        public string Skshots { get; set; } = string.Empty;

        [JsonProperty("skshotpct")]
        public string Skshotpct { get; set; } = string.Empty;

        [JsonProperty("skshotspg")]
        public string Skshotspg { get; set; } = string.Empty;

        [JsonProperty("skshotattempts")]
        public string Skshotattempts { get; set; } = string.Empty;

        [JsonProperty("skshotonnetpct")]
        public string Skshotonnetpct { get; set; } = string.Empty;

        [JsonProperty("skpasses")]
        public string Skpasses { get; set; } = string.Empty;

        [JsonProperty("skpassattempts")]
        public string Skpassattempts { get; set; } = string.Empty;

        [JsonProperty("skpasspct")]
        public string Skpasspct { get; set; } = string.Empty;

        [JsonProperty("sksaucerpasses")]
        public string Sksaucerpasses { get; set; } = string.Empty;

        [JsonProperty("skdekes")]
        public string Skdekes { get; set; } = string.Empty;

        [JsonProperty("skdekesmade")]
        public string Skdekesmade { get; set; } = string.Empty;

        [JsonProperty("skgiveaways")]
        public string Skgiveaways { get; set; } = string.Empty;

        [JsonProperty("sktakeaways")]
        public string Sktakeaways { get; set; } = string.Empty;

        [JsonProperty("skinterceptions")]
        public string Skinterceptions { get; set; } = string.Empty;

        [JsonProperty("skscrnchances")]
        public string Skscrnchances { get; set; } = string.Empty;

        [JsonProperty("skscrngoals")]
        public string Skscrngoals { get; set; } = string.Empty;

        [JsonProperty("skbrkgoals")]
        public string Skbrkgoals { get; set; } = string.Empty;

        [JsonProperty("skbreakaways")]
        public string Skbreakaways { get; set; } = string.Empty;

        [JsonProperty("skbreakawaypct")]
        public string Skbreakawaypct { get; set; } = string.Empty;

        [JsonProperty("skgc")]
        public string Skgc { get; set; } = string.Empty;

        [JsonProperty("skgcFC")]
        public string SkgcFC { get; set; } = string.Empty;

        [JsonProperty("skhattricks")]
        public string Skhattricks { get; set; } = string.Empty;

        [JsonProperty("skprevgoals")]
        public string Skprevgoals { get; set; } = string.Empty;

        [JsonProperty("skprevassists")]
        public string Skprevassists { get; set; } = string.Empty;

        [JsonProperty("skpossession")]
        public string Skpossession { get; set; } = string.Empty;

        [JsonProperty("skdeflections")]
        public string Skdeflections { get; set; } = string.Empty;

        [JsonProperty("skpkclearzone")]
        public string Skpkclearzone { get; set; } = string.Empty;

        [JsonProperty("skpenaltiesdrawn")]
        public string Skpenaltiesdrawn { get; set; } = string.Empty;

        [JsonProperty("glwins")]
        public string Glwins { get; set; } = string.Empty;

        [JsonProperty("gllosses")]
        public string Gllosses { get; set; } = string.Empty;

        [JsonProperty("glotl")]
        public string Glotl { get; set; } = string.Empty;

        [JsonProperty("glwinnerByDnf")]
        public string GlwinnerByDnf { get; set; } = string.Empty;

        [JsonProperty("glshots")]
        public string Glshots { get; set; } = string.Empty;

        [JsonProperty("glsaves")]
        public string Glsaves { get; set; } = string.Empty;

        [JsonProperty("glsavepct")]
        public string Glsavepct { get; set; } = string.Empty;

        [JsonProperty("gltoi")]
        public string Gltoi { get; set; } = string.Empty;

        [JsonProperty("glga")]
        public string Glga { get; set; } = string.Empty;

        [JsonProperty("glgaa")]
        public string Glgaa { get; set; } = string.Empty;

        [JsonProperty("glso")]
        public string Glso { get; set; } = string.Empty;

        [JsonProperty("glsoperiods")]
        public string Glsoperiods { get; set; } = string.Empty;

        [JsonProperty("gldsaves")]
        public string Gldsaves { get; set; } = string.Empty;

        [JsonProperty("glbrkshots")]
        public string Glbrkshots { get; set; } = string.Empty;

        [JsonProperty("glbrksaves")]
        public string Glbrksaves { get; set; } = string.Empty;

        [JsonProperty("glbrksavepct")]
        public string Glbrksavepct { get; set; } = string.Empty;

        [JsonProperty("glpenshots")]
        public string Glpenshots { get; set; } = string.Empty;

        [JsonProperty("glpensaves")]
        public string Glpensaves { get; set; } = string.Empty;

        [JsonProperty("glpensavepct")]
        public string Glpensavepct { get; set; } = string.Empty;

        [JsonProperty("glsoshots")]
        public string Glsoshots { get; set; } = string.Empty;

        [JsonProperty("glsosaves")]
        public string Glsosaves { get; set; } = string.Empty;

        [JsonProperty("glsosavepct")]
        public string Glsosavepct { get; set; } = string.Empty;

        [JsonProperty("glrecord")]
        public string Glrecord { get; set; } = string.Empty;

        [JsonProperty("glpokechecks")]
        public string Glpokechecks { get; set; } = string.Empty;

        [JsonProperty("glgc")]
        public string Glgc { get; set; } = string.Empty;

        [JsonProperty("glgcFC")]
        public string GlgcFC { get; set; } = string.Empty;

        [JsonProperty("glprevwins")]
        public string Glprevwins { get; set; } = string.Empty;

        [JsonProperty("glprevso")]
        public string Glprevso { get; set; } = string.Empty;

        [JsonProperty("glpkclearzone")]
        public string Glpkclearzone { get; set; } = string.Empty;

        [JsonProperty("glgp")]
        public string Glgp { get; set; } = string.Empty;

        [JsonProperty("lwgp")]
        public string Lwgp { get; set; } = string.Empty;

        [JsonProperty("rwgp")]
        public string Rwgp { get; set; } = string.Empty;

        [JsonProperty("cgp")]
        public string Cgp { get; set; } = string.Empty;

        [JsonProperty("dgp")]
        public string Dgp { get; set; } = string.Empty;

        [JsonProperty("skgp")]
        public string Skgp { get; set; } = string.Empty;

        [JsonProperty("gamesplayed")]
        public string Gamesplayed { get; set; } = string.Empty;

        [JsonProperty("gamesCompleted")]
        public string GamesCompleted { get; set; } = string.Empty;

        [JsonProperty("gamesCompletedFC")]
        public string GamesCompletedFC { get; set; } = string.Empty;

        [JsonProperty("skwinpct")]
        public string Skwinpct { get; set; } = string.Empty;

        [JsonProperty("glwinpct")]
        public string Glwinpct { get; set; } = string.Empty;

        [JsonProperty("lwQuitDisc")]
        public string LwQuitDisc { get; set; } = string.Empty;

        [JsonProperty("rwQuitDisc")]
        public string RwQuitDisc { get; set; } = string.Empty;

        [JsonProperty("cQuitDisc")]
        public string CQuitDisc { get; set; } = string.Empty;

        [JsonProperty("dQuitDisc")]
        public string DQuitDisc { get; set; } = string.Empty;

        [JsonProperty("glQuitDisc")]
        public string GlQuitDisc { get; set; } = string.Empty;

        [JsonProperty("skDNF")]
        public string SkDNF { get; set; } = string.Empty;

        [JsonProperty("lwDNF")]
        public string LwDNF { get; set; } = string.Empty;

        [JsonProperty("rwDNF")]
        public string RwDNF { get; set; } = string.Empty;

        [JsonProperty("cDNF")]
        public string CDNF { get; set; } = string.Empty;

        [JsonProperty("dDNF")]
        public string DDNF { get; set; } = string.Empty;

        [JsonProperty("glDNF")]
        public string GlDNF { get; set; } = string.Empty;

        [JsonProperty("glDNFmm")]
        public string GlDNFmm { get; set; } = string.Empty;

        [JsonProperty("playerQuitDisc")]
        public string PlayerQuitDisc { get; set; } = string.Empty;

        [JsonProperty("playerDNF")]
        public string PlayerDNF { get; set; } = string.Empty;

        [JsonProperty("xfactor_zoneability_goals")]
        public string XfactorZoneabilityGoals { get; set; } = string.Empty;

        [JsonProperty("xfactor_zoneability_assists")]
        public string XfactorZoneabilityAssists { get; set; } = string.Empty;

        [JsonProperty("xfactor_zoneability_saves")]
        public string XfactorZoneabilitySaves { get; set; } = string.Empty;

        [JsonProperty("xfactor_zoneability_hits")]
        public string XfactorZoneabilityHits { get; set; } = string.Empty;

        [JsonProperty("xfactor_zoneability_stick_checks")]
        public string XfactorZoneabilityStickChecks { get; set; } = string.Empty;

        [JsonProperty("xfactor_zoneability_times_used")]
        public string XfactorZoneabilityTimesUsed { get; set; } = string.Empty;

        [JsonProperty("xfactor_superstarability_goals")]
        public string XfactorSuperstarabilityGoals { get; set; } = string.Empty;

        [JsonProperty("xfactor_superstarability_assists")]
        public string XfactorSuperstarabilityAssists { get; set; } = string.Empty;

        [JsonProperty("xfactor_superstarability_saves")]
        public string XfactorSuperstarabilitySaves { get; set; } = string.Empty;

        [JsonProperty("xfactor_superstarability_hits")]
        public string XfactorSuperstarabilityHits { get; set; } = string.Empty;

        [JsonProperty("xfactor_superstarability_stick_checks")]
        public string XfactorSuperstarabilityStickChecks { get; set; } = string.Empty;

        [JsonProperty("favoritePosition")]
        public string FavoritePosition { get; set; } = string.Empty;

        [JsonProperty("goals")]
        public string Goals { get; set; } = string.Empty;

        [JsonProperty("assists")]
        public string Assists { get; set; } = string.Empty;

        [JsonProperty("points")]
        public string Points { get; set; } = string.Empty;

        [JsonProperty("pointspg")]
        public string Pointspg { get; set; } = string.Empty;

        [JsonProperty("gwg")]
        public string Gwg { get; set; } = string.Empty;

        [JsonProperty("plusmin")]
        public string Plusmin { get; set; } = string.Empty;

        [JsonProperty("toi")]
        public string Toi { get; set; } = string.Empty;

        [JsonProperty("pim")]
        public string Pim { get; set; } = string.Empty;

        [JsonProperty("ppg")]
        public string Ppg { get; set; } = string.Empty;

        [JsonProperty("shg")]
        public string Shg { get; set; } = string.Empty;

        [JsonProperty("penaltyshotgoals")]
        public string Penaltyshotgoals { get; set; } = string.Empty;

        [JsonProperty("penaltyattempts")]
        public string Penaltyattempts { get; set; } = string.Empty;

        [JsonProperty("penaltyshotpct")]
        public string Penaltyshotpct { get; set; } = string.Empty;

        [JsonProperty("offsides")]
        public string Offsides { get; set; } = string.Empty;

        [JsonProperty("offsidespg")]
        public string Offsidespg { get; set; } = string.Empty;

        [JsonProperty("fights")]
        public string Fights { get; set; } = string.Empty;

        [JsonProperty("fightswon")]
        public string Fightswon { get; set; } = string.Empty;

        [JsonProperty("fo")]
        public string Fo { get; set; } = string.Empty;

        [JsonProperty("fow")]
        public string Fow { get; set; } = string.Empty;

        [JsonProperty("fol")]
        public string Fol { get; set; } = string.Empty;

        [JsonProperty("fop")]
        public string Fop { get; set; } = string.Empty;

        [JsonProperty("hits")]
        public string Hits { get; set; } = string.Empty;

        [JsonProperty("hitspg")]
        public string Hitspg { get; set; } = string.Empty;

        [JsonProperty("bs")]
        public string Bs { get; set; } = string.Empty;

        [JsonProperty("shots")]
        public string Shots { get; set; } = string.Empty;

        [JsonProperty("shotpct")]
        public string Shotpct { get; set; } = string.Empty;

        [JsonProperty("shotspg")]
        public string Shotspg { get; set; } = string.Empty;

        [JsonProperty("shotattempts")]
        public string Shotattempts { get; set; } = string.Empty;

        [JsonProperty("shotonnetpct")]
        public string Shotonnetpct { get; set; } = string.Empty;

        [JsonProperty("passes")]
        public string Passes { get; set; } = string.Empty;

        [JsonProperty("passattempts")]
        public string Passattempts { get; set; } = string.Empty;

        [JsonProperty("passpct")]
        public string Passpct { get; set; } = string.Empty;

        [JsonProperty("saucerpasses")]
        public string Saucerpasses { get; set; } = string.Empty;

        [JsonProperty("dekes")]
        public string Dekes { get; set; } = string.Empty;

        [JsonProperty("dekesmade")]
        public string Dekesmade { get; set; } = string.Empty;

        [JsonProperty("giveaways")]
        public string Giveaways { get; set; } = string.Empty;

        [JsonProperty("takeaways")]
        public string Takeaways { get; set; } = string.Empty;

        [JsonProperty("interceptions")]
        public string Interceptions { get; set; } = string.Empty;

        [JsonProperty("scrnchances")]
        public string Scrnchances { get; set; } = string.Empty;

        [JsonProperty("scrngoals")]
        public string Scrngoals { get; set; } = string.Empty;

        [JsonProperty("brkgoals")]
        public string Brkgoals { get; set; } = string.Empty;

        [JsonProperty("breakaways")]
        public string Breakaways { get; set; } = string.Empty;

        [JsonProperty("breakawaypct")]
        public string Breakawaypct { get; set; } = string.Empty;

        [JsonProperty("gc")]
        public string Gc { get; set; } = string.Empty;

        [JsonProperty("gcFC")]
        public string GcFC { get; set; } = string.Empty;

        [JsonProperty("hattricks")]
        public string Hattricks { get; set; } = string.Empty;

        [JsonProperty("prevgoals")]
        public string Prevgoals { get; set; } = string.Empty;

        [JsonProperty("prevassists")]
        public string Prevassists { get; set; } = string.Empty;

        [JsonProperty("possession")]
        public string Possession { get; set; } = string.Empty;

        [JsonProperty("deflections")]
        public string Deflections { get; set; } = string.Empty;

        [JsonProperty("pkclearzone")]
        public string Pkclearzone { get; set; } = string.Empty;

        [JsonProperty("penaltiesdrawn")]
        public string Penaltiesdrawn { get; set; } = string.Empty;

        [JsonProperty("gp")]
        public string Gp { get; set; } = string.Empty;

        [JsonProperty("winpct")]
        public string Winpct { get; set; } = string.Empty;

        [JsonProperty("DNF")]
        public string DNF { get; set; } = string.Empty;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("clientPlatform")]
        public string ClientPlatform { get; set; } = string.Empty;
    }
}