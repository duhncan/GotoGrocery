
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
            this.label1.Location = new System.Drawing.Point(228, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Member information";
            // 
            // CancelEditMemberBtn
            // 
            this.CancelEditMemberBtn.Location = new System.Drawing.Point(84, 582);
            this.CancelEditMemberBtn.Name = "CancelEditMemberBtn";
            this.CancelEditMemberBtn.Size = new System.Drawing.Size(86, 34);
            this.CancelEditMemberBtn.TabIndex = 24;
            this.CancelEditMemberBtn.Text = "Cancel";
            this.CancelEditMemberBtn.UseVisualStyleBackColor = true;
            this.CancelEditMemberBtn.Click += new System.EventHandler(this.CancelEditMemberBtn_Click);
            // 
            // AcceptEditMemberDetailsBtn
            // 
            this.AcceptEditMemberDetailsBtn.Location = new System.Drawing.Point(510, 582);
            this.AcceptEditMemberDetailsBtn.Name = "AcceptEditMemberDetailsBtn";
            this.AcceptEditMemberDetailsBtn.Size = new System.Drawing.Size(96, 34);
            this.AcceptEditMemberDetailsBtn.TabIndex = 23;
            this.AcceptEditMemberDetailsBtn.Text = "Accept";
            this.AcceptEditMemberDetailsBtn.UseVisualStyleBackColor = true;
            this.AcceptEditMemberDetailsBtn.Click += new System.EventHandler(this.AcceptEditMemberDetailsBtn_Click);
            // 
            // EditDOBInput
            // 
            this.EditDOBInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EditDOBInput.Location = new System.Drawing.Point(232, 291);
            this.EditDOBInput.Name = "EditDOBInput";
            this.EditDOBInput.Size = new System.Drawing.Size(139, 26);
            this.EditDOBInput.TabIndex = 22;
            // 
            // EditEmailTB
            // 
            this.EditEmailTB.Location = new System.Drawing.Point(232, 397);
            this.EditEmailTB.Name = "EditEmailTB";
            this.EditEmailTB.Size = new System.Drawing.Size(372, 26);
            this.EditEmailTB.TabIndex = 21;
            // 
            // EditPhoneTB
            // 
            this.EditPhoneTB.Location = new System.Drawing.Point(232, 338);
            this.EditPhoneTB.Name = "EditPhoneTB";
            this.EditPhoneTB.Size = new System.Drawing.Size(214, 26);
            this.EditPhoneTB.TabIndex = 20;
            // 
            // EditLNameTB
            // 
            this.EditLNameTB.Location = new System.Drawing.Point(232, 248);
            this.EditLNameTB.Name = "EditLNameTB";
            this.EditLNameTB.Size = new System.Drawing.Size(372, 26);
            this.EditLNameTB.TabIndex = 19;
            // 
            // EditFNameTB
            // 
            this.EditFNameTB.Location = new System.Drawing.Point(232, 194);
            this.EditFNameTB.Name = "EditFNameTB";
            this.EditFNameTB.Size = new System.Drawing.Size(372, 26);
            this.EditFNameTB.TabIndex = 18;
            // 
            // EditEmailLbl
            // 
            this.EditEmailLbl.AutoSize = true;
            this.EditEmailLbl.Location = new System.Drawing.Point(93, 397);
            this.EditEmailLbl.Name = "EditEmailLbl";
            this.EditEmailLbl.Size = new System.Drawing.Size(48, 20);
            this.EditEmailLbl.TabIndex = 17;
            this.EditEmailLbl.Text = "Email";
            // 
            // EditPhoneLbl
            // 
            this.EditPhoneLbl.AutoSize = true;
            this.EditPhoneLbl.Location = new System.Drawing.Point(80, 338);
            this.EditPhoneLbl.Name = "EditPhoneLbl";
            this.EditPhoneLbl.Size = new System.Drawing.Size(79, 20);
            this.EditPhoneLbl.TabIndex = 16;
            this.EditPhoneLbl.Text = "Phone No";
            // 
            // EditDOBLbl
            // 
            this.EditDOBLbl.AutoSize = true;
            this.EditDOBLbl.Location = new System.Drawing.Point(93, 295);
            this.EditDOBLbl.Name = "EditDOBLbl";
            this.EditDOBLbl.Size = new System.Drawing.Size(52, 20);
            this.EditDOBLbl.TabIndex = 15;
            this.EditDOBLbl.Text = "D.O.B";
            // 
            // EditLNameLbl
            // 
            this.EditLNameLbl.AutoSize = true;
            this.EditLNameLbl.Location = new System.Drawing.Point(80, 248);
            this.EditLNameLbl.Name = "EditLNameLbl";
            this.EditLNameLbl.Size = new System.Drawing.Size(86, 20);
            this.EditLNameLbl.TabIndex = 14;
            this.EditLNameLbl.Text = "Last Name";
            // 
            // EditFnameLbl
            // 
            this.EditFnameLbl.AutoSize = true;
            this.EditFnameLbl.Location = new System.Drawing.Point(80, 194);
            this.EditFnameLbl.Name = "EditFnameLbl";
            this.EditFnameLbl.Size = new System.Drawing.Size(86, 20);
            this.EditFnameLbl.TabIndex = 13;
            this.EditFnameLbl.Text = "First Name";
            // 
            // EditIdLbl
            // 
            this.EditIdLbl.AutoSize = true;
            this.EditIdLbl.Location = new System.Drawing.Point(76, 134);
            this.EditIdLbl.Name = "EditIdLbl";
            this.EditIdLbl.Size = new System.Drawing.Size(105, 20);
            this.EditIdLbl.TabIndex = 25;
            this.EditIdLbl.Text = "ID (read-only)";
            // 
            // MemberIdTB
            // 
            this.MemberIdTB.Location = new System.Drawing.Point(232, 129);
            this.MemberIdTB.Name = "MemberIdTB";
            this.MemberIdTB.ReadOnly = true;
            this.MemberIdTB.Size = new System.Drawing.Size(372, 26);
            this.MemberIdTB.TabIndex = 26;
            // 
            // EditMemberStartDateLbl
            // 
            this.EditMemberStartDateLbl.AutoSize = true;
            this.EditMemberStartDateLbl.Location = new System.Drawing.Point(50, 452);
            this.EditMemberStartDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EditMemberStartDateLbl.Name = "EditMemberStartDateLbl";
            this.EditMemberStartDateLbl.Size = new System.Drawing.Size(145, 20);
            this.EditMemberStartDateLbl.TabIndex = 27;
            this.EditMemberStartDateLbl.Text = "Member Start Date";
            // 
            // MemberStatusLbl
            // 
            this.MemberStatusLbl.AutoSize = true;
            this.MemberStatusLbl.Location = new System.Drawing.Point(80, 512);
            this.MemberStatusLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MemberStatusLbl.Name = "MemberStatusLbl";
            this.MemberStatusLbl.Size = new System.Drawing.Size(115, 20);
            this.MemberStatusLbl.TabIndex = 29;
            this.MemberStatusLbl.Text = "Member status";
            // 
            // StatusTrueCheck
            // 
            this.StatusTrueCheck.AutoSize = true;
            this.StatusTrueCheck.Location = new System.Drawing.Point(232, 511);
            this.StatusTrueCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusTrueCheck.Name = "StatusTrueCheck";
            this.StatusTrueCheck.Size = new System.Drawing.Size(67, 24);
            this.StatusTrueCheck.TabIndex = 30;
            this.StatusTrueCheck.Text = "True";
            this.StatusTrueCheck.UseVisualStyleBackColor = true;
            this.StatusTrueCheck.Click += new System.EventHandler(this.StatusTrueCheck_CheckedChanged);
            // 
            // StatusFalseCheck
            // 
            this.StatusFalseCheck.AutoSize = true;
            this.StatusFalseCheck.Location = new System.Drawing.Point(394, 511);
            this.StatusFalseCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StatusFalseCheck.Name = "StatusFalseCheck";
            this.StatusFalseCheck.Size = new System.Drawing.Size(74, 24);
            this.StatusFalseCheck.TabIndex = 31;
            this.StatusFalseCheck.Text = "False";
            this.StatusFalseCheck.UseVisualStyleBackColor = true;
            this.StatusFalseCheck.Click += new System.EventHandler(this.StatusFalseCheck_CheckedChanged);
            // 
            // EditdateStartInput
            // 
            this.EditdateStartInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EditdateStartInput.Location = new System.Drawing.Point(232, 452);
            this.EditdateStartInput.Name = "EditdateStartInput";
            this.EditdateStartInput.Size = new System.Drawing.Size(139, 26);
            this.EditdateStartInput.TabIndex = 32;
            // 
            // EditMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 692);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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