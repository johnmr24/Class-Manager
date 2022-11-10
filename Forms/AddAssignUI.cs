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
        }

        private void AddAssignBtn_Click(object sender, EventArgs e)
        {
            Assignment a = new();
            a.EditName(assignNameTxtBx.Text.ToString());
            a.EditDueDate(dateTimePicker.Value);
            a.EditDueDateTime(timePicker.Value);

            user.classes[classIndex].AddAssignment(a);

            Close();
        }
    }
}
