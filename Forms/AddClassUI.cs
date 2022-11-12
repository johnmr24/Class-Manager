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
    public partial class AddClassFrm : Form
    {
        private readonly User user;
        public AddClassFrm(User u)
        {
            InitializeComponent();
            this.user = u;
        }

        private void AddClassBtn_Click(object sender, EventArgs e)
        {
            Class c;
            //If textbox.text is empty or spaces, prompt user to enter a name
            if (string.IsNullOrWhiteSpace(classNameTxtBx.Text))
            {
                MessageBox.Show("Please enter a name for the class.");
                return;
            }
            else
            {
                c = new(classNameTxtBx.Text.ToString());
            }
            
            user.classes.Add(c);

            Close();
        }
    }
}
