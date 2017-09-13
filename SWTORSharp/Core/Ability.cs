using Newtonsoft.Json;

namespace SWTORSharp.Core
{
    public class Ability
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
        public TargetRule TargetRule { get; set; }

        [JsonProperty("loscheck")]
        public bool Loscheck { get; set; }

        [JsonProperty("items_use_and_equip_information")]
        public ItemsUseAndEquipInformation ItemsUseAndEquipInformation { get; set; }

        [JsonProperty("maxrange")]
        public int Maxrange { get; set; }

        [JsonProperty("passive")]
        public bool Passive { get; set; }

        [JsonProperty("overridegcd")]
        public object Overridegcd { get; set; }

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

        public class Convert
        {
            // Serialize/deserialize helpers

            public static Ability FromJson(string json) => JsonConvert.DeserializeObject<Ability>(json, Settings);
            public static string ToJson(Ability o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
    public class TargetRule
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ItemsUseAndEquipInformation
    {
        [JsonProperty("number_of_items_with_equip")]
        public int NumberOfItemsWithEquip { get; set; }

        [JsonProperty("number_of_items_with_use")]
        public int NumberOfItemsWithUse { get; set; }
    }
    public class AbilityList
    {
        /// <summary>
        /// Abilities requested.
        /// </summary>
        [JsonProperty("objects")]
        public Ability[] Objects { get; set; }

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
        public object PreviousPage { get; set; }

        [JsonProperty("sort_order")]
        public object SortOrder { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
        public class Convert
        {
            // Serialize/deserialize helpers

            public static AbilityList FromJson(string json) => JsonConvert.DeserializeObject<AbilityList>(json, Settings);
            public static string ToJson(AbilityList o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }

}