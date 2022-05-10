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
        private Members _testMember;

        [SetUp]
        public void SetUp()
        {
            _testMember = new Members();
        }

        [Test]
        public void TestObjectExists()
        {
            Assert.IsNotNull(_testMember); // Ensure object is created and existing
        }


        [TestCase("some string.")]  // Fullstop
        [TestCase("SOME sTrInG")]   // Uppercase
        [TestCase("s0m3 s7r1ng")]   // Digits
        public void TestFirstandLastName(string toTest)
        {
            _testMember.FName = toTest;
            _testMember.LName = toTest;
            Assert.AreEqual(_testMember.FName, ""); // Ensuring that all not expected letters are filtered as ""
            Assert.AreEqual(_testMember.LName, "");
        }



    }
}