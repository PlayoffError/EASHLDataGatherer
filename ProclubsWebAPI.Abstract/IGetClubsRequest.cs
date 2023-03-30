using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI.Abstract
{
    /// <summary>
    /// Represents a web request to get information about clubs
    /// </summary>
    public interface IGetClubsRequest
    {
        /// <summary>
        /// The console platform to search on.
        /// 
        /// Valid values are:
        /// ps5 
        /// ps4 
        /// xbox-series-xs 
        /// xboxone
        /// </summary>
        public string Platform { get; }

        /// <summary>
        /// The name or partial name of the club to search for.
        /// </summary>
        public string SearchName { get; }

        /// <summary>
        /// The URL of the get clubs web request
        /// </summary>
        public string URL { get; }

        /// <summary>
        /// Object that will process the web call
        /// </summary>
        public IWebRequest WebRequest { get; }

        /// <summary>
        /// Call to get the information for the club(s) that match the search criteria.
        /// </summary>
        /// <returns>JSON string containing the club information.</returns>
        public Task<string> GetClubs();
    }
}
