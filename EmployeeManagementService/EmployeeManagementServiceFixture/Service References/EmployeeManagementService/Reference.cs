﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManagementServiceFixture.EmployeeManagementService {
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
        private EmployeeManagementServiceFixture.EmployeeManagementService.Remark remarkObjectField;
        
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
        public EmployeeManagementServiceFixture.EmployeeManagementService.Remark remarkObject {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Remark", Namespace="http://schemas.datacontract.org/2004/07/EmployeeManagementService")]
    [System.SerializableAttribute()]
    public partial class Remark : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RemarkContentField;
        
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
        public string RemarkContent {
            get {
                return this.RemarkContentField;
            }
            set {
                if ((object.ReferenceEquals(this.RemarkContentField, value) != true)) {
                    this.RemarkContentField = value;
                    this.RaisePropertyChanged("RemarkContent");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeManagementService.ICreateEmployeeAndAddRemarks")]
    public interface ICreateEmployeeAndAddRemarks {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAndAddRemarks/CreateNewEmployee", ReplyAction="http://tempuri.org/ICreateEmployeeAndAddRemarks/CreateNewEmployeeResponse")]
        void CreateNewEmployee(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAndAddRemarks/CreateNewEmployee", ReplyAction="http://tempuri.org/ICreateEmployeeAndAddRemarks/CreateNewEmployeeResponse")]
        System.Threading.Tasks.Task CreateNewEmployeeAsync(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAndAddRemarks/AddRemarks", ReplyAction="http://tempuri.org/ICreateEmployeeAndAddRemarks/AddRemarksResponse")]
        void AddRemarks(int id, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAndAddRemarks/AddRemarks", ReplyAction="http://tempuri.org/ICreateEmployeeAndAddRemarks/AddRemarksResponse")]
        System.Threading.Tasks.Task AddRemarksAsync(int id, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAndAddRemarks/ClearEmployeeList", ReplyAction="http://tempuri.org/ICreateEmployeeAndAddRemarks/ClearEmployeeListResponse")]
        void ClearEmployeeList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICreateEmployeeAndAddRemarks/ClearEmployeeList", ReplyAction="http://tempuri.org/ICreateEmployeeAndAddRemarks/ClearEmployeeListResponse")]
        System.Threading.Tasks.Task ClearEmployeeListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICreateEmployeeAndAddRemarksChannel : EmployeeManagementServiceFixture.EmployeeManagementService.ICreateEmployeeAndAddRemarks, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreateEmployeeAndAddRemarksClient : System.ServiceModel.ClientBase<EmployeeManagementServiceFixture.EmployeeManagementService.ICreateEmployeeAndAddRemarks>, EmployeeManagementServiceFixture.EmployeeManagementService.ICreateEmployeeAndAddRemarks {
        
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
        
        public void AddRemarks(int id, string text) {
            base.Channel.AddRemarks(id, text);
        }
        
        public System.Threading.Tasks.Task AddRemarksAsync(int id, string text) {
            return base.Channel.AddRemarksAsync(id, text);
        }
        
        public void ClearEmployeeList() {
            base.Channel.ClearEmployeeList();
        }
        
        public System.Threading.Tasks.Task ClearEmployeeListAsync() {
            return base.Channel.ClearEmployeeListAsync();
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeManagementService.IRetrieve")]
    public interface IRetrieve {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/GetAllEmployeeList", ReplyAction="http://tempuri.org/IRetrieve/GetAllEmployeeListResponse")]
        EmployeeManagementServiceFixture.EmployeeManagementService.Employee[] GetAllEmployeeList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/GetAllEmployeeList", ReplyAction="http://tempuri.org/IRetrieve/GetAllEmployeeListResponse")]
        System.Threading.Tasks.Task<EmployeeManagementServiceFixture.EmployeeManagementService.Employee[]> GetAllEmployeeListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/SearchByName", ReplyAction="http://tempuri.org/IRetrieve/SearchByNameResponse")]
        EmployeeManagementServiceFixture.EmployeeManagementService.Employee[] SearchByName(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/SearchByName", ReplyAction="http://tempuri.org/IRetrieve/SearchByNameResponse")]
        System.Threading.Tasks.Task<EmployeeManagementServiceFixture.EmployeeManagementService.Employee[]> SearchByNameAsync(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/SearchById", ReplyAction="http://tempuri.org/IRetrieve/SearchByIdResponse")]
        EmployeeManagementServiceFixture.EmployeeManagementService.Employee SearchById(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/SearchById", ReplyAction="http://tempuri.org/IRetrieve/SearchByIdResponse")]
        System.Threading.Tasks.Task<EmployeeManagementServiceFixture.EmployeeManagementService.Employee> SearchByIdAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/GetAllEmployeesWithRemarks", ReplyAction="http://tempuri.org/IRetrieve/GetAllEmployeesWithRemarksResponse")]
        EmployeeManagementServiceFixture.EmployeeManagementService.Employee[] GetAllEmployeesWithRemarks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetrieve/GetAllEmployeesWithRemarks", ReplyAction="http://tempuri.org/IRetrieve/GetAllEmployeesWithRemarksResponse")]
        System.Threading.Tasks.Task<EmployeeManagementServiceFixture.EmployeeManagementService.Employee[]> GetAllEmployeesWithRemarksAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRetrieveChannel : EmployeeManagementServiceFixture.EmployeeManagementService.IRetrieve, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RetrieveClient : System.ServiceModel.ClientBase<EmployeeManagementServiceFixture.EmployeeManagementService.IRetrieve>, EmployeeManagementServiceFixture.EmployeeManagementService.IRetrieve {
        
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
        
        public EmployeeManagementServiceFixture.EmployeeManagementService.Employee[] GetAllEmployeeList() {
            return base.Channel.GetAllEmployeeList();
        }
        
        public System.Threading.Tasks.Task<EmployeeManagementServiceFixture.EmployeeManagementService.Employee[]> GetAllEmployeeListAsync() {
            return base.Channel.GetAllEmployeeListAsync();
        }
        
        public EmployeeManagementServiceFixture.EmployeeManagementService.Employee[] SearchByName(string Name) {
            return base.Channel.SearchByName(Name);
        }
        
        public System.Threading.Tasks.Task<EmployeeManagementServiceFixture.EmployeeManagementService.Employee[]> SearchByNameAsync(string Name) {
            return base.Channel.SearchByNameAsync(Name);
        }
        
        public EmployeeManagementServiceFixture.EmployeeManagementService.Employee SearchById(int Id) {
            return base.Channel.SearchById(Id);
        }
        
        public System.Threading.Tasks.Task<EmployeeManagementServiceFixture.EmployeeManagementService.Employee> SearchByIdAsync(int Id) {
            return base.Channel.SearchByIdAsync(Id);
        }
        
        public EmployeeManagementServiceFixture.EmployeeManagementService.Employee[] GetAllEmployeesWithRemarks() {
            return base.Channel.GetAllEmployeesWithRemarks();
        }
        
        public System.Threading.Tasks.Task<EmployeeManagementServiceFixture.EmployeeManagementService.Employee[]> GetAllEmployeesWithRemarksAsync() {
            return base.Channel.GetAllEmployeesWithRemarksAsync();
        }
    }
}
