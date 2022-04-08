
namespace InventorySystem.Forms.InventoryForms
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
            this.EditOrderAmount = new System.Windows.Forms.TextBox();
            this.EditShelfQty = new System.Windows.Forms.TextBox();
            this.EditInventoryLevel = new System.Windows.Forms.TextBox();
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
            this.ItemIdTB.Location = new System.Drawing.Point(212, 124);
            this.ItemIdTB.Margin = new System.Windows.Forms.Padding(2);
            this.ItemIdTB.Name = "ItemIdTB";
            this.ItemIdTB.ReadOnly = true;
            this.ItemIdTB.Size = new System.Drawing.Size(249, 20);
            this.ItemIdTB.TabIndex = 41;
            // 
            // EditItemIdLbl
            // 
            this.EditItemIdLbl.AutoSize = true;
            this.EditItemIdLbl.Location = new System.Drawing.Point(87, 127);
            this.EditItemIdLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditItemIdLbl.Name = "EditItemIdLbl";
            this.EditItemIdLbl.Size = new System.Drawing.Size(110, 13);
            this.EditItemIdLbl.TabIndex = 40;
            this.EditItemIdLbl.Text = "Product ID (read-only)";
            // 
            // CancelEditItemBtn
            // 
            this.CancelEditItemBtn.Location = new System.Drawing.Point(140, 342);
            this.CancelEditItemBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CancelEditItemBtn.Name = "CancelEditItemBtn";
            this.CancelEditItemBtn.Size = new System.Drawing.Size(57, 22);
            this.CancelEditItemBtn.TabIndex = 39;
            this.CancelEditItemBtn.Text = "Cancel";
            this.CancelEditItemBtn.UseVisualStyleBackColor = true;
            this.CancelEditItemBtn.Click += new System.EventHandler(this.CancelEditItemBtn_Click);
            // 
            // AcceptEditItemDetailsBtn
            // 
            this.AcceptEditItemDetailsBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AcceptEditItemDetailsBtn.Location = new System.Drawing.Point(390, 342);
            this.AcceptEditItemDetailsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AcceptEditItemDetailsBtn.Name = "AcceptEditItemDetailsBtn";
            this.AcceptEditItemDetailsBtn.Size = new System.Drawing.Size(94, 22);
            this.AcceptEditItemDetailsBtn.TabIndex = 38;
            this.AcceptEditItemDetailsBtn.Text = "Accept";
            this.AcceptEditItemDetailsBtn.UseVisualStyleBackColor = true;
            this.AcceptEditItemDetailsBtn.Click += new System.EventHandler(this.AcceptEditItemDetailsBtn_Click);
            // 
            // EditOrderAmount
            // 
            this.EditOrderAmount.Location = new System.Drawing.Point(212, 298);
            this.EditOrderAmount.Margin = new System.Windows.Forms.Padding(2);
            this.EditOrderAmount.Name = "EditOrderAmount";
            this.EditOrderAmount.Size = new System.Drawing.Size(102, 20);
            this.EditOrderAmount.TabIndex = 36;
            // 
            // EditShelfQty
            // 
            this.EditShelfQty.Location = new System.Drawing.Point(212, 260);
            this.EditShelfQty.Margin = new System.Windows.Forms.Padding(2);
            this.EditShelfQty.Name = "EditShelfQty";
            this.EditShelfQty.Size = new System.Drawing.Size(102, 20);
            this.EditShelfQty.TabIndex = 35;
            // 
            // EditInventoryLevel
            // 
            this.EditInventoryLevel.Location = new System.Drawing.Point(212, 201);
            this.EditInventoryLevel.Margin = new System.Windows.Forms.Padding(2);
            this.EditInventoryLevel.Name = "EditInventoryLevel";
            this.EditInventoryLevel.Size = new System.Drawing.Size(102, 20);
            this.EditInventoryLevel.TabIndex = 34;
            // 
            // EditItemNameTB
            // 
            this.EditItemNameTB.Location = new System.Drawing.Point(212, 166);
            this.EditItemNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.EditItemNameTB.Name = "EditItemNameTB";
            this.EditItemNameTB.Size = new System.Drawing.Size(249, 20);
            this.EditItemNameTB.TabIndex = 33;
            // 
            // EditOrderAmountLbl
            // 
            this.EditOrderAmountLbl.AutoSize = true;
            this.EditOrderAmountLbl.Location = new System.Drawing.Point(110, 301);
            this.EditOrderAmountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditOrderAmountLbl.Name = "EditOrderAmountLbl";
            this.EditOrderAmountLbl.Size = new System.Drawing.Size(71, 13);
            this.EditOrderAmountLbl.TabIndex = 32;
            this.EditOrderAmountLbl.Text = "Order amount";
            // 
            // EditShelfQuantityLbl
            // 
            this.EditShelfQuantityLbl.AutoSize = true;
            this.EditShelfQuantityLbl.Location = new System.Drawing.Point(110, 260);
            this.EditShelfQuantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditShelfQuantityLbl.Name = "EditShelfQuantityLbl";
            this.EditShelfQuantityLbl.Size = new System.Drawing.Size(71, 13);
            this.EditShelfQuantityLbl.TabIndex = 31;
            this.EditShelfQuantityLbl.Text = "Shelf quantity";
            // 
            // EditProdSizeLbl
            // 
            this.EditProdSizeLbl.AutoSize = true;
            this.EditProdSizeLbl.Location = new System.Drawing.Point(110, 232);
            this.EditProdSizeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditProdSizeLbl.Name = "EditProdSizeLbl";
            this.EditProdSizeLbl.Size = new System.Drawing.Size(65, 13);
            this.EditProdSizeLbl.TabIndex = 30;
            this.EditProdSizeLbl.Text = "Product size";
            // 
            // EditInventoryLvlLbl
            // 
            this.EditInventoryLvlLbl.AutoSize = true;
            this.EditInventoryLvlLbl.Location = new System.Drawing.Point(110, 201);
            this.EditInventoryLvlLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditInventoryLvlLbl.Name = "EditInventoryLvlLbl";
            this.EditInventoryLvlLbl.Size = new System.Drawing.Size(76, 13);
            this.EditInventoryLvlLbl.TabIndex = 29;
            this.EditInventoryLvlLbl.Text = "Inventory level";
            // 
            // EditFProdNameLbl
            // 
            this.EditFProdNameLbl.AutoSize = true;
            this.EditFProdNameLbl.Location = new System.Drawing.Point(110, 166);
            this.EditFProdNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditFProdNameLbl.Name = "EditFProdNameLbl";
            this.EditFProdNameLbl.Size = new System.Drawing.Size(73, 13);
            this.EditFProdNameLbl.TabIndex = 28;
            this.EditFProdNameLbl.Text = "Product name";
            // 
            // EditItemTitleLbl
            // 
            this.EditItemTitleLbl.AutoSize = true;
            this.EditItemTitleLbl.Location = new System.Drawing.Point(209, 88);
            this.EditItemTitleLbl.Name = "EditItemTitleLbl";
            this.EditItemTitleLbl.Size = new System.Drawing.Size(81, 13);
            this.EditItemTitleLbl.TabIndex = 27;
            this.EditItemTitleLbl.Text = "Edit Item details";
            // 
            // EditProdSizeTB
            // 
            this.EditProdSizeTB.Location = new System.Drawing.Point(212, 232);
            this.EditProdSizeTB.Margin = new System.Windows.Forms.Padding(2);
            this.EditProdSizeTB.Name = "EditProdSizeTB";
            this.EditProdSizeTB.Size = new System.Drawing.Size(176, 20);
            this.EditProdSizeTB.TabIndex = 42;
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.EditProdSizeTB);
            this.Controls.Add(this.ItemIdTB);
            this.Controls.Add(this.EditItemIdLbl);
            this.Controls.Add(this.CancelEditItemBtn);
            this.Controls.Add(this.AcceptEditItemDetailsBtn);
            this.Controls.Add(this.EditOrderAmount);
            this.Controls.Add(this.EditShelfQty);
            this.Controls.Add(this.EditInventoryLevel);
            this.Controls.Add(this.EditItemNameTB);
            this.Controls.Add(this.EditOrderAmountLbl);
            this.Controls.Add(this.EditShelfQuantityLbl);
            this.Controls.Add(this.EditProdSizeLbl);
            this.Controls.Add(this.EditInventoryLvlLbl);
            this.Controls.Add(this.EditFProdNameLbl);
            this.Controls.Add(this.EditItemTitleLbl);
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
        private System.Windows.Forms.TextBox EditOrderAmount;
        private System.Windows.Forms.TextBox EditShelfQty;
        private System.Windows.Forms.TextBox EditInventoryLevel;
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