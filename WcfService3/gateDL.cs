using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace WcfService3
{
    public class gatekDL
    {
        public static List<Cgatek> availableGatekeepers = new List<Cgatek>();

        public static List<Cgatek> allotedGatekeepers = new List<Cgatek>();

        public static void deleteRegisteredGateKeeper(string gatekeeperP)
        {
            int indexForDelete = 0;
            foreach (Cgatek gatekeeperO in gatekDL.availableGatekeepers)
            {
                if (gatekeeperO.Name== gatekeeperP)
                {
                    indexForDelete =gatekDL.availableGatekeepers.IndexOf(gatekeeperO);
                    gatekDL.availableGatekeepers.RemoveAt(indexForDelete);
                    break;
                }
            }

            
        }

        public static void addgatekeeper(Cgatek gatekeeper)
        {
            availableGatekeepers.Add(gatekeeper);
        }
       
        public static bool isGatekeeper(string username, string password)
        {
            bool isfound = false;
            foreach (Cgatek gateKeeper in gatekDL.availableGatekeepers)
            {
                if (gateKeeper.Name == username && gateKeeper.Password == password)
                {
                    isfound = true;
                    myutilGateKeeper.logingatkeeper = gateKeeper;
                    return isfound;
                }
            }
            foreach (Cgatek gateKeeper in gatekDL.allotedGatekeepers)
            {
                if (gateKeeper.Name == username && gateKeeper.Password == password)
                {
                    isfound = true;
                    myutilGateKeeper.logingatkeeper = gateKeeper;
                    return isfound;
                }
            }
            return isfound;

        }
        public static bool resetGatePass(string name, string question, string answer, string newPassword)
        {
            bool isfound = false;
            foreach (Cgatek ad in gatekDL.availableGatekeepers)
            {
                if (ad.Name == name && ad.Question == question && ad.Answer == answer)
                {
                    isfound = true;
                    ad.Password = newPassword;
                }
            }
            return isfound;
        }
    }
}