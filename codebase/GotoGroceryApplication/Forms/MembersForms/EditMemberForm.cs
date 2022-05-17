using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;

namespace GotoGrocery.Forms.MembersForms
{
    public partial class EditMemberForm : Form
    {
        private MembersForm mf;

        public EditMemberForm(String id, MembersForm membersForm)
        {
            InitializeComponent();
            mf = membersForm;
            int formattedID = -1;
            try { formattedID = Int32.Parse(id); }
            catch (FormatException) { Console.WriteLine($"Unable to parse '{id}'"); }

            Members memb = new Members();
            memb = GetMemberFromDB(memb, formattedID);

            MemberIdTB.Text = memb.MembID.ToString();
            EditFNameTB.Text = Capitalize(memb.FName);
            EditLNameTB.Text = Capitalize(memb.LName);
            EditDOBInput.Text = Date_forFORM(memb.Dob);
            EditEmailTB.Text = memb.Email;
            EditPhoneTB.Text = memb.PhoneNo;
            EditdateStartInput.Text = Date_forFORM(memb.MembershipStartDate);

        }

        private string Capitalize(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }

        private Members GetMemberFromDB(Members member, int id)
        {
            DatabaseConnection db = new DatabaseConnection();
            List<String> m = db.MembertoString(id);


            // Convert from list of strings to Member Object
            member.MembID = id;
            member.FName = m[1];
            member.LName = m[2];
            member.Dob = Date_forDB(m[3]);
            member.PhoneNo = m[4];
            member.Email = m[5];
            member.MembershipStatus = m[6].ToLower();
            member.MembershipStartDate = Date_forDB(m[7]);

            // Membership Status Logic
            if (member.MembershipStatus == "true")
            {
                StatusTrueCheck.Checked = true;
            }
            else if (member.MembershipStatus == "false")
            {
                StatusFalseCheck.Checked = true;
            }

            return member;
        }

        private void CancelEditMemberBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AcceptEditMemberDetailsBtn_Click(object sender, EventArgs e)
        {
            // Push all information from textbox to Member Object
            Members memb = new Members();

            memb.MembID = Int32.Parse(MemberIdTB.Text);
            memb.FName = EditFNameTB.Text.ToLower();
            memb.LName = EditLNameTB.Text.ToLower();
            memb.Dob = Date_forDB(EditDOBInput.Text);
            memb.Email = EditEmailTB.Text;
            memb.PhoneNo = EditPhoneTB.Text;
            memb.MembershipStartDate = Date_forDB(EditdateStartInput.Text);
            if (StatusTrueCheck.Checked == true) //Membership Status Logic
                memb.MembershipStatus = "true";
            else
                memb.MembershipStatus = "false";

            // Validate
            uint pass = memb.Validate();
            string errorMsg = "";
            if (!IsBitSet(pass, 7)) { errorMsg += "\nID Invalid"; }
            if (!IsBitSet(pass, 6)) { errorMsg += "\nFirst Name Invalid"; }
            if (!IsBitSet(pass, 5)) { errorMsg += "\nLast Name Invalid"; }
            //if (!IsBitSet(pass, 4)) { errorMsg += "\nEmail Invalid"; } Email Validation not needed at is used as first point of reference and validated upon adding
            if (!IsBitSet(pass, 3)) { errorMsg += "\nMembership Status Name Invalid"; }
            if (!IsBitSet(pass, 2)) { errorMsg += "\nPhone Number Invalid"; }
            if (!IsBitSet(pass, 1)) { errorMsg += "\nDoB Invalid"; }
            if (!IsBitSet(pass, 0)) { errorMsg += "\nMembership Start Date Invalid"; }

            // Error Management
            if (errorMsg != "")
            {
                MessageBox.Show(errorMsg + "\n" + EditDOBInput.Text);
                Console.WriteLine(errorMsg);
            }
            else
            {
                // Push to database
                DatabaseConnection db = new DatabaseConnection();

                db.UpdateMember(memb.Email, "Member_FirstName", memb.FName);
                db.UpdateMember(memb.Email, "Member_LastName", memb.LName);
                db.UpdateMember(memb.Email, "Member_DOB", memb.Dob);
                db.UpdateMember(memb.Email, "Member_phoneNumber", memb.PhoneNo);
                db.UpdateMember(memb.Email, "Member_Status", memb.MembershipStatus);
                db.UpdateMember(memb.Email, "Member_StartDate", memb.MembershipStartDate);

                MessageBox.Show("Member edited successfully!");
                Console.WriteLine("Member edited successfully!");
                this.Close();
                mf.LoadMembersIntoTable();
            }

        }

        bool IsBitSet(uint b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }

        private void StatusFalseCheck_CheckedChanged(object sender, EventArgs e)
        {
            StatusFalseCheck.Checked = true;
            StatusTrueCheck.Checked = false;

        }

        private void StatusTrueCheck_CheckedChanged(object sender, EventArgs e)
        {
            StatusTrueCheck.Checked = true;
            StatusFalseCheck.Checked = false;

        }

        // Private method that changes the Date to one acceptable by MYSQL database
        // Assumes that Forms yield a date in the format "dd/MM/yyyy"
        // Converts it into "yyyy-MM-dd" otherwise returns empty string
        private string Date_forDB(string givenDate)
        {
               return Convert.ToDateTime(givenDate).ToString("yyyy-MM-dd");
        }


        // Private method that changes the Date to one acceptable by MYSQL database
        // Assumes that Forms yield a date in the format "dd/MM/yyyy"
        // Converts it into "yyyy-MM-dd" otherwise returns empty string
        private string Date_forFORM(string givenDate)
        {
            return Convert.ToDateTime(givenDate).ToString("dd/MM/yyyy");
        }

        private void StatusTrueCheck_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
