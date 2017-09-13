using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWTORSharp.Core
{
    public enum SortOrder
    {
        display_name_asc,
        display_name_desc,
        id_asc,
        id_desc,
        value_asc,
        value_desc,
        minimum_level_asc,
        minimum_level_desc
    }
    public enum ItemBind
    {
        Pickup,
        Null,
        None,
        Legacy,
        Equip,
        Use,
        OnEquip,
        OnPickup,
        OnLegacy,
        OnUse,
        Never
    }
    public enum ItemQuality
    {
        Null,
        Currency,
        Artifact,
        Standard,
        Prototype,
        Cheap,
        Premium,
        Legendary,
        Quest,
        Legacy,
        Custom
    }
    public enum CraftingProfession
    {
        Armstech,
        Synthweaving,
        Cybertech,
        Armormech,
        Biochem,
        Artifice,
        Archaeology,
        Investigation,
        UnderworldTrading,
        Diplomacy,
        Bioanalysis,
        Scavenging,
        Slicing,
        TreasureHunting,
        Research,
        Any
    }
    public enum TargetRules
    {
        Any,
        Self,
        Companion,
        Attackable,
        GroundSelf,
        Friendly, 
        Ground,
        FriendlyDead,
        PBAoE,
        Grouped,
        SelfDead,
        SelfStunned,
        LootHopper,
        SelfDeadorAlive,
        Vendor,
        Vehicle,
        VehicleOwner,
        CoverObject,
        CoverObjectLeft,
        CoverObjectRight
    }
    public enum History
    {
        all,
        none
    }
}
