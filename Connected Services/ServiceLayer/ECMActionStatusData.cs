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
    /// There are no comments for ECMActionStatusData in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ECMActionStatusData")]
    public partial class ECMActionStatusData : global::System.ComponentModel.INotifyPropertyChanged
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
        /// There are no comments for Property ActStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActStatus")]
        public virtual global::System.Nullable<global::SAPB1.EcmActionStatusEnum> ActStatus
        {
            get
            {
                return this._ActStatus;
            }
            set
            {
                this.OnActStatusChanging(value);
                this._ActStatus = value;
                this.OnActStatusChanged();
                this.OnPropertyChanged("ActStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.EcmActionStatusEnum> _ActStatus;
        partial void OnActStatusChanging(global::System.Nullable<global::SAPB1.EcmActionStatusEnum> value);
        partial void OnActStatusChanged();
        /// <summary>
        /// There are no comments for Property ReportID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportID")]
        public virtual string ReportID
        {
            get
            {
                return this._ReportID;
            }
            set
            {
                this.OnReportIDChanging(value);
                this._ReportID = value;
                this.OnReportIDChanged();
                this.OnPropertyChanged("ReportID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportID;
        partial void OnReportIDChanging(string value);
        partial void OnReportIDChanged();
        /// <summary>
        /// There are no comments for Property ReceivDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReceivDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> ReceivDate
        {
            get
            {
                return this._ReceivDate;
            }
            set
            {
                this.OnReceivDateChanging(value);
                this._ReceivDate = value;
                this.OnReceivDateChanged();
                this.OnPropertyChanged("ReceivDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _ReceivDate;
        partial void OnReceivDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnReceivDateChanged();
        /// <summary>
        /// There are no comments for Property ActMessage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActMessage")]
        public virtual string ActMessage
        {
            get
            {
                return this._ActMessage;
            }
            set
            {
                this.OnActMessageChanging(value);
                this._ActMessage = value;
                this.OnActMessageChanged();
                this.OnPropertyChanged("ActMessage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActMessage;
        partial void OnActMessageChanging(string value);
        partial void OnActMessageChanged();
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
