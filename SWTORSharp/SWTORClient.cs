using RestSharp;
using Newtonsoft.Json;


namespace SWTORSharp.Core
{
    public class SWTORClient
    {
        private static string ApiKey { get; set; }
        public SWTORClient(string apikey)
        {
            ApiKey = apikey;
        }
        #region Data
                private readonly RestClient client = new RestClient("http://swtordata.com/api/v2_2/");
                    /// <summary>
                    /// Get Item by it's ID. | List: http://swtordata.com/items
                    /// </summary>
                    /// <param name="id">The Id to search.</param>
                    /// <returns></returns>
                    public Item GetItemById(int id)
                    {
                        var request = new RestRequest($"items/{id}");
                        request.AddHeader("X-API-KEY", ApiKey);
                        var response = client.Execute(request);
                        var item = Item.Convert.FromJson(response.Content);
                        return item;
                    }
                    /// <summary>
                    /// Gives a paginated list of items. Each item will include basic information about the item with a link to the json to get more information
                    /// </summary>
                    /// <param name="page">Page number. Defaults to 1</param>
                    /// <param name="perpage">Items Per Page. Max 50, 20 if <paramref name="Moredetailed"/> is true.</param>
                    /// <param name="itembind">Filter. No value sent will return objects with any binding	</param>
                    /// <param name="order">Filter. Will Default to: 'display_name asc'</param>
                    /// <param name="quality">Filter.</param>
                    /// <param name="MinmumLevelGreaterThan"></param>
                    /// <param name="MaximumLevelLessThan"></param>
                    /// <param name="Moredetailed">By default index will not return the stats or mods. To include the stats and mods in index, set this paramater to 'true'. Due to the amount of data being returned, the maximum items per page is lowered to 20</param>
                    /// <param name="query">Search Items.</param>
                    /// <returns></returns>
                    public ItemList GetItems(int page = 1, int perpage = 20, ItemBind itembind = ItemBind.Null, SortOrder order = SortOrder.display_name_asc, ItemQuality quality = ItemQuality.Null, int MinmumLevelGreaterThan = 1, int MaximumLevelLessThan = 0, bool Moredetailed = true, string query = null)
                    {
                        var request = new RestRequest($"items");
                        request.AddParameter("page", page);
                        request.AddParameter("perpage", perpage);
                        if (query != null)
                            request.AddQueryParameter("query", query);
                        request.AddQueryParameter("sortorder", order.ToString());
                        if (itembind != ItemBind.Null)
                            request.AddQueryParameter("item_bind", itembind.ToString());
                        if (quality != ItemQuality.Null)
                            request.AddQueryParameter("item_quality", quality.ToString());
                        request.AddQueryParameter("moredetailed", Moredetailed.ToString());
                        request.AddParameter("minimum_level_gte", MinmumLevelGreaterThan);
                        if (MaximumLevelLessThan != 0)
                            request.AddParameter("minimum_level_lt", MaximumLevelLessThan);
                        request.AddHeader("X-API-KEY", ApiKey);
                        var response = client.Execute(request);
                        var item = ItemList.Convert.FromJson(response.Content);
                        return item;
                    }
                    /// <summary>
                    ///  With a Model ID, find items with the same mode
                    /// </summary>
                    /// <param name="id">ID to use.</param>
                    /// <returns></returns>
                    public ItemList2 GetItemsWithModelId(int id)
                    {
                        var request = new RestRequest($"item_models/{id}");
                        request.AddHeader("X-API-KEY", ApiKey);
                        var response = client.Execute(request);
                        var item = ItemList2.Convert.FromJson(response.Content);
                        return item;
                    }
                    public CraftingItem GetCraftingsById(int id)
                    {
                        var request = new RestRequest($"craftings/{id}");
                        request.AddHeader("X-API-KEY", ApiKey);
                        var response = client.Execute(request);
                        var ci = CraftingItem.Convert.FromJson(response.Content);
                        return ci;
                    }
                    public CraftingList GetCraftings(int page = 1, int perpage = 50, SortOrder order = SortOrder.display_name_asc, CraftingProfession profession = CraftingProfession.Any, string query = null)
                    {
                        var rq = new RestRequest($"craftings");
                        rq.AddParameter("page", page);
                        rq.AddParameter("perpage", perpage);
                        if (query!=null)
                            rq.AddQueryParameter("query", query);
                        if (order == SortOrder.id_asc || order == SortOrder.id_desc || order == SortOrder.display_name_asc || order == SortOrder.display_name_desc)
                            rq.AddQueryParameter("sortorder", $"{order.ToString()}");
                        if (profession != CraftingProfession.Any)
                            rq.AddQueryParameter("crafting_profession", $"{profession.ToString()}");
                        rq.AddHeader("X-API-KEY", ApiKey);
                        var response = client.Execute(rq);
                        var ci = CraftingList.Convert.FromJson(response.Content);
                        return ci;
                    }
                    public Ability GetAbilityById(int id)
                    {
                        var request = new RestRequest($"abilities/{id}");
                        request.AddHeader("X-API-KEY", ApiKey);
                        var response = client.Execute(request);
                        var ab = Ability.Convert.FromJson(response.Content);
                        return ab;
                    }
                    public AbilityList GetAbilities(int page = 1, int perpage = 50, SortOrder order = SortOrder.display_name_asc, TargetRules rule = TargetRules.Any, int MinRange = 1,
                        int MaxRange = 0, int MinCooldown = 1, int MaxCooldown = 0,string query = null)
                    {
                        var request = new RestRequest($"abilities");
                        request.AddQueryParameter("page", $"{page}");
                        request.AddQueryParameter("perpage", $"{perpage}");
                        if (query != null)
                            request.AddParameter("query", query);
                        if (order == SortOrder.id_asc || order == SortOrder.id_desc || order == SortOrder.display_name_asc || order == SortOrder.display_name_desc)
                            request.AddQueryParameter("sortorder", $"{order.ToString()}");
                        request.AddQueryParameter("targetrule", rule.ToString());
                        request.AddQueryParameter("range_min", $"{MinRange}");
                        if (MaxRange != 0)
                            request.AddQueryParameter("range_max", $"{MaxRange}");
                        request.AddQueryParameter("cooldown_min", $"{MinCooldown}");
                        if (MaxCooldown != 0)
                            request.AddQueryParameter("cooldown_max", $"{MaxCooldown}");
                    request.AddHeader("X-Api-Key", ApiKey);
                        var response = client.Execute(request);
                        var ab = AbilityList.Convert.FromJson(response.Content);
                        return ab;
                    }
                    public Mission GetMissionById(int id)
                    {
                        var request = new RestRequest($"missions/{id}");
                        request.AddHeader("X-Api-Key", ApiKey);
                    var response = client.Execute(request);
                    return Mission.Convert.FromJson(response.Content);
                    }
                    public MissionList GetMissions(int page = 1, int perpage = 30, SortOrder order = SortOrder.display_name_asc, string query = null)
                {
                    var request = new RestRequest($"missions");
                    request.AddQueryParameter("page", $"{page}");
                    request.AddQueryParameter("perpage", $"{perpage}");
                    if (query != null)
                        request.AddParameter("query", query);
                    if (order == SortOrder.id_asc || order == SortOrder.id_desc || order == SortOrder.display_name_asc || order == SortOrder.display_name_desc)
                        request.AddQueryParameter("sortorder", $"{order.ToString()}");
                    request.AddHeader("X-Api-Key", ApiKey);
                    var response = client.Execute(request);
                    return MissionList.Convert.FromJson(response.Content);
                }
                    public Npc GetNpcById(int id)
                    {
                        var request = new RestRequest($"npcs/{id}");
                    request.AddHeader("X-Api-Key", ApiKey);
                    var response = client.Execute(request);
                    return Npc.Convert.FromJson(response.Content);
                    }
                public NpcList GetNpcs(int page =1, int perpage = 20, SortOrder order = SortOrder.display_name_asc, bool moredetailed = false, string query = null)
                {
                    var request = new RestRequest($"npcs");
                    request.AddQueryParameter("page", $"{page}");
                    request.AddQueryParameter("perpage", $"{perpage}");
                    if (query != null)
                        request.AddParameter("query", query);
                    if (order == SortOrder.id_asc || order == SortOrder.id_desc || order == SortOrder.display_name_asc || order == SortOrder.display_name_desc)
                        request.AddQueryParameter("sortorder", $"{order.ToString()}");
                    request.AddHeader("X-Api-Key", ApiKey);
                    var response = client.Execute(request);
                    return NpcList.Convert.FromJson(response.Content);
                }
                #endregion
        #region DVL
        private readonly RestClient client2 = new RestClient("http://swtordata.com/api/dvl/v1/");

