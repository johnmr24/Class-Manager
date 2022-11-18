using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Manager.Model;

namespace Class_Manager
{
    public partial class AddFileFrm : Form
    {
        private readonly User user;
        private readonly int classIndex;
        private readonly int assignmentIndex;
        public AddFileFrm(User u, int clsIndex, int asgnIndex)
        {
            InitializeComponent();
            user = u;
            classIndex = clsIndex;
            assignmentIndex = asgnIndex;
        }

        private void AddFileButton_Click(object sender, EventArgs e)
        {
            //If textbox.text is empty or spaces or not valid file, prompt user to enter a name
            if (string.IsNullOrWhiteSpace(fileLocation.Text) || !System.IO.File.Exists(fileLocation.Text))
            {
                MessageBox.Show("Please enter a valid file.");
                return;
            }
            //check if name is already taken by another file in user
            for (int i = 0; i < user.classes[classIndex].assignments[assignmentIndex].Files.Count; i++)
            {
                if (fileLocation.Text == user.classes[classIndex].assignments[assignmentIndex].Files[i].Path)
                {
                    MessageBox.Show("Please enter a file not already used.");
                    return;
                }
            }
            Class_Manager.Model.File f = new(fileLocation.Text.Substring(fileLocation.Text.LastIndexOf('\\') + 1), fileLocation.Text);

            user.Classes[classIndex].Assignments[assignmentIndex].Files.Add(f);
            Close();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialog = new();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileLocation.Text = dialog.FileName;
            }
        }

        private void AddFileFrm_DragDrop(object sender, DragEventArgs e)
        {
            // get all files droppeds  
            if (e.Data != null && e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Any())
                //check to see if file location is a file
                if (System.IO.File.Exists(files[0]))
                    fileLocation.Text = files[0];
        }

        private void AddFileFrm_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.FileDrop) && System.IO.File.Exists(((string[])e.Data.GetData(DataFormats.FileDrop))[0]))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void AddFileFrm_Load(object sender, EventArgs e)
        {
            fileGroupBox.BackColor = user.Col;
            BackColor = Color.FromArgb(255, Math.Min((user.Col.R + 50), 255), Math.Min((user.Col.G + 50), 255), Math.Min((user.Col.B + 50), 255));

            if (user.Col.R + user.Col.G + user.Col.B > 200)
            {
                fileGroupBox.ForeColor = Color.Black;
            }
            else
            {
                fileGroupBox.ForeColor = Color.White;
                selectFileButton.ForeColor = Color.Black;
            }
        }
    }
}
