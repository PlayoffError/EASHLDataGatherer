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
        [InlineData("ps5")]
        [InlineData("ps4")]
        [InlineData("xbox-series-xs")]
        [InlineData("xboxone")]
        [InlineData("common-gen4")]
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
        [InlineData("ps5", 1463)]
        [InlineData("ps4", 2532)]
        [InlineData("xbox-series-xs", 35)]
        [InlineData("xboxone", 2305)]
        [InlineData("common-gen4", 2532)]
        [InlineData("common-gen5", 1463)]        
        void URL_SubstituteValues(string platform, long clubID)
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(clubID, platform, webRequest, platformValidator);

            request.URL.Should().Be($"https://proclubs.ea.com/api/nhl/members/stats?clubId={clubID}&platform={platform}");
        }

        [Theory]
        [InlineData("ps5", 1463)]
        [InlineData("ps4", 2532)]
        [InlineData("xbox-series-xs", 35)]
        [InlineData("xboxone", 2305)]
        [InlineData("common-gen4", 2532)]
        [InlineData("common-gen5", 1463)]
        
        void URL_GetPlayers_ClubExists(string platform, long clubID)
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(clubID, platform, webRequest, platformValidator);
            string result = request.GetPlayers().Result;
            result.Should().StartWith("{\"members\":[");
        }

        [Theory]
        [InlineData("ps5", 999999)]
        [InlineData("ps4", 999999)]
        [InlineData("xbox-series-xs", 999999)]
        [InlineData("xboxone", 999999)]
        [InlineData("common-gen4", 999999)]
        [InlineData("common-gen5", 999999)]
        
        void URL_GetPlayers_ClubDoesNotExist(string platform, long clubID )
        {
            string testURL = "test URL";
            var innerException = new Exception("test message");

            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(clubID, platform, webRequest, platformValidator);
            string result = request.GetPlayers().Result;
            result.Should().Be("{\"error\":{\"component\":11,\"errorcode\":66125835,\"errorname\":\"CLUBS_ERR_INVALID_CLUB_ID\"}}");
        }
    }
}
