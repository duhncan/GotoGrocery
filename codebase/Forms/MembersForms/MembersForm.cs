using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GotoGrocery
{
    public partial class MembersForm : Form
    {

        public MembersForm()
        {
            InitializeComponent();
            Grid_Load();
            LoadMembersIntoTable();
          //  BindGrid();
        }

        //member table creation
        DataTable dt = new DataTable();
        //method to load table
        private void Grid_Load()
        {

            //column setup
            dt.Columns.Add("ID");
            dt.Columns.Add("fName");
            dt.Columns.Add("lName");
            dt.Columns.Add("DOB");
            dt.Columns.Add("Email");
            dt.Columns.Add("ContactNumber");
            dt.Columns.Add("Start-Date");
            dt.Columns.Add("Status");

            membersdataGridView.DataSource = dt;

        }
        private void LoadMembersIntoTable()
        {
            DatabaseConnection db = new DatabaseConnection();

            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            /*
             * (highestNumberById?)
            while next member exists return true
            loop -
            method return member info ->
            new member()

            dr[0] = member.name;
            dr[1] = member.email;
            dr[2] = memer.phone;
            dt.Rows.Add(dr);
             
            


            //new data row

            //DataRow dr1 = dt.NewRow();
            //String ID = "01293";
            //String fName = "John";
            //String lName = "Johanson";
            ////YMD
            //DateTime dob = new DateTime(2000, 11, 1);
            //string formattedDOB = dob.ToString("dd/M/yyyy");
            //String email = "johnJ@hotmail.com";
            //String phone = "0409150111";
            //DateTime startDate = new DateTime(2020, 11, 1);
            //string formattedDate = startDate.ToString("dd/M/yyyy");
            //bool status = true;

            ////rows are created
            //dr1[0] = ID;
            //dr1[1] = fName;
            //dr1[2] = lName;
            //dr1[3] = formattedDOB;
            //dr1[4] = email;
            //dr1[5] = phone;
            //dr1[6] = formattedDate;
            //dr1[7] = status;

            //dt.Rows.Add(dr1);
            





           
            DataRow dr2 = dt.NewRow();
          int ID2= db.NumberOfMembers();
            String fName2 = "James";
            String lName2 = "Jona";
            //YMD
            DateTime dob2 = new DateTime(2010, 1, 1);
            string formattedDOB2 = dob2.ToString("dd/M/yyyy");
            String email2 = "johnJ@hotmail.com";
            String phone2 = "0409150111";
            DateTime startDate2 = new DateTime(2020, 10, 1);
            string formattedDate2 = startDate2.ToString("dd/M/yyyy");
            bool status2 = true;

            //rows are created and inputed with test data
            dr2[0] = ID2;
            dr2[1] = fName2;
            dr2[2] = lName2;
            dr2[3] = formattedDOB2;
            dr2[4] = email2;
            dr2[5] = phone2;
            dr2[6] = formattedDate2;
            dr2[7] = status2;

            dt.Rows.Add(dr2);
          //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            */

            membersdataGridView.DataSource = db.GetMembersList();

        }
        
        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            //Create and Open form to add new member
            AddMemberForm f = new AddMemberForm();
            f.Show();
        }

        //edit button event for members
        private void EditSelectedMemberBtn_Click(object sender, EventArgs e)
        {
            string ID1 = "";

            foreach (DataGridViewRow row in membersdataGridView.SelectedRows)
            {


                ID1 = row.Cells[0].Value.ToString();


            }
            //open edit form
            if (ID1 != null)
            {
                //Search database for MemberID wherevalue1 == memberID
                
                //^if exists then 
                DatabaseConnection db = new DatabaseConnection();
                List<String> m = new List<string>();
                m = db.MembertoString(11); 


               


                Forms.MembersForms.EditMemberForm f = new Forms.MembersForms.EditMemberForm(ID1);
                f.Show();

            }
            else
            {
                MessageBox.Show("Select row from table to edit");
            }
            

        }

        private void MemberSearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchByIDCheck.Checked)
            {
                String ID = MembersSearchTB.Text;
               
                /*           TODO
                 *+++++++++++++++++++++++++++ 
                 
                //getMemberById()
                //method to update table
                +++++++++++++++++++++++++++++++
                */
            }
        }

        private void StatusIDCheck_CheckedChanged(object sender, EventArgs e)
        {
            SearchByIDCheck.Checked = true;
            SearchByEmailCheck.Checked = false;

        }

        private void StatusEmailCheck_CheckedChanged(object sender, EventArgs e)
        {
            SearchByIDCheck.Checked = false;
            SearchByEmailCheck.Checked = true;

        }

       
    }
}
