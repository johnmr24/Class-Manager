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
        private readonly int classIndex;
        private readonly int assignIndex;
        private readonly User user;
        public EditAssignFrm(User u, int clsIndex, int assignmentIndex)
        {
            InitializeComponent();
            this.classIndex = clsIndex;
            this.assignIndex = assignmentIndex;
            this.user = u;
            //set datepicker date to the date currently in the assignment
            dateTimePicker.Value = user.Classes[classIndex].Assignments[assignIndex].DueDate;

            //set the textbox to the name of the assignment
            assignNameTxtBx.Text = user.Classes[classIndex].Assignments[assignIndex].Name;

            //set the textbox to notes saved to assignment
            notesTextBox.Text = user.GetClasses()[classIndex].GetAssignments()[assignIndex].GetNotes();

            //set the title of the form to the name of the assignment
            Text = "Edit Assignment " + user.Classes[classIndex].Assignments[assignIndex].Name;
        }

        private void AddAssignBtn_Click(object sender, EventArgs e)
        {
            //change name and date of assignment to what is set by user
            user.Classes[classIndex].Assignments[assignIndex].Name = assignNameTxtBx.Text;
            user.Classes[classIndex].Assignments[assignIndex].DueDate = dateTimePicker.Value;
            user.GetClasses()[classIndex].GetAssignments()[assignIndex].EditNotes(notesTextBox.Text);

            Close();
        }

        private void DeleteAssignBtn_Click(object sender, EventArgs e)
        {
            //Delete the assignment selected
            user.Classes[classIndex].Assignments.RemoveAt(assignIndex);
            Close();
        }
    }
}
