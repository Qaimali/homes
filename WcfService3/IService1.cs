﻿using System;
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
        void registerStudent(string username, string password, string question, string answer);//student signup

        [OperationContract]
        void registerGatekeeper(string username, string password, string question, string answer);//gatekeeper signup

        [OperationContract]
        void registerRt(string username, string password, string question, string answer);//RT signup

        [OperationContract]
        void registerAdmin(string username, string password, string question, string answer);//Admin Signup

        [OperationContract]
        bool AdminLogin(string username, string password);//login of admin

        [OperationContract]
        bool StudentLogin(string username, string password);//login of student

        [OperationContract]
        bool LoginRT(string username, string password);//login of RT

        [OperationContract]
        bool GatekeeperLogin(string username, string password);//login of Gatekkeper

        [OperationContract]

        bool changeAdminPassword(string n1,string q1,string a1,string pass);//change Password of admin

        [OperationContract]

        bool changeGateKeeperPassword(string n1, string q1, string a1, string pass);//change Password of Gatekeeper

        [OperationContract]

        bool changeStudentPassword(string n1, string q1, string a1, string pass);//change Password of Student

        [OperationContract]

        bool canresetrt(string n1, string q1, string a1, string pass);//change Password of RT

        [OperationContract]

        Cstudent loggedstudent();//student which is logged in

        [OperationContract]

        CRT loggedRt();//RT which is logged in

        [OperationContract]

        Cgatek logged_Gatekeeper();//RT which is logged in

        [OperationContract]

        List<CRT> listOfavailableRT();

        [OperationContract]

        List<Cgatek> listOfavailableGateKeeper();

        [OperationContract]

        void addhostel(string hostelName, int roomCapcity, int numberofRooms, string RT, string gateKeeperist);//Adding hostel

        [OperationContract]

        Hostel hostelIndex(int index);//get hostel object of given index from hostels list

        [OperationContract]

        List<Hostel> listOfAllHostel();//get list of hostel

        [OperationContract]

        void registerForHostel(Cstudent s);//hostel form submission

        [OperationContract]

        bool isHostelRegistered(String name);//check that if student has filled his form and registered for hostel

        [OperationContract]

        List<Cstudent> listOfRegisteredStudent();//list of registerd student that filled the hostel registration form

        [OperationContract]

        Cstudent registeredStudentIndex(int index);////get student object of given index from hostel registered students list

        [OperationContract]

        List<Cstudent> listOfAllotedStudent();//get list of studnets that is alloted for homes

        [OperationContract]

        Cstudent indexForAllottedStudent(int index);//get alloted student  object of given index from alloted student list

        [OperationContract]

        void allotStudent(Cstudent std);// allot student 

        [OperationContract]

        void addnotificationforStudent(string name, string regno, string not);// add notifcation for student whose registion number is "regno" and NAME is"name"

        [OperationContract]

        void deletePendingStudent(Cstudent st);//delete student from registerd students list 

        [OperationContract]

        bool student_checkin(string name, string regNo, string roomNo, string checkin_date);

        [OperationContract]

        bool student_checkOut(string name, string regNo, string roomNo, string checkOut_date);

        [OperationContract]

        bool visitor_checkIn(string hostregno, string visitor_name, string visitor_cnic, string checkin);

        [OperationContract]

        bool visitor_checkOut(string hostregno, string visitor_name, string visitor_cnic, string checkout);

        [OperationContract]

        List<CRT> listOfallotedRT();

        [OperationContract]

        void complaintsfromstudent(string n1, string s1, string t1, string r1, string regNum, string roomNu);

        [OperationContract]

        void complaintsfromRT(string n1, string s1, string t1, string r1);

        [OperationContract]

        List<Complaints> listOfComplainFromRt();

        [OperationContract]

        Complaints getIndexedComplaintsFromRt(int index);

        [OperationContract]

        void addNotificationForRt(string name, string hostel, string not);

        [OperationContract]

        void deleteComplaintsfromStudents(Complaints comp);

        [OperationContract]

        void deleteComplaintsfromRT(int index);

        [OperationContract]

        void deleteAllotedStudent(Cstudent s);

        [OperationContract]

        Hostel AddNewRT(Hostel hostelP, String rtP);

        [OperationContract]

        Hostel AddNewGateKeeper(Hostel hostelP, string GateKeeperP);

        [OperationContract]

        bool uniqueStudentid(String id);

    }
}
