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
    /// There are no comments for ChecksforPaymentPrintStatus in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ChecksforPaymentPrintStatus")]
    public partial class ChecksforPaymentPrintStatus : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property DocEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocEntry")]
        public virtual global::System.Nullable<int> DocEntry
        {
            get
            {
                return this._DocEntry;
            }
            set
            {
                this.OnDocEntryChanging(value);
                this._DocEntry = value;
                this.OnDocEntryChanged();
                this.OnPropertyChanged("DocEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DocEntry;
        partial void OnDocEntryChanging(global::System.Nullable<int> value);
        partial void OnDocEntryChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        public virtual global::System.Nullable<int> LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _LineNumber;
        partial void OnLineNumberChanging(global::System.Nullable<int> value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property CheckNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckNumber")]
        public virtual global::System.Nullable<int> CheckNumber
        {
            get
            {
                return this._CheckNumber;
            }
            set
            {
                this.OnCheckNumberChanging(value);
                this._CheckNumber = value;
                this.OnCheckNumberChanged();
                this.OnPropertyChanged("CheckNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _CheckNumber;
        partial void OnCheckNumberChanging(global::System.Nullable<int> value);
        partial void OnCheckNumberChanged();
        /// <summary>
        /// There are no comments for Property PrintStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrintStatus")]
        public virtual string PrintStatus
        {
            get
            {
                return this._PrintStatus;
            }
            set
            {
                this.OnPrintStatusChanging(value);
                this._PrintStatus = value;
                this.OnPrintStatusChanged();
                this.OnPropertyChanged("PrintStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PrintStatus;
        partial void OnPrintStatusChanging(string value);
        partial void OnPrintStatusChanged();
        /// <summary>
        /// There are no comments for Property PrintedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrintedBy")]
        public virtual global::System.Nullable<int> PrintedBy
        {
            get
            {
                return this._PrintedBy;
            }
            set
            {
                this.OnPrintedByChanging(value);
                this._PrintedBy = value;
                this.OnPrintedByChanged();
                this.OnPropertyChanged("PrintedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _PrintedBy;
        partial void OnPrintedByChanging(global::System.Nullable<int> value);
        partial void OnPrintedByChanged();
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