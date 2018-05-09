using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WcfService3
{

    [DataContract]
    public class Cadmin
    {
        String adminname;

        [DataMember]

        public String Adminname
        {
            get { return adminname; }
            set { adminname = value; }
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

        

        

    }
}