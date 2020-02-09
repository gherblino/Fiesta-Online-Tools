using Newtonsoft.Json;
using System.Collections.Generic;

namespace CleanFiles.Config
{
    public class Files
    {
        [JsonProperty("AllowedFiles")]
        public List<string> AllowedFiles { get; set; } = new List<string>();
    }
}
