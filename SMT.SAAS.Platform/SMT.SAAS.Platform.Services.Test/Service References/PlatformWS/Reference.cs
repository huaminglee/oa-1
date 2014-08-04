﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMT.SAAS.Platform.Services.Test.PlatformWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ModuleInfo", Namespace="http://schemas.datacontract.org/2004/07/SMT.SAAS.Platform.Model")]
    [System.SerializableAttribute()]
    public partial class ModuleInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] DependsOnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnterAssemblyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FilePathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HostAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<string, string> InitParamsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IsSaveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModuleCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModuleIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModuleIconField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModuleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModuleTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ParentModuleIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServerIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SystemTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UseStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VersionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ClientID {
            get {
                return this.ClientIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientIDField, value) != true)) {
                    this.ClientIDField = value;
                    this.RaisePropertyChanged("ClientID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] DependsOn {
            get {
                return this.DependsOnField;
            }
            set {
                if ((object.ReferenceEquals(this.DependsOnField, value) != true)) {
                    this.DependsOnField = value;
                    this.RaisePropertyChanged("DependsOn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EnterAssembly {
            get {
                return this.EnterAssemblyField;
            }
            set {
                if ((object.ReferenceEquals(this.EnterAssemblyField, value) != true)) {
                    this.EnterAssemblyField = value;
                    this.RaisePropertyChanged("EnterAssembly");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName {
            get {
                return this.FileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FileNameField, value) != true)) {
                    this.FileNameField = value;
                    this.RaisePropertyChanged("FileName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FilePath {
            get {
                return this.FilePathField;
            }
            set {
                if ((object.ReferenceEquals(this.FilePathField, value) != true)) {
                    this.FilePathField = value;
                    this.RaisePropertyChanged("FilePath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HostAddress {
            get {
                return this.HostAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.HostAddressField, value) != true)) {
                    this.HostAddressField = value;
                    this.RaisePropertyChanged("HostAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<string, string> InitParams {
            get {
                return this.InitParamsField;
            }
            set {
                if ((object.ReferenceEquals(this.InitParamsField, value) != true)) {
                    this.InitParamsField = value;
                    this.RaisePropertyChanged("InitParams");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IsSave {
            get {
                return this.IsSaveField;
            }
            set {
                if ((object.ReferenceEquals(this.IsSaveField, value) != true)) {
                    this.IsSaveField = value;
                    this.RaisePropertyChanged("IsSave");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModuleCode {
            get {
                return this.ModuleCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ModuleCodeField, value) != true)) {
                    this.ModuleCodeField = value;
                    this.RaisePropertyChanged("ModuleCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModuleID {
            get {
                return this.ModuleIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ModuleIDField, value) != true)) {
                    this.ModuleIDField = value;
                    this.RaisePropertyChanged("ModuleID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModuleIcon {
            get {
                return this.ModuleIconField;
            }
            set {
                if ((object.ReferenceEquals(this.ModuleIconField, value) != true)) {
                    this.ModuleIconField = value;
                    this.RaisePropertyChanged("ModuleIcon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModuleName {
            get {
                return this.ModuleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ModuleNameField, value) != true)) {
                    this.ModuleNameField = value;
                    this.RaisePropertyChanged("ModuleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModuleType {
            get {
                return this.ModuleTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.ModuleTypeField, value) != true)) {
                    this.ModuleTypeField = value;
                    this.RaisePropertyChanged("ModuleType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ParentModuleID {
            get {
                return this.ParentModuleIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ParentModuleIDField, value) != true)) {
                    this.ParentModuleIDField = value;
                    this.RaisePropertyChanged("ParentModuleID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServerID {
            get {
                return this.ServerIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ServerIDField, value) != true)) {
                    this.ServerIDField = value;
                    this.RaisePropertyChanged("ServerID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SystemType {
            get {
                return this.SystemTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.SystemTypeField, value) != true)) {
                    this.SystemTypeField = value;
                    this.RaisePropertyChanged("SystemType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UseState {
            get {
                return this.UseStateField;
            }
            set {
                if ((object.ReferenceEquals(this.UseStateField, value) != true)) {
                    this.UseStateField = value;
                    this.RaisePropertyChanged("UseState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Version {
            get {
                return this.VersionField;
            }
            set {
                if ((object.ReferenceEquals(this.VersionField, value) != true)) {
                    this.VersionField = value;
                    this.RaisePropertyChanged("Version");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ShortCut", Namespace="http://schemas.datacontract.org/2004/07/SMT.SAAS.Platform.Model")]
    [System.SerializableAttribute()]
    public partial class ShortCut : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AssemplyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IconPathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IsSysNeedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModuleIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ParamsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShortCutIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserStateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AssemplyName {
            get {
                return this.AssemplyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AssemplyNameField, value) != true)) {
                    this.AssemplyNameField = value;
                    this.RaisePropertyChanged("AssemplyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IconPath {
            get {
                return this.IconPathField;
            }
            set {
                if ((object.ReferenceEquals(this.IconPathField, value) != true)) {
                    this.IconPathField = value;
                    this.RaisePropertyChanged("IconPath");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IsSysNeed {
            get {
                return this.IsSysNeedField;
            }
            set {
                if ((object.ReferenceEquals(this.IsSysNeedField, value) != true)) {
                    this.IsSysNeedField = value;
                    this.RaisePropertyChanged("IsSysNeed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ModuleID {
            get {
                return this.ModuleIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ModuleIDField, value) != true)) {
                    this.ModuleIDField = value;
                    this.RaisePropertyChanged("ModuleID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Params {
            get {
                return this.ParamsField;
            }
            set {
                if ((object.ReferenceEquals(this.ParamsField, value) != true)) {
                    this.ParamsField = value;
                    this.RaisePropertyChanged("Params");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShortCutID {
            get {
                return this.ShortCutIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ShortCutIDField, value) != true)) {
                    this.ShortCutIDField = value;
                    this.RaisePropertyChanged("ShortCutID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Titel {
            get {
                return this.TitelField;
            }
            set {
                if ((object.ReferenceEquals(this.TitelField, value) != true)) {
                    this.TitelField = value;
                    this.RaisePropertyChanged("Titel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserState {
            get {
                return this.UserStateField;
            }
            set {
                if ((object.ReferenceEquals(this.UserStateField, value) != true)) {
                    this.UserStateField = value;
                    this.RaisePropertyChanged("UserState");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PlatformWS.IPlatformServices")]
    public interface IPlatformServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlatformServices/AddModule", ReplyAction="http://tempuri.org/IPlatformServices/AddModuleResponse")]
        bool AddModule(SMT.SAAS.Platform.Services.Test.PlatformWS.ModuleInfo model);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlatformServices/GetModuleByCodes", ReplyAction="http://tempuri.org/IPlatformServices/GetModuleByCodesResponse")]
        SMT.SAAS.Platform.Services.Test.PlatformWS.ModuleInfo[] GetModuleByCodes(string[] moduleCodes);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlatformServices/GetModuleFileStream", ReplyAction="http://tempuri.org/IPlatformServices/GetModuleFileStreamResponse")]
        byte[] GetModuleFileStream(string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlatformServices/AddModuleByFile", ReplyAction="http://tempuri.org/IPlatformServices/AddModuleByFileResponse")]
        bool AddModuleByFile(SMT.SAAS.Platform.Services.Test.PlatformWS.ModuleInfo model, byte[] xapFileStream);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlatformServices/GetModuleCatalogByUser", ReplyAction="http://tempuri.org/IPlatformServices/GetModuleCatalogByUserResponse")]
        SMT.SAAS.Platform.Services.Test.PlatformWS.ModuleInfo[] GetModuleCatalogByUser(string userSysID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlatformServices/GetShortCutByUser", ReplyAction="http://tempuri.org/IPlatformServices/GetShortCutByUserResponse")]
        SMT.SAAS.Platform.Services.Test.PlatformWS.ShortCut[] GetShortCutByUser(string userSysID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlatformServices/AddShortCutByUser", ReplyAction="http://tempuri.org/IPlatformServices/AddShortCutByUserResponse")]
        bool AddShortCutByUser(SMT.SAAS.Platform.Services.Test.PlatformWS.ShortCut[] models, string userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlatformServices/RemoveShortCutByUser", ReplyAction="http://tempuri.org/IPlatformServices/RemoveShortCutByUserResponse")]
        bool RemoveShortCutByUser(string shortCutID, string userID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPlatformServices/GetTaskConfigInfoByUser", ReplyAction="http://tempuri.org/IPlatformServices/GetTaskConfigInfoByUserResponse")]
        SMT.SAAS.Platform.Services.Test.PlatformWS.ModuleInfo[] GetTaskConfigInfoByUser(string userID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPlatformServicesChannel : SMT.SAAS.Platform.Services.Test.PlatformWS.IPlatformServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PlatformServicesClient : System.ServiceModel.ClientBase<SMT.SAAS.Platform.Services.Test.PlatformWS.IPlatformServices>, SMT.SAAS.Platform.Services.Test.PlatformWS.IPlatformServices {
        
        public PlatformServicesClient() {
        }
        
        public PlatformServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PlatformServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PlatformServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PlatformServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddModule(SMT.SAAS.Platform.Services.Test.PlatformWS.ModuleInfo model) {
            return base.Channel.AddModule(model);
        }
        
        public SMT.SAAS.Platform.Services.Test.PlatformWS.ModuleInfo[] GetModuleByCodes(string[] moduleCodes) {
            return base.Channel.GetModuleByCodes(moduleCodes);
        }
        
        public byte[] GetModuleFileStream(string fileName) {
            return base.Channel.GetModuleFileStream(fileName);
        }
        
        public bool AddModuleByFile(SMT.SAAS.Platform.Services.Test.PlatformWS.ModuleInfo model, byte[] xapFileStream) {
            return base.Channel.AddModuleByFile(model, xapFileStream);
        }
        
        public SMT.SAAS.Platform.Services.Test.PlatformWS.ModuleInfo[] GetModuleCatalogByUser(string userSysID) {
            return base.Channel.GetModuleCatalogByUser(userSysID);
        }
        
        public SMT.SAAS.Platform.Services.Test.PlatformWS.ShortCut[] GetShortCutByUser(string userSysID) {
            return base.Channel.GetShortCutByUser(userSysID);
        }
        
        public bool AddShortCutByUser(SMT.SAAS.Platform.Services.Test.PlatformWS.ShortCut[] models, string userID) {
            return base.Channel.AddShortCutByUser(models, userID);
        }
        
        public bool RemoveShortCutByUser(string shortCutID, string userID) {
            return base.Channel.RemoveShortCutByUser(shortCutID, userID);
        }
        
        public SMT.SAAS.Platform.Services.Test.PlatformWS.ModuleInfo[] GetTaskConfigInfoByUser(string userID) {
            return base.Channel.GetTaskConfigInfoByUser(userID);
        }
    }
}
