using Newtonsoft.Json;

namespace SWTORSharp.Core
{
    public class Mission
    {
        [JsonProperty("difficulty")]
        public string Difficulty { get; set; }

        [JsonProperty("branches")]
        public Branch[] Branches { get; set; }

        [JsonProperty("api_link")]
        public string ApiLink { get; set; }

        [JsonProperty("api_icon")]
        public string ApiIcon { get; set; }

        [JsonProperty("bonusquest")]
        public bool Bonusquest { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("canabandon")]
        public bool Canabandon { get; set; }

        [JsonProperty("classquest")]
        public bool Classquest { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("requiredlevel")]
        public int Requiredlevel { get; set; }

        [JsonProperty("get_tooltip")]
        public GetTooltip GetTooltip { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("repeatable")]
        public bool Repeatable { get; set; }

        [JsonProperty("mission_classes")]
        public MissionClass[] MissionClasses { get; set; }

        [JsonProperty("required_privacy")]
        public string RequiredPrivacy { get; set; }

        [JsonProperty("sharebonus")]
        public bool Sharebonus { get; set; }

        [JsonProperty("rewards")]
        public Rewards Rewards { get; set; }

        [JsonProperty("website_link")]
        public string WebsiteLink { get; set; }

        [JsonProperty("xplevel")]
        public int Xplevel { get; set; }

        public class Convert
        {
            // Serialize/deserialize helpers

            public static Mission FromJson(string json) => JsonConvert.DeserializeObject<Mission>(json, Settings);
            public static string ToJson(Mission o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
    public class MissionList
    {
        [JsonProperty("objects")]
        public Mission[] Objects { get; set; }

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
        public int PreviousPage { get; set; }

        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        public class Convert
        {
            // Serialize/deserialize helpers

            public static MissionList FromJson(string json) => JsonConvert.DeserializeObject<MissionList>(json, Settings);
            public static string ToJson(MissionList o) => JsonConvert.SerializeObject(o, Settings);

            // JsonConverter stuff

            static JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
            };
        }
    }
    public class Branch
    {
        /// <summary>
        /// Note: At this time missions do not include mission steps
        /// </summary>
        [JsonProperty("branch_steps")]
        public BranchStep[] BranchSteps { get; set; }

        [JsonProperty("foundid")]
        public int Foundid { get; set; }
    }

    public class BranchStep
    {
        [JsonProperty("sharable")]
        public object Sharable { get; set; }

        [JsonProperty("is_sharable")]
        public bool IsSharable { get; set; }

        [JsonProperty("foundid")]
        public int Foundid { get; set; }

        [JsonProperty("journaltext")]
        public string Journaltext { get; set; }

        [JsonProperty("taskcount")]
        public object Taskcount { get; set; }

        [JsonProperty("step_tasks")]
        public StepTask[] StepTasks { get; set; }

        [JsonProperty("tasktext")]
        public object Tasktext { get; set; }
    }

    public class StepTask
    {
        [JsonProperty("foundid")]
        public int Foundid { get; set; }

        [JsonProperty("show_count")]
        public bool ShowCount { get; set; }

        [JsonProperty("bonus_missions_with_task")]
        public object[] BonusMissionsWithTask { get; set; }

        [JsonProperty("needed_count")]
        public int NeededCount { get; set; }

        [JsonProperty("show_tracking")]
        public bool ShowTracking { get; set; }

        [JsonProperty("task_description")]
        public string TaskDescription { get; set; }
    }
    public class MissionClass
    {
        [JsonProperty("class_icon")]
        public string ClassIcon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Rewards
    {
        [JsonProperty("base_rewards")]
        public object[] BaseRewards { get; set; }

        [JsonProperty("choose_one")]
        public object[] ChooseOne { get; set; }
    }


}