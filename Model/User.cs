using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Manager.Model
{
    internal class User
    {
        private List<Class> classes;
        bool notifications;
        bool startup;

        public User()
        {
            this.classes = new List<Class>();
        }

        public User(List<Class> classes)
        {
            this.classes = classes;
        }

        public void addClass(Class c)
        {
            this.classes.Add(c);
        }

        public void removeClass(Class c)
        {
            if (this.classes.Contains(c))
            {
                this.classes.Remove(c);
            }
        }

        public void turnOnNotifications()
        {
            notifications = true;
        }

        public void turnOffNotifications()
        {
            notifications = false;
        }

        public void turnOnStartup()
        {
            startup = true;
        }

        public void turnOffStartup()
        {
            startup = false;
        }
    }
}
