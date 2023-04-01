using ProclubsWebAPI.Abstract;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProclubsWebAPI
{
    public class ProclubsWebRequest : IWebRequest
    {        
        ///<inheritdoc/>
        public async Task<string> Process(string URL)
        {
            // Use an HttpClient to make the call to the EA API to get the requested infromation.
            using (var httpClient = new HttpClient())
            {
                using (var requestMessage = new HttpRequestMessage(new HttpMethod("GET"), URL))
                {
                    // Setup the headers to simulate a call from Postman.  
                    requestMessage.Headers.Add("User-Agent", "PostmanRuntime/7.28.4");
                    requestMessage.Headers.Add("Accept", "*/*");
                    requestMessage.Headers.TryAddWithoutValidation("referer", "www.ea.com");

                    try
                    {
                        var response = await httpClient.SendAsync(requestMessage).ConfigureAwait(false);

                        using (HttpContent content = response.Content)
                        {
                            var json = await content.ReadAsStringAsync();
                            return json;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ProclubsWebRequestException(URL, ex);
                    }                    
                }
            }
        }
    }
}
