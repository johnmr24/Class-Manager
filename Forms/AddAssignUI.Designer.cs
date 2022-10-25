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
            this.assignNameLbl = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addAssignBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assignNameTxtBx
            // 
            this.assignNameTxtBx.Location = new System.Drawing.Point(105, 28);
            this.assignNameTxtBx.Name = "assignNameTxtBx";
            this.assignNameTxtBx.Size = new System.Drawing.Size(193, 23);
            this.assignNameTxtBx.TabIndex = 3;
            // 
            // assignNameLbl
            // 
            this.assignNameLbl.AutoSize = true;
            this.assignNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assignNameLbl.Location = new System.Drawing.Point(39, 30);
            this.assignNameLbl.Name = "assignNameLbl";
            this.assignNameLbl.Size = new System.Drawing.Size(60, 21);
            this.assignNameLbl.TabIndex = 2;
            this.assignNameLbl.Text = "Name:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(74, 66);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 4;
            // 
            // addAssignBtn
            // 
            this.addAssignBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addAssignBtn.Location = new System.Drawing.Point(122, 130);
            this.addAssignBtn.Name = "addAssignBtn";
            this.addAssignBtn.Size = new System.Drawing.Size(102, 44);
            this.addAssignBtn.TabIndex = 5;
            this.addAssignBtn.Text = "Add Assignment";
            this.addAssignBtn.UseVisualStyleBackColor = true;
            this.addAssignBtn.Click += new System.EventHandler(this.addAssignBtn_Click);
            // 
            // AddAssignFrm
            // 
            this.AcceptButton = this.addAssignBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(341, 196);
            this.Controls.Add(this.addAssignBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.assignNameTxtBx);
            this.Controls.Add(this.assignNameLbl);
            this.KeyPreview = true;
            this.Name = "AddAssignFrm";
            this.Text = "Add Assignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox assignNameTxtBx;
        private Label assignNameLbl;
        private DateTimePicker dateTimePicker;
        private Button addAssignBtn;
    }
}