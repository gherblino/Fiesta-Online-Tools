using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace CleanFiles.Config
{
    public class Folder
    {
        [JsonProperty("FolderName")]
        public string FolderName;

		//[JsonProperty("AllowedFiles")]
		//public List<string> AllowedFiles { get; set; } = new List<string>();
		[JsonProperty("Data")]
		public Data data;
    }
}
