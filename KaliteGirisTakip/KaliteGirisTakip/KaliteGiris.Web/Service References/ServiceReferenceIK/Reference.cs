﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KaliteGiris.Web.ServiceReferenceIK {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonelBilgi", Namespace="http://schemas.datacontract.org/2004/07/IK.Entities.Service")]
    [System.SerializableAttribute()]
    public partial class PersonelBilgi : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmanAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DepartmanIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonelIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SicilNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SoyadiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SubeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UnvanField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UnvanIdField;
        
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
        public string Adi {
            get {
                return this.AdiField;
            }
            set {
                if ((object.ReferenceEquals(this.AdiField, value) != true)) {
                    this.AdiField = value;
                    this.RaisePropertyChanged("Adi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartmanAdi {
            get {
                return this.DepartmanAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmanAdiField, value) != true)) {
                    this.DepartmanAdiField = value;
                    this.RaisePropertyChanged("DepartmanAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DepartmanId {
            get {
                return this.DepartmanIdField;
            }
            set {
                if ((this.DepartmanIdField.Equals(value) != true)) {
                    this.DepartmanIdField = value;
                    this.RaisePropertyChanged("DepartmanId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonelId {
            get {
                return this.PersonelIdField;
            }
            set {
                if ((this.PersonelIdField.Equals(value) != true)) {
                    this.PersonelIdField = value;
                    this.RaisePropertyChanged("PersonelId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SicilNo {
            get {
                return this.SicilNoField;
            }
            set {
                if ((this.SicilNoField.Equals(value) != true)) {
                    this.SicilNoField = value;
                    this.RaisePropertyChanged("SicilNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Soyadi {
            get {
                return this.SoyadiField;
            }
            set {
                if ((object.ReferenceEquals(this.SoyadiField, value) != true)) {
                    this.SoyadiField = value;
                    this.RaisePropertyChanged("Soyadi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sube {
            get {
                return this.SubeField;
            }
            set {
                if ((object.ReferenceEquals(this.SubeField, value) != true)) {
                    this.SubeField = value;
                    this.RaisePropertyChanged("Sube");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SubeId {
            get {
                return this.SubeIdField;
            }
            set {
                if ((this.SubeIdField.Equals(value) != true)) {
                    this.SubeIdField = value;
                    this.RaisePropertyChanged("SubeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Unvan {
            get {
                return this.UnvanField;
            }
            set {
                if ((object.ReferenceEquals(this.UnvanField, value) != true)) {
                    this.UnvanField = value;
                    this.RaisePropertyChanged("Unvan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UnvanId {
            get {
                return this.UnvanIdField;
            }
            set {
                if ((this.UnvanIdField.Equals(value) != true)) {
                    this.UnvanIdField = value;
                    this.RaisePropertyChanged("UnvanId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonelDepartman", Namespace="http://schemas.datacontract.org/2004/07/IK.Entities")]
    [System.SerializableAttribute()]
    public partial class PersonelDepartman : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmanAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmanKoduField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmanParentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ModificationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonelDepartmanIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SistemIdField;
        
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
        public System.DateTime CreationDate {
            get {
                return this.CreationDateField;
            }
            set {
                if ((this.CreationDateField.Equals(value) != true)) {
                    this.CreationDateField = value;
                    this.RaisePropertyChanged("CreationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartmanAdi {
            get {
                return this.DepartmanAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmanAdiField, value) != true)) {
                    this.DepartmanAdiField = value;
                    this.RaisePropertyChanged("DepartmanAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartmanKodu {
            get {
                return this.DepartmanKoduField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmanKoduField, value) != true)) {
                    this.DepartmanKoduField = value;
                    this.RaisePropertyChanged("DepartmanKodu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartmanParentId {
            get {
                return this.DepartmanParentIdField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmanParentIdField, value) != true)) {
                    this.DepartmanParentIdField = value;
                    this.RaisePropertyChanged("DepartmanParentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ModificationDate {
            get {
                return this.ModificationDateField;
            }
            set {
                if ((this.ModificationDateField.Equals(value) != true)) {
                    this.ModificationDateField = value;
                    this.RaisePropertyChanged("ModificationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PersonelDepartmanId {
            get {
                return this.PersonelDepartmanIdField;
            }
            set {
                if ((this.PersonelDepartmanIdField.Equals(value) != true)) {
                    this.PersonelDepartmanIdField = value;
                    this.RaisePropertyChanged("PersonelDepartmanId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SistemId {
            get {
                return this.SistemIdField;
            }
            set {
                if ((this.SistemIdField.Equals(value) != true)) {
                    this.SistemIdField = value;
                    this.RaisePropertyChanged("SistemId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonelUnvan", Namespace="http://schemas.datacontract.org/2004/07/IK.Entities")]
    [System.SerializableAttribute()]
    public partial class PersonelUnvan : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonelUnvanIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SiraNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UnvanAciklamaField;
        
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
        public int PersonelUnvanId {
            get {
                return this.PersonelUnvanIdField;
            }
            set {
                if ((this.PersonelUnvanIdField.Equals(value) != true)) {
                    this.PersonelUnvanIdField = value;
                    this.RaisePropertyChanged("PersonelUnvanId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SiraNo {
            get {
                return this.SiraNoField;
            }
            set {
                if ((this.SiraNoField.Equals(value) != true)) {
                    this.SiraNoField = value;
                    this.RaisePropertyChanged("SiraNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UnvanAciklama {
            get {
                return this.UnvanAciklamaField;
            }
            set {
                if ((object.ReferenceEquals(this.UnvanAciklamaField, value) != true)) {
                    this.UnvanAciklamaField = value;
                    this.RaisePropertyChanged("UnvanAciklama");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonelSube", Namespace="http://schemas.datacontract.org/2004/07/IK.Entities")]
    [System.SerializableAttribute()]
    public partial class PersonelSube : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PersonelSubeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubeAdiField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubeKoduField;
        
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
        public int PersonelSubeId {
            get {
                return this.PersonelSubeIdField;
            }
            set {
                if ((this.PersonelSubeIdField.Equals(value) != true)) {
                    this.PersonelSubeIdField = value;
                    this.RaisePropertyChanged("PersonelSubeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubeAdi {
            get {
                return this.SubeAdiField;
            }
            set {
                if ((object.ReferenceEquals(this.SubeAdiField, value) != true)) {
                    this.SubeAdiField = value;
                    this.RaisePropertyChanged("SubeAdi");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubeKodu {
            get {
                return this.SubeKoduField;
            }
            set {
                if ((object.ReferenceEquals(this.SubeKoduField, value) != true)) {
                    this.SubeKoduField = value;
                    this.RaisePropertyChanged("SubeKodu");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceIK.IServicePersonel")]
    public interface IServicePersonel {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePersonel/GetPersonelBilgiList", ReplyAction="http://tempuri.org/IServicePersonel/GetPersonelBilgiListResponse")]
        KaliteGiris.Web.ServiceReferenceIK.PersonelBilgi[] GetPersonelBilgiList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePersonel/GetPersonelBilgiList", ReplyAction="http://tempuri.org/IServicePersonel/GetPersonelBilgiListResponse")]
        System.Threading.Tasks.Task<KaliteGiris.Web.ServiceReferenceIK.PersonelBilgi[]> GetPersonelBilgiListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePersonel/CheckUser", ReplyAction="http://tempuri.org/IServicePersonel/CheckUserResponse")]
        KaliteGiris.Web.ServiceReferenceIK.PersonelBilgi CheckUser(string kullaniciAdi, string sifre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePersonel/CheckUser", ReplyAction="http://tempuri.org/IServicePersonel/CheckUserResponse")]
        System.Threading.Tasks.Task<KaliteGiris.Web.ServiceReferenceIK.PersonelBilgi> CheckUserAsync(string kullaniciAdi, string sifre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePersonel/GetDepartmanListesi", ReplyAction="http://tempuri.org/IServicePersonel/GetDepartmanListesiResponse")]
        KaliteGiris.Web.ServiceReferenceIK.PersonelDepartman[] GetDepartmanListesi();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePersonel/GetDepartmanListesi", ReplyAction="http://tempuri.org/IServicePersonel/GetDepartmanListesiResponse")]
        System.Threading.Tasks.Task<KaliteGiris.Web.ServiceReferenceIK.PersonelDepartman[]> GetDepartmanListesiAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePersonel/GetUnvanList", ReplyAction="http://tempuri.org/IServicePersonel/GetUnvanListResponse")]
        KaliteGiris.Web.ServiceReferenceIK.PersonelUnvan[] GetUnvanList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePersonel/GetUnvanList", ReplyAction="http://tempuri.org/IServicePersonel/GetUnvanListResponse")]
        System.Threading.Tasks.Task<KaliteGiris.Web.ServiceReferenceIK.PersonelUnvan[]> GetUnvanListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePersonel/GetSubeList", ReplyAction="http://tempuri.org/IServicePersonel/GetSubeListResponse")]
        KaliteGiris.Web.ServiceReferenceIK.PersonelSube[] GetSubeList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePersonel/GetSubeList", ReplyAction="http://tempuri.org/IServicePersonel/GetSubeListResponse")]
        System.Threading.Tasks.Task<KaliteGiris.Web.ServiceReferenceIK.PersonelSube[]> GetSubeListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicePersonelChannel : KaliteGiris.Web.ServiceReferenceIK.IServicePersonel, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePersonelClient : System.ServiceModel.ClientBase<KaliteGiris.Web.ServiceReferenceIK.IServicePersonel>, KaliteGiris.Web.ServiceReferenceIK.IServicePersonel {
        
        public ServicePersonelClient() {
        }
        
        public ServicePersonelClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePersonelClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePersonelClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePersonelClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public KaliteGiris.Web.ServiceReferenceIK.PersonelBilgi[] GetPersonelBilgiList() {
            return base.Channel.GetPersonelBilgiList();
        }
        
        public System.Threading.Tasks.Task<KaliteGiris.Web.ServiceReferenceIK.PersonelBilgi[]> GetPersonelBilgiListAsync() {
            return base.Channel.GetPersonelBilgiListAsync();
        }
        
        public KaliteGiris.Web.ServiceReferenceIK.PersonelBilgi CheckUser(string kullaniciAdi, string sifre) {
            return base.Channel.CheckUser(kullaniciAdi, sifre);
        }
        
        public System.Threading.Tasks.Task<KaliteGiris.Web.ServiceReferenceIK.PersonelBilgi> CheckUserAsync(string kullaniciAdi, string sifre) {
            return base.Channel.CheckUserAsync(kullaniciAdi, sifre);
        }
        
        public KaliteGiris.Web.ServiceReferenceIK.PersonelDepartman[] GetDepartmanListesi() {
            return base.Channel.GetDepartmanListesi();
        }
        
        public System.Threading.Tasks.Task<KaliteGiris.Web.ServiceReferenceIK.PersonelDepartman[]> GetDepartmanListesiAsync() {
            return base.Channel.GetDepartmanListesiAsync();
        }
        
        public KaliteGiris.Web.ServiceReferenceIK.PersonelUnvan[] GetUnvanList() {
            return base.Channel.GetUnvanList();
        }
        
        public System.Threading.Tasks.Task<KaliteGiris.Web.ServiceReferenceIK.PersonelUnvan[]> GetUnvanListAsync() {
            return base.Channel.GetUnvanListAsync();
        }
        
        public KaliteGiris.Web.ServiceReferenceIK.PersonelSube[] GetSubeList() {
            return base.Channel.GetSubeList();
        }
        
        public System.Threading.Tasks.Task<KaliteGiris.Web.ServiceReferenceIK.PersonelSube[]> GetSubeListAsync() {
            return base.Channel.GetSubeListAsync();
        }
    }
}