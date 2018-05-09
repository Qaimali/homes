using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WcfService3
{
    [DataContract]
    public class Cnotification
    {
        string notification;
        [DataMember]
        public string Notification
        {
            get { return notification; }
            set { notification = value; }
        }
    }
}