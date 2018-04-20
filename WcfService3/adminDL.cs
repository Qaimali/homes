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
        void addadmin(Cadmin ad) 
        {
            admlist.Add(ad);
        }
        public bool isadmin(string username, string password) 
        {
            bool isfound = false;
            foreach (Cadmin ad in adminDL.admlist)
            {
                if (ad.Adminname== username && ad.Password == password)
                {
                    isfound = true;
                }
            }
            return isfound;
        }
        public bool resetadminpass(string u1, string q1, string a1) 
        {
            bool isfound = false;
            foreach (Cadmin ad in adminDL.admlist) 
            {
                if (ad.Adminname==u1 && ad.Question==q1 && ad.Answer==a1)
                {
                    isfound = true;
                    ad.Password = "abc";
                }
            }
            return isfound;
        }
    }
}