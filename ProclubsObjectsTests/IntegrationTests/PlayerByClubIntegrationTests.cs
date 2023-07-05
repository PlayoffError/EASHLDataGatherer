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
        public void PlayerByClubIntegrationTests_ClubExists()
        {
            PlayersByClubIDRequest playerRequest = new PlayersByClubIDRequest(1463, "common-gen5");
            PlayerByClubReturn? byClubReturn = playerRequest.GetPlayers().Result;
            byClubReturn.Should().NotBeNull();
            byClubReturn!.Members.Should().NotBeEmpty();
            byClubReturn!.PositionCount.Should().NotBeNull();
            byClubReturn!.PositionCount.DefenseMen.Should().NotBeNull();
            byClubReturn!.PositionCount.Forwards.Should().NotBeNull();
            byClubReturn!.PositionCount.Goalie.Should().NotBeNull();
        }

        [Fact]
        public void PlayerByClubIntegrationTests_ClubDoesNotExists()
        {
            PlayersByClubIDRequest playerRequest = new PlayersByClubIDRequest(99999, "common-gen5");
            PlayerByClubReturn? byClubReturn = playerRequest.GetPlayers().Result;
            byClubReturn.Should().NotBeNull();
            byClubReturn!.Members.Should().BeEmpty();
            byClubReturn!.PositionCount.Should().NotBeNull();
            byClubReturn!.PositionCount.DefenseMen.Should().BeNull();
            byClubReturn!.PositionCount.Forwards.Should().BeNull();
            byClubReturn!.PositionCount.Goalie.Should().BeNull();
        }
    }
}
