using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WcfService3
{
    [DataContract]
    public class Hostel
    {
        
        string Name;
        [DataMember]
        public string HostelName
        {
            get { return Name; }
            set { Name = value; }
        }
        int numberOfRooms;
        [DataMember]
        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set { numberOfRooms = value; }
        }
        List<room> roomlist=new List<room>();
        [DataMember]
        public List<room> Roomlist
        {
            get { return roomlist; }
            set { roomlist = value; }
        }
        List<CRT> rtList=new List<CRT>();
        [DataMember]
        public List<CRT> RtList
        {
            get { return rtList; }
            set { rtList = value; }
        }
        List<Cgatek> gatekeeperList=new List<Cgatek>();
        [DataMember]
        public List<Cgatek> GatekeeperList
        {
            get { return gatekeeperList; }
            set { gatekeeperList = value; }
        }


    }
}