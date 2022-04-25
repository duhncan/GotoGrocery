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
       private String _id;
        private String _fName;
        private String _lName;
        private String _DOB;
        private String _email;
        private String _phone;
        private string _status;
        private string _startDate;

        // DateTime startDate = new DateTime(2020, 11, 1);

        // string formattedDate = startDate.ToString("dd/M/yyyy");

        public EditMemberForm(String id)//member as peram?
        
        {
            InitializeComponent();
            DatabaseConnection db = new DatabaseConnection();
            //TODO put member details into display text bar using MemberToString
            //Testing data
            List<String> m = new List<string>();
            string input = String.Empty;
            try
            {
                int result = Int32.Parse(id);
                m = db.MembertoString(result);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{id}'");
            }

             _id = m[0];        
             _fName = m[1];
             _lName = m[2];

            //YMD
            //++++++++++++++++++++++++++++++++++++++++++++++TODO - dates+++++++++++++++++++++++++++++++
            //DateTime dob = new DateTime(2000, 11, 1);
            //string formattedDOB = dob.ToString("dd/M/yyyy");
             _DOB = m[3];
            _phone = m[4];
            _email = m[5];
            _status = m[6];
            _startDate = m[7];
            
            //Check checkboxes according to current status
            if (_status == "True")
            {
                StatusTrueCheck.Checked = true;
                StatusFalseCheck.Checked = false;
            }
            else
            {
                StatusTrueCheck.Checked = false;
                StatusFalseCheck.Checked = true;
            }

            // DateTime startDate = new DateTime(2020, 11, 1);

            // string formattedDate = startDate.ToString("dd/M/yyyy");
            bool status;

            MemberIdTB.Text = _id;
            EditFNameTB.Text = _fName;
            EditLNameTB.Text = _lName;
            //  EditDOBInput.Text = formattedDOB;
            EditDOBInput.Text = _DOB;
            EditEmailTB.Text = _email;
            EditPhoneTB.Text = _phone;
            // EditdateStartInput.Text = formattedDate;
           
            

        }

        private void CancelEditMemberBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

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
