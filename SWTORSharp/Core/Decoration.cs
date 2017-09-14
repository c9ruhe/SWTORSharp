using Newtonsoft.Json;

namespace SWTORSharp.Core
{
    public class DecorationList
    {
        [JsonProperty("objects")]
        public Decoration[] Objects { get; set; }

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

        public class Convert
        {
            // Serialize/deserialize helpers

            public static DecorationList FromJson(string json) => JsonConvert.DeserializeObject<DecorationList>(json, Settings);
            public static string ToJson(DecorationList o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }

    public class Decoration
    {
        [JsonProperty("decoration_subcategory")]
        public DecorationCategory DecorationSubcategory { get; set; }

        [JsonProperty("decoration_dynamicstate")]
        public DecorationCategory DecorationDynamicstate { get; set; }

        [JsonProperty("available")]
        public bool? Available { get; set; }

        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("decoration_category")]
        public DecorationCategory DecorationCategory { get; set; }

        [JsonProperty("decoration_restricted_faction")]
        public DecorationCategory DecorationRestrictedFaction { get; set; }

        [JsonProperty("decoration_hooks")]
        public DecorationCategory[] DecorationHooks { get; set; }

        [JsonProperty("decoration_sources")]
        public DecorationCategory[] DecorationSources { get; set; }

        [JsonProperty("guild_unlock_limit")]
        public int GuildUnlockLimit { get; set; }

        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("guild_cost")]
        public int GuildCost { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("personal_unlock_limit")]
        public int PersonalUnlockLimit { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }

        public class Convert
        {
            // Serialize/deserialize helpers

            public static Decoration FromJson(string json) => JsonConvert.DeserializeObject<Decoration>(json, Settings);
            public static string ToJson(Decoration o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }

    public class DecorationCategory
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
    public class CraftedWithItemInformation
    {
        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("number_crafted_with_item")]
        public int NumberCraftedWithItem { get; set; }
    }


    public class RewardedFromMissionsInformation
    {
        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("number_of_missions_rewarded_from")]
        public int NumberOfMissionsRewardedFrom { get; set; }
    }

    public class UseAbility
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ignorealacrity")]
        public bool Ignorealacrity { get; set; }

        [JsonProperty("casttime")]
        public int Casttime { get; set; }

        [JsonProperty("api_icon")]
        public string ApiIcon { get; set; }

        [JsonProperty("ammoheatcost")]
        public int Ammoheatcost { get; set; }

        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("channeltime")]
        public int Channeltime { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("cooldown")]
        public int Cooldown { get; set; }

        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }

        [JsonProperty("energycost")]
        public int Energycost { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("forcecost")]
        public int Forcecost { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("globalcooldown")]
        public double Globalcooldown { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("minrange")]
        public int Minrange { get; set; }

        [JsonProperty("target_rule")]
        public DecorationCategory TargetRule { get; set; }

        [JsonProperty("loscheck")]
        public bool Loscheck { get; set; }

        [JsonProperty("items_use_and_equip_information")]
        public ItemsUseAndEquipInformation ItemsUseAndEquipInformation { get; set; }

        [JsonProperty("maxrange")]
        public int Maxrange { get; set; }

        [JsonProperty("passive")]
        public bool Passive { get; set; }

        [JsonProperty("overridegcd")]
        public bool? Overridegcd { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("targetarcoffset")]
        public int Targetarcoffset { get; set; }

        [JsonProperty("targetarc")]
        public int Targetarc { get; set; }

        [JsonProperty("usespushback")]
        public bool Usespushback { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }
}