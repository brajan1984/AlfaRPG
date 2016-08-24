using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaRPG.Infrastructure.JiraQuests
{
    public interface IJiraQuest
    {
        string JiraName { get; set; }
        int SprintPoints { get; set; }
    }
}
