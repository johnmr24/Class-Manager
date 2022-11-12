using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Manager.Model
{
    [Serializable()]
    public class User
    {
        public List<Class> classes;
        bool notifications;
        bool startup;
        private Color col;

        public User()
        {
            this.classes = new List<Class>();

        }

        public User(List<Class> classes)
        {
            this.classes = classes;
        }

        public void AddClass(Class c)
        {
            this.classes.Add(c);
        }

        public void RemoveClass(Class c)
        {
            if (this.classes.Contains(c))
            {
                this.classes.Remove(c);
            }
        }

        public void TurnOnNotifications()
        {
            notifications = true;
        }

        public void TurnOffNotifications()
        {
            notifications = false;
        }

        public void TurnOnStartup()
        {
            startup = true;
        }

        public void TurnOffStartup()
        {
            startup = false;
        }

        public Color Col
        {
            get { return col; }
            set {col = value;}
        }

        public List<Class> GetClasses()
        {
            return this.classes;
        }

        public bool GetNotifications()
        {
            return this.notifications;
        }

        public bool GetStartup()
        {
            return this.startup;
        }


    }
}
