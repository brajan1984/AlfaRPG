using AlfaRPG.DomainModels.Characters.Players;
using AlfaRPG.DomainModels.JiraQuests;
using AlfaRPG.DomainModels.Services;
using AlfaRPG.Infrastructure.Characters;
using AlfaRPG.Infrastructure.JiraQuests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaRPG.Infrastructure.Services
{
    [TestFixture]
    public class ExperienceCalculatorTests
    {
        [Test]
        public void CalculateExperience_Is_Passing()
        {
            IJiraQuest quest = PrepareJiraQuest();
            int calculatedValue = quest.CompleteQuest();
            Assert.AreEqual(5, calculatedValue);
        }

        private static IJiraQuest PrepareJiraQuest()
        {
            IExperienceCalculator expCalculator = new ExperienceCalculator();
            IJiraQuest quest = new JiraQuest(expCalculator);
            quest.SprintPoints = 8;
            quest.EstimatedCompletionTime = 7.5;
            quest.RealTime = 10;
            return quest;
        }

        [Test]
        public void UserCompletesJiraQuest_Is_Passing()
        {
            IPlayerCharacter humanPlayer = new HumanPlayer();
            humanPlayer.JiraQuests.Add(PrepareJiraQuest());
            var notCompletedQuest = humanPlayer.JiraQuests.Where(o => !o.Completed).Single();
            notCompletedQuest.CompleteQuest(humanPlayer);
            Assert.AreEqual(5, humanPlayer.Experience);
            
        }
    }
}
