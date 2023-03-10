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
    /// There are no comments for ValueMappingCommunicationDataSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ValueMappingCommunicationDataSingle")]
    public partial class ValueMappingCommunicationDataSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ValueMappingCommunicationData>
    {
        /// <summary>
        /// Initialize a new ValueMappingCommunicationDataSingle object.
        /// </summary>
        public ValueMappingCommunicationDataSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ValueMappingCommunicationDataSingle object.
        /// </summary>
        public ValueMappingCommunicationDataSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ValueMappingCommunicationDataSingle object.
        /// </summary>
        public ValueMappingCommunicationDataSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ValueMappingCommunicationData> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ValueMappingCommunicationData in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AbsEntry
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AbsEntry")]
    [global::Microsoft.OData.Client.EntitySet("ValueMappingCommunication")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ValueMappingCommunicationData")]
    public partial class ValueMappingCommunicationData : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ValueMappingCommunicationData object.
        /// </summary>
        /// <param name="absEntry">Initial value of AbsEntry.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ValueMappingCommunicationData CreateValueMappingCommunicationData(int absEntry)
        {
            ValueMappingCommunicationData valueMappingCommunicationData = new ValueMappingCommunicationData();
            valueMappingCommunicationData.AbsEntry = absEntry;
            return valueMappingCommunicationData;
        }
        /// <summary>
        /// There are no comments for Property AbsEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AbsEntry")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AbsEntry is required.")]
        public virtual int AbsEntry
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
        private int _AbsEntry;
        partial void OnAbsEntryChanging(int value);
        partial void OnAbsEntryChanged();
        /// <summary>
        /// There are no comments for Property ThirdPartySystemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ThirdPartySystemId")]
        public virtual global::System.Nullable<int> ThirdPartySystemId
        {
            get
            {
                return this._ThirdPartySystemId;
            }
            set
            {
                this.OnThirdPartySystemIdChanging(value);
                this._ThirdPartySystemId = value;
                this.OnThirdPartySystemIdChanged();
                this.OnPropertyChanged("ThirdPartySystemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ThirdPartySystemId;
        partial void OnThirdPartySystemIdChanging(global::System.Nullable<int> value);
        partial void OnThirdPartySystemIdChanged();
        /// <summary>
        /// There are no comments for Property ObjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ObjectId")]
        public virtual global::System.Nullable<int> ObjectId
        {
            get
            {
                return this._ObjectId;
            }
            set
            {
                this.OnObjectIdChanging(value);
                this._ObjectId = value;
                this.OnObjectIdChanged();
                this.OnPropertyChanged("ObjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ObjectId;
        partial void OnObjectIdChanging(global::System.Nullable<int> value);
        partial void OnObjectIdChanged();
        /// <summary>
        /// There are no comments for Property CommunicationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CommunicationType")]
        public virtual global::System.Nullable<global::SAPB1.VMCommunicationTypeEnum> CommunicationType
        {
            get
            {
                return this._CommunicationType;
            }
            set
            {
                this.OnCommunicationTypeChanging(value);
                this._CommunicationType = value;
                this.OnCommunicationTypeChanged();
                this.OnPropertyChanged("CommunicationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.VMCommunicationTypeEnum> _CommunicationType;
        partial void OnCommunicationTypeChanging(global::System.Nullable<global::SAPB1.VMCommunicationTypeEnum> value);
        partial void OnCommunicationTypeChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _StartDate;
        partial void OnStartDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property StartTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartTime")]
        public virtual global::System.Nullable<int> StartTime
        {
            get
            {
                return this._StartTime;
            }
            set
            {
                this.OnStartTimeChanging(value);
                this._StartTime = value;
                this.OnStartTimeChanged();
                this.OnPropertyChanged("StartTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _StartTime;
        partial void OnStartTimeChanging(global::System.Nullable<int> value);
        partial void OnStartTimeChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this._EndDate = value;
                this.OnEndDateChanged();
                this.OnPropertyChanged("EndDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _EndDate;
        partial void OnEndDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property EndTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndTime")]
        public virtual global::System.Nullable<int> EndTime
        {
            get
            {
                return this._EndTime;
            }
            set
            {
                this.OnEndTimeChanging(value);
                this._EndTime = value;
                this.OnEndTimeChanged();
                this.OnPropertyChanged("EndTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _EndTime;
        partial void OnEndTimeChanging(global::System.Nullable<int> value);
        partial void OnEndTimeChanged();
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
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::SAPB1.VMCommunicationStatusEnum> Status
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
        private global::System.Nullable<global::SAPB1.VMCommunicationStatusEnum> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::SAPB1.VMCommunicationStatusEnum> value);
        partial void OnStatusChanged();
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
