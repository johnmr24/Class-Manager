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
        private DateTime dueDate;
        private bool shownNotification;

        //Default Contructor
        public Assignment()
        {
            this.files = new List<File>();
            this.name = "";
            this.dueDate = DateTime.Now;
            this.shownNotification = false;
        }
        public Assignment(string name, DateTime dueDate)
        {
            files = new List<File>();
            this.name = name;
            this.dueDate = dueDate;
            this.shownNotification = false;
        }


        //properties
        //Replace, functions are obsolete
        public void EditName(string name)
        {
            if (name == null)
            {
                return;
            }
            else
            {
                this.name = name;
            }
        }

        public void EditDueDate(DateTime date)
        {
            dueDate = date;
        }

        public void EditDueDateTime(DateTime date)
        {
            dueDate = dueDate.AddHours(date.Hour);
            dueDate = dueDate.AddMinutes(date.Minute);
        }

        public List<File> GetFiles()
        {
            return this.files;
        }

        public string GetName()
        {
             return this.name;
        }
        public Assignment(List<File> files, string name, DateTime dueDate)
        {
            this.files = files;
            this.name = name;
            this.dueDate = dueDate;
        }
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
        public DateTime DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public void SendNotification()
        {
            shownNotification = true;
        }

        public bool GetNotificationStatus()
        {
            return shownNotification;
        }
    }
}