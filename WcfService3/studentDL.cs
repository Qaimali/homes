using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace WcfService3
{
    public class studentDL
    {
        public static List<Cstudent> stdList = new List<Cstudent>();
        public static List<Cstudent> hostelRegistration = new List<Cstudent>();
        public static List<Cstudent> allotedstudents = new List<Cstudent>();
        public static bool checkInS(string n1, string r1, string ro1,String dt)
        {
            bool isfound = false;
            foreach(Cstudent cs in studentDL.allotedstudents)
            {
                if(cs.Name== n1 && cs.RegistrationNumber == r1 && cs.RoomNumber == ro1)
                {
                    CDate d = new CDate();
                    d.Date=dt;
                    cs.Student_checkin.Add(d);
                    isfound =true;
                }
            }
            return isfound;
        }
        
        public static bool checkOutS(string n1, string r1, string ro1, string dt)
        {
            bool isfound = false;
            foreach (Cstudent cs in studentDL.allotedstudents)
            {
                if (cs.Name == n1 && cs.RegistrationNumber == r1 && cs.RoomNumber == ro1)
                {
                    CDate d = new CDate();
                    d.Date = dt;
                    cs.Student_checkout.Add(d);
                    isfound = true;
                }
            }
            return isfound;
        }
        public static bool CheckInVisitor(string h1,string r1,string v1,string room, string checkin,string cnic)
        {
            bool isfound = false;
            foreach(Cstudent c in studentDL.allotedstudents)
            {
                if(c.Name == h1 && c.RegistrationNumber == r1 && c.RoomNumber == room)
                {
                    Cvisistor vi = new Cvisistor();
                    vi.Name = v1;
                    vi.CheckIn = checkin;
                    vi.Cnic = cnic;
                    c.addvisitors(vi);
                    isfound = true;
                }
            }
            return isfound;
        }
        public static bool CheckOutVisitor(string h1, string r1, string v1, string room, string checkout, string cnic)
        {
            bool isfound = false;
            foreach (Cstudent c in studentDL.allotedstudents)
            {
                if (c.Name == h1 && c.RegistrationNumber == r1 && c.RoomNumber == room)
                {
                    foreach(Cvisistor vo in c.Visitors)
                    {
                        if(vo.Name==v1 && vo.Cnic == cnic)
                        {
                            vo.CheckOut = checkout;
                            c.addvisitors(vo);
                            isfound = true;
                        }
                    }   
                }
            }
            return isfound;
        }
        public static void addstudent(Cstudent st)
        {
            stdList.Add(st);
        }
        public static void getHostelRegistration(Cstudent st)
        {
            hostelRegistration.Add(st);
        }
        public static void allotment(Cstudent s)
        {
            int p = 0;
            foreach(Hostel h in hostelDL.hostellist)
            {
                if (h.HostelName == s.HostelName)
                {
                    p = Convert.ToInt32(s.RoomNumber)-1;
                    if (h.Roomlist[p].Allotees < h.Roomlist[p].Capacity)
                    {
                        allotedstudents.Add(s);
                        h.Roomlist[p].Allotees++;
                    }
                }
            }
        }
        
        public static void addNotification(Cnotification not) 
        {
            myutilStudent.loginstudents.Notificationlist.Add(not);
        }
        public static bool isstudent(string u1, string p1)
        {
            bool isfound = false;
            foreach (Cstudent cst in studentDL.stdList)
            {
                if (cst.Userid == u1 && cst.Password == p1)
                {
                    isfound = true;
                    myutilStudent.loginstudents = cst;
                }
            }
            return isfound;
        }
       
        public static bool resetStudentPass(string u1, string q1, string a1, string p1)
        {
            bool isfound = false;
            foreach (Cstudent ad in studentDL.stdList)
            {
                if (ad.Userid== u1 && ad.Question == q1 && ad.Answer == a1)
                {
                    isfound = true;
                    ad.Password = p1;
                }
            }
            return isfound;
        }
    }
}