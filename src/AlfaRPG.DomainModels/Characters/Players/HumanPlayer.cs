using AlfaRPG.DomainModels.Characters.Races;
using AlfaRPG.Infrastructure.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlfaRPG.Infrastructure.JiraQuests;

namespace AlfaRPG.DomainModels.Characters.Players
{
    public class HumanPlayer : Human, IPlayerCharacter
    {
        public HumanPlayer()
        {
            JiraQuests = new List<IJiraQuest>();
        }

        public IList<IJiraQuest> JiraQuests { get; set; }
    }
}
