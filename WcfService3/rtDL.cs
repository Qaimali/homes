using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace WcfService3
{
    public class rtDL
    {
        public static List<CRT> availableRT = new List<CRT>();

        public static List<CRT> allotedtRT = new List<CRT>();

        public static void addRT(CRT rt)
        {
            availableRT.Add(rt);
        }

        public static void deleteRegisteredRt(string rtP)
        {
            int indexForDelete = 0;
            foreach (CRT rtO in rtDL.availableRT)
            {
                if (rtO.Name == rtP)
                {
                    indexForDelete = rtDL.availableRT.IndexOf(rtO);
                    rtDL.availableRT.RemoveAt(indexForDelete);
                    break;
                }
            }
           
        }

        public static bool isRT(string username, string password)
        {
            bool isfound = false;
            foreach (CRT cr in rtDL.availableRT)
            {
                if (cr.Name == username && cr.Password == password)
                {
                    isfound = true;
                    myutilRT.loginRT = cr;
                    return isfound;
                }
            }
            foreach (CRT cr in rtDL.allotedtRT)
            {
                if (cr.Name == username && cr.Password == password)
                {
                    isfound = true;
                    myutilRT.loginRT = cr;
                    return isfound;
                }
            }
            return isfound;
        }

        public static bool resetRtPass(string name, string question, string answer, string newPassword)
        {
            bool isfound = false;
            foreach (CRT ad in rtDL.availableRT)
            {
                if (ad.Name == name && ad.Question == question && ad.Answer == answer)
                {
                    isfound = true;
                    ad.Password = newPassword;
                }
            }
            return isfound;
        }

        public static void addomplaintforRT(string name,string subject,string text,string resident ,string regNumber,string roomNuber)
        {
            Complaints complaint = new Complaints();
            complaint.ComplaintSubject = subject;
            complaint.TextCompliants = text;
            complaint.Residencyofperson = resident;
            complaint.Name = name;
            complaint.RegistrationNumber = regNumber;
            complaint.RoomNumber = roomNuber;
            Cnotification notifications = new Cnotification();
            notifications.Notification = "you have recieved a Complaint from " + name;
            foreach(CRT rt in rtDL.allotedtRT)
            {
                if (rt.AllotedHostel == resident)
                {
                    rt.ComplaintsforRT.Add(complaint);
                    rt.notificationaddtion(notifications);
                }                
            }
        }
    }
}