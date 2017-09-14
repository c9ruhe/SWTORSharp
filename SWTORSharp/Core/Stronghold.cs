using Newtonsoft.Json;

namespace SWTORSharp.Core
{
    public partial class StrongholdList
    {
        [JsonProperty("objects")]
        public Stronghold[] Objects { get; set; }

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

    public partial class Stronghold
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("defaultguildoccupancy")]
        public int Defaultguildoccupancy { get; set; }

        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("api_icon")]
        public string ApiIcon { get; set; }

        [JsonProperty("api_publicicon")]
        public string ApiPublicicon { get; set; }

        [JsonProperty("defaultoccupancy")]
        public int Defaultoccupancy { get; set; }

        [JsonProperty("defaulthooks")]
        public int Defaulthooks { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("maxhooks")]
        public int Maxhooks { get; set; }

        [JsonProperty("guildcost")]
        public int Guildcost { get; set; }

        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stronghold_factionpurchaserestriction")]
        public StrongholdInfo StrongholdFactionpurchaserestriction { get; set; }

        [JsonProperty("stronghold_type")]
        public StrongholdInfo StrongholdType { get; set; }

        [JsonProperty("playercost")]
        public int Playercost { get; set; }

        [JsonProperty("stronghold_rooms")]
        public StrongholdRoom[] StrongholdRooms { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }

    public partial class StrongholdInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class StrongholdRoom
    {
        [JsonProperty("guilddecorationincrease")]
        public int Guilddecorationincrease { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("biowareid")]
        public int Biowareid { get; set; }

        [JsonProperty("guildcost")]
        public int Guildcost { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playerdecorationincrease")]
        public int Playerdecorationincrease { get; set; }

        [JsonProperty("guildoccupacyincrease")]
        public int Guildoccupacyincrease { get; set; }

        [JsonProperty("playercost")]
        public int Playercost { get; set; }

        [JsonProperty("playeroccupancyincrease")]
        public int Playeroccupancyincrease { get; set; }
    }


    public partial class StrongholdList
    {
        public static StrongholdList FromJson(string json) => JsonConvert.DeserializeObject<StrongholdList>(json, Converter.Settings);
    }

    public partial class Stronghold
    {
        public static Stronghold FromJson(string json) => JsonConvert.DeserializeObject<Stronghold>(json, Converter.Settings);
    }

}