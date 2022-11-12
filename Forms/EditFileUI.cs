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
    public partial class EditFileFrm : Form
    {
        private readonly User user;
        private readonly int classIndex;
        private readonly int fileIndex;
        private readonly int assignIndex;
        public EditFileFrm(User u, int clsIndex, int asgnIndex, int fleIndex)
        {
            InitializeComponent();
            user = u;
            classIndex = clsIndex;
            this.fileIndex = fleIndex;
            this.assignIndex = asgnIndex;
            fileLocation.Text = user.Classes[classIndex].Assignments[assignIndex].Files[fleIndex].Path;
        }

        private void EditClassButton_Click(object sender, EventArgs e)
        {
            //change file to the inputted file location
            user.Classes[classIndex].Assignments[assignIndex].Files[fileIndex].Path = fileLocation.Text;
            //Refresh the file name using the path
            user.Classes[classIndex].Assignments[assignIndex].Files[fileIndex].Name = fileLocation.Text.Substring(fileLocation.Text.LastIndexOf('\\') + 1);
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

        private void DeleteFileButton_Click(object sender, EventArgs e)
        {
            //delete file selected
            user.Classes[classIndex].Assignments[assignIndex].Files.RemoveAt(fileIndex);
            Close();
        }

        private void EditFileFrm_Load(object sender, EventArgs e)
        {
            fileGroupBox.BackColor = user.Col;
            BackColor = Color.FromArgb(255, Math.Min((user.Col.R + 50), 255), Math.Min((user.Col.G + 50), 255), Math.Min((user.Col.B + 50), 255));
        }
    }
}
