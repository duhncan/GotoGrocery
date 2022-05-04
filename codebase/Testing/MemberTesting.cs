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
    public class MemberTesting
    {
        // Testing Member Objects
        private Members _testableObject;

        [SetUp]
        public void SetUp()
        {
            _testableObject = new Members();
        }

        [Test]
        public void TestObjectExists()
        {

            Assert.IsNotNull(_testableObject); //For example

        }


        [TestCase("Some string.")] //Scenario 1: Exact match.
        [TestCase("SOME sTrInG.")] //Scenario 2: Contains uppercase characters.
        [TestCase("some string.")] //Scenario 3: All lowercase characters.
        public void TestString(string toTest)
        {

        }


    }
}