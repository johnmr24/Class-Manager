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
    public partial class EditClassFrm : Form
    {
        private readonly int classIndex;
        private readonly User user;
        public EditClassFrm(User u, int index)
        {
            InitializeComponent();
            classIndex = index;
            user = u;
            //set the textbox to the name of the class
            classNameTxtBx.Text = user.Classes[index].Name;
            //set the title of the form to the name of the class
            Text = "Edit Class " + user.Classes[index].Name;
        }

        private void EditClassBtn_Click(object sender, EventArgs e)
        {
            //set the name of the class to the text in the text box
            user.Classes[classIndex].Name = classNameTxtBx.Text;

            Close();
        }

        private void DeleteClassBtn_Click(object sender, EventArgs e)
        {
            //delete the class that is being edited
            user.Classes.RemoveAt(classIndex);
            Close();
        }
    }
}
