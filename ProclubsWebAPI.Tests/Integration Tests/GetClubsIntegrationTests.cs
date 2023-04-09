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
    public class GetClubsIntegrationTests
    {
        [Theory]
        [InlineData("ps5")]
        [InlineData("ps4")]
        [InlineData("xbox-series-xs")]
        [InlineData("xboxone")]
        [InlineData("common-gen4")]
        [InlineData("common-gen5")]
        void Constructor_Success( string platformName )
        {
            var webRequest = new ProclubsWebRequest();
            var validator = new ProclubsPlatformValidator();

            GetClubsRequest request = new GetClubsRequest(platformName, "Club Test", webRequest, validator);
            request.Platform.Should().Be(platformName);
            request.SearchName.Should().Be("Club Test");
            request.WebRequest.Should().Be(webRequest);
        }

        [Fact]
        void Constructor_NullWebRequest_Fail()
        {
            var validator = new ProclubsPlatformValidator();

            Action testConstruct = () => new GetClubsRequest("PS5", "Club Test", null, validator);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("webRequest");
        }

        [Fact]
        void Constructor_NullPlatformValidator_Fail()
        {
            var webRequest = new ProclubsWebRequest();

            Action testConstruct = () => new GetClubsRequest("PS5", "Club Test", webRequest, null);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("platformValidator");
        }

        [Fact]
        void Constructor_InvalidPlatformName_Fail()
        {
            var webRequest = new ProclubsWebRequest();
            var validator = new ProclubsPlatformValidator();

            Action testConstruct = () => new GetClubsRequest("PS5", "Club Test", webRequest, validator);
            testConstruct.Should().Throw<ArgumentOutOfRangeException>().WithParameterName("platform");
        }

        [Theory]
        [InlineData("ps5", "Club Name", "Club+Name")]
        [InlineData("ps5", "ClubName", "ClubName")]
        [InlineData("ps4", "Club Name", "Club+Name")]
        [InlineData("ps4", "ClubName", "ClubName")]
        [InlineData("xbox-series-xs", "Club Name", "Club+Name")]
        [InlineData("xbox-series-xs", "ClubName", "ClubName")]
        [InlineData("xboxone", "Club Name", "Club+Name")]
        [InlineData("xboxone", "ClubName", "ClubName")]
        [InlineData("common-gen4", "Club Name", "Club+Name")]
        [InlineData("common-gen4", "ClubName", "ClubName")]
        [InlineData("common-gen5", "Club Name", "Club+Name")]
        [InlineData("common-gen5", "ClubName", "ClubName")]
        void URL_SubstituteValues(string platformName, string clubName, string urlClubName)
        {
            var webRequest = new ProclubsWebRequest();
            var validator = new ProclubsPlatformValidator();

            GetClubsRequest request = new GetClubsRequest(platformName, clubName, webRequest, validator);

            request.URL.Should().Be($"https://proclubs.ea.com/api/nhl/clubs/search?platform={platformName}&clubName={urlClubName}");
        }

        [Theory]
        [InlineData("ps4", "Plzensky Prazdroj")]
        [InlineData("ps5", "EHC Blackwings Linz")]
        [InlineData("xbox-series-xs", "Nothing 2 Prove")]
        [InlineData("xboxone", "MICKEY N FRIENDS")]
        [InlineData("common-gen4", "MICKEY N FRIENDS")]
        [InlineData("common-gen5", "EHC Blackwings Linz")]
        void URL_GetClubs_ClubExists(string platformName, string clubName)
        {
            var webRequest = new ProclubsWebRequest();
            var validator = new ProclubsPlatformValidator();

            GetClubsRequest request = new GetClubsRequest(platformName, clubName, webRequest, validator);
            string result = request.GetClubs().Result;
            result.Should().Contain($"\"name\":\"{clubName}\",");
            result.Should().Contain($"\"platform\":\"{platformName}\"");
        }

        [Theory]
        [InlineData("ps4", "00000000")]
        [InlineData("ps5", "00000000")]
        [InlineData("xbox-series-xs", "00000000")]
        [InlineData("xboxone", "00000000")]
        [InlineData("common-gen4", "00000000")]
        [InlineData("common-gen5", "00000000")]
        void URL_GetClubs_ClubDoesNotExist(string platformName, string clubName)
        {
            var webRequest = new ProclubsWebRequest();
            var validator = new ProclubsPlatformValidator();

            GetClubsRequest request = new GetClubsRequest(platformName, clubName, webRequest, validator);
            string result = request.GetClubs().Result;
            result.Should().Be("{}");
        }
    }
}
