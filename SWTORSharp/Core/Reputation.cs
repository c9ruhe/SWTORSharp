using Newtonsoft.Json;

namespace SWTORSharp.Core
{

    public partial class ReputationList
    {
        [JsonProperty("objects")]
        public Reputation[] Objects { get; set; }

        [JsonProperty("items_per_pags")]
        public int ItemsPerPags { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("next_page")]
        public string NextPage { get; set; }

        [JsonProperty("query")]
        public object Query { get; set; }

        [JsonProperty("total_items")]
        public int TotalItems { get; set; }

        [JsonProperty("previous_page")]
        public string PreviousPage { get; set; }

        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        public partial class Convert
        {
            // Serialize/deserialize helpers

            public static ReputationList FromJson(string json) => JsonConvert.DeserializeObject<ReputationList>(json, Settings);
            public static string ToJson(ReputationList o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
    public partial class Reputation
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }

        [JsonProperty("reputation_factionspecifics")]
        public ReputationFactionspecific[] ReputationFactionspecifics { get; set; }

        [JsonProperty("reputation_factionavailability")]
        public ReputationFactionavailability ReputationFactionavailability { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }

        [JsonProperty("weeklyreplimit")]
        public int Weeklyreplimit { get; set; }

        public partial class Convert
        {
            // Serialize/deserialize helpers

            public static Reputation FromJson(string json) => JsonConvert.DeserializeObject<Reputation>(json, Settings);
            public static string ToJson(Reputation o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
    public partial class ReputationFactionspecific
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("api_icon")]
        public string ApiIcon { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("faction")]
        public string Faction { get; set; }
    }

    public partial class ReputationFactionavailability
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }


}