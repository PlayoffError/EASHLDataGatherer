using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI
{
    public class GetClubsRequest : IGetClubsRequest
    {
        private GetClubsRequest() { }

        /// <summary>
        /// Constructs a GetClubsRequest
        /// </summary>
        /// <param name="platform"></param>
        /// <param name="searchName"></param>
        /// <param name="url"></param>
        /// <param name="webRequest"></param>
        /// <param name="platformValidator"></param>
        public GetClubsRequest(string platform, string searchName, IWebRequest webRequest, IPlatformValidator platformValidator)
        {
            if (webRequest == null)
            {
                throw new ArgumentNullException(nameof(webRequest));
            }

            if ( platformValidator == null )
            {
                throw new ArgumentNullException(nameof(platformValidator));
            }

            if ( platformValidator.Validate(platform) == false)
            {
                throw new ArgumentOutOfRangeException("platform", platform, $"Provided value is not a valid platform.");
            }

            Platform = platform;
            SearchName = searchName;           
            WebRequest = webRequest;
        }

        /// <inheritdoc/>
        public string Platform { get; }

        /// <inheritdoc/>
        public string SearchName { get; }

        /// <inheritdoc/>
        public string URL 
        {
            get 
            {
                string clubNameFormatted = SearchName.Replace(" ", "+");
                return $"https://proclubs.ea.com/api/nhl/clubs/search?platform={Platform}&clubName={clubNameFormatted}";
            }  
        }

        /// <inheritdoc/>
        public IWebRequest WebRequest { get; }

        /// <inheritdoc/>
        public async Task<string> GetClubs()
        {
            return await WebRequest.Process(URL);
        }
    }
}
