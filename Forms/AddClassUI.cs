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
    public partial class AddClassFrm : Form
    {
        private readonly User user;
        
        //Initialize add class form
        public AddClassFrm(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        //Add class to class list and show on main form
        private void AddClassBtn_Click(object sender, EventArgs e)
        {
            Class c;
            //If textbox.text is empty or spaces, prompt user to enter a name
            if (string.IsNullOrWhiteSpace(classNameTxtBx.Text))
            {
                MessageBox.Show("Please enter a name for the class.");
                return;
            }
            //check if name is already taken by another class in user
            for (int i = 0; i < user.classes.Count; i++)
            {
                if (classNameTxtBx.Text == user.classes[i].Name)
                {
                    MessageBox.Show("Please enter a name not already used.");
                    return;
                }
            }
            
            //Set class name
            c = new(classNameTxtBx.Text.ToString());

            user.classes.Add(c);

            Close();
        }

        //Load user's chosen color from main form to add class form
        private void AddClassFrm_Load(object sender, EventArgs e)
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
