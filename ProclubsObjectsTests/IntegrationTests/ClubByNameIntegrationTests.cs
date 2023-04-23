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
        void GetClubByName()
        {
            var webRequest = new ProclubsWebRequest();
            var validator = new ProclubsPlatformValidator();

            GetClubsRequest request = new GetClubsRequest("common-gen5", "old time hockey", webRequest, validator);
            string result = request.GetClubs().Result;

            var clubReturn = JsonConvert.DeserializeObject<Dictionary<string, Club>>(result);
            clubReturn.Should().NotBeNull();
        }
    }
}
