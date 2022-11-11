namespace Class_Manager
{
    partial class EditAssignFrm
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
            this.assignNameLbl = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EditAssignBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.notesLbl = new System.Windows.Forms.Label();
            this.DeleteAssignBtn = new System.Windows.Forms.Button();
            this.dueDateLbl = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignNameTxtBx
            // 
            this.assignNameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assignNameTxtBx.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.assignNameTxtBx.Location = new System.Drawing.Point(60, 18);
            this.assignNameTxtBx.Name = "assignNameTxtBx";
            this.assignNameTxtBx.Size = new System.Drawing.Size(263, 22);
            this.assignNameTxtBx.TabIndex = 3;
            // 
            // assignNameLbl
            // 
            this.assignNameLbl.AutoSize = true;
            this.assignNameLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignNameLbl.Location = new System.Drawing.Point(6, 24);
            this.assignNameLbl.Name = "assignNameLbl";
            this.assignNameLbl.Size = new System.Drawing.Size(50, 16);
            this.assignNameLbl.TabIndex = 2;
            this.assignNameLbl.Text = "Name:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(82, 56);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(241, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // EditAssignBtn
            // 
            this.EditAssignBtn.BackColor = System.Drawing.Color.White;
            this.EditAssignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditAssignBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditAssignBtn.Location = new System.Drawing.Point(6, 252);
            this.EditAssignBtn.Name = "EditAssignBtn";
            this.EditAssignBtn.Size = new System.Drawing.Size(51, 24);
            this.EditAssignBtn.TabIndex = 5;
            this.EditAssignBtn.Text = "Edit";
            this.EditAssignBtn.UseVisualStyleBackColor = false;
            this.EditAssignBtn.Click += new System.EventHandler(this.AddAssignBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timePicker);
            this.groupBox1.Controls.Add(this.notesTextBox);
            this.groupBox1.Controls.Add(this.notesLbl);
            this.groupBox1.Controls.Add(this.DeleteAssignBtn);
            this.groupBox1.Controls.Add(this.dueDateLbl);
            this.groupBox1.Controls.Add(this.EditAssignBtn);
            this.groupBox1.Controls.Add(this.assignNameLbl);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.assignNameTxtBx);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 285);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // notesTextBox
            // 
            this.notesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.notesTextBox.Location = new System.Drawing.Point(6, 111);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(317, 136);
            this.notesTextBox.TabIndex = 8;
            // 
            // notesLbl
            // 
            this.notesLbl.AutoSize = true;
            this.notesLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notesLbl.Location = new System.Drawing.Point(6, 92);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(47, 16);
            this.notesLbl.TabIndex = 7;
            this.notesLbl.Text = "Notes:";
            // 
            // DeleteAssignBtn
            // 
            this.DeleteAssignBtn.BackColor = System.Drawing.Color.White;
            this.DeleteAssignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAssignBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteAssignBtn.Location = new System.Drawing.Point(270, 253);
            this.DeleteAssignBtn.Name = "DeleteAssignBtn";
            this.DeleteAssignBtn.Size = new System.Drawing.Size(53, 23);
            this.DeleteAssignBtn.TabIndex = 6;
            this.DeleteAssignBtn.Text = "Delete";
            this.DeleteAssignBtn.UseVisualStyleBackColor = false;
            this.DeleteAssignBtn.Click += new System.EventHandler(this.DeleteAssignBtn_Click);
            // 
            // dueDateLbl
            // 
            this.dueDateLbl.AutoSize = true;
            this.dueDateLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dueDateLbl.Location = new System.Drawing.Point(6, 60);
            this.dueDateLbl.Name = "dueDateLbl";
            this.dueDateLbl.Size = new System.Drawing.Size(70, 16);
            this.dueDateLbl.TabIndex = 4;
            this.dueDateLbl.Text = "Due Date:";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "";
            this.timePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(82, 84);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(241, 22);
            this.timePicker.TabIndex = 9;
            this.timePicker.Value = new System.DateTime(2022, 11, 10, 23, 59, 0, 0);
            // 
            // EditAssignFrm
            // 
            this.AcceptButton = this.EditAssignBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(353, 306);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "EditAssignFrm";
            this.Text = "Edit Assignment _";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox assignNameTxtBx;
        private Label assignNameLbl;
        private DateTimePicker dateTimePicker;
        private Button EditAssignBtn;
        private GroupBox groupBox1;
        private Label dueDateLbl;
        private Button DeleteAssignBtn;
        private Label notesLbl;
        private TextBox notesTextBox;
        private DateTimePicker timePicker;
    }
}