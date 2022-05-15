
namespace GotoGrocery.Forms
{
    partial class ReportForm
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
            this.SaveReport = new System.Windows.Forms.Button();
            this.ReportLbl = new System.Windows.Forms.Label();
            this.ReportFormTtl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveReport
            // 
            this.SaveReport.Location = new System.Drawing.Point(496, 273);
            this.SaveReport.Name = "SaveReport";
            this.SaveReport.Size = new System.Drawing.Size(155, 46);
            this.SaveReport.TabIndex = 0;
            this.SaveReport.Text = "Click";
            this.SaveReport.UseVisualStyleBackColor = true;
            this.SaveReport.Click += new System.EventHandler(this.SaveReport_Click);
            // 
            // ReportLbl
            // 
            this.ReportLbl.AutoSize = true;
            this.ReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLbl.Location = new System.Drawing.Point(403, 203);
            this.ReportLbl.Name = "ReportLbl";
            this.ReportLbl.Size = new System.Drawing.Size(336, 25);
            this.ReportLbl.TabIndex = 1;
            this.ReportLbl.Text = "Click button to generate a CSV report";
            // 
            // ReportFormTtl
            // 
            this.ReportFormTtl.AutoSize = true;
            this.ReportFormTtl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportFormTtl.Location = new System.Drawing.Point(522, 55);
            this.ReportFormTtl.Name = "ReportFormTtl";
            this.ReportFormTtl.Size = new System.Drawing.Size(98, 29);
            this.ReportFormTtl.TabIndex = 2;
            this.ReportFormTtl.Text = "Reports";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 524);
            this.Controls.Add(this.ReportFormTtl);
            this.Controls.Add(this.ReportLbl);
            this.Controls.Add(this.SaveReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveReport;
        private System.Windows.Forms.Label ReportLbl;
        private System.Windows.Forms.Label ReportFormTtl;
    }
}