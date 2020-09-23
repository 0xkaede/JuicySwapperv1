using Newtonsoft.Json;

namespace Juicy_Swapper_v2.Classes.API
{
    class StatusAPI
    {
        public class Status
        {
            [JsonProperty("isOnline")]
            public bool IsOnline { get; set; }

            [JsonProperty("offlineMessage")]
            public string OfflineMessage { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }

            [JsonProperty("outOfDateMessage")]
            public string OutOfDateMessage { get; set; }

            [JsonProperty("isSkinTabEnabled")]
            public bool SkinTabEnabled { get; set; }

            [JsonProperty("isMiscTabEnabled")]
            public bool MiscTabEnabled { get; set; }
        }
    }
}
