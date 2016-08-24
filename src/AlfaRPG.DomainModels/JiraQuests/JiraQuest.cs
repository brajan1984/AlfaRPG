using AlfaRPG.Infrastructure.JiraQuests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlfaRPG.Infrastructure.Services;
using AlfaRPG.Infrastructure.Characters;

namespace AlfaRPG.DomainModels.JiraQuests
{
    public class JiraQuest : IJiraQuest
    {
        private IExperienceCalculator _expCalculator;

        public JiraQuest(IExperienceCalculator expCalculator)
        {
            _expCalculator = expCalculator;
        }

        public JiraQuest()
        {
            _expCalculator = null;
        }

        public double EstimatedCompletionTime
        {
            get;set;
        }

        public string JiraName
        {
            get;set;
        }

        public double RealTime
        {
            get;set;
        }

        public int SprintPoints
        {
            get;set;
        }

        public bool Completed
        {
            get;set;
        }

        public int CompleteQuest()
        {
            return _expCalculator.CalculateExperience(this);
        }

        public int CompleteQuest(IPlayerCharacter humanPlayer)
        {
            int expToAdd = _expCalculator.CalculateExperience(this);
            humanPlayer.Experience += expToAdd;
            return expToAdd;
        }
    }
}
