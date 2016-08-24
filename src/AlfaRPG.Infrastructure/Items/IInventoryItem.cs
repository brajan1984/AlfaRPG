using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaRPG.Infrastructure.Items
{
    public interface IInventoryItem : IItem
    {
        int WeightInKilos { get; set; }
    }
}
