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
    public class ClubByNameIntegrationTests
    {
        [Fact]
        void GetClubByName_ClubExists()
        {
            ClubObjectsByNameRequest request = new ClubObjectsByNameRequest("prospect", "common-gen5");
            Dictionary<string, Club>? clubReturn = request.GetClubs().Result;
            
            clubReturn.Should().NotBeNull();
            clubReturn.Should().NotBeEmpty();

            Club firstClub = clubReturn!.Values.First();
            firstClub.Should().NotBeNull();

            firstClub.Name.ToUpper().Should().StartWith("PROSPECT");
            firstClub.Platform.Should().Be("common-gen5");
            firstClub.ClubInfo.Should().NotBeNull();
        }

        [Fact]
        void GetClubByName_ClubDoesNotExist()
        {
            ClubObjectsByNameRequest request = new ClubObjectsByNameRequest("000000", "common-gen5");
            Dictionary<string, Club>? clubReturn = request.GetClubs().Result;

            clubReturn.Should().BeEmpty();
        }
    }
}
