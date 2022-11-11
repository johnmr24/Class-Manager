using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Manager.Model
{
    [Serializable()]
    public class Assignment
    {
        public List<File> files;
        private string name;
        private string notes;
        private DateTime dueDate;
        private bool shownNotification;

        //Default Contructor
        public Assignment()
        {
            this.files = new List<File>();
            this.name = "";
            this.notes = "";
            this.dueDate = DateTime.Now;
            this.shownNotification = false;
        }
        public Assignment(List<File> files, string name, string notes, DateTime dueDate)
        {
            this.files = files;
            this.name = name;
            this.notes = notes;
            this.dueDate = dueDate;
            this.shownNotification = false;
        }


        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<File> Files
        {
            get { return files; }
            set { files = value; }
        }
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }
        public DateTime DueDateTime
        {
            get { return dueDate; }
            set { dueDate = dueDate.AddHours(value.Hour);
                  dueDate = dueDate.AddMinutes(value.Minute); }
        }
        public bool ShownNotification
        {
            get { return shownNotification; }
            set { shownNotification = value; }
        }
    }
}