using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService3
{
    [DataContract]
    public class Cgatek
    {
        [DataMember]

        public String Question
        {
            get { return question; }
            set { question = value; }
        }
        String name;

        [DataMember]

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]

        public List<Cnotification> Notificationlist
        {
            get { return notificationlist; }
            set { notificationlist = value; }
        }
        [DataMember]

        public String Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        String password;

        [DataMember]

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        [DataMember]
        public string AllotedHostel
        {
            get
            {
                return allotedHostel;
            }

            set
            {
                allotedHostel = value;
            }
        }

        String question;

        
        String answer;

        string allotedHostel;

        
        List<Cnotification> notificationlist = new List<Cnotification>();

        
        public void notificationaddtion(Cnotification n)
        {
            Notificationlist.Add(n);
        }
        
    }
}