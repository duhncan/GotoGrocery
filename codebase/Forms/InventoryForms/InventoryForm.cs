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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            Grid_Load();
            LoadMemberIntoTable();

        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            //creates form to add a new item
            AddItemForm f = new AddItemForm();
            f.Show();
        }
        //inventory table creation
        DataTable dt = new DataTable();
        //method to load table

        private void Grid_Load()
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Inventory level");
            dt.Columns.Add("Product size");
            dt.Columns.Add("Shelf Qty");
            dt.Columns.Add("Order Qty");

            InventorydataGridView.DataSource = dt;

        }
        private void LoadMemberIntoTable()
        {

            /*              TODO
             * +++++++++++++++++++++++++++++++++++
             * change for inventory
             * (highestNumberById?)
            while next item exists return true
            loop -
            method return item info ->
            new member()

            dr[0] = item.name;
            dr[1] = item.size;
            dr[2] = item.ShelfQty;
            dt.Rows.Add(dr);   
            +++++++++++++++++++++++++++++++++++++
             */
            
            //new data row test
            DataRow dr1 = dt.NewRow();
            String id = "10237";
            String prodName = "Beans";
            String inventoryLevel = "3";
            String size = "200ml";
            String ShelfQty = "5";
            String orderQty = "5";

            //rows are created
            dr1[0] = id;
            dr1[1] = prodName;
            dr1[2] = inventoryLevel;
            dr1[3] = size;
            dr1[4] = ShelfQty;
            dr1[5] = orderQty;

            dt.Rows.Add(dr1);

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
                /*                          TODO
                 * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //Search database for ProdID where id1 == memberID
                //^if exists then 
                //open edit form ++++++ pass item Obj through? 
                ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                */
                ////load form to edit member details
                Forms.InventoryForms.EditItemForm f = new Forms.InventoryForms.EditItemForm(id1);
                f.Show();

            }
            else
            {
                MessageBox.Show("Select row from table to edit");
            }
            

        }
    }
}
