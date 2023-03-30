using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI
{
    public class GetPlayersRequest : IGetPlayersRequest
    {
        private GetPlayersRequest() { }

        /// <summary>
        /// Constructs a GetPlayersRequest instance
        /// </summary>
        /// <param name="clubID"></param>
        /// <param name="name"></param>
        /// <param name="platform"></param>
        /// <param name="byNameURL"></param>
        /// <param name="byClubURL"></param>
        /// <param name="webRequest"></param>
        public GetPlayersRequest(long clubID, string name, string platform, IWebRequest webRequest)
        {
            ClubID = clubID;
            Name = name;
            Platform = platform;
            WebRequest = webRequest;
        }

        /// <inheritdoc/>
        public long ClubID { get; }

        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public string Platform { get; }

        /// <inheritdoc/>
        public string ByNameURL 
        { 
            get
            {
                return $"https://proclubs.ea.com/api/nhl/members/search?platform={Platform}&memberName={Name}";
            }
        }

        /// <inheritdoc/>
        public string ByClubURL 
        { 
            get
            {
                return $"https://proclubs.ea.com/api/nhl/members/stats?clubId={ClubID}&platform={Platform}";
            }
        }

        /// <inheritdoc/>
        public IWebRequest WebRequest { get; }

        /// <inheritdoc/>
        public async Task<string> GetPlayersByClub()
        {
            return await WebRequest.Process(ByClubURL);
        }

        /// <inheritdoc/>
        public async Task<string> GetPlayersByName()
        {
            return await WebRequest.Process(ByNameURL);
        }
    }
}
