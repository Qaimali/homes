using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace WcfService3
{
    public class rtDL
    {
        public static List<CRT> rtlist = new List<CRT>();

        public static List<CRT> allotedtRT = new List<CRT>();

        public static void addRT(CRT rt)
        {
            rtlist.Add(rt);
        }

        public static ArrayList arr = new ArrayList();

        public  static void addNotification(Cnotification not)
        {
            myutilRT.loginRT.Notificationlist.Add(not);
        }

        public static ArrayList rtnames() 
        {
            foreach (CRT cr in rtDL.rtlist) 
            {
                rtDL.arr.Add(cr.Name);
            }
            return arr;
        }

        public static bool isRT(string username, string password)
        {
            bool isfound = false;
            foreach (CRT cr in rtDL.rtlist)
            {
                if (cr.Name == username && cr.Password == password)
                {
                    isfound = true;
                    myutilRT.loginRT = cr;
                }
            }
            return isfound;
        }

        public static bool resetRtPass(string u1, string q1, string a1, string p1)
        {
            bool isfound = false;
            foreach (CRT ad in rtDL.rtlist)
            {
                if (ad.Name == u1 && ad.Question == q1 && ad.Answer == a1)
                {
                    isfound = true;
                    ad.Password = p1;
                }
            }
            return isfound;
        }

        public static void addomplaintforRT(string name1,string subject1,string text1,string resident)
        {
            Complaints com = new Complaints();
            com.ComplaintSubject = subject1;
            com.TextCompliants = text1;
            com.Residencyofperson = resident;
            com.Name = name1;
            foreach(CRT rt in rtDL.allotedtRT)
            {
                if (rt.AllotedHostel == resident)
                {
                    rt.ComplaintsforRT.Add(com);
                }                
            }
        }
    }
}