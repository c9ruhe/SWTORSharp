using Newtonsoft.Json;

namespace SWTORSharp.Core
{
    public class Npc
    {
        public class Convert
        {
            // Serialize/deserialize helpers

            public static Npc FromJson(string json) => JsonConvert.DeserializeObject<Npc>(json, Settings);
            public static string ToJson(Npc o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("npc_class")]
        public NpcClass NpcClass { get; set; }

        [JsonProperty("display_name")]
        public object DisplayName { get; set; }

        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }

        [JsonProperty("minimum_level")]
        public int MinimumLevel { get; set; }

        [JsonProperty("maximum_level")]
        public int MaximumLevel { get; set; }

        [JsonProperty("npc_category")]
        public OtherNpc NpcCategory { get; set; }

        [JsonProperty("npc_faction")]
        public OtherOtherNpc NpcFaction { get; set; }

        [JsonProperty("npc_toughness")]
        public OtherOtherNpc NpcToughness { get; set; }

        [JsonProperty("npc_difficultyflag")]
        public OtherNpc NpcDifficultyflag { get; set; }

        [JsonProperty("npc_sub_category")]
        public OtherNpc NpcSubCategory { get; set; }

        [JsonProperty("npc_vendor_packages")]
        public object[] NpcVendorPackages { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }
    public class NpcList
    {
        [JsonProperty("objects")]
        public Npc[] Objects { get; set; }

        [JsonProperty("items_per_pags")]
        public long ItemsPerPags { get; set; }

        [JsonProperty("current_page")]
        public long CurrentPage { get; set; }

        [JsonProperty("next_page")]
        public string NextPage { get; set; }

        [JsonProperty("query")]
        public object Query { get; set; }

        [JsonProperty("total_items")]
        public long TotalItems { get; set; }

        [JsonProperty("previous_page")]
        public object PreviousPage { get; set; }

        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        public class Convert
        {
            // Serialize/deserialize helpers

            public static NpcList FromJson(string json) => JsonConvert.DeserializeObject<NpcList>(json, Settings);
            public static string ToJson(NpcList o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
    public class NpcClass
    {
        [JsonProperty("alignmentdark")]
        public int Alignmentdark { get; set; }

        [JsonProperty("npc_abilitypackage")]
        public NpcAbilitypackage NpcAbilitypackage { get; set; }

        [JsonProperty("alighmentlight")]
        public int Alighmentlight { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playerclass")]
        public bool Playerclass { get; set; }
    }

    public class NpcAbilitypackage
    {
        [JsonProperty("abilities")]
        public NpcAbility[] Abilities { get; set; }
    }
    public class NpcAbility
    {
        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("api_icon")]
        public string ApiIcon { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }
    public class OtherNpc
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OtherOtherNpc
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    }

}