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

        public async Task<PlayerByNameReturn?> GetPlayers()
        {
            var webRequest = new ProclubsWebRequest();
            var platformValidator = new ProclubsPlatformValidator();

            GetPlayersByNameRequest request = new GetPlayersByNameRequest(Name, Platform, webRequest, platformValidator);

            string result = await request.GetPlayers();

            return JsonConvert.DeserializeObject<PlayerByNameReturn>(result);
        }
    }
}
