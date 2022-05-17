using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;


namespace GotoGrocery
{
    public partial class AddMemberForm : Form
    {
      private MembersForm mf;
        public AddMemberForm(MembersForm membersForm)
        {
            mf = membersForm;
            InitializeComponent();
        }


        private void CancelNewMemberBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMemberDetailsBtn_Click(object sender, EventArgs e)
        {
            // Push all information from textbox to Member Object
            Members memb = new Members();
            DateTime dt = DateTime.Now;

            memb.FName = FNameTB.Text;
            memb.LName = LNameTB.Text;
            memb.Dob = Date_forDB(DOBTB.Text);
            memb.Email = EmailTB.Text;
            memb.PhoneNo = PhoneTB.Text;
            memb.MembershipStartDate = dt.ToString("yyyy-MM-dd");
            memb.MembershipStatus = "true";

            // Validate
            uint pass = memb.Validate();
            string errorMsg = "";
            if (!IsBitSet(pass, 7)) { errorMsg += "\nID Invalid"; }
            if (!IsBitSet(pass, 6)) { errorMsg += "\nFirst Name Invalid"; }
            if (!IsBitSet(pass, 5)) { errorMsg += "\nLast Name Invalid"; }
            if (!IsBitSet(pass, 4)) { errorMsg += "\nEmail Invalid"; }
            if (!IsBitSet(pass, 3)) { errorMsg += "\nMembership Status Name Invalid"; }
            if (!IsBitSet(pass, 2)) { errorMsg += "\nPhone Number Invalid"; }
            if (!IsBitSet(pass, 1)) { errorMsg += "\nDoB Invalid"; }
            if (!IsBitSet(pass, 0)) { errorMsg += "\nMembership Start Date Invalid"; }

            // Error Management
            if (errorMsg != "")
            {
                MessageBox.Show(errorMsg);
                Console.WriteLine(errorMsg);
            }
            else
            {
                // Push to DB
                DatabaseConnection db = new DatabaseConnection();
                db.AddMember(memb.FName, memb.LName, memb.Dob, memb.PhoneNo, memb.Email, memb.MembershipStartDate);

                MessageBox.Show("Member Added Successfully!");
                Console.WriteLine("Member Added Successfully!");
                this.Close();
                mf.LoadMembersIntoTable();
            }
        }

        // Private method that changes the Date to one acceptable by MYSQL database
        // Assumes that Forms yield a date in the format "dd/MM/yyyy"
        // Converts it into "yyyy-MM-dd" otherwise returns empty string
        //private string Date_forDB(string givenDate)
        //{
        //    DateTime dt;
        //    string[] formats = { "dd/MM/yyyy" };
        //    if (!DateTime.TryParseExact(givenDate, formats, System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
        //        return "";
        //    else
        //        return dt.ToString("yyyy-MM-dd");
        //}

        // Private method that changes the Date to one acceptable by MYSQL database
        // Assumes that Forms yield a date in the format "dd/MM/yyyy"
        // Converts it into "yyyy-MM-dd" otherwise returns empty string
        private string Date_forDB(string givenDate)
        {
            return Convert.ToDateTime(givenDate).ToString("yyyy-MM-dd");
        }

        bool IsBitSet(uint b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
