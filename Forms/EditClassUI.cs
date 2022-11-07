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
        private int classIndex;
        private User user;
        public EditClassFrm(User u, int index)
        {
            InitializeComponent();
            classIndex = index;
            user = u;
            //set the textbox to the name of the class
            classNameTxtBx.Text = user.getClasses()[index].getName();
            //set the title of the form to the name of the class
            Text = "Edit Class " + user.getClasses()[index].getName();
        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            //set the name of the class to the text in the text box
            user.getClasses()[classIndex].setName(classNameTxtBx.Text);
           
            classNameTxtBx.Clear();
        }

        private void addClassBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
