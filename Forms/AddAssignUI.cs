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
    public partial class AddAssignFrm : Form
    {
        private readonly User user;
        private readonly int classIndex;
        public AddAssignFrm(User u, int clsIndex)
        {
            InitializeComponent();
            user = u;
            classIndex = clsIndex;
            dateTimePicker.Value = DateTime.Today.AddDays(1);
        }

        private void AddAssignBtn_Click(object sender, EventArgs e)
        {

            //If textbox.text is empty or spaces, prompt user to enter a name
            if (string.IsNullOrWhiteSpace(assignNameTxtBx.Text))
            {
                MessageBox.Show("Please enter a name for the assignment.");
                return;
            }
            
            Assignment a = new()
            {
                Notes = notesTextBox.Text.ToString(),

                Name = assignNameTxtBx.Text.ToString(),
                DueDate = dateTimePicker.Value
            };
            a.AddTime(timePicker.Value);
            user.classes[classIndex].Assignments.Add(a);

            Close();
        }
    }
}
