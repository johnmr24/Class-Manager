namespace Class_Manager.Forms
{
    partial class EditAssignmentUI
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
            this.saveChangesAssignmentBtn = new System.Windows.Forms.Button();
            this.dateTimePickerEdit = new System.Windows.Forms.DateTimePicker();
            this.editNameAssignmentTxtBx = new System.Windows.Forms.TextBox();
            this.assignNameLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveChangesAssignmentBtn
            // 
            this.saveChangesAssignmentBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveChangesAssignmentBtn.Location = new System.Drawing.Point(93, 165);
            this.saveChangesAssignmentBtn.Name = "saveChangesAssignmentBtn";
            this.saveChangesAssignmentBtn.Size = new System.Drawing.Size(102, 44);
            this.saveChangesAssignmentBtn.TabIndex = 9;
            this.saveChangesAssignmentBtn.Text = "Save Changes";
            this.saveChangesAssignmentBtn.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEdit
            // 
            this.dateTimePickerEdit.Location = new System.Drawing.Point(44, 119);
            this.dateTimePickerEdit.Name = "dateTimePickerEdit";
            this.dateTimePickerEdit.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerEdit.TabIndex = 8;
            // 
            // editNameAssignmentTxtBx
            // 
            this.editNameAssignmentTxtBx.Location = new System.Drawing.Point(78, 82);
            this.editNameAssignmentTxtBx.Name = "editNameAssignmentTxtBx";
            this.editNameAssignmentTxtBx.Size = new System.Drawing.Size(193, 23);
            this.editNameAssignmentTxtBx.TabIndex = 7;
            // 
            // assignNameLbl
            // 
            this.assignNameLbl.AutoSize = true;
            this.assignNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignNameLbl.Location = new System.Drawing.Point(12, 80);
            this.assignNameLbl.Name = "assignNameLbl";
            this.assignNameLbl.Size = new System.Drawing.Size(60, 21);
            this.assignNameLbl.TabIndex = 6;
            this.assignNameLbl.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 49);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Leave the name box empty if you do not want to change the name.";
            // 
            // EditAssignmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(289, 234);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.saveChangesAssignmentBtn);
            this.Controls.Add(this.dateTimePickerEdit);
            this.Controls.Add(this.editNameAssignmentTxtBx);
            this.Controls.Add(this.assignNameLbl);
            this.Name = "EditAssignmentUI";
            this.Text = "Edit Assignment";
            this.Load += new System.EventHandler(this.EditAssignmentUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button saveChangesAssignmentBtn;
        private DateTimePicker dateTimePickerEdit;
        private TextBox editNameAssignmentTxtBx;
        private Label assignNameLbl;
        private TextBox textBox1;
    }
}