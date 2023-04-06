using FakeItEasy;
using FluentAssertions;
using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProclubsWebAPI.Tests.Unit_Tests
{
    public class GetPlayersRequestTests
    {
        [Fact]
        void Constructor_Success()
        {
            var webRequest = A.Fake<IWebRequest>();
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            GetPlayersRequest request = new GetPlayersRequest(1234, "Joe NHL 1", "PS5", webRequest, platformValidator );
            request.Platform.Should().Be("PS5");
            request.ClubID.Should().Be(1234);
            request.Name.Should().Be("Joe NHL 1");
            request.WebRequest.Should().Be(webRequest);
        }

        [Fact]
        void Constructor_NullWebRequest_Fail()
        {
            var platformValidator = A.Fake<IPlatformValidator>();

            Action testConstruct = () => new GetPlayersRequest(1234, "Joe NHL 1", "PS5", null, platformValidator);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("webRequest");
        }

        [Fact]
        void Constructor_NullPlatformValidator_Fail()
        {
            var webRequest = A.Fake<IWebRequest>();

            Action testConstruct = () => new GetPlayersRequest(1234, "Joe NHL 1", "PS5", webRequest, null);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("platformValidator");
        }
        

        [Fact]
        void Constructor_InvalidPlatformName_Fail()
        {
            var webRequest = A.Fake<IWebRequest>();
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(false);

            Action testConstruct = () => new GetPlayersRequest(1234, "Joe NHL 1", "PS5", webRequest, platformValidator);
            testConstruct.Should().Throw<ArgumentOutOfRangeException>().WithParameterName("platform");
        }
        
        [Fact]
        void ByNameURL_SubstituteValues()
        {
            var webRequest = A.Fake<IWebRequest>();
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            GetPlayersRequest request = new GetPlayersRequest(1234, "Joe NHL 1", "PS5", webRequest, platformValidator);

            request.ByNameURL.Should().Be($"https://proclubs.ea.com/api/nhl/members/search?platform=PS5&memberName=Joe+NHL+1");
        }

        [Fact]
        void ByNameURL_GetPlayers()
        {
            var webRequest = A.Fake<IWebRequest>();
            A.CallTo(() => webRequest.Process(A<string>.Ignored)).Returns("test return value");
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            GetPlayersRequest request = new GetPlayersRequest(1234, "Joe NHL 1", "PS5", webRequest, platformValidator);

            request.GetPlayersByName().Result.Should().Be("test return value");
        }

        [Fact]
        void ByNameURL_GetPlayers_WebRequestFails()
        {
            string testURL = "test URL";
            var innerException = new Exception("test message");

            var webRequest = A.Fake<IWebRequest>();
            A.CallTo(() => webRequest.Process(A<string>.Ignored)).Throws(() => new ProclubsWebRequestException("test url", innerException));
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            GetPlayersRequest request = new GetPlayersRequest(1234, "Joe NHL 1", "PS5", webRequest, platformValidator);

            Func<Task> f = async () => { await request.GetPlayersByName(); };
            f.Should().ThrowAsync<ProclubsWebRequestException>().WithMessage($"Error processing request for URL {testURL} .  Error: {innerException.Message}");
        }

        [Fact]
        void ByClubURL_SubstituteValues()
        {
            var webRequest = A.Fake<IWebRequest>();
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            GetPlayersRequest request = new GetPlayersRequest(1234, "Joe NHL 1", "PS5", webRequest, platformValidator);

            request.ByClubURL.Should().Be($"https://proclubs.ea.com/api/nhl/members/stats?clubId=1234&platform=PS5");
        }

        [Fact]
        void ByClubURL_GetPlayers()
        {
            var webRequest = A.Fake<IWebRequest>();
            A.CallTo(() => webRequest.Process(A<string>.Ignored)).Returns("test return value");
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            GetPlayersRequest request = new GetPlayersRequest(1234, "Joe NHL 1", "PS5", webRequest, platformValidator);

            request.GetPlayersByClub().Result.Should().Be("test return value");
        }

        [Fact]
        void ByClubURL_GetPlayers_WebRequestFails()
        {
            string testURL = "test URL";
            var innerException = new Exception("test message");

            var webRequest = A.Fake<IWebRequest>();
            A.CallTo(() => webRequest.Process(A<string>.Ignored)).Throws(() => new ProclubsWebRequestException("test url", innerException));
            var platformValidator = A.Fake<IPlatformValidator>();
            A.CallTo(() => platformValidator.Validate(A<string>.Ignored)).Returns(true);

            GetPlayersRequest request = new GetPlayersRequest(1234, "Joe NHL 1", "PS5", webRequest, platformValidator);

            Func<Task> f = async () => { await request.GetPlayersByClub(); };
            f.Should().ThrowAsync<ProclubsWebRequestException>().WithMessage($"Error processing request for URL {testURL} .  Error: {innerException.Message}");
        }
    }
}
