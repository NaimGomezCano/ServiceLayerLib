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
    /// There are no comments for ServiceContract_Line in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceContract_Line")]
    public partial class ServiceContract_Line : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property LineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNum")]
        public virtual global::System.Nullable<int> LineNum
        {
            get
            {
                return this._LineNum;
            }
            set
            {
                this.OnLineNumChanging(value);
                this._LineNum = value;
                this.OnLineNumChanged();
                this.OnPropertyChanged("LineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _LineNum;
        partial void OnLineNumChanging(global::System.Nullable<int> value);
        partial void OnLineNumChanged();
        /// <summary>
        /// There are no comments for Property ManufacturerSerialNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ManufacturerSerialNum")]
        public virtual string ManufacturerSerialNum
        {
            get
            {
                return this._ManufacturerSerialNum;
            }
            set
            {
                this.OnManufacturerSerialNumChanging(value);
                this._ManufacturerSerialNum = value;
                this.OnManufacturerSerialNumChanged();
                this.OnPropertyChanged("ManufacturerSerialNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ManufacturerSerialNum;
        partial void OnManufacturerSerialNumChanging(string value);
        partial void OnManufacturerSerialNumChanged();
        /// <summary>
        /// There are no comments for Property InternalSerialNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InternalSerialNum")]
        public virtual string InternalSerialNum
        {
            get
            {
                return this._InternalSerialNum;
            }
            set
            {
                this.OnInternalSerialNumChanging(value);
                this._InternalSerialNum = value;
                this.OnInternalSerialNumChanged();
                this.OnPropertyChanged("InternalSerialNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InternalSerialNum;
        partial void OnInternalSerialNumChanging(string value);
        partial void OnInternalSerialNumChanged();
        /// <summary>
        /// There are no comments for Property ItemCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemCode")]
        public virtual string ItemCode
        {
            get
            {
                return this._ItemCode;
            }
            set
            {
                this.OnItemCodeChanging(value);
                this._ItemCode = value;
                this.OnItemCodeChanged();
                this.OnPropertyChanged("ItemCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemCode;
        partial void OnItemCodeChanging(string value);
        partial void OnItemCodeChanged();
        /// <summary>
        /// There are no comments for Property ItemName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemName")]
        public virtual string ItemName
        {
            get
            {
                return this._ItemName;
            }
            set
            {
                this.OnItemNameChanging(value);
                this._ItemName = value;
                this.OnItemNameChanged();
                this.OnPropertyChanged("ItemName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemName;
        partial void OnItemNameChanging(string value);
        partial void OnItemNameChanged();
        /// <summary>
        /// There are no comments for Property ItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemGroup")]
        public virtual global::System.Nullable<int> ItemGroup
        {
            get
            {
                return this._ItemGroup;
            }
            set
            {
                this.OnItemGroupChanging(value);
                this._ItemGroup = value;
                this.OnItemGroupChanged();
                this.OnPropertyChanged("ItemGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ItemGroup;
        partial void OnItemGroupChanging(global::System.Nullable<int> value);
        partial void OnItemGroupChanged();
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
        /// There are no comments for Property ItemGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemGroupName")]
        public virtual string ItemGroupName
        {
            get
            {
                return this._ItemGroupName;
            }
            set
            {
                this.OnItemGroupNameChanging(value);
                this._ItemGroupName = value;
                this.OnItemGroupNameChanged();
                this.OnPropertyChanged("ItemGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemGroupName;
        partial void OnItemGroupNameChanging(string value);
        partial void OnItemGroupNameChanged();
        /// <summary>
        /// There are no comments for Property TerminationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TerminationDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> TerminationDate
        {
            get
            {
                return this._TerminationDate;
            }
            set
            {
                this.OnTerminationDateChanging(value);
                this._TerminationDate = value;
                this.OnTerminationDateChanged();
                this.OnPropertyChanged("TerminationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _TerminationDate;
        partial void OnTerminationDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnTerminationDateChanged();
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