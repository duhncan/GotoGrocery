using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToGrocery
{
    public class Members
    {
        // All Member Variables
        private string fName, lName, email, membershipStatus, phoneNo, dob;
        private int membID;

        // Constructor class
        // When a member is created, it requires: a first name; a last name; an email;
        // and a date of birth, in order to register.
        // Other information can be set manually later
        public Members(string _fName, string _lName, string _email, string _dob )
        {
            fName = _fName;
            lName = _lName;
            email = _email;
            dob = _dob;
            //membID = GenerateID();          // Member ID can not be manually set
            membershipStatus = "active";    // Defaults to active when created
        }

        public string FName { 
            get => fName; 
            set { fName = value; } 
        }
        public string LName
        {
            get => lName;
            set { lName = value; }
        }

        public string Email
        {
            get => email;
            set { email = value; }
        }

        public string PhoneNo
        {
            get => phoneNo;
            set { phoneNo = value; }
        }

        public string Dob
        {
            get => dob;
            set { dob = value; }
        }

        public string FullName()
        {
            return fName + " " + lName;
        }


        // Generates New member ID based on the current members
        //private int GenerateID(/* Dunno what to put here */)
        //{
            
        //}
    }
}
