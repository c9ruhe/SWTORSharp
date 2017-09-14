using Newtonsoft.Json;

namespace SWTORSharp.Core
{


    public partial class CodexEntryList
    {
        [JsonProperty("objects")]
        public CodexEntry[] Objects { get; set; }

        [JsonProperty("items_per_pags")]
        public int ItemsPerPags { get; set; }

        [JsonProperty("current_page")]
        public int CurrentPage { get; set; }

        [JsonProperty("next_page")]
        public string NextPage { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

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

            public static CodexEntryList FromJson(string json) => JsonConvert.DeserializeObject<CodexEntryList>(json, Settings);
            public static string ToJson(CodexEntryList o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }


    public partial class CodexEntry
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("codex_category")]
        public CodexCategory CodexCategory { get; set; }

        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("api_icon")]
        public string ApiIcon { get; set; }

        [JsonProperty("classrestricted")]
        public bool Classrestricted { get; set; }

        [JsonProperty("codex_faction")]
        public CodexFaction CodexFaction { get; set; }

        [JsonProperty("codex_classes")]
        public CodexClass[] CodexClasses { get; set; }

        [JsonProperty("codex_sub_category")]
        public CodexCategory CodexSubCategory { get; set; }

        [JsonProperty("ishidden")]
        public bool Ishidden { get; set; }

        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("linked_codex_count")]
        public int LinkedCodexCount { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }

        [JsonProperty("related_codexes")]
        public RelatedCodex[] RelatedCodexes { get; set; }

        public partial class Convert
        {
            // Serialize/deserialize helpers

            public static CodexEntry FromJson(string json) => JsonConvert.DeserializeObject<CodexEntry>(json, Settings);
            public static string ToJson(CodexEntry o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
    public partial class CodexCategory
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class CodexFaction
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class RelatedCodex
    {
        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("api_icon")]
        public string ApiIcon { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }
    public  class CodexClass
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

}