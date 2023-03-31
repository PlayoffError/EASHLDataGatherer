using System;
using System.Collections.Generic;
using System.Text;

namespace ProclubsWebAPI.Abstract
{
    public interface IPlatformValidator
    {
        /// <summary>
        /// Checks to see if the provided platform is a valid platform string
        /// </summary>
        /// <param name="platform"></param>
        /// <returns>True if the provided platform is valid, false otherwise</returns>
        bool Validate(string platform);
    }
}
