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
    public partial class AddAssignFrm : Form
    {
        private MainUIFrm mainUIFrm;
        public AddAssignFrm()
        {
            InitializeComponent();
            mainUIFrm = new MainUIFrm();
        }

        public void SetMainUIForm(MainUIFrm f)
        {
            mainUIFrm = f;
        }

        private void AddAssignBtn_Click(object sender, EventArgs e)
        {
            Assignment a = new();
            a.EditName(assignNameTxtBx.Text.ToString());
            a.EditDueDate(dateTimePicker.Value);

            mainUIFrm.AddAssignment(a);

            Close();
        }
    }
}
