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
    /// There are no comments for EcmActionLog in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EcmActionLog")]
    public partial class EcmActionLog : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property ActionID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActionID")]
        public virtual global::System.Nullable<int> ActionID
        {
            get
            {
                return this._ActionID;
            }
            set
            {
                this.OnActionIDChanging(value);
                this._ActionID = value;
                this.OnActionIDChanged();
                this.OnPropertyChanged("ActionID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ActionID;
        partial void OnActionIDChanging(global::System.Nullable<int> value);
        partial void OnActionIDChanged();
        /// <summary>
        /// There are no comments for Property LogID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LogID")]
        public virtual global::System.Nullable<int> LogID
        {
            get
            {
                return this._LogID;
            }
            set
            {
                this.OnLogIDChanging(value);
                this._LogID = value;
                this.OnLogIDChanged();
                this.OnPropertyChanged("LogID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _LogID;
        partial void OnLogIDChanging(global::System.Nullable<int> value);
        partial void OnLogIDChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::SAPB1.EcmActionLogTypeEnum> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.EcmActionLogTypeEnum> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::SAPB1.EcmActionLogTypeEnum> value);
        partial void OnTypeChanged();
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
        /// There are no comments for Property Data in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Data")]
        public virtual string Data
        {
            get
            {
                return this._Data;
            }
            set
            {
                this.OnDataChanging(value);
                this._Data = value;
                this.OnDataChanged();
                this.OnPropertyChanged("Data");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Data;
        partial void OnDataChanging(string value);
        partial void OnDataChanged();
        /// <summary>
        /// There are no comments for Property LogDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LogDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> LogDate
        {
            get
            {
                return this._LogDate;
            }
            set
            {
                this.OnLogDateChanging(value);
                this._LogDate = value;
                this.OnLogDateChanged();
                this.OnPropertyChanged("LogDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _LogDate;
        partial void OnLogDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnLogDateChanged();
        /// <summary>
        /// There are no comments for Property LogTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LogTime")]
        public virtual global::System.Nullable<int> LogTime
        {
            get
            {
                return this._LogTime;
            }
            set
            {
                this.OnLogTimeChanging(value);
                this._LogTime = value;
                this.OnLogTimeChanged();
                this.OnPropertyChanged("LogTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _LogTime;
        partial void OnLogTimeChanging(global::System.Nullable<int> value);
        partial void OnLogTimeChanged();
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
