using Class_Manager.Model;

namespace Class_Manager
{
    public partial class MainUIFrm : System.Windows.Forms.Form
    {
        private int classIndex;
        private int assignmentIndex;
        private User user;

        public MainUIFrm()
        {
            InitializeComponent();
            user = new User();
            classIndex = -1;
            assignmentIndex = -1;
        }

        private void addClassMainBtn_Click(object sender, EventArgs e)
        {
            AddClassFrm addClassFrm = new AddClassFrm();
            addClassFrm.setMainUIForm(this);
            addClassFrm.ShowDialog();
        }

        private void addAssignMainBtn_Click(object sender, EventArgs e)
        {
            if (classIndex == -1)
                MessageBox.Show("Select a class to add to");
            else
            {
                AddAssignFrm addAssignFrm = new AddAssignFrm();
                addAssignFrm.setMainUIForm(this);
                addAssignFrm.ShowDialog();
            }
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
            r.Text = user.classes[user.classes.Count - 1].getName();
            r.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            r.ForeColor = Color.Black;
            r.Tag = user.classes.Count;
            r.Click += new EventHandler(ClassButton_Click);

            classLayout.Controls.Add(r);
        }

        public void addAssignment(Assignment a)
        {
            user.classes[classIndex].addAssignment(a);
            addAssignmentButton();
        }

        public void addAssignmentButton()
        {
            RadioButton r = new RadioButton();
            r.Text = user.classes[classIndex].assignments[user.classes[classIndex].assignments.Count - 1].getName();
            r.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            r.ForeColor = Color.Black;
            r.Tag = user.classes[classIndex].assignments.Count - 1;
            r.Click += new EventHandler(AssignmentButton_Click);

            AssignmentFlowLayout.Controls.Add(r);
        }

        public void addFile(Class_Manager.Model.File f)
        {
            user.classes[classIndex].assignments[assignmentIndex].addFile(f);
            addFileButton();
        }

        public void addFileButton()
        {

        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            classIndex = (int)rb.Tag-1;

            AssignmentFlowLayout.Controls.Clear();

            if (user.classes[classIndex].assignments.Count == 0)
                return;
            else
                initializeAssignments();
        }

        private void AssignmentButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            assignmentIndex = (int)rb.Tag;

            //MessageBox.Show(assignmentIndex.ToString());
            MessageBox.Show(user.classes[classIndex].assignments[assignmentIndex].getName());
            //MessageBox.Show(user.getClasses()[classIndex].getAssignments()[user.getClasses()[classIndex].getAssignments().Count - 1].getName());
        }

        private void initializeAssignments()
        {
            for (int i=0; i<user.classes[classIndex].assignments.Count; i++)
            {
                RadioButton r = new RadioButton();
                r.Text = user.getClasses()[classIndex].assignments[i].getName();
                r.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                r.ForeColor = Color.Black;
                r.Tag = i;
                r.Click += new EventHandler(AssignmentButton_Click);

                AssignmentFlowLayout.Controls.Add(r);
            }
        }

        private void assignDueLbl_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedclassIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}