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
    /// There are no comments for BinLocationFieldSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BinLocationFieldSingle")]
    public partial class BinLocationFieldSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BinLocationField>
    {
        /// <summary>
        /// Initialize a new BinLocationFieldSingle object.
        /// </summary>
        public BinLocationFieldSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BinLocationFieldSingle object.
        /// </summary>
        public BinLocationFieldSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BinLocationFieldSingle object.
        /// </summary>
        public BinLocationFieldSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BinLocationField> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BinLocationAttributes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BinLocationAttributes")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.BinLocationAttribute> BinLocationAttributes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BinLocationAttributes == null))
                {
                    this._BinLocationAttributes = Context.CreateQuery<global::SAPB1.BinLocationAttribute>(GetPath("BinLocationAttributes"));
                }
                return this._BinLocationAttributes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.BinLocationAttribute> _BinLocationAttributes;
        /// <summary>
        /// There are no comments for WarehouseSublevelCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseSublevelCodes")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.WarehouseSublevelCode> WarehouseSublevelCodes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseSublevelCodes == null))
                {
                    this._WarehouseSublevelCodes = Context.CreateQuery<global::SAPB1.WarehouseSublevelCode>(GetPath("WarehouseSublevelCodes"));
                }
                return this._WarehouseSublevelCodes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.WarehouseSublevelCode> _WarehouseSublevelCodes;
    }
    /// <summary>
    /// There are no comments for BinLocationField in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AbsEntry
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AbsEntry")]
    [global::Microsoft.OData.Client.EntitySet("BinLocationFields")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BinLocationField")]
    public partial class BinLocationField : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BinLocationField object.
        /// </summary>
        /// <param name="absEntry">Initial value of AbsEntry.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BinLocationField CreateBinLocationField(int absEntry)
        {
            BinLocationField binLocationField = new BinLocationField();
            binLocationField.AbsEntry = absEntry;
            return binLocationField;
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
        /// There are no comments for Property FieldType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FieldType")]
        public virtual global::System.Nullable<global::SAPB1.BinLocationFieldTypeEnum> FieldType
        {
            get
            {
                return this._FieldType;
            }
            set
            {
                this.OnFieldTypeChanging(value);
                this._FieldType = value;
                this.OnFieldTypeChanged();
                this.OnPropertyChanged("FieldType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BinLocationFieldTypeEnum> _FieldType;
        partial void OnFieldTypeChanging(global::System.Nullable<global::SAPB1.BinLocationFieldTypeEnum> value);
        partial void OnFieldTypeChanged();
        /// <summary>
        /// There are no comments for Property FieldNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FieldNumber")]
        public virtual global::System.Nullable<int> FieldNumber
        {
            get
            {
                return this._FieldNumber;
            }
            set
            {
                this.OnFieldNumberChanging(value);
                this._FieldNumber = value;
                this.OnFieldNumberChanged();
                this.OnPropertyChanged("FieldNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _FieldNumber;
        partial void OnFieldNumberChanging(global::System.Nullable<int> value);
        partial void OnFieldNumberChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Activated in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Activated")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Activated
        {
            get
            {
                return this._Activated;
            }
            set
            {
                this.OnActivatedChanging(value);
                this._Activated = value;
                this.OnActivatedChanged();
                this.OnPropertyChanged("Activated");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Activated;
        partial void OnActivatedChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnActivatedChanged();
        /// <summary>
        /// There are no comments for Property DefaultFieldName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultFieldName")]
        public virtual string DefaultFieldName
        {
            get
            {
                return this._DefaultFieldName;
            }
            set
            {
                this.OnDefaultFieldNameChanging(value);
                this._DefaultFieldName = value;
                this.OnDefaultFieldNameChanged();
                this.OnPropertyChanged("DefaultFieldName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultFieldName;
        partial void OnDefaultFieldNameChanging(string value);
        partial void OnDefaultFieldNameChanged();
        /// <summary>
        /// There are no comments for Property BinLocationAttributes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BinLocationAttributes")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.BinLocationAttribute> BinLocationAttributes
        {
            get
            {
                return this._BinLocationAttributes;
            }
            set
            {
                this.OnBinLocationAttributesChanging(value);
                this._BinLocationAttributes = value;
                this.OnBinLocationAttributesChanged();
                this.OnPropertyChanged("BinLocationAttributes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.BinLocationAttribute> _BinLocationAttributes = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.BinLocationAttribute>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBinLocationAttributesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.BinLocationAttribute> value);
        partial void OnBinLocationAttributesChanged();
        /// <summary>
        /// There are no comments for Property WarehouseSublevelCodes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseSublevelCodes")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.WarehouseSublevelCode> WarehouseSublevelCodes
        {
            get
            {
                return this._WarehouseSublevelCodes;
            }
            set
            {
                this.OnWarehouseSublevelCodesChanging(value);
                this._WarehouseSublevelCodes = value;
                this.OnWarehouseSublevelCodesChanged();
                this.OnPropertyChanged("WarehouseSublevelCodes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.WarehouseSublevelCode> _WarehouseSublevelCodes = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.WarehouseSublevelCode>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWarehouseSublevelCodesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.WarehouseSublevelCode> value);
        partial void OnWarehouseSublevelCodesChanged();
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
