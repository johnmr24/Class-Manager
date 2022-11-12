﻿using System;
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
            notesTextBox.Text = user.Classes[classIndex].Assignments[assignIndex].Notes;

            //set the title of the form to the name of the assignment
            Text = "Edit Assignment " + user.Classes[classIndex].Assignments[assignIndex].Name;

            //set the timepicker to the time currently in the assignment
            timePicker.Value = user.Classes[classIndex].Assignments[assignIndex].DueDateTime;
        }

        private void EditAssignBtn_Click(object sender, EventArgs e)
        {
            //change name and date of assignment to what is set by user
            user.Classes[classIndex].Assignments[assignIndex].Name = assignNameTxtBx.Text;
            user.Classes[classIndex].Assignments[assignIndex].DueDate = dateTimePicker.Value;
            user.Classes[classIndex].Assignments[assignIndex].AddTime(timePicker.Value);
            //set the time of the assignment to 12am without changing date


            //user.Classes[classIndex].Assignments[assignIndex].DueDateTime = timePicker.Value;
            user.Classes[classIndex].Assignments[assignIndex].Notes = notesTextBox.Text;
            user.Classes[classIndex].Assignments[assignIndex].ShownNotification = false;

            Close();
        }

        private void DeleteAssignBtn_Click(object sender, EventArgs e)
        {
            //Delete the assignment selected
            user.Classes[classIndex].Assignments.RemoveAt(assignIndex);
            Close();
        }

        private void EditAssignFrm_Load(object sender, EventArgs e)
        {
            dueDateGroupBox.BackColor = user.Col;
            nameGroupBox.BackColor = user.Col;
            notesGroupBox.BackColor = user.Col;
            BackColor = Color.FromArgb(255, Math.Min((user.Col.R + 50), 255), Math.Min((user.Col.G + 50), 255), Math.Min((user.Col.B + 50), 255));
        }
    }
}
