using FakeItEasy;
using FluentAssertions;
using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI.Tests.Unit_Tests
{
    public class GetGamesRequestTests
    {
        [Fact]
        void Constructor_Success()
        {
            var webRequest = A.Fake<IWebRequest>();
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            var matchTypeValidator = A.Fake<IMatchTypeValidator>();
            A.CallTo(() => matchTypeValidator.Validate(A<string>.Ignored)).Returns(true);

            GetGamesRequest request = new GetGamesRequest(1234, "matchType1", "PS5", webRequest, platformValidator, matchTypeValidator);
            request.Platform.Should().Be("PS5");
            request.ClubID.Should().Be(1234);
            request.MatchType.Should().Be("matchType1");
            request.WebRequest.Should().Be(webRequest);
        }

        [Fact]
        void Constructor_NullWebRequest_Fail()
        {
            var platformValidator = A.Fake<IPlatformValidator>();
            var matchTypeValidator = A.Fake<IMatchTypeValidator>();

            Action testConstruct = () => new GetGamesRequest(1234, "matchType1", "PS5", null, platformValidator, matchTypeValidator);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("webRequest");
        }

        [Fact]
        void Constructor_NullPlatformValidator_Fail()
        {
            var webRequest = A.Fake<IWebRequest>();
            var matchTypeValidator = A.Fake<IMatchTypeValidator>();

            Action testConstruct = () => new GetGamesRequest(1234, "matchType1", "PS5", webRequest, null, matchTypeValidator);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("platformValidator");
        }

        [Fact]
        void Constructor_NullMatchTypeValidator_Fail()
        {
            var webRequest = A.Fake<IWebRequest>();
            var platformValidator = A.Fake<IPlatformValidator>();

            Action testConstruct = () => new GetGamesRequest(1234, "matchType1", "PS5", webRequest, platformValidator, null);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("matchTypeValidator");
        }

        [Fact]
        void Constructor_InvalidPlatformName_Fail()
        {
            var webRequest = A.Fake<IWebRequest>();
            var matchTypeValidator = A.Fake<IMatchTypeValidator>();
            A.CallTo(() => matchTypeValidator.Validate(A<string>.Ignored)).Returns(true);
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(false);

            Action testConstruct = () => new GetGamesRequest(1234, "matchType1", "PS5", webRequest, platformValidator, matchTypeValidator);
            testConstruct.Should().Throw<ArgumentOutOfRangeException>().WithParameterName("platform");
        }

        [Fact]
        void Constructor_InvalidMatchType_Fail()
        {
            var webRequest = A.Fake<IWebRequest>();
            var matchTypeValidator = A.Fake<IMatchTypeValidator>();
            A.CallTo(() => matchTypeValidator.Validate(A<string>.Ignored)).Returns(false);
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            Action testConstruct = () => new GetGamesRequest(1234, "matchType1", "PS5", webRequest, platformValidator, matchTypeValidator);
            testConstruct.Should().Throw<ArgumentOutOfRangeException>().WithParameterName("matchType");
        }

        [Fact]
        void URL_SubstituteValues()
        {
            var webRequest = A.Fake<IWebRequest>();
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);
            var matchTypeValidator = A.Fake<IMatchTypeValidator>();
            A.CallTo(() => matchTypeValidator.Validate(A<string>.Ignored)).Returns(true);

            GetGamesRequest request = new GetGamesRequest(1234, "matchType1", "PS5", webRequest, platformValidator, matchTypeValidator);

            request.URL.Should().Be($"https://proclubs.ea.com/api/nhl/clubs/matches?clubIds=1234&platform=PS5&matchType=matchType1");
        }

        [Fact]
        void URL_GetGames()
        {
            var webRequest = A.Fake<IWebRequest>();
            A.CallTo(() => webRequest.Process(A<string>.Ignored)).Returns("test return value");
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);
            var matchTypeValidator = A.Fake<IMatchTypeValidator>();
            A.CallTo(() => matchTypeValidator.Validate(A<string>.Ignored)).Returns(true);

            GetGamesRequest request = new GetGamesRequest(1234, "matchType1", "PS5", webRequest, platformValidator, matchTypeValidator);

            request.GetGames().Result.Should().Be("test return value");
        }

        [Fact]
        void URL_GetGames_WebRequestFails()
        {
            string testURL = "test URL";
            var innerException = new Exception("test message");

            var webRequest = A.Fake<IWebRequest>();
            A.CallTo(() => webRequest.Process(A<string>.Ignored)).Throws(() => new ProclubsWebRequestException("test url", innerException));
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);
            var matchTypeValidator = A.Fake<IMatchTypeValidator>();
            A.CallTo(() => matchTypeValidator.Validate(A<string>.Ignored)).Returns(true);

            GetGamesRequest request = new GetGamesRequest(1234, "matchType1", "PS5", webRequest, platformValidator, matchTypeValidator);

            Func<Task> f = async () => { await request.GetGames(); };
            f.Should().ThrowAsync<ProclubsWebRequestException>().WithMessage($"Error processing request for URL {testURL} .  Error: {innerException.Message}");
        }
    }
}
