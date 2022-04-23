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
        

        //private
        public AddItemForm()
        {
            InitializeComponent();
            inv = new Inventory();
        }

        private void AddItemDetailsBtn_Click(object sender, EventArgs e)
        {
            //Set product name
            _productname = ItemNameTB.Text;
            
            //Set inventory level
            try
            {
                _inventorylevel = Int32.Parse(InventoryLevelTB.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Inventory Level is not a valid integer");
            }

            //Set product size
            _productsize = ItemSizeTB.Text;

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

            //expand this to a switch case to determine which input failed
            if (inv.validateProduct(_productname, _inventorylevel, _productsize, _shelfquantity, _orderamount))
            {
                //Make a form pop up saying item added successfully and close add new item form
            }
            else
            {
                //Make a form pop up saying could not add item and close new item form
            }

        }

        private void CancelNewItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
