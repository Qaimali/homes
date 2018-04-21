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
        void addRT(CRT rt)
        {
            rtlist.Add(rt);
        }
        public bool isRT(string username, string password)
        {
            bool isfound = false;
            foreach (CRT cr in rtDL.rtlist)
            {
                if (cr.Name == username && cr.Password == password)
                {
                    isfound = true;
                }
            }
            return isfound;
        }
        public bool resetRtPass(string u1, string q1, string a1, string p1)
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
    }
}