using Newtonsoft.Json;

namespace SWTORSharp.Core
{
    public partial class CollectionList
    {
        [JsonProperty("objects")]
        public Collection[] Objects { get; set; }

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

    public partial class Collection
    {
        [JsonProperty("api_icon")]
        public string ApiIcon { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("achievement_sub_category")]
        public AchievementCategory AchievementSubCategory { get; set; }

        [JsonProperty("achievement_category")]
        public AchievementCategory AchievementCategory { get; set; }

        [JsonProperty("achievementpoints")]
        public int Achievementpoints { get; set; }

        [JsonProperty("cartelcoins")]
        public int Cartelcoins { get; set; }

        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }

        [JsonProperty("nonspoilerdescription")]
        public string Nonspoilerdescription { get; set; }

        [JsonProperty("fleetrequisition")]
        public string Fleetrequisition { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }

    public partial class AchievementCategory
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class CollectionList
    {
        public static CollectionList FromJson(string json) => JsonConvert.DeserializeObject<CollectionList>(json, Converter.Settings);
    }

    public partial class Collection
    {
        public static Collection FromJson(string json) => JsonConvert.DeserializeObject<Collection>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this CollectionList self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public partial class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
