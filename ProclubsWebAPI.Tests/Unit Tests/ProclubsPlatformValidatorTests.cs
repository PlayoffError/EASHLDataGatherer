using FluentAssertions;

namespace ProclubsWebAPI.Tests
{
    public class ProclubsPlatformValidatorTests
    {
        [Theory]
        [InlineData("PS5")]
        [InlineData("PS4")]
        [InlineData("XBOX-SERIES-XS")]
        [InlineData("XBOXONE")]
        void Validate_ValidPlatforms_UpperCase_Fails(string platform)
        {
            ProclubsPlatformValidator validator = new ProclubsPlatformValidator();
            validator.Validate(platform).Should().BeFalse();
        }

        [Theory]
        [InlineData("ps5")]
        [InlineData("ps4")]
        [InlineData("xbox-series-xs")]
        [InlineData("xboxone")]
        void Validate_ValidPlatforms_Exact(string platform)
        {
            ProclubsPlatformValidator validator = new ProclubsPlatformValidator();
            validator.Validate(platform).Should().BeTrue();
        }

        [Theory]
        [InlineData("pS5")]
        [InlineData("Ps4")]
        [InlineData("XbOx-SERies-xS")]
        [InlineData("xbOxONe")]
        void Validate_ValidPlatforms_MixedCase_Fails(string platform)
        {
            ProclubsPlatformValidator validator = new ProclubsPlatformValidator();
            validator.Validate(platform).Should().BeFalse();
        }

        [Fact]
        void Validate_EmptyPlatform_Fails()
        {
            ProclubsPlatformValidator validator = new ProclubsPlatformValidator();
            validator.Validate(string.Empty).Should().BeFalse();
        }

        [Theory]
        [InlineData("")]
        [InlineData("ps6")]
        [InlineData("XBOX360")]
        [InlineData("ps5 ")]
        [InlineData(" PS5")]
        [InlineData("p s 5")]
        void Validate_InvalidPlatform_Fails(string platform)
        {
            ProclubsPlatformValidator validator = new ProclubsPlatformValidator();
            validator.Validate(platform).Should().BeFalse();
        }
    }
}