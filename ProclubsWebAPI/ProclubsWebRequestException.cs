using System;
using System.Collections.Generic;
using System.Text;

namespace ProclubsWebAPI
{
    public class ProclubsWebRequestException : Exception
    {
        public ProclubsWebRequestException(string url, string message, Exception innerException) 
            : base(message, innerException)
        {
            URL = url;
        }

        public string URL { get; }

        public override string Message
        {
            get 
            {
                return $"Error processing request for URL {URL} .  Error: {InnerException.Message}";
            }
        }
    }
}
