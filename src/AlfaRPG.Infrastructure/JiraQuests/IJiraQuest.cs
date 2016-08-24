using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlfaRPG.Infrastructure.Characters;

namespace AlfaRPG.Infrastructure.JiraQuests
{
    public interface IJiraQuest
    {
        bool Completed { get; set; }
        double EstimatedCompletionTime { get; set; }
        string JiraName { get; set; }
        double RealTime { get; set; }
        int SprintPoints { get; set; }

        int CompleteQuest();
        int CompleteQuest(IPlayerCharacter humanPlayer);
    }
}
