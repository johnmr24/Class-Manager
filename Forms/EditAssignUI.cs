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
    public partial class EditAssignFrm : Form
    {
        private int classIndex;
        private int assignIndex;
        private User user;
        public EditAssignFrm(User u, int clsIndex, int assignmentIndex)
        {
            InitializeComponent();
            this.classIndex = clsIndex;
            this.assignIndex = assignmentIndex;
            this.user = u;
            //set datepicker date to the date currently in the assignment
            dateTimePicker.Value = user.getClasses()[classIndex].getAssignments()[assignIndex].getDueDate();

            //set the textbox to the name of the assignment
            assignNameTxtBx.Text = user.getClasses()[classIndex].getAssignments()[assignIndex].getName();

            //set the title of the form to the name of the assignment
            Text = "Edit Assignment " + user.getClasses()[classIndex].getAssignments()[assignIndex].getName();
        }

        private void addAssignBtn_Click(object sender, EventArgs e)
        {
            //change name and date of assignment to what is set by user
            user.getClasses()[classIndex].getAssignments()[assignIndex].editName(assignNameTxtBx.Text);
            user.getClasses()[classIndex].getAssignments()[assignIndex].editDueDate(dateTimePicker.Value);

            Close();
        }
    }
}
