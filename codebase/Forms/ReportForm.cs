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
            /*//OpenFileDialog ofd = new OpenFileDialog();

            //ofd.Filter = "Text file(*.txt)|*.txt";


            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    string dirLocationString = ofd.FileName;
            //}

            string selectedPath = "";

            Thread t = new Thread((ThreadStart)(() => {
                FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog();

                // saveFileDialog1.Filter = "Text file(*.txt)|*.txt";
                //  saveFileDialog1.FilterIndex = 2;
               // FolderBrowserDialog.RestoreDirectory = true;

                if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = FolderBrowserDialog.SelectedPath;
                }
            }));
                
            // Run your code from a thread that joins the STA Thread
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            */
            db.ExportInventoryReport();
        }
    }
}
