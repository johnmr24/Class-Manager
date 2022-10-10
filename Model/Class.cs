using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Manager.Model
{
    internal class Class
    {
        private List<Assignment> assignmentList;

        public Class()
        {
            assignmentList = new List<Assignment>();
        }

        public Class(List<Assignment> assignmentList)
        {
            this.assignmentList = assignmentList;
        }

        public void addAssignment(Assignment assignment)
        {
            assignmentList.Add(assignment);
        }

        public void removeAssignment(Assignment assignment)
        {
            if (assignmentList.Contains(assignment))
            {
                assignmentList.Remove(assignment);
            }
            else
            {
                MessageBox.Show("Assignment Not Available To Remove");
            }
        }

        public List<Assignment> getAssignments()
        {
            return this.assignmentList;
        }
    }
}
