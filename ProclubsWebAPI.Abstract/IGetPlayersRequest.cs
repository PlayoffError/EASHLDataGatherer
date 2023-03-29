using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI.Abstract
{
    public interface IGetPlayersRequest
    {
        /// <summary>
        /// ID of the club desired players belong to.  Required if
        /// getting players by club.
        /// </summary>
        public long ClubID { get; }

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
        /// Call to get players by their name.
        /// </summary>
        /// <returns>JSON string containing the player information.</returns>
        public Task<string> GetPlayersByName();

        /// <summary>
        /// Call to get players by their club.
        /// </summary>
        /// <returns>JSON string containing the player information.</returns>
        public Task<string> GetPlayersByClub();
    }
}
