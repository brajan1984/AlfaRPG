using AlfaRPG.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlfaRPG.Infrastructure.JiraQuests;

namespace AlfaRPG.DomainModels.Services
{
    public class ExperienceCalculator : IExperienceCalculator
    {
        public int CalculateExperience(IJiraQuest quest)
        {
            int value = 0;
            double doubleValue = quest.SprintPoints +
                (quest.SprintPoints *
                (quest.EstimatedCompletionTime - quest.RealTime))
                / quest.EstimatedCompletionTime;

            if (!double.IsNaN(doubleValue))
            {
                value = Convert.ToInt32(doubleValue);
            }
            return value;
        }
    }
}
