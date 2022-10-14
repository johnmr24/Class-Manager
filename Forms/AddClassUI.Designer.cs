namespace Class_Manager
{
    partial class AddClassFrm
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
            this.classNameTxtBx = new System.Windows.Forms.TextBox();
            this.classNameLbl = new System.Windows.Forms.Label();
            this.addClassBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // classNameTxtBx
            // 
            this.classNameTxtBx.Location = new System.Drawing.Point(105, 46);
            this.classNameTxtBx.Name = "classNameTxtBx";
            this.classNameTxtBx.Size = new System.Drawing.Size(193, 23);
            this.classNameTxtBx.TabIndex = 5;
            // 
            // classNameLbl
            // 
            this.classNameLbl.AutoSize = true;
            this.classNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classNameLbl.Location = new System.Drawing.Point(39, 48);
            this.classNameLbl.Name = "classNameLbl";
            this.classNameLbl.Size = new System.Drawing.Size(60, 21);
            this.classNameLbl.TabIndex = 4;
            this.classNameLbl.Text = "Name:";
            // 
            // addClassBtn
            // 
            this.addClassBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addClassBtn.Location = new System.Drawing.Point(122, 106);
            this.addClassBtn.Name = "addClassBtn";
            this.addClassBtn.Size = new System.Drawing.Size(102, 44);
            this.addClassBtn.TabIndex = 6;
            this.addClassBtn.Text = "Add Class";
            this.addClassBtn.UseVisualStyleBackColor = true;
            this.addClassBtn.Click += new System.EventHandler(this.addClassBtn_Click);
            // 
            // AddClassFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(341, 196);
            this.Controls.Add(this.addClassBtn);
            this.Controls.Add(this.classNameTxtBx);
            this.Controls.Add(this.classNameLbl);
            this.Name = "AddClassFrm";
            this.Text = "Add Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox classNameTxtBx;
        private Label classNameLbl;
        private Button addClassBtn;
    }
}