
namespace GotoGrocery.Forms.MembersForms
{
    partial class EditMemberForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CancelEditMemberBtn = new System.Windows.Forms.Button();
            this.AcceptEditMemberDetailsBtn = new System.Windows.Forms.Button();
            this.EditDOBInput = new System.Windows.Forms.DateTimePicker();
            this.EditEmailTB = new System.Windows.Forms.TextBox();
            this.EditPhoneTB = new System.Windows.Forms.TextBox();
            this.EditLNameTB = new System.Windows.Forms.TextBox();
            this.EditFNameTB = new System.Windows.Forms.TextBox();
            this.EditEmailLbl = new System.Windows.Forms.Label();
            this.EditPhoneLbl = new System.Windows.Forms.Label();
            this.EditDOBLbl = new System.Windows.Forms.Label();
            this.EditLNameLbl = new System.Windows.Forms.Label();
            this.EditFnameLbl = new System.Windows.Forms.Label();
            this.EditIdLbl = new System.Windows.Forms.Label();
            this.MemberIdTB = new System.Windows.Forms.TextBox();
            this.EditMemberStartDateLbl = new System.Windows.Forms.Label();
            this.MemberStatusLbl = new System.Windows.Forms.Label();
            this.StatusTrueCheck = new System.Windows.Forms.CheckBox();
            this.StatusFalseCheck = new System.Windows.Forms.CheckBox();
            this.EditdateStartInput = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Member information";
            // 
            // CancelEditMemberBtn
            // 
            this.CancelEditMemberBtn.Location = new System.Drawing.Point(56, 378);
            this.CancelEditMemberBtn.Name = "CancelEditMemberBtn";
            this.CancelEditMemberBtn.Size = new System.Drawing.Size(57, 22);
            this.CancelEditMemberBtn.TabIndex = 24;
            this.CancelEditMemberBtn.Text = "Cancel";
            this.CancelEditMemberBtn.UseVisualStyleBackColor = true;
            this.CancelEditMemberBtn.Click += new System.EventHandler(this.CancelEditMemberBtn_Click);
            // 
            // AcceptEditMemberDetailsBtn
            // 
            this.AcceptEditMemberDetailsBtn.Location = new System.Drawing.Point(340, 378);
            this.AcceptEditMemberDetailsBtn.Name = "AcceptEditMemberDetailsBtn";
            this.AcceptEditMemberDetailsBtn.Size = new System.Drawing.Size(64, 22);
            this.AcceptEditMemberDetailsBtn.TabIndex = 23;
            this.AcceptEditMemberDetailsBtn.Text = "Accept";
            this.AcceptEditMemberDetailsBtn.UseVisualStyleBackColor = true;
            this.AcceptEditMemberDetailsBtn.Click += new System.EventHandler(this.AcceptEditMemberDetailsBtn_Click);
            // 
            // EditDOBInput
            // 
            this.EditDOBInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EditDOBInput.Location = new System.Drawing.Point(155, 189);
            this.EditDOBInput.Name = "EditDOBInput";
            this.EditDOBInput.Size = new System.Drawing.Size(94, 20);
            this.EditDOBInput.TabIndex = 22;
            // 
            // EditEmailTB
            // 
            this.EditEmailTB.Location = new System.Drawing.Point(155, 258);
            this.EditEmailTB.Name = "EditEmailTB";
            this.EditEmailTB.Size = new System.Drawing.Size(249, 20);
            this.EditEmailTB.TabIndex = 21;
            // 
            // EditPhoneTB
            // 
            this.EditPhoneTB.Location = new System.Drawing.Point(155, 220);
            this.EditPhoneTB.Name = "EditPhoneTB";
            this.EditPhoneTB.Size = new System.Drawing.Size(144, 20);
            this.EditPhoneTB.TabIndex = 20;
            // 
            // EditLNameTB
            // 
            this.EditLNameTB.Location = new System.Drawing.Point(155, 161);
            this.EditLNameTB.Name = "EditLNameTB";
            this.EditLNameTB.Size = new System.Drawing.Size(249, 20);
            this.EditLNameTB.TabIndex = 19;
            // 
            // EditFNameTB
            // 
            this.EditFNameTB.Location = new System.Drawing.Point(155, 126);
            this.EditFNameTB.Name = "EditFNameTB";
            this.EditFNameTB.Size = new System.Drawing.Size(249, 20);
            this.EditFNameTB.TabIndex = 18;
            // 
            // EditEmailLbl
            // 
            this.EditEmailLbl.AutoSize = true;
            this.EditEmailLbl.Location = new System.Drawing.Point(62, 258);
            this.EditEmailLbl.Name = "EditEmailLbl";
            this.EditEmailLbl.Size = new System.Drawing.Size(32, 13);
            this.EditEmailLbl.TabIndex = 17;
            this.EditEmailLbl.Text = "Email";
            // 
            // EditPhoneLbl
            // 
            this.EditPhoneLbl.AutoSize = true;
            this.EditPhoneLbl.Location = new System.Drawing.Point(53, 220);
            this.EditPhoneLbl.Name = "EditPhoneLbl";
            this.EditPhoneLbl.Size = new System.Drawing.Size(55, 13);
            this.EditPhoneLbl.TabIndex = 16;
            this.EditPhoneLbl.Text = "Phone No";
            // 
            // EditDOBLbl
            // 
            this.EditDOBLbl.AutoSize = true;
            this.EditDOBLbl.Location = new System.Drawing.Point(62, 192);
            this.EditDOBLbl.Name = "EditDOBLbl";
            this.EditDOBLbl.Size = new System.Drawing.Size(36, 13);
            this.EditDOBLbl.TabIndex = 15;
            this.EditDOBLbl.Text = "D.O.B";
            // 
            // EditLNameLbl
            // 
            this.EditLNameLbl.AutoSize = true;
            this.EditLNameLbl.Location = new System.Drawing.Point(53, 161);
            this.EditLNameLbl.Name = "EditLNameLbl";
            this.EditLNameLbl.Size = new System.Drawing.Size(58, 13);
            this.EditLNameLbl.TabIndex = 14;
            this.EditLNameLbl.Text = "Last Name";
            // 
            // EditFnameLbl
            // 
            this.EditFnameLbl.AutoSize = true;
            this.EditFnameLbl.Location = new System.Drawing.Point(53, 126);
            this.EditFnameLbl.Name = "EditFnameLbl";
            this.EditFnameLbl.Size = new System.Drawing.Size(57, 13);
            this.EditFnameLbl.TabIndex = 13;
            this.EditFnameLbl.Text = "First Name";
            // 
            // EditIdLbl
            // 
            this.EditIdLbl.AutoSize = true;
            this.EditIdLbl.Location = new System.Drawing.Point(51, 87);
            this.EditIdLbl.Name = "EditIdLbl";
            this.EditIdLbl.Size = new System.Drawing.Size(70, 13);
            this.EditIdLbl.TabIndex = 25;
            this.EditIdLbl.Text = "ID (read-only)";
            // 
            // MemberIdTB
            // 
            this.MemberIdTB.Location = new System.Drawing.Point(155, 84);
            this.MemberIdTB.Name = "MemberIdTB";
            this.MemberIdTB.ReadOnly = true;
            this.MemberIdTB.Size = new System.Drawing.Size(249, 20);
            this.MemberIdTB.TabIndex = 26;
            // 
            // EditMemberStartDateLbl
            // 
            this.EditMemberStartDateLbl.AutoSize = true;
            this.EditMemberStartDateLbl.Location = new System.Drawing.Point(33, 294);
            this.EditMemberStartDateLbl.Name = "EditMemberStartDateLbl";
            this.EditMemberStartDateLbl.Size = new System.Drawing.Size(96, 13);
            this.EditMemberStartDateLbl.TabIndex = 27;
            this.EditMemberStartDateLbl.Text = "Member Start Date";
            // 
            // MemberStatusLbl
            // 
            this.MemberStatusLbl.AutoSize = true;
            this.MemberStatusLbl.Location = new System.Drawing.Point(53, 333);
            this.MemberStatusLbl.Name = "MemberStatusLbl";
            this.MemberStatusLbl.Size = new System.Drawing.Size(76, 13);
            this.MemberStatusLbl.TabIndex = 29;
            this.MemberStatusLbl.Text = "Member status";
            // 
            // StatusTrueCheck
            // 
            this.StatusTrueCheck.AutoSize = true;
            this.StatusTrueCheck.Location = new System.Drawing.Point(155, 332);
            this.StatusTrueCheck.Name = "StatusTrueCheck";
            this.StatusTrueCheck.Size = new System.Drawing.Size(48, 17);
            this.StatusTrueCheck.TabIndex = 30;
            this.StatusTrueCheck.Text = "True";
            this.StatusTrueCheck.UseVisualStyleBackColor = true;
            this.StatusTrueCheck.CheckedChanged += new System.EventHandler(this.StatusTrueCheck_CheckedChanged_1);
            this.StatusTrueCheck.Click += new System.EventHandler(this.StatusTrueCheck_CheckedChanged);
            // 
            // StatusFalseCheck
            // 
            this.StatusFalseCheck.AutoSize = true;
            this.StatusFalseCheck.Location = new System.Drawing.Point(263, 332);
            this.StatusFalseCheck.Name = "StatusFalseCheck";
            this.StatusFalseCheck.Size = new System.Drawing.Size(51, 17);
            this.StatusFalseCheck.TabIndex = 31;
            this.StatusFalseCheck.Text = "False";
            this.StatusFalseCheck.UseVisualStyleBackColor = true;
            this.StatusFalseCheck.Click += new System.EventHandler(this.StatusFalseCheck_CheckedChanged);
            // 
            // EditdateStartInput
            // 
            this.EditdateStartInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EditdateStartInput.Location = new System.Drawing.Point(155, 294);
            this.EditdateStartInput.Name = "EditdateStartInput";
            this.EditdateStartInput.Size = new System.Drawing.Size(94, 20);
            this.EditdateStartInput.TabIndex = 32;
            // 
            // EditMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.EditdateStartInput);
            this.Controls.Add(this.StatusFalseCheck);
            this.Controls.Add(this.StatusTrueCheck);
            this.Controls.Add(this.MemberStatusLbl);
            this.Controls.Add(this.EditMemberStartDateLbl);
            this.Controls.Add(this.MemberIdTB);
            this.Controls.Add(this.EditIdLbl);
            this.Controls.Add(this.CancelEditMemberBtn);
            this.Controls.Add(this.AcceptEditMemberDetailsBtn);
            this.Controls.Add(this.EditDOBInput);
            this.Controls.Add(this.EditEmailTB);
            this.Controls.Add(this.EditPhoneTB);
            this.Controls.Add(this.EditLNameTB);
            this.Controls.Add(this.EditFNameTB);
            this.Controls.Add(this.EditEmailLbl);
            this.Controls.Add(this.EditPhoneLbl);
            this.Controls.Add(this.EditDOBLbl);
            this.Controls.Add(this.EditLNameLbl);
            this.Controls.Add(this.EditFnameLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMemberForm";
            this.Load += new System.EventHandler(this.EditMemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelEditMemberBtn;
        private System.Windows.Forms.Button AcceptEditMemberDetailsBtn;
        private System.Windows.Forms.DateTimePicker EditDOBInput;
        private System.Windows.Forms.TextBox EditEmailTB;
        private System.Windows.Forms.TextBox EditPhoneTB;
        private System.Windows.Forms.TextBox EditLNameTB;
        private System.Windows.Forms.TextBox EditFNameTB;
        private System.Windows.Forms.Label EditEmailLbl;
        private System.Windows.Forms.Label EditPhoneLbl;
        private System.Windows.Forms.Label EditDOBLbl;
        private System.Windows.Forms.Label EditLNameLbl;
        private System.Windows.Forms.Label EditFnameLbl;
        private System.Windows.Forms.Label EditIdLbl;
        private System.Windows.Forms.TextBox MemberIdTB;
        private System.Windows.Forms.Label EditMemberStartDateLbl;
        private System.Windows.Forms.Label MemberStatusLbl;
        private System.Windows.Forms.CheckBox StatusTrueCheck;
        private System.Windows.Forms.CheckBox StatusFalseCheck;
        private System.Windows.Forms.DateTimePicker EditdateStartInput;
    }
}