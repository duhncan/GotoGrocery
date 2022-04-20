using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class AddItemForm : Form
    {
        //private
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemDetailsBtn_Click(object sender, EventArgs e)
        {
            //new item()
            //get TextBox.Text
            //member.AddMember()

        }

        private void CancelNewItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
