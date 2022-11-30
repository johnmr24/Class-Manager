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
        
        //Initialize edit class form
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

        //Edit class in class list and show on main form
        private void EditClassBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(classNameTxtBx.Text))
            {
                MessageBox.Show("Please enter a name for the class.");
                return;
            }
            //check if name is already taken by another class in user
            for (int i = 0; i < user.classes.Count; i++)
            {
                if (i == classIndex)
                    continue;
                if (classNameTxtBx.Text == user.classes[i].Name)
                {
                    MessageBox.Show("Please enter a name not already used.");
                    return;
                }
            }
            
            //update class name
            user.Classes[classIndex].Name = classNameTxtBx.Text;

            Close();
        }

        private void DeleteClassBtn_Click(object sender, EventArgs e)
        {
            //delete the class that is being edited
            user.Classes.RemoveAt(classIndex);
            Close();
        }

        //Load user's chosen color from main form to edit class form 
        private void EditClassFrm_Load(object sender, EventArgs e)
        {
            nameGroupBox.BackColor = user.Col;
            BackColor = Color.FromArgb(255, Math.Min((user.Col.R + 50), 255), Math.Min((user.Col.G + 50), 255), Math.Min((user.Col.B + 50), 255));

            //Change groupbox forecolor based on background color from user
            if (user.Col.R + user.Col.G + user.Col.B > 200)
            {
                nameGroupBox.ForeColor = Color.Black;
            }
            else
            {
                nameGroupBox.ForeColor = Color.White;
            }
        }
    }
}
