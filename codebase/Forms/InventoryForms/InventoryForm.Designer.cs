
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
            ((System.ComponentModel.ISupportInitialize)(this.InventorydataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Location = new System.Drawing.Point(50, 231);
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
            this.InventorydataGridView.Location = new System.Drawing.Point(334, 191);
            this.InventorydataGridView.MultiSelect = false;
            this.InventorydataGridView.Name = "InventorydataGridView";
            this.InventorydataGridView.ReadOnly = true;
            this.InventorydataGridView.RowHeadersWidth = 62;
            this.InventorydataGridView.RowTemplate.Height = 28;
            this.InventorydataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventorydataGridView.Size = new System.Drawing.Size(948, 434);
            this.InventorydataGridView.TabIndex = 3;
            // 
            // EditSelectedItemBtn
            // 
            this.EditSelectedItemBtn.Location = new System.Drawing.Point(418, 661);
            this.EditSelectedItemBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditSelectedItemBtn.Name = "EditSelectedItemBtn";
            this.EditSelectedItemBtn.Size = new System.Drawing.Size(112, 35);
            this.EditSelectedItemBtn.TabIndex = 4;
            this.EditSelectedItemBtn.Text = "Edit";
            this.EditSelectedItemBtn.UseVisualStyleBackColor = true;
            this.EditSelectedItemBtn.Click += new System.EventHandler(this.EditSelectedItemBtn_Click);
            // 
            // inventoryTitle
            // 
            this.inventoryTitle.AutoSize = true;
            this.inventoryTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTitle.Location = new System.Drawing.Point(482, 29);
            this.inventoryTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inventoryTitle.Name = "inventoryTitle";
            this.inventoryTitle.Size = new System.Drawing.Size(129, 29);
            this.inventoryTitle.TabIndex = 5;
            this.inventoryTitle.Text = "Inventory";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 769);
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
    }
}