using System;
using System.Collections.Generic;
using System.Text;

namespace ProclubsWebAPI.Abstract
{
    public interface IMatchTypeValidator
    {
        /// <summary>
        /// Checks to see if the provided match type is a valid match type string
        /// </summary>
        /// <param name="matchType"></param>
        /// <returns>True if the provided match type is valid, false otherwise</returns>
        bool Validate(string matchType);
    }
}
