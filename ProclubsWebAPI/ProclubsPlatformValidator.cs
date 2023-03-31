using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProclubsWebAPI
{
    public class ProclubsPlatformValidator : IPlatformValidator
    {
        private static readonly Lazy<List<string>> _validPlatforms = new Lazy<List<string>>(() => new List<string>() { "PS5", "PS4", "XBOX-SERIES-XS", "XBOXONE" });

        /// <inheritdoc/>
        public bool Validate(string platform)
        {
            if ( string.IsNullOrEmpty(platform) == false && _validPlatforms.Value.Contains(platform.ToUpper()) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
