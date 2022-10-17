using Class_Manager.Model;

namespace Class_Manager
{
    public partial class MainUIFrm : System.Windows.Forms.Form
    {
        public MainUIFrm()
        {
            InitializeComponent();
        }

        private void addClassMainBtn_Click(object sender, EventArgs e)
        {
            AddClassFrm addClassFrm = new AddClassFrm();
            addClassFrm.setMainUIForm(this);
            addClassFrm.ShowDialog();
        }

        private void addAssignMainBtn_Click(object sender, EventArgs e)
        {
            AddAssignFrm addAssignFrm = new AddAssignFrm();
            addAssignFrm.ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DragAndDropFrm dragAndDropFrm = new DragAndDropFrm();
            dragAndDropFrm.ShowDialog();
        }

        public void addClass(Class c) 
        { 
            user.addClass(c);
            addClassButton();
        }

        public void addClassButton()
        {
            classLayout.Controls.Add(user.classes[user.classes.Count - 1].radioButton);
        }
    }
}