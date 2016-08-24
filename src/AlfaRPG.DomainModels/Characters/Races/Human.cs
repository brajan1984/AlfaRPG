using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlfaRPG.Infrastructure.Characters;
using AlfaRPG.Infrastructure.Items;

namespace AlfaRPG.DomainModels.Characters.Races
{
    public class Human: ICharacter
    {
        public long Experience { get; set; }

        public int HP
        {
            get;set;
        }

        public IList<IInventoryItem> Inventory
        {
            get;set;
        }

        public int Level
        {
            get;set;
        }

        public string Name
        {
            get;set;
        }

        public int Strength
        {
            get;set;
        }
    }
}
