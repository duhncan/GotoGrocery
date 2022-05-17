using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotoGrocery.Forms
{
    public partial class ReportForm : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public ReportForm()
        {
            InitializeComponent();
        }

        private void SaveReport_Click(object sender, EventArgs e)
        {
            db.ExportInventoryReport();
            MessageBox.Show("Report exported to C:\\CSV\\data.csv");
        }

    }
}
