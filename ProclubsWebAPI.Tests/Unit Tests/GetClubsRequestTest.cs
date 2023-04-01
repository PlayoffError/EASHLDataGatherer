using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using ProclubsWebAPI.Abstract;

namespace ProclubsWebAPI.Tests
{
    public class GetClubsRequestTest
    {
        [Fact]
        void Constructor_Success()
        {
            var webRequest = A.Fake<IWebRequest>();
            var validator = A.Fake<IPlatformValidator>();
            A.CallTo(() => validator.Validate(A<string>.Ignored)).Returns(true);

            GetClubsRequest request = new GetClubsRequest("PS5", "Joe NHL", webRequest, validator);
            request.Platform.Should().Be("PS5");
            request.SearchName.Should().Be("Joe NHL");
            request.WebRequest.Should().Be(webRequest);
        }

        [Fact]
        void Constructor_NullWebRequest_Fail()
        {
            var validator = A.Fake<IPlatformValidator>();

            Action testConstruct = () => new GetClubsRequest("PS5", "Joe NHL", null, validator);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("webRequest");
        }

        [Fact]
        void Constructor_NullPlatformValidator_Fail()
        {
            var webRequest = A.Fake<IWebRequest>();

            Action testConstruct = () => new GetClubsRequest("PS5", "Joe NHL", webRequest, null);
            testConstruct.Should().Throw<ArgumentNullException>().WithParameterName("platformValidator");
        }

        [Fact]
        void Constructor_InvalidPlatformName_Fail()
        {
            var webRequest = A.Fake<IWebRequest>();
            var validator = A.Fake<IPlatformValidator>();
            A.CallTo(() => validator.Validate(A<string>.Ignored)).Returns(false);

            Action testConstruct = () => new GetClubsRequest("PS5", "Joe NHL", webRequest, validator);
            testConstruct.Should().Throw<ArgumentOutOfRangeException>().WithParameterName("platform");
        }

        [Fact]
        void URL_SubstituteValues()
        {
            var webRequest = A.Fake<IWebRequest>();
            var validator = A.Fake<IPlatformValidator>();
            A.CallTo(() => validator.Validate(A<string>.Ignored)).Returns(true);

            GetClubsRequest request = new GetClubsRequest("PS5", "Joe NHL", webRequest, validator);

            request.URL.Should().Be($"https://proclubs.ea.com/api/nhl/clubs/search?platform=PS5&clubName=Joe+NHL");
        }

        [Fact]
        void URL_GetClubs()
        {
            var webRequest = A.Fake<IWebRequest>();
            A.CallTo(() => webRequest.Process(A<string>.Ignored)).Returns("test return value");
            var validator = A.Fake<IPlatformValidator>();
            A.CallTo(() => validator.Validate(A<string>.Ignored)).Returns(true);

            GetClubsRequest request = new GetClubsRequest("PS5", "Joe NHL", webRequest, validator);

            request.GetClubs().Result.Should().Be("test return value");
        }

        [Fact]
        void URL_GetClubs_WebRequestFails()
        {
            string testURL = "test URL";
            var innerException = new Exception("test message");

            var webRequest = A.Fake<IWebRequest>();
            A.CallTo(() => webRequest.Process(A<string>.Ignored)).Throws(() => new ProclubsWebRequestException("test url", innerException));
            var validator = A.Fake<IPlatformValidator>();
            A.CallTo(() => validator.Validate(A<string>.Ignored)).Returns(true);

            GetClubsRequest request = new GetClubsRequest("PS5", "Joe NHL", webRequest, validator);

            Func<Task> f = async () => { await request.GetClubs(); };
            f.Should().ThrowAsync<ProclubsWebRequestException>().WithMessage($"Error processing request for URL {testURL} .  Error: {innerException.Message}");
        }
    }
}
