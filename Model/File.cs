using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//File class that contains all the data for a file
//Contains the name and path of the file

namespace Class_Manager.Model
{
    [Serializable()]
    public class File
    {
        private string name;
        private string path;

        public File()
        {
            name = "";
            path = "";
        }

        public File(string name, string path)
        {
            this.name = name;
            this.path = path;
        }
        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
    }
}
