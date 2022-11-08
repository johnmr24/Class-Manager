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

                InitializeClasses();    //Refresh the UI
            }
            else
            {
                this.user = new User();
                //System.IO.File.Create(FileName);
            }
        }

        //Buttonpress events
        private void AddClassMainBtn_Click(object sender, EventArgs e)
        {
            AddClassFrm addClassFrm = new();
            addClassFrm.SetMainUIForm(this);
            addClassFrm.ShowDialog();
        }

        private void AddAssignMainBtn_Click(object sender, EventArgs e)
        {
            if (classIndex == -1)
                MessageBox.Show("Select a class to add to");
            else
            {
                AddAssignFrm addAssignFrm = new();
                addAssignFrm.SetMainUIForm(this);
                addAssignFrm.ShowDialog();
            }
        }

        private void AddFileMainBtn_Click(object sender, EventArgs e)
        {
            if (assignmentIndex == -1)
            {
                MessageBox.Show("Select an assignment to add to");
            }
            else
            {
                AddFileFrm addFileFrm = new();
                addFileFrm.SetMainUIForm(this);
                addFileFrm.ShowDialog();
            }
        }

        //Public methods referenced by child forms
        public void AddClass(Class c) 
        { 
            user.AddClass(c);
            InitializeClasses();
        }
        
        public void AddAssignment(Assignment a)
        {
            user.classes[classIndex].AddAssignment(a);
            InitializeAssignments();
        }

        public void AddFile(Class_Manager.Model.File f)
        {
            user.classes[classIndex].assignments[assignmentIndex].AddFile(f);
            InitializeFiles();
        }

        private void ClassButton_Click(object? sender, EventArgs e)
        {
            if (sender is not RadioButton rb) //if no radio button was selected
            {
                return;
            }
            //if the user clicks the same class twice, open the edit class form
            if (classIndex == (int)rb.Tag - 1)
            {
                EditClassFrm editClassFrm = new(user, classIndex);  //Create a new edit class form
                editClassFrm.ShowDialog();  //Show the edit class form
                InitializeClasses();    //Refresh the UI
            }
            else
            {
                classIndex = (int)rb.Tag - 1; //set the class index to the index of the class that was selected

                AssignmentFlowLayout.Controls.Clear();  //Clear the assignment flow layout
                FileFlowLayout.Controls.Clear();    //Clear the file flow layout

                if (user.classes[classIndex].assignments.Count == 0)
                    return;
                else
                {
                    InitializeAssignments();    //Initialize the assignments
                }
            }
        }

        private void AssignmentButton_Click(object? sender, EventArgs e)
        {
            if (sender is not RadioButton rb) //if no radio button was selected
            {
                return;
            }
            //if the user clicks on the same assignment twice, open the edit assignment form
            if (assignmentIndex == (int)rb.Tag)
            {
                EditAssignFrm editAssignFrm = new(user, classIndex, assignmentIndex);
                editAssignFrm.ShowDialog();
                //initialize assignments when the edit assignment form is closed
                InitializeAssignments();
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
                    InitializeFiles();
                }
            }
        }
        
        private void FileButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button b) //if no radio button was selected
            {
                return;
            }
            fileIndex = (int)b.Tag;

            //check if file location is valid
            if (System.IO.File.Exists(user.classes[classIndex].assignments[assignmentIndex].files[fileIndex].GetPath()))
            {
                var process = new System.Diagnostics.Process
                {
                    StartInfo = new System.Diagnostics.ProcessStartInfo()
                    {
                        UseShellExecute = true,
                        FileName = user.classes[classIndex].assignments[assignmentIndex].files[fileIndex].GetPath()
                    }
                };
                process.Start();
            }
            else
            {
                MessageBox.Show("File location is invalid");
            }

            
        }
        private void InitializeClasses()    //Load classes and clear all forms below (assignment, files)
        {
            classLayout.Controls.Clear();
            if (user.GetClasses().Count > 0)   //Skip when there are no classes
            {
                for (int i = 0; i < user.GetClasses().Count; i++)   //iterate through the classes
                {
                    RadioButton r = new()   //create a new radio button
                    {
                        Text = user.classes[i].GetName(),
                        Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                        ForeColor = Color.Black,
                        Tag = i + 1
                    };  
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
        
        private void InitializeAssignments()    //Load assignments and clear forms below (files)
        {
            AssignmentFlowLayout.Controls.Clear();
            if (classIndex == -1)
            {
                return;
            }
            for (int i=0; i<user.classes[classIndex].assignments.Count; i++)
            {
                RadioButton r = new();
                String name = String.Format("{1}          {0, -20}", user.GetClasses()[classIndex].assignments[i].GetName(), user.GetClasses()[classIndex].assignments[i].GetDueDate().ToString("MM/dd/yyyy"));
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

        private void InitializeFiles()
        {
            FileFlowLayout.Controls.Clear();
            for (int i = 0; i < user.classes[classIndex].assignments[assignmentIndex].files.Count; i++)
            {
                Button b = new()    //Create a new button
                {
                    Text = user.GetClasses()[classIndex].assignments[assignmentIndex].files[i].GetPath(),
                    Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    ForeColor = Color.Black,
                    Tag = i
                };
                b.Click += new EventHandler(FileButton_Click);
                b.Width = 200;

                FileFlowLayout.Controls.Add(b);
            }
        }
        
        private void MainUIFrm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            System.IO.Directory.CreateDirectory(Folder);
            Stream TestFilesStream = System.IO.File.Create(FileName); //save object information to a file for reuse
            BinaryFormatter serializer = new();
            _ = user;
            serializer.Serialize(TestFilesStream, user); //The serialized file is binary
            TestFilesStream.Close();
        }
        
        private void CollapseBtn_Click(object sender, EventArgs e)
        {
            classLayout.Enabled = !classLayout.Enabled;
            collapsePanel.Hide();
            expandBtn.Show();
            expandBtn.Location = new System.Drawing.Point(0, 205);
        }
        
        private void ExpandBtn_Click(object sender, EventArgs e)
        {
            collapsePanel.Show();
            expandBtn.Hide();
            classLayout.Enabled = !classLayout.Enabled;
        }
    }
}