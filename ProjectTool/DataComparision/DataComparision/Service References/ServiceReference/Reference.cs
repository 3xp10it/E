﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataComparision.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.DataWebServiceSoap")]
    public interface DataWebServiceSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 userName 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        DataComparision.ServiceReference.LoginResponse Login(DataComparision.ServiceReference.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<DataComparision.ServiceReference.LoginResponse> LoginAsync(DataComparision.ServiceReference.LoginRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 userName 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CompareToolLogin", ReplyAction="*")]
        DataComparision.ServiceReference.CompareToolLoginResponse CompareToolLogin(DataComparision.ServiceReference.CompareToolLoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CompareToolLogin", ReplyAction="*")]
        System.Threading.Tasks.Task<DataComparision.ServiceReference.CompareToolLoginResponse> CompareToolLoginAsync(DataComparision.ServiceReference.CompareToolLoginRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 userName 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LogOut", ReplyAction="*")]
        DataComparision.ServiceReference.LogOutResponse LogOut(DataComparision.ServiceReference.LogOutRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LogOut", ReplyAction="*")]
        System.Threading.Tasks.Task<DataComparision.ServiceReference.LogOutResponse> LogOutAsync(DataComparision.ServiceReference.LogOutRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 userName 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGroups", ReplyAction="*")]
        DataComparision.ServiceReference.GetGroupsResponse GetGroups(DataComparision.ServiceReference.GetGroupsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGroups", ReplyAction="*")]
        System.Threading.Tasks.Task<DataComparision.ServiceReference.GetGroupsResponse> GetGroupsAsync(DataComparision.ServiceReference.GetGroupsRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 userName 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGroupNames", ReplyAction="*")]
        DataComparision.ServiceReference.GetGroupNamesResponse GetGroupNames(DataComparision.ServiceReference.GetGroupNamesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGroupNames", ReplyAction="*")]
        System.Threading.Tasks.Task<DataComparision.ServiceReference.GetGroupNamesResponse> GetGroupNamesAsync(DataComparision.ServiceReference.GetGroupNamesRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 data 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaveTradeData", ReplyAction="*")]
        DataComparision.ServiceReference.SaveTradeDataResponse SaveTradeData(DataComparision.ServiceReference.SaveTradeDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SaveTradeData", ReplyAction="*")]
        System.Threading.Tasks.Task<DataComparision.ServiceReference.SaveTradeDataResponse> SaveTradeDataAsync(DataComparision.ServiceReference.SaveTradeDataRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="http://tempuri.org/", Order=0)]
        public DataComparision.ServiceReference.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(DataComparision.ServiceReference.LoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public LoginRequestBody() {
        }
        
        public LoginRequestBody(string userName, string password) {
            this.userName = userName;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginResponse", Namespace="http://tempuri.org/", Order=0)]
        public DataComparision.ServiceReference.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(DataComparision.ServiceReference.LoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool LoginResult;
        
        public LoginResponseBody() {
        }
        
        public LoginResponseBody(bool LoginResult) {
            this.LoginResult = LoginResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CompareToolLoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CompareToolLogin", Namespace="http://tempuri.org/", Order=0)]
        public DataComparision.ServiceReference.CompareToolLoginRequestBody Body;
        
        public CompareToolLoginRequest() {
        }
        
        public CompareToolLoginRequest(DataComparision.ServiceReference.CompareToolLoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CompareToolLoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public CompareToolLoginRequestBody() {
        }
        
        public CompareToolLoginRequestBody(string userName, string password) {
            this.userName = userName;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CompareToolLoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CompareToolLoginResponse", Namespace="http://tempuri.org/", Order=0)]
        public DataComparision.ServiceReference.CompareToolLoginResponseBody Body;
        
        public CompareToolLoginResponse() {
        }
        
        public CompareToolLoginResponse(DataComparision.ServiceReference.CompareToolLoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CompareToolLoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool CompareToolLoginResult;
        
        public CompareToolLoginResponseBody() {
        }
        
        public CompareToolLoginResponseBody(bool CompareToolLoginResult) {
            this.CompareToolLoginResult = CompareToolLoginResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LogOutRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LogOut", Namespace="http://tempuri.org/", Order=0)]
        public DataComparision.ServiceReference.LogOutRequestBody Body;
        
        public LogOutRequest() {
        }
        
        public LogOutRequest(DataComparision.ServiceReference.LogOutRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LogOutRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        public LogOutRequestBody() {
        }
        
        public LogOutRequestBody(string userName) {
            this.userName = userName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LogOutResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LogOutResponse", Namespace="http://tempuri.org/", Order=0)]
        public DataComparision.ServiceReference.LogOutResponseBody Body;
        
        public LogOutResponse() {
        }
        
        public LogOutResponse(DataComparision.ServiceReference.LogOutResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class LogOutResponseBody {
        
        public LogOutResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGroupsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGroups", Namespace="http://tempuri.org/", Order=0)]
        public DataComparision.ServiceReference.GetGroupsRequestBody Body;
        
        public GetGroupsRequest() {
        }
        
        public GetGroupsRequest(DataComparision.ServiceReference.GetGroupsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetGroupsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        public GetGroupsRequestBody() {
        }
        
        public GetGroupsRequestBody(string userName) {
            this.userName = userName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGroupsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGroupsResponse", Namespace="http://tempuri.org/", Order=0)]
        public DataComparision.ServiceReference.GetGroupsResponseBody Body;
        
        public GetGroupsResponse() {
        }
        
        public GetGroupsResponse(DataComparision.ServiceReference.GetGroupsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetGroupsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetGroupsResult;
        
        public GetGroupsResponseBody() {
        }
        
        public GetGroupsResponseBody(string GetGroupsResult) {
            this.GetGroupsResult = GetGroupsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGroupNamesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGroupNames", Namespace="http://tempuri.org/", Order=0)]
        public DataComparision.ServiceReference.GetGroupNamesRequestBody Body;
        
        public GetGroupNamesRequest() {
        }
        
        public GetGroupNamesRequest(DataComparision.ServiceReference.GetGroupNamesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetGroupNamesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        public GetGroupNamesRequestBody() {
        }
        
        public GetGroupNamesRequestBody(string userName) {
            this.userName = userName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGroupNamesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGroupNamesResponse", Namespace="http://tempuri.org/", Order=0)]
        public DataComparision.ServiceReference.GetGroupNamesResponseBody Body;
        
        public GetGroupNamesResponse() {
        }
        
        public GetGroupNamesResponse(DataComparision.ServiceReference.GetGroupNamesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetGroupNamesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetGroupNamesResult;
        
        public GetGroupNamesResponseBody() {
        }
        
        public GetGroupNamesResponseBody(string GetGroupNamesResult) {
            this.GetGroupNamesResult = GetGroupNamesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveTradeDataRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveTradeData", Namespace="http://tempuri.org/", Order=0)]
        public DataComparision.ServiceReference.SaveTradeDataRequestBody Body;
        
        public SaveTradeDataRequest() {
        }
        
        public SaveTradeDataRequest(DataComparision.ServiceReference.SaveTradeDataRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaveTradeDataRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string data;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string dataType;
        
        public SaveTradeDataRequestBody() {
        }
        
        public SaveTradeDataRequestBody(string data, string dataType) {
            this.data = data;
            this.dataType = dataType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveTradeDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveTradeDataResponse", Namespace="http://tempuri.org/", Order=0)]
        public DataComparision.ServiceReference.SaveTradeDataResponseBody Body;
        
        public SaveTradeDataResponse() {
        }
        
        public SaveTradeDataResponse(DataComparision.ServiceReference.SaveTradeDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaveTradeDataResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool SaveTradeDataResult;
        
        public SaveTradeDataResponseBody() {
        }
        
        public SaveTradeDataResponseBody(bool SaveTradeDataResult) {
            this.SaveTradeDataResult = SaveTradeDataResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface DataWebServiceSoapChannel : DataComparision.ServiceReference.DataWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataWebServiceSoapClient : System.ServiceModel.ClientBase<DataComparision.ServiceReference.DataWebServiceSoap>, DataComparision.ServiceReference.DataWebServiceSoap {
        
        public DataWebServiceSoapClient() {
        }
        
        public DataWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataComparision.ServiceReference.LoginResponse DataComparision.ServiceReference.DataWebServiceSoap.Login(DataComparision.ServiceReference.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public bool Login(string userName, string password) {
            DataComparision.ServiceReference.LoginRequest inValue = new DataComparision.ServiceReference.LoginRequest();
            inValue.Body = new DataComparision.ServiceReference.LoginRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            DataComparision.ServiceReference.LoginResponse retVal = ((DataComparision.ServiceReference.DataWebServiceSoap)(this)).Login(inValue);
            return retVal.Body.LoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataComparision.ServiceReference.LoginResponse> DataComparision.ServiceReference.DataWebServiceSoap.LoginAsync(DataComparision.ServiceReference.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataComparision.ServiceReference.LoginResponse> LoginAsync(string userName, string password) {
            DataComparision.ServiceReference.LoginRequest inValue = new DataComparision.ServiceReference.LoginRequest();
            inValue.Body = new DataComparision.ServiceReference.LoginRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            return ((DataComparision.ServiceReference.DataWebServiceSoap)(this)).LoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataComparision.ServiceReference.CompareToolLoginResponse DataComparision.ServiceReference.DataWebServiceSoap.CompareToolLogin(DataComparision.ServiceReference.CompareToolLoginRequest request) {
            return base.Channel.CompareToolLogin(request);
        }
        
        public bool CompareToolLogin(string userName, string password) {
            DataComparision.ServiceReference.CompareToolLoginRequest inValue = new DataComparision.ServiceReference.CompareToolLoginRequest();
            inValue.Body = new DataComparision.ServiceReference.CompareToolLoginRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            DataComparision.ServiceReference.CompareToolLoginResponse retVal = ((DataComparision.ServiceReference.DataWebServiceSoap)(this)).CompareToolLogin(inValue);
            return retVal.Body.CompareToolLoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataComparision.ServiceReference.CompareToolLoginResponse> DataComparision.ServiceReference.DataWebServiceSoap.CompareToolLoginAsync(DataComparision.ServiceReference.CompareToolLoginRequest request) {
            return base.Channel.CompareToolLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataComparision.ServiceReference.CompareToolLoginResponse> CompareToolLoginAsync(string userName, string password) {
            DataComparision.ServiceReference.CompareToolLoginRequest inValue = new DataComparision.ServiceReference.CompareToolLoginRequest();
            inValue.Body = new DataComparision.ServiceReference.CompareToolLoginRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            return ((DataComparision.ServiceReference.DataWebServiceSoap)(this)).CompareToolLoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataComparision.ServiceReference.LogOutResponse DataComparision.ServiceReference.DataWebServiceSoap.LogOut(DataComparision.ServiceReference.LogOutRequest request) {
            return base.Channel.LogOut(request);
        }
        
        public void LogOut(string userName) {
            DataComparision.ServiceReference.LogOutRequest inValue = new DataComparision.ServiceReference.LogOutRequest();
            inValue.Body = new DataComparision.ServiceReference.LogOutRequestBody();
            inValue.Body.userName = userName;
            DataComparision.ServiceReference.LogOutResponse retVal = ((DataComparision.ServiceReference.DataWebServiceSoap)(this)).LogOut(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataComparision.ServiceReference.LogOutResponse> DataComparision.ServiceReference.DataWebServiceSoap.LogOutAsync(DataComparision.ServiceReference.LogOutRequest request) {
            return base.Channel.LogOutAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataComparision.ServiceReference.LogOutResponse> LogOutAsync(string userName) {
            DataComparision.ServiceReference.LogOutRequest inValue = new DataComparision.ServiceReference.LogOutRequest();
            inValue.Body = new DataComparision.ServiceReference.LogOutRequestBody();
            inValue.Body.userName = userName;
            return ((DataComparision.ServiceReference.DataWebServiceSoap)(this)).LogOutAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataComparision.ServiceReference.GetGroupsResponse DataComparision.ServiceReference.DataWebServiceSoap.GetGroups(DataComparision.ServiceReference.GetGroupsRequest request) {
            return base.Channel.GetGroups(request);
        }
        
        public string GetGroups(string userName) {
            DataComparision.ServiceReference.GetGroupsRequest inValue = new DataComparision.ServiceReference.GetGroupsRequest();
            inValue.Body = new DataComparision.ServiceReference.GetGroupsRequestBody();
            inValue.Body.userName = userName;
            DataComparision.ServiceReference.GetGroupsResponse retVal = ((DataComparision.ServiceReference.DataWebServiceSoap)(this)).GetGroups(inValue);
            return retVal.Body.GetGroupsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataComparision.ServiceReference.GetGroupsResponse> DataComparision.ServiceReference.DataWebServiceSoap.GetGroupsAsync(DataComparision.ServiceReference.GetGroupsRequest request) {
            return base.Channel.GetGroupsAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataComparision.ServiceReference.GetGroupsResponse> GetGroupsAsync(string userName) {
            DataComparision.ServiceReference.GetGroupsRequest inValue = new DataComparision.ServiceReference.GetGroupsRequest();
            inValue.Body = new DataComparision.ServiceReference.GetGroupsRequestBody();
            inValue.Body.userName = userName;
            return ((DataComparision.ServiceReference.DataWebServiceSoap)(this)).GetGroupsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataComparision.ServiceReference.GetGroupNamesResponse DataComparision.ServiceReference.DataWebServiceSoap.GetGroupNames(DataComparision.ServiceReference.GetGroupNamesRequest request) {
            return base.Channel.GetGroupNames(request);
        }
        
        public string GetGroupNames(string userName) {
            DataComparision.ServiceReference.GetGroupNamesRequest inValue = new DataComparision.ServiceReference.GetGroupNamesRequest();
            inValue.Body = new DataComparision.ServiceReference.GetGroupNamesRequestBody();
            inValue.Body.userName = userName;
            DataComparision.ServiceReference.GetGroupNamesResponse retVal = ((DataComparision.ServiceReference.DataWebServiceSoap)(this)).GetGroupNames(inValue);
            return retVal.Body.GetGroupNamesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataComparision.ServiceReference.GetGroupNamesResponse> DataComparision.ServiceReference.DataWebServiceSoap.GetGroupNamesAsync(DataComparision.ServiceReference.GetGroupNamesRequest request) {
            return base.Channel.GetGroupNamesAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataComparision.ServiceReference.GetGroupNamesResponse> GetGroupNamesAsync(string userName) {
            DataComparision.ServiceReference.GetGroupNamesRequest inValue = new DataComparision.ServiceReference.GetGroupNamesRequest();
            inValue.Body = new DataComparision.ServiceReference.GetGroupNamesRequestBody();
            inValue.Body.userName = userName;
            return ((DataComparision.ServiceReference.DataWebServiceSoap)(this)).GetGroupNamesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        DataComparision.ServiceReference.SaveTradeDataResponse DataComparision.ServiceReference.DataWebServiceSoap.SaveTradeData(DataComparision.ServiceReference.SaveTradeDataRequest request) {
            return base.Channel.SaveTradeData(request);
        }
        
        public bool SaveTradeData(string data, string dataType) {
            DataComparision.ServiceReference.SaveTradeDataRequest inValue = new DataComparision.ServiceReference.SaveTradeDataRequest();
            inValue.Body = new DataComparision.ServiceReference.SaveTradeDataRequestBody();
            inValue.Body.data = data;
            inValue.Body.dataType = dataType;
            DataComparision.ServiceReference.SaveTradeDataResponse retVal = ((DataComparision.ServiceReference.DataWebServiceSoap)(this)).SaveTradeData(inValue);
            return retVal.Body.SaveTradeDataResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<DataComparision.ServiceReference.SaveTradeDataResponse> DataComparision.ServiceReference.DataWebServiceSoap.SaveTradeDataAsync(DataComparision.ServiceReference.SaveTradeDataRequest request) {
            return base.Channel.SaveTradeDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<DataComparision.ServiceReference.SaveTradeDataResponse> SaveTradeDataAsync(string data, string dataType) {
            DataComparision.ServiceReference.SaveTradeDataRequest inValue = new DataComparision.ServiceReference.SaveTradeDataRequest();
            inValue.Body = new DataComparision.ServiceReference.SaveTradeDataRequestBody();
            inValue.Body.data = data;
            inValue.Body.dataType = dataType;
            return ((DataComparision.ServiceReference.DataWebServiceSoap)(this)).SaveTradeDataAsync(inValue);
        }
    }
}