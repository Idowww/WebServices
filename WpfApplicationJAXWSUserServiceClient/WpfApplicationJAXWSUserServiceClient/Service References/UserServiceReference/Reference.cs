﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplicationJAXWSUserServiceClient.UserServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.roman.epam.com/", ConfigurationName="UserServiceReference.UserService")]
    public interface UserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.roman.epam.com/UserService/deleteUserRequest", ReplyAction="http://ws.roman.epam.com/UserService/deleteUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        void deleteUser(int arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.roman.epam.com/UserService/deleteUserRequest", ReplyAction="http://ws.roman.epam.com/UserService/deleteUserResponse")]
        System.Threading.Tasks.Task deleteUserAsync(int arg0);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlArrayAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.roman.epam.com/UserService/getAllUsersRequest", ReplyAction="http://ws.roman.epam.com/UserService/getAllUsersResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersResponse getAllUsers(WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.roman.epam.com/UserService/getAllUsersRequest", ReplyAction="http://ws.roman.epam.com/UserService/getAllUsersResponse")]
        System.Threading.Tasks.Task<WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersResponse> getAllUsersAsync(WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.roman.epam.com/UserService/addUserRequest", ReplyAction="http://ws.roman.epam.com/UserService/addUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        void addUser(WpfApplicationJAXWSUserServiceClient.UserServiceReference.user arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.roman.epam.com/UserService/addUserRequest", ReplyAction="http://ws.roman.epam.com/UserService/addUserResponse")]
        System.Threading.Tasks.Task addUserAsync(WpfApplicationJAXWSUserServiceClient.UserServiceReference.user arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.roman.epam.com/UserService/getUserRequest", ReplyAction="http://ws.roman.epam.com/UserService/getUserResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WpfApplicationJAXWSUserServiceClient.UserServiceReference.user getUser(int arg0);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ws.roman.epam.com/UserService/getUserRequest", ReplyAction="http://ws.roman.epam.com/UserService/getUserResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<WpfApplicationJAXWSUserServiceClient.UserServiceReference.user> getUserAsync(int arg0);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34281")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.roman.epam.com/")]
    public partial class user : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string loginField;
        
        private int epamIdField;
        
        private bool epamIdFieldSpecified;
        
        private bool deletedField;
        
        private bool deletedFieldSpecified;
        
        private int levelIdField;
        
        private bool levelIdFieldSpecified;
        
        private long locationIdField;
        
        private bool locationIdFieldSpecified;
        
        private int managerIdField;
        
        private bool managerIdFieldSpecified;
        
        private long upsaIdField;
        
        private bool upsaIdFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
                this.RaisePropertyChanged("idSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string login {
            get {
                return this.loginField;
            }
            set {
                this.loginField = value;
                this.RaisePropertyChanged("login");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int epamId {
            get {
                return this.epamIdField;
            }
            set {
                this.epamIdField = value;
                this.RaisePropertyChanged("epamId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool epamIdSpecified {
            get {
                return this.epamIdFieldSpecified;
            }
            set {
                this.epamIdFieldSpecified = value;
                this.RaisePropertyChanged("epamIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public bool deleted {
            get {
                return this.deletedField;
            }
            set {
                this.deletedField = value;
                this.RaisePropertyChanged("deleted");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deletedSpecified {
            get {
                return this.deletedFieldSpecified;
            }
            set {
                this.deletedFieldSpecified = value;
                this.RaisePropertyChanged("deletedSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public int levelId {
            get {
                return this.levelIdField;
            }
            set {
                this.levelIdField = value;
                this.RaisePropertyChanged("levelId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool levelIdSpecified {
            get {
                return this.levelIdFieldSpecified;
            }
            set {
                this.levelIdFieldSpecified = value;
                this.RaisePropertyChanged("levelIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public long locationId {
            get {
                return this.locationIdField;
            }
            set {
                this.locationIdField = value;
                this.RaisePropertyChanged("locationId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool locationIdSpecified {
            get {
                return this.locationIdFieldSpecified;
            }
            set {
                this.locationIdFieldSpecified = value;
                this.RaisePropertyChanged("locationIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public int managerId {
            get {
                return this.managerIdField;
            }
            set {
                this.managerIdField = value;
                this.RaisePropertyChanged("managerId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool managerIdSpecified {
            get {
                return this.managerIdFieldSpecified;
            }
            set {
                this.managerIdFieldSpecified = value;
                this.RaisePropertyChanged("managerIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public long upsaId {
            get {
                return this.upsaIdField;
            }
            set {
                this.upsaIdField = value;
                this.RaisePropertyChanged("upsaId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool upsaIdSpecified {
            get {
                return this.upsaIdFieldSpecified;
            }
            set {
                this.upsaIdFieldSpecified = value;
                this.RaisePropertyChanged("upsaIdSpecified");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAllUsers", WrapperNamespace="http://ws.roman.epam.com/", IsWrapped=true)]
    public partial class getAllUsersRequest {
        
        public getAllUsersRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAllUsersResponse", WrapperNamespace="http://ws.roman.epam.com/", IsWrapped=true)]
    public partial class getAllUsersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="", Order=0)]
        [System.Xml.Serialization.XmlArrayAttribute()]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WpfApplicationJAXWSUserServiceClient.UserServiceReference.user[] @return;
        
        public getAllUsersResponse() {
        }
        
        public getAllUsersResponse(WpfApplicationJAXWSUserServiceClient.UserServiceReference.user[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UserServiceChannel : WpfApplicationJAXWSUserServiceClient.UserServiceReference.UserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<WpfApplicationJAXWSUserServiceClient.UserServiceReference.UserService>, WpfApplicationJAXWSUserServiceClient.UserServiceReference.UserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void deleteUser(int arg0) {
            base.Channel.deleteUser(arg0);
        }
        
        public System.Threading.Tasks.Task deleteUserAsync(int arg0) {
            return base.Channel.deleteUserAsync(arg0);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersResponse WpfApplicationJAXWSUserServiceClient.UserServiceReference.UserService.getAllUsers(WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersRequest request) {
            return base.Channel.getAllUsers(request);
        }
        
        public WpfApplicationJAXWSUserServiceClient.UserServiceReference.user[] getAllUsers() {
            WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersRequest inValue = new WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersRequest();
            WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersResponse retVal = ((WpfApplicationJAXWSUserServiceClient.UserServiceReference.UserService)(this)).getAllUsers(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersResponse> WpfApplicationJAXWSUserServiceClient.UserServiceReference.UserService.getAllUsersAsync(WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersRequest request) {
            return base.Channel.getAllUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersResponse> getAllUsersAsync() {
            WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersRequest inValue = new WpfApplicationJAXWSUserServiceClient.UserServiceReference.getAllUsersRequest();
            return ((WpfApplicationJAXWSUserServiceClient.UserServiceReference.UserService)(this)).getAllUsersAsync(inValue);
        }
        
        public void addUser(WpfApplicationJAXWSUserServiceClient.UserServiceReference.user arg0) {
            base.Channel.addUser(arg0);
        }
        
        public System.Threading.Tasks.Task addUserAsync(WpfApplicationJAXWSUserServiceClient.UserServiceReference.user arg0) {
            return base.Channel.addUserAsync(arg0);
        }
        
        public WpfApplicationJAXWSUserServiceClient.UserServiceReference.user getUser(int arg0) {
            return base.Channel.getUser(arg0);
        }
        
        public System.Threading.Tasks.Task<WpfApplicationJAXWSUserServiceClient.UserServiceReference.user> getUserAsync(int arg0) {
            return base.Channel.getUserAsync(arg0);
        }
    }
}