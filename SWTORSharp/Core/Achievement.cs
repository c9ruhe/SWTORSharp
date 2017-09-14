using Newtonsoft.Json;

namespace SWTORSharp.Core
{
    public partial class AchievementList
    {
        [JsonProperty("objects")]
        public Achievement[] Objects { get; set; }

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
        public object PreviousPage { get; set; }

        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }

    public partial class Achievement
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
        public object Cartelcoins { get; set; }

        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }

        [JsonProperty("nonspoilerdescription")]
        public object Nonspoilerdescription { get; set; }

        [JsonProperty("fleetrequisition")]
        public object Fleetrequisition { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }

    public partial class AchievementList
    {
        public static AchievementList FromJson(string json) => JsonConvert.DeserializeObject<AchievementList>(json, Converter.Settings);
    }

    public partial class Achievement
    {
        public static Achievement FromJson(string json) => JsonConvert.DeserializeObject<Achievement>(json, Converter.Settings);
    }

}