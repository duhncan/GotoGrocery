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
    public partial class MainForm : Form
    {//spashpage

        public MainForm()
        {
            InitializeComponent();
            LoadForm(new DashboardForm());

        }
        public void LoadForm(object Form)
        {
            if (this.currentPagePanel.Controls.Count > 0)
                this.currentPagePanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.currentPagePanel.Controls.Add(f);
            this.currentPagePanel.Tag = f;
            f.Show();
        }
        

    
        private void Name_Click(object sender, EventArgs e)
        {//nothing

        }
        //menu buttons
        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new InventoryForm());
        }
        private void MemberBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new MembersForm());
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new DashboardForm());
        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new SalesForm());
        }
    }
}
