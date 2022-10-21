using Class_Manager.Model;
using System.Diagnostics;

namespace Class_Manager
{
    public partial class MainUIFrm : System.Windows.Forms.Form
    {
        private int classIndex;
        private int assignmentIndex;
        private int fileIndex;
        private User user;

        public MainUIFrm()
        {
            InitializeComponent();
            user = new User();
            classIndex = -1;
            assignmentIndex = -1;
            fileIndex = 1;
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
            if (assignmentIndex == -1)
            {
                MessageBox.Show("Select an assignment to add to");
            }
            else
            {
                DragAndDropFrm dragAndDropFrm = new DragAndDropFrm();
                dragAndDropFrm.setMainUIForm(this);
                dragAndDropFrm.ShowDialog();
            }
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
            Button b = new Button();
            b.Text = user.classes[classIndex].assignments[assignmentIndex].files[user.classes[classIndex].assignments[assignmentIndex].files.Count-1].getPath();
            b.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            b.ForeColor = Color.Black;
            b.Tag = user.classes[classIndex].assignments[assignmentIndex].files.Count - 1;
            b.Click += new EventHandler(FileButton_Click);
            b.Width = 300;

            FileFlowLayout.Controls.Add(b);
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            classIndex = (int)rb.Tag-1;

            AssignmentFlowLayout.Controls.Clear();
            FileFlowLayout.Controls.Clear();

            if (user.classes[classIndex].assignments.Count == 0)
                return;
            else
            {
                initializeAssignments();
            }
        }

        private void AssignmentButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            assignmentIndex = (int)rb.Tag;

            FileFlowLayout.Controls.Clear();

            if (user.classes[classIndex].assignments[assignmentIndex].files.Count == 0)
                return;
            else
            {
                initializeFiles();
            }

            //MessageBox.Show(assignmentIndex.ToString());
            //MessageBox.Show(user.classes[classIndex].assignments[assignmentIndex].getName());
            //MessageBox.Show(user.getClasses()[classIndex].getAssignments()[user.getClasses()[classIndex].getAssignments().Count - 1].getName());
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            fileIndex = (int)b.Tag;

            var process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, 
                                            FileName = user.classes[classIndex].assignments[assignmentIndex].files[fileIndex].getPath() };
            process.Start();
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

        private void initializeFiles()
        {
            for (int i = 0; i < user.classes[classIndex].assignments[assignmentIndex].files.Count; i++)
            {
                Button b = new Button();
                b.Text = user.getClasses()[classIndex].assignments[assignmentIndex].files[i].getPath();
                b.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                b.ForeColor = Color.Black;
                b.Tag = i;
                b.Click += new EventHandler(FileButton_Click);
                b.Width = 200;

                FileFlowLayout.Controls.Add(b);
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