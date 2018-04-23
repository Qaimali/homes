using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3
{
    public class Cstudent
    {
        String userid;

        public String Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        String question;

        public String Question
        {
            get { return question; }
            set { question = value; }
        }
        String answer;

        public String Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        List<Cnotification> notificationlist = new List<Cnotification>();

        public List<Cnotification> Notificationlist
        {
            get { return notificationlist; }
            set { notificationlist = value; }
        }
    }
}