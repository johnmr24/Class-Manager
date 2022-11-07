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
            this.addAssignBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dueDateLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignNameTxtBx
            // 
            this.assignNameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assignNameTxtBx.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.assignNameTxtBx.Location = new System.Drawing.Point(60, 18);
            this.assignNameTxtBx.Name = "assignNameTxtBx";
            this.assignNameTxtBx.Size = new System.Drawing.Size(247, 22);
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
            this.dateTimePicker.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker.TabIndex = 4;
            // 
            // addAssignBtn
            // 
            this.addAssignBtn.BackColor = System.Drawing.Color.White;
            this.addAssignBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAssignBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addAssignBtn.Location = new System.Drawing.Point(272, 100);
            this.addAssignBtn.Name = "addAssignBtn";
            this.addAssignBtn.Size = new System.Drawing.Size(51, 24);
            this.addAssignBtn.TabIndex = 5;
            this.addAssignBtn.Text = "Add";
            this.addAssignBtn.UseVisualStyleBackColor = false;
            this.addAssignBtn.Click += new System.EventHandler(this.addAssignBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dueDateLbl);
            this.groupBox1.Controls.Add(this.addAssignBtn);
            this.groupBox1.Controls.Add(this.assignNameLbl);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.assignNameTxtBx);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
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
            // AddAssignFrm
            // 
            this.AcceptButton = this.addAssignBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(353, 156);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "AddAssignFrm";
            this.Text = "Add Assignment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox assignNameTxtBx;
        private Label assignNameLbl;
        private DateTimePicker dateTimePicker;
        private Button addAssignBtn;
        private GroupBox groupBox1;
        private Label dueDateLbl;
    }
}