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
    /// There are no comments for LengthMeasureSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LengthMeasureSingle")]
    public partial class LengthMeasureSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<LengthMeasure>
    {
        /// <summary>
        /// Initialize a new LengthMeasureSingle object.
        /// </summary>
        public LengthMeasureSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new LengthMeasureSingle object.
        /// </summary>
        public LengthMeasureSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new LengthMeasureSingle object.
        /// </summary>
        public LengthMeasureSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<LengthMeasure> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for LengthMeasure in the schema.
    /// </summary>
    /// <KeyProperties>
    /// UnitCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("UnitCode")]
    [global::Microsoft.OData.Client.EntitySet("LengthMeasures")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("LengthMeasure")]
    public partial class LengthMeasure : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new LengthMeasure object.
        /// </summary>
        /// <param name="unitCode">Initial value of UnitCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static LengthMeasure CreateLengthMeasure(int unitCode)
        {
            LengthMeasure lengthMeasure = new LengthMeasure();
            lengthMeasure.UnitCode = unitCode;
            return lengthMeasure;
        }
        /// <summary>
        /// There are no comments for Property UnitCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UnitCode is required.")]
        public virtual int UnitCode
        {
            get
            {
                return this._UnitCode;
            }
            set
            {
                this.OnUnitCodeChanging(value);
                this._UnitCode = value;
                this.OnUnitCodeChanged();
                this.OnPropertyChanged("UnitCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _UnitCode;
        partial void OnUnitCodeChanging(int value);
        partial void OnUnitCodeChanged();
        /// <summary>
        /// There are no comments for Property UnitDisplay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitDisplay")]
        public virtual string UnitDisplay
        {
            get
            {
                return this._UnitDisplay;
            }
            set
            {
                this.OnUnitDisplayChanging(value);
                this._UnitDisplay = value;
                this.OnUnitDisplayChanged();
                this.OnPropertyChanged("UnitDisplay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitDisplay;
        partial void OnUnitDisplayChanging(string value);
        partial void OnUnitDisplayChanged();
        /// <summary>
        /// There are no comments for Property UnitName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitName")]
        public virtual string UnitName
        {
            get
            {
                return this._UnitName;
            }
            set
            {
                this.OnUnitNameChanging(value);
                this._UnitName = value;
                this.OnUnitNameChanged();
                this.OnPropertyChanged("UnitName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitName;
        partial void OnUnitNameChanging(string value);
        partial void OnUnitNameChanged();
        /// <summary>
        /// There are no comments for Property UnitCodeforQuantityDisplay in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitCodeforQuantityDisplay")]
        public virtual string UnitCodeforQuantityDisplay
        {
            get
            {
                return this._UnitCodeforQuantityDisplay;
            }
            set
            {
                this.OnUnitCodeforQuantityDisplayChanging(value);
                this._UnitCodeforQuantityDisplay = value;
                this.OnUnitCodeforQuantityDisplayChanged();
                this.OnPropertyChanged("UnitCodeforQuantityDisplay");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UnitCodeforQuantityDisplay;
        partial void OnUnitCodeforQuantityDisplayChanging(string value);
        partial void OnUnitCodeforQuantityDisplayChanged();
        /// <summary>
        /// There are no comments for Property UnitLengthinmm in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitLengthinmm")]
        public virtual global::System.Nullable<double> UnitLengthinmm
        {
            get
            {
                return this._UnitLengthinmm;
            }
            set
            {
                this.OnUnitLengthinmmChanging(value);
                this._UnitLengthinmm = value;
                this.OnUnitLengthinmmChanged();
                this.OnPropertyChanged("UnitLengthinmm");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _UnitLengthinmm;
        partial void OnUnitLengthinmmChanging(global::System.Nullable<double> value);
        partial void OnUnitLengthinmmChanged();
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