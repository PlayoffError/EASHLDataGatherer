using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI.Abstract
{
    public interface IWebRequest
    {
        /// <summary>
        /// Processes the web request for the provided URL
        /// </summary>
        /// <param name="URL"></param>
        /// <returns>JSON string response from the web request</returns>
        public Task<string> Process( string URL );
    }
}
