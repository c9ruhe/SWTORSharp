using System;
using System.Net;
using System.Collections.Generic;

using Newtonsoft.Json;


namespace SWTORSharp.Core
{

    public class Item
    {
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("enhancements")]
        public Enhancement[] Enhancements { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("combined_stats")]
        public Stat[] CombinedStats { get; set; }
        /// <summary>
        /// The name of the armor spec
        /// </summary>
        [JsonProperty("armor_spec")]
        public string ArmorSpec { get; set; }
        /// <summary>
        /// Link to just get information about a specific item with the API
        /// </summary>
        [JsonProperty("api_link")]
        public string ApiLink { get; set; }
        /// <summary>
        /// Link to the icon for the item
        /// </summary>
        [JsonProperty("api_icon")]
        public string ApiIcon { get; set; }
        /// <summary>
        /// Armor rating.
        /// </summary>
        [JsonProperty("armor_rating")]
        public int ArmorRating { get; set; }
        /// <summary>
        ///  How the item binds to the character (like 'OnEquip')
        /// </summary>
        [JsonProperty("binding")]
        public string Binding { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("base_stats")]
        public Stat[] BaseStats { get; set; }
        /// <summary>
        /// Category of the item
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }
        /// <summary>
        /// Flavor text generally at the bottom of the tooltip for an item
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("craftable_with_item")]
        public CraftableWithItem[] CraftableWithItem { get; set; }
        /// <summary>
        ///  If the item is consumed on use
        /// </summary>
        [JsonProperty("consumed_on_use")]
        public bool ConsumedOnUse { get; set; }
        /// <summary>
        /// Profession that can craft this item
        /// </summary>
        [JsonProperty("crafted_by")]
        public object[] CraftedBy { get; set; }

        /// <summary>
        ///  Name of the Item - in English
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        /// <summary>
        /// Name of the profession that can disassemble the item
        /// </summary>
        [JsonProperty("disassemble")]
        public string Disassemble { get; set; }
        /// <summary>
        /// If the item is an enhancement (mod) the name of its type
        /// </summary>
        [JsonProperty("enhancement_type")]
        public string EnhancementType { get; set; }

        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("item_slots")]
        public ItemEnhancementType[] ItemSlots { get; set; }
        /// <summary>
        /// The level of a specific profession (defined under 'required_profession') the item requires to be used
        /// </summary>
        [JsonProperty("required_profession_level")]
        public string RequiredProfessionLevel { get; set; }
        /// <summary>
        /// Rank of a companion gift
        /// </summary>
        [JsonProperty("giftrank")]
        public string Giftrank { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("equip_ability")]
        public EquipAbility EquipAbility { get; set; }
        /// <summary>
        /// The name of the type of companion gift
        /// </summary>
        [JsonProperty("gift_type")]
        public string GiftType { get; set; }
        /// <summary>
        /// The voice modulation applied to Imperial characters
        /// </summary>
        [JsonProperty("imp_voice_modulation")]
        public string ImpVoiceModulation { get; set; }

        /// <summary>
        /// The ID of the item
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// Calculated level of the item
        /// </summary>
        [JsonProperty("item_level")]
        public int ItemLevel { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("quality")]
        public Quality Quality { get; set; }
        /// <summary>
        /// Level required to use the item
        /// </summary>
        [JsonProperty("minimum_level")]
        public string MinimumLevel { get; set; }
        /// <summary>
        /// Maxinum size the stack can be (nil or 0 means the item cannot stack)
        /// </summary>
        [JsonProperty("max_durability")]
        public string MaxDurability { get; set; }

        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("model_information")]
        public ModelInformation ModelInformation { get; set; }
        /// <summary>
        /// Gender the item requires
        /// </summary>
        [JsonProperty("required_gender")]
        public string RequiredGender { get; set; }
        /// <summary>
        /// The voice modulation applied to Republic characters
        /// </summary>
        [JsonProperty("rep_voice_modulation")]
        public string RepVoiceModulation { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("required_profession")]
        public ItemEnhancementType RequiredProfession { get; set; }
        /// <summary>
        /// Maxinum size the stack can be (nil or 0 means the item cannot stack)
        /// </summary>
        [JsonProperty("stack_count")]
        public string StackCount { get; set; }
        /// <summary>
        /// Wether the item requires a certain social score
        /// </summary>
        [JsonProperty("social_score_required")]
        public bool SocialScoreRequired { get; set; }
        /// <summary>
        /// The minimum valor rank the item requires
        /// </summary>
        [JsonProperty("required_valor_rank")]
        public int RequiredValorRank { get; set; }
        /// <summary>
        ///  The minumum social score rank it requires"
        /// </summary>
        [JsonProperty("social_score_required_rank")]
        public int SocialScoreRequiredRank { get; set; }
        /// <summary>
        /// total number of this item you can have (0 means it does not count)
        /// </summary>
        [JsonProperty("unique_limit")]
        public int UniqueLimit { get; set; }
        /// <summary>
        ///  Vendor sell price
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
        /// <summary>
        /// Subcategory of the item.
        /// </summary>
        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("use_ability")]
        public EquipAbility UseAbility { get; set; }
        /// <summary>
        /// Link to the item on the normal website, useful for giving links to your users
        /// </summary>
        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
        public class Convert
        {
            // Serialize/deserialize helpers

            public static Item FromJson(string json) => JsonConvert.DeserializeObject<Item>(json, Settings);
            public static string ToJson(Item o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }

    }

    public class Enhancement
    {
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("enhancement")]
        public OtherEnhancement OtherEnhancement { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("item_enhancement_type")]
        public ItemEnhancementType ItemEnhancementType { get; set; }
    }

    public class OtherEnhancement
    {
        /// <summary>
        /// Display name.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        /// <summary>
        /// Link to the item in the API to get more information about the item
        /// </summary>
        [JsonProperty("api_link")]
        public string ApiLink { get; set; }
        /// <summary>
        /// Link to the icon for the item
        /// </summary>
        [JsonProperty("api_icon")]
        public string ApiIcon { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("base_stats")]
        public Stat[] BaseStats { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("quality")]
        public Quality Quality { get; set; }
        /// <summary>
        /// If the item has an empty enhancement spot, the 'enhancement' key will not be there. Like in the example above.
        /// </summary>
        [JsonProperty("important_note_on_enhancements")]
        public string ImportantNoteOnEnhancements { get; set; }
        /// <summary>
        /// Link to the item on the website
        /// </summary>
        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }

    public class Stat
    {
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("item_stat")]
        public ItemStat ItemStat { get; set; }
    }

    public class ItemStat
    {
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("item_stat_type")]
        public ItemStatType ItemStatType { get; set; }
        /// <summary>
        /// The amount of the stat the item has with the default mods applied.
        /// </summary>
        [JsonProperty("stat_amount")]
        public int StatAmount { get; set; }
    }

    public class ItemStatType
    {
        /// <summary>
        /// The name of the stat the player sees
        /// </summary>
        [JsonProperty("display_text")]
        public string DisplayText { get; set; }
        /// <summary>
        /// The name of the stat in the files
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CraftableWithItem
    {
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("crafting")]
        public Crafting Crafting { get; set; }
    }

    public class Crafting
    {
        /// <summary>
        /// Name of the crafting schematic (almost guaranteed to be the name of the crafted item)
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        /// <summary>
        /// See class summaries.
        /// </summary>
        [JsonProperty("item")]
        public Item2 Item { get; set; }
        /// <summary>
        ///  API Link to get more information about the crafting schematic
        /// </summary>
        [JsonProperty("api_link")]
        public string ApiLink { get; set; }
        /// <summary>
        /// ID of the crafting schematic
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }
        /// <summary>
        /// User link for the schematic
        /// </summary>
        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }

    public class Item2
    {
        /// <summary>
        /// API link to get more information about the crafted item
        /// </summary>
        [JsonProperty("api_link")]
        public string ApiLink { get; set; }
        /// <summary>
        /// name of the crafted item
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        /// <summary>
        /// Icon for the crafted item. Use this if you want to show an icon next to the schemati
        /// </summary>
        [JsonProperty("api_icon")]
        public string ApiIcon { get; set; }
        /// <summary>
        /// description of the crafted item
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// Id of the crafted item
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// User link for the crafted item.
        /// </summary>
        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }

    public class ItemEnhancementType
    {/// <summary>
     /// Name of the type of enhancement (the slot used)
     /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetTooltip
    {/// <summary>
     /// Javascript that should be on the 'onmouseout' event for any SWTORData links
     /// </summary>
        [JsonProperty("onmouseout")]
        public string Onmouseout { get; set; }
        [JsonProperty("about_the_get_tooltip_hash")]
        public string AboutTheGetTooltipHash { get; set; } = "This hash is a little different from other information in the APi. First it requires that the SWTORData tooltip code is on the page. This hash is for when you are using javascript to load in links after the page has loaded. The current form of the tooltip code only looks for SWTORData links on page load, this hash is to address that issue for anyone using the API";
        /// <summary>
        /// Javascript that should be on the 'onmouseover' event for any SWTORData links
        /// </summary>
        [JsonProperty("onmouseover")]
        public string Onmouseover { get; set; }
    }

    public class EquipAbility
    {/// <summary>
     /// Link to the ability in the API to get more information about the ability
     /// </summary>
        [JsonProperty("api_link")]
        public string ApiLink { get; set; }
        /// <summary>
        /// Name of the use ability on the item (in game the name is not shown) 
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
        /// <summary>
        /// Link to the icon for the ability
        /// </summary>
        [JsonProperty("api_icon")]
        public string ApiIcon { get; set; }
        /// <summary>
        ///  Description of the use ability on the item (in game this is what is shown in the tooltip)
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// Link to the ability on the website
        /// </summary>
        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }

    public class Quality
    {
        /// <summary>
        /// the hex code for the dark background color for the quality
        /// </summary>
        [JsonProperty("darkdisplaycolor_hex")]
        public string DarkdisplaycolorHex { get; set; }
        /// <summary>
        /// the hex code for the light background color for the quality
        /// </summary>
        [JsonProperty("lightdisplaycolor_hex")]
        public string LightdisplaycolorHex { get; set; }
        /// <summary>
        /// the name of a dark background color for the quality
        /// </summary>
        [JsonProperty("darkdisplaycolor")]
        public string Darkdisplaycolor { get; set; }
        /// <summary>
        /// the name of a light background color for the quality
        /// </summary>
        [JsonProperty("lightdisplaycolor")]
        public string Lightdisplaycolor { get; set; }
        /// <summary>
        ///  the name of the quality in game
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ModelInformation
    {
        /// <summary>
        /// The ID of the Model Information record, used with the 'item_model' API Endpoint
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// Link to the 'item_model' API endpoint with the ID
        /// </summary>
        [JsonProperty("api_link")]
        public string ApiLink { get; set; }
        /// <summary>
        /// Name of the Model file name (doubt you will need to use this value)
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Number of items with the same model (if the item has a model, greater than 1 means other items have this model)
        /// </summary>
        [JsonProperty("number_of_items_with_model")]
        public string NumberOfItemsWithModel { get; set; }
    }
    public class ItemList
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

            public static ItemList FromJson(string json) => JsonConvert.DeserializeObject<ItemList>(json, Settings);
            public static string ToJson(ItemList o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
    public class ItemList2
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("items_with_model")]
        public Item[] ItemsWithModel { get; set; }

        [JsonProperty("number_of_items_with_model")]
        public int NumberOfItemsWithModel { get; set; }
        public class Convert
        {
            // Serialize/deserialize helpers

            public static ItemList2 FromJson(string json) => JsonConvert.DeserializeObject<ItemList2>(json, Settings);
            public static string ToJson(ItemList2 o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
}
