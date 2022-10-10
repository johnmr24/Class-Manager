using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Manager.Model
{
    internal class Assignment
    {
        private File file;
        private string name;
        private DateTime dueDate;

        public Assignment()
        {
            this.file = new File();
            this.name = "";
            this.dueDate = DateTime.Now;
        }

        public Assignment(File file, string name, DateTime dueDate)
        {
            this.file = file;
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
    }
}
