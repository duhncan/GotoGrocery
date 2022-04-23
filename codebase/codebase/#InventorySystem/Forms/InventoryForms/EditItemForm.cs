using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Forms.InventoryForms
{
    public partial class EditItemForm : Form
    {
        public EditItemForm(string id)//change to member ?
        {
            InitializeComponent();
            //InsertItemDetails(ID);+++unused, implement with working inventory Obj++++
            String ID = id;

            String prodName = "Beans";
            String inventoryLevel = "3";
            String size = "200ml";
            String shelfQty = "5";
            String orderAmount = "5";


            ItemIdTB.Text = ID;
            EditItemNameTB.Text = prodName;
            EditInventoryLevel.Text = inventoryLevel;
            EditProdSizeTB.Text = size;
            EditShelfQty.Text = shelfQty;
            EditOrderAmount.Text = orderAmount;
        }


        private void CancelEditItemBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////  private void InsertItemDetails(String id)//Member?
        //  {
        //      //member.getMember()
        //      ItemIdTB.Text = id;
        //      EditItemNameTB.Text = name;
        //      // TODO
        //  }

        private void AcceptEditItemDetailsBtn_Click(object sender, EventArgs e)
        {
            //TODO send updated item details to method
        }
    }
}
