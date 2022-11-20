﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Class_Manager.Model;
using Class_Manager.Properties;
using static System.Net.Mime.MediaTypeNames;

namespace Class_Manager.Forms 
{
    public partial class TutorialUIFrm : Form
    {
        private readonly User user;
        public int pagenum = 1;
        public List<string> TutorialText = new();
        public TutorialUIFrm(User u)
        {
            InitializeComponent();
            TutorialText.Add("Welcome to Class Manager! This tutorial will teach you the basics of the software. Above is the Main UI. This UI allows you to add classes, assignments, and attach files to assignments with the Add buttons at the top. You may also choose to recieve notifications, change colors, and toggle startup in the settings.");
            TutorialText.Add("This is the Add Class UI. To add a class, simply type it's name into the box and press Add. The class you just added should appear in the Classes box. You may double click your added class to change it's name at any time.");
            TutorialText.Add("After adding a class, you can click it and press the Assignments button to add an assignment. Enter the name of the assignment, it's due date, and anything you would like to note about said assignment. It will appear in the assignments box when you have the appropriate class selected. You can double click an assignment to change it's due date, notes, or name at any time.");
            TutorialText.Add("You can associate a file/file path with an assignment if you need to. Select the appropriate class, and then the assignment you want to add a file to. Press the File button to be prompted with a dialog to enter the file path. In this dialog, you can either open a second dialog to manually navigate to your file, or manually enter the file path in the text box.");
            TutorialText.Add("This concludes the tutorial for Class Manager. Remember, you can double click any class, assignment, or file to edit or remove them. You can also manually edit the XML loaded at startup by navigating to the Documents folder and finding the Class Manager folder. This is ONLY recommended to advanced users with XML knowledge, or anyone that needs to reset their Class Manager startup by deleting it.");
 
            user = u;
            
        }

        private void NextBttn_Click(object sender, EventArgs e)
        {
            if (pagenum >= 5)
            {
                pagenum = 5;
            }
            else
            {
                pagenum++;
            }
            if (pagenum == 1)
            {
                this.TutorialBox.Text = TutorialText[0];
                TutorialPicture.Image = Class_Manager.Properties.Resources.Demo1;
            }
            else if (pagenum == 2)
            {
                TutorialBox.Text = TutorialText[1];
                TutorialPicture.Image = Class_Manager.Properties.Resources.Demo2;
            }
            else if (pagenum == 3)
            {
                TutorialBox.Text = TutorialText[2];
                TutorialPicture.Image = Class_Manager.Properties.Resources.Demo4;

            }
            else if (pagenum == 4)
            {
                TutorialBox.Text = TutorialText[3];
                TutorialPicture.Image = Class_Manager.Properties.Resources.Demo5;
            }
            else if (pagenum == 5)
            {
                TutorialBox.Text = TutorialText[4];
                TutorialPicture.Image = Class_Manager.Properties.Resources.Demo6;
            }

        }

        private void PrevBttn_Click(object sender, EventArgs e)
        {
            if (pagenum <= 0)
            {
                pagenum = 1;
            }
            else
            {
                pagenum--;
            }
            if (pagenum == 1)
            {
                this.TutorialBox.Text = TutorialText[0];
                TutorialPicture.Image = Class_Manager.Properties.Resources.Demo1;
            }
            else if (pagenum == 2)
            {
                TutorialBox.Text = TutorialText[1];
                TutorialPicture.Image = Class_Manager.Properties.Resources.Demo2;
            }
            else if (pagenum == 3)
            {
                TutorialBox.Text = TutorialText[2];
                TutorialPicture.Image = Class_Manager.Properties.Resources.Demo4;

            }
            else if (pagenum == 4)
            {
                TutorialBox.Text = TutorialText[3];
                TutorialPicture.Image = Class_Manager.Properties.Resources.Demo5;
            }
            else if (pagenum == 5)
            {
                TutorialBox.Text = TutorialText[4];
                TutorialPicture.Image = Class_Manager.Properties.Resources.Demo6;
            }
        }

        private void TutorialUIFrm_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(255, Math.Min((user.Col.R + 50), 255), Math.Min((user.Col.G + 50), 255), Math.Min((user.Col.B + 50), 255));

        }
    }
}
