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
            Cnotification not = new Cnotification();
            not.Notification = "You are registered in HOMES now.You will notified soon on Room Alootment if there is vacancy" ;
            st.notificationaddtion(not);
            studentDL.addstudent(st);
        }

        public void reggk(string username, string password, string question, string answer)
        {
            Cgatek gk = new Cgatek();
            gk.Name = username;
            gk.Password = password;
            gk.Question = question;
            gk.Answer = answer;
            Cnotification not = new Cnotification();
            not.Notification = "You are registered in 'HOMES'.You will be notified if there vacancy in HOMES";
            gk.notificationaddtion(not);
            gatekDL.addgatekeeper(gk);
        }

        public void regrt(string username, string password, string question, string answer)
        {
            CRT rt = new CRT();
            rt.Name = username;
            rt.Password = password;
            rt.Question = question;
            rt.Answer = answer;
            Cnotification not = new Cnotification();
            not.Notification = "You are registered in 'HOMES'.You will be notified if there vacancy in HOMES" ;
            rt.notificationaddtion(not);
            rtDL.addRT(rt);
        }

        public void regadmin(string username, string password, string question, string answer)
        {
            Cadmin ad = new Cadmin();
            ad.Adminname = username;
            ad.Password = password;
            ad.Question = question;
            ad.Answer = answer;
            adminDL.addadmin(ad);
        }

        public bool isAdmin(string username, string password)
        {
            adminDL adm = new adminDL();
            if (adminDL.isadmin(username, password))
            {
                return true;
            }
            return false;
        }

        public bool isStudent(string username, string password)
        {
            
            if (studentDL.isstudent(username, password))
            {
                
                return true;
            }
            return false;

        }

        public bool isRT(string username, string password)
        {
           
            if (rtDL.isRT(username, password))
            {
                
                return true;
            }
            return false;

        }

        public bool isGatekeeper(string username, string password)
        {
            
            if (gatekDL.isgatekeeper(username, password))
            {
                
                return true;
            }
            return false;
        }

        public bool canresetAdmin(string n1, string q1, string a1, string pass)
        {
            
            if (adminDL.resetadminpass(n1, q1, a1, pass))
            {
                return true;
            }
            return false;
        }

        public bool canresetgatekeeper(string n1, string q1, string a1, string pass)
        {
            
            if (gatekDL.resetGatePass(n1, q1, a1, pass))
            {
                return true;
            }
            return false;
        }
        public bool canresetstudent(string n1, string q1, string a1, string pass)
        {
           
            if (studentDL.resetStudentPass(n1, q1, a1, pass))
            {
                return true;
            }
            return false;
        }
        public bool canresetrt(string n1, string q1, string a1, string pass)
        {
            
            if (rtDL.resetRtPass(n1, q1, a1, pass))
            {
                return true;
            }
            return false;
        }
        
        public Cstudent loggedstudent()
        {
            return myutilStudent.loginstudents;
        }
        public CRT loggedRt()
        {
            return myutilRT.loginRT;
        }
        public Cgatek logged_Gatekeeper()
        {
            return myutilGateKeeper.logingatkeeper;
        }
        public void addhostel(string hostname, int roomcapcity, int nuofrooms, string r1, string r2, string g1, string g2)
        {
            Hostel g = new Hostel();
            g.HostelName = hostname;
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
                    cr.AllotedHostel = g.HostelName;
                    cr.Notificationlist.Add(not);
                    rtDL.allotedtRT.Add(cr);
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
                    cr.AllotedHostel = g.HostelName;
                    rtDL.allotedtRT.Add(cr);
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
            hostelDL.addhostel(g);
        }

        public ArrayList rtnames()
        {
            return rtDL.rtnames();
        }

        public Hostel hostels(int index)
        {
            return hostelDL.hostellist[index];
        }

        public ArrayList gknames()
        {
    
            return gatekDL.gknames();
        }

        public List<Hostel> showallhostel()
        {
            return hostelDL.hostellist;
        }

        public void registerforhostel(Cstudent s)
        { 
            studentDL.getHostelRegistration(s);
        }

        public bool isHostelRegistered(String name)
        {
            bool isfound = false;
            foreach (Cstudent stu in studentDL.hostelRegistration)
            {
                if (stu.Userid == name)
                {
                    isfound = true;
                }
            }
            foreach(Cstudent stu in studentDL.allotedstudents)
            {
                if (stu.Userid == name)
                {
                    isfound = true;
                }
            }
            return isfound;
        }

        public List<Cstudent> registeredstudent()
        {
            return studentDL.hostelRegistration;
        }

        public Cstudent getregisteredstudent(int index)
        {
            return studentDL.hostelRegistration[index];
        }

        public List<Cstudent> allotedStudentsforhostel()
        {
            return studentDL.allotedstudents;
        }

        public void allotstudent(Cstudent std)
        {
            studentDL.allotment(std);
        }

        public void addnotificationforsearch(string name, string regno, string not)
        {
            Cnotification cs = new Cnotification();
            cs.Notification = not;
            foreach (Cstudent c in studentDL.allotedstudents)
            {
                if (c.Name == name && c.RegistrationNumber == regno)
                {
                    c.notificationaddtion(cs);
                }
            }
        }
        public void addNotificationForRt(string name,string hostel,string not)
        {
            Cnotification cs = new Cnotification();
            cs.Notification = not;
            foreach(CRT rt in rtDL.allotedtRT)
            {
                if(rt.AllotedHostel==hostel && rt.Name == name)
                {
                    rt.Notificationlist.Add(cs);
                }
            }
        }

        public void deletependingst(Cstudent st)
        {
            int p=0;
           foreach(Cstudent s in studentDL.hostelRegistration)
           {
                if(s.Userid == st.Userid && s.RegistrationNumber == st.RegistrationNumber)
                {
                    p = studentDL.hostelRegistration.IndexOf(s);
                    break;
                }
           }
            studentDL.hostelRegistration.RemoveAt(p);
        }

        public bool student_checkin(string name, string regNo, string roomNo, string checkin_date)
        {
            
            
            if (studentDL.checkInS(name, regNo, roomNo, checkin_date))
            {
                return true;
            }
            return false;
        }
        public bool student_checkOut(string name, string regNo, string roomNo, string checkOut_date)
        {
            
            if (studentDL.checkOutS(name, regNo, roomNo, checkOut_date))
            {
                return true;
            }
            return false;
        }
        public Cstudent indexForAllottedStudent(int index)
        {
            return studentDL.allotedstudents[index];
        }
        public bool visitor_checkIn(string host, string hostregno, string visitor_name, string visitor_cnic, string checkin, string room_number)
        {
            
            
            if (studentDL.CheckInVisitor(host, hostregno, visitor_name,room_number, checkin, visitor_cnic))
            {
                return true;
            }
            return false;
        }
        public bool visitor_checkOut(string host, string hostregno, string visitor_name, string visitor_cnic, string checkout, string room_number)
        {
            CDate c = new CDate();
            c.Date = checkout;
            
            if (studentDL.CheckOutVisitor(host, hostregno, visitor_name,room_number, checkout, visitor_cnic))
            {
                return true;
            }
            return false;
        }

        public List<CRT> allotedRT()
        {
            return rtDL.allotedtRT;
        }

        public void complaintsfromstudent(string n1, string s1, string t1, string r1,string regNum,string roomNu)
        {
            rtDL.addomplaintforRT(n1, s1, t1, r1,regNum,roomNu);
        }
        public void complaintsfromRT(string n1, string s1, string t1, string r1)
        {
            adminDL.addcomplaintsforadmin(n1, s1, t1, r1);
        }

        public List<Complaints> getComplainFromRt()
        {
            return adminDL.complaintsForAdmin;
        }

        public Complaints getIndexedComplaintsFromRt(int index)
        {
            return adminDL.complaintsForAdmin[index];
        }
        public void deleteComplaintsfromStudents(Complaints comp)
        {
            int p = 0;
            foreach(CRT rt in rtDL.allotedtRT)
            {
                if(rt.AllotedHostel== comp.Residencyofperson)
                {
                    foreach(Complaints c in rt.ComplaintsforRT)
                    {
                        if(c.RegistrationNumber == comp.RegistrationNumber && c.Name== comp.Name)
                        {
                            p = rt.ComplaintsforRT.IndexOf(c);
                            break;
                        }
                    }
                    rt.ComplaintsforRT.RemoveAt(p);
                }
            }

        }

        public void deleteComplaintsfromRT(int index)
        {
            adminDL.complaintsForAdmin.RemoveAt(index);
        }

        public void deleteAllotedStudent(Cstudent s)
        {
            int p = 0;
            foreach(Cstudent stud in studentDL.allotedstudents)
            {
                if(stud.RegistrationNumber == s.RegistrationNumber && stud.Userid == s.Userid)
                {
                    p = studentDL.allotedstudents.IndexOf(stud);
                }
            }
            studentDL.allotedstudents.RemoveAt(p);
        }



    }   
}

