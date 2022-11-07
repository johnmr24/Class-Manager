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

        public void setMainUIForm(MainUIFrm f)
        {
            mainUIFrm = f;
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            Class_Manager.Model.File f = new Class_Manager.Model.File();
            f.setPath(fileLocation.Text);

            mainUIFrm.addFile(f);

            Close();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fileLocation.Text = dialog.FileName;
                }
            }
        }

        private void AddFileFrm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
                fileLocation.Text = files.First(); //select the first one
        }

        private void AddFileFrm_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
