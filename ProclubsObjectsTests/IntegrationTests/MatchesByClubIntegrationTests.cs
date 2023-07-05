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
        void GetMatches_ClubExists()
        {
            RecentMatchesByClubIDRequest matchRequest = new RecentMatchesByClubIDRequest(1463, "gameType5", "common-gen5");
            List<Match>? matches = matchRequest.GetMatches().Result;            
            matches.Should().NotBeNull();
            matches!.Count().Should().Be(5);
        }

        [Fact]
        void GetMatches_ClubDoesNotExist()
        {
            RecentMatchesByClubIDRequest matchRequest = new RecentMatchesByClubIDRequest(999999, "gameType5", "common-gen5");
            List<Match>? matches = matchRequest.GetMatches().Result;
            matches.Should().BeEmpty();
        }
    }
}
