using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWTORSharp.Core
{
    public partial class TitleList
    {
        [JsonProperty("objects")]
        public Title[] Objects { get; set; }

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

    public partial class Title
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }

        [JsonProperty("legacyprefix")]
        public bool Legacyprefix { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }
    }



    public partial class TitleList
    {
        public static TitleList FromJson(string json) => JsonConvert.DeserializeObject<TitleList>(json, Converter.Settings);
    }

    public partial class Title
    {
        public static Title FromJson(string json) => JsonConvert.DeserializeObject<Title>(json, Converter.Settings);
    }




}
