using FakeItEasy;
using FluentAssertions;
using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI.Tests.Unit_Tests
{
    public class GetPlayersByClubRequestTests
    {
        [Fact]
        void Constructor_Success()
        {
            var webRequest = A.Fake<IWebRequest>();
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(1234, "PS5", webRequest, platformValidator);
            request.Platform.Should().Be("PS5");
            request.ClubID.Should().Be(1234);
            request.WebRequest.Should().Be(webRequest);
        }

        [Fact]
        void Constructor_NullWebRequest_Fail()
        {
            var platformValidator = A.Fake<IPlatformValidator>();

            Action testConstruct = () => new GetPlayersByClubRequest(1234, "PS5", null, platformValidator);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("webRequest");
        }

        [Fact]
        void Constructor_NullPlatformValidator_Fail()
        {
            var webRequest = A.Fake<IWebRequest>();

            Action testConstruct = () => new GetPlayersByClubRequest(1234, "PS5", webRequest, null);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("platformValidator");
        }


        [Fact]
        void Constructor_InvalidPlatformName_Fail()
        {
            var webRequest = A.Fake<IWebRequest>();
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(false);

            Action testConstruct = () => new GetPlayersByClubRequest(1234, "PS5", webRequest, platformValidator);
            testConstruct.Should().Throw<ArgumentOutOfRangeException>().WithParameterName("platform");
        }

        [Fact]
        void URL_SubstituteValues()
        {
            var webRequest = A.Fake<IWebRequest>();
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(1234, "PS5", webRequest, platformValidator);

            request.URL.Should().Be($"https://proclubs.ea.com/api/nhl/members/stats?clubId=1234&platform=PS5");
        }

        [Fact]
        void URL_GetPlayers()
        {
            var webRequest = A.Fake<IWebRequest>();
            A.CallTo(() => webRequest.Process(A<string>.Ignored)).Returns("test return value");
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(1234, "PS5", webRequest, platformValidator);

            request.GetPlayers().Result.Should().Be("test return value");
        }

        [Fact]
        void URL_GetPlayers_WebRequestFails()
        {
            string testURL = "test URL";
            var innerException = new Exception("test message");

            var webRequest = A.Fake<IWebRequest>();
            A.CallTo(() => webRequest.Process(A<string>.Ignored)).Throws(() => new ProclubsWebRequestException("test url", innerException));
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            GetPlayersByClubRequest request = new GetPlayersByClubRequest(1234, "PS5", webRequest, platformValidator);

            Func<Task> f = async () => { await request.GetPlayers(); };
            f.Should().ThrowAsync<ProclubsWebRequestException>().WithMessage($"Error processing request for URL {testURL} .  Error: {innerException.Message}");
        }
    }
}
