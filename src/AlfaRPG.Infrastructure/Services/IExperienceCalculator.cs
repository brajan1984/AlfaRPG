using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlfaRPG.Infrastructure.JiraQuests;

namespace AlfaRPG.Infrastructure.Services
{
    public interface IExperienceCalculator
    {
        int CalculateExperience(IJiraQuest quest);
    }
}
