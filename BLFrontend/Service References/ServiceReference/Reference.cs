﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLFrontend.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IBLBackend")]
    public interface IBLBackend {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBLBackend/GetShagrirs", ReplyAction="http://tempuri.org/IBLBackend/GetShagrirsResponse")]
        System.Collections.Generic.List<BE.Shagrir> GetShagrirs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBLBackend/GetShagrirs", ReplyAction="http://tempuri.org/IBLBackend/GetShagrirsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BE.Shagrir>> GetShagrirsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBLBackend/AddShagrir", ReplyAction="http://tempuri.org/IBLBackend/AddShagrirResponse")]
        bool AddShagrir(BE.Shagrir shagrirToAdd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBLBackend/AddShagrir", ReplyAction="http://tempuri.org/IBLBackend/AddShagrirResponse")]
        System.Threading.Tasks.Task<bool> AddShagrirAsync(BE.Shagrir shagrirToAdd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBLBackendChannel : BLFrontend.ServiceReference.IBLBackend, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BLBackendClient : System.ServiceModel.ClientBase<BLFrontend.ServiceReference.IBLBackend>, BLFrontend.ServiceReference.IBLBackend {
        
        public BLBackendClient() {
        }
        
        public BLBackendClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BLBackendClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BLBackendClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BLBackendClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<BE.Shagrir> GetShagrirs() {
            return base.Channel.GetShagrirs();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BE.Shagrir>> GetShagrirsAsync() {
            return base.Channel.GetShagrirsAsync();
        }
        
        public bool AddShagrir(BE.Shagrir shagrirToAdd) {
            return base.Channel.AddShagrir(shagrirToAdd);
        }
        
        public System.Threading.Tasks.Task<bool> AddShagrirAsync(BE.Shagrir shagrirToAdd) {
            return base.Channel.AddShagrirAsync(shagrirToAdd);
        }
    }
}