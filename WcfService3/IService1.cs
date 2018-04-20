using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void regst(string username, string password, string question, string answer);
        [OperationContract]
        void reggk(string username, string password, string question, string answer);
        [OperationContract]
        void regrt(string username, string password, string question, string answer);
        [OperationContract]
        void regadmin(string username, string password, string question, string answer);
        [OperationContract]
        bool isAdmin(string username, string password);
        [OperationContract]
        bool isStudent(string username, string password);
        [OperationContract]
        bool isRT(string username, string password);
        [OperationContract]
        bool isGatekeeper(string username, string password);

    }



}
