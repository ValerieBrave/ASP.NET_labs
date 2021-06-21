﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFclient.WCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Note", Namespace="http://schemas.datacontract.org/2004/07/WCFlib.Repository")]
    [System.SerializableAttribute()]
    public partial class Note : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long NoteIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelephoneField;

        public Note(string name, string num)
        {
            this.NoteId = DateTime.Now.ToFileTime();
            this.Fullname = name;
            this.Telephone = num;
        }
        public Note(long id, string name, string num)
        {
            this.NoteId = id;
            this.Fullname = name;
            this.Telephone = num;
        }

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
        public string Fullname {
            get {
                return this.FullnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullnameField, value) != true)) {
                    this.FullnameField = value;
                    this.RaisePropertyChanged("Fullname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long NoteId {
            get {
                return this.NoteIdField;
            }
            set {
                if ((this.NoteIdField.Equals(value) != true)) {
                    this.NoteIdField = value;
                    this.RaisePropertyChanged("NoteId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telephone {
            get {
                return this.TelephoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelephoneField, value) != true)) {
                    this.TelephoneField = value;
                    this.RaisePropertyChanged("Telephone");
                }
            }
        }

        public long Id { get; }
        public string Name { get; }
        public string Number { get; }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCF.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAll", ReplyAction="http://tempuri.org/IService/GetAllResponse")]
        WCFclient.WCF.Note[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAll", ReplyAction="http://tempuri.org/IService/GetAllResponse")]
        System.Threading.Tasks.Task<WCFclient.WCF.Note[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Add", ReplyAction="http://tempuri.org/IService/AddResponse")]
        WCFclient.WCF.Note Add(WCFclient.WCF.Note newNote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Add", ReplyAction="http://tempuri.org/IService/AddResponse")]
        System.Threading.Tasks.Task<WCFclient.WCF.Note> AddAsync(WCFclient.WCF.Note newNote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update", ReplyAction="http://tempuri.org/IService/UpdateResponse")]
        WCFclient.WCF.Note Update(WCFclient.WCF.Note newNote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Update", ReplyAction="http://tempuri.org/IService/UpdateResponse")]
        System.Threading.Tasks.Task<WCFclient.WCF.Note> UpdateAsync(WCFclient.WCF.Note newNote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Delete", ReplyAction="http://tempuri.org/IService/DeleteResponse")]
        long Delete(long NoteID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Delete", ReplyAction="http://tempuri.org/IService/DeleteResponse")]
        System.Threading.Tasks.Task<long> DeleteAsync(long NoteID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WCFclient.WCF.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WCFclient.WCF.IService>, WCFclient.WCF.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFclient.WCF.Note[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<WCFclient.WCF.Note[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public WCFclient.WCF.Note Add(WCFclient.WCF.Note newNote) {
            return base.Channel.Add(newNote);
        }
        
        public System.Threading.Tasks.Task<WCFclient.WCF.Note> AddAsync(WCFclient.WCF.Note newNote) {
            return base.Channel.AddAsync(newNote);
        }
        
        public WCFclient.WCF.Note Update(WCFclient.WCF.Note newNote) {
            return base.Channel.Update(newNote);
        }
        
        public System.Threading.Tasks.Task<WCFclient.WCF.Note> UpdateAsync(WCFclient.WCF.Note newNote) {
            return base.Channel.UpdateAsync(newNote);
        }
        
        public long Delete(long NoteID) {
            return base.Channel.Delete(NoteID);
        }
        
        public System.Threading.Tasks.Task<long> DeleteAsync(long NoteID) {
            return base.Channel.DeleteAsync(NoteID);
        }
    }
}