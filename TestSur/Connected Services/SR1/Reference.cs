﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestSur.SR1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WCFError", Namespace="Horace")]
    [System.SerializableAttribute()]
    public partial class WCFError : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperationField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operation {
            get {
                return this.OperationField;
            }
            set {
                if ((object.ReferenceEquals(this.OperationField, value) != true)) {
                    this.OperationField = value;
                    this.RaisePropertyChanged("Operation");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="Horace", ConfigurationName="SR1.Icl")]
    public interface Icl {
        
        [System.ServiceModel.OperationContractAttribute(Action="Horace/Icl/Login", ReplyAction="Horace/Icl/LoginResponse")]
        int Login(string p, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="Horace/Icl/Login", ReplyAction="Horace/Icl/LoginResponse")]
        System.Threading.Tasks.Task<int> LoginAsync(string p, string pswd);
        
        [System.ServiceModel.OperationContractAttribute(Action="Horace/Icl/GetServer", ReplyAction="Horace/Icl/GetServerResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(TestSur.SR1.WCFError), Action="Horace/Icl/GetServerWCFErrorFault", Name="WCFError")]
        System.Data.DataSet GetServer(string p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Horace/Icl/GetServer", ReplyAction="Horace/Icl/GetServerResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetServerAsync(string p);
        
        [System.ServiceModel.OperationContractAttribute(Action="Horace/Icl/PingSer", ReplyAction="Horace/Icl/PingSerResponse")]
        TestSur.SR1.PingSerResponse PingSer(TestSur.SR1.PingSerRequest request);
        
        // CODEGEN: 正在生成消息协定，应为该操作具有多个返回值。
        [System.ServiceModel.OperationContractAttribute(Action="Horace/Icl/PingSer", ReplyAction="Horace/Icl/PingSerResponse")]
        System.Threading.Tasks.Task<TestSur.SR1.PingSerResponse> PingSerAsync(TestSur.SR1.PingSerRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PingSer", WrapperNamespace="Horace", IsWrapped=true)]
    public partial class PingSerRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="Horace", Order=0)]
        public string serid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="Horace", Order=1)]
        public System.Net.IPAddress Address;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="Horace", Order=2)]
        public long RtT;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="Horace", Order=3)]
        public int Ttl;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="Horace", Order=4)]
        public bool DF;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="Horace", Order=5)]
        public int BfL;
        
        public PingSerRequest() {
        }
        
        public PingSerRequest(string serid, System.Net.IPAddress Address, long RtT, int Ttl, bool DF, int BfL) {
            this.serid = serid;
            this.Address = Address;
            this.RtT = RtT;
            this.Ttl = Ttl;
            this.DF = DF;
            this.BfL = BfL;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="PingSerResponse", WrapperNamespace="Horace", IsWrapped=true)]
    public partial class PingSerResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="Horace", Order=0)]
        public int PingSerResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="Horace", Order=1)]
        public long RtT;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="Horace", Order=2)]
        public int Ttl;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="Horace", Order=3)]
        public int BfL;
        
        public PingSerResponse() {
        }
        
        public PingSerResponse(int PingSerResult, long RtT, int Ttl, int BfL) {
            this.PingSerResult = PingSerResult;
            this.RtT = RtT;
            this.Ttl = Ttl;
            this.BfL = BfL;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IclChannel : TestSur.SR1.Icl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IclClient : System.ServiceModel.ClientBase<TestSur.SR1.Icl>, TestSur.SR1.Icl {
        
        public IclClient() {
        }
        
        public IclClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IclClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IclClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IclClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Login(string p, string pswd) {
            return base.Channel.Login(p, pswd);
        }
        
        public System.Threading.Tasks.Task<int> LoginAsync(string p, string pswd) {
            return base.Channel.LoginAsync(p, pswd);
        }
        
        public System.Data.DataSet GetServer(string p) {
            return base.Channel.GetServer(p);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetServerAsync(string p) {
            return base.Channel.GetServerAsync(p);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestSur.SR1.PingSerResponse TestSur.SR1.Icl.PingSer(TestSur.SR1.PingSerRequest request) {
            return base.Channel.PingSer(request);
        }
        
        public int PingSer(string serid, System.Net.IPAddress Address, ref long RtT, ref int Ttl, bool DF, ref int BfL) {
            TestSur.SR1.PingSerRequest inValue = new TestSur.SR1.PingSerRequest();
            inValue.serid = serid;
            inValue.Address = Address;
            inValue.RtT = RtT;
            inValue.Ttl = Ttl;
            inValue.DF = DF;
            inValue.BfL = BfL;
            TestSur.SR1.PingSerResponse retVal = ((TestSur.SR1.Icl)(this)).PingSer(inValue);
            RtT = retVal.RtT;
            Ttl = retVal.Ttl;
            BfL = retVal.BfL;
            return retVal.PingSerResult;
        }
        
        public System.Threading.Tasks.Task<TestSur.SR1.PingSerResponse> PingSerAsync(TestSur.SR1.PingSerRequest request) {
            return base.Channel.PingSerAsync(request);
        }
    }
}
