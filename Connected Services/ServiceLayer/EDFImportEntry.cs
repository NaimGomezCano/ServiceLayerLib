﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/9/2023 12:16:29 PM
namespace SAPB1
{
    /// <summary>
    /// There are no comments for EDFImportEntry in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EDFImportEntry")]
    public partial class EDFImportEntry : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property AbsEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AbsEntry")]
        public virtual global::System.Nullable<int> AbsEntry
        {
            get
            {
                return this._AbsEntry;
            }
            set
            {
                this.OnAbsEntryChanging(value);
                this._AbsEntry = value;
                this.OnAbsEntryChanged();
                this.OnPropertyChanged("AbsEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _AbsEntry;
        partial void OnAbsEntryChanging(global::System.Nullable<int> value);
        partial void OnAbsEntryChanged();
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        public virtual global::System.Nullable<global::SAPB1.ElectronicDocProtocolCodeStrEnum> Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                this.OnCodeChanging(value);
                this._Code = value;
                this.OnCodeChanged();
                this.OnPropertyChanged("Code");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ElectronicDocProtocolCodeStrEnum> _Code;
        partial void OnCodeChanging(global::System.Nullable<global::SAPB1.ElectronicDocProtocolCodeStrEnum> value);
        partial void OnCodeChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::SAPB1.ElectronicDocumentEntryStatusEnum> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ElectronicDocumentEntryStatusEnum> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::SAPB1.ElectronicDocumentEntryStatusEnum> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property Message in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Message")]
        public virtual string Message
        {
            get
            {
                return this._Message;
            }
            set
            {
                this.OnMessageChanging(value);
                this._Message = value;
                this.OnMessageChanged();
                this.OnPropertyChanged("Message");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Message;
        partial void OnMessageChanging(string value);
        partial void OnMessageChanged();
        /// <summary>
        /// There are no comments for Property TestMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TestMode")]
        public virtual string TestMode
        {
            get
            {
                return this._TestMode;
            }
            set
            {
                this.OnTestModeChanging(value);
                this._TestMode = value;
                this.OnTestModeChanged();
                this.OnPropertyChanged("TestMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TestMode;
        partial void OnTestModeChanging(string value);
        partial void OnTestModeChanged();
        /// <summary>
        /// There are no comments for Property GUID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GUID")]
        public virtual string GUID
        {
            get
            {
                return this._GUID;
            }
            set
            {
                this.OnGUIDChanging(value);
                this._GUID = value;
                this.OnGUIDChanged();
                this.OnPropertyChanged("GUID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GUID;
        partial void OnGUIDChanging(string value);
        partial void OnGUIDChanged();
        /// <summary>
        /// There are no comments for Property Authority in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Authority")]
        public virtual string Authority
        {
            get
            {
                return this._Authority;
            }
            set
            {
                this.OnAuthorityChanging(value);
                this._Authority = value;
                this.OnAuthorityChanged();
                this.OnPropertyChanged("Authority");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Authority;
        partial void OnAuthorityChanging(string value);
        partial void OnAuthorityChanged();
        /// <summary>
        /// There are no comments for Property ProcessingSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcessingSource")]
        public virtual string ProcessingSource
        {
            get
            {
                return this._ProcessingSource;
            }
            set
            {
                this.OnProcessingSourceChanging(value);
                this._ProcessingSource = value;
                this.OnProcessingSourceChanged();
                this.OnPropertyChanged("ProcessingSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProcessingSource;
        partial void OnProcessingSourceChanging(string value);
        partial void OnProcessingSourceChanged();
        /// <summary>
        /// There are no comments for Property MetaData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MetaData")]
        public virtual string MetaData
        {
            get
            {
                return this._MetaData;
            }
            set
            {
                this.OnMetaDataChanging(value);
                this._MetaData = value;
                this.OnMetaDataChanged();
                this.OnPropertyChanged("MetaData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MetaData;
        partial void OnMetaDataChanging(string value);
        partial void OnMetaDataChanged();
        /// <summary>
        /// There are no comments for Property CreateDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreateDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> CreateDate
        {
            get
            {
                return this._CreateDate;
            }
            set
            {
                this.OnCreateDateChanging(value);
                this._CreateDate = value;
                this.OnCreateDateChanged();
                this.OnPropertyChanged("CreateDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _CreateDate;
        partial void OnCreateDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnCreateDateChanged();
        /// <summary>
        /// There are no comments for Property CreateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreateTime")]
        public virtual global::System.Nullable<int> CreateTime
        {
            get
            {
                return this._CreateTime;
            }
            set
            {
                this.OnCreateTimeChanging(value);
                this._CreateTime = value;
                this.OnCreateTimeChanged();
                this.OnPropertyChanged("CreateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _CreateTime;
        partial void OnCreateTimeChanging(global::System.Nullable<int> value);
        partial void OnCreateTimeChanged();
        /// <summary>
        /// There are no comments for Property UpdateDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UpdateDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> UpdateDate
        {
            get
            {
                return this._UpdateDate;
            }
            set
            {
                this.OnUpdateDateChanging(value);
                this._UpdateDate = value;
                this.OnUpdateDateChanged();
                this.OnPropertyChanged("UpdateDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _UpdateDate;
        partial void OnUpdateDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnUpdateDateChanged();
        /// <summary>
        /// There are no comments for Property UpdateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UpdateTime")]
        public virtual global::System.Nullable<int> UpdateTime
        {
            get
            {
                return this._UpdateTime;
            }
            set
            {
                this.OnUpdateTimeChanging(value);
                this._UpdateTime = value;
                this.OnUpdateTimeChanged();
                this.OnPropertyChanged("UpdateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _UpdateTime;
        partial void OnUpdateTimeChanging(global::System.Nullable<int> value);
        partial void OnUpdateTimeChanged();
        /// <summary>
        /// There are no comments for Property User in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("User")]
        public virtual global::System.Nullable<int> User
        {
            get
            {
                return this._User;
            }
            set
            {
                this.OnUserChanging(value);
                this._User = value;
                this.OnUserChanged();
                this.OnPropertyChanged("User");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _User;
        partial void OnUserChanging(global::System.Nullable<int> value);
        partial void OnUserChanged();
        /// <summary>
        /// There are no comments for Property User2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("User2")]
        public virtual global::System.Nullable<int> User2
        {
            get
            {
                return this._User2;
            }
            set
            {
                this.OnUser2Changing(value);
                this._User2 = value;
                this.OnUser2Changed();
                this.OnPropertyChanged("User2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _User2;
        partial void OnUser2Changing(global::System.Nullable<int> value);
        partial void OnUser2Changed();
        /// <summary>
        /// There are no comments for Property MimeType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MimeType")]
        public virtual string MimeType
        {
            get
            {
                return this._MimeType;
            }
            set
            {
                this.OnMimeTypeChanging(value);
                this._MimeType = value;
                this.OnMimeTypeChanged();
                this.OnPropertyChanged("MimeType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MimeType;
        partial void OnMimeTypeChanging(string value);
        partial void OnMimeTypeChanged();
        /// <summary>
        /// There are no comments for Property FileName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FileName")]
        public virtual string FileName
        {
            get
            {
                return this._FileName;
            }
            set
            {
                this.OnFileNameChanging(value);
                this._FileName = value;
                this.OnFileNameChanged();
                this.OnPropertyChanged("FileName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FileName;
        partial void OnFileNameChanging(string value);
        partial void OnFileNameChanged();
        /// <summary>
        /// There are no comments for Property AssignedID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssignedID")]
        public virtual string AssignedID
        {
            get
            {
                return this._AssignedID;
            }
            set
            {
                this.OnAssignedIDChanging(value);
                this._AssignedID = value;
                this.OnAssignedIDChanged();
                this.OnPropertyChanged("AssignedID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AssignedID;
        partial void OnAssignedIDChanging(string value);
        partial void OnAssignedIDChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
