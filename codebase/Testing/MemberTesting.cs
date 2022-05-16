using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;


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


        [TestCase("102093756@student.swin.edu.au")] 
        [TestCase("email@gmail.com")] 
        public void TestValidEmails(string toTest)
        {
            _testMember.Email = toTest;
            Assert.AreEqual(toTest, _testMember.Email); 
        }

        [TestCase("email")]
        [TestCase("duhncangmail.com")]
        public void TestNonValidEmails(string toTest)
        {
            _testMember.Email = toTest;
            Assert.AreEqual("", _testMember.Email);
        }

        [TestCase("abc123")]
        [TestCase("0412345ABc")]
        public void TestPhoneNo(string toTest)
        {
            _testMember.PhoneNo = toTest;
            Assert.AreEqual("", _testMember.PhoneNo);
        }


        private void DefaultMember()
        {
            // Set up Valid Member and Test
            _testMember.FName = "duhncan";
            _testMember.LName = "guy";
            _testMember.Email = "duhncan@gmail.com";
            //_testMember.Email = "102093756@student.swin.edu.au";
            _testMember.MembershipStatus = "true";
            _testMember.MembershipStartDate = "2022-10-02";
            _testMember.Dob = "1999-05-12";
            _testMember.PhoneNo = "0412345678";
        }


        [Test]
        public void TestValidMemberCreation()
        {
            // Set up Valid Member and Test
            DefaultMember();

            Assert.AreNotEqual(_testMember.FName, "");
            Assert.AreNotEqual(_testMember.LName, "");
            Assert.AreNotEqual(_testMember.Email, "");
            Assert.AreNotEqual(_testMember.MembershipStatus, "");
            Assert.AreNotEqual(_testMember.MembershipStartDate, "");
            Assert.AreNotEqual(_testMember.Dob, "");
            Assert.AreNotEqual(_testMember.PhoneNo, "");
        }

         [Test]
        public void TestValidation()
        {
            // Set up Valid Member and Test
            DefaultMember(); // Reset Member to Defaults within method
            Assert.AreEqual(0b_1111_1111, _testMember.Validate());

            // First Name Validation Test
            _testMember.FName = "1Duhncan"; // Invalid First Name
            Assert.AreEqual(0b_1011_1111, _testMember.Validate());
            // Note that this will be the same for first and last name

            // Email Validation Test
            DefaultMember(); // Reset Member to Defaults within method
            _testMember.Email = "email.server"; // Invalid Email
            Assert.AreEqual(0b_1110_1111, _testMember.Validate());

            // Membership Status Validation Test
            DefaultMember(); // Reset Member to Defaults within method
            _testMember.MembershipStatus = "jibberish"; // Invalid Membership Status
            Assert.AreEqual(0b_1111_0111, _testMember.Validate());

            // Phone Number Validation Test
            DefaultMember(); // Reset Member to Defaults within method
            _testMember.PhoneNo = "04abcdefgh"; // Invalid Phone Number
            Assert.AreEqual(0b_1111_1011, _testMember.Validate());

            // DoB Validation Test
            DefaultMember(); // Reset Member to Defaults within method
            _testMember.Dob = "12-05-1999"; // Invalid Phone Number
            Assert.AreEqual(0b_1111_1101, _testMember.Validate());

            // Membership Start Date Validation Test
            DefaultMember(); // Reset Member to Defaults within method
            _testMember.MembershipStartDate = "12/05/2022"; // Invalid Phone Number
            Assert.AreEqual(0b_1111_1110, _testMember.Validate());

        }
    }
}