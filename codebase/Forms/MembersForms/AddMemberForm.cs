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


        private void CancelNewMemberBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMemberDetailsBtn_Click(object sender, EventArgs e)
        {
            String fName = FNameTB.Text;
            String lName = LNameTB.Text;
            String dob = DOBTB.Text; // This needs to change to other format for procesing in database
            String Phone = PhoneTB.Text;
            String email = EmailTB.Text;
            //Members m = new Members(fName, lName, email, dob);



            DatabaseConnection db = new DatabaseConnection(); // Hard coded date "dob"
            db.AddMember(fName, lName, "2002-12-28", Phone, email, DateTime.UtcNow.ToString("yyyy-MM-dd"));
             
            this.Close();
          //  MemberForm.membersdataGridView.DataSource = db.GetMembersList();

        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
