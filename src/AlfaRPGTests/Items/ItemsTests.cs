using AlfaRPG.DomainModels.Items.Weapons;
using AlfaRPG.Infrastructure.Items;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlfaRPGTests.Items
{
    [TestFixture]
    public class ItemsTests
    {
        [Test]
        public void Items_Has_Name()
        {
            IItem club = new Club();
            club.Name = "Maczuga";
            Assert.IsTrue(club.Name == "Maczuga");
        }

        [Test]
        public void InventoryItem_Has_Weight()
        {
            IInventoryItem club = new Club();
            club.WeightInKilos = 2;
            Assert.IsTrue(club.WeightInKilos == 2);
        }

        [Test]
        public void AttackItem_Has_Attack()
        {
            IAttackItem club = new Club();
            club.Attack = 5;
            Assert.IsTrue(club.Attack == 5);
        }
    }
}
