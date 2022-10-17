using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Manager.Model
{
    internal class User
    {
        public List<Class> classes;
        bool notifications;
        bool startup;
        
        private RadioButton radioButton;

        public User()
        {
            this.classes = new List<Class>();
            radioButton = new RadioButton();
        }

        public User(List<Class> classes)
        {
            this.classes = classes;
        }

        public void addClass(Class c)
        {
            this.classes.Add(c);

            classes[classes.Count-1].radioButton.Text = c.getName();
            classes[classes.Count - 1].radioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            classes[classes.Count - 1].radioButton.ForeColor = Color.Black;
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

        public List<Class> getClasses()
        {
            return this.classes;
        }

        public bool getNotifications()
        {
            return this.notifications;
        }

        public bool getStartup()
        {
            return this.startup;
        }
    }
}
