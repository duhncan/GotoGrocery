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
            String dob = datefix(DOBTB.Text);
            String Phone = PhoneTB.Text;
            String email = EmailTB.Text;

            DatabaseConnection db = new DatabaseConnection(); // Hard coded date "dob"
            db.AddMember(fName, lName, dob, Phone, email, DateTime.UtcNow.ToString("yyyy-MM-dd"));
            
            //close and load members
            this.Close();
            mf.LoadMembersIntoTable();
        }

        // Method to convert SQL Date from yyyy-MM-dd to dd/MM/yyyy
        private string datefix(string givenDate)
        {
            // DateTime startDate = new DateTime(2020, 11, 1);
            // string formattedDate = startDate.ToString("dd/M/yyyy");
            string[] split = givenDate.Split('/');
            return split[2] + "-" + split[1] + "-" + split[0];
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
