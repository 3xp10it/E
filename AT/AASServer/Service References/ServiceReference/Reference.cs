﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace AASServer.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GroupService.Queryinfo", Namespace="http://schemas.datacontract.org/2004/07/GroupClient")]
    [System.SerializableAttribute()]
    public partial class GroupServiceQueryinfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OtherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Other2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ResultField;
        
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
        public string Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorField, value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Other {
            get {
                return this.OtherField;
            }
            set {
                if ((object.ReferenceEquals(this.OtherField, value) != true)) {
                    this.OtherField = value;
                    this.RaisePropertyChanged("Other");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Other2 {
            get {
                return this.Other2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Other2Field, value) != true)) {
                    this.Other2Field = value;
                    this.RaisePropertyChanged("Other2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Result {
            get {
                return this.ResultField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultField, value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GroupService.QueryFormatData", Namespace="http://schemas.datacontract.org/2004/07/GroupClient")]
    [System.SerializableAttribute()]
    public partial class GroupServiceQueryFormatData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrCJField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrWTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan QueryTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] lstCJField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] lstWTField;
        
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
        public string ErrCJ {
            get {
                return this.ErrCJField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrCJField, value) != true)) {
                    this.ErrCJField = value;
                    this.RaisePropertyChanged("ErrCJ");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrWT {
            get {
                return this.ErrWTField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrWTField, value) != true)) {
                    this.ErrWTField = value;
                    this.RaisePropertyChanged("ErrWT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan QueryTime {
            get {
                return this.QueryTimeField;
            }
            set {
                if ((this.QueryTimeField.Equals(value) != true)) {
                    this.QueryTimeField = value;
                    this.RaisePropertyChanged("QueryTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] lstCJ {
            get {
                return this.lstCJField;
            }
            set {
                if ((object.ReferenceEquals(this.lstCJField, value) != true)) {
                    this.lstCJField = value;
                    this.RaisePropertyChanged("lstCJ");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] lstWT {
            get {
                return this.lstWTField;
            }
            set {
                if ((object.ReferenceEquals(this.lstWTField, value) != true)) {
                    this.lstWTField = value;
                    this.RaisePropertyChanged("lstWT");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GroupService.QueryFilteData", Namespace="http://schemas.datacontract.org/2004/07/GroupClient")]
    [System.SerializableAttribute()]
    public partial class GroupServiceQueryFilteData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrCJField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrWTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan QueryTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] lstCJField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] lstWTField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string strTitleCJField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string strTitleWTField;
        
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
        public string ErrCJ {
            get {
                return this.ErrCJField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrCJField, value) != true)) {
                    this.ErrCJField = value;
                    this.RaisePropertyChanged("ErrCJ");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrWT {
            get {
                return this.ErrWTField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrWTField, value) != true)) {
                    this.ErrWTField = value;
                    this.RaisePropertyChanged("ErrWT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan QueryTime {
            get {
                return this.QueryTimeField;
            }
            set {
                if ((this.QueryTimeField.Equals(value) != true)) {
                    this.QueryTimeField = value;
                    this.RaisePropertyChanged("QueryTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] lstCJ {
            get {
                return this.lstCJField;
            }
            set {
                if ((object.ReferenceEquals(this.lstCJField, value) != true)) {
                    this.lstCJField = value;
                    this.RaisePropertyChanged("lstCJ");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] lstWT {
            get {
                return this.lstWTField;
            }
            set {
                if ((object.ReferenceEquals(this.lstWTField, value) != true)) {
                    this.lstWTField = value;
                    this.RaisePropertyChanged("lstWT");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string strTitleCJ {
            get {
                return this.strTitleCJField;
            }
            set {
                if ((object.ReferenceEquals(this.strTitleCJField, value) != true)) {
                    this.strTitleCJField = value;
                    this.RaisePropertyChanged("strTitleCJ");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string strTitleWT {
            get {
                return this.strTitleWTField;
            }
            set {
                if ((object.ReferenceEquals(this.strTitleWTField, value) != true)) {
                    this.strTitleWTField = value;
                    this.RaisePropertyChanged("strTitleWT");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.GroupService")]
    public interface GroupService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/Decrypt", ReplyAction="http://tempuri.org/GroupService/DecryptResponse")]
        string Decrypt(string string1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/Decrypt", ReplyAction="http://tempuri.org/GroupService/DecryptResponse")]
        System.Threading.Tasks.Task<string> DecryptAsync(string string1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/Test", ReplyAction="http://tempuri.org/GroupService/TestResponse")]
        string Test(string IP, short Port, string Version, short YybID, string AccountNo, string TradeAccount, string JyPassword, string TxPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/Test", ReplyAction="http://tempuri.org/GroupService/TestResponse")]
        System.Threading.Tasks.Task<string> TestAsync(string IP, short Port, string Version, short YybID, string AccountNo, string TradeAccount, string JyPassword, string TxPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/GetGroupClientID", ReplyAction="http://tempuri.org/GroupService/GetGroupClientIDResponse")]
        int GetGroupClientID(string groupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/GetGroupClientID", ReplyAction="http://tempuri.org/GroupService/GetGroupClientIDResponse")]
        System.Threading.Tasks.Task<int> GetGroupClientIDAsync(string groupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/IsGroupMultythread", ReplyAction="http://tempuri.org/GroupService/IsGroupMultythreadResponse")]
        bool IsGroupMultythread(string groupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/IsGroupMultythread", ReplyAction="http://tempuri.org/GroupService/IsGroupMultythreadResponse")]
        System.Threading.Tasks.Task<bool> IsGroupMultythreadAsync(string groupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/QueryPosition", ReplyAction="http://tempuri.org/GroupService/QueryPositionResponse")]
        AASServer.ServiceReference.GroupServiceQueryinfo QueryPosition(string GroupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/QueryPosition", ReplyAction="http://tempuri.org/GroupService/QueryPositionResponse")]
        System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryinfo> QueryPositionAsync(string GroupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/QueryDataAutoByMac", ReplyAction="http://tempuri.org/GroupService/QueryDataAutoByMacResponse")]
        AASServer.ServiceReference.GroupServiceQueryFormatData QueryDataAutoByMac(string groupName, string mac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/QueryDataAutoByMac", ReplyAction="http://tempuri.org/GroupService/QueryDataAutoByMacResponse")]
        System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryFormatData> QueryDataAutoByMacAsync(string groupName, string mac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/QueryDataFilted", ReplyAction="http://tempuri.org/GroupService/QueryDataFiltedResponse")]
        AASServer.ServiceReference.GroupServiceQueryFilteData QueryDataFilted(string mac, string GroupName, bool needTitleInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/QueryDataFilted", ReplyAction="http://tempuri.org/GroupService/QueryDataFiltedResponse")]
        System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryFilteData> QueryDataFiltedAsync(string mac, string GroupName, bool needTitleInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/UpdateOrderIDList", ReplyAction="http://tempuri.org/GroupService/UpdateOrderIDListResponse")]
        string[] UpdateOrderIDList(string mac, string GroupName, string[] orderIDs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/UpdateOrderIDList", ReplyAction="http://tempuri.org/GroupService/UpdateOrderIDListResponse")]
        System.Threading.Tasks.Task<string[]> UpdateOrderIDListAsync(string mac, string GroupName, string[] orderIDs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/QueryOrderByID", ReplyAction="http://tempuri.org/GroupService/QueryOrderByIDResponse")]
        string QueryOrderByID(string GroupName, string orderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/QueryOrderByID", ReplyAction="http://tempuri.org/GroupService/QueryOrderByIDResponse")]
        System.Threading.Tasks.Task<string> QueryOrderByIDAsync(string GroupName, string orderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/QueryListByMac", ReplyAction="http://tempuri.org/GroupService/QueryListByMacResponse")]
        string[] QueryListByMac(string mac, string GroupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/QueryListByMac", ReplyAction="http://tempuri.org/GroupService/QueryListByMacResponse")]
        System.Threading.Tasks.Task<string[]> QueryListByMacAsync(string mac, string GroupName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/SendOrder", ReplyAction="http://tempuri.org/GroupService/SendOrderResponse")]
        AASServer.ServiceReference.GroupServiceQueryinfo SendOrder(string GroupName, int Category, int PriceType, string Gddm, string Zqdm, float Price, int Quantity, string Mac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/SendOrder", ReplyAction="http://tempuri.org/GroupService/SendOrderResponse")]
        System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryinfo> SendOrderAsync(string GroupName, int Category, int PriceType, string Gddm, string Zqdm, float Price, int Quantity, string Mac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/CancelOrder", ReplyAction="http://tempuri.org/GroupService/CancelOrderResponse")]
        AASServer.ServiceReference.GroupServiceQueryinfo CancelOrder(string GroupName, string ExchangeID, string hth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/CancelOrder", ReplyAction="http://tempuri.org/GroupService/CancelOrderResponse")]
        System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryinfo> CancelOrderAsync(string GroupName, string ExchangeID, string hth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/CancelOrderHK", ReplyAction="http://tempuri.org/GroupService/CancelOrderHKResponse")]
        AASServer.ServiceReference.GroupServiceQueryinfo CancelOrderHK(string GroupName, string hth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/CancelOrderHK", ReplyAction="http://tempuri.org/GroupService/CancelOrderHKResponse")]
        System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryinfo> CancelOrderHKAsync(string GroupName, string hth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/SendIMSOrder", ReplyAction="http://tempuri.org/GroupService/SendIMSOrderResponse")]
        AASServer.ServiceReference.GroupServiceQueryinfo SendIMSOrder(string GroupName, string BSFlag, string market, string Zqdm, float price, int qty);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/SendIMSOrder", ReplyAction="http://tempuri.org/GroupService/SendIMSOrderResponse")]
        System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryinfo> SendIMSOrderAsync(string GroupName, string BSFlag, string market, string Zqdm, float price, int qty);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/CancelImsOrder", ReplyAction="http://tempuri.org/GroupService/CancelImsOrderResponse")]
        AASServer.ServiceReference.GroupServiceQueryinfo CancelImsOrder(string GroupName, string market, string zqdm, string hth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/CancelImsOrder", ReplyAction="http://tempuri.org/GroupService/CancelImsOrderResponse")]
        System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryinfo> CancelImsOrderAsync(string GroupName, string market, string zqdm, string hth);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/AccountRepay", ReplyAction="http://tempuri.org/GroupService/AccountRepayResponse")]
        string AccountRepay(string group, decimal amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GroupService/AccountRepay", ReplyAction="http://tempuri.org/GroupService/AccountRepayResponse")]
        System.Threading.Tasks.Task<string> AccountRepayAsync(string group, decimal amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GroupServiceChannel : AASServer.ServiceReference.GroupService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GroupServiceClient : System.ServiceModel.ClientBase<AASServer.ServiceReference.GroupService>, AASServer.ServiceReference.GroupService {
        
        public GroupServiceClient() {
        }
        
        public GroupServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GroupServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GroupServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Decrypt(string string1) {
            return base.Channel.Decrypt(string1);
        }
        
        public System.Threading.Tasks.Task<string> DecryptAsync(string string1) {
            return base.Channel.DecryptAsync(string1);
        }
        
        public string Test(string IP, short Port, string Version, short YybID, string AccountNo, string TradeAccount, string JyPassword, string TxPassword) {
            return base.Channel.Test(IP, Port, Version, YybID, AccountNo, TradeAccount, JyPassword, TxPassword);
        }
        
        public System.Threading.Tasks.Task<string> TestAsync(string IP, short Port, string Version, short YybID, string AccountNo, string TradeAccount, string JyPassword, string TxPassword) {
            return base.Channel.TestAsync(IP, Port, Version, YybID, AccountNo, TradeAccount, JyPassword, TxPassword);
        }
        
        public int GetGroupClientID(string groupName) {
            return base.Channel.GetGroupClientID(groupName);
        }
        
        public System.Threading.Tasks.Task<int> GetGroupClientIDAsync(string groupName) {
            return base.Channel.GetGroupClientIDAsync(groupName);
        }
        
        public bool IsGroupMultythread(string groupName) {
            return base.Channel.IsGroupMultythread(groupName);
        }
        
        public System.Threading.Tasks.Task<bool> IsGroupMultythreadAsync(string groupName) {
            return base.Channel.IsGroupMultythreadAsync(groupName);
        }
        
        public AASServer.ServiceReference.GroupServiceQueryinfo QueryPosition(string GroupName) {
            return base.Channel.QueryPosition(GroupName);
        }
        
        public System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryinfo> QueryPositionAsync(string GroupName) {
            return base.Channel.QueryPositionAsync(GroupName);
        }
        
        public AASServer.ServiceReference.GroupServiceQueryFormatData QueryDataAutoByMac(string groupName, string mac) {
            return base.Channel.QueryDataAutoByMac(groupName, mac);
        }
        
        public System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryFormatData> QueryDataAutoByMacAsync(string groupName, string mac) {
            return base.Channel.QueryDataAutoByMacAsync(groupName, mac);
        }
        
        public AASServer.ServiceReference.GroupServiceQueryFilteData QueryDataFilted(string mac, string GroupName, bool needTitleInfo) {
            return base.Channel.QueryDataFilted(mac, GroupName, needTitleInfo);
        }
        
        public System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryFilteData> QueryDataFiltedAsync(string mac, string GroupName, bool needTitleInfo) {
            return base.Channel.QueryDataFiltedAsync(mac, GroupName, needTitleInfo);
        }
        
        public string[] UpdateOrderIDList(string mac, string GroupName, string[] orderIDs) {
            return base.Channel.UpdateOrderIDList(mac, GroupName, orderIDs);
        }
        
        public System.Threading.Tasks.Task<string[]> UpdateOrderIDListAsync(string mac, string GroupName, string[] orderIDs) {
            return base.Channel.UpdateOrderIDListAsync(mac, GroupName, orderIDs);
        }
        
        public string QueryOrderByID(string GroupName, string orderID) {
            return base.Channel.QueryOrderByID(GroupName, orderID);
        }
        
        public System.Threading.Tasks.Task<string> QueryOrderByIDAsync(string GroupName, string orderID) {
            return base.Channel.QueryOrderByIDAsync(GroupName, orderID);
        }
        
        public string[] QueryListByMac(string mac, string GroupName) {
            return base.Channel.QueryListByMac(mac, GroupName);
        }
        
        public System.Threading.Tasks.Task<string[]> QueryListByMacAsync(string mac, string GroupName) {
            return base.Channel.QueryListByMacAsync(mac, GroupName);
        }
        
        public AASServer.ServiceReference.GroupServiceQueryinfo SendOrder(string GroupName, int Category, int PriceType, string Gddm, string Zqdm, float Price, int Quantity, string Mac) {
            return base.Channel.SendOrder(GroupName, Category, PriceType, Gddm, Zqdm, Price, Quantity, Mac);
        }
        
        public System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryinfo> SendOrderAsync(string GroupName, int Category, int PriceType, string Gddm, string Zqdm, float Price, int Quantity, string Mac) {
            return base.Channel.SendOrderAsync(GroupName, Category, PriceType, Gddm, Zqdm, Price, Quantity, Mac);
        }
        
        public AASServer.ServiceReference.GroupServiceQueryinfo CancelOrder(string GroupName, string ExchangeID, string hth) {
            return base.Channel.CancelOrder(GroupName, ExchangeID, hth);
        }
        
        public System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryinfo> CancelOrderAsync(string GroupName, string ExchangeID, string hth) {
            return base.Channel.CancelOrderAsync(GroupName, ExchangeID, hth);
        }
        
        public AASServer.ServiceReference.GroupServiceQueryinfo CancelOrderHK(string GroupName, string hth) {
            return base.Channel.CancelOrderHK(GroupName, hth);
        }
        
        public System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryinfo> CancelOrderHKAsync(string GroupName, string hth) {
            return base.Channel.CancelOrderHKAsync(GroupName, hth);
        }
        
        public AASServer.ServiceReference.GroupServiceQueryinfo SendIMSOrder(string GroupName, string BSFlag, string market, string Zqdm, float price, int qty) {
            return base.Channel.SendIMSOrder(GroupName, BSFlag, market, Zqdm, price, qty);
        }
        
        public System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryinfo> SendIMSOrderAsync(string GroupName, string BSFlag, string market, string Zqdm, float price, int qty) {
            return base.Channel.SendIMSOrderAsync(GroupName, BSFlag, market, Zqdm, price, qty);
        }
        
        public AASServer.ServiceReference.GroupServiceQueryinfo CancelImsOrder(string GroupName, string market, string zqdm, string hth) {
            return base.Channel.CancelImsOrder(GroupName, market, zqdm, hth);
        }
        
        public System.Threading.Tasks.Task<AASServer.ServiceReference.GroupServiceQueryinfo> CancelImsOrderAsync(string GroupName, string market, string zqdm, string hth) {
            return base.Channel.CancelImsOrderAsync(GroupName, market, zqdm, hth);
        }
        
        public string AccountRepay(string group, decimal amount) {
            return base.Channel.AccountRepay(group, amount);
        }
        
        public System.Threading.Tasks.Task<string> AccountRepayAsync(string group, decimal amount) {
            return base.Channel.AccountRepayAsync(group, amount);
        }
    }
}