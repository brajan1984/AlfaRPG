using AlfaRPG.Infrastructure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaRPG.DomainModels.Items.Weapons
{
    public class Club : IInventoryItem, IAttackItem
    {
        public int Attack
        {
            get;set;
        }

        public string Name
        {
            get;set;
        }

        public int WeightInKilos
        {
            get;set;
        }
    }
}
