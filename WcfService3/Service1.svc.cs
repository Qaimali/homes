using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void regst(string username, string password, string question, string answer)
        {
            Cstudent st = new Cstudent();
            st.Userid = username;
            st.Password = password;
            st.Question = question;
            st.Answer = answer;
            studentDL.stdList.Add(st);
        }
        public void reggk(string username, string password, string question, string answer)
        {
            Cgatek gk = new Cgatek();
            gk.Name = username;
            gk.Password = password;
            gk.Question = question;
            gk.Answer = answer;
            gatekDL.gatekList.Add(gk);
        }
        public void regrt(string username, string password, string question, string answer)
        {
            CRT rt = new CRT();
            rt.Name = username;
            rt.Password = password;
            rt.Question = question;
            rt.Answer = answer;
            rtDL.rtlist.Add(rt);
        }
        public void regadmin(string username, string password, string question, string answer)
        {
            Cadmin ad = new Cadmin();
            ad.Adminname = username;
            ad.Password = password;
            ad.Question = question;
            ad.Answer = answer;
            adminDL.admlist.Add(ad);
        }
        public bool isAdmin(string username, string password)
        {
            adminDL adm = new adminDL();
            if (adm.isadmin(username, password))
            {
                return true;
            }
            return false;
        }
        public bool isStudent(string username, string password)
        {
            studentDL std = new studentDL();
            if (std.isstudent(username, password))
            {
                return true;
            }
            return false;

        }
        public bool isRT(string username, string password)
        {
            rtDL rt = new rtDL();
            if (rt.isRT(username, password))
            {
                return true;
            }
            return false;

        }
        public bool isGatekeeper(string username, string password)
        {
            gatekDL gk = new gatekDL();
            if (gk.isgatekeeper(username, password))
            {
                return true;
            }
            return false;
        }

    }
}
