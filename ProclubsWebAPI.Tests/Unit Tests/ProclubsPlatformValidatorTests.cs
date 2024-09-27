using FluentAssertions;

namespace ProclubsWebAPI.Tests
{
    public class ProclubsPlatformValidatorTests
    {
        [Theory]
        [InlineData("COMMON-GEN5")]
        void Validate_ValidPlatforms_UpperCase_Fails(string platform)
        {
            ProclubsPlatformValidator validator = new ProclubsPlatformValidator();
            validator.Validate(platform).Should().BeFalse();
        }

        [Theory]
        [InlineData("common-gen5")]
        void Validate_ValidPlatforms_Exact(string platform)
        {
            ProclubsPlatformValidator validator = new ProclubsPlatformValidator();
            validator.Validate(platform).Should().BeTrue();
        }

        [Theory]
        [InlineData("common-Gen5")]
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
        [InlineData("common-gen4")]
        void Validate_InvalidPlatform_Fails(string platform)
        {
            ProclubsPlatformValidator validator = new ProclubsPlatformValidator();
            validator.Validate(platform).Should().BeFalse();
        }
    }
}