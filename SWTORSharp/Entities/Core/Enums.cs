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
}
