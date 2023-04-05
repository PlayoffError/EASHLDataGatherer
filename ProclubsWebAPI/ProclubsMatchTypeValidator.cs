using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProclubsWebAPI
{
    public class ProclubsMatchTypeValidator : IMatchTypeValidator
    {
        // gameType5 is Online Season games
        // gametype10 is Club Finals games
        // club_private is Private games
        private static readonly Lazy<List<string>> _validMatchTypes = new Lazy<List<string>>(() => new List<string>() { "gameType5", "gameType10", "club_private" });

        ///<inheritdoc/>
        public bool Validate(string matchType)
        {
            // Current implementation of the proclubs API is case sensitive
            if (string.IsNullOrEmpty(matchType) == false && _validMatchTypes.Value.Contains(matchType))
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
