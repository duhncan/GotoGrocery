using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoGrocery.Forms.MembersForms
{
    public partial class EditMemberForm : Form
    {
        public EditMemberForm(String id)//member as peram?
        {
            InitializeComponent();

            //TODO put member details into display text bar using member methods or ?
            //Testing data
            String ID = id;         //"01293";
            String fName = "John";
            String lName = "Johanson";
            //YMD
            DateTime dob = new DateTime(2000, 11, 1);
            string formattedDOB = dob.ToString("dd/M/yyyy");
            String email = "johnJ@hotmail.com";
            String phone = "0409150111";
            DateTime startDate = new DateTime(2020, 11, 1);
            string formattedDate = startDate.ToString("dd/M/yyyy");
            bool status = true;

            MemberIdTB.Text = ID;
            EditFNameTB.Text = fName;
            EditLNameTB.Text = lName;
            EditDOBInput.Text = formattedDOB;
            EditEmailTB.Text = email;
            EditPhoneTB.Text = phone;
           EditdateStartInput.Text = formattedDate;
           //Check checkboxes according to current status
            if (status)
            {
                StatusTrueCheck.Checked = true;
                StatusFalseCheck.Checked = false;
            }
            else
            {
                StatusTrueCheck.Checked = false;
                StatusFalseCheck.Checked = true;
            }
          
        }

        private void CancelEditMemberBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        ////String id, String fName, String Lname, String DOB, String Phone, String Em
        ////private void InsertMemberDetails(Member m)
        //{
        //    MemberIdTB.Text = member.GetId(m);
        //    EditFNameTB.Text = fName;
        //    // TODO
        //}
     
        private void AcceptEditMemberDetailsBtn_Click(object sender, EventArgs e)
        {
            //send new edited member details to database
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

       
    }
}
