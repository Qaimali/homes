using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WcfService3
{
    [DataContract]
    public class CDate
    {
        string date;
        [DataMember]
        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }
}