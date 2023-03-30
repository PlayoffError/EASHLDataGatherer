﻿using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI
{
    public class GetGamesRequest : IGetGamesRequest
    {
        private GetGamesRequest() { }

        /// <summary>
        /// Constructs a GetGamesRequest instance
        /// </summary>
        /// <param name="clubID"></param>
        /// <param name="matchType"></param>
        /// <param name="platform"></param>
        /// <param name="webRequest"></param>
        public GetGamesRequest(long clubID, string matchType, string platform, IWebRequest webRequest)
        {
            ClubID = clubID;
            MatchType = matchType;
            Platform = platform;
            WebRequest = webRequest;
        }

        /// <inheritdoc/>
        public long ClubID { get; }

        /// <inheritdoc/>
        public string MatchType { get; }

        /// <inheritdoc/>
        public string URL 
        { 
            get
            {
                return $"https://proclubs.ea.com/api/nhl/clubs/matches?clubIds={ClubID}&platform={Platform}&matchType={MatchType}";
            }
        }

        /// <inheritdoc/>
        public IWebRequest WebRequest { get; }

        /// <inheritdoc/>
        public string Platform { get; }

        /// <inheritdoc/>
        public async Task<string> GetGames()
        {
            return await WebRequest.Process(URL);
        }
    }
}