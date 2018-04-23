using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3
{
    public class room
    {
        int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        int allotees;

        public int Allotees
        {
            get { return allotees; }
            set { allotees = value; }
        }
        int roomnumber;

        public int Roomnumber
        {
            get { return roomnumber; }
            set { roomnumber = value; }
        }
    }
}