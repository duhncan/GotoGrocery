using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GotoGrocery
{
    public partial class MembersForm : Form
    {
        List<String> m;

        public MembersForm()
        {
            InitializeComponent();
            LoadMembersIntoTable();
        }
        DatabaseConnection db = new DatabaseConnection();
        //member table creation
        DataTable dt = new DataTable();
        //method to load table

        private void Grid_Load()
        {

            //column setup
    
            membersdataGridView.Columns[0].HeaderText = "ID";
            membersdataGridView.Columns[1].HeaderText = "fName";
            membersdataGridView.Columns[2].HeaderText = "lName";
            membersdataGridView.Columns[3].HeaderText = "DOB";
            membersdataGridView.Columns[4].HeaderText = "ContactNumber";
            membersdataGridView.Columns[5].HeaderText = "Start-Date";
            membersdataGridView.Columns[5].HeaderText = "Status";


        }
        public void LoadMembersIntoTable()
        {
            DatabaseConnection db = new DatabaseConnection();
            membersdataGridView.DataSource = db.GetMembersList();
            Grid_Load();

        }
       
          
        

        private void Tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                String name = MembersSearchTB.Text;
                membersdataGridView.DataSource = db.SearchMemberByName(name);
            }
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
                m = db.MembertoString(11);
                Forms.MembersForms.EditMemberForm f = new Forms.MembersForms.EditMemberForm(id, this);
                f.Show();

            }
            else
            {
                MessageBox.Show("Select row from table to edit");
            }


        }

        private void MemberSearchBtn_Click(object sender, EventArgs e)
        {

            String name = MembersSearchTB.Text;
            membersdataGridView.DataSource = db.SearchMemberByName(name);

        }


        private void MemberClearBtn_Click(object sender, EventArgs e)
        {
            MembersSearchTB.Text = "";
            membersdataGridView.DataSource = db.GetMembersList();
        }
    }
}
