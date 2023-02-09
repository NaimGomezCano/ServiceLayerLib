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
    /// There are no comments for DNFCodeSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DNFCodeSetupSingle")]
    public partial class DNFCodeSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DNFCodeSetup>
    {
        /// <summary>
        /// Initialize a new DNFCodeSetupSingle object.
        /// </summary>
        public DNFCodeSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DNFCodeSetupSingle object.
        /// </summary>
        public DNFCodeSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DNFCodeSetupSingle object.
        /// </summary>
        public DNFCodeSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DNFCodeSetup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for NCMCodeSetup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("NCMCodeSetup")]
        public virtual global::SAPB1.NCMCodeSetupSingle NCMCodeSetup
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._NCMCodeSetup == null))
                {
                    this._NCMCodeSetup = new global::SAPB1.NCMCodeSetupSingle(this.Context, GetPath("NCMCodeSetup"));
                }
                return this._NCMCodeSetup;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.NCMCodeSetupSingle _NCMCodeSetup;
        /// <summary>
        /// There are no comments for Items in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Items")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.Item> Items
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Items == null))
                {
                    this._Items = Context.CreateQuery<global::SAPB1.Item>(GetPath("Items"));
                }
                return this._Items;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.Item> _Items;
    }
    /// <summary>
    /// There are no comments for DNFCodeSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AbsEntry
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AbsEntry")]
    [global::Microsoft.OData.Client.EntitySet("DNFCodeSetup")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DNFCodeSetup")]
    public partial class DNFCodeSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DNFCodeSetup object.
        /// </summary>
        /// <param name="absEntry">Initial value of AbsEntry.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DNFCodeSetup CreateDNFCodeSetup(int absEntry)
        {
            DNFCodeSetup dNFCodeSetup = new DNFCodeSetup();
            dNFCodeSetup.AbsEntry = absEntry;
            return dNFCodeSetup;
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
        /// There are no comments for Property NCMCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NCMCode")]
        public virtual global::System.Nullable<int> NCMCode
        {
            get
            {
                return this._NCMCode;
            }
            set
            {
                this.OnNCMCodeChanging(value);
                this._NCMCode = value;
                this.OnNCMCodeChanged();
                this.OnPropertyChanged("NCMCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _NCMCode;
        partial void OnNCMCodeChanging(global::System.Nullable<int> value);
        partial void OnNCMCodeChanged();
        /// <summary>
        /// There are no comments for Property DNFCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DNFCode")]
        public virtual string DNFCode
        {
            get
            {
                return this._DNFCode;
            }
            set
            {
                this.OnDNFCodeChanging(value);
                this._DNFCode = value;
                this.OnDNFCodeChanged();
                this.OnPropertyChanged("DNFCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DNFCode;
        partial void OnDNFCodeChanging(string value);
        partial void OnDNFCodeChanged();
        /// <summary>
        /// There are no comments for Property UoM in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UoM")]
        public virtual string UoM
        {
            get
            {
                return this._UoM;
            }
            set
            {
                this.OnUoMChanging(value);
                this._UoM = value;
                this.OnUoMChanged();
                this.OnPropertyChanged("UoM");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UoM;
        partial void OnUoMChanging(string value);
        partial void OnUoMChanged();
        /// <summary>
        /// There are no comments for Property Factor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Factor")]
        public virtual global::System.Nullable<double> Factor
        {
            get
            {
                return this._Factor;
            }
            set
            {
                this.OnFactorChanging(value);
                this._Factor = value;
                this.OnFactorChanged();
                this.OnPropertyChanged("Factor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Factor;
        partial void OnFactorChanging(global::System.Nullable<double> value);
        partial void OnFactorChanged();
        /// <summary>
        /// There are no comments for Property NCMCodeSetup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NCMCodeSetup")]
        public virtual global::SAPB1.NCMCodeSetup NCMCodeSetup
        {
            get
            {
                return this._NCMCodeSetup;
            }
            set
            {
                this.OnNCMCodeSetupChanging(value);
                this._NCMCodeSetup = value;
                this.OnNCMCodeSetupChanged();
                this.OnPropertyChanged("NCMCodeSetup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.NCMCodeSetup _NCMCodeSetup;
        partial void OnNCMCodeSetupChanging(global::SAPB1.NCMCodeSetup value);
        partial void OnNCMCodeSetupChanged();
        /// <summary>
        /// There are no comments for Property Items in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Items")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Item> Items
        {
            get
            {
                return this._Items;
            }
            set
            {
                this.OnItemsChanging(value);
                this._Items = value;
                this.OnItemsChanged();
                this.OnPropertyChanged("Items");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Item> _Items = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Item>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnItemsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Item> value);
        partial void OnItemsChanged();
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