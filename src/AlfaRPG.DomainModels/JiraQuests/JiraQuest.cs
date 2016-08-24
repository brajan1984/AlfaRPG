using AlfaRPG.Infrastructure.JiraQuests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaRPG.DomainModels.JiraQuests
{
    public class JiraQuest : IJiraQuest
    {
        public string JiraName
        {
            get;set;
        }

        public int SprintPoints
        {
            get;set;
        }
    }
}