        public CxpBonus GetCurrentCxpBonus()
            {
                var request = new RestRequest("cxp_bonus_current");
                request.AddHeader("X-Api-Key", ApiKey);
                var response = client2.Execute(request);
                return CxpBonus.Convert.FromJson(response.Content);
            }
        /// <summary>
        /// Returns all of the CXP bonus so far for the current month
        /// </summary>
        /// <returns></returns>
        public CxpBonusList GetCxpBonusList()
            {
                var request = new RestRequest("cxp_bonus");
                request.AddHeader("X-Api-Key", ApiKey);
                var response = client2.Execute(request);
                return CxpBonusList.Convert.FromJson(response.Content);
            }
            public ServerList GetServers(History history = History.none)
            {
                var request = new RestRequest("servers");
            request.AddQueryParameter("history", history.ToString());

            request.AddHeader("X-Api-Key", ApiKey);
                var response = client2.Execute(request);
                return ServerList.Convert.FromJson(response.Content);
            }
            public Server GetServer(int id, History history = History.none)
            {
                var request = new RestRequest($"servers/{id}");
            request.AddQueryParameter("history", history.ToString());

            request.AddHeader("X-Api-Key", ApiKey);
                var response = client2.Execute(request);
                return Server.Convert.FromJson(response.Content);
            }
        #endregion
    }
}
