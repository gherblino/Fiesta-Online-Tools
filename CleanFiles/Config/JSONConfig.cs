using Newtonsoft.Json;

namespace CleanFiles.Config
{
    public class JSONConfig
    {
        [JsonProperty("Client")]
        public Data ClientSettings = new Data();

        [JsonProperty("Server")]
        public Data ServerSettings = new Data();
    }
}
