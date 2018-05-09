using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WcfService3
{
    [DataContract]
    public class CRT
    {
        
        String name;

        [DataMember]

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        String password;

        [DataMember]

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        String question;

        [DataMember]

        public String Question
        {
            get { return question; }
            set { question = value; }
        }
        String answer;

        [DataMember]

        public String Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        string allotedHostel="Not Alloted any hostel";

        [DataMember]

        List<Cnotification> notificationlist = new List<Cnotification>();

        public List<Cnotification> Notificationlist
        {
            get { return notificationlist; }
            set { notificationlist = value; }
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

        [DataMember]

        public List<Complaints> ComplaintsforRT
        {
            get
            {
                return complaintsforRT;
            }

            set
            {
                complaintsforRT = value;
            }
        }

        List<Complaints> complaintsforRT = new List<Complaints>();
    }
}