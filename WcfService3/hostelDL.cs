using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WcfService3
{
    //[DataContract]
    public class hostelDL
    {
        //[DataMember]
        public static List<Hostel> hostellist = new List<Hostel>();
        public void addhostel(Hostel h) 
        {
            hostellist.Add(h);
        }
       
        
    }
}