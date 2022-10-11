namespace Class_Manager
{
    partial class MainUIFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classGrpBx = new System.Windows.Forms.GroupBox();
            this.classRadBtn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.assignChkLstBx = new System.Windows.Forms.CheckedListBox();
            this.assignDueLbl = new System.Windows.Forms.Label();
            this.homeRadBtn = new System.Windows.Forms.RadioButton();
            this.addAssignMainBtn = new System.Windows.Forms.Button();
            this.addClassMainBtn = new System.Windows.Forms.Button();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.classGrpBx.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(580, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.editToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // classGrpBx
            // 
            this.classGrpBx.Controls.Add(this.classRadBtn);
            this.classGrpBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classGrpBx.Location = new System.Drawing.Point(11, 70);
            this.classGrpBx.Name = "classGrpBx";
            this.classGrpBx.Size = new System.Drawing.Size(149, 302);
            this.classGrpBx.TabIndex = 6;
            this.classGrpBx.TabStop = false;
            this.classGrpBx.Text = "Classes";
            // 
            // classRadBtn
            // 
            this.classRadBtn.AutoSize = true;
            this.classRadBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classRadBtn.Location = new System.Drawing.Point(6, 24);
            this.classRadBtn.Name = "classRadBtn";
            this.classRadBtn.Size = new System.Drawing.Size(68, 21);
            this.classRadBtn.TabIndex = 7;
            this.classRadBtn.TabStop = true;
            this.classRadBtn.Text = "Class 1";
            this.classRadBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.assignChkLstBx);
            this.panel1.Controls.Add(this.assignDueLbl);
            this.panel1.Location = new System.Drawing.Point(169, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 449);
            this.panel1.TabIndex = 0;
            // 
            // assignChkLstBx
            // 
            this.assignChkLstBx.FormattingEnabled = true;
            this.assignChkLstBx.Items.AddRange(new object[] {
            "Assignment 1"});
            this.assignChkLstBx.Location = new System.Drawing.Point(12, 33);
            this.assignChkLstBx.Name = "assignChkLstBx";
            this.assignChkLstBx.Size = new System.Drawing.Size(179, 94);
            this.assignChkLstBx.TabIndex = 11;
            // 
            // assignDueLbl
            // 
            this.assignDueLbl.AutoSize = true;
            this.assignDueLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignDueLbl.Location = new System.Drawing.Point(12, 13);
            this.assignDueLbl.Name = "assignDueLbl";
            this.assignDueLbl.Size = new System.Drawing.Size(120, 17);
            this.assignDueLbl.TabIndex = 10;
            this.assignDueLbl.Text = "Assignments Due:";
            // 
            // homeRadBtn
            // 
            this.homeRadBtn.AutoSize = true;
            this.homeRadBtn.Checked = true;
            this.homeRadBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.homeRadBtn.Location = new System.Drawing.Point(51, 44);
            this.homeRadBtn.Name = "homeRadBtn";
            this.homeRadBtn.Size = new System.Drawing.Size(63, 21);
            this.homeRadBtn.TabIndex = 0;
            this.homeRadBtn.TabStop = true;
            this.homeRadBtn.Text = "Home";
            this.homeRadBtn.UseVisualStyleBackColor = true;
            // 
            // addAssignMainBtn
            // 
            this.addAssignMainBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addAssignMainBtn.Location = new System.Drawing.Point(36, 428);
            this.addAssignMainBtn.Name = "addAssignMainBtn";
            this.addAssignMainBtn.Size = new System.Drawing.Size(102, 44);
            this.addAssignMainBtn.TabIndex = 8;
            this.addAssignMainBtn.Text = "Add Assignment";
            this.addAssignMainBtn.UseVisualStyleBackColor = true;
            this.addAssignMainBtn.Click += new System.EventHandler(this.addAssignMainBtn_Click);
            // 
            // addClassMainBtn
            // 
            this.addClassMainBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addClassMainBtn.Location = new System.Drawing.Point(36, 378);
            this.addClassMainBtn.Name = "addClassMainBtn";
            this.addClassMainBtn.Size = new System.Drawing.Size(102, 44);
            this.addClassMainBtn.TabIndex = 9;
            this.addClassMainBtn.Text = "Add Class";
            this.addClassMainBtn.UseVisualStyleBackColor = true;
            this.addClassMainBtn.Click += new System.EventHandler(this.addClassMainBtn_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // MainUIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(580, 479);
            this.Controls.Add(this.addClassMainBtn);
            this.Controls.Add(this.addAssignMainBtn);
            this.Controls.Add(this.homeRadBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.classGrpBx);
            this.Controls.Add(this.menuStrip);
            this.Name = "MainUIFrm";
            this.Text = "Class Manager";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.classGrpBx.ResumeLayout(false);
            this.classGrpBx.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private GroupBox classGrpBx;
        private RadioButton classRadBtn;
        private Panel panel1;
        private Label assignDueLbl;
        private RadioButton homeRadBtn;
        private Button addAssignMainBtn;
        private Button addClassMainBtn;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private CheckedListBox assignChkLstBx;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}