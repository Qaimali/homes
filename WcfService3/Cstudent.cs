using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WcfService3
{
    [DataContract]
    public class Cstudent
    {
        //attributes of student
        String userid;
        [DataMember]
        public String Userid
        {
            get { return userid; }
            set { userid = value; }
        }
        String hostelName;
        String name;
        String gender;
        String phoneNumber;
        String registrationNumber;
        String fatherName;
        String guardianName;
        String bloodGroup;
        String address;
        String roomNumber;
        String fatherNumber;
        String guardianNumber;
        String password;
        List<CDate> student_checkin =new List<CDate>();
        List<CDate> student_checkout=new List<CDate>();
        List<Cvisistor> visitors = new List<Cvisistor>();
        
        bool checkIn = false;
        [DataMember]
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        String question;
        [DataMember]
        public String Question
        {
            get { return question; }
            set { question = value; }
        }
        String answer;
        [DataMember]
        public String Answer
        {
            get { return answer; }
            set { answer = value; }
        }
        
       [DataMember]
        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }
        [DataMember]
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }
        [DataMember]
        public string RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }

            set
            {
                registrationNumber = value;
            }
        }
        [DataMember]
        public string FatherName
        {
            get
            {
                return fatherName;
            }

            set
            {
                fatherName = value;
            }
        }
        [DataMember]
        public string GuardianName
        {
            get
            {
                return guardianName;
            }

            set
            {
                guardianName = value;
            }
        }
        [DataMember]
        public string BloodGroup
        {
            get
            {
                return bloodGroup;
            }

            set
            {
                bloodGroup = value;
            }
        }
        [DataMember]
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }
        [DataMember]
        public string RoomNumber
        {
            get
            {
                return roomNumber;
            }

            set
            {
                roomNumber = value;
            }
        }
        [DataMember]
        public string FatherNumber
        {
            get
            {
                return fatherNumber;
            }

            set
            {
                fatherNumber = value;
            }
        }
        [DataMember]
        public string GuardianNumber
        {
            get
            {
                return guardianNumber;
            }

            set
            {
                guardianNumber = value;
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
        [DataMember]
        public string HostelName
        {
            get
            {
                return hostelName;
            }

            set
            {
                hostelName = value;
            }
        }
        
        
        [DataMember]
        public List<CDate> Student_checkout
        {
            get
            {
                return student_checkout;
            }

            set
            {
                student_checkout = value;
            }
        }
        
        List<Cnotification> notificationlist = new List<Cnotification>();
        [DataMember]

        public List<Cnotification> Notificationlist
        {
            get { return notificationlist; }
            set { notificationlist = value; }
        }

        public void notificationaddtion(Cnotification n)
        {
            if (Notificationlist == null)
            {
                Notificationlist = new List<Cnotification>();
            }
            Notificationlist.Add(n);
        }
        [DataMember]

        public List<Cvisistor> Visitors
        {
            get{ return visitors;}
            set{ visitors = value; }
        }

        public void addvisitors(Cvisistor c)
        {
            if (Visitors == null)
            {
                Visitors = new List<Cvisistor>();
            }
            visitors.Add(c);
        }
        [DataMember]
        

        public List<CDate> Student_checkin
        {
            get
            {
                return student_checkin;
            }

            set
            {
                student_checkin = value;
            }
        }
        [DataMember]
        public bool CheckIn
        {
            get
            {
                return checkIn;
            }

            set
            {
                checkIn = value;
            }
        }
    }
}