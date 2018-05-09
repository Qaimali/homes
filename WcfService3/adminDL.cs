using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace WcfService3
{
    public class adminDL
    {
        public static List<Cadmin> adminslist = new List<Cadmin>();
        public static List<Complaints> complaintsForAdmin = new List<Complaints>();
        public static void addadmin(Cadmin admin)
        {
            adminDL.adminslist.Add(admin);
        }
        public static bool isAdmin(string username, string password)
        {
            bool isfound = false;
            foreach (Cadmin admin in adminDL.adminslist)
            {
                if (admin.Adminname == username && admin.Password == password)
                {
                    isfound = true;
                }
            }
            return isfound;
        }
        public static bool resetAdminPassword(string nameOfadmin, string qestion, string answer, string newPassword)
        {
            bool isfound = false;
            foreach (Cadmin admin in adminDL.adminslist)
            {
                if (admin.Adminname == nameOfadmin && admin.Question == qestion && admin.Answer == answer)
                {
                    isfound = true;
                    admin.Password = newPassword;
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
            adminDL.complaintsForAdmin.Add(com);
        }
    }
}