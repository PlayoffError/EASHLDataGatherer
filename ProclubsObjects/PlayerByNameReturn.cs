using Newtonsoft.Json;

namespace ProclubsObjects
{
    public class PlayerByNameReturn
    {
        [JsonProperty("members")]
        public List<MemberByName> members { get; set; } = new List<MemberByName>();
    }
}