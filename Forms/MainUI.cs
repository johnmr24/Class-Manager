using Class_Manager.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;
using System.Diagnostics;

namespace Class_Manager
{
    public partial class MainUIFrm : System.Windows.Forms.Form
    {
        private int classIndex; // Index of the class in the list
        private int assignmentIndex; // Index of the assignment in the list
        private int fileIndex;  // Index of the file in the list
        public User user;

        //Folder is the name of the folder stored in user documents that will hold the application files
        readonly string Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ClassManager");
        //File name is the name of the file that will hold the user data which is being serialized (.bin)
        readonly string FileName = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ClassManager"), "Info.bin");

        public MainUIFrm()
        {
            InitializeComponent();
            user = new User();  //Create new user object
            classIndex = -1;    //classIndex is -1 because the user has not selected a class yet
            assignmentIndex = -1;   //assignmentIndex is -1 because the user has not selected an assignment yet
            fileIndex = 1;  //fileIndex is -1 because the user has not selected a file yet
        }
        
        private void MainUIFrm_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(FileName)) //Load a file with existing information
            {
                Stream openFileStream = System.IO.File.OpenRead(FileName);  //Open the file
                BinaryFormatter deserializer = new();   //Create a new deserializer
                this.user = (User)deserializer.Deserialize(openFileStream); //get the user object from the file
                openFileStream.Close(); //Close the file

                initializeClasses();    //Refresh the UI
            }
            else
            {
                this.user = new User();
                //System.IO.File.Create(FileName);
            }
        }

        //Buttonpress events
        private void addClassMainBtn_Click(object sender, EventArgs e)
        {
            AddClassFrm addClassFrm = new();
            addClassFrm.setMainUIForm(this);
            addClassFrm.ShowDialog();
        }

        private void addAssignMainBtn_Click(object sender, EventArgs e)
        {
            if (classIndex == -1)
                MessageBox.Show("Select a class to add to");
            else
            {
                AddAssignFrm addAssignFrm = new();
                addAssignFrm.setMainUIForm(this);
                addAssignFrm.ShowDialog();
            }
        }

        private void addFileMainBtn_Click(object sender, EventArgs e)
        {
            if (assignmentIndex == -1)
            {
                MessageBox.Show("Select an assignment to add to");
            }
            else
            {
                AddFileFrm addFileFrm = new();
                addFileFrm.setMainUIForm(this);
                addFileFrm.ShowDialog();
            }
        }

        //Public methods referenced by child forms
        public void addClass(Class c) 
        { 
            user.addClass(c);
            initializeClasses();
        }
        
        public void addAssignment(Assignment a)
        {
            user.classes[classIndex].addAssignment(a);
            initializeAssignments();
        }

        public void addFile(Class_Manager.Model.File f)
        {
            user.classes[classIndex].assignments[assignmentIndex].addFile(f);
            initializeFiles();
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            //if the user clicks the same class twice, open the edit class form
            if (classIndex == (int)rb.Tag - 1)
            {
                EditClassFrm editClassFrm = new(user, classIndex);
                editClassFrm.ShowDialog();
                initializeClasses();
            }
            else
            {
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
        }

        private void AssignmentButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            //if the user clicks on the same assignment twice, open the edit assignment form
            if (assignmentIndex == (int)rb.Tag)
            {
                EditAssignFrm editAssignFrm = new EditAssignFrm(user, classIndex, assignmentIndex);
                editAssignFrm.ShowDialog();
                //initialize assignments when the edit assignment form is closed
                initializeAssignments();
                FileFlowLayout.Controls.Clear();
            }
            else
            {
                assignmentIndex = (int)rb.Tag;

                FileFlowLayout.Controls.Clear();

                if (user.classes[classIndex].assignments[assignmentIndex].files.Count == 0)
                    return;
                else
                {
                    initializeFiles();
                }
            }
        }
        
        private void FileButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            fileIndex = (int)b.Tag;

            //check if file location is valid
            if (System.IO.File.Exists(user.classes[classIndex].assignments[assignmentIndex].files[fileIndex].getPath()))
            {
                var process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo()
                {
                    UseShellExecute = true,
                    FileName = user.classes[classIndex].assignments[assignmentIndex].files[fileIndex].getPath()
                };
                process.Start();
            }
            else
            {
                MessageBox.Show("File location is invalid");
            }

            
        }
        private void initializeClasses()    //Load classes and clear all forms below (assignment, files)
        {
            classLayout.Controls.Clear();
            if (user.getClasses().Count > 0)   //Skip when there are no classes
            {
                for (int i = 0; i < user.getClasses().Count; i++)   //iterate through the classes
                {
                    RadioButton r = new RadioButton();  //create a new radio button
                    r.Text = user.classes[i].getName();
                    r.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    r.ForeColor = Color.Black;
                    r.Tag = i + 1;
                    r.Click += new EventHandler(ClassButton_Click); //when a radio button is selected

                    classLayout.Controls.Add(r);
                }
            }
            
            //set class index to -1
            classIndex = -1;
            //clear the assignment and file flow layouts
            AssignmentFlowLayout.Controls.Clear();
            FileFlowLayout.Controls.Clear();
            //set the assignment and file index to -1
            assignmentIndex = -1;
            fileIndex = -1;
        }
        
        private void initializeAssignments()    //Load assignments and clear forms below (files)
        {
            AssignmentFlowLayout.Controls.Clear();
            if (classIndex == -1)
            {
                return;
            }
            for (int i=0; i<user.classes[classIndex].assignments.Count; i++)
            {
                RadioButton r = new RadioButton();
                String name = String.Format("{1}          {0, -20}", user.getClasses()[classIndex].assignments[i].getName(), user.getClasses()[classIndex].assignments[i].getDueDate().ToString("MM/dd/yyyy"));
                r.Text = name;
                r.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                r.ForeColor = Color.Black;
                r.Tag = i;
                r.Click += new EventHandler(AssignmentButton_Click);
                r.Width = 300;

                AssignmentFlowLayout.Controls.Add(r);
            }
            //set assignment index to -1
            assignmentIndex = -1;
            //clear the file flow layout
            FileFlowLayout.Controls.Clear();
            //set the file index to -1
            fileIndex = -1;
        }

        private void initializeFiles()
        {
            FileFlowLayout.Controls.Clear();
            for (int i = 0; i < user.classes[classIndex].assignments[assignmentIndex].files.Count; i++)
            {
                Button b = new Button();
                b.Text = user.getClasses()[classIndex].assignments[assignmentIndex].files[i].getPath();
                b.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                b.ForeColor = Color.Black;
                b.Tag = i;
                b.Click += new EventHandler(FileButton_Click);
                b.Width = 200;

                FileFlowLayout.Controls.Add(b);
            }
        }
        
        private void MainUIFrm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            System.IO.Directory.CreateDirectory(Folder);
            Stream TestFilesStream = System.IO.File.Create(FileName); //save object information to a file for reuse
            BinaryFormatter serializer = new BinaryFormatter();
            User[] userSave = { user };
            serializer.Serialize(TestFilesStream, user); //The serialized file is binary
            TestFilesStream.Close();
        }
        
        private void collapseBtn_Click(object sender, EventArgs e)
        {
            collapsePanel.Hide();
            expandBtn.Show();
            expandBtn.Location = new System.Drawing.Point(0, 205);
        }
        
        private void expandBtn_Click(object sender, EventArgs e)
        {
            collapsePanel.Show();
            expandBtn.Hide();
        }
    }
}