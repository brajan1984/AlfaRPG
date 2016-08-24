using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaRPG.Infrastructure.Items
{
    public interface IAttackItem : IItem
    {
        int Attack { get; set; }
    }
}
