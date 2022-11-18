using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

//Once instance of this class is created, it will be used to store all the data for the program
//XML serialization is used to save the data to a file
//contains a list of classes, along with setting information for the program

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
        private Color col = Color.CadetBlue;

        public User()   //default constructor
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

        //properties for the class
        public List<Class> Classes
        {
            get { return classes; }
            set { classes = value; }
        }
        public bool Notifications
        {
            get { return notifications; }
            set { notifications = value; }
        }
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
        public Color Col    
        {
            get { return col; }
            set { col = value; }
        }
    }
}
