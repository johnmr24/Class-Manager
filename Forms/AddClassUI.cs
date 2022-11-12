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

        private void AddClassFrm_Load(object sender, EventArgs e)
        {
            nameGroupBox.BackColor = user.Col;
            BackColor = Color.FromArgb(255, Math.Min((user.Col.R + 50), 255), Math.Min((user.Col.G + 50), 255), Math.Min((user.Col.B + 50), 255));
        }
    }
}
