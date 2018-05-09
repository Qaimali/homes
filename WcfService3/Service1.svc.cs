using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void registerStudent(string username, string password, string question, string answer)
        {
            Cstudent student = new Cstudent();
            student.Userid = username;
            student.Password = password;
            student.Question = question;
            student.Answer = answer;
            Cnotification notifications = new Cnotification();
            notifications.Notification = "You are registered in HOMES now.You will notified soon on Room Alootment if there is vacancy" ;
            student.notificationaddtion(notifications);
            studentDL.addstudent(student);
        }

        public void registerGatekeeper(string username, string password, string question, string answer)
        {
            Cgatek gatekeeper = new Cgatek();
            gatekeeper.Name = username;
            gatekeeper.Password = password;
            gatekeeper.Question = question;
            gatekeeper.Answer = answer;
            Cnotification notifications = new Cnotification();
            notifications.Notification = "You are registered in 'HOMES'.You will be notified if there vacancy in HOMES";
            gatekeeper.notificationaddtion(notifications);
            gatekDL.addgatekeeper(gatekeeper);
        }

        public void registerRt(string username, string password, string question, string answer)
        {
            CRT Rt = new CRT();
            Rt.Name = username;
            Rt.Password = password;
            Rt.Question = question;
            Rt.Answer = answer;
            Cnotification notifications = new Cnotification();
            notifications.Notification = "You are registered in 'HOMES'.You will be notified if there vacancy in HOMES" ;
            Rt.notificationaddtion(notifications);
            rtDL.addRT(Rt);
        }

        public void registerAdmin(string username, string password, string question, string answer)
        {
            Cadmin admin = new Cadmin();
            admin.Adminname = username;
            admin.Password = password;
            admin.Question = question;
            admin.Answer = answer;
            adminDL.addadmin(admin);
        }

        public bool AdminLogin(string username, string password)
        {
            adminDL admin = new adminDL();
            if (adminDL.isAdmin(username, password))
            {
                return true;
            }
            return false;
        }

        public bool StudentLogin(string username, string password)
        {
            
            if (studentDL.isStudent(username, password))
            {
                
                return true;
            }
            return false;

        }

        public bool LoginRT(string username, string password)
        {
           
            if (rtDL.isRT(username, password))
            {
                
                return true;
            }
            return false;

        }

        public bool GatekeeperLogin(string username, string password)
        {
            
            if (gatekDL.isGatekeeper(username, password))
            {
                
                return true;
            }
            return false;
        }

        public bool changeAdminPassword(string name, string question, string answer, string newPassword)
        {
            
            if (adminDL.resetAdminPassword(name, question, answer, newPassword))
            {
                return true;
            }
            return false;
        }

        public bool changeGateKeeperPassword(string name, string qusestion, string answer, string newPassword)
        {
            
            if (gatekDL.resetGatePass(name, qusestion, answer, newPassword))
            {
                return true;
            }
            return false;
        }
        public bool changeStudentPassword(string name1, string question1, string answer1, string newpassword)
        {
           
            if (studentDL.resetStudentPass(name1, question1, answer1, newpassword))
            {
                return true;
            }
            return false;
        }
        public bool canresetrt(string name, string question, string answer, string newpasssword)
        {
            
            if (rtDL.resetRtPass(name, question, answer, newpasssword))
            {
                return true;
            }
            return false;
        }
        
        public Cstudent loggedstudent()
        {
            return myutilStudent.loginstudents;
        }
        public CRT loggedRt()
        {
            return myutilRT.loginRT;
        }
        public Cgatek logged_Gatekeeper()
        {
            return myutilGateKeeper.logingatkeeper;
        }
        public void addhostel(string hostelName, int roomCapcity, int numberofRooms, string RT, string gateKeeperist)
        {
            Hostel hostelO = new Hostel();
            hostelO.HostelName = hostelName;
            for (int i = 1; i <= numberofRooms; i++)
            {
                room roomO = new room();
                roomO.Roomnumber = i;
                roomO.Allotees = 0;
                roomO.Capacity = roomCapcity;
                hostelO.Roomlist.Add(roomO);
            }
            
            foreach (CRT Rt in rtDL.availableRT)
            {
                if ( Rt.Name == RT)
                {
                    Cnotification notificationO = new Cnotification();
                    notificationO.Notification = "Mr.you are alloted to take your positions";
                    Rt.AllotedHostel = hostelO.HostelName;
                    Rt.Notificationlist.Add(notificationO);
                    rtDL.allotedtRT.Add(Rt);
                  
                    hostelO.RtList.Add(Rt);
                }
            }
            rtDL.deleteRegisteredRt(RT);
            
            foreach (Cgatek gateKeeper in gatekDL.availableGatekeepers)
            {
                if (gateKeeper.Name == gateKeeperist )
                {
                    Cnotification notificationO = new Cnotification();
                    notificationO.Notification = "Mr.you are alloted to" + hostelO.HostelName + " take your positions";
                    gateKeeper.AllotedHostel = hostelO.HostelName;
                    gateKeeper.Notificationlist.Add(notificationO);
                    gatekDL.allotedGatekeepers.Add(gateKeeper);
                    hostelO.GatekeeperList.Add(gateKeeper);
                }
            }
            gatekDL.deleteRegisteredGateKeeper(gateKeeperist);
            hostelDL.addhostel(hostelO);
        }

        public Hostel hostelIndex(int index)
        {
            return hostelDL.hostellist[index];
        }

        public List<CRT> listOfavailableRT()
        {
            return rtDL.availableRT;
        }

        public List<Cgatek> listOfavailableGateKeeper()
        {
            return gatekDL.availableGatekeepers;
        }
              
        public List<Hostel> listOfAllHostel()
        {
            return hostelDL.hostellist;
        }

        public void registerForHostel(Cstudent student)
        { 
            studentDL.getHostelRegistration(student);
        }

        public bool isHostelRegistered(String name)
        {
            bool isfound = false;
            foreach (Cstudent student in studentDL.hostelRegistration)
            {
                if (student.Userid == name)
                {
                    isfound = true;
                    return isfound;
                }
            }
            foreach(Cstudent student in studentDL.allotedstudents)
            {
                if (student.Userid == name)
                {
                    isfound = true;
                    return isfound;
                }
            }
            return isfound;
        }

        public List<Cstudent> listOfRegisteredStudent()
        {
            return studentDL.hostelRegistration;
        }

        public Cstudent registeredStudentIndex(int index)
        {
            return studentDL.hostelRegistration[index];
        }

        public List<Cstudent> listOfAllotedStudent()
        {
            return studentDL.allotedstudents;
        }

        public void allotStudent(Cstudent student)
        {
            studentDL.allotment(student);
        }

        public void addnotificationforStudent(string name, string registrationNumber, string notification)
        {
            Cnotification notifictionO = new Cnotification();
            notifictionO.Notification = notification;
            foreach (Cstudent studentO in studentDL.allotedstudents)
            {
                if (studentO.Name == name && studentO.RegistrationNumber == registrationNumber)
                {
                    studentO.notificationaddtion(notifictionO);
                }
            }
        }
        public void addNotificationForRt(string name,string hostel,string notifications)
        {
            Cnotification notificationO = new Cnotification();
            notificationO.Notification = notifications;
            foreach(CRT rtO in rtDL.allotedtRT)
            {
                if(rtO.AllotedHostel==hostel && rtO.Name == name)
                {
                    rtO.Notificationlist.Add(notificationO);
                }
            }
        }

        public void deletePendingStudent(Cstudent studentP)
        {
            int indexForDelete=0;
           foreach(Cstudent studentO in studentDL.hostelRegistration)
           {
                if(studentO.Userid == studentP.Userid && studentO.RegistrationNumber == studentP.RegistrationNumber)
                {
                    indexForDelete = studentDL.hostelRegistration.IndexOf(studentO);
                    break;
                }
           }
            studentDL.hostelRegistration.RemoveAt(indexForDelete);
        }

        public bool student_checkin(string name, string registrationNumber, string roomNumber, string checkin_date)
        {
            
            
            if (studentDL.checkInS(name, registrationNumber, roomNumber, checkin_date))
            {
                return true;
            }
            return false;
        }
        public bool student_checkOut(string name, string registrationNumber, string roomNumber, string checkOut_date)
        {
            
            if (studentDL.checkOutS(name, registrationNumber, roomNumber, checkOut_date))
            {
                return true;
            }
            return false;
        }
        public Cstudent indexForAllottedStudent(int index)
        {
            return studentDL.allotedstudents[index];
        }
        public bool visitor_checkIn(string registrationNumberOfHost, string visitor_name, string visitor_cnic, string checkin)
        {
            
            
            if (studentDL.CheckInVisitor(registrationNumberOfHost, visitor_name, checkin, visitor_cnic))
            {
                return true;
            }
            return false;
        }
        public bool visitor_checkOut(string registrationNumberOfHost, string visitor_name, string visitor_cnic, string checkout)
        {
            CDate c = new CDate();
            c.Date = checkout;
            
            if (studentDL.CheckOutVisitor(registrationNumberOfHost, visitor_name, checkout, visitor_cnic))
            {
                return true;
            }
            return false;
        }

        public List<CRT> listOfallotedRT()
        {
            return rtDL.allotedtRT;
        }

        public void complaintsfromstudent(string name, string subject, string text, string HostelName,string registrationNumber,string roomNumber)
        {
            rtDL.addomplaintforRT(name, subject, text, HostelName,registrationNumber,roomNumber);
        }
        public void complaintsfromRT(string name, string subject, string ComplaintText, string hostelName)
        {
            adminDL.addcomplaintsforadmin(name, subject, ComplaintText, hostelName);
        }

        public List<Complaints> listOfComplainFromRt()
        {
            return adminDL.complaintsForAdmin;
        }

        public Complaints getIndexedComplaintsFromRt(int index)
        {
            return adminDL.complaintsForAdmin[index];
        }
        public void deleteComplaintsfromStudents(Complaints complaintsP)
        {
            int indexForDelete = 0;
            foreach(CRT rt in rtDL.allotedtRT)
            {
                if(rt.AllotedHostel== complaintsP.Residencyofperson)
                {
                    foreach(Complaints complaintO in rt.ComplaintsforRT)
                    {
                        if(complaintO.RegistrationNumber == complaintsP.RegistrationNumber && complaintO.Name== complaintsP.Name)
                        {
                            indexForDelete = rt.ComplaintsforRT.IndexOf(complaintO);
                            break;
                        }
                    }
                    rt.ComplaintsforRT.RemoveAt(indexForDelete);
                }
            }
        }

        public void deleteComplaintsfromRT(int index)
        {
            adminDL.complaintsForAdmin.RemoveAt(index);
        }

        public void deleteAllotedStudent(Cstudent studentP)
        {
            int indexForDelete = 0;
            foreach(Cstudent studentO in studentDL.allotedstudents)
            {
                if(studentO.RegistrationNumber == studentP.RegistrationNumber && studentO.Userid == studentP.Userid)
                {
                    indexForDelete = studentDL.allotedstudents.IndexOf(studentO);
                }
            }
            studentDL.allotedstudents.RemoveAt(indexForDelete);
        }

        public Hostel AddNewRT(Hostel hostelP,String rtP)
        {
            foreach(Hostel hostelO in hostelDL.hostellist)
            {
                if (hostelO.HostelName == hostelP.HostelName)
                {
                    foreach(CRT rtO in rtDL.availableRT)
                    {
                        if(rtO.Name == rtP)
                        {
                            hostelO.RtList.Add(rtO);
                            Cnotification notificationO = new Cnotification();
                            notificationO.Notification = "Mr.you are alloted to take your positions";
                            rtO.AllotedHostel = hostelO.HostelName;
                            rtO.Notificationlist.Add(notificationO);
                            rtDL.allotedtRT.Add(rtO);
                            break;
                        }
                    }
                    rtDL.deleteRegisteredRt(rtP);
                    return hostelO;
                   
                }
            }
            return null;
            
        }
        public Hostel AddNewGateKeeper(Hostel hostelP,string GateKeeperP)
        {
            foreach (Hostel hostelO in hostelDL.hostellist)
            {
                if (hostelO.HostelName == hostelP.HostelName)
                {
                    foreach (Cgatek gateKeeperO in gatekDL.availableGatekeepers)
                    {
                        if (gateKeeperO.Name==GateKeeperP)
                        {
                            hostelO.GatekeeperList.Add(gateKeeperO);
                            Cnotification notificationO = new Cnotification();
                            notificationO.Notification = "Mr.you are alloted to"+hostelO.HostelName+" take your positions";
                            gateKeeperO.Notificationlist.Add(notificationO);
                            gatekDL.allotedGatekeepers.Add(gateKeeperO);
                            break;
                        }
                    }
                    gatekDL.deleteRegisteredGateKeeper(GateKeeperP);
                    return hostelO;
                }
            }
            return null;
        }
        public bool uniqueStudentid(String id)
        {
            foreach(Cstudent studentO in studentDL.stdList)
            {
                if(studentO.Userid == id)
                {
                    return false;
                }
            }
            return true;
        }
    }   
}

