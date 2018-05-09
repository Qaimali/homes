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
        public static ArrayList gatearr = new ArrayList();
        public static ArrayList gknames()
        {
            foreach (Cgatek cr in gatekDL.gatekList)
            {
                gatekDL.gatearr.Add(cr.Name);
            }
            return gatearr;
        }
        public static void addgatekeeper(Cgatek gk)
        {
            gatekList.Add(gk);
        }
        public static void addNotification(Cnotification not)
        {
            myutilGateKeeper.logingatkeeper.Notificationlist.Add(not);
        }
        public static bool isgatekeeper(string username, string password)
        {
            bool isfound = false;
            foreach (Cgatek cg in gatekDL.gatekList)
            {
                if (cg.Name == username && cg.Password == password)
                {
                    isfound = true;
                    myutilGateKeeper.logingatkeeper = cg;
                }
            }
            return isfound;
        }
        public static bool resetGatePass(string u1, string q1, string a1, string p1)
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