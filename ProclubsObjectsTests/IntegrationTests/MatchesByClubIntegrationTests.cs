using FluentAssertions;
using Newtonsoft.Json;
using ProclubsObjects;
using ProclubsWebAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjectsTests.IntegrationTests
{
    public class MatchesByClubIntegrationTests
    {

        [Fact]
        void GetMatches()
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();
            var matchTypeValidator = new ProclubsMatchTypeValidator();

            GetGamesRequest request = new GetGamesRequest(1463, "gameType5", "common-gen5", webRequest, platformValidator, matchTypeValidator);
            string result = request.GetGames().Result;

            List<Match>? matches = JsonConvert.DeserializeObject<List<Match>>(result);
            matches.Should().NotBeNull();
        }
    }
}
