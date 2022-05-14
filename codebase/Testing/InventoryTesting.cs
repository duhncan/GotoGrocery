using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GotoGrocery;

namespace Testing
{
    [TestFixture]
    public class InventoryTesting
    {
        // Testing Member Objects
        private Inventory _testInventory;

        [SetUp]
        public void SetUp()
        {
            _testInventory = new Inventory();
        }

        [Test]
        public void TestObjectExists()
        {
            Assert.IsNotNull(_testInventory); // Ensure object is created and existing
        }

        public void TestValidation()
        {
            Assert.Pass();
        }



    }
}