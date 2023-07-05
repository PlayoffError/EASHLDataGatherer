using Newtonsoft.Json;
using ProclubsWebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class PlayersByClubIDRequest
    {
        public PlayersByClubIDRequest( long clubID, string platform )
        {
            ClubID = clubID;
            Platform = platform;
        }

        public long ClubID { get; }
        public string Platform { get; }

        public async Task<PlayerByClubReturn?> GetPlayers()
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(ClubID, Platform, webRequest, platformValidator);

            string result = await request.GetPlayers();

            return JsonConvert.DeserializeObject<PlayerByClubReturn>(result);
        }
    }
}
