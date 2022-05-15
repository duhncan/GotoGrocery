
namespace GotoGrocery
{
    partial class InventoryForm
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
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.InventorydataGridView = new System.Windows.Forms.DataGridView();
            this.EditSelectedItemBtn = new System.Windows.Forms.Button();
            this.inventoryTitle = new System.Windows.Forms.Label();
            this.SearchProdLbl = new System.Windows.Forms.Label();
            this.ItemSearchTB = new System.Windows.Forms.TextBox();
            this.ItemSearchBtn = new System.Windows.Forms.Button();
            this.InvClearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventorydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Location = new System.Drawing.Point(246, 639);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(209, 52);
            this.AddItemBtn.TabIndex = 1;
            this.AddItemBtn.Text = "Add new item";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // InventorydataGridView
            // 
            this.InventorydataGridView.AllowUserToAddRows = false;
            this.InventorydataGridView.AllowUserToDeleteRows = false;
            this.InventorydataGridView.AllowUserToOrderColumns = true;
            this.InventorydataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventorydataGridView.Location = new System.Drawing.Point(182, 186);
            this.InventorydataGridView.MultiSelect = false;
            this.InventorydataGridView.Name = "InventorydataGridView";
            this.InventorydataGridView.ReadOnly = true;
            this.InventorydataGridView.RowHeadersVisible = false;
            this.InventorydataGridView.RowHeadersWidth = 62;
            this.InventorydataGridView.RowTemplate.Height = 28;
            this.InventorydataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InventorydataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventorydataGridView.Size = new System.Drawing.Size(916, 434);
            this.InventorydataGridView.TabIndex = 3;
            // 
            // EditSelectedItemBtn
            // 
            this.EditSelectedItemBtn.Location = new System.Drawing.Point(485, 639);
            this.EditSelectedItemBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditSelectedItemBtn.Name = "EditSelectedItemBtn";
            this.EditSelectedItemBtn.Size = new System.Drawing.Size(212, 52);
            this.EditSelectedItemBtn.TabIndex = 4;
            this.EditSelectedItemBtn.Text = "Edit";
            this.EditSelectedItemBtn.UseVisualStyleBackColor = true;
            this.EditSelectedItemBtn.Click += new System.EventHandler(this.EditSelectedItemBtn_Click);
            // 
            // inventoryTitle
            // 
            this.inventoryTitle.AutoSize = true;
            this.inventoryTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTitle.Location = new System.Drawing.Point(512, 41);
            this.inventoryTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventoryTitle.Name = "inventoryTitle";
            this.inventoryTitle.Size = new System.Drawing.Size(129, 29);
            this.inventoryTitle.TabIndex = 5;
            this.inventoryTitle.Text = "Inventory";
            // 
            // SearchProdLbl
            // 
            this.SearchProdLbl.AutoSize = true;
            this.SearchProdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProdLbl.Location = new System.Drawing.Point(382, 109);
            this.SearchProdLbl.Name = "SearchProdLbl";
            this.SearchProdLbl.Size = new System.Drawing.Size(183, 22);
            this.SearchProdLbl.TabIndex = 6;
            this.SearchProdLbl.Text = "Search Product name";
            // 
            // ItemSearchTB
            // 
            this.ItemSearchTB.Location = new System.Drawing.Point(246, 150);
            this.ItemSearchTB.Name = "ItemSearchTB";
            this.ItemSearchTB.Size = new System.Drawing.Size(485, 26);
            this.ItemSearchTB.TabIndex = 7;
            this.ItemSearchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_KeyDown);
            // 
            // ItemSearchBtn
            // 
            this.ItemSearchBtn.Location = new System.Drawing.Point(760, 146);
            this.ItemSearchBtn.Name = "ItemSearchBtn";
            this.ItemSearchBtn.Size = new System.Drawing.Size(75, 34);
            this.ItemSearchBtn.TabIndex = 8;
            this.ItemSearchBtn.Text = "Search";
            this.ItemSearchBtn.UseVisualStyleBackColor = true;
            this.ItemSearchBtn.Click += new System.EventHandler(this.ItemSearchBtn_Click);
            // 
            // InvClearBtn
            // 
            this.InvClearBtn.Location = new System.Drawing.Point(854, 146);
            this.InvClearBtn.Name = "InvClearBtn";
            this.InvClearBtn.Size = new System.Drawing.Size(75, 34);
            this.InvClearBtn.TabIndex = 9;
            this.InvClearBtn.Text = "Clear";
            this.InvClearBtn.UseVisualStyleBackColor = true;
            this.InvClearBtn.Click += new System.EventHandler(this.InvClearBtn_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 769);
            this.Controls.Add(this.InvClearBtn);
            this.Controls.Add(this.ItemSearchBtn);
            this.Controls.Add(this.ItemSearchTB);
            this.Controls.Add(this.SearchProdLbl);
            this.Controls.Add(this.inventoryTitle);
            this.Controls.Add(this.EditSelectedItemBtn);
            this.Controls.Add(this.InventorydataGridView);
            this.Controls.Add(this.AddItemBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.InventorydataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.DataGridView InventorydataGridView;
        private System.Windows.Forms.Button EditSelectedItemBtn;
        private System.Windows.Forms.Label inventoryTitle;
        private System.Windows.Forms.Label SearchProdLbl;
        private System.Windows.Forms.TextBox ItemSearchTB;
        private System.Windows.Forms.Button ItemSearchBtn;
        private System.Windows.Forms.Button InvClearBtn;
    }
}