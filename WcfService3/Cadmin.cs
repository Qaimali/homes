using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3
{
    public class Cadmin
    {
        String adminname;

        public String Adminname
        {
            get { return adminname; }
            set { adminname = value; }
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
    }
}