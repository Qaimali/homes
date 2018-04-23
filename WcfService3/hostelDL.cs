using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3
{
    public class hostelDL
    {
        public static List<Hostel> hostellist = new List<Hostel>();
        public void addhostel(Hostel h) 
        {
            hostellist.Add(h);
        }
    }
}