using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            String fName = FNameTB.Text;
            String lName = LNameTB.Text;
            String dob = datefix(DOBTB.Text); // This needs to change to other format for procesing in database
            String Phone = PhoneTB.Text;
            String email = EmailTB.Text;
            //Members m = new Members(fName, lName, email, dob);



            DatabaseConnection db = new DatabaseConnection(); // Hard coded date "dob"
            db.AddMember(fName, lName, dob, Phone, email, DateTime.UtcNow.ToString("yyyy-MM-dd"));
            
            //close and load members
            this.Close();
            mf.LoadMembersIntoTable();
        }
        private string datefix(string givenDate)
        {
            // DateTime startDate = new DateTime(2020, 11, 1);
            // string formattedDate = startDate.ToString("dd/M/yyyy");
            string[] split = givenDate.Split('/');
            return split[2] + "-" + split[0] + "-" + split[1];
        }

    }
}
