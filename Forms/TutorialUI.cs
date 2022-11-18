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
using Class_Manager.Properties;
using static System.Net.Mime.MediaTypeNames;

namespace Class_Manager.Forms 
{
    public partial class TutorialUIFrm : Form
    {
        private readonly User user;
        public int pagenum = 1;

        public TutorialUIFrm(User u)
        {
            InitializeComponent();
            user = u;
            if (pagenum == 1)
            {
                this.TutorialBox.Text = "Welcome to Class Manager! This tutorial will guide you through the usage of this software, along with the basics of interacting with the UI.\r\n\r\nPictured above is the Main UI of the Class Manager, along with it's functions. Here is a list of them, along with how they are used:\r\n\r\nThe Add section features 3 buttons, Class, Assignment, and FIle. Clicking the Class button will open the \"Add Class\" dialog, \r\nwhich will allow you to add a class to the respective box below. The Assignment button will allow you to add an \r\nassignment to the class you have selected in the Classes box. Finally, the File box allows you to attach a file to your selected Assignment.\r\nSelecting an assignment is similar to selecting a class, except that the box for doing so is on the right of the UI.\r\n\r\nBelow all of these features, you will find the Menu Strip. Clicking one of the options will open it's sub menus.\r\nSettings allows you to turn notification on or off, which will be showcased later in the tutorial.\r\nThere's also the ability to edit the color of the UI. This change affects all of the windows in the application, and the\r\nfont color is automatically adjusted depending on the color chosen for readability.\r\n\r\nWhen you have adjusted to these options, click next for a walkthrough on adding a class, assignment, and a file to said assignment.\r\n";
            }
            else if (pagenum == 2)
            {
                TutorialBox.Text = "This is the Add Class UI. When you click the Class button in the Add group, you will be taken to this form. Here, you will be asked to make a new class. To do this, simply enter the name of the class and press the \"Add\" button. The class should appear in your Classes box if done correctly. For this tutorial, I'll be creating a class called Demonstration. Press next to continue. \r\n";
            }
            else if (pagenum == 3)
            {
                TutorialBox.Text = "Once you press the Add button, you should see your class. As you can see here, the Demonstration class has now been added to the box. Once a class is added, you can click it twice to edit or delete it through a dialog. Next, we'll create a Demonstration assignment. Click the class you have created, and then click the Assignment button in the Add box. Click next to continue.";
            }
            else if (pagenum == 4)
            {
                TutorialBox.Text = "To add an assignment to your class, as discussed in the previous page, click the class you have an assignment for in the Classes box, and then click the Assignment button in the Add group. When you do this, a dialogue will appear, as pictured above. In this dialog, you can enter the name of the assignment, it's Due Date, and anything you'd wish to note about it. If you have notifications enabled in the Settings of the menu strip, you will recieve a notification when the due date approaches. Once you have entered all of the information, you can click Add and create the assignment. It will show up in the Assignments box. ";
            }
            else if (pagenum == 5)
            {
                TutorialBox.Text = "Lastly, you can add a File for any Assignment you have in a class. To do this, click the File button in the Add group. You will be prompted with a dialog to select a file. To select a file, you can either manually type in it's file path, or click the Select File button to be prompted with a dialogue. This dialogue will allow you to navigate to the file you wish to add to the assignment. Once this is done, you will see the file in the Files box.";
            }
            else if (pagenum == 6)
            {
                TutorialBox.Text = "This concludes the tutorial on using Class Manager. If you follow the steps above, you should get a result similar to what is being shown above. Remember, you can access this tutorial at any time if you need help later. Thank you for using Class Manager!";
            }




        }
        private void NextBttn_MouseClick(object sender, MouseEventArgs e)
        {
            if (pagenum >= 6)
            {
                pagenum = 6;
            }
            else
            {
                pagenum++;
            }
        }

        private void PrevBttn_MouseClick(object sender, MouseEventArgs e)
        {
            if (pagenum <= 0)
            {
                pagenum = 1;
            }
            else
            {
                pagenum--;
            }
        }
    }
}
