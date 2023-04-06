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
        /// <param name="platformValidator"></param>
        public GetPlayersRequest(long clubID, string name, string platform, IWebRequest webRequest, IPlatformValidator platformValidator)
        {
            if (webRequest == null)
            {
                throw new ArgumentNullException(nameof(webRequest));
            }

            if (platformValidator == null)
            {
                throw new ArgumentNullException(nameof(platformValidator));
            }

            if (platformValidator.Validate(platform) == false)
            {
                throw new ArgumentOutOfRangeException("platform", platform, $"Provided value is not a valid platform.");
            }

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
                string nameFormatted = Name.Replace(" ", "+");
                return $"https://proclubs.ea.com/api/nhl/members/search?platform={Platform}&memberName={nameFormatted}";
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
