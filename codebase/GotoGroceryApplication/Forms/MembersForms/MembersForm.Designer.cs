using System;

namespace GotoGrocery
{
    partial class MembersForm
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
            this.memberTitle = new System.Windows.Forms.Label();
            this.AddMemberBtn = new System.Windows.Forms.Button();
            this.membersdataGridView = new System.Windows.Forms.DataGridView();
            this.EditSelectedMemberBtn = new System.Windows.Forms.Button();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.MembersSearchTB = new System.Windows.Forms.TextBox();
            this.MemberSearchBtn = new System.Windows.Forms.Button();
            this.MemberClearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.membersdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // memberTitle
            // 
            this.memberTitle.AutoSize = true;
            this.memberTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberTitle.Location = new System.Drawing.Point(632, 35);
            this.memberTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberTitle.Name = "memberTitle";
            this.memberTitle.Size = new System.Drawing.Size(122, 29);
            this.memberTitle.TabIndex = 0;
            this.memberTitle.Text = "Members";
            // 
            // AddMemberBtn
            // 
            this.AddMemberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberBtn.Location = new System.Drawing.Point(351, 651);
            this.AddMemberBtn.Name = "AddMemberBtn";
            this.AddMemberBtn.Size = new System.Drawing.Size(209, 52);
            this.AddMemberBtn.TabIndex = 1;
            this.AddMemberBtn.Text = "Add new Member";
            this.AddMemberBtn.UseVisualStyleBackColor = true;
            this.AddMemberBtn.Click += new System.EventHandler(this.AddMemberBtn_Click);
            // 
            // membersdataGridView
            // 
            this.membersdataGridView.AllowUserToAddRows = false;
            this.membersdataGridView.AllowUserToDeleteRows = false;
            this.membersdataGridView.AllowUserToOrderColumns = true;
            this.membersdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersdataGridView.Location = new System.Drawing.Point(256, 180);
            this.membersdataGridView.MultiSelect = false;
            this.membersdataGridView.Name = "membersdataGridView";
            this.membersdataGridView.ReadOnly = true;
            this.membersdataGridView.RowHeadersVisible = false;
            this.membersdataGridView.RowHeadersWidth = 62;
            this.membersdataGridView.RowTemplate.Height = 28;
            this.membersdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.membersdataGridView.Size = new System.Drawing.Size(1228, 434);
            this.membersdataGridView.TabIndex = 2;
            // 
            // EditSelectedMemberBtn
            // 
            this.EditSelectedMemberBtn.Location = new System.Drawing.Point(609, 651);
            this.EditSelectedMemberBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditSelectedMemberBtn.Name = "EditSelectedMemberBtn";
            this.EditSelectedMemberBtn.Size = new System.Drawing.Size(210, 52);
            this.EditSelectedMemberBtn.TabIndex = 3;
            this.EditSelectedMemberBtn.Text = "Edit";
            this.EditSelectedMemberBtn.UseVisualStyleBackColor = true;
            this.EditSelectedMemberBtn.Click += new System.EventHandler(this.EditSelectedMemberBtn_Click);
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLbl.Location = new System.Drawing.Point(402, 104);
            this.SearchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(271, 22);
            this.SearchLbl.TabIndex = 4;
            this.SearchLbl.Text = "Search First Name or Last Name";
            // 
            // MembersSearchTB
            // 
            this.MembersSearchTB.Location = new System.Drawing.Point(358, 140);
            this.MembersSearchTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MembersSearchTB.Name = "MembersSearchTB";
            this.MembersSearchTB.Size = new System.Drawing.Size(477, 26);
            this.MembersSearchTB.TabIndex = 7;
            this.MembersSearchTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_KeyDown);
            // 
            // MemberSearchBtn
            // 
            this.MemberSearchBtn.Location = new System.Drawing.Point(859, 138);
            this.MemberSearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemberSearchBtn.Name = "MemberSearchBtn";
            this.MemberSearchBtn.Size = new System.Drawing.Size(112, 34);
            this.MemberSearchBtn.TabIndex = 8;
            this.MemberSearchBtn.Text = "Search";
            this.MemberSearchBtn.UseVisualStyleBackColor = true;
            this.MemberSearchBtn.Click += new System.EventHandler(this.MemberSearchBtn_Click);
            // 
            // MemberClearBtn
            // 
            this.MemberClearBtn.Location = new System.Drawing.Point(993, 138);
            this.MemberClearBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemberClearBtn.Name = "MemberClearBtn";
            this.MemberClearBtn.Size = new System.Drawing.Size(112, 34);
            this.MemberClearBtn.TabIndex = 9;
            this.MemberClearBtn.Text = "Clear";
            this.MemberClearBtn.UseVisualStyleBackColor = true;
            this.MemberClearBtn.Click += new System.EventHandler(this.MemberClearBtn_Click);
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 900);
            this.Controls.Add(this.MemberClearBtn);
            this.Controls.Add(this.MemberSearchBtn);
            this.Controls.Add(this.MembersSearchTB);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.EditSelectedMemberBtn);
            this.Controls.Add(this.membersdataGridView);
            this.Controls.Add(this.AddMemberBtn);
            this.Controls.Add(this.memberTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MembersForm";
            this.Text = "InventoryManager";
            ((System.ComponentModel.ISupportInitialize)(this.membersdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Label memberTitle;
        private System.Windows.Forms.Button AddMemberBtn;
        private System.Windows.Forms.DataGridView membersdataGridView;
        private System.Windows.Forms.Button EditSelectedMemberBtn;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.TextBox MembersSearchTB;
        private System.Windows.Forms.Button MemberSearchBtn;
        private System.Windows.Forms.Button MemberClearBtn;
    }
}