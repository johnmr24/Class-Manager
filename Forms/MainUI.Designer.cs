using Class_Manager.Model;

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
            this.classLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FileGroupBox = new System.Windows.Forms.GroupBox();
            this.FileFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.AssignmentGroupBox = new System.Windows.Forms.GroupBox();
            this.AssignmentFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.homeRadBtn = new System.Windows.Forms.RadioButton();
            this.addAssignMainBtn = new System.Windows.Forms.Button();
            this.addClassMainBtn = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.classGrpBx.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FileGroupBox.SuspendLayout();
            this.AssignmentGroupBox.SuspendLayout();
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
            this.removeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
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
            this.classGrpBx.Controls.Add(this.classLayout);
            this.classGrpBx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classGrpBx.Location = new System.Drawing.Point(11, 70);
            this.classGrpBx.Name = "classGrpBx";
            this.classGrpBx.Size = new System.Drawing.Size(149, 302);
            this.classGrpBx.TabIndex = 6;
            this.classGrpBx.TabStop = false;
            this.classGrpBx.Text = "Classes";
            // 
            // classLayout
            // 
            this.classLayout.AutoScroll = true;
            this.classLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.classLayout.Location = new System.Drawing.Point(6, 24);
            this.classLayout.Name = "classLayout";
            this.classLayout.Size = new System.Drawing.Size(137, 272);
            this.classLayout.TabIndex = 0;
            this.classLayout.WrapContents = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.FileGroupBox);
            this.panel1.Controls.Add(this.AssignmentGroupBox);
            this.panel1.Location = new System.Drawing.Point(166, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 449);
            this.panel1.TabIndex = 0;
            // 
            // FileGroupBox
            // 
            this.FileGroupBox.Controls.Add(this.FileFlowLayout);
            this.FileGroupBox.Location = new System.Drawing.Point(3, 240);
            this.FileGroupBox.Name = "FileGroupBox";
            this.FileGroupBox.Size = new System.Drawing.Size(395, 199);
            this.FileGroupBox.TabIndex = 12;
            this.FileGroupBox.TabStop = false;
            this.FileGroupBox.Text = "Files";
            // 
            // FileFlowLayout
            // 
            this.FileFlowLayout.AutoScroll = true;
            this.FileFlowLayout.Location = new System.Drawing.Point(6, 22);
            this.FileFlowLayout.Name = "FileFlowLayout";
            this.FileFlowLayout.Size = new System.Drawing.Size(383, 171);
            this.FileFlowLayout.TabIndex = 0;
            // 
            // AssignmentGroupBox
            // 
            this.AssignmentGroupBox.Controls.Add(this.AssignmentFlowLayout);
            this.AssignmentGroupBox.Location = new System.Drawing.Point(6, 16);
            this.AssignmentGroupBox.Name = "AssignmentGroupBox";
            this.AssignmentGroupBox.Size = new System.Drawing.Size(395, 199);
            this.AssignmentGroupBox.TabIndex = 11;
            this.AssignmentGroupBox.TabStop = false;
            this.AssignmentGroupBox.Text = "Assignments";
            this.AssignmentGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AssignmentFlowLayout
            // 
            this.AssignmentFlowLayout.AutoScroll = true;
            this.AssignmentFlowLayout.Location = new System.Drawing.Point(6, 22);
            this.AssignmentFlowLayout.Name = "AssignmentFlowLayout";
            this.AssignmentFlowLayout.Size = new System.Drawing.Size(383, 171);
            this.AssignmentFlowLayout.TabIndex = 0;
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUIFrm_FormClosing_1);
            this.Load += new System.EventHandler(this.MainUIFrm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.classGrpBx.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.FileGroupBox.ResumeLayout(false);
            this.AssignmentGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private GroupBox classGrpBx;
        private Panel panel1;
        private RadioButton homeRadBtn;
        private Button addAssignMainBtn;
        private Button addClassMainBtn;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private FlowLayoutPanel classLayout;
        private GroupBox AssignmentGroupBox;
        private FlowLayoutPanel AssignmentFlowLayout;
        private GroupBox FileGroupBox;
        private FlowLayoutPanel FileFlowLayout;
    }
}