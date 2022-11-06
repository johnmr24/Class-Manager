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
    public partial class EditClassFrm : Form
    {
        private MainUIFrm mainUIFrm;
        public EditClassFrm(int index)
        {
            InitializeComponent();
            mainUIFrm = new MainUIFrm();
            classNameTxtBx.Text = mainUIFrm.user.getClasses()[index].getName();
        }

        private void addClassBtn_Click(object sender, EventArgs e)
        {
            Class c = new Class();
            c.setName(classNameTxtBx.Text.ToString());

            mainUIFrm.addClass(c);

            classNameTxtBx.Clear();
        }

        public void setMainUIForm(MainUIFrm f)
        {
            mainUIFrm = f;
        }

        private void addClassBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
