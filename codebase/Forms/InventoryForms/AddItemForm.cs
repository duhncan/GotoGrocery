using GotoGrocery.GoToGrocery;
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
    public partial class AddItemForm : Form
    {
        private string _productname;
        private int _inventorylevel;
        private string _productsize;
        private int _shelfquantity;
        private int _orderamount;
        private Inventory inv;

        private InventoryForm _inventoryForm;

        public AddItemForm()
        {
        }

        //private
        public AddItemForm(InventoryForm inventoryForm):this()
        {
            InitializeComponent();
            this._inventoryForm = inventoryForm;
            inv = new Inventory();
        }

        private void AddItemDetailsBtn_Click(object sender, EventArgs e)
        {
            //Set product name
            _productname = ItemNameTB.Text.ToLower();

            //Set inventory level
            try
            {
                _inventorylevel = int.Parse(InventoryLevelTB.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Inventory Level is not a valid integer");

            }

            //Set product size
            _productsize = ItemSizeTB.Text.ToLower();

            //Set shelf quantity
            try
            {
                _shelfquantity = int.Parse(ShelfQuantityTB.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Shelf Quantity is not a valid integer");
            }

            //Set order amount
            try
            {
                _orderamount = int.Parse(OrderAmountTB.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Order Amount is not a valid integer");
            }


            switch (inv.validateProduct(_productname, _inventorylevel, _productsize, _shelfquantity, _orderamount))
            {
                case 0:
                    MessageBox.Show("Item added successfully");
                    Console.WriteLine("Item added successfully");
                    this.Close();
                    break;

                case 1:
                    MessageBox.Show("Product name is not valid");
                    Console.WriteLine("Product name is not valid");
                    break;

                case 2:
                    MessageBox.Show("Inventory level is not valid");
                    Console.WriteLine("Inventory level is not valid");
                    break;

                case 3:
                    MessageBox.Show("Product size is not valid");
                    Console.WriteLine("Product size is not valid");
                    break;

                case 4:
                    MessageBox.Show("Shelf quantity is not valid");
                    Console.WriteLine("Shelf quantity is not valid");
                    break;

                case 5:
                    MessageBox.Show("Order amount is not valid");
                    Console.WriteLine("Order amount is not valid");
                    break;
                    
                default:
                    MessageBox.Show("Item could not be added to database");
                    Console.WriteLine("Item could not be added to database");
                    break;
            }

            _inventoryForm.LoadItemIntoTable();


        }

        private void CancelNewItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
