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
        private MainUIFrm mainUIFrm;
        public AddClassFrm()
        {
            InitializeComponent();
            mainUIFrm = new MainUIFrm();
        }

        private void AddClassBtn_Click(object sender, EventArgs e)
        {
            Class c = new();
            c.SetName(classNameTxtBx.Text.ToString());

            mainUIFrm.AddClass(c);

            Close();
        }

        public void SetMainUIForm(MainUIFrm f)
        {
            mainUIFrm = f;
        }
    }
}
