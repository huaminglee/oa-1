﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.269
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMT.SaaS.BLLCommonServices.GSCommonWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GSCommonWS.GSCommonServices")]
    public interface GSCommonServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GSCommonServices/UpdateCheckState", ReplyAction="http://tempuri.org/GSCommonServices/UpdateCheckStateResponse")]
        int UpdateCheckState(string strModelCode, string orderID, string strCheckStates, ref string strMsg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GSCommonServicesChannel : SMT.SaaS.BLLCommonServices.GSCommonWS.GSCommonServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GSCommonServicesClient : System.ServiceModel.ClientBase<SMT.SaaS.BLLCommonServices.GSCommonWS.GSCommonServices>, SMT.SaaS.BLLCommonServices.GSCommonWS.GSCommonServices {
        
        public GSCommonServicesClient() {
        }
        
        public GSCommonServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GSCommonServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GSCommonServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GSCommonServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int UpdateCheckState(string strModelCode, string orderID, string strCheckStates, ref string strMsg) {
            return base.Channel.UpdateCheckState(strModelCode, orderID, strCheckStates, ref strMsg);
        }
    }
}
