using Newtonsoft.Json;

namespace SWTORSharp.Core
{
    public class CraftingItem
    {
        /// <summary>
        /// Name of the crafting object (If this is making an item instead of a mission, it is the name of the Item)
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        /// <summary>
        /// Name of the required profession
        /// </summary>
        [JsonProperty("profession")]
        public Profession Profession { get; set; }
        /// <summary>
        /// Training cost
        /// </summary>
        [JsonProperty("cost")]
        public int Cost { get; set; }
        /// <summary>
        /// Link to get more inforamtion about the object
        /// </summary>
        [JsonProperty("api_link")]
        public string ApiLink { get; set; }
        /// <summary>
        /// this hash will be an Item object that should be the same as what is returned with this API version
        /// </summary>
        [JsonProperty("crafted_item")]
        public Notes CraftedItem { get; set; }
        /// <summary>
        /// Id of the Crafting Object
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }
        /// <summary>
        /// description of the mission
        /// </summary>
        [JsonProperty("missiondescription")]
        public object Missiondescription { get; set; }
        /// <summary>
        /// See clas summaries.
        /// </summary>
        [JsonProperty("required_materials")]
        public RequiredMaterial[] RequiredMaterials { get; set; }
        /// <summary>
        /// wether this can be unlocked for the player
        /// </summary>
        [JsonProperty("unlockable")]
        public bool Unlockable { get; set; }
        /// <summary>
        /// minimum required profession level
        /// </summary>
        [JsonProperty("professionlevelrequired")]
        public int Professionlevelrequired { get; set; }
        /// <summary>
        /// See clas summaries.
        /// </summary>
        [JsonProperty("skill_range")]
        public SkillRange SkillRange { get; set; }
        /// <summary>
        /// Link to the object for the user
        /// </summary>
        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("yield")]
        public Yield Yield { get; set; }
        public class Convert
        {
            // Serialize/deserialize helpers

            public static CraftingItem FromJson(string json) => JsonConvert.DeserializeObject<CraftingItem>(json, Settings);
            public static string ToJson(CraftingItem o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }

    public class Profession
    {
        /// <summary>
        /// Name of the required profession
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class RequiredMaterial
    {
        /// <summary>
        /// how many of this specific mat it takes to craft the item
        /// </summary>
        [JsonProperty("amountneed")]
        public int Amountneed { get; set; }

        [JsonProperty("item")]
        public Notes Notes { get; set; }
    }

    public class Notes
    {
        [JsonProperty("NOTES")]
        public string Note { get; set; }
    }

    public class SkillRange
    {/// <summary>
     ///  The grey skill range shown in game
     /// </summary>
        [JsonProperty("grey")]
        public int Grey { get; set; }
        /// <summary>
        ///  The green skill range shown in game
        /// </summary>
        [JsonProperty("green")]
        public int Green { get; set; }
        /// <summary>
        /// The orange skill range shown in game
        /// </summary>
        [JsonProperty("orange")]
        public int Orange { get; set; }
        /// <summary>
        /// The yellow skill range shown in game
        /// </summary>
        [JsonProperty("yellow")]
        public int Yellow { get; set; }
    }

    public class Yield
    {
        /// <summary>
        /// The amount of yield as shown in game
        /// </summary>
        [JsonProperty("yield_amount")]
        public string YieldAmount { get; set; }
        /// <summary>
        /// The type of yield as shown in game
        /// </summary>
        [JsonProperty("yield_type")]
        public string YieldType { get; set; }
    }

    public class CraftingList
    {
        /// <summary>
        /// Items requested.
        /// </summary>
        [JsonProperty("objects")]
        public Item[] Objects { get; set; }

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
        public object SortOrder { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        public class Convert
        {
            // Serialize/deserialize helpers

            public static CraftingList FromJson(string json) => JsonConvert.DeserializeObject<CraftingList>(json, Settings);
            public static string ToJson(CraftingList o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }

    }