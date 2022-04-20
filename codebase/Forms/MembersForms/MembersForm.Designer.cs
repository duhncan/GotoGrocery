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
            this.SearchByIDCheck = new System.Windows.Forms.CheckBox();
            this.SearchByEmailCheck = new System.Windows.Forms.CheckBox();
            this.MembersSearchTB = new System.Windows.Forms.TextBox();
            this.MemberSearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.membersdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // memberTitle
            // 
            this.memberTitle.AutoSize = true;
            this.memberTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberTitle.Location = new System.Drawing.Point(482, 29);
            this.memberTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberTitle.Name = "memberTitle";
            this.memberTitle.Size = new System.Drawing.Size(122, 29);
            this.memberTitle.TabIndex = 0;
            this.memberTitle.Text = "Members";
            // 
            // AddMemberBtn
            // 
            this.AddMemberBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberBtn.Location = new System.Drawing.Point(50, 231);
            this.AddMemberBtn.Name = "AddMemberBtn";
            this.AddMemberBtn.Size = new System.Drawing.Size(230, 60);
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
            this.membersdataGridView.Location = new System.Drawing.Point(332, 231);
            this.membersdataGridView.MultiSelect = false;
            this.membersdataGridView.Name = "membersdataGridView";
            this.membersdataGridView.ReadOnly = true;
            this.membersdataGridView.RowHeadersWidth = 62;
            this.membersdataGridView.RowTemplate.Height = 28;
            this.membersdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.membersdataGridView.Size = new System.Drawing.Size(948, 434);
            this.membersdataGridView.TabIndex = 2;
            // 
            // EditSelectedMemberBtn
            // 
            this.EditSelectedMemberBtn.Location = new System.Drawing.Point(392, 720);
            this.EditSelectedMemberBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditSelectedMemberBtn.Name = "EditSelectedMemberBtn";
            this.EditSelectedMemberBtn.Size = new System.Drawing.Size(112, 35);
            this.EditSelectedMemberBtn.TabIndex = 3;
            this.EditSelectedMemberBtn.Text = "Edit";
            this.EditSelectedMemberBtn.UseVisualStyleBackColor = true;
            this.EditSelectedMemberBtn.Click += new System.EventHandler(this.EditSelectedMemberBtn_Click);
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLbl.Location = new System.Drawing.Point(834, 128);
            this.SearchLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(75, 25);
            this.SearchLbl.TabIndex = 4;
            this.SearchLbl.Text = "Search";
            // 
            // SearchByIDCheck
            // 
            this.SearchByIDCheck.AutoSize = true;
            this.SearchByIDCheck.Checked = true;
            this.SearchByIDCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchByIDCheck.Location = new System.Drawing.Point(500, 165);
            this.SearchByIDCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchByIDCheck.Name = "SearchByIDCheck";
            this.SearchByIDCheck.Size = new System.Drawing.Size(52, 24);
            this.SearchByIDCheck.TabIndex = 5;
            this.SearchByIDCheck.Text = "ID";
            this.SearchByIDCheck.UseVisualStyleBackColor = true;
            this.SearchByIDCheck.Click += new System.EventHandler(this.StatusIDCheck_CheckedChanged);
            // 
            // SearchByEmailCheck
            // 
            this.SearchByEmailCheck.AutoSize = true;
            this.SearchByEmailCheck.Location = new System.Drawing.Point(598, 165);
            this.SearchByEmailCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchByEmailCheck.Name = "SearchByEmailCheck";
            this.SearchByEmailCheck.Size = new System.Drawing.Size(74, 24);
            this.SearchByEmailCheck.TabIndex = 6;
            this.SearchByEmailCheck.Text = "Email";
            this.SearchByEmailCheck.UseVisualStyleBackColor = true;
            this.SearchByEmailCheck.Click += new System.EventHandler(this.StatusEmailCheck_CheckedChanged);
            // 
            // MembersSearchTB
            // 
            this.MembersSearchTB.Location = new System.Drawing.Point(712, 157);
            this.MembersSearchTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MembersSearchTB.Name = "MembersSearchTB";
            this.MembersSearchTB.Size = new System.Drawing.Size(394, 26);
            this.MembersSearchTB.TabIndex = 7;
            // 
            // MemberSearchBtn
            // 
            this.MemberSearchBtn.Location = new System.Drawing.Point(1148, 157);
            this.MemberSearchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemberSearchBtn.Name = "MemberSearchBtn";
            this.MemberSearchBtn.Size = new System.Drawing.Size(112, 34);
            this.MemberSearchBtn.TabIndex = 8;
            this.MemberSearchBtn.Text = "Go";
            this.MemberSearchBtn.UseVisualStyleBackColor = true;
            this.MemberSearchBtn.Click += new System.EventHandler(this.MemberSearchBtn_Click);
            // 
            // MembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 900);
            this.Controls.Add(this.MemberSearchBtn);
            this.Controls.Add(this.MembersSearchTB);
            this.Controls.Add(this.SearchByEmailCheck);
            this.Controls.Add(this.SearchByIDCheck);
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
        private System.Windows.Forms.CheckBox SearchByIDCheck;
        private System.Windows.Forms.CheckBox SearchByEmailCheck;
        private System.Windows.Forms.TextBox MembersSearchTB;
        private System.Windows.Forms.Button MemberSearchBtn;
    }
}