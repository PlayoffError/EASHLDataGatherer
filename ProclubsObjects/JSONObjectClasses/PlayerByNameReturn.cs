using Newtonsoft.Json;

namespace ProclubsObjects
{
    public class PlayerByNameReturn
    {
        [JsonProperty("members")]
        public List<MemberByName> Members { get; set; } = new List<MemberByName>();
    }
}