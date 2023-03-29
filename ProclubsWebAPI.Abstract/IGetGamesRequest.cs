using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI.Abstract
{
    public interface IGetGamesRequest
    {
        /// <summary>
        /// Numeric ID of the club to find games for
        /// </summary>
        public long ClubID { get; }

        /// <summary>
        /// Match type of games
        /// 
        /// Valid values are:
        /// gameType5, 
        /// gameType10, 
        /// club_private
        /// 
        /// </summary>
        public string MatchType { get; }

        /// <summary>
        /// Call to get the information for the games that match the search criteria.
        /// </summary>
        /// <returns>JSON string containing the game information.</returns>
        public Task<string> GetGames();
    }    
}
