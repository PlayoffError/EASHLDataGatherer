using Newtonsoft.Json;
using ProclubsWebAPI;

namespace ProclubsObjects
{
    public class PlayersByNameRequest
    {
        public PlayersByNameRequest( string name, string platform )
        {
            Name = name;
            Platform = platform;
        }

        public string Name { get; }
        public string Platform { get; }

        public PlayerByNameReturn? GetPlayers()
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByNameRequest request = new GetPlayersByNameRequest(Name, Platform, webRequest, platformValidator);

            string result = request.GetPlayers().Result;

            return JsonConvert.DeserializeObject<PlayerByNameReturn>(result);
        }
    }
}
