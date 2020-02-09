using System.Collections.Generic;
using Newtonsoft.Json;

namespace CleanFiles.Config
{
    public class Data
    {
        [JsonProperty("Files")]
        public List<string> Files = new List<string>();

        [JsonProperty("Folders")]
        public List<Folder> Folders = new List<Folder>();
    }
}
