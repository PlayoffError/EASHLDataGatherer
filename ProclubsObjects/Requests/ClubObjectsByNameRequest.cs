using Newtonsoft.Json;
using ProclubsWebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjects
{
    public class ClubObjectsByNameRequest
    {
        public ClubObjectsByNameRequest( string clubName, string platform )
        {
            ClubName = clubName;
            Platform = platform;
        }

        public string ClubName { get; }
        public string Platform { get; }

        public async Task<Dictionary<string, Club>?> GetClubs()
        {
            var webRequest = new ProclubsWebRequest();
            var validator = new ProclubsPlatformValidator();

            GetClubsRequest request = new GetClubsRequest(Platform, ClubName, webRequest, validator);
            string result = await request.GetClubs();

            return JsonConvert.DeserializeObject<Dictionary<string, Club>>(result);
        }
    }
}
