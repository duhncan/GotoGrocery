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
        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CancelNewMemberBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMemberDetailsBtn_Click(object sender, EventArgs e)
        {

            String fName = FNameTB.Text;

            String lName = LNameTB.Text;

            String dob = DOBTB.Text;

            String Phone = PhoneTB.Text;

            String email = EmailTB.Text;

            Members m = new Members(fName, lName, email, dob);

            //create new member
            //AddMemeber(fName,lName,)
           // Members m = new Members(fName,lName,email,dob);

        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
