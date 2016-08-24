using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlfaRPG.Infrastructure.JiraQuests;

namespace AlfaRPG.Infrastructure.Characters
{
    public interface IPlayerCharacter : ICharacter
    {
        IList<IJiraQuest> JiraQuests { get; set; }
    }
}
