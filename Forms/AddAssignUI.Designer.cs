namespace Class_Manager
{
    partial class AddAssignFrm
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
            this.assignNameTxtBx = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addAssignBtn = new System.Windows.Forms.Button();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesGroupBox = new System.Windows.Forms.GroupBox();
            this.dueDateGroupBox = new System.Windows.Forms.GroupBox();
            this.nameGroupBox.SuspendLayout();
            this.notesGroupBox.SuspendLayout();
            this.dueDateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignNameTxtBx
            // 
            this.assignNameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assignNameTxtBx.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.assignNameTxtBx.Location = new System.Drawing.Point(6, 21);
            this.assignNameTxtBx.Name = "assignNameTxtBx";
            this.assignNameTxtBx.Size = new System.Drawing.Size(263, 22);
            this.assignNameTxtBx.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(6, 21);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.dateTimePicker.TabIndex = 4;
            this.dateTimePicker.Value = new System.DateTime(2022, 11, 10, 0, 0, 0, 0);
            // 
            // addAssignBtn
            // 
            this.addAssignBtn.BackColor = System.Drawing.Color.White;
            this.addAssignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAssignBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addAssignBtn.Location = new System.Drawing.Point(125, 331);
            this.addAssignBtn.Name = "addAssignBtn";
            this.addAssignBtn.Size = new System.Drawing.Size(51, 24);
            this.addAssignBtn.TabIndex = 5;
            this.addAssignBtn.Text = "Add";
            this.addAssignBtn.UseVisualStyleBackColor = false;
            this.addAssignBtn.Click += new System.EventHandler(this.AddAssignBtn_Click);
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.assignNameTxtBx);
            this.nameGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameGroupBox.Location = new System.Drawing.Point(12, 12);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(277, 56);
            this.nameGroupBox.TabIndex = 6;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Name";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "";
            this.timePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(6, 49);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(263, 22);
            this.timePicker.TabIndex = 6;
            this.timePicker.Value = new System.DateTime(2022, 11, 10, 23, 59, 0, 0);
            // 
            // notesTextBox
            // 
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notesTextBox.Location = new System.Drawing.Point(3, 18);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(271, 139);
            this.notesTextBox.TabIndex = 7;
            // 
            // notesGroupBox
            // 
            this.notesGroupBox.Controls.Add(this.notesTextBox);
            this.notesGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notesGroupBox.Location = new System.Drawing.Point(12, 165);
            this.notesGroupBox.Name = "notesGroupBox";
            this.notesGroupBox.Size = new System.Drawing.Size(277, 160);
            this.notesGroupBox.TabIndex = 8;
            this.notesGroupBox.TabStop = false;
            this.notesGroupBox.Text = "Notes";
            // 
            // dueDateGroupBox
            // 
            this.dueDateGroupBox.Controls.Add(this.timePicker);
            this.dueDateGroupBox.Controls.Add(this.dateTimePicker);
            this.dueDateGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dueDateGroupBox.Location = new System.Drawing.Point(12, 74);
            this.dueDateGroupBox.Name = "dueDateGroupBox";
            this.dueDateGroupBox.Size = new System.Drawing.Size(277, 85);
            this.dueDateGroupBox.TabIndex = 9;
            this.dueDateGroupBox.TabStop = false;
            this.dueDateGroupBox.Text = "Due Date";
            // 
            // AddAssignFrm
            // 
            this.AcceptButton = this.addAssignBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(302, 362);
            this.Controls.Add(this.dueDateGroupBox);
            this.Controls.Add(this.notesGroupBox);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.addAssignBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(318, 401);
            this.MinimumSize = new System.Drawing.Size(318, 401);
            this.Name = "AddAssignFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Assignment";
            this.Load += new System.EventHandler(this.AddAssignFrm_Load);
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.notesGroupBox.ResumeLayout(false);
            this.notesGroupBox.PerformLayout();
            this.dueDateGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox assignNameTxtBx;
        private DateTimePicker dateTimePicker;
        private Button addAssignBtn;
        private GroupBox nameGroupBox;
        private TextBox notesTextBox;
        private DateTimePicker timePicker;
        private GroupBox notesGroupBox;
        private GroupBox dueDateGroupBox;
    }
}