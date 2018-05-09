using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService3
{
    
    public class hostelDL
    {
        
        public static List<Hostel> hostellist = new List<Hostel>();
        public static void addhostel(Hostel h) 
        {
            hostellist.Add(h);
        }

    }
}