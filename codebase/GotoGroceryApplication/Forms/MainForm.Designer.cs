using System;
//+++++++++This is Windows Form Designer generated code+++++++++++++++++++
namespace GotoGrocery
{
    partial class MainForm
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
            this.headerpanel1 = new System.Windows.Forms.Panel();
            this.pageTitle = new System.Windows.Forms.Label();
            this.sideflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.memberBtn = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.ReportsBtn = new System.Windows.Forms.Button();
            this.mainWindowPanel1 = new System.Windows.Forms.Panel();
            this.currentPagePanel = new System.Windows.Forms.Panel();
            this.headerpanel1.SuspendLayout();
            this.sideflowLayoutPanel.SuspendLayout();
            this.mainWindowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerpanel1
            // 
            this.headerpanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.headerpanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerpanel1.Controls.Add(this.pageTitle);
            this.headerpanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel1.Location = new System.Drawing.Point(0, 0);
            this.headerpanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerpanel1.Name = "headerpanel1";
            this.headerpanel1.Size = new System.Drawing.Size(1659, 92);
            this.headerpanel1.TabIndex = 0;
            // 
            // pageTitle
            // 
            this.pageTitle.AutoSize = true;
            this.pageTitle.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitle.ForeColor = System.Drawing.Color.Transparent;
            this.pageTitle.Location = new System.Drawing.Point(857, 27);
            this.pageTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(201, 38);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "Goto Grocery";
            this.pageTitle.Click += new System.EventHandler(this.Label1_Click);
            // 
            // sideflowLayoutPanel
            // 
            this.sideflowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sideflowLayoutPanel.Controls.Add(this.dashboardBtn);
            this.sideflowLayoutPanel.Controls.Add(this.memberBtn);
            this.sideflowLayoutPanel.Controls.Add(this.inventoryBtn);
            this.sideflowLayoutPanel.Controls.Add(this.ReportsBtn);
            this.sideflowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideflowLayoutPanel.Location = new System.Drawing.Point(0, 92);
            this.sideflowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sideflowLayoutPanel.Name = "sideflowLayoutPanel";
            this.sideflowLayoutPanel.Size = new System.Drawing.Size(241, 748);
            this.sideflowLayoutPanel.TabIndex = 0;
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.dashboardBtn.Location = new System.Drawing.Point(4, 5);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(236, 72);
            this.dashboardBtn.TabIndex = 4;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // memberBtn
            // 
            this.memberBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memberBtn.FlatAppearance.BorderSize = 0;
            this.memberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memberBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.memberBtn.Location = new System.Drawing.Point(4, 87);
            this.memberBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memberBtn.Name = "memberBtn";
            this.memberBtn.Size = new System.Drawing.Size(236, 77);
            this.memberBtn.TabIndex = 0;
            this.memberBtn.Text = "Members";
            this.memberBtn.UseVisualStyleBackColor = false;
            this.memberBtn.Click += new System.EventHandler(this.MemberBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.inventoryBtn.FlatAppearance.BorderSize = 0;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.inventoryBtn.Location = new System.Drawing.Point(4, 174);
            this.inventoryBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Size = new System.Drawing.Size(236, 82);
            this.inventoryBtn.TabIndex = 1;
            this.inventoryBtn.Text = "Inventory";
            this.inventoryBtn.UseVisualStyleBackColor = false;
            this.inventoryBtn.Click += new System.EventHandler(this.InventoryBtn_Click);
            // 
            // ReportsBtn
            // 
            this.ReportsBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ReportsBtn.FlatAppearance.BorderSize = 0;
            this.ReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideflowLayoutPanel.SetFlowBreak(this.ReportsBtn, true);
            this.ReportsBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ReportsBtn.Location = new System.Drawing.Point(4, 266);
            this.ReportsBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReportsBtn.Name = "ReportsBtn";
            this.ReportsBtn.Size = new System.Drawing.Size(236, 80);
            this.ReportsBtn.TabIndex = 5;
            this.ReportsBtn.Text = "Reports";
            this.ReportsBtn.UseVisualStyleBackColor = false;
            this.ReportsBtn.Click += new System.EventHandler(this.ReportsBtn_Click);
            // 
            // mainWindowPanel1
            // 
            this.mainWindowPanel1.Controls.Add(this.currentPagePanel);
            this.mainWindowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowPanel1.Location = new System.Drawing.Point(241, 92);
            this.mainWindowPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainWindowPanel1.Name = "mainWindowPanel1";
            this.mainWindowPanel1.Size = new System.Drawing.Size(1418, 748);
            this.mainWindowPanel1.TabIndex = 1;
            // 
            // currentPagePanel
            // 
            this.currentPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentPagePanel.Location = new System.Drawing.Point(0, 0);
            this.currentPagePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentPagePanel.Name = "currentPagePanel";
            this.currentPagePanel.Size = new System.Drawing.Size(1418, 748);
            this.currentPagePanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 840);
            this.Controls.Add(this.mainWindowPanel1);
            this.Controls.Add(this.sideflowLayoutPanel);
            this.Controls.Add(this.headerpanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Goto Grocery Application";
            this.headerpanel1.ResumeLayout(false);
            this.headerpanel1.PerformLayout();
            this.sideflowLayoutPanel.ResumeLayout(false);
            this.mainWindowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.Panel headerpanel1;
        private System.Windows.Forms.FlowLayoutPanel sideflowLayoutPanel;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.Button memberBtn;
        private System.Windows.Forms.Panel mainWindowPanel1;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Panel currentPagePanel;
        private System.Windows.Forms.Button ReportsBtn;
    }
}

