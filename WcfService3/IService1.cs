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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void regst(string username, string password, string question, string answer);//student signup

        [OperationContract]
        void reggk(string username, string password, string question, string answer);//gatekeeper signup

        [OperationContract]
        void regrt(string username, string password, string question, string answer);//RT signup

        [OperationContract]
        void regadmin(string username, string password, string question, string answer);//Admin Signup

        [OperationContract]
        bool isAdmin(string username, string password);//login of admin

        [OperationContract]
        bool isStudent(string username, string password);//login of student

        [OperationContract]
        bool isRT(string username, string password);//login of RT

        [OperationContract]
        bool isGatekeeper(string username, string password);//login of Gatekkeper

        [OperationContract]

        bool canresetAdmin(string n1,string q1,string a1,string pass);//change Password of admin

        [OperationContract]

        bool canresetgatekeeper(string n1, string q1, string a1, string pass);//change Password of Gatekeeper

        [OperationContract]

        bool canresetstudent(string n1, string q1, string a1, string pass);//change Password of Student

        [OperationContract]

        bool canresetrt(string n1, string q1, string a1, string pass);//change Password of RT

        [OperationContract]

        List<Cnotification> mutateStNotification();//Getter of Student Notifiction

        [OperationContract]

        Cstudent loggedstudent();//student which is logged in

        [OperationContract]

        List<Cnotification> mutateRtNotifications();//Getter of RT Notifiction

        [OperationContract]

        CRT loggedRt();//RT which is logged in

        [OperationContract]

        List<Cnotification> mutateGKNotifications();//Getter of GateKeeper Notifiction

        [OperationContract]

        Cgatek logged_Gatekeeper();//RT which is logged in

        [OperationContract]

        void addhostel(string hostname, int roomcapcity, int nuofrooms, string r1, string r2, string g1, string g2);//Adding hostel

        [OperationContract]

        ArrayList rtnames();//get the names of registered RT for Add hostel 

        [OperationContract]

        Hostel hostels(int index);//get hostel object of given index from hostels list

        [OperationContract]

        ArrayList gknames();////get the names of registered Gatekeeper for Add hostel 

        [OperationContract]

        List<Hostel> showallhostel();//get list of hostel

        [OperationContract]

        void registerforhostel(Cstudent s);//hostel form submission

        [OperationContract]

        bool isHostelRegistered(String name);//check that if student has filled his form and registered for hostel

        [OperationContract]

        List<Cstudent> registeredstudent();//list of registerd student that filled the hostel registration form

        [OperationContract]

        Cstudent getregisteredstudent(int index);////get student object of given index from hostel registered students list

        [OperationContract]

        List<Cstudent> allotedStudentsforhostel();//get list of studnets that is alloted for homes

        [OperationContract]

        Cstudent indexForAllottedStudent(int index);//get alloted student  object of given index from alloted student list

        [OperationContract]

        void allotstudent(Cstudent std);// allot student 

        [OperationContract]

        void addnotificationforsearch(string name, string regno, string not);// add notifcation for student whose registion number is "regno" and NAME is"name"

        [OperationContract]

        void deletependingst(Cstudent st);//delete student from registerd students list 

        [OperationContract]

        bool student_checkin(string name, string regNo, string roomNo, String checkin_date);

        [OperationContract]

        bool student_checkOut(string name, string regNo, string roomNo, DateTime checkOut_date);

        [OperationContract]

        bool visitor_checkIn(string host, string hostregno, string visitor_name, string visitor_cnic, DateTime checkin,string room_number);

        [OperationContract]

        bool visitor_checkOut(string host, string hostregno, string visitor_name, string visitor_cnic, DateTime checkout, string room_number);

        [OperationContract]

        List<CRT> allotedRT();

        [OperationContract]

        void complaintsfromstudent(string n1, string s1, string t1, string r1);

        
    }
}
