using System;
using System.Data;
using System.Windows.Forms;

namespace GotoGrocery
{
    public partial class InventoryForm : Form
    {
        DatabaseConnection db = new DatabaseConnection();

        public InventoryForm()
        {
            InitializeComponent();

            LoadItemIntoTable();

        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            //creates form to add a new item
            AddItemForm f = new AddItemForm(this);
            
            f.Show();
        }
        //inventory table creation
        DataTable dt = new DataTable();
        
        //method to load table
        private void Grid_Load()
        {
           InventorydataGridView.Columns[0].HeaderText = "ID";
            InventorydataGridView.Columns[1].HeaderText = "Name";
            InventorydataGridView.Columns[2].HeaderText = "Inventory Level";
            InventorydataGridView.Columns[3].HeaderText = "Product Size";
            InventorydataGridView.Columns[4].HeaderText = "Shelf Qty";
            InventorydataGridView.Columns[5].HeaderText = "Order Qty";
        }
        public void LoadItemIntoTable()
        {
            //get inventory from db
              InventorydataGridView.DataSource = db.GetInventoryList();
              Grid_Load();
            

        }

        private void EditSelectedItemBtn_Click(object sender, EventArgs e)
        {
            string id1 = "";
            //get selected prodID from grid to edit
            foreach (DataGridViewRow row in InventorydataGridView.SelectedRows)
            {

                id1 = row.Cells[0].Value.ToString();
            }

            if (id1 != null)
            {

                Forms.InventoryForms.EditItemForm f = new Forms.InventoryForms.EditItemForm(id1,this);
                f.Show();

            }
            else
            {
                MessageBox.Show("Select row from table to edit");
            }


        }
        private void Tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                String name = ItemSearchTB.Text;
                InventorydataGridView.DataSource = db.SearchInventoryByName(name);
            }
        }

        private void ItemSearchBtn_Click(object sender, EventArgs e)
        {
            String search = ItemSearchTB.Text;
            InventorydataGridView.DataSource = db.SearchInventoryByName(search);

        }

        private void InvClearBtn_Click(object sender, EventArgs e)
        {
            ItemSearchTB.Text = "";
            InventorydataGridView.DataSource = db.GetInventoryList();
        }
    }
}
