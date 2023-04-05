using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProclubsWebAPI
{
    public class ProclubsPlatformValidator : IPlatformValidator
    {
        private static readonly Lazy<List<string>> _validPlatforms = new Lazy<List<string>>(() => new List<string>() { "ps5", "ps4", "xbox-series-xs", "xboxone", "common-gen4", "common-gen5" });

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
