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
    public class GetPlayersByNameIntegrationTests
    {
        [Theory]
        [InlineData("common-gen4")]
        [InlineData("common-gen5")]
        void Constructor_Success(string platform)
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByNameRequest request = new GetPlayersByNameRequest("Joe NHL 1", platform, webRequest, platformValidator);
            request.Platform.Should().Be(platform);
            request.Name.Should().Be("Joe NHL 1");
            request.WebRequest.Should().Be(webRequest);
        }

        [Fact]
        void Constructor_NullWebRequest_Fail()
        {
            var platformValidator = new ProclubsPlatformValidator();

            Action testConstruct = () => new GetPlayersByNameRequest("Joe NHL 1", "ps5", null, platformValidator);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("webRequest");
        }

        [Fact]
        void Constructor_NullPlatformValidator_Fail()
        {
            var webRequest = new ProclubsWebRequest();

            Action testConstruct = () => new GetPlayersByNameRequest("Joe NHL 1", "ps5", webRequest, null);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("platformValidator");
        }


        [Fact]
        void Constructor_InvalidPlatformName_Fail()
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            Action testConstruct = () => new GetPlayersByNameRequest("Joe NHL 1", "PS5", webRequest, platformValidator);
            testConstruct.Should().Throw<ArgumentOutOfRangeException>().WithParameterName("platform");
        }

        [Theory]
        [InlineData("common-gen4")]
        [InlineData("common-gen5")]
        void URL_SubstituteValues(string platform)
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByNameRequest request = new GetPlayersByNameRequest("Joe NHL 1", platform, webRequest, platformValidator);

            request.URL.Should().Be($"https://proclubs.ea.com/api/nhl/members/search?platform={platform}&memberName=Joe+NHL+1");
        }

        [Theory]
        //[InlineData("ps5", "prnold")]
        //[InlineData("ps4", "winy125")]
        //[InlineData("xbox-series-xs", "FACE I16I")]
        //[InlineData("xboxone", "Tanka Haiku")]
        //[InlineData("common-gen4", "winy125")]
        //[InlineData("common-gen5", "xXrapidV2Xx")]
        [InlineData("common-gen5", "joe")]
        void URL_GetPlayers_PlayerExist(string platform, string name)
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByNameRequest request = new GetPlayersByNameRequest(name, platform, webRequest, platformValidator);

            string result = request.GetPlayers().Result;
            result.Should().StartWith("{\"members\":[{\"");
        }

        [Theory]
        [InlineData("common-gen4", "0000000")]
        [InlineData("common-gen5", "0000000")]
        void URL_GetPlayers_PLayerDoesNotExist(string platform, string name)
        {
            var innerException = new Exception("test message");

            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByNameRequest request = new GetPlayersByNameRequest(name, platform, webRequest, platformValidator);

            string result = request.GetPlayers().Result;
            result.Should().Be("{\"members\":[]}");
        }
    }
}
