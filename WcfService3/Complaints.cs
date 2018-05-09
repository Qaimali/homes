using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WcfService3
{
    [DataContract]
    public class Complaints
    {
        
        string complaintSubject;
        string textCompliants;
        string name;
        string residencyofperson;
        [DataMember]
        public string Residencyofperson
        {
            get
            {
                return residencyofperson;
            }

            set
            {
                residencyofperson = value;
            }
        }
        [DataMember]
        public string TextCompliants
        {
            get
            {
                return textCompliants;
            }

            set
            {
                textCompliants = value;
            }
        }
        [DataMember]
        public string ComplaintSubject
        {
            get
            {
                return complaintSubject;
            }

            set
            {
                complaintSubject = value;
            }
        }
        [DataMember]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}