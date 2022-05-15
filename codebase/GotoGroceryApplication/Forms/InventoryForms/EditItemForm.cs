using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoToGrocery;

namespace GotoGrocery.Forms.InventoryForms
{
    public partial class EditItemForm : Form
    {
        private string _productname;
        private string _newproductname;
        private int _inventorylevel;
        private string _productsize;
        private int _shelfquantity;
        private int _orderamount;
        private int _errorcode;
        private List<String> m = new List<string>();
        private Inventory _inventory;
        private InventoryForm _inventoryForm;
        private DatabaseConnection db;
       
        public EditItemForm(string id, InventoryForm inv)
        {
            InitializeComponent();
            db = new DatabaseConnection();
            _inventory = new Inventory();
            _inventoryForm = inv;

            //try catch to get lsit of item data
            try
            {
                int result = Int32.Parse(id);
                m = db.SearchInventoryById(result);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{id}'");
            }
            //get variables from list
            String ID = m[0];
            _productname = m[1];
            _inventorylevel = int.Parse(m[2]);
            _productsize = m[3];
            _shelfquantity = int.Parse(m[4]);
            _orderamount = int.Parse(m[5]);

            ItemIdTB.Text = ID;
            EditItemNameTB.Text = _productname;
            EditInventoryLevelTB.Text = _inventorylevel.ToString();
            EditProdSizeTB.Text = _productsize;
            EditShelfQtyTB.Text = _shelfquantity.ToString();
            EditOrderAmountTB.Text = _orderamount.ToString();


        }


        private void CancelEditItemBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AcceptEditItemDetailsBtn_Click(object sender, EventArgs e)
        {
            _errorcode = _inventory.validateProduct(EditItemNameTB.Text, EditInventoryLevelTB.Text, EditProdSizeTB.Text, EditShelfQtyTB.Text, EditOrderAmountTB.Text);

            //Set product name
            _newproductname = EditItemNameTB.Text.ToLower();

            //Set inventory level
            try
            {
                _inventorylevel = int.Parse(EditInventoryLevelTB.Text);
            }
            catch (FormatException)
            {
                _errorcode = 2;
            }

            //Set product size
            _productsize = EditProdSizeTB.Text.ToLower();

            //Set shelf quantity
            try
            {
                _shelfquantity = int.Parse(EditShelfQtyTB.Text);
            }
            catch (FormatException)
            {
                _errorcode = 4;
            }

            //Set order amount
            try
            {
                _orderamount = int.Parse(EditOrderAmountTB.Text);
            }
            catch (FormatException)
            {
                _errorcode = 5;
            }

            switch (_errorcode)
            {
                case 0:
                    //Fields that can be updated: product_name, inventory_level, product_size, shelf_quantity, order_amount
                    //UpdateProduct(_productname, field to update, value)
                    db.UpdateProduct(_productname, "product_name", _newproductname);
                    db.UpdateProduct(_newproductname, "inventory_level", _inventorylevel.ToString()); 
                    db.UpdateProduct(_newproductname, "product_size", _productsize);
                    db.UpdateProduct(_newproductname, "shelf_quantity", _shelfquantity.ToString());
                    db.UpdateProduct(_newproductname, "order_amount", _orderamount.ToString());

                    MessageBox.Show("Item edited successfully");
                    //Console.WriteLine("Item edited successfully");
                    this.Close();

                    //close and Refresh table
                    this.Close();
                    _inventoryForm.LoadItemIntoTable();
                    break;

                case 1:
                    MessageBox.Show("Product name is not valid");
                    //Console.WriteLine("Product name is not valid");
                    break;

                case 2:
                    MessageBox.Show("Inventory level is not valid");
                    //Console.WriteLine("Inventory level is not valid");
                    break;

                case 3:
                    MessageBox.Show("Product size is not valid");
                    //Console.WriteLine("Product size is not valid");
                    break;

                case 4:
                    MessageBox.Show("Shelf quantity is not valid");
                    //Console.WriteLine("Shelf quantity is not valid");
                    break;

                case 5:
                    MessageBox.Show("Order amount is not valid");
                    //Console.WriteLine("Order amount is not valid");
                    break;

                default:
                    MessageBox.Show("Item could not be added to database");
                    //Console.WriteLine("Item could not be added to database");
                    break;
            }           
        }
    }
}
