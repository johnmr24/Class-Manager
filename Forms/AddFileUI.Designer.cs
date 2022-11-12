namespace Class_Manager
{
    partial class AddFileFrm
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
            this.selectFileButton = new System.Windows.Forms.Button();
            this.fileLocation = new System.Windows.Forms.TextBox();
            this.addFileButton = new System.Windows.Forms.Button();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.fileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.BackColor = System.Drawing.Color.LightGray;
            this.selectFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFileButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectFileButton.Location = new System.Drawing.Point(216, 22);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(74, 23);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = false;
            this.selectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // fileLocation
            // 
            this.fileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileLocation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileLocation.Location = new System.Drawing.Point(6, 22);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(204, 22);
            this.fileLocation.TabIndex = 1;
            // 
            // addFileButton
            // 
            this.addFileButton.BackColor = System.Drawing.Color.LightGray;
            this.addFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFileButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addFileButton.Location = new System.Drawing.Point(137, 75);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(51, 24);
            this.addFileButton.TabIndex = 2;
            this.addFileButton.Text = "Add";
            this.addFileButton.UseVisualStyleBackColor = false;
            this.addFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Controls.Add(this.fileLocation);
            this.fileGroupBox.Controls.Add(this.selectFileButton);
            this.fileGroupBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileGroupBox.Location = new System.Drawing.Point(12, 12);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(299, 57);
            this.fileGroupBox.TabIndex = 3;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "File";
            // 
            // AddFileFrm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(324, 107);
            this.Controls.Add(this.fileGroupBox);
            this.Controls.Add(this.addFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(340, 146);
            this.MinimumSize = new System.Drawing.Size(340, 146);
            this.Name = "AddFileFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add File";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AddFileFrm_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.AddFileFrm_DragOver);
            this.fileGroupBox.ResumeLayout(false);
            this.fileGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button selectFileButton;
        private TextBox fileLocation;
        private Button addFileButton;
        private GroupBox fileGroupBox;
    }
}