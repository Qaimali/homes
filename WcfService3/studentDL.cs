using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace WcfService3
{
    public class studentDL
    {
        public static List<Cstudent> stdList = new List<Cstudent>();
        void addstudent(Cstudent st)
        {
            stdList.Add(st);
        }
        public bool isstudent(string u1, string p1)
        {
            bool isfound = false;
            foreach (Cstudent cst in studentDL.stdList)
            {
                if (cst.Userid == u1 && cst.Password == p1)
                {
                    isfound = true;
                }
            }
            return isfound;
        }
    }
}