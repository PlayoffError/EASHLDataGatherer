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
        public void PlayersByNameIntegrationTests_PlayerExists()
        {
            PlayersByNameRequest request = new PlayersByNameRequest("joe", "common-gen5");
            PlayerByNameReturn? byNameReturn = request.GetPlayers();
            byNameReturn.Should().NotBeNull();
            byNameReturn.Members.Should().NotBeEmpty();
        }

        [Fact]
        public void PlayersByNameIntegrationTests_PlayerDoesNotExists()
        {
            PlayersByNameRequest request = new PlayersByNameRequest("00000", "common-gen5");
            PlayerByNameReturn? byNameReturn = request.GetPlayers();
            byNameReturn.Should().NotBeNull();
            byNameReturn.Members.Should().BeEmpty();
        }
    }
}