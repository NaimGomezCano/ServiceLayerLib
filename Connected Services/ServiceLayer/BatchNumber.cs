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
    /// There are no comments for BatchNumber in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BatchNumber")]
    public partial class BatchNumber : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property BatchNumberProperty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BatchNumberProperty")]
        public virtual string BatchNumberProperty
        {
            get
            {
                return this._BatchNumberProperty;
            }
            set
            {
                this.OnBatchNumberPropertyChanging(value);
                this._BatchNumberProperty = value;
                this.OnBatchNumberPropertyChanged();
                this.OnPropertyChanged("BatchNumberProperty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BatchNumberProperty;
        partial void OnBatchNumberPropertyChanging(string value);
        partial void OnBatchNumberPropertyChanged();
        /// <summary>
        /// There are no comments for Property ManufacturerSerialNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ManufacturerSerialNumber")]
        public virtual string ManufacturerSerialNumber
        {
            get
            {
                return this._ManufacturerSerialNumber;
            }
            set
            {
                this.OnManufacturerSerialNumberChanging(value);
                this._ManufacturerSerialNumber = value;
                this.OnManufacturerSerialNumberChanged();
                this.OnPropertyChanged("ManufacturerSerialNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ManufacturerSerialNumber;
        partial void OnManufacturerSerialNumberChanging(string value);
        partial void OnManufacturerSerialNumberChanged();
        /// <summary>
        /// There are no comments for Property InternalSerialNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InternalSerialNumber")]
        public virtual string InternalSerialNumber
        {
            get
            {
                return this._InternalSerialNumber;
            }
            set
            {
                this.OnInternalSerialNumberChanging(value);
                this._InternalSerialNumber = value;
                this.OnInternalSerialNumberChanged();
                this.OnPropertyChanged("InternalSerialNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InternalSerialNumber;
        partial void OnInternalSerialNumberChanging(string value);
        partial void OnInternalSerialNumberChanged();
        /// <summary>
        /// There are no comments for Property ExpiryDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpiryDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> ExpiryDate
        {
            get
            {
                return this._ExpiryDate;
            }
            set
            {
                this.OnExpiryDateChanging(value);
                this._ExpiryDate = value;
                this.OnExpiryDateChanged();
                this.OnPropertyChanged("ExpiryDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _ExpiryDate;
        partial void OnExpiryDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnExpiryDateChanged();
        /// <summary>
        /// There are no comments for Property ManufacturingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ManufacturingDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> ManufacturingDate
        {
            get
            {
                return this._ManufacturingDate;
            }
            set
            {
                this.OnManufacturingDateChanging(value);
                this._ManufacturingDate = value;
                this.OnManufacturingDateChanged();
                this.OnPropertyChanged("ManufacturingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _ManufacturingDate;
        partial void OnManufacturingDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnManufacturingDateChanged();
        /// <summary>
        /// There are no comments for Property AddmisionDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AddmisionDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> AddmisionDate
        {
            get
            {
                return this._AddmisionDate;
            }
            set
            {
                this.OnAddmisionDateChanging(value);
                this._AddmisionDate = value;
                this.OnAddmisionDateChanged();
                this.OnPropertyChanged("AddmisionDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _AddmisionDate;
        partial void OnAddmisionDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnAddmisionDateChanged();
        /// <summary>
        /// There are no comments for Property Location in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Location")]
        public virtual string Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this.OnLocationChanging(value);
                this._Location = value;
                this.OnLocationChanged();
                this.OnPropertyChanged("Location");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Location;
        partial void OnLocationChanging(string value);
        partial void OnLocationChanged();
        /// <summary>
        /// There are no comments for Property Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Notes")]
        public virtual string Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this.OnNotesChanging(value);
                this._Notes = value;
                this.OnNotesChanged();
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Notes;
        partial void OnNotesChanging(string value);
        partial void OnNotesChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Quantity")]
        public virtual global::System.Nullable<double> Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Quantity;
        partial void OnQuantityChanging(global::System.Nullable<double> value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property BaseLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseLineNumber")]
        public virtual global::System.Nullable<int> BaseLineNumber
        {
            get
            {
                return this._BaseLineNumber;
            }
            set
            {
                this.OnBaseLineNumberChanging(value);
                this._BaseLineNumber = value;
                this.OnBaseLineNumberChanged();
                this.OnPropertyChanged("BaseLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BaseLineNumber;
        partial void OnBaseLineNumberChanging(global::System.Nullable<int> value);
        partial void OnBaseLineNumberChanged();
        /// <summary>
        /// There are no comments for Property TrackingNote in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TrackingNote")]
        public virtual global::System.Nullable<int> TrackingNote
        {
            get
            {
                return this._TrackingNote;
            }
            set
            {
                this.OnTrackingNoteChanging(value);
                this._TrackingNote = value;
                this.OnTrackingNoteChanged();
                this.OnPropertyChanged("TrackingNote");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _TrackingNote;
        partial void OnTrackingNoteChanging(global::System.Nullable<int> value);
        partial void OnTrackingNoteChanged();
        /// <summary>
        /// There are no comments for Property TrackingNoteLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TrackingNoteLine")]
        public virtual global::System.Nullable<int> TrackingNoteLine
        {
            get
            {
                return this._TrackingNoteLine;
            }
            set
            {
                this.OnTrackingNoteLineChanging(value);
                this._TrackingNoteLine = value;
                this.OnTrackingNoteLineChanged();
                this.OnPropertyChanged("TrackingNoteLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _TrackingNoteLine;
        partial void OnTrackingNoteLineChanging(global::System.Nullable<int> value);
        partial void OnTrackingNoteLineChanged();
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
        /// There are no comments for Property SystemSerialNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SystemSerialNumber")]
        public virtual global::System.Nullable<int> SystemSerialNumber
        {
            get
            {
                return this._SystemSerialNumber;
            }
            set
            {
                this.OnSystemSerialNumberChanging(value);
                this._SystemSerialNumber = value;
                this.OnSystemSerialNumberChanged();
                this.OnPropertyChanged("SystemSerialNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SystemSerialNumber;
        partial void OnSystemSerialNumberChanging(global::System.Nullable<int> value);
        partial void OnSystemSerialNumberChanged();
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