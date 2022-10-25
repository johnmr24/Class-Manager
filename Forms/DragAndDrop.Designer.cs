namespace Class_Manager
{
    partial class DragAndDropFrm
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
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(293, 105);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(112, 23);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // fileLocation
            // 
            this.fileLocation.AllowDrop = true;
            this.fileLocation.Location = new System.Drawing.Point(4, 105);
            this.fileLocation.Name = "fileLocation";
            this.fileLocation.Size = new System.Drawing.Size(283, 23);
            this.fileLocation.TabIndex = 1;
            this.fileLocation.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileLocation_DragDrop);
            this.fileLocation.DragOver += new System.Windows.Forms.DragEventHandler(this.fileLocation_DragOver);
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(147, 161);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(120, 39);
            this.addFileButton.TabIndex = 2;
            this.addFileButton.Text = "Add File";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addClassButton_Click);
            // 
            // DragAndDropFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(417, 243);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.fileLocation);
            this.Controls.Add(this.selectFileButton);
            this.Name = "DragAndDropFrm";
            this.Text = "Drag and Drop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button selectFileButton;
        private TextBox fileLocation;
        private Button addFileButton;
    }
}