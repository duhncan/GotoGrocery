
namespace GotoGrocery.Forms.InventoryForms
{
    partial class EditItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemIdTB = new System.Windows.Forms.TextBox();
            this.EditItemIdLbl = new System.Windows.Forms.Label();
            this.CancelEditItemBtn = new System.Windows.Forms.Button();
            this.AcceptEditItemDetailsBtn = new System.Windows.Forms.Button();
            this.EditOrderAmountTB = new System.Windows.Forms.TextBox();
            this.EditShelfQtyTB = new System.Windows.Forms.TextBox();
            this.EditInventoryLevelTB = new System.Windows.Forms.TextBox();
            this.EditItemNameTB = new System.Windows.Forms.TextBox();
            this.EditOrderAmountLbl = new System.Windows.Forms.Label();
            this.EditShelfQuantityLbl = new System.Windows.Forms.Label();
            this.EditProdSizeLbl = new System.Windows.Forms.Label();
            this.EditInventoryLvlLbl = new System.Windows.Forms.Label();
            this.EditFProdNameLbl = new System.Windows.Forms.Label();
            this.EditItemTitleLbl = new System.Windows.Forms.Label();
            this.EditProdSizeTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ItemIdTB
            // 
            this.ItemIdTB.Location = new System.Drawing.Point(318, 119);
            this.ItemIdTB.Name = "ItemIdTB";
            this.ItemIdTB.ReadOnly = true;
            this.ItemIdTB.Size = new System.Drawing.Size(372, 26);
            this.ItemIdTB.TabIndex = 41;
            // 
            // EditItemIdLbl
            // 
            this.EditItemIdLbl.AutoSize = true;
            this.EditItemIdLbl.Location = new System.Drawing.Point(130, 123);
            this.EditItemIdLbl.Name = "EditItemIdLbl";
            this.EditItemIdLbl.Size = new System.Drawing.Size(164, 20);
            this.EditItemIdLbl.TabIndex = 40;
            this.EditItemIdLbl.Text = "Product ID (read-only)";
            // 
            // CancelEditItemBtn
            // 
            this.CancelEditItemBtn.Location = new System.Drawing.Point(210, 526);
            this.CancelEditItemBtn.Name = "CancelEditItemBtn";
            this.CancelEditItemBtn.Size = new System.Drawing.Size(86, 34);
            this.CancelEditItemBtn.TabIndex = 39;
            this.CancelEditItemBtn.Text = "Cancel";
            this.CancelEditItemBtn.UseVisualStyleBackColor = true;
            this.CancelEditItemBtn.Click += new System.EventHandler(this.CancelEditItemBtn_Click);
            // 
            // AcceptEditItemDetailsBtn
            // 
            this.AcceptEditItemDetailsBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AcceptEditItemDetailsBtn.Location = new System.Drawing.Point(585, 526);
            this.AcceptEditItemDetailsBtn.Name = "AcceptEditItemDetailsBtn";
            this.AcceptEditItemDetailsBtn.Size = new System.Drawing.Size(141, 34);
            this.AcceptEditItemDetailsBtn.TabIndex = 38;
            this.AcceptEditItemDetailsBtn.Text = "Accept";
            this.AcceptEditItemDetailsBtn.UseVisualStyleBackColor = true;
            this.AcceptEditItemDetailsBtn.Click += new System.EventHandler(this.AcceptEditItemDetailsBtn_Click);
            // 
            // EditOrderAmountTB
            // 
            this.EditOrderAmountTB.Location = new System.Drawing.Point(318, 386);
            this.EditOrderAmountTB.Name = "EditOrderAmountTB";
            this.EditOrderAmountTB.Size = new System.Drawing.Size(151, 26);
            this.EditOrderAmountTB.TabIndex = 36;
            // 
            // EditShelfQtyTB
            // 
            this.EditShelfQtyTB.Location = new System.Drawing.Point(318, 328);
            this.EditShelfQtyTB.Name = "EditShelfQtyTB";
            this.EditShelfQtyTB.Size = new System.Drawing.Size(151, 26);
            this.EditShelfQtyTB.TabIndex = 35;
            // 
            // EditInventoryLevelTB
            // 
            this.EditInventoryLevelTB.Location = new System.Drawing.Point(318, 237);
            this.EditInventoryLevelTB.Name = "EditInventoryLevelTB";
            this.EditInventoryLevelTB.Size = new System.Drawing.Size(151, 26);
            this.EditInventoryLevelTB.TabIndex = 34;
            // 
            // EditItemNameTB
            // 
            this.EditItemNameTB.Location = new System.Drawing.Point(318, 183);
            this.EditItemNameTB.Name = "EditItemNameTB";
            this.EditItemNameTB.Size = new System.Drawing.Size(372, 26);
            this.EditItemNameTB.TabIndex = 33;
            // 
            // EditOrderAmountLbl
            // 
            this.EditOrderAmountLbl.AutoSize = true;
            this.EditOrderAmountLbl.Location = new System.Drawing.Point(165, 391);
            this.EditOrderAmountLbl.Name = "EditOrderAmountLbl";
            this.EditOrderAmountLbl.Size = new System.Drawing.Size(107, 20);
            this.EditOrderAmountLbl.TabIndex = 32;
            this.EditOrderAmountLbl.Text = "Order amount";
            // 
            // EditShelfQuantityLbl
            // 
            this.EditShelfQuantityLbl.AutoSize = true;
            this.EditShelfQuantityLbl.Location = new System.Drawing.Point(165, 328);
            this.EditShelfQuantityLbl.Name = "EditShelfQuantityLbl";
            this.EditShelfQuantityLbl.Size = new System.Drawing.Size(106, 20);
            this.EditShelfQuantityLbl.TabIndex = 31;
            this.EditShelfQuantityLbl.Text = "Shelf quantity";
            // 
            // EditProdSizeLbl
            // 
            this.EditProdSizeLbl.AutoSize = true;
            this.EditProdSizeLbl.Location = new System.Drawing.Point(165, 285);
            this.EditProdSizeLbl.Name = "EditProdSizeLbl";
            this.EditProdSizeLbl.Size = new System.Drawing.Size(96, 20);
            this.EditProdSizeLbl.TabIndex = 30;
            this.EditProdSizeLbl.Text = "Product size";
            // 
            // EditInventoryLvlLbl
            // 
            this.EditInventoryLvlLbl.AutoSize = true;
            this.EditInventoryLvlLbl.Location = new System.Drawing.Point(165, 237);
            this.EditInventoryLvlLbl.Name = "EditInventoryLvlLbl";
            this.EditInventoryLvlLbl.Size = new System.Drawing.Size(109, 20);
            this.EditInventoryLvlLbl.TabIndex = 29;
            this.EditInventoryLvlLbl.Text = "Inventory level";
            // 
            // EditFProdNameLbl
            // 
            this.EditFProdNameLbl.AutoSize = true;
            this.EditFProdNameLbl.Location = new System.Drawing.Point(165, 183);
            this.EditFProdNameLbl.Name = "EditFProdNameLbl";
            this.EditFProdNameLbl.Size = new System.Drawing.Size(108, 20);
            this.EditFProdNameLbl.TabIndex = 28;
            this.EditFProdNameLbl.Text = "Product name";
            // 
            // EditItemTitleLbl
            // 
            this.EditItemTitleLbl.AutoSize = true;
            this.EditItemTitleLbl.Location = new System.Drawing.Point(314, 68);
            this.EditItemTitleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditItemTitleLbl.Name = "EditItemTitleLbl";
            this.EditItemTitleLbl.Size = new System.Drawing.Size(123, 20);
            this.EditItemTitleLbl.TabIndex = 27;
            this.EditItemTitleLbl.Text = "Edit Item details";
            // 
            // EditProdSizeTB
            // 
            this.EditProdSizeTB.Location = new System.Drawing.Point(318, 285);
            this.EditProdSizeTB.Name = "EditProdSizeTB";
            this.EditProdSizeTB.Size = new System.Drawing.Size(262, 26);
            this.EditProdSizeTB.TabIndex = 42;
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 692);
            this.Controls.Add(this.EditProdSizeTB);
            this.Controls.Add(this.ItemIdTB);
            this.Controls.Add(this.EditItemIdLbl);
            this.Controls.Add(this.CancelEditItemBtn);
            this.Controls.Add(this.AcceptEditItemDetailsBtn);
            this.Controls.Add(this.EditOrderAmountTB);
            this.Controls.Add(this.EditShelfQtyTB);
            this.Controls.Add(this.EditInventoryLevelTB);
            this.Controls.Add(this.EditItemNameTB);
            this.Controls.Add(this.EditOrderAmountLbl);
            this.Controls.Add(this.EditShelfQuantityLbl);
            this.Controls.Add(this.EditProdSizeLbl);
            this.Controls.Add(this.EditInventoryLvlLbl);
            this.Controls.Add(this.EditFProdNameLbl);
            this.Controls.Add(this.EditItemTitleLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemIdTB;
        private System.Windows.Forms.Label EditItemIdLbl;
        private System.Windows.Forms.Button CancelEditItemBtn;
        private System.Windows.Forms.Button AcceptEditItemDetailsBtn;
        private System.Windows.Forms.TextBox EditOrderAmountTB;
        private System.Windows.Forms.TextBox EditShelfQtyTB;
        private System.Windows.Forms.TextBox EditInventoryLevelTB;
        private System.Windows.Forms.TextBox EditItemNameTB;
        private System.Windows.Forms.Label EditOrderAmountLbl;
        private System.Windows.Forms.Label EditShelfQuantityLbl;
        private System.Windows.Forms.Label EditProdSizeLbl;
        private System.Windows.Forms.Label EditInventoryLvlLbl;
        private System.Windows.Forms.Label EditFProdNameLbl;
        private System.Windows.Forms.Label EditItemTitleLbl;
        private System.Windows.Forms.TextBox EditProdSizeTB;
    }
}