﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeBreakWebApp.CBService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:55675/", ConfigurationName="CBService.CoffeeBreakServiceSoap")]
    public interface CoffeeBreakServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:55675/UpdateMessage", ReplyAction="*")]
        void UpdateMessage();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:55675/UpdateMessage", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateMessageAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CoffeeBreakServiceSoapChannel : CoffeeBreakWebApp.CBService.CoffeeBreakServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CoffeeBreakServiceSoapClient : System.ServiceModel.ClientBase<CoffeeBreakWebApp.CBService.CoffeeBreakServiceSoap>, CoffeeBreakWebApp.CBService.CoffeeBreakServiceSoap {
        
        public CoffeeBreakServiceSoapClient() {
        }
        
        public CoffeeBreakServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CoffeeBreakServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CoffeeBreakServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CoffeeBreakServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void UpdateMessage() {
            base.Channel.UpdateMessage();
        }
        
        public System.Threading.Tasks.Task UpdateMessageAsync() {
            return base.Channel.UpdateMessageAsync();
        }
    }
}
