//------------------------------------------------------------------------------
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
    /// There are no comments for EDFEntryAddLogInputParams in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EDFEntryAddLogInputParams")]
    public partial class EDFEntryAddLogInputParams : global::System.ComponentModel.INotifyPropertyChanged
    {
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
        /// There are no comments for Property LogType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LogType")]
        public virtual global::System.Nullable<global::SAPB1.ElectronicDocumentEntryLogTypeEnum> LogType
        {
            get
            {
                return this._LogType;
            }
            set
            {
                this.OnLogTypeChanging(value);
                this._LogType = value;
                this.OnLogTypeChanged();
                this.OnPropertyChanged("LogType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ElectronicDocumentEntryLogTypeEnum> _LogType;
        partial void OnLogTypeChanging(global::System.Nullable<global::SAPB1.ElectronicDocumentEntryLogTypeEnum> value);
        partial void OnLogTypeChanged();
        /// <summary>
        /// There are no comments for Property LogMessage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LogMessage")]
        public virtual string LogMessage
        {
            get
            {
                return this._LogMessage;
            }
            set
            {
                this.OnLogMessageChanging(value);
                this._LogMessage = value;
                this.OnLogMessageChanged();
                this.OnPropertyChanged("LogMessage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LogMessage;
        partial void OnLogMessageChanging(string value);
        partial void OnLogMessageChanged();
        /// <summary>
        /// There are no comments for Property LogData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LogData")]
        public virtual string LogData
        {
            get
            {
                return this._LogData;
            }
            set
            {
                this.OnLogDataChanging(value);
                this._LogData = value;
                this.OnLogDataChanged();
                this.OnPropertyChanged("LogData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LogData;
        partial void OnLogDataChanging(string value);
        partial void OnLogDataChanged();
        /// <summary>
        /// There are no comments for Property ExportFormat in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExportFormat")]
        public virtual global::System.Nullable<int> ExportFormat
        {
            get
            {
                return this._ExportFormat;
            }
            set
            {
                this.OnExportFormatChanging(value);
                this._ExportFormat = value;
                this.OnExportFormatChanged();
                this.OnPropertyChanged("ExportFormat");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ExportFormat;
        partial void OnExportFormatChanging(global::System.Nullable<int> value);
        partial void OnExportFormatChanged();
        /// <summary>
        /// There are no comments for Property LogDataContentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LogDataContentType")]
        public virtual global::System.Nullable<global::SAPB1.ElectronicDocumentBlobContentTypeEnum> LogDataContentType
        {
            get
            {
                return this._LogDataContentType;
            }
            set
            {
                this.OnLogDataContentTypeChanging(value);
                this._LogDataContentType = value;
                this.OnLogDataContentTypeChanged();
                this.OnPropertyChanged("LogDataContentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ElectronicDocumentBlobContentTypeEnum> _LogDataContentType;
        partial void OnLogDataContentTypeChanging(global::System.Nullable<global::SAPB1.ElectronicDocumentBlobContentTypeEnum> value);
        partial void OnLogDataContentTypeChanged();
        /// <summary>
        /// There are no comments for Property ZipLogData in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ZipLogData")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> ZipLogData
        {
            get
            {
                return this._ZipLogData;
            }
            set
            {
                this.OnZipLogDataChanging(value);
                this._ZipLogData = value;
                this.OnZipLogDataChanged();
                this.OnPropertyChanged("ZipLogData");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _ZipLogData;
        partial void OnZipLogDataChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnZipLogDataChanged();
        /// <summary>
        /// There are no comments for Property ExportFile in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExportFile")]
        public virtual string ExportFile
        {
            get
            {
                return this._ExportFile;
            }
            set
            {
                this.OnExportFileChanging(value);
                this._ExportFile = value;
                this.OnExportFileChanged();
                this.OnPropertyChanged("ExportFile");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExportFile;
        partial void OnExportFileChanging(string value);
        partial void OnExportFileChanged();
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
