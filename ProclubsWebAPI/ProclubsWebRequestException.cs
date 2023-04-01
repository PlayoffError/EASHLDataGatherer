using System;
using System.Collections.Generic;
using System.Text;

namespace ProclubsWebAPI
{
    public class ProclubsWebRequestException : Exception
    {
        public ProclubsWebRequestException(string url, Exception innerException) 
            : base(innerException.Message, innerException)
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
