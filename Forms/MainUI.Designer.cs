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
            this.classGrpBx = new System.Windows.Forms.GroupBox();
            this.classLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.collapsePanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addClassMainBtn = new System.Windows.Forms.Button();
            this.addFileMainBtn = new System.Windows.Forms.Button();
            this.addAssignMainBtn = new System.Windows.Forms.Button();
            this.collapseBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileGroupBox = new System.Windows.Forms.GroupBox();
            this.FileFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.AssignmentGroupBox = new System.Windows.Forms.GroupBox();
            this.AssignmentFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.expandBtn = new System.Windows.Forms.Button();
            this.classGrpBx.SuspendLayout();
            this.collapsePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.FileGroupBox.SuspendLayout();
            this.AssignmentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // classGrpBx
            // 
            this.classGrpBx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.classGrpBx.Controls.Add(this.classLayout);
            this.classGrpBx.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classGrpBx.Location = new System.Drawing.Point(32, 65);
            this.classGrpBx.Name = "classGrpBx";
            this.classGrpBx.Size = new System.Drawing.Size(149, 326);
            this.classGrpBx.TabIndex = 6;
            this.classGrpBx.TabStop = false;
            this.classGrpBx.Text = "Classes";
            // 
            // classLayout
            // 
            this.classLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.classLayout.AutoScroll = true;
            this.classLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.classLayout.BackColor = System.Drawing.Color.White;
            this.classLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.classLayout.Location = new System.Drawing.Point(6, 16);
            this.classLayout.Name = "classLayout";
            this.classLayout.Size = new System.Drawing.Size(137, 304);
            this.classLayout.TabIndex = 0;
            this.classLayout.WrapContents = false;
            // 
            // collapsePanel
            // 
            this.collapsePanel.BackColor = System.Drawing.Color.CadetBlue;
            this.collapsePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.collapsePanel.Controls.Add(this.groupBox1);
            this.collapsePanel.Controls.Add(this.collapseBtn);
            this.collapsePanel.Controls.Add(this.classGrpBx);
            this.collapsePanel.Controls.Add(this.menuStrip1);
            this.collapsePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.collapsePanel.Location = new System.Drawing.Point(0, 0);
            this.collapsePanel.Name = "collapsePanel";
            this.collapsePanel.Size = new System.Drawing.Size(218, 432);
            this.collapsePanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.addClassMainBtn);
            this.groupBox1.Controls.Add(this.addFileMainBtn);
            this.groupBox1.Controls.Add(this.addAssignMainBtn);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(-1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 60);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // addClassMainBtn
            // 
            this.addClassMainBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addClassMainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClassMainBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addClassMainBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addClassMainBtn.Location = new System.Drawing.Point(11, 22);
            this.addClassMainBtn.Name = "addClassMainBtn";
            this.addClassMainBtn.Size = new System.Drawing.Size(51, 24);
            this.addClassMainBtn.TabIndex = 9;
            this.addClassMainBtn.Text = "Class";
            this.addClassMainBtn.UseVisualStyleBackColor = false;
            this.addClassMainBtn.Click += new System.EventHandler(this.addClassMainBtn_Click);
            // 
            // addFileMainBtn
            // 
            this.addFileMainBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addFileMainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFileMainBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addFileMainBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addFileMainBtn.Location = new System.Drawing.Point(155, 22);
            this.addFileMainBtn.Name = "addFileMainBtn";
            this.addFileMainBtn.Size = new System.Drawing.Size(51, 24);
            this.addFileMainBtn.TabIndex = 10;
            this.addFileMainBtn.Text = "File";
            this.addFileMainBtn.UseVisualStyleBackColor = false;
            this.addFileMainBtn.Click += new System.EventHandler(this.addFileMainBtn_Click);
            // 
            // addAssignMainBtn
            // 
            this.addAssignMainBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addAssignMainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAssignMainBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addAssignMainBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addAssignMainBtn.Location = new System.Drawing.Point(68, 22);
            this.addAssignMainBtn.Name = "addAssignMainBtn";
            this.addAssignMainBtn.Size = new System.Drawing.Size(81, 24);
            this.addAssignMainBtn.TabIndex = 8;
            this.addAssignMainBtn.Text = "Assignment";
            this.addAssignMainBtn.UseVisualStyleBackColor = false;
            this.addAssignMainBtn.Click += new System.EventHandler(this.addAssignMainBtn_Click);
            // 
            // collapseBtn
            // 
            this.collapseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.collapseBtn.BackColor = System.Drawing.Color.DimGray;
            this.collapseBtn.FlatAppearance.BorderSize = 0;
            this.collapseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapseBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.collapseBtn.Location = new System.Drawing.Point(202, 204);
            this.collapseBtn.Name = "collapseBtn";
            this.collapseBtn.Size = new System.Drawing.Size(15, 23);
            this.collapseBtn.TabIndex = 13;
            this.collapseBtn.Text = "<";
            this.collapseBtn.UseVisualStyleBackColor = false;
            this.collapseBtn.Click += new System.EventHandler(this.collapseBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 406);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(216, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // FileGroupBox
            // 
            this.FileGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.FileGroupBox.Controls.Add(this.FileFlowLayout);
            this.FileGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FileGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FileGroupBox.Location = new System.Drawing.Point(218, 233);
            this.FileGroupBox.Name = "FileGroupBox";
            this.FileGroupBox.Size = new System.Drawing.Size(397, 199);
            this.FileGroupBox.TabIndex = 12;
            this.FileGroupBox.TabStop = false;
            this.FileGroupBox.Text = "Files";
            // 
            // FileFlowLayout
            // 
            this.FileFlowLayout.AutoScroll = true;
            this.FileFlowLayout.BackColor = System.Drawing.Color.White;
            this.FileFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FileFlowLayout.Location = new System.Drawing.Point(3, 18);
            this.FileFlowLayout.Name = "FileFlowLayout";
            this.FileFlowLayout.Size = new System.Drawing.Size(391, 178);
            this.FileFlowLayout.TabIndex = 0;
            // 
            // AssignmentGroupBox
            // 
            this.AssignmentGroupBox.AutoSize = true;
            this.AssignmentGroupBox.Controls.Add(this.AssignmentFlowLayout);
            this.AssignmentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignmentGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AssignmentGroupBox.Location = new System.Drawing.Point(218, 0);
            this.AssignmentGroupBox.Name = "AssignmentGroupBox";
            this.AssignmentGroupBox.Size = new System.Drawing.Size(397, 432);
            this.AssignmentGroupBox.TabIndex = 11;
            this.AssignmentGroupBox.TabStop = false;
            this.AssignmentGroupBox.Text = "Assignments";
            // 
            // AssignmentFlowLayout
            // 
            this.AssignmentFlowLayout.AutoScroll = true;
            this.AssignmentFlowLayout.BackColor = System.Drawing.Color.White;
            this.AssignmentFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignmentFlowLayout.Location = new System.Drawing.Point(3, 18);
            this.AssignmentFlowLayout.Name = "AssignmentFlowLayout";
            this.AssignmentFlowLayout.Size = new System.Drawing.Size(391, 411);
            this.AssignmentFlowLayout.TabIndex = 0;
            // 
            // expandBtn
            // 
            this.expandBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.expandBtn.BackColor = System.Drawing.Color.DimGray;
            this.expandBtn.FlatAppearance.BorderSize = 0;
            this.expandBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expandBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expandBtn.Location = new System.Drawing.Point(218, 205);
            this.expandBtn.Name = "expandBtn";
            this.expandBtn.Size = new System.Drawing.Size(15, 23);
            this.expandBtn.TabIndex = 14;
            this.expandBtn.Text = ">";
            this.expandBtn.UseVisualStyleBackColor = false;
            this.expandBtn.Visible = false;
            this.expandBtn.Click += new System.EventHandler(this.expandBtn_Click);
            // 
            // MainUIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(615, 432);
            this.Controls.Add(this.expandBtn);
            this.Controls.Add(this.FileGroupBox);
            this.Controls.Add(this.AssignmentGroupBox);
            this.Controls.Add(this.collapsePanel);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(631, 471);
            this.Name = "MainUIFrm";
            this.Text = "Class Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUIFrm_FormClosing_1);
            this.Load += new System.EventHandler(this.MainUIFrm_Load);
            this.classGrpBx.ResumeLayout(false);
            this.collapsePanel.ResumeLayout(false);
            this.collapsePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FileGroupBox.ResumeLayout(false);
            this.AssignmentGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox classGrpBx;
        private Panel collapsePanel;
        private Button addAssignMainBtn;
        private Button addClassMainBtn;
        private FlowLayoutPanel classLayout;
        private GroupBox AssignmentGroupBox;
        private FlowLayoutPanel AssignmentFlowLayout;
        private GroupBox FileGroupBox;
        private FlowLayoutPanel FileFlowLayout;
        private GroupBox groupBox1;
        private Button addFileMainBtn;
        private Button collapseBtn;
        private Button expandBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
    }
}