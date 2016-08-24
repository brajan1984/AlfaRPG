using AlfaRPG.DomainModels.Characters.Players;
using AlfaRPG.Infrastructure.Characters;
using AlfaRPG.Infrastructure.JiraQuests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaRPGTests.Characters
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        [Test]
        public void PlayerCharacter_Has_JiraQuests()
        {
            IPlayerCharacter character = new HumanPlayer();
            character.JiraQuests = new List<IJiraQuest>();
            Assert.IsTrue(character.JiraQuests.Count == 0);
        }
    }
}
