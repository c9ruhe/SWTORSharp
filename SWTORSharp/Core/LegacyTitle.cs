using Newtonsoft.Json;

namespace SWTORSharp.Core
{
    public partial class LegacyTitleList
    {
        [JsonProperty("objects")]
        public LegacyTitle[] Objects { get; set; }

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
    }

    public partial class LegacyTitle
    {
        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }

        [JsonProperty("achievements_count")]
        public int AchievementsCount { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }

    public partial class LegacyTitleList
    {
        public static LegacyTitleList FromJson(string json) => JsonConvert.DeserializeObject<LegacyTitleList>(json, Converter.Settings);
    }
    public partial class LegacyTitle
    {
        public static LegacyTitle FromJson(string json) => JsonConvert.DeserializeObject<LegacyTitle>(json, Converter.Settings);
    }
}