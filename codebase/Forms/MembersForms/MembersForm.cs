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
        }

        //member table creation
        DataTable dt = new DataTable();
        DataColumn dcRowString;
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
             dcRowString = dt.Columns.Add("_RowString", typeof(string));
            membersdataGridView.DataSource = dt;

        }
        public void LoadMembersIntoTable()
        {
            DatabaseConnection db = new DatabaseConnection();
            membersdataGridView.DataSource = db.GetMembersList();
            foreach (DataRow dataRow in dt.Rows)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < dt.Columns.Count - 1; i++)
                {
                    sb.Append(dataRow[i].ToString());
                    sb.Append("\t");
                }
                dataRow[dcRowString] = sb.ToString();
            }
        }
        private void MembersSearchTB_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", MembersSearchTB.Text);
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            //Create and Open form to add new member
            AddMemberForm f = new AddMemberForm(this);
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





                Forms.MembersForms.EditMemberForm f = new Forms.MembersForms.EditMemberForm(id,this);
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
