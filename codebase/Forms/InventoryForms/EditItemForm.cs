using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoGrocery.Forms.InventoryForms
{
    public partial class EditItemForm : Form
    {
        private string _productname;
        private string _inventorylevel;
        private string _productsize;
        private string _shelfquantity;
        private string _orderamount;
        private List<String> m = new List<string>();
        InventoryForm _inventoryForm;
       
        public EditItemForm(string id, InventoryForm inv)
        {
            _inventoryForm = inv;
            InitializeComponent();
            DatabaseConnection db = new DatabaseConnection();



            try
            {
                int result = Int32.Parse(id);
                m = db.SearchInventoryById(result);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{id}'");
            }

            String ID = m[0];
            _productname = m[1];
            _inventorylevel = m[2];
            _productsize = m[3];
            _shelfquantity = m[4];
            _orderamount = m[5];


            ItemIdTB.Text = ID;
            EditItemNameTB.Text = _productname;
            EditInventoryLevelTB.Text = _inventorylevel;
            EditProdSizeTB.Text = _productsize;
            EditShelfQtyTB.Text = _shelfquantity;
            EditOrderAmountTB.Text = _orderamount;
        }


        private void CancelEditItemBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AcceptEditItemDetailsBtn_Click(object sender, EventArgs e)
        {


            //Set product name
            _productname = EditItemNameTB.Text.ToLower();

            //Set inventory level
            _inventorylevel = EditInventoryLevelTB.Text;


            //Set product size
            _productsize = EditProdSizeTB.Text.ToLower();

            //Set shelf quantity

            _shelfquantity = EditShelfQtyTB.Text;
            //int.Parse(ShelfQuantityTB.Text);


            //Set order amount ++++try catch example for input verification+++++
            try
            {
                _orderamount = EditOrderAmountTB.Text;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Order Amount is not a valid integer");
            }
            
             //+++++++++++change item details here++++++++++++++

           
            
            
            
            
            
            //close and Refresh table
           this.Close();
            _inventoryForm.LoadItemIntoTable();
            

           
        }
    }
}
