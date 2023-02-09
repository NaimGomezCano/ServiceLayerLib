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
    /// There are no comments for SerialNumberDetailSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SerialNumberDetailSingle")]
    public partial class SerialNumberDetailSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SerialNumberDetail>
    {
        /// <summary>
        /// Initialize a new SerialNumberDetailSingle object.
        /// </summary>
        public SerialNumberDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SerialNumberDetailSingle object.
        /// </summary>
        public SerialNumberDetailSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SerialNumberDetailSingle object.
        /// </summary>
        public SerialNumberDetailSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SerialNumberDetail> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Item in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Item")]
        public virtual global::SAPB1.ItemSingle Item
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Item == null))
                {
                    this._Item = new global::SAPB1.ItemSingle(this.Context, GetPath("Item"));
                }
                return this._Item;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.ItemSingle _Item;
    }
    /// <summary>
    /// There are no comments for SerialNumberDetail in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DocEntry
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DocEntry")]
    [global::Microsoft.OData.Client.EntitySet("SerialNumberDetails")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SerialNumberDetail")]
    public partial class SerialNumberDetail : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SerialNumberDetail object.
        /// </summary>
        /// <param name="docEntry">Initial value of DocEntry.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SerialNumberDetail CreateSerialNumberDetail(int docEntry)
        {
            SerialNumberDetail serialNumberDetail = new SerialNumberDetail();
            serialNumberDetail.DocEntry = docEntry;
            return serialNumberDetail;
        }
        /// <summary>
        /// There are no comments for Property DocEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocEntry")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DocEntry is required.")]
        public virtual int DocEntry
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
        private int _DocEntry;
        partial void OnDocEntryChanging(int value);
        partial void OnDocEntryChanged();
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
        /// There are no comments for Property ItemDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemDescription")]
        public virtual string ItemDescription
        {
            get
            {
                return this._ItemDescription;
            }
            set
            {
                this.OnItemDescriptionChanging(value);
                this._ItemDescription = value;
                this.OnItemDescriptionChanged();
                this.OnPropertyChanged("ItemDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemDescription;
        partial void OnItemDescriptionChanging(string value);
        partial void OnItemDescriptionChanged();
        /// <summary>
        /// There are no comments for Property MfrSerialNo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MfrSerialNo")]
        public virtual string MfrSerialNo
        {
            get
            {
                return this._MfrSerialNo;
            }
            set
            {
                this.OnMfrSerialNoChanging(value);
                this._MfrSerialNo = value;
                this.OnMfrSerialNoChanged();
                this.OnPropertyChanged("MfrSerialNo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MfrSerialNo;
        partial void OnMfrSerialNoChanging(string value);
        partial void OnMfrSerialNoChanged();
        /// <summary>
        /// There are no comments for Property SerialNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SerialNumber")]
        public virtual string SerialNumber
        {
            get
            {
                return this._SerialNumber;
            }
            set
            {
                this.OnSerialNumberChanging(value);
                this._SerialNumber = value;
                this.OnSerialNumberChanged();
                this.OnPropertyChanged("SerialNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SerialNumber;
        partial void OnSerialNumberChanging(string value);
        partial void OnSerialNumberChanged();
        /// <summary>
        /// There are no comments for Property LotNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LotNumber")]
        public virtual string LotNumber
        {
            get
            {
                return this._LotNumber;
            }
            set
            {
                this.OnLotNumberChanging(value);
                this._LotNumber = value;
                this.OnLotNumberChanged();
                this.OnPropertyChanged("LotNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LotNumber;
        partial void OnLotNumberChanging(string value);
        partial void OnLotNumberChanged();
        /// <summary>
        /// There are no comments for Property SystemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SystemNumber")]
        public virtual global::System.Nullable<int> SystemNumber
        {
            get
            {
                return this._SystemNumber;
            }
            set
            {
                this.OnSystemNumberChanging(value);
                this._SystemNumber = value;
                this.OnSystemNumberChanged();
                this.OnPropertyChanged("SystemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SystemNumber;
        partial void OnSystemNumberChanging(global::System.Nullable<int> value);
        partial void OnSystemNumberChanged();
        /// <summary>
        /// There are no comments for Property AdmissionDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdmissionDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> AdmissionDate
        {
            get
            {
                return this._AdmissionDate;
            }
            set
            {
                this.OnAdmissionDateChanging(value);
                this._AdmissionDate = value;
                this.OnAdmissionDateChanged();
                this.OnPropertyChanged("AdmissionDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _AdmissionDate;
        partial void OnAdmissionDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnAdmissionDateChanged();
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
        /// There are no comments for Property ExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpirationDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> ExpirationDate
        {
            get
            {
                return this._ExpirationDate;
            }
            set
            {
                this.OnExpirationDateChanging(value);
                this._ExpirationDate = value;
                this.OnExpirationDateChanged();
                this.OnPropertyChanged("ExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _ExpirationDate;
        partial void OnExpirationDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnExpirationDateChanged();
        /// <summary>
        /// There are no comments for Property MfrWarrantyStart in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MfrWarrantyStart")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> MfrWarrantyStart
        {
            get
            {
                return this._MfrWarrantyStart;
            }
            set
            {
                this.OnMfrWarrantyStartChanging(value);
                this._MfrWarrantyStart = value;
                this.OnMfrWarrantyStartChanged();
                this.OnPropertyChanged("MfrWarrantyStart");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _MfrWarrantyStart;
        partial void OnMfrWarrantyStartChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnMfrWarrantyStartChanged();
        /// <summary>
        /// There are no comments for Property MFrWarrantyEnd in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MFrWarrantyEnd")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> MFrWarrantyEnd
        {
            get
            {
                return this._MFrWarrantyEnd;
            }
            set
            {
                this.OnMFrWarrantyEndChanging(value);
                this._MFrWarrantyEnd = value;
                this.OnMFrWarrantyEndChanged();
                this.OnPropertyChanged("MFrWarrantyEnd");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _MFrWarrantyEnd;
        partial void OnMFrWarrantyEndChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnMFrWarrantyEndChanged();
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
        /// There are no comments for Property Details in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Details")]
        public virtual string Details
        {
            get
            {
                return this._Details;
            }
            set
            {
                this.OnDetailsChanging(value);
                this._Details = value;
                this.OnDetailsChanged();
                this.OnPropertyChanged("Details");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Details;
        partial void OnDetailsChanging(string value);
        partial void OnDetailsChanged();
        /// <summary>
        /// There are no comments for Property Item in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Item")]
        public virtual global::SAPB1.Item Item
        {
            get
            {
                return this._Item;
            }
            set
            {
                this.OnItemChanging(value);
                this._Item = value;
                this.OnItemChanged();
                this.OnPropertyChanged("Item");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.Item _Item;
        partial void OnItemChanging(global::SAPB1.Item value);
        partial void OnItemChanged();
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
