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
            this.addClassBtn = new System.Windows.Forms.Button();
            this.nameGroupBox = new System.Windows.Forms.GroupBox();
            this.nameGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // classNameTxtBx
            // 
            this.classNameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classNameTxtBx.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classNameTxtBx.Location = new System.Drawing.Point(6, 21);
            this.classNameTxtBx.MaxLength = 30;
            this.classNameTxtBx.Name = "classNameTxtBx";
            this.classNameTxtBx.Size = new System.Drawing.Size(263, 22);
            this.classNameTxtBx.TabIndex = 5;
            // 
            // addClassBtn
            // 
            this.addClassBtn.BackColor = System.Drawing.Color.White;
            this.addClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClassBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addClassBtn.Location = new System.Drawing.Point(125, 74);
            this.addClassBtn.Name = "addClassBtn";
            this.addClassBtn.Size = new System.Drawing.Size(51, 24);
            this.addClassBtn.TabIndex = 6;
            this.addClassBtn.Text = "Add";
            this.addClassBtn.UseVisualStyleBackColor = false;
            this.addClassBtn.Click += new System.EventHandler(this.AddClassBtn_Click);
            // 
            // nameGroupBox
            // 
            this.nameGroupBox.Controls.Add(this.classNameTxtBx);
            this.nameGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameGroupBox.Location = new System.Drawing.Point(12, 12);
            this.nameGroupBox.Name = "nameGroupBox";
            this.nameGroupBox.Size = new System.Drawing.Size(277, 56);
            this.nameGroupBox.TabIndex = 7;
            this.nameGroupBox.TabStop = false;
            this.nameGroupBox.Text = "Name";
            // 
            // AddClassFrm
            // 
            this.AcceptButton = this.addClassBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(302, 105);
            this.Controls.Add(this.nameGroupBox);
            this.Controls.Add(this.addClassBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(318, 144);
            this.MinimumSize = new System.Drawing.Size(318, 144);
            this.Name = "AddClassFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Class";
            this.nameGroupBox.ResumeLayout(false);
            this.nameGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox classNameTxtBx;
        private Button addClassBtn;
        private GroupBox nameGroupBox;
    }
}