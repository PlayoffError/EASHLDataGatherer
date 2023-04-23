using FluentAssertions;
using Newtonsoft.Json;
using ProclubsObjects;
using ProclubsWebAPI;
using System.Xml.Linq;

namespace ProclubsObjectsTests.IntegrationTests
{
    public class PlayersByNameIntegrationTests
    {
        [Fact]
        public void PlayerExists()
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByNameRequest request = new GetPlayersByNameRequest("joe", "common-gen5", webRequest, platformValidator);

            string result = request.GetPlayers().Result;

            PlayerByNameReturn? byNameReturn = JsonConvert.DeserializeObject<PlayerByNameReturn>(result);
            byNameReturn.Should().NotBeNull();

        }
    }
}