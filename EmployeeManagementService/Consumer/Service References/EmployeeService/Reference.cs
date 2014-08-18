﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consumer.EmployeeService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementService")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Consumer.EmployeeService.Remarks remarkObjectField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Consumer.EmployeeService.Remarks remarkObject {
            get {
                return this.remarkObjectField;
            }
            set {
                if ((object.ReferenceEquals(this.remarkObjectField, value) != true)) {
                    this.remarkObjectField = value;
                    this.RaisePropertyChanged("remarkObject");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Remarks", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementService")]
    [System.SerializableAttribute()]
    public partial class Remarks : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RemarkField;
        
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
        public System.DateTime Date {
            get {
                return this.DateField;
            }
            set {
                if ((this.DateField.Equals(value) != true)) {
                    this.DateField = value;
                    this.RaisePropertyChanged("Date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Remark {
            get {
                return this.RemarkField;
            }
            set {
                if ((object.ReferenceEquals(this.RemarkField, value) != true)) {
                    this.RemarkField = value;
                    this.RaisePropertyChanged("Remark");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.ICreateEmployeeAndAddRemarks")]
    public interface ICreateEmployeeAndAddRemarks {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAndAddRemarks/CreateNewEmployee", ReplyAction="http://tempuri.org/ICreateEmployeeAndAddRemarks/CreateNewEmployeeResponse")]
        void CreateNewEmployee(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAndAddRemarks/CreateNewEmployee", ReplyAction="http://tempuri.org/ICreateEmployeeAndAddRemarks/CreateNewEmployeeResponse")]
        System.Threading.Tasks.Task CreateNewEmployeeAsync(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAndAddRemarks/AddRemarks", ReplyAction="http://tempuri.org/ICreateEmployeeAndAddRemarks/AddRemarksResponse")]
        void AddRemarks(Consumer.EmployeeService.Employee emp);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAndAddRemarks/AddRemarks", ReplyAction="http://tempuri.org/ICreateEmployeeAndAddRemarks/AddRemarksResponse")]
        System.Threading.Tasks.Task AddRemarksAsync(Consumer.EmployeeService.Employee emp);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICreateEmployeeAndAddRemarksChannel : Consumer.EmployeeService.ICreateEmployeeAndAddRemarks, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreateEmployeeAndAddRemarksClient : System.ServiceModel.ClientBase<Consumer.EmployeeService.ICreateEmployeeAndAddRemarks>, Consumer.EmployeeService.ICreateEmployeeAndAddRemarks {
        
        public CreateEmployeeAndAddRemarksClient() {
        }
        
        public CreateEmployeeAndAddRemarksClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CreateEmployeeAndAddRemarksClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreateEmployeeAndAddRemarksClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CreateEmployeeAndAddRemarksClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CreateNewEmployee(int id, string name) {
            base.Channel.CreateNewEmployee(id, name);
        }
        
        public System.Threading.Tasks.Task CreateNewEmployeeAsync(int id, string name) {
            return base.Channel.CreateNewEmployeeAsync(id, name);
        }
        
        public void AddRemarks(Consumer.EmployeeService.Employee emp) {
            base.Channel.AddRemarks(emp);
        }
        
        public System.Threading.Tasks.Task AddRemarksAsync(Consumer.EmployeeService.Employee emp) {
            return base.Channel.AddRemarksAsync(emp);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeService.IRetrieve")]
    public interface IRetrieve {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/GetAllEmployeeList", ReplyAction="http://tempuri.org/IRetrieve/GetAllEmployeeListResponse")]
        Consumer.EmployeeService.Employee[] GetAllEmployeeList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/GetAllEmployeeList", ReplyAction="http://tempuri.org/IRetrieve/GetAllEmployeeListResponse")]
        System.Threading.Tasks.Task<Consumer.EmployeeService.Employee[]> GetAllEmployeeListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/SearchByName", ReplyAction="http://tempuri.org/IRetrieve/SearchByNameResponse")]
        Consumer.EmployeeService.Employee SearchByName(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/SearchByName", ReplyAction="http://tempuri.org/IRetrieve/SearchByNameResponse")]
        System.Threading.Tasks.Task<Consumer.EmployeeService.Employee> SearchByNameAsync(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/SearchById", ReplyAction="http://tempuri.org/IRetrieve/SearchByIdResponse")]
        Consumer.EmployeeService.Employee SearchById(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/SearchById", ReplyAction="http://tempuri.org/IRetrieve/SearchByIdResponse")]
        System.Threading.Tasks.Task<Consumer.EmployeeService.Employee> SearchByIdAsync(int Id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRetrieveChannel : Consumer.EmployeeService.IRetrieve, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RetrieveClient : System.ServiceModel.ClientBase<Consumer.EmployeeService.IRetrieve>, Consumer.EmployeeService.IRetrieve {
        
        public RetrieveClient() {
        }
        
        public RetrieveClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RetrieveClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RetrieveClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RetrieveClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Consumer.EmployeeService.Employee[] GetAllEmployeeList() {
            return base.Channel.GetAllEmployeeList();
        }
        
        public System.Threading.Tasks.Task<Consumer.EmployeeService.Employee[]> GetAllEmployeeListAsync() {
            return base.Channel.GetAllEmployeeListAsync();
        }
        
        public Consumer.EmployeeService.Employee SearchByName(string Name) {
            return base.Channel.SearchByName(Name);
        }
        
        public System.Threading.Tasks.Task<Consumer.EmployeeService.Employee> SearchByNameAsync(string Name) {
            return base.Channel.SearchByNameAsync(Name);
        }
        
        public Consumer.EmployeeService.Employee SearchById(int Id) {
            return base.Channel.SearchById(Id);
        }
        
        public System.Threading.Tasks.Task<Consumer.EmployeeService.Employee> SearchByIdAsync(int Id) {
            return base.Channel.SearchByIdAsync(Id);
        }
    }
}
