using Class_Manager.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using Microsoft.Toolkit.Uwp.Notifications;


namespace Class_Manager
{
    public partial class MainUIFrm : System.Windows.Forms.Form
    {
        private int classIndex; // Index of the class in the list
        private int assignmentIndex; // Index of the assignment in the list
        private int fileIndex;  // Index of the file in the list
        public User user;
        private bool fileDoubleClk = false;

        //Folder is the name of the folder stored in user documents that will hold the application files
        readonly string Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ClassManager");
        //File name is the name of the file that will hold the user data which is being serialized (.bin)
        readonly string FileName = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ClassManager"), "Info.xml");

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
                FileStream fs = new(FileName, FileMode.Open);
                XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                DataContractSerializer ser = new(typeof(User));

                // Deserialize the data and read it from the instance.
                if (ser.ReadObject(reader, true) is User deserializedUser)
                {
                    user = deserializedUser;
                }
                reader.Close();
                fs.Close();
                InitializeClasses();    //Refresh the UI
            }
            else
            {
                this.user = new User();
                //System.IO.File.Create(FileName);
            }

            //check if startup is true
            if (user.Startup)
            {
                onToolStripMenuItem.Checked = true;
            }
            else
            {
                offToolStripMenuItem.Checked = true;
            }
            ColorRefresh();
            InitializeNotificationSettings();
        }

        //Buttonpress events
        private void AddClassMainBtn_Click(object sender, EventArgs e)
        {
            AddClassFrm addClassFrm = new(user);
            addClassFrm.ShowDialog();
            InitializeClasses();
        }

        private void AddAssignMainBtn_Click(object sender, EventArgs e)
        {
            if (classIndex == -1)
                MessageBox.Show("Select a class to add to");
            else
            {
                AddAssignFrm addAssignFrm = new(user, classIndex);
                addAssignFrm.ShowDialog();
                InitializeAssignments();
            }
        }

        private void InitializeNotificationSettings()
        {
            if (user.Notifications)
            {
                notificationsOnButton.Checked = true;
                notificationsOffButton.Checked = false;
                updateToolStripMenuItem.Enabled = true;
                dueDateTimer.Start(); //start the timer that checks for due dates
            }
            else
            {
                notificationsOnButton.Checked = false;
                notificationsOffButton.Checked = true;
                updateToolStripMenuItem.Enabled = false;
            }
            if (user.NotificationsUpdate == 5)
            {
                fiveMinuteUpdate.Checked = true;
                oneHourUpdate.Checked = false;
                twelveHourUpdate.Checked = false;
                oneDayUpdate.Checked = false;
            }
            else if (user.NotificationsUpdate == 1)
            {
                fiveMinuteUpdate.Checked = false;
                oneHourUpdate.Checked = true;
                twelveHourUpdate.Checked = false;
                oneDayUpdate.Checked = false;
            }
            else if (user.NotificationsUpdate == 12)
            {
                fiveMinuteUpdate.Checked = false;
                oneHourUpdate.Checked = false;
                twelveHourUpdate.Checked = true;
                oneDayUpdate.Checked = false;
            }
            else if (user.NotificationsUpdate == 24)
            {
                fiveMinuteUpdate.Checked = false;
                oneHourUpdate.Checked = false;
                twelveHourUpdate.Checked = false;
                oneDayUpdate.Checked = true;
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
                AddFileFrm addFileFrm = new(user, classIndex, assignmentIndex);
                addFileFrm.ShowDialog();
                InitializeFiles();
            }
        }

        public void AddFile(Class_Manager.Model.File f)
        {
            user.classes[classIndex].assignments[assignmentIndex].Files.Add(f);
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
                notesTextBox.Clear();
            }
            else
            {
                assignmentIndex = (int)rb.Tag;

                String notes = user.Classes[classIndex].assignments[assignmentIndex].Notes;
                notesTextBox.Text = notes;

                FileFlowLayout.Controls.Clear();

                if (user.classes[classIndex].assignments[assignmentIndex].files.Count == 0)
                    return;
                else
                {
                    InitializeFiles();
                }
            }
        }

        private async void FileLabel_Click(object? sender, EventArgs e)
        {
            await Task.Delay(SystemInformation.DoubleClickTime);

            if (fileDoubleClk)
            {
                fileDoubleClk = false;
                return;
            }
            if (sender is not Label b) //if no radio button was selected
            {
                return;
            }
            fileIndex = (int)b.Tag;

            //check if file location is valid
            if (System.IO.File.Exists(user.classes[classIndex].assignments[assignmentIndex].files[fileIndex].Path))
            {
                var process = new System.Diagnostics.Process
                {
                    StartInfo = new System.Diagnostics.ProcessStartInfo()
                    {
                        UseShellExecute = true,
                        FileName = user.classes[classIndex].assignments[assignmentIndex].files[(int)b.Tag].Path
                    }
                };
                process.Start();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("File location is invalid, Delete file entry?", "File Location Error", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    user.Classes[classIndex].Assignments[assignmentIndex].Files.RemoveAt(fileIndex);
                    InitializeFiles();
                }
            }
        }

        private void FileButton_DoubleClick(object? sender, EventArgs e)
        {
            fileDoubleClk = true;
            //set the file index to the index of the file that was selected
            if (sender is not Label l) //if no radio button was selected
            {
                return;
            }
            EditFileFrm editFileFrm = new(user, classIndex, assignmentIndex, (int)l.Tag);
            editFileFrm.ShowDialog();
            InitializeFiles();
        }

        private void InitializeClasses()    //Load classes and clear all forms below (assignment, files)
        {
            classLayout.Controls.Clear();
            if (user.Classes.Count > 0)   //Skip when there are no classes
            {
                for (int i = 0; i < user.Classes.Count; i++)   //iterate through the classes
                {
                    RadioButton r = new()   //create a new radio button
                    {
                        Appearance = Appearance.Button,
                        Text = user.classes[i].Name,
                        Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                        ForeColor = Color.Black,
                        Tag = i + 1,
                        Width = 166,
                        //center text
                        TextAlign = ContentAlignment.MiddleCenter,

                        //center button in flow layout
                        Dock = DockStyle.Fill,


                        Anchor = AnchorStyles.None,
                        AutoEllipsis = true,
                        UseCompatibleTextRendering = true
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
            for (int i = 0; i < user.classes[classIndex].assignments.Count; i++)
            {
                //String name = ;
                RadioButton r = new()
                {
                    Appearance = Appearance.Button,
                    Text = String.Format("{1}          {0, -20}", user.Classes[classIndex].assignments[i].Name, user.Classes[classIndex].assignments[i].DueDateTime.ToString("MM/dd/yyyy")),
                    Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    ForeColor = Color.Black,
                    Tag = i
                };
                
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
                Label l = new()    //Create a new button
                {
                    Text = user.Classes[classIndex].assignments[assignmentIndex].files[i].Name,
                    Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                    ForeColor = Color.Black,
                    Tag = i
                };
                l.Click += new EventHandler(FileLabel_Click);
                l.DoubleClick += new EventHandler(FileButton_DoubleClick);
                l.Width = 200;

                FileFlowLayout.Controls.Add(l);
            }
        }

        private void MainUIFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.Directory.CreateDirectory(Folder);    //If folder is not already created, create it

            //Delete previous save file
            if (System.IO.File.Exists(FileName))
            {
                System.IO.File.Delete(FileName);
            }

            FileStream writer = new(FileName, FileMode.Create);
            DataContractSerializer ser = new(typeof(User));

            ser.WriteObject(writer, user);
            writer.Close();
        }

        private void CollapseBtn_Click(object sender, EventArgs e)
        {
            classLayout.Enabled = !classLayout.Enabled;
            collapsePanel.Hide();
            expandButton.Show();
            expandButton.Location = new System.Drawing.Point(0, 194);
        }

        private void ExpandBtn_Click(object sender, EventArgs e)
        {
            collapsePanel.Show();
            expandButton.Hide();
            classLayout.Enabled = !classLayout.Enabled;
        }

        //toggle startup
        private void ToggleStartup(bool toggle)
        {
            RegistryKey? rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rk == null)
            {
                //prompt user with error
                MessageBox.Show("Error: Registry key not found");
                return;
            }
            if (toggle)
            {
                rk.SetValue("ClassManager", Application.ExecutablePath.ToString());
                user.Startup = true;
            }
            else
            {
                rk.DeleteValue("ClassManager", false);
                user.Startup = false;
            }
        }


        private void OnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set startup to true
            ToggleStartup(true);
            //checkmark on item and uncheckmark off item
            onToolStripMenuItem.Checked = true;
            offToolStripMenuItem.Checked = false;
        }

        private void OffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //set startup to false
            ToggleStartup(false);
            //checkmark on item and uncheckmark off item
            onToolStripMenuItem.Checked = false;
            offToolStripMenuItem.Checked = true;
        }
        private void DueDateTimer_Tick(object sender, EventArgs e)
        {
            CheckDueDates();
        }

        private void CheckDueDates()
        {
            if (user.classes.Count > 0)
            {
                for (int i = 0; i < user.classes.Count; i++)
                {
                    if (user.classes[i].assignments.Count > 0)
                    {
                        for (int j = 0; j < user.classes[i].assignments.Count; j++)
                        {
                            if (user.classes[i].assignments[j].ShownNotification == false)
                            {
                                if (InTimeInterval(user.classes[i].assignments[j].DueDateTime))
                                {
                                    user.classes[i].assignments[j].ShownNotification = true;
                                    SendNotification(i, j);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void SendNotification(int c, int a)
        {
            new ToastContentBuilder()
               .AddText("You have an upcoming assignment due\n\n")
               .AddText("Class: " + user.classes[c].Name.ToString() + "\n" +
                        "Assignment: " + user.classes[c].assignments[a].Name.ToString() + "\n" +
                        "Due: " + user.classes[c].assignments[a].DueDateTime.ToString())
               .Show(); // Not seeing the Show() method? Make sure you have version 7.0, and if you're using .NET 6 (or later), then your TFM must be net6.0-windows10.0.17763.0 or greater
        }

        private bool InTimeInterval(DateTime t)
        {
            DateTime currTime = DateTime.Now;
            TimeSpan timeSpan = t - currTime;

            //check timeSpan to see if the user should be notified
            if (timeSpan.Days <= 1)
            {
                if (timeSpan.Hours <= 12)
                {
                    if (timeSpan.Hours <= 1)
                    {
                        if (timeSpan.Hours == 0 && timeSpan.Minutes <= 5)
                        {
                            if (user.NotificationsUpdate == 5f)
                                return true;
                            else
                                return false;
                        }
                        if (user.NotificationsUpdate == 1f)
                            return true;
                        else
                            return false;
                    }
                    if (user.NotificationsUpdate == 12f)
                        return true;
                    else
                        return false;
                }
                if (user.NotificationsUpdate == 24f)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        private void OneDayUpdate_Click(object sender, EventArgs e)
        {
            user.NotificationsUpdate = 24;
            fiveMinuteUpdate.Checked = false;
            oneHourUpdate.Checked = false;
            twelveHourUpdate.Checked = false;
            oneDayUpdate.Checked = true;
        }

        private void TwelveHourUpdate_Click(object sender, EventArgs e)
        {
            user.NotificationsUpdate = 12;
            fiveMinuteUpdate.Checked = false;
            oneHourUpdate.Checked = false;
            twelveHourUpdate.Checked = true;
            oneDayUpdate.Checked = false;
        }

        private void OneHourUpdate_Click(object sender, EventArgs e)
        {
            user.NotificationsUpdate = 1;
            fiveMinuteUpdate.Checked = false;
            oneHourUpdate.Checked = true;
            twelveHourUpdate.Checked = false;
            oneDayUpdate.Checked = false;
        }

        private void FiveMinuteUpdate_Click(object sender, EventArgs e)
        {
            user.NotificationsUpdate = 5;
            fiveMinuteUpdate.Checked = true;
            oneHourUpdate.Checked = false;
            twelveHourUpdate.Checked = false;
            oneDayUpdate.Checked = false;
        }

        private void NotificationsOnButton_Click(object sender, EventArgs e)
        {
            notificationsOnButton.Checked = true;
            notificationsOffButton.Checked = false;
            updateToolStripMenuItem.Enabled = true;
            user.Notifications = true;
            dueDateTimer.Start();
        }

        private void NotificationsOffButton_Click(object sender, EventArgs e)
        {
            notificationsOnButton.Checked = false;
            notificationsOffButton.Checked = true;
            updateToolStripMenuItem.Enabled = false;
            user.Notifications = true;
            dueDateTimer.Stop();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colDialog.ShowDialog();
            user.Col = colDialog.Color;
            collapsePanel.BackColor = user.Col;
            addGroupBox.BackColor = user.Col;

            Color col1 = Color.FromArgb(255, Math.Max((user.Col.R - 50), 0), Math.Max((user.Col.G - 50), 0), Math.Max((user.Col.B - 50), 0));
            Color col2 = Color.FromArgb(255, Math.Min((user.Col.R + 50), 255), Math.Min((user.Col.G + 50), 255), Math.Min((user.Col.B + 50), 255));

            addGroupBox.BackColor = col1;
            assignmentGroupBox.BackColor = col2;
            notesGroupBox.BackColor = col2;
            fileGroupBox.BackColor = col2;

            if (user.Col.R + user.Col.G + user.Col.B > 200)
            {
                addGroupBox.ForeColor = Color.Black;
                classesGroupBox.ForeColor = Color.Black;
                assignmentGroupBox.ForeColor = Color.Black;
                notesGroupBox.ForeColor = Color.Black;
                fileGroupBox.ForeColor = Color.Black;
            }
            else
            {
                addGroupBox.ForeColor = Color.White;
                classesGroupBox.ForeColor = Color.White;
                assignmentGroupBox.ForeColor = Color.White;
                notesGroupBox.ForeColor = Color.White;
                fileGroupBox.ForeColor = Color.White;
            }
        }

        private void ColorRefresh()
        {
            collapsePanel.BackColor = user.Col;
            addGroupBox.BackColor = Color.FromArgb(255, Math.Max((user.Col.R - 50), 0), Math.Max((user.Col.G - 50), 0), Math.Max((user.Col.B - 50), 0));
            assignmentGroupBox.BackColor = Color.FromArgb(255, Math.Min((user.Col.R + 50), 255), Math.Min((user.Col.G + 50), 255), Math.Min((user.Col.B + 50), 255));
            notesGroupBox.BackColor = Color.FromArgb(255, Math.Min((user.Col.R + 50), 255), Math.Min((user.Col.G + 50), 255), Math.Min((user.Col.B + 50), 255));
            fileGroupBox.BackColor = Color.FromArgb(255, Math.Min((user.Col.R + 50), 255), Math.Min((user.Col.G + 50), 255), Math.Min((user.Col.B + 50), 255));

            if (user.Col.R + user.Col.G + user.Col.B > 200)
            {
                addGroupBox.ForeColor = Color.Black;
                classesGroupBox.ForeColor = Color.Black;
                assignmentGroupBox.ForeColor = Color.Black;
                notesGroupBox.ForeColor = Color.Black;
                fileGroupBox.ForeColor = Color.Black;
            }
            else
            {
                addGroupBox.ForeColor = Color.White;
                classesGroupBox.ForeColor = Color.White;
                assignmentGroupBox.ForeColor = Color.White;
                notesGroupBox.ForeColor = Color.White;
                fileGroupBox.ForeColor = Color.White;
            }
        }
    }
}