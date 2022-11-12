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

        private void AddAssignFrm_Load(object sender, EventArgs e)
        {
            dueDateGroupBox.BackColor = user.Col;
            BackColor = Color.FromArgb(255, Math.Min((user.Col.R + 50), 255), Math.Min((user.Col.G + 50), 255), Math.Min((user.Col.B + 50), 255));
        }
    }
}
