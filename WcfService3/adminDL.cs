using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace WcfService3
{
    public class adminDL
    {
        public static List<Cadmin> admlist = new List<Cadmin>();
        public static void addadmin(Cadmin ad)
        {
            admlist.Add(ad);
        }
        public static bool isadmin(string username, string password)
        {
            bool isfound = false;
            foreach (Cadmin ad in adminDL.admlist)
            {
                if (ad.Adminname == username && ad.Password == password)
                {
                    isfound = true;
                }
            }
            return isfound;
        }
        public static bool resetadminpass(string u1, string q1, string a1, string p1)
        {
            bool isfound = false;
            foreach (Cadmin ad in adminDL.admlist)
            {
                if (ad.Adminname == u1 && ad.Question == q1 && ad.Answer == a1)
                {
                    isfound = true;
                    ad.Password = p1;
                }
            }
            return isfound;
        }
        public static void addcomplaintsforadmin(string name1,string subject1,string text1,string resident)
        {
            Complaints com = new Complaints();
            com.ComplaintSubject = subject1;
            com.TextCompliants = text1;
            com.Residencyofperson = resident;
            com.Name = name1;
            Cadmin c = new Cadmin();
            c.ComplaintsForAdmin.Add(com);
        }
    }
}