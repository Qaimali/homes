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
        public static bool checkInS(string name, string registrationNumber, string roomNumber,String checkIn_date)
        {
            bool isfound = false;
            foreach(Cstudent student in studentDL.allotedstudents)
            {
                if(student.Name== name && student.RegistrationNumber == registrationNumber && student.RoomNumber == roomNumber)
                {
                    CDate d = new CDate();
                    d.Date=checkIn_date;
                    student.Student_checkin.Add(d);
                    student.CheckIn = true;
                    isfound =true;
                }
            }
            return isfound;
        }
        
        public static bool checkOutS(string name, string registrationNumber, string roomNumber, string checkOut_date)
        {
            bool isfound = false;
            foreach (Cstudent studentO in studentDL.allotedstudents)
            {
                if (studentO.Name == name && studentO.RegistrationNumber == registrationNumber && studentO.RoomNumber == roomNumber && studentO.CheckIn )
                { 
                    CDate d = new CDate();
                    d.Date = checkOut_date;
                    studentO.Student_checkout.Add(d);
                    isfound = true;
                    studentO.CheckIn = false;
                }
            }
            return isfound;
        }
        public static bool CheckInVisitor(string registrationNumber,string visitor_name, string checkin,string cnic)
        {
            bool isfound = false;
            foreach(Cstudent c in studentDL.allotedstudents)
            {
                if(c.RegistrationNumber == registrationNumber )
                {
                    Cvisistor visitorO = new Cvisistor();
                    visitorO.Name = visitor_name;
                    visitorO.CheckIn = checkin;
                    visitorO.Cnic = cnic;
                    visitorO.CheckInbool = true;
                    c.addvisitors(visitorO);
                    isfound = true;
                }
            }
            return isfound;
        }
        public static bool CheckOutVisitor(string registrationNumber, string visitor_name, string checkout, string cnic)
        {
            bool isfound = false;
            foreach (Cstudent student in studentDL.allotedstudents)
            {
                if (student.RegistrationNumber == registrationNumber)
                {
                    foreach(Cvisistor visitorO in student.Visitors)
                    {
                        if(visitorO.Name==visitor_name && visitorO.Cnic == cnic)
                        {
                            visitorO.CheckOut = checkout;
                            visitorO.CheckInbool = false;
                            isfound = true;
                            return isfound;
                        }
                    }   
                }
            }
            return isfound;
        }
        public static void addstudent(Cstudent student)
        {
            stdList.Add(student);
        }
        public static void getHostelRegistration(Cstudent student)
        {
            hostelRegistration.Add(student);
        }
        public static void allotment(Cstudent student)
        {
            int p = 0;
            foreach(Hostel h in hostelDL.hostellist)
            {
                if (h.HostelName == student.HostelName)
                {
                    p = Convert.ToInt32(student.RoomNumber)-1;
                    if (h.Roomlist[p].Allotees < h.Roomlist[p].Capacity)
                    {
                        allotedstudents.Add(student);
                        h.Roomlist[p].Allotees++;
                    }
                }
            }
        }
        
        public static void addNotification(Cnotification not) 
        {
            myutilStudent.loginstudents.Notificationlist.Add(not);
        }
        public static bool isStudent(string u1, string p1)
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