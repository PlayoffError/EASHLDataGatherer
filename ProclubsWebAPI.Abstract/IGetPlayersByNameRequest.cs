using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI.Abstract
{
    public interface IGetPlayersByNameRequest
    {        
        /// <summary>
        /// Name of the player to search for.  Required if getting players
        /// by name.
        /// </summary>
        public string Name { get; }

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
        /// The URL of the get players by name web request
        /// </summary>
        public string URL { get; }
        
        /// <summary>
        /// Object that will process the web call
        /// </summary>
        public IWebRequest WebRequest { get; }

        /// <summary>
        /// Call to get players by their name.
        /// </summary>
        /// <returns>JSON string containing the player information.</returns>
        public Task<string> GetPlayers();        
    }
}
