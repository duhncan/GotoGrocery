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
        List<String> m; 

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
            string id = "";
             m = new List<string>();
            foreach (DataGridViewRow row in membersdataGridView.SelectedRows)
            {


                id = row.Cells[0].Value.ToString();


            }
            //open edit form
            if (id != null)
            {
                
                DatabaseConnection db = new DatabaseConnection();
              
                m = db.MembertoString(11);





                Forms.MembersForms.EditMemberForm f = new Forms.MembersForms.EditMemberForm(id);
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
