using FakeItEasy;
using FluentAssertions;
using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI.Tests.Integration_Tests
{
    public class GetPlayersByClubIntegrationTests
    {
        [Theory]
        [InlineData("common-gen5")]
        void Constructor_Success(string platform)
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(1234, platform, webRequest, platformValidator);
            request.Platform.Should().Be(platform);
            request.ClubID.Should().Be(1234);
            request.WebRequest.Should().Be(webRequest);
        }

        [Fact]
        void Constructor_NullWebRequest_Fail()
        {
            var platformValidator = new ProclubsPlatformValidator();

            Action testConstruct = () => new GetPlayersByClubRequest(1234, "ps5", null, platformValidator);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("webRequest");
        }

        [Fact]
        void Constructor_NullPlatformValidator_Fail()
        {
            var webRequest = new ProclubsWebRequest();

            Action testConstruct = () => new GetPlayersByClubRequest(1234, "ps5", webRequest, null);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("platformValidator");
        }


        [Fact]
        void Constructor_InvalidPlatformName_Fail()
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            Action testConstruct = () => new GetPlayersByClubRequest(1234, "PS5", webRequest, platformValidator);
            testConstruct.Should().Throw<ArgumentOutOfRangeException>().WithParameterName("platform");
        }

        [Theory]
        [InlineData("common-gen5", 1463)]        
        void URL_SubstituteValues(string platform, long clubID)
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(clubID, platform, webRequest, platformValidator);

            request.URL.Should().Be($"https://proclubs.ea.com/api/nhl/members/stats?clubId={clubID}&platform={platform}");
        }

        [Theory]
        [InlineData("common-gen5", 746)]        
        void URL_GetPlayers_ClubExists(string platform, long clubID)
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(clubID, platform, webRequest, platformValidator);
            string result = request.GetPlayers().Result;
            result.Should().StartWith("{\"members\":[");
        }

        [Theory]
        [InlineData("common-gen5", 999999)]        
        void URL_GetPlayers_ClubDoesNotExist(string platform, long clubID )
        {
            var innerException = new Exception("test message");

            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(clubID, platform, webRequest, platformValidator);
            string result = request.GetPlayers().Result;
            result.Should().Be("Fail to request /clubs/getMembers, Response: {\n\"error\" : {\n    \"component\": 11,\n    \"errorcode\": 66125835,\n    \"errorname\": \"CLUBS_ERR_INVALID_CLUB_ID\"\n    }\n}\n");
        }
    }
}
