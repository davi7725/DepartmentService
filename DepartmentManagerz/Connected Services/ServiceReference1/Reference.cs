﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DepartmentManagerz.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetItemCount", ReplyAction="http://tempuri.org/IService1/GetItemCountResponse")]
        int GetItemCount();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetItemCount", ReplyAction="http://tempuri.org/IService1/GetItemCountResponse")]
        System.Threading.Tasks.Task<int> GetItemCountAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddItem", ReplyAction="http://tempuri.org/IService1/AddItemResponse")]
        void AddItem(string itemName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddItem", ReplyAction="http://tempuri.org/IService1/AddItemResponse")]
        System.Threading.Tasks.Task AddItemAsync(string itemName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : DepartmentManagerz.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<DepartmentManagerz.ServiceReference1.IService1>, DepartmentManagerz.ServiceReference1.IService1 {
        
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
        
        public int GetItemCount() {
            return base.Channel.GetItemCount();
        }
        
        public System.Threading.Tasks.Task<int> GetItemCountAsync() {
            return base.Channel.GetItemCountAsync();
        }
        
        public void AddItem(string itemName) {
            base.Channel.AddItem(itemName);
        }
        
        public System.Threading.Tasks.Task AddItemAsync(string itemName) {
            return base.Channel.AddItemAsync(itemName);
        }
    }
}