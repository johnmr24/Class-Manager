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

        public Assignment()
        {
            this.files = new List<File>();
            this.name = "";
            this.dueDate = DateTime.Now;
        }

        public Assignment(List<File> files, string name, DateTime dueDate)
        {
            this.files = files;
            this.name = name;
            this.dueDate = dueDate;
        }

        public void editName(string name)
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

        public void editDueDate(DateTime date)
        {
            dueDate = date;
        }

        public List<File> getFile()
        {
            return this.files;
        }

        public string getName()
        {
            return this.name;
        }

        public DateTime getDueDate()
        {
            return dueDate;
        }
        public void addFile(File f)
        {
            this.files.Add(f);
        }
    }
}
