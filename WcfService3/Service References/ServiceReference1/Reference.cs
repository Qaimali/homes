﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService3.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addst", ReplyAction="http://tempuri.org/IService1/addstResponse")]
        void addst(string username, string password, string question, string answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addst", ReplyAction="http://tempuri.org/IService1/addstResponse")]
        System.Threading.Tasks.Task addstAsync(string username, string password, string question, string answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addgk", ReplyAction="http://tempuri.org/IService1/addgkResponse")]
        void addgk(string username, string password, string question, string answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addgk", ReplyAction="http://tempuri.org/IService1/addgkResponse")]
        System.Threading.Tasks.Task addgkAsync(string username, string password, string question, string answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addrt", ReplyAction="http://tempuri.org/IService1/addrtResponse")]
        void addrt(string username, string password, string question, string answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addrt", ReplyAction="http://tempuri.org/IService1/addrtResponse")]
        System.Threading.Tasks.Task addrtAsync(string username, string password, string question, string answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addadmin", ReplyAction="http://tempuri.org/IService1/addadminResponse")]
        void addadmin(string username, string password, string question, string answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/addadmin", ReplyAction="http://tempuri.org/IService1/addadminResponse")]
        System.Threading.Tasks.Task addadminAsync(string username, string password, string question, string answer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WcfService3.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WcfService3.ServiceReference1.IService1>, WcfService3.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void addst(string username, string password, string question, string answer) {
            base.Channel.addst(username, password, question, answer);
        }
        
        public System.Threading.Tasks.Task addstAsync(string username, string password, string question, string answer) {
            return base.Channel.addstAsync(username, password, question, answer);
        }
        
        public void addgk(string username, string password, string question, string answer) {
            base.Channel.addgk(username, password, question, answer);
        }
        
        public System.Threading.Tasks.Task addgkAsync(string username, string password, string question, string answer) {
            return base.Channel.addgkAsync(username, password, question, answer);
        }
        
        public void addrt(string username, string password, string question, string answer) {
            base.Channel.addrt(username, password, question, answer);
        }
        
        public System.Threading.Tasks.Task addrtAsync(string username, string password, string question, string answer) {
            return base.Channel.addrtAsync(username, password, question, answer);
        }
        
        public void addadmin(string username, string password, string question, string answer) {
            base.Channel.addadmin(username, password, question, answer);
        }
        
        public System.Threading.Tasks.Task addadminAsync(string username, string password, string question, string answer) {
            return base.Channel.addadminAsync(username, password, question, answer);
        }
    }
}
