using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI.Tests.Unit_Tests
{
    public class ProclubsMatchTypeValidatorTests
    {
        [Theory]
        [InlineData("GAMETYPE5")]
        [InlineData("GAMETYPE10")]
        [InlineData("CLUB_PRIVATE")]
        void Validate_ValidMatchTypes_UpperCase_Fails(string matchType)
        {
            ProclubsMatchTypeValidator validator = new ProclubsMatchTypeValidator();
            validator.Validate(matchType).Should().BeFalse();
        }

        [Theory]
        [InlineData("gameType5")]
        [InlineData("gameType10")]
        [InlineData("club_private")]
        void Validate_ValidMatchTypes_Exact(string matchType)
        {
            ProclubsMatchTypeValidator validator = new ProclubsMatchTypeValidator();
            validator.Validate(matchType).Should().BeTrue();
        }

        [Theory]
        [InlineData("GaMeTYpe5")]
        [InlineData("gAmeTyPe10")]
        [InlineData("cluB_prIvate")]
        void Validate_ValidMatchTypes_MixedCase_Fails(string matchType)
        {
            ProclubsMatchTypeValidator validator = new ProclubsMatchTypeValidator();
            validator.Validate(matchType).Should().BeFalse();
        }

        [Fact]
        void Validate_EmptyMatchTypes_Fails()
        {
            ProclubsMatchTypeValidator validator = new ProclubsMatchTypeValidator();
            validator.Validate(string.Empty).Should().BeFalse();
        }

        [Theory]
        [InlineData("gameType6")]
        [InlineData("gameType9")]
        [InlineData("club_public")]
        void Validate_InvalidMatchTypes_Fails(string matchType)
        {
            ProclubsMatchTypeValidator validator = new ProclubsMatchTypeValidator();
            validator.Validate(matchType).Should().BeFalse();
        }
    }
}
