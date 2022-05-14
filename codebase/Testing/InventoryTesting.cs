using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoToGrocery;

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

        //Inventory order: Product name, inventory level, product size, shelf quantity, order amount
        [Test]
        public void TestValidationAllValid()
        {
            int errorcode = _testInventory.validateProduct("name", "12", "14 kg", "22", "16");
            Assert.IsTrue(errorcode == 0);
        }

        [Test]
        public void TestValidationNameInvalid()
        {
            int errorcode = _testInventory.validateProduct("", "12", "14 kg", "22", "16");
            Assert.IsTrue(errorcode == 1);
        }

        [Test]
        public void TestValidationLevelInvalid()
        {
            int errorcode = _testInventory.validateProduct("name", "inventorylevel", "14 kg", "22", "16");
            Assert.IsTrue(errorcode == 2);
        }

        [Test]
        public void TestValidationSizeInvalid()
        {
            int errorcode = _testInventory.validateProduct("name", "12", "productsize", "22", "16");
            Assert.IsTrue(errorcode == 3);
        }

        [Test]
        public void TestValidationShelfInvalid()
        {
            int errorcode = _testInventory.validateProduct("name", "12", "14 kg", "shelfquantity", "16");
            Assert.IsTrue(errorcode == 4);
        }

        [Test]
        public void TestValidationOrderInvalid()
        {
            int errorcode = _testInventory.validateProduct("name", "12", "14 kg", "22", "orderamount");
            Assert.IsTrue(errorcode == 5);
        }

        [Test]
        public void TestValidationMultipleInvalid()
        {
            int errorcode = _testInventory.validateProduct("", "inventorylevel", "productsize", "shelfquantity", "orderamount");
            Assert.IsTrue(errorcode == 1);
        }
    }
}