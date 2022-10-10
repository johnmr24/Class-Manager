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
    }
}