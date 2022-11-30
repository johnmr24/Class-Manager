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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUIFrm));
            this.classesGroupBox = new System.Windows.Forms.GroupBox();
            this.classLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.collapsePanel = new System.Windows.Forms.Panel();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.addClassMainBtn = new System.Windows.Forms.Button();
            this.addFileMainBtn = new System.Windows.Forms.Button();
            this.addAssignMainBtn = new System.Windows.Forms.Button();
            this.collapseButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appearanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsOnButton = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsOffButton = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveMinuteUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.oneHourUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.twelveHourUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.oneDayUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandButton = new System.Windows.Forms.Button();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.FileFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.assignmentGroupBox = new System.Windows.Forms.GroupBox();
            this.AssignmentFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.notesGroupBox = new System.Windows.Forms.GroupBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.dueDateTimer = new System.Windows.Forms.Timer(this.components);
            this.colDialog = new System.Windows.Forms.ColorDialog();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesGroupBox.SuspendLayout();
            this.collapsePanel.SuspendLayout();
            this.addGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.fileGroupBox.SuspendLayout();
            this.assignmentGroupBox.SuspendLayout();
            this.notesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // classesGroupBox
            // 
            this.classesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.classesGroupBox.Controls.Add(this.classLayout);
            this.classesGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classesGroupBox.ForeColor = System.Drawing.Color.Black;
            this.classesGroupBox.Location = new System.Drawing.Point(11, 65);
            this.classesGroupBox.Name = "classesGroupBox";
            this.classesGroupBox.Size = new System.Drawing.Size(185, 326);
            this.classesGroupBox.TabIndex = 6;
            this.classesGroupBox.TabStop = false;
            this.classesGroupBox.Text = "Classes";
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
            this.classLayout.Size = new System.Drawing.Size(173, 304);
            this.classLayout.TabIndex = 0;
            this.classLayout.WrapContents = false;
            // 
            // collapsePanel
            // 
            this.collapsePanel.BackColor = System.Drawing.Color.CadetBlue;
            this.collapsePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.collapsePanel.Controls.Add(this.addGroupBox);
            this.collapsePanel.Controls.Add(this.collapseButton);
            this.collapsePanel.Controls.Add(this.classesGroupBox);
            this.collapsePanel.Controls.Add(this.menuStrip);
            this.collapsePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.collapsePanel.Location = new System.Drawing.Point(0, 0);
            this.collapsePanel.Name = "collapsePanel";
            this.collapsePanel.Size = new System.Drawing.Size(218, 432);
            this.collapsePanel.TabIndex = 0;
            // 
            // addGroupBox
            // 
            this.addGroupBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addGroupBox.Controls.Add(this.addClassMainBtn);
            this.addGroupBox.Controls.Add(this.addFileMainBtn);
            this.addGroupBox.Controls.Add(this.addAssignMainBtn);
            this.addGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addGroupBox.Location = new System.Drawing.Point(-1, -1);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(218, 60);
            this.addGroupBox.TabIndex = 11;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add";
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
            this.addClassMainBtn.Click += new System.EventHandler(this.AddClassMainBtn_Click);
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
            this.addFileMainBtn.Click += new System.EventHandler(this.AddFileMainBtn_Click);
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
            this.addAssignMainBtn.Click += new System.EventHandler(this.AddAssignMainBtn_Click);
            // 
            // collapseButton
            // 
            this.collapseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.collapseButton.BackColor = System.Drawing.Color.DimGray;
            this.collapseButton.FlatAppearance.BorderSize = 0;
            this.collapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.collapseButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.collapseButton.Location = new System.Drawing.Point(202, 194);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(15, 23);
            this.collapseButton.TabIndex = 13;
            this.collapseButton.Text = "<";
            this.collapseButton.UseVisualStyleBackColor = false;
            this.collapseButton.Click += new System.EventHandler(this.CollapseBtn_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 406);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(216, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startupToolStripMenuItem,
            this.appearanceToolStripMenuItem,
            this.notificationsToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // startupToolStripMenuItem
            // 
            this.startupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onToolStripMenuItem,
            this.offToolStripMenuItem});
            this.startupToolStripMenuItem.Name = "startupToolStripMenuItem";
            this.startupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startupToolStripMenuItem.Text = "Startup";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.onToolStripMenuItem.Text = "On";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.OnToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.offToolStripMenuItem.Text = "Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.OffToolStripMenuItem_Click);
            // 
            // appearanceToolStripMenuItem
            // 
            this.appearanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.appearanceToolStripMenuItem.Name = "appearanceToolStripMenuItem";
            this.appearanceToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.appearanceToolStripMenuItem.Text = "Appearance";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificationsOnButton,
            this.notificationsOffButton,
            this.updateToolStripMenuItem});
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            // 
            // notificationsOnButton
            // 
            this.notificationsOnButton.CheckOnClick = true;
            this.notificationsOnButton.Name = "notificationsOnButton";
            this.notificationsOnButton.Size = new System.Drawing.Size(117, 22);
            this.notificationsOnButton.Text = "On";
            this.notificationsOnButton.Click += new System.EventHandler(this.NotificationsOnButton_Click);
            // 
            // notificationsOffButton
            // 
            this.notificationsOffButton.Checked = true;
            this.notificationsOffButton.CheckOnClick = true;
            this.notificationsOffButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notificationsOffButton.Name = "notificationsOffButton";
            this.notificationsOffButton.Size = new System.Drawing.Size(117, 22);
            this.notificationsOffButton.Text = "Off";
            this.notificationsOffButton.Click += new System.EventHandler(this.NotificationsOffButton_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiveMinuteUpdate,
            this.oneHourUpdate,
            this.twelveHourUpdate,
            this.oneDayUpdate});
            this.updateToolStripMenuItem.Enabled = false;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // fiveMinuteUpdate
            // 
            this.fiveMinuteUpdate.Checked = true;
            this.fiveMinuteUpdate.CheckOnClick = true;
            this.fiveMinuteUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fiveMinuteUpdate.Name = "fiveMinuteUpdate";
            this.fiveMinuteUpdate.Size = new System.Drawing.Size(117, 22);
            this.fiveMinuteUpdate.Text = "5 min.";
            this.fiveMinuteUpdate.Click += new System.EventHandler(this.FiveMinuteUpdate_Click);
            // 
            // oneHourUpdate
            // 
            this.oneHourUpdate.CheckOnClick = true;
            this.oneHourUpdate.Name = "oneHourUpdate";
            this.oneHourUpdate.Size = new System.Drawing.Size(117, 22);
            this.oneHourUpdate.Text = "1 hour";
            this.oneHourUpdate.Click += new System.EventHandler(this.OneHourUpdate_Click);
            // 
            // twelveHourUpdate
            // 
            this.twelveHourUpdate.CheckOnClick = true;
            this.twelveHourUpdate.Name = "twelveHourUpdate";
            this.twelveHourUpdate.Size = new System.Drawing.Size(117, 22);
            this.twelveHourUpdate.Text = "12 hour";
            this.twelveHourUpdate.Click += new System.EventHandler(this.TwelveHourUpdate_Click);
            // 
            // oneDayUpdate
            // 
            this.oneDayUpdate.CheckOnClick = true;
            this.oneDayUpdate.Name = "oneDayUpdate";
            this.oneDayUpdate.Size = new System.Drawing.Size(117, 22);
            this.oneDayUpdate.Text = "24 hour";
            this.oneDayUpdate.Click += new System.EventHandler(this.OneDayUpdate_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // expandButton
            // 
            this.expandButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.expandButton.BackColor = System.Drawing.Color.DimGray;
            this.expandButton.FlatAppearance.BorderSize = 0;
            this.expandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expandButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expandButton.Location = new System.Drawing.Point(215, 195);
            this.expandButton.Name = "expandButton";
            this.expandButton.Size = new System.Drawing.Size(15, 23);
            this.expandButton.TabIndex = 14;
            this.expandButton.Text = ">";
            this.expandButton.UseVisualStyleBackColor = false;
            this.expandButton.Visible = false;
            this.expandButton.Click += new System.EventHandler(this.ExpandBtn_Click);
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.BackColor = System.Drawing.Color.AliceBlue;
            this.fileGroupBox.Controls.Add(this.FileFlowLayout);
            this.fileGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fileGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileGroupBox.Location = new System.Drawing.Point(218, 233);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(612, 199);
            this.fileGroupBox.TabIndex = 12;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "Files";
            // 
            // FileFlowLayout
            // 
            this.FileFlowLayout.AutoScroll = true;
            this.FileFlowLayout.BackColor = System.Drawing.Color.White;
            this.FileFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FileFlowLayout.Location = new System.Drawing.Point(3, 18);
            this.FileFlowLayout.Name = "FileFlowLayout";
            this.FileFlowLayout.Size = new System.Drawing.Size(606, 178);
            this.FileFlowLayout.TabIndex = 0;
            // 
            // assignmentGroupBox
            // 
            this.assignmentGroupBox.AutoSize = true;
            this.assignmentGroupBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.assignmentGroupBox.Controls.Add(this.AssignmentFlowLayout);
            this.assignmentGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignmentGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignmentGroupBox.ForeColor = System.Drawing.Color.Black;
            this.assignmentGroupBox.Location = new System.Drawing.Point(218, 0);
            this.assignmentGroupBox.Name = "assignmentGroupBox";
            this.assignmentGroupBox.Size = new System.Drawing.Size(361, 233);
            this.assignmentGroupBox.TabIndex = 11;
            this.assignmentGroupBox.TabStop = false;
            this.assignmentGroupBox.Text = "Assignments";
            // 
            // AssignmentFlowLayout
            // 
            this.AssignmentFlowLayout.AutoScroll = true;
            this.AssignmentFlowLayout.BackColor = System.Drawing.Color.White;
            this.AssignmentFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssignmentFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AssignmentFlowLayout.Location = new System.Drawing.Point(3, 18);
            this.AssignmentFlowLayout.Name = "AssignmentFlowLayout";
            this.AssignmentFlowLayout.Size = new System.Drawing.Size(355, 212);
            this.AssignmentFlowLayout.TabIndex = 0;
            // 
            // notesGroupBox
            // 
            this.notesGroupBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.notesGroupBox.Controls.Add(this.notesTextBox);
            this.notesGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.notesGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notesGroupBox.Location = new System.Drawing.Point(579, 0);
            this.notesGroupBox.Name = "notesGroupBox";
            this.notesGroupBox.Size = new System.Drawing.Size(251, 233);
            this.notesGroupBox.TabIndex = 15;
            this.notesGroupBox.TabStop = false;
            this.notesGroupBox.Text = "Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesTextBox.Location = new System.Drawing.Point(3, 18);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.ReadOnly = true;
            this.notesTextBox.Size = new System.Drawing.Size(245, 212);
            this.notesTextBox.TabIndex = 0;
            // 
            // dueDateTimer
            // 
            this.dueDateTimer.Interval = 1000;
            this.dueDateTimer.Tick += new System.EventHandler(this.DueDateTimer_Tick);
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tutorialToolStripMenuItem.Text = "Tutorial";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.tutorialToolStripMenuItem_Click);
            // 
            // MainUIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(830, 432);
            this.Controls.Add(this.expandButton);
            this.Controls.Add(this.assignmentGroupBox);
            this.Controls.Add(this.notesGroupBox);
            this.Controls.Add(this.fileGroupBox);
            this.Controls.Add(this.collapsePanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(846, 471);
            this.Name = "MainUIFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainUIFrm_FormClosing);
            this.Load += new System.EventHandler(this.MainUIFrm_Load);
            this.classesGroupBox.ResumeLayout(false);
            this.collapsePanel.ResumeLayout(false);
            this.collapsePanel.PerformLayout();
            this.addGroupBox.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.fileGroupBox.ResumeLayout(false);
            this.assignmentGroupBox.ResumeLayout(false);
            this.notesGroupBox.ResumeLayout(false);
            this.notesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox classesGroupBox;
        private Panel collapsePanel;
        private Button addAssignMainBtn;
        private Button addClassMainBtn;
        private FlowLayoutPanel classLayout;
        private GroupBox assignmentGroupBox;
        private FlowLayoutPanel AssignmentFlowLayout;
        private GroupBox fileGroupBox;
        private FlowLayoutPanel FileFlowLayout;
        private GroupBox addGroupBox;
        private Button addFileMainBtn;
        private Button collapseButton;
        private Button expandButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private GroupBox notesGroupBox;
        private TextBox notesTextBox;
        private ToolStripMenuItem startupToolStripMenuItem;
        private ToolStripMenuItem onToolStripMenuItem;
        private ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.Timer dueDateTimer;
        private ToolStripMenuItem notificationsToolStripMenuItem;
        private ToolStripMenuItem notificationsOnButton;
        private ToolStripMenuItem notificationsOffButton;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem fiveMinuteUpdate;
        private ToolStripMenuItem oneHourUpdate;
        private ToolStripMenuItem twelveHourUpdate;
        private ToolStripMenuItem oneDayUpdate;
        private ToolStripMenuItem appearanceToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ColorDialog colDialog;
        private ToolStripMenuItem tutorialToolStripMenuItem;
    }
}