using Class_Manager.Model;

namespace Class_Manager
{
    public partial class MainUIFrm : System.Windows.Forms.Form
    {
        private User user;

        public MainUIFrm()
        {
            InitializeComponent();
            user = new User();
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
            RadioButton r = new RadioButton();
            r.Text = user.getClasses()[user.getClasses().Count - 1].getName();
            r.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            r.ForeColor = Color.Black;
            r.Tag = user.getClasses().Count;
            r.Click += new EventHandler(DynamicButton_Click);

            classLayout.Controls.Add(r);
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            MessageBox.Show(user.classes[(int)rb.Tag-1].getName());
        }

        private void assignDueLbl_Click(object sender, EventArgs e)
        {

        }
    }
}