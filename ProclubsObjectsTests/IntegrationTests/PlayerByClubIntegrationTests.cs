using FluentAssertions;
using Newtonsoft.Json;
using ProclubsObjects;
using ProclubsWebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsObjectsTests.IntegrationTests
{
    public class PlayerByClubIntegrationTests
    {
        [Fact]
        public void PlayerExists()
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(1463, "common-gen5", webRequest, platformValidator);

            string result = request.GetPlayers().Result;

            PlayerByClubReturn? byClubReturn = JsonConvert.DeserializeObject<PlayerByClubReturn>(result);
            byClubReturn.Should().NotBeNull();

        }
    }
}
