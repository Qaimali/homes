using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3
{
    public class Hostel
    {
        string Name;

        public string HostelName
        {
            get { return Name; }
            set { Name = value; }
        }
        int numberOfRooms;

        public int NumberOfRooms
        {
            get { return numberOfRooms; }
            set { numberOfRooms = value; }
        }
        List<room> roomlist=new List<room>();

        public List<room> Roomlist
        {
            get { return roomlist; }
            set { roomlist = value; }
        }
        List<CRT> rtList=new List<CRT>();

        public List<CRT> RtList
        {
            get { return rtList; }
            set { rtList = value; }
        }
        List<Cgatek> gatekeeperList=new List<Cgatek>();

        public List<Cgatek> GatekeeperList
        {
            get { return gatekeeperList; }
            set { gatekeeperList = value; }
        }

    }
}