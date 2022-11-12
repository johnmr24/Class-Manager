namespace Class_Manager
{
    partial class EditFileFrm
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
            this.EditFileButton = new System.Windows.Forms.Button();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteFileButton = new System.Windows.Forms.Button();
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
            // EditFileButton
            // 
            this.EditFileButton.BackColor = System.Drawing.Color.LightGray;
            this.EditFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditFileButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditFileButton.Location = new System.Drawing.Point(12, 75);
            this.EditFileButton.Name = "EditFileButton";
            this.EditFileButton.Size = new System.Drawing.Size(51, 24);
            this.EditFileButton.TabIndex = 2;
            this.EditFileButton.Text = "Edit";
            this.EditFileButton.UseVisualStyleBackColor = false;
            this.EditFileButton.Click += new System.EventHandler(this.EditClassButton_Click);
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
            // DeleteFileButton
            // 
            this.DeleteFileButton.BackColor = System.Drawing.Color.LightGray;
            this.DeleteFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFileButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteFileButton.Location = new System.Drawing.Point(258, 75);
            this.DeleteFileButton.Name = "DeleteFileButton";
            this.DeleteFileButton.Size = new System.Drawing.Size(54, 24);
            this.DeleteFileButton.TabIndex = 3;
            this.DeleteFileButton.Text = "Delete";
            this.DeleteFileButton.UseVisualStyleBackColor = false;
            this.DeleteFileButton.Click += new System.EventHandler(this.DeleteFileButton_Click);
            // 
            // EditFileFrm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(324, 107);
            this.Controls.Add(this.DeleteFileButton);
            this.Controls.Add(this.EditFileButton);
            this.Controls.Add(this.fileGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(340, 146);
            this.MinimumSize = new System.Drawing.Size(340, 146);
            this.Name = "EditFileFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit File";
            this.Load += new System.EventHandler(this.EditFileFrm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AddFileFrm_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.AddFileFrm_DragOver);
            this.fileGroupBox.ResumeLayout(false);
            this.fileGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button selectFileButton;
        private TextBox fileLocation;
        private Button EditFileButton;
        private GroupBox fileGroupBox;
        private Button DeleteFileButton;
    }
}