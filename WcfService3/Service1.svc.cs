using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;

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
            studentDL std = new studentDL();
            std.addstudent(st);
        }
        public void reggk(string username, string password, string question, string answer)
        {
            Cgatek gk = new Cgatek();
            gk.Name = username;
            gk.Password = password;
            gk.Question = question;
            gk.Answer = answer;
            gatekDL gkl = new gatekDL();
            gkl.addgatekeeper(gk);    
        }
        public void regrt(string username, string password, string question, string answer)
        {
            CRT rt = new CRT();
            rt.Name = username;
            rt.Password = password;
            rt.Question = question;
            rt.Answer = answer;
            rtDL rtd = new rtDL();
            rtd.addRT(rt);  
        }
        public void regadmin(string username, string password, string question, string answer)
        {
            Cadmin ad = new Cadmin();
            ad.Adminname = username;
            ad.Password = password;
            ad.Question = question;
            ad.Answer = answer;
            adminDL adl = new adminDL();
            adl.addadmin(ad);
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
                Cnotification not = new Cnotification();
                not.Notification = "Dear Student fill the registration form to get allotment in HOMES"+myutilStudent.loginstudents.Userid;
                std.addNotification(not);
                return true;
            }
            return false;

        }
        public bool isRT(string username, string password)
        {
            rtDL rt = new rtDL();
            if (rt.isRT(username, password))
            {
                Cnotification not = new Cnotification();
                not.Notification = "You are registered in 'HOMES'.You will be notified if there w"+myutilRT.loginRT.Name;
                rt.addNotification(not);
                return true;
            }
            return false;

        }
        public bool isGatekeeper(string username, string password)
        {
            gatekDL gk = new gatekDL();
            if (gk.isgatekeeper(username, password))
            {
                Cnotification not = new Cnotification();
                not.Notification = "You are registered in 'HOMES'.Y" ;
                gk.addNotification(not);
                return true;
            }
            return false;
        }
        public bool canresetAdmin(string n1, string q1, string a1, string pass) 
        {
            adminDL ad = new adminDL();
            if(ad.resetadminpass(n1,q1,a1,pass))
            {
                return true;
            }
            return false;
        }
        public bool canresetgatekeeper(string n1, string q1, string a1, string pass) 
        {
            gatekDL gk = new gatekDL();
            if(gk.resetGatePass(n1,q1,a1,pass))
            {
                return true;
            }
            return false;
        }
        public bool canresetstudent(string n1, string q1, string a1, string pass) 
        {
            studentDL st = new studentDL();
            if (st.resetStudentPass(n1, q1, a1,pass)) 
            {
                return true;
            }
            return false;
        }
        public bool canresetrt(string n1, string q1, string a1, string pass) 
        {
            rtDL rt = new rtDL();
            if(rt.resetRtPass(n1,q1,a1,pass))
            {
                return true;
            }
            return false;
        }
        public List<Cnotification> mutateStNotification() 
        {
            return myutilStudent.loginstudents.Notificationlist;
        }
        public string loggedstudent() 
        {
            return myutilStudent.loginstudents.Userid;
        }
        public string loggedRt() 
        {
            return myutilRT.loginRT.Name;
        }
        public List<Cnotification> mutateGKNotifications() 
        {
            return myutilGateKeeper.logingatkeeper.Notificationlist;
            
        }
        public List<Cnotification> mutateRtNotifications() 
        {
            return myutilRT.loginRT.Notificationlist;
        }
        public string logged_Gatekeeper() 
        {
            return myutilGateKeeper.logingatkeeper.Name;
        }
        public void addhostel(string hostname, int  roomcapcity, int nuofrooms, string r1, string r2, string g1, string g2)
        {
            Hostel g = new Hostel();
            g.HostelName = hostname;
            hostelDL hdl = new hostelDL();
            
            for (int i = 1; i <= nuofrooms; i++)
            {
                room r = new room();
                r.Roomnumber = i;
                r.Allotees = 0;
                r.Capacity = roomcapcity;
                g.Roomlist.Add(r);
            }
            foreach (CRT cr in rtDL.rtlist)
            {
                if (cr.Name == r1)
                {
                    Cnotification not = new Cnotification();
                    not.Notification = "Mr.you are alloted to take your positions";
                    cr.Notificationlist.Add(not);
                    g.RtList.Add(cr);
                }
            }
            foreach (CRT cr in rtDL.rtlist)
            {
                if (cr.Name == r2)
                {
                    Cnotification not = new Cnotification();
                    not.Notification = "Mr.you are alloted to take your positions";
                    cr.Notificationlist.Add(not);
                    g.RtList.Add(cr);
                }
            }
            foreach (Cgatek cg in gatekDL.gatekList)
            {
                if (cg.Name == g1)
                {
                    Cnotification not = new Cnotification();
                    not.Notification = "Mr.you are alloted to take your positions";
                    cg.Notificationlist.Add(not);
                    g.GatekeeperList.Add(cg);
                }
            }
            foreach (Cgatek cg in gatekDL.gatekList)
            {
                if (cg.Name == g2)
                {
                    Cnotification not = new Cnotification();
                    not.Notification = "Mr,you are alloted to take your positions";
                    cg.Notificationlist.Add(not);
                    g.GatekeeperList.Add(cg);
                }
            }
        }
        public ArrayList  rtnames() 
        {
            rtDL n = new rtDL();
            return n.rtnames();
        }
        public List<Hostel> hostels() 
        {
            return hostelDL.hostellist;
        }
        public ArrayList gknames() 
        {
            gatekDL g = new gatekDL();
            return g.gknames();
        }
    }
   
}

