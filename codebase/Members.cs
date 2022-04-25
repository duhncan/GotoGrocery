using System.Linq;

namespace GotoGrocery
{
    public class Members
    {
        // All Member Variables
        private string fName, lName, email, membershipStatus, phoneNo, dob, membershipStartDate;
        private int membID;

        public Members() { }

        public uint Validate()
        {
            // Each member variable represents a valid or invalid bit in the following order
            // ID, First Name, Last Name, Email, Membership Status, Phone Number, DOB, Membership Start Date
            // ID is handled by SQL therefore not needed to be checked and will always be considered the most left bit
            uint valid = 0b_1000_0000;

            if (this.FName != "") { valid ^= 0b_0100_0000; }
            if (this.LName != "") { valid ^= 0b_0010_0000; }
            if (this.Email != "") { valid ^= 0b_0001_0000; }
            if (this.MembershipStatus != "") { valid ^= 0b_0000_1000; }
            if (this.PhoneNo != "") { valid ^= 0b_0000_0100; }
            if (this.Dob != "") { valid ^= 0b_0000_0010; }
            if (this.MembershipStartDate != "") { valid ^= 0b_0000_0001; }

            return valid;
        }

        private bool textValidation(string text)
        {
            if (text == null || text.Length == 0) // Checks if exists
                return false;

            if (text.Any(char.IsUpper)) // Checks whether capitalised 
                return false;

            if (text.Any(char.IsDigit)) // Checks whether there are numbers within
                return false;

            return true; // True if all test cases pass
        }

        public string FName
        {
            get => fName;
            set
            {
                if (!textValidation(value.ToLower()))
                    fName = "";
                else
                    fName = value.ToLower();
            }
        }
        public string LName
        {
            get => lName;
            set
            {
                if (!textValidation(value.ToLower()))
                    lName = "";
                else
                    lName = value.ToLower();
            }
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
        public string MembershipStatus
        {
            get => membershipStatus;
            set
            {
                if (value.ToLower() != "active" || value.ToLower() != "inactive")
                {
                    membershipStatus = "";
                }
                else
                {
                    membershipStatus = value.ToLower();
                }
            }

        }

        public string MembershipStartDate
        {
            get => membershipStartDate;
            set { membershipStartDate = value; }
        }
        public int MembID
        {
            get => membID;
            set { membID = value; }
        }

        public string FullName()
        {
            return fName + " " + lName;
        }

    }
}
