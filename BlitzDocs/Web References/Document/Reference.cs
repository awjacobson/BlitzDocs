﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace BlitzDocs.Document {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DocumentServiceSoap", Namespace="http://www.blitzdocs.net/Document.wsdl")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BlitzDataComponentProxy))]
    public partial class DocumentService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DocumentService() {
            this.Url = global::BlitzDocs.Properties.Settings.Default.BlitzDocs_Document_DocumentService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetCompletedEventHandler GetCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.blitzdocs.net/Document.wsdl/Get", RequestNamespace="http://www.blitzdocs.net/Document.wsdl", ResponseNamespace="http://www.blitzdocs.net/Document.wsdl", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DocumentProxy Get(int id) {
            object[] results = this.Invoke("Get", new object[] {
                        id});
            return ((DocumentProxy)(results[0]));
        }
        
        /// <remarks/>
        public void GetAsync(int id) {
            this.GetAsync(id, null);
        }
        
        /// <remarks/>
        public void GetAsync(int id, object userState) {
            if ((this.GetOperationCompleted == null)) {
                this.GetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetOperationCompleted);
            }
            this.InvokeAsync("Get", new object[] {
                        id}, this.GetOperationCompleted, userState);
        }
        
        private void OnGetOperationCompleted(object arg) {
            if ((this.GetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetCompleted(this, new GetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.blitzdocs.net/Document.wsdl")]
    public partial class DocumentProxy : BlitzDocsComponentProxy {
        
        private short contentTypeIdField;
        
        private string createdByLoginIdField;
        
        private System.Guid createdByUserIdField;
        
        private System.DateTime createdDateField;
        
        private int fileSizeField;
        
        private bool isBlitzDocsPdfField;
        
        private bool isLockedForEditField;
        
        private bool isLockedForViewField;
        
        private bool isLockedForPrintField;
        
        private bool isInvalidPdfField;
        
        private bool isUnlockedPdfField;
        
        private bool hasPageImagesCreatedField;
        
        private int idField;
        
        private System.DateTime lastUpdateField;
        
        private short pageCountField;
        
        private DocumentSourceType sourceTypeField;
        
        private PrimaryDocumentStorageStatus storageStatusField;
        
        private short storageVolumeIdField;
        
        /// <remarks/>
        public short ContentTypeId {
            get {
                return this.contentTypeIdField;
            }
            set {
                this.contentTypeIdField = value;
            }
        }
        
        /// <remarks/>
        public string CreatedByLoginId {
            get {
                return this.createdByLoginIdField;
            }
            set {
                this.createdByLoginIdField = value;
            }
        }
        
        /// <remarks/>
        public System.Guid CreatedByUserId {
            get {
                return this.createdByUserIdField;
            }
            set {
                this.createdByUserIdField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CreatedDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }
        
        /// <remarks/>
        public int FileSize {
            get {
                return this.fileSizeField;
            }
            set {
                this.fileSizeField = value;
            }
        }
        
        /// <remarks/>
        public bool IsBlitzDocsPdf {
            get {
                return this.isBlitzDocsPdfField;
            }
            set {
                this.isBlitzDocsPdfField = value;
            }
        }
        
        /// <remarks/>
        public bool IsLockedForEdit {
            get {
                return this.isLockedForEditField;
            }
            set {
                this.isLockedForEditField = value;
            }
        }
        
        /// <remarks/>
        public bool IsLockedForView {
            get {
                return this.isLockedForViewField;
            }
            set {
                this.isLockedForViewField = value;
            }
        }
        
        /// <remarks/>
        public bool IsLockedForPrint {
            get {
                return this.isLockedForPrintField;
            }
            set {
                this.isLockedForPrintField = value;
            }
        }
        
        /// <remarks/>
        public bool IsInvalidPdf {
            get {
                return this.isInvalidPdfField;
            }
            set {
                this.isInvalidPdfField = value;
            }
        }
        
        /// <remarks/>
        public bool IsUnlockedPdf {
            get {
                return this.isUnlockedPdfField;
            }
            set {
                this.isUnlockedPdfField = value;
            }
        }
        
        /// <remarks/>
        public bool HasPageImagesCreated {
            get {
                return this.hasPageImagesCreatedField;
            }
            set {
                this.hasPageImagesCreatedField = value;
            }
        }
        
        /// <remarks/>
        public int Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime LastUpdate {
            get {
                return this.lastUpdateField;
            }
            set {
                this.lastUpdateField = value;
            }
        }
        
        /// <remarks/>
        public short PageCount {
            get {
                return this.pageCountField;
            }
            set {
                this.pageCountField = value;
            }
        }
        
        /// <remarks/>
        public DocumentSourceType SourceType {
            get {
                return this.sourceTypeField;
            }
            set {
                this.sourceTypeField = value;
            }
        }
        
        /// <remarks/>
        public PrimaryDocumentStorageStatus StorageStatus {
            get {
                return this.storageStatusField;
            }
            set {
                this.storageStatusField = value;
            }
        }
        
        /// <remarks/>
        public short StorageVolumeId {
            get {
                return this.storageVolumeIdField;
            }
            set {
                this.storageVolumeIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.blitzdocs.net/Document.wsdl")]
    public enum DocumentSourceType {
        
        /// <remarks/>
        NotSet,
        
        /// <remarks/>
        Fax,
        
        /// <remarks/>
        Scan,
        
        /// <remarks/>
        Upload,
        
        /// <remarks/>
        Indexed,
        
        /// <remarks/>
        Import,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.blitzdocs.net/Document.wsdl")]
    public enum PrimaryDocumentStorageStatus {
        
        /// <remarks/>
        NotSet,
        
        /// <remarks/>
        Pending,
        
        /// <remarks/>
        Completed,
        
        /// <remarks/>
        ToBeDeleted,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentProxy))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.blitzdocs.net/Document.wsdl")]
    public abstract partial class BlitzDocsComponentProxy : BlitzDataComponentProxy {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BlitzDocsComponentProxy))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DocumentProxy))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.blitzdocs.net/Document.wsdl")]
    public abstract partial class BlitzDataComponentProxy {
        
        private DataStateType dataStateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DataStateType DataState {
            get {
                return this.dataStateField;
            }
            set {
                this.dataStateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.blitzdocs.net/Document.wsdl")]
    public enum DataStateType {
        
        /// <remarks/>
        Deleted,
        
        /// <remarks/>
        Detached,
        
        /// <remarks/>
        Modified,
        
        /// <remarks/>
        Unchanged,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void GetCompletedEventHandler(object sender, GetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DocumentProxy Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DocumentProxy)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591