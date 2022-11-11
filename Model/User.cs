using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Class_Manager.Model
{
    [Serializable()]
    [XmlRoot("User", Namespace = "", IsNullable = false, DataType = "")]
    public class User
    {
        public List<Class> classes;
        bool notifications;
        bool startup;
        private float notificationsUpdate;

        public User()
        {
            this.classes = new List<Class>();
            this.startup = true;
            this.notificationsUpdate = 5; //5 min default
            notifications = false;

        }
        public User(List<Class> classes)
        {
            this.classes = classes;
            this.startup = true;
            this.notificationsUpdate = 5; //5 min default\
            notifications = false;
        }
        
        //property for classes
        public List<Class> Classes
        {
            get { return classes; }
            set { classes = value; }
        }
        //property for notifications
        public bool Notifications
        {
            get { return notifications; }
            set { notifications = value; }
        }
        //property for startup
        public bool Startup
        {
            get { return startup; }
            set { startup = value; }
        }
        public float NotificationsUpdate
        {
            get { return notificationsUpdate; }
            set { notificationsUpdate = value; }
        }
    }
}
