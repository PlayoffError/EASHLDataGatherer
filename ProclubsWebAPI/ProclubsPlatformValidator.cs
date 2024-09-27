using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProclubsWebAPI
{
    public class ProclubsPlatformValidator : IPlatformValidator
    {
        // As of NHL 25 there is only one valid platform
        private static readonly Lazy<List<string>> _validPlatforms = new Lazy<List<string>>(() => new List<string>() { "common-gen5" });

        /// <inheritdoc/>
        public bool Validate(string platform)
        {
            // Current implementation of the proclubs API is case sensitive
            if ( string.IsNullOrEmpty(platform) == false && _validPlatforms.Value.Contains(platform) )
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
