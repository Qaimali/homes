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
        
        public void addstudent(Cstudent st)
        {
            stdList.Add(st);
        }
        public void addNotification(Cnotification not) 
        {
            myutilStudent.loginstudents.Notificationlist.Add(not);
        }
        public bool isstudent(string u1, string p1)
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
       
        public bool resetStudentPass(string u1, string q1, string a1, string p1)
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