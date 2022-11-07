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
        private MainUIFrm mainUIFrm;
        public AddFileFrm()
        {
            InitializeComponent();
            mainUIFrm = new MainUIFrm();
        }

        public void SetMainUIForm(MainUIFrm f)
        {
            mainUIFrm = f;
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            Class_Manager.Model.File f = new();
            f.SetPath(fileLocation.Text);

            mainUIFrm.AddFile(f);

            Close();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileLocation.Text = dialog.FileName;
                }
            }
        }

        private void AddFileFrm_DragDrop(object sender, DragEventArgs e)
        {
            // get all files droppeds  
            if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Any())
                //check to see if file location is a file
                if (System.IO.File.Exists(files[0]))
                    fileLocation.Text = files[0];
        }

        private void AddFileFrm_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && System.IO.File.Exists(((string[])e.Data.GetData(DataFormats.FileDrop))[0]))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
