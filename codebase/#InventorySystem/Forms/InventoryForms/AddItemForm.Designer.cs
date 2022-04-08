
namespace InventorySystem
{
    partial class AddItemForm
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
            this.AddProductTitleLbl = new System.Windows.Forms.Label();
            this.CancelNewMember = new System.Windows.Forms.Button();
            this.AddMemberDetailsBtn = new System.Windows.Forms.Button();
            this.OrderAmountTB = new System.Windows.Forms.TextBox();
            this.ShelfQuantityTB = new System.Windows.Forms.TextBox();
            this.ItemSizeTB = new System.Windows.Forms.TextBox();
            this.ItemNameTB = new System.Windows.Forms.TextBox();
            this.InventoryLevelLbl = new System.Windows.Forms.Label();
            this.ItemSizeLbl = new System.Windows.Forms.Label();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.InventoryLevelTB = new System.Windows.Forms.TextBox();
            this.ShelfQuantityLbl = new System.Windows.Forms.Label();
            this.OrderAmountLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddProductTitleLbl
            // 
            this.AddProductTitleLbl.AutoSize = true;
            this.AddProductTitleLbl.Location = new System.Drawing.Point(227, 26);
            this.AddProductTitleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductTitleLbl.Name = "AddProductTitleLbl";
            this.AddProductTitleLbl.Size = new System.Drawing.Size(97, 13);
            this.AddProductTitleLbl.TabIndex = 26;
            this.AddProductTitleLbl.Text = "Enter New Product";
            // 
            // CancelNewMember
            // 
            this.CancelNewMember.Location = new System.Drawing.Point(109, 245);
            this.CancelNewMember.Margin = new System.Windows.Forms.Padding(2);
            this.CancelNewMember.Name = "CancelNewMember";
            this.CancelNewMember.Size = new System.Drawing.Size(57, 22);
            this.CancelNewMember.TabIndex = 25;
            this.CancelNewMember.Text = "Cancel";
            this.CancelNewMember.UseVisualStyleBackColor = true;
            this.CancelNewMember.Click += new System.EventHandler(this.CancelNewItem_Click);
            // 
            // AddMemberDetailsBtn
            // 
            this.AddMemberDetailsBtn.Location = new System.Drawing.Point(360, 245);
            this.AddMemberDetailsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddMemberDetailsBtn.Name = "AddMemberDetailsBtn";
            this.AddMemberDetailsBtn.Size = new System.Drawing.Size(94, 22);
            this.AddMemberDetailsBtn.TabIndex = 24;
            this.AddMemberDetailsBtn.Text = "Add Member";
            this.AddMemberDetailsBtn.UseVisualStyleBackColor = true;
            this.AddMemberDetailsBtn.Click += new System.EventHandler(this.AddItemDetailsBtn_Click);
            // 
            // OrderAmountTB
            // 
            this.OrderAmountTB.Location = new System.Drawing.Point(181, 201);
            this.OrderAmountTB.Margin = new System.Windows.Forms.Padding(2);
            this.OrderAmountTB.Name = "OrderAmountTB";
            this.OrderAmountTB.Size = new System.Drawing.Size(249, 20);
            this.OrderAmountTB.TabIndex = 22;
            // 
            // ShelfQuantityTB
            // 
            this.ShelfQuantityTB.Location = new System.Drawing.Point(181, 164);
            this.ShelfQuantityTB.Margin = new System.Windows.Forms.Padding(2);
            this.ShelfQuantityTB.Name = "ShelfQuantityTB";
            this.ShelfQuantityTB.Size = new System.Drawing.Size(144, 20);
            this.ShelfQuantityTB.TabIndex = 21;
            // 
            // ItemSizeTB
            // 
            this.ItemSizeTB.Location = new System.Drawing.Point(183, 133);
            this.ItemSizeTB.Margin = new System.Windows.Forms.Padding(2);
            this.ItemSizeTB.Name = "ItemSizeTB";
            this.ItemSizeTB.Size = new System.Drawing.Size(106, 20);
            this.ItemSizeTB.TabIndex = 20;
            // 
            // ItemNameTB
            // 
            this.ItemNameTB.Location = new System.Drawing.Point(181, 70);
            this.ItemNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.ItemNameTB.Name = "ItemNameTB";
            this.ItemNameTB.Size = new System.Drawing.Size(249, 20);
            this.ItemNameTB.TabIndex = 19;
            // 
            // InventoryLevelLbl
            // 
            this.InventoryLevelLbl.AutoSize = true;
            this.InventoryLevelLbl.Location = new System.Drawing.Point(76, 106);
            this.InventoryLevelLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InventoryLevelLbl.Name = "InventoryLevelLbl";
            this.InventoryLevelLbl.Size = new System.Drawing.Size(80, 13);
            this.InventoryLevelLbl.TabIndex = 16;
            this.InventoryLevelLbl.Text = "Inventory Level";
            // 
            // ItemSizeLbl
            // 
            this.ItemSizeLbl.AutoSize = true;
            this.ItemSizeLbl.Location = new System.Drawing.Point(25, 133);
            this.ItemSizeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ItemSizeLbl.Name = "ItemSizeLbl";
            this.ItemSizeLbl.Size = new System.Drawing.Size(157, 13);
            this.ItemSizeLbl.TabIndex = 15;
            this.ItemSizeLbl.Text = "Size of Product (e.g. ml, cm, kg)";
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Location = new System.Drawing.Point(79, 70);
            this.ProductNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(75, 13);
            this.ProductNameLbl.TabIndex = 14;
            this.ProductNameLbl.Text = "Product Name";
            // 
            // InventoryLevelTB
            // 
            this.InventoryLevelTB.Location = new System.Drawing.Point(181, 104);
            this.InventoryLevelTB.Margin = new System.Windows.Forms.Padding(2);
            this.InventoryLevelTB.Name = "InventoryLevelTB";
            this.InventoryLevelTB.Size = new System.Drawing.Size(122, 20);
            this.InventoryLevelTB.TabIndex = 27;
            // 
            // ShelfQuantityLbl
            // 
            this.ShelfQuantityLbl.AutoSize = true;
            this.ShelfQuantityLbl.Location = new System.Drawing.Point(76, 166);
            this.ShelfQuantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShelfQuantityLbl.Name = "ShelfQuantityLbl";
            this.ShelfQuantityLbl.Size = new System.Drawing.Size(73, 13);
            this.ShelfQuantityLbl.TabIndex = 28;
            this.ShelfQuantityLbl.Text = "Shelf Quantity";
            // 
            // OrderAmountLbl
            // 
            this.OrderAmountLbl.AutoSize = true;
            this.OrderAmountLbl.Location = new System.Drawing.Point(76, 201);
            this.OrderAmountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderAmountLbl.Name = "OrderAmountLbl";
            this.OrderAmountLbl.Size = new System.Drawing.Size(72, 13);
            this.OrderAmountLbl.TabIndex = 29;
            this.OrderAmountLbl.Text = "Order Amount";
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.OrderAmountLbl);
            this.Controls.Add(this.ShelfQuantityLbl);
            this.Controls.Add(this.InventoryLevelTB);
            this.Controls.Add(this.AddProductTitleLbl);
            this.Controls.Add(this.CancelNewMember);
            this.Controls.Add(this.AddMemberDetailsBtn);
            this.Controls.Add(this.OrderAmountTB);
            this.Controls.Add(this.ShelfQuantityTB);
            this.Controls.Add(this.ItemSizeTB);
            this.Controls.Add(this.ItemNameTB);
            this.Controls.Add(this.InventoryLevelLbl);
            this.Controls.Add(this.ItemSizeLbl);
            this.Controls.Add(this.ProductNameLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductTitleLbl;
        private System.Windows.Forms.Button CancelNewMember;
        private System.Windows.Forms.Button AddMemberDetailsBtn;
        private System.Windows.Forms.TextBox OrderAmountTB;
        private System.Windows.Forms.TextBox ShelfQuantityTB;
        private System.Windows.Forms.TextBox ItemSizeTB;
        private System.Windows.Forms.TextBox ItemNameTB;
        private System.Windows.Forms.Label InventoryLevelLbl;
        private System.Windows.Forms.Label ItemSizeLbl;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.TextBox InventoryLevelTB;
        private System.Windows.Forms.Label ShelfQuantityLbl;
        private System.Windows.Forms.Label OrderAmountLbl;
    }
}