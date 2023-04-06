using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI
{
    public class GetPlayersByNameRequest : IGetPlayersByNameRequest
    {
        private GetPlayersByNameRequest() { }

        /// <summary>
        /// Constructs a GetPlayersRequest instance
        /// </summary>
        /// <param name="name"></param>
        /// <param name="platform"></param>
        /// <param name="webRequest"></param>
        /// <param name="platformValidator"></param>
        public GetPlayersByNameRequest(string name, string platform, IWebRequest webRequest, IPlatformValidator platformValidator)
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

            Name = name;
            Platform = platform;
            WebRequest = webRequest;
        }

        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public string Platform { get; }

        /// <inheritdoc/>
        public string URL 
        { 
            get
            {
                string nameFormatted = Name.Replace(" ", "+");
                return $"https://proclubs.ea.com/api/nhl/members/search?platform={Platform}&memberName={nameFormatted}";
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
