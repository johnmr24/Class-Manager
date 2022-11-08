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

        public List<File> GetFiles()
        {
            return this.files;
        }

        public string GetName()
        {
            return this.name;
        }

        public DateTime GetDueDate()
        {
            return dueDate;
        }
        public void AddFile(File f)
        {
            this.files.Add(f);
        }
        public void RemoveFile(int f)
        {
            if (files.Count > f)
            {
                files.RemoveAt(f);
            }
            else
            {
                MessageBox.Show("File Not Available To Remove");
            }
        }
    }
}
