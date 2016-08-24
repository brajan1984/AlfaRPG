using AlfaRPG.DomainModels.Characters.Races;
using AlfaRPG.Infrastructure.Characters;
using AlfaRPG.Infrastructure.Items;
using NUnit.Framework;
using System.Collections.Generic;

namespace AlfaRPGTests.Characters
{
    [TestFixture]
    public class CharacterTests
    {
        [Test]
        public void Character_Is_ICharacter_Test()
        {
            ICharacter human = new Human();
            Assert.IsTrue(human is ICharacter);
        }

        [Test]
        public void Character_Has_Experience()
        {
            ICharacter human = new Human();
            Assert.IsTrue(human.Experience == 0);
        }

        [Test]
        public void Character_Has_Name()
        {
            ICharacter human = new Human();
            human.Name = "Arturek";
            Assert.IsTrue(human.Name == "Arturek");
        }

        [Test]
        public void Character_Has_Level()
        {
            ICharacter human = new Human();
            human.Level = 12;
            Assert.IsTrue(human.Level == 12);
        }

        [Test]
        public void Character_Has_Hitpoints()
        {
            ICharacter human = new Human();
            human.HP = 120;
            Assert.IsTrue(human.HP == 120);
        }

        [Test]
        public void Character_Has_Strength()
        {
            ICharacter human = new Human();
            human.Strength = 10;
            Assert.IsTrue(human.Strength == 10);
        }

        [Test]
        public void Character_Has_Inventory()
        {
            ICharacter human = new Human();
            human.Inventory = new List<IInventoryItem>();
            Assert.IsTrue(human.Inventory.Count == 0);
        }
    }
}