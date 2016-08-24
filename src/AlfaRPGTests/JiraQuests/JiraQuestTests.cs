using AlfaRPG.Infrastructure.JiraQuests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlfaRPG.DomainModels.JiraQuests;

namespace AlfaRPGTests.JiraQuests
{
    [TestFixture]
    public class JiraQuestTests
    {
        [Test]
        public void JiraQuest_Has_JiraName()
        {
            IJiraQuest quest = new JiraQuest();
            quest.JiraName = "TPTWO-4532";
            Assert.IsTrue(quest.JiraName == "TPTWO-4532");
        }

        [Test]
        public void JiraQuest_Has_SprintPoints()
        {
            IJiraQuest quest = new JiraQuest();
            quest.SprintPoints = 8;
            Assert.IsTrue(quest.SprintPoints == 8);
        }
    }
}
