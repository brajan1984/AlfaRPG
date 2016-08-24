using System.Collections.Generic;
using AlfaRPG.Infrastructure.Items;

namespace AlfaRPG.Infrastructure.Characters
{
    public interface ICharacter
    {
        long Experience { get; set; }
        int HP { get; set; }
        IList<IInventoryItem> Inventory { get; set; }
        int Level { get; set; }
        string Name { get; set; }
        int Strength { get; set; }
    }
}