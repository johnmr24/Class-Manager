using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Manager.Model
{
    internal class File
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
    }
}
