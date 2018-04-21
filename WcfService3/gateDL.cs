using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace WcfService3
{
    public class gatekDL
    {
        public static List<Cgatek> gatekList = new List<Cgatek>();
        public void addgatekeeper(Cgatek gk)
        {
            gatekList.Add(gk);
        }
        public bool isgatekeeper(string username, string password)
        {
            bool isfound = false;
            foreach (Cgatek cg in gatekDL.gatekList)
            {
                if (cg.Name == username && cg.Password == password)
                {
                    isfound = true;
                }
            }
            return isfound;
        }
        public bool resetGatePass(string u1, string q1, string a1, string p1)
        {
            bool isfound = false;
            foreach (Cgatek ad in gatekDL.gatekList)
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