﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace intcom.web.CloudServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CloudServices.IServices")]
    public interface IServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/setAccessCondition", ReplyAction="http://tempuri.org/IServices/setAccessConditionResponse")]
        void setAccessCondition(long filesize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/setAccessCondition", ReplyAction="http://tempuri.org/IServices/setAccessConditionResponse")]
        System.Threading.Tasks.Task setAccessConditionAsync(long filesize);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/ulpload", ReplyAction="http://tempuri.org/IServices/ulploadResponse")]
        void ulpload(string[] files);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/ulpload", ReplyAction="http://tempuri.org/IServices/ulploadResponse")]
        System.Threading.Tasks.Task ulploadAsync(string[] files);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/download", ReplyAction="http://tempuri.org/IServices/downloadResponse")]
        void download(string key, string destination);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/download", ReplyAction="http://tempuri.org/IServices/downloadResponse")]
        System.Threading.Tasks.Task downloadAsync(string key, string destination);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/getAll", ReplyAction="http://tempuri.org/IServices/getAllResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(string[]))]
        object getAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServices/getAll", ReplyAction="http://tempuri.org/IServices/getAllResponse")]
        System.Threading.Tasks.Task<object> getAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicesChannel : intcom.web.CloudServices.IServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicesClient : System.ServiceModel.ClientBase<intcom.web.CloudServices.IServices>, intcom.web.CloudServices.IServices {
        
        public ServicesClient() {
        }
        
        public ServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void setAccessCondition(long filesize) {
            base.Channel.setAccessCondition(filesize);
        }
        
        public System.Threading.Tasks.Task setAccessConditionAsync(long filesize) {
            return base.Channel.setAccessConditionAsync(filesize);
        }
        
        public void ulpload(string[] files) {
            base.Channel.ulpload(files);
        }
        
        public System.Threading.Tasks.Task ulploadAsync(string[] files) {
            return base.Channel.ulploadAsync(files);
        }
        
        public void download(string key, string destination) {
            base.Channel.download(key, destination);
        }
        
        public System.Threading.Tasks.Task downloadAsync(string key, string destination) {
            return base.Channel.downloadAsync(key, destination);
        }
        
        public object getAll() {
            return base.Channel.getAll();
        }
        
        public System.Threading.Tasks.Task<object> getAllAsync() {
            return base.Channel.getAllAsync();
        }
    }
}
