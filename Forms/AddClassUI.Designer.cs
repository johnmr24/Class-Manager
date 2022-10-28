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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classNameTxtBx
            // 
            this.classNameTxtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classNameTxtBx.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classNameTxtBx.Location = new System.Drawing.Point(60, 18);
            this.classNameTxtBx.Name = "classNameTxtBx";
            this.classNameTxtBx.Size = new System.Drawing.Size(222, 22);
            this.classNameTxtBx.TabIndex = 5;
            // 
            // classNameLbl
            // 
            this.classNameLbl.AutoSize = true;
            this.classNameLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.classNameLbl.Location = new System.Drawing.Point(6, 24);
            this.classNameLbl.Name = "classNameLbl";
            this.classNameLbl.Size = new System.Drawing.Size(50, 16);
            this.classNameLbl.TabIndex = 4;
            this.classNameLbl.Text = "Name:";
            // 
            // addClassBtn
            // 
            this.addClassBtn.BackColor = System.Drawing.Color.White;
            this.addClassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClassBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addClassBtn.Location = new System.Drawing.Point(242, 61);
            this.addClassBtn.Name = "addClassBtn";
            this.addClassBtn.Size = new System.Drawing.Size(51, 24);
            this.addClassBtn.TabIndex = 6;
            this.addClassBtn.Text = "Add";
            this.addClassBtn.UseVisualStyleBackColor = false;
            this.addClassBtn.Click += new System.EventHandler(this.addClassBtn_Click);
            this.addClassBtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addClassBtn_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classNameLbl);
            this.groupBox1.Controls.Add(this.addClassBtn);
            this.groupBox1.Controls.Add(this.classNameTxtBx);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // AddClassFrm
            // 
            this.AcceptButton = this.addClassBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(324, 117);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "AddClassFrm";
            this.Text = "Add Class";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddClassFrm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox classNameTxtBx;
        private Label classNameLbl;
        private Button addClassBtn;
        private GroupBox groupBox1;
    }
}