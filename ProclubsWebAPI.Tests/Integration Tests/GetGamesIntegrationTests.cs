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
    public class GetGamesIntegrationTests
    {        
        [Theory]
        [InlineData("ps5", "gameType5")]
        [InlineData("ps4", "gameType5")]
        [InlineData("xbox-series-xs", "gameType5")]
        [InlineData("xboxone", "gameType5")]
        [InlineData("common-gen4", "gameType5")]
        [InlineData("common-gen5", "gameType5")]
        [InlineData("ps5", "gameType10")]
        [InlineData("ps4", "gameType10")]
        [InlineData("xbox-series-xs", "gameType10")]
        [InlineData("xboxone", "gameType10")]
        [InlineData("common-gen4", "gameType10")]
        [InlineData("common-gen5", "gameType10")]
        [InlineData("ps5", "club_private")]
        [InlineData("ps4", "club_private")]
        [InlineData("xbox-series-xs", "club_private")]
        [InlineData("xboxone", "club_private")]
        [InlineData("common-gen4", "club_private")]
        [InlineData("common-gen5", "club_private")]
        void Constructor_Success( string platform, string matchType )
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            var matchTypeValidator = new ProclubsMatchTypeValidator();

            GetGamesRequest request = new GetGamesRequest(1234, matchType, platform, webRequest, platformValidator, matchTypeValidator);
            request.Platform.Should().Be(platform);
            request.ClubID.Should().Be(1234);
            request.MatchType.Should().Be(matchType);
            request.WebRequest.Should().Be(webRequest);
        }

        [Fact]
        void Constructor_NullWebRequest_Fail()
        {
            var platformValidator = new ProclubsPlatformValidator();
            var matchTypeValidator = new ProclubsMatchTypeValidator();

            Action testConstruct = () => new GetGamesRequest(1234, "gameType5", "ps5", null, platformValidator, matchTypeValidator);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("webRequest");
        }

        [Fact]
        void Constructor_NullPlatformValidator_Fail()
        {
            var webRequest = new ProclubsWebRequest();
            var matchTypeValidator = new ProclubsMatchTypeValidator();

            Action testConstruct = () => new GetGamesRequest(1234, "gameType5", "ps5", webRequest, null, matchTypeValidator);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("platformValidator");
        }

        [Fact]
        void Constructor_NullMatchTypeValidator_Fail()
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            Action testConstruct = () => new GetGamesRequest(1234, "gameType5", "ps5", webRequest, platformValidator, null);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("matchTypeValidator");
        }

        [Fact]
        void Constructor_InvalidPlatformName_Fail()
        {
            var webRequest = new ProclubsWebRequest();
            var matchTypeValidator = new ProclubsMatchTypeValidator();
            var platformValidator = new ProclubsPlatformValidator();

            Action testConstruct = () => new GetGamesRequest(1234, "gameType5", "PS5", webRequest, platformValidator, matchTypeValidator);
            testConstruct.Should().Throw<ArgumentOutOfRangeException>().WithParameterName("platform");
        }

        [Fact]
        void Constructor_InvalidMatchType_Fail()
        {
            var webRequest = new ProclubsWebRequest();
            var matchTypeValidator = new ProclubsMatchTypeValidator();
            var platformValidator = new ProclubsPlatformValidator();

            Action testConstruct = () => new GetGamesRequest(1234, "matchType1", "ps5", webRequest, platformValidator, matchTypeValidator);
            testConstruct.Should().Throw<ArgumentOutOfRangeException>().WithParameterName("matchType");
        }

        [Theory]
        [InlineData("ps5", 1463, "gameType5")]
        [InlineData("ps4", 2532, "gameType5")]
        [InlineData("xbox-series-xs", 35, "gameType5")]
        [InlineData("xboxone", 2305, "gameType5")]
        [InlineData("common-gen4", 2532, "gameType5")]
        [InlineData("common-gen5", 1463, "gameType5")]
        [InlineData("ps5", 1463, "gameType10")]
        [InlineData("ps4", 2532, "gameType10")]
        [InlineData("xbox-series-xs", 35, "gameType10")]
        [InlineData("xboxone", 2305, "gameType10")]
        [InlineData("common-gen4", 2532, "gameType10")]
        [InlineData("common-gen5", 1463, "gameType10")]
        [InlineData("ps5", 1463, "club_private")]
        [InlineData("ps4", 2532, "club_private")]
        [InlineData("xbox-series-xs", 35, "club_private")]
        [InlineData("xboxone", 2305, "club_private")]
        [InlineData("common-gen4", 2532, "club_private")]
        [InlineData("common-gen5", 1463, "club_private")]
        void URL_SubstituteValues(string platform, long clubID, string matchType)
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();
            var matchTypeValidator = new ProclubsMatchTypeValidator();

            GetGamesRequest request = new GetGamesRequest(clubID, matchType, platform, webRequest, platformValidator, matchTypeValidator);

            request.URL.Should().Be($"https://proclubs.ea.com/api/nhl/clubs/matches?clubIds={clubID}&platform={platform}&matchType={matchType}");
        }

        [Theory]
        [InlineData("ps5", 1463, "gameType5")]
        [InlineData("ps4", 2532, "gameType5")]
        [InlineData("xbox-series-xs", 35, "gameType5")]
        [InlineData("xboxone", 2305, "gameType5")]
        [InlineData("common-gen4", 2532, "gameType5")]
        [InlineData("common-gen5", 1463, "gameType5")]
        [InlineData("ps5", 1463, "gameType10")]
        [InlineData("ps4", 2532, "gameType10")]
        [InlineData("xbox-series-xs", 35, "gameType10")]
        [InlineData("xboxone", 2305, "gameType10")]
        [InlineData("common-gen4", 2532, "gameType10")]
        [InlineData("common-gen5", 1463, "gameType10")]
        [InlineData("ps5", 1463, "club_private")]
        [InlineData("ps4", 2532, "club_private")]
        [InlineData("xbox-series-xs", 35, "club_private")]
        [InlineData("xboxone", 9997, "club_private")]
        [InlineData("common-gen4", 2532, "club_private")]
        [InlineData("common-gen5", 1463, "club_private")]
        void URL_GetGames_ClubExists(string platform, long clubID, string matchType)
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();
            var matchTypeValidator = new ProclubsMatchTypeValidator();

            GetGamesRequest request = new GetGamesRequest(clubID, matchType, platform, webRequest, platformValidator, matchTypeValidator);
            string result = request.GetGames().Result;
            result.Should().StartWith("[{\"matchId\":\"");
        }

        [Theory]
        [InlineData("ps5", 999999, "gameType5")]
        [InlineData("ps4", 999999, "gameType5")]
        [InlineData("xbox-series-xs", 999999, "gameType5")]
        [InlineData("xboxone", 999999, "gameType5")]
        [InlineData("common-gen4", 999999, "gameType5")]
        [InlineData("common-gen5", 999999, "gameType5")]
        [InlineData("ps5", 999999, "gameType10")]
        [InlineData("ps4", 999999, "gameType10")]
        [InlineData("xbox-series-xs", 999999, "gameType10")]
        [InlineData("xboxone", 999999, "gameType10")]
        [InlineData("common-gen4", 999999, "gameType10")]
        [InlineData("common-gen5", 999999, "gameType10")]
        [InlineData("ps5", 999999, "club_private")]
        [InlineData("ps4", 999999, "club_private")]
        [InlineData("xbox-series-xs", 999999, "club_private")]
        [InlineData("xboxone", 999999, "club_private")]
        [InlineData("common-gen4", 999999, "club_private")]
        [InlineData("common-gen5", 999999, "club_private")]
        void URL_GetGames_ClubDoesNotExist(string platform, long clubID, string matchType)
        {
            var innerException = new Exception("test message");

            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();
            var matchTypeValidator = new ProclubsMatchTypeValidator();

            GetGamesRequest request = new GetGamesRequest(clubID, matchType, platform, webRequest, platformValidator, matchTypeValidator);
            string result = request.GetGames().Result;
            result.Should().Be("[]");

        }
    }
}
