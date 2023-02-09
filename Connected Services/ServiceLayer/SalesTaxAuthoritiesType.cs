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
    /// There are no comments for SalesTaxAuthoritiesTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTaxAuthoritiesTypeSingle")]
    public partial class SalesTaxAuthoritiesTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SalesTaxAuthoritiesType>
    {
        /// <summary>
        /// Initialize a new SalesTaxAuthoritiesTypeSingle object.
        /// </summary>
        public SalesTaxAuthoritiesTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SalesTaxAuthoritiesTypeSingle object.
        /// </summary>
        public SalesTaxAuthoritiesTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SalesTaxAuthoritiesTypeSingle object.
        /// </summary>
        public SalesTaxAuthoritiesTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SalesTaxAuthoritiesType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for SalesTaxAuthorities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTaxAuthorities")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.SalesTaxAuthority> SalesTaxAuthorities
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SalesTaxAuthorities == null))
                {
                    this._SalesTaxAuthorities = Context.CreateQuery<global::SAPB1.SalesTaxAuthority>(GetPath("SalesTaxAuthorities"));
                }
                return this._SalesTaxAuthorities;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.SalesTaxAuthority> _SalesTaxAuthorities;
        /// <summary>
        /// There are no comments for User in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("User")]
        public virtual global::SAPB1.UserSingle User
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._User == null))
                {
                    this._User = new global::SAPB1.UserSingle(this.Context, GetPath("User"));
                }
                return this._User;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.UserSingle _User;
        /// <summary>
        /// There are no comments for DepreciationAreas in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DepreciationAreas")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.DepreciationArea> DepreciationAreas
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DepreciationAreas == null))
                {
                    this._DepreciationAreas = Context.CreateQuery<global::SAPB1.DepreciationArea>(GetPath("DepreciationAreas"));
                }
                return this._DepreciationAreas;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.DepreciationArea> _DepreciationAreas;
    }
    /// <summary>
    /// There are no comments for SalesTaxAuthoritiesType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Numerator
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Numerator")]
    [global::Microsoft.OData.Client.EntitySet("SalesTaxAuthoritiesTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTaxAuthoritiesType")]
    public partial class SalesTaxAuthoritiesType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SalesTaxAuthoritiesType object.
        /// </summary>
        /// <param name="numerator">Initial value of Numerator.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SalesTaxAuthoritiesType CreateSalesTaxAuthoritiesType(int numerator)
        {
            SalesTaxAuthoritiesType salesTaxAuthoritiesType = new SalesTaxAuthoritiesType();
            salesTaxAuthoritiesType.Numerator = numerator;
            return salesTaxAuthoritiesType;
        }
        /// <summary>
        /// There are no comments for Property UserSignature in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserSignature")]
        public virtual global::System.Nullable<int> UserSignature
        {
            get
            {
                return this._UserSignature;
            }
            set
            {
                this.OnUserSignatureChanging(value);
                this._UserSignature = value;
                this.OnUserSignatureChanged();
                this.OnPropertyChanged("UserSignature");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _UserSignature;
        partial void OnUserSignatureChanging(global::System.Nullable<int> value);
        partial void OnUserSignatureChanged();
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
        /// There are no comments for Property VAT in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VAT")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> VAT
        {
            get
            {
                return this._VAT;
            }
            set
            {
                this.OnVATChanging(value);
                this._VAT = value;
                this.OnVATChanged();
                this.OnPropertyChanged("VAT");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _VAT;
        partial void OnVATChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnVATChanged();
        /// <summary>
        /// There are no comments for Property Numerator in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Numerator")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Numerator is required.")]
        public virtual int Numerator
        {
            get
            {
                return this._Numerator;
            }
            set
            {
                this.OnNumeratorChanging(value);
                this._Numerator = value;
                this.OnNumeratorChanged();
                this.OnPropertyChanged("Numerator");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Numerator;
        partial void OnNumeratorChanging(int value);
        partial void OnNumeratorChanged();
        /// <summary>
        /// There are no comments for Property TaxCreditControl in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxCreditControl")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> TaxCreditControl
        {
            get
            {
                return this._TaxCreditControl;
            }
            set
            {
                this.OnTaxCreditControlChanging(value);
                this._TaxCreditControl = value;
                this.OnTaxCreditControlChanged();
                this.OnPropertyChanged("TaxCreditControl");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _TaxCreditControl;
        partial void OnTaxCreditControlChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnTaxCreditControlChanged();
        /// <summary>
        /// There are no comments for Property SalesTaxAuthorities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesTaxAuthorities")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.SalesTaxAuthority> SalesTaxAuthorities
        {
            get
            {
                return this._SalesTaxAuthorities;
            }
            set
            {
                this.OnSalesTaxAuthoritiesChanging(value);
                this._SalesTaxAuthorities = value;
                this.OnSalesTaxAuthoritiesChanged();
                this.OnPropertyChanged("SalesTaxAuthorities");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.SalesTaxAuthority> _SalesTaxAuthorities = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.SalesTaxAuthority>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSalesTaxAuthoritiesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.SalesTaxAuthority> value);
        partial void OnSalesTaxAuthoritiesChanged();
        /// <summary>
        /// There are no comments for Property User in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("User")]
        public virtual global::SAPB1.User User
        {
            get
            {
                return this._User;
            }
            set
            {
                this.OnUserChanging(value);
                this._User = value;
                this.OnUserChanged();
                this.OnPropertyChanged("User");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.User _User;
        partial void OnUserChanging(global::SAPB1.User value);
        partial void OnUserChanged();
        /// <summary>
        /// There are no comments for Property DepreciationAreas in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DepreciationAreas")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.DepreciationArea> DepreciationAreas
        {
            get
            {
                return this._DepreciationAreas;
            }
            set
            {
                this.OnDepreciationAreasChanging(value);
                this._DepreciationAreas = value;
                this.OnDepreciationAreasChanged();
                this.OnPropertyChanged("DepreciationAreas");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.DepreciationArea> _DepreciationAreas = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.DepreciationArea>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDepreciationAreasChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.DepreciationArea> value);
        partial void OnDepreciationAreasChanged();
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