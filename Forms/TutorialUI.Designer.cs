namespace Class_Manager.Forms
{
    partial class TutorialUIFrm
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
            this.TutorialBox = new System.Windows.Forms.RichTextBox();
            this.TutorialPicture = new System.Windows.Forms.PictureBox();
            this.NextBttn = new System.Windows.Forms.Button();
            this.PrevBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TutorialPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TutorialBox
            // 
            this.TutorialBox.Location = new System.Drawing.Point(12, 220);
            this.TutorialBox.Name = "TutorialBox";
            this.TutorialBox.Size = new System.Drawing.Size(425, 167);
            this.TutorialBox.TabIndex = 0;
            this.TutorialBox.Text = "";
            // 
            // TutorialPicture
            // 
            this.TutorialPicture.Image = global::Class_Manager.Properties.Resources.Demo1;
            this.TutorialPicture.Location = new System.Drawing.Point(12, 12);
            this.TutorialPicture.Name = "TutorialPicture";
            this.TutorialPicture.Size = new System.Drawing.Size(425, 202);
            this.TutorialPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TutorialPicture.TabIndex = 1;
            this.TutorialPicture.TabStop = false;
            // 
            // NextBttn
            // 
            this.NextBttn.Location = new System.Drawing.Point(362, 393);
            this.NextBttn.Name = "NextBttn";
            this.NextBttn.Size = new System.Drawing.Size(75, 23);
            this.NextBttn.TabIndex = 2;
            this.NextBttn.Text = "Next";
            this.NextBttn.UseVisualStyleBackColor = true;
            this.NextBttn.Click += new System.EventHandler(this.NextBttn_Click);
            // 
            // PrevBttn
            // 
            this.PrevBttn.Location = new System.Drawing.Point(12, 393);
            this.PrevBttn.Name = "PrevBttn";
            this.PrevBttn.Size = new System.Drawing.Size(75, 23);
            this.PrevBttn.TabIndex = 3;
            this.PrevBttn.Text = "Prev";
            this.PrevBttn.UseVisualStyleBackColor = true;
            this.PrevBttn.Click += new System.EventHandler(this.PrevBttn_Click);
            // 
            // TutorialUIFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(449, 428);
            this.Controls.Add(this.PrevBttn);
            this.Controls.Add(this.NextBttn);
            this.Controls.Add(this.TutorialPicture);
            this.Controls.Add(this.TutorialBox);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "TutorialUIFrm";
            this.Text = "Tutorial";
            this.Load += new System.EventHandler(this.TutorialUIFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TutorialPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox TutorialBox;
        private PictureBox TutorialPicture;
        private Button NextBttn;
        private Button PrevBttn;
    }
}