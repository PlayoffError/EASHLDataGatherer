using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI
{
    public class GetPlayersByClubRequest : IGetPlayersByClubRequest
    {
        private GetPlayersByClubRequest() { }

        /// <summary>
        /// Constructs a GetPlayersByClubRequest instance
        /// </summary>
        /// <param name="clubID"></param>
        /// <param name="platform"></param>
        /// <param name="webRequest"></param>
        /// <param name="platformValidator"></param>
        public GetPlayersByClubRequest(long clubID, string platform, IWebRequest webRequest, IPlatformValidator platformValidator)
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
            Platform = platform;
            WebRequest = webRequest;
        }

        /// <inheritdoc/>
        public long ClubID { get; }        

        /// <inheritdoc/>
        public string Platform { get; }
       
        /// <inheritdoc/>
        public string URL
        {
            get
            {
                return $"https://proclubs.ea.com/api/nhl/members/stats?clubId={ClubID}&platform={Platform}";
            }
        }

        /// <inheritdoc/>
        public IWebRequest WebRequest { get; }

        /// <inheritdoc/>
        public async Task<string> GetPlayers()
        {
            return await WebRequest.Process(URL);
        }        
    }
}
