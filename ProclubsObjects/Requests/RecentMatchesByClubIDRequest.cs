using Newtonsoft.Json;
using ProclubsWebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class RecentMatchesByClubIDRequest
    {
        public RecentMatchesByClubIDRequest( long clubID, string matchType, string platform )
        {
            ClubID = clubID;
            MatchType = matchType;
            Platform = platform;
        }

        public long ClubID { get; }
        public string MatchType { get; }
        public string Platform { get; }

        public async Task<List<Match>?> GetMatches()
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();
            var matchTypeValidator = new ProclubsMatchTypeValidator();

            GetGamesRequest request = new GetGamesRequest(ClubID, MatchType, Platform, webRequest, platformValidator, matchTypeValidator);
            string result = await request.GetGames();

            return JsonConvert.DeserializeObject<List<Match>>(result);
        }
    }
}
