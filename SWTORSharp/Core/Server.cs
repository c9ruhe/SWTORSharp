using Newtonsoft.Json;

namespace SWTORSharp.Core
{
    public class ServerList
    {
        [JsonProperty("servers")]
        public Server[] Servers { get; set; }

        [JsonProperty("total_servers")]
        public int TotalServers { get; set; }

        public class Convert
        {
            // Serialize/deserialize helpers

            public static ServerList FromJson(string json) => JsonConvert.DeserializeObject<ServerList>(json, Settings);
            public static string ToJson(ServerList o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
    public class Server
    {
        [JsonProperty("light_side_victory_count")]
        public int LightSideVictoryCount { get; set; }

        [JsonProperty("dark_side_victory_count")]
        public int DarkSideVictoryCount { get; set; }

        [JsonProperty("current_side")]
        public string CurrentSide { get; set; }

        [JsonProperty("added_to_queue")]
        public bool AddedToQueue { get; set; }

        [JsonProperty("current_value")]
        public int CurrentValue { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dark_side_victory_count_since_5_01")]
        public int DarkSideVictoryCountSince501 { get; set; }

        [JsonProperty("last_score_update")]
        public string LastScoreUpdate { get; set; }

        [JsonProperty("started_processing")]
        public bool StartedProcessing { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("light_side_victory_count_since_5_01")]
        public int LightSideVictoryCountSince501 { get; set; }

        [JsonProperty("server_history")]
        public object[] ServerHistory { get; set; }

        [JsonProperty("victory_state")]
        public bool VictoryState { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("victory_time")]
        public string VictoryTime { get; set; }

        public class Convert
        {
            // Serialize/deserialize helpers

            public static Server FromJson(string json) => JsonConvert.DeserializeObject<Server>(json, Settings);
            public static string ToJson(Server o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
    public class CxpBonusList
    {
        [JsonProperty("cxp_bonus")]
        public CxpBonus[] CxpBonus { get; set; }

        [JsonProperty("total_cxp_bonus")]
        public int TotalCxpBonus { get; set; }

        public class Convert
        {
            // Serialize/deserialize helpers

            public static CxpBonusList FromJson(string json) => JsonConvert.DeserializeObject<CxpBonusList>(json, Settings);
            public static string ToJson(CxpBonusList o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }

    public class CxpBonus
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("bonus_name")]
        public string BonusName { get; set; }

        [JsonProperty("original_animated_gif")]
        public string OriginalAnimatedGif { get; set; }

        public class Convert
        {
            // Serialize/deserialize helpers

            public static CxpBonus FromJson(string json) => JsonConvert.DeserializeObject<CxpBonus>(json, Settings);
            public static string ToJson(CxpBonus o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }


}