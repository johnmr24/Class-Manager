using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Manager.Model
{
    [Serializable()]
    public class Class
    {
        public List<Assignment> assignments;
        private string name;


        public Class()
        {
            assignments = new List<Assignment>();
            name = "";
        }

        public Class(List<Assignment> assignmentList, string name)
        {
            this.assignments = assignmentList;
            this.name = name;  
        }

        public void AddAssignment(Assignment assignment)
        {
            assignments.Add(assignment);
        }

        public void RemoveAssignment(Assignment assignment)
        {
            if (assignments.Contains(assignment))
            {
                assignments.Remove(assignment);
            }
            else
            {
                MessageBox.Show("Assignment Not Available To Remove");
            }
        }

        public List<Assignment> GetAssignments()
        {
            return this.assignments;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
