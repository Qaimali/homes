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
    }
}