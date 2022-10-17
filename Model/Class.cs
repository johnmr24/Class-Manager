using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Manager.Model
{
    public class Class
    {
        private List<Assignment> assignmentList;
        private string name;
        public RadioButton radioButton;


        public Class()
        {
            assignmentList = new List<Assignment>();
            name = "";
            radioButton = new RadioButton();
        }

        public Class(List<Assignment> assignmentList, string name)
        {
            this.assignmentList = assignmentList;
            this.name = name;  
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

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setButtonClickEvent()
        {
            radioButton.Click += new EventHandler(DynamicButton_Click);
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name);
        }
    }
}
