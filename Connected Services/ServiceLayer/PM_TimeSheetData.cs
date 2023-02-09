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
    /// There are no comments for PM_TimeSheetDataSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PM_TimeSheetDataSingle")]
    public partial class PM_TimeSheetDataSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PM_TimeSheetData>
    {
        /// <summary>
        /// Initialize a new PM_TimeSheetDataSingle object.
        /// </summary>
        public PM_TimeSheetDataSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PM_TimeSheetDataSingle object.
        /// </summary>
        public PM_TimeSheetDataSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PM_TimeSheetDataSingle object.
        /// </summary>
        public PM_TimeSheetDataSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PM_TimeSheetData> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EmployeeInfo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeeInfo")]
        public virtual global::SAPB1.EmployeeInfoSingle EmployeeInfo
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmployeeInfo == null))
                {
                    this._EmployeeInfo = new global::SAPB1.EmployeeInfoSingle(this.Context, GetPath("EmployeeInfo"));
                }
                return this._EmployeeInfo;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.EmployeeInfoSingle _EmployeeInfo;
        /// <summary>
        /// There are no comments for Attachments2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Attachments2")]
        public virtual global::SAPB1.Attachments2Single Attachments2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Attachments2 == null))
                {
                    this._Attachments2 = new global::SAPB1.Attachments2Single(this.Context, GetPath("Attachments2"));
                }
                return this._Attachments2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.Attachments2Single _Attachments2;
    }
    /// <summary>
    /// There are no comments for PM_TimeSheetData in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AbsEntry
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AbsEntry")]
    [global::Microsoft.OData.Client.EntitySet("ProjectManagementTimeSheet")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PM_TimeSheetData")]
    public partial class PM_TimeSheetData : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PM_TimeSheetData object.
        /// </summary>
        /// <param name="absEntry">Initial value of AbsEntry.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PM_TimeSheetData CreatePM_TimeSheetData(int absEntry)
        {
            PM_TimeSheetData pM_TimeSheetData = new PM_TimeSheetData();
            pM_TimeSheetData.AbsEntry = absEntry;
            return pM_TimeSheetData;
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
        /// There are no comments for Property DocNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocNumber")]
        public virtual global::System.Nullable<int> DocNumber
        {
            get
            {
                return this._DocNumber;
            }
            set
            {
                this.OnDocNumberChanging(value);
                this._DocNumber = value;
                this.OnDocNumberChanged();
                this.OnPropertyChanged("DocNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DocNumber;
        partial void OnDocNumberChanging(global::System.Nullable<int> value);
        partial void OnDocNumberChanged();
        /// <summary>
        /// There are no comments for Property TimeSheetType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TimeSheetType")]
        public virtual global::System.Nullable<global::SAPB1.TimeSheetTypeEnum> TimeSheetType
        {
            get
            {
                return this._TimeSheetType;
            }
            set
            {
                this.OnTimeSheetTypeChanging(value);
                this._TimeSheetType = value;
                this.OnTimeSheetTypeChanged();
                this.OnPropertyChanged("TimeSheetType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.TimeSheetTypeEnum> _TimeSheetType;
        partial void OnTimeSheetTypeChanging(global::System.Nullable<global::SAPB1.TimeSheetTypeEnum> value);
        partial void OnTimeSheetTypeChanged();
        /// <summary>
        /// There are no comments for Property UserID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserID")]
        public virtual global::System.Nullable<int> UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                this.OnUserIDChanging(value);
                this._UserID = value;
                this.OnUserIDChanged();
                this.OnPropertyChanged("UserID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _UserID;
        partial void OnUserIDChanging(global::System.Nullable<int> value);
        partial void OnUserIDChanged();
        /// <summary>
        /// There are no comments for Property LastName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LastName")]
        public virtual string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this.OnLastNameChanging(value);
                this._LastName = value;
                this.OnLastNameChanged();
                this.OnPropertyChanged("LastName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LastName;
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        /// <summary>
        /// There are no comments for Property FirstName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FirstName")]
        public virtual string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this.OnFirstNameChanging(value);
                this._FirstName = value;
                this.OnFirstNameChanged();
                this.OnPropertyChanged("FirstName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FirstName;
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        /// <summary>
        /// There are no comments for Property Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Department")]
        public virtual global::System.Nullable<int> Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                this.OnDepartmentChanging(value);
                this._Department = value;
                this.OnDepartmentChanged();
                this.OnPropertyChanged("Department");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Department;
        partial void OnDepartmentChanging(global::System.Nullable<int> value);
        partial void OnDepartmentChanged();
        /// <summary>
        /// There are no comments for Property DateFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateFrom")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DateFrom
        {
            get
            {
                return this._DateFrom;
            }
            set
            {
                this.OnDateFromChanging(value);
                this._DateFrom = value;
                this.OnDateFromChanged();
                this.OnPropertyChanged("DateFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DateFrom;
        partial void OnDateFromChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDateFromChanged();
        /// <summary>
        /// There are no comments for Property DateTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateTo")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DateTo
        {
            get
            {
                return this._DateTo;
            }
            set
            {
                this.OnDateToChanging(value);
                this._DateTo = value;
                this.OnDateToChanged();
                this.OnPropertyChanged("DateTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DateTo;
        partial void OnDateToChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDateToChanged();
        /// <summary>
        /// There are no comments for Property SAPPassport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SAPPassport")]
        public virtual string SAPPassport
        {
            get
            {
                return this._SAPPassport;
            }
            set
            {
                this.OnSAPPassportChanging(value);
                this._SAPPassport = value;
                this.OnSAPPassportChanged();
                this.OnPropertyChanged("SAPPassport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SAPPassport;
        partial void OnSAPPassportChanging(string value);
        partial void OnSAPPassportChanged();
        /// <summary>
        /// There are no comments for Property AttachmentEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttachmentEntry")]
        public virtual global::System.Nullable<int> AttachmentEntry
        {
            get
            {
                return this._AttachmentEntry;
            }
            set
            {
                this.OnAttachmentEntryChanging(value);
                this._AttachmentEntry = value;
                this.OnAttachmentEntryChanged();
                this.OnPropertyChanged("AttachmentEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _AttachmentEntry;
        partial void OnAttachmentEntryChanging(global::System.Nullable<int> value);
        partial void OnAttachmentEntryChanged();
        /// <summary>
        /// There are no comments for Property UserCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserCode")]
        public virtual string UserCode
        {
            get
            {
                return this._UserCode;
            }
            set
            {
                this.OnUserCodeChanging(value);
                this._UserCode = value;
                this.OnUserCodeChanged();
                this.OnPropertyChanged("UserCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserCode;
        partial void OnUserCodeChanging(string value);
        partial void OnUserCodeChanged();
        /// <summary>
        /// There are no comments for Property PM_TimeSheetLineDataCollection in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PM_TimeSheetLineDataCollection")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.PM_TimeSheetLineData> PM_TimeSheetLineDataCollection
        {
            get
            {
                return this._PM_TimeSheetLineDataCollection;
            }
            set
            {
                this.OnPM_TimeSheetLineDataCollectionChanging(value);
                this._PM_TimeSheetLineDataCollection = value;
                this.OnPM_TimeSheetLineDataCollectionChanged();
                this.OnPropertyChanged("PM_TimeSheetLineDataCollection");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.PM_TimeSheetLineData> _PM_TimeSheetLineDataCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.PM_TimeSheetLineData>();
        partial void OnPM_TimeSheetLineDataCollectionChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.PM_TimeSheetLineData> value);
        partial void OnPM_TimeSheetLineDataCollectionChanged();
        /// <summary>
        /// There are no comments for Property EmployeeInfo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeeInfo")]
        public virtual global::SAPB1.EmployeeInfo EmployeeInfo
        {
            get
            {
                return this._EmployeeInfo;
            }
            set
            {
                this.OnEmployeeInfoChanging(value);
                this._EmployeeInfo = value;
                this.OnEmployeeInfoChanged();
                this.OnPropertyChanged("EmployeeInfo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.EmployeeInfo _EmployeeInfo;
        partial void OnEmployeeInfoChanging(global::SAPB1.EmployeeInfo value);
        partial void OnEmployeeInfoChanged();
        /// <summary>
        /// There are no comments for Property Attachments2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Attachments2")]
        public virtual global::SAPB1.Attachments2 Attachments2
        {
            get
            {
                return this._Attachments2;
            }
            set
            {
                this.OnAttachments2Changing(value);
                this._Attachments2 = value;
                this.OnAttachments2Changed();
                this.OnPropertyChanged("Attachments2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.Attachments2 _Attachments2;
        partial void OnAttachments2Changing(global::SAPB1.Attachments2 value);
        partial void OnAttachments2Changed();
        /// <summary>
        /// There are no comments for Property DynamicProperties in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DynamicProperties")]
        public virtual global::System.Collections.Generic.IDictionary<string, object> DynamicProperties
        {
            get
            {
                return this._DynamicProperties;
            }
            set
            {
                this.OnDynamicPropertiesChanging(value);
                this._DynamicProperties = value;
                this.OnDynamicPropertiesChanged();
                this.OnPropertyChanged("DynamicProperties");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.Generic.IDictionary<string, object> _DynamicProperties = new global::System.Collections.Generic.Dictionary<string, object>();
        partial void OnDynamicPropertiesChanging(global::System.Collections.Generic.IDictionary<string, object> value);
        partial void OnDynamicPropertiesChanged();
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