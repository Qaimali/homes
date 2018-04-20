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
        void addgatekeeper(Cgatek gk)
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
    }
}