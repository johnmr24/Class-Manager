using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string getName()
        {
            return this.name;
        }

        public string getPath()
        {
            return this.path;
        }
    }
}
