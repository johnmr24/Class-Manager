using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Class that contains all the data for the program
//Contains a list of assignments, along with information about the class


namespace Class_Manager.Model
{
    [Serializable()]
    public class Class
    {
        public List<Assignment> assignments;
        private string name;

        //Default Constructor
        public Class()
        {
            this.assignments = new List<Assignment>();
            this.name = "";
        }
        //Constructor
        public Class(string name)
        {
            assignments = new List<Assignment>();
            this.name = name;
        }
        
        //Properties
        public List<Assignment> Assignments
        {
            get { return assignments; }
            set { assignments = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}