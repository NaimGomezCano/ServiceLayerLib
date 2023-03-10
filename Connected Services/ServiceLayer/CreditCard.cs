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
    /// There are no comments for CreditCardSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CreditCardSingle")]
    public partial class CreditCardSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CreditCard>
    {
        /// <summary>
        /// Initialize a new CreditCardSingle object.
        /// </summary>
        public CreditCardSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CreditCardSingle object.
        /// </summary>
        public CreditCardSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CreditCardSingle object.
        /// </summary>
        public CreditCardSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CreditCard> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BusinessPartners in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPartners")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.BusinessPartner> BusinessPartners
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BusinessPartners == null))
                {
                    this._BusinessPartners = Context.CreateQuery<global::SAPB1.BusinessPartner>(GetPath("BusinessPartners"));
                }
                return this._BusinessPartners;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.BusinessPartner> _BusinessPartners;
        /// <summary>
        /// There are no comments for ChartOfAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ChartOfAccount")]
        public virtual global::SAPB1.ChartOfAccountSingle ChartOfAccount
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ChartOfAccount == null))
                {
                    this._ChartOfAccount = new global::SAPB1.ChartOfAccountSingle(this.Context, GetPath("ChartOfAccount"));
                }
                return this._ChartOfAccount;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.ChartOfAccountSingle _ChartOfAccount;
        /// <summary>
        /// There are no comments for Country in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Country")]
        public virtual global::SAPB1.CountrySingle Country
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Country == null))
                {
                    this._Country = new global::SAPB1.CountrySingle(this.Context, GetPath("Country"));
                }
                return this._Country;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.CountrySingle _Country;
        /// <summary>
        /// There are no comments for CreditPaymentMethods in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditPaymentMethods")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.CreditPaymentMethod> CreditPaymentMethods
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._CreditPaymentMethods == null))
                {
                    this._CreditPaymentMethods = Context.CreateQuery<global::SAPB1.CreditPaymentMethod>(GetPath("CreditPaymentMethods"));
                }
                return this._CreditPaymentMethods;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.CreditPaymentMethod> _CreditPaymentMethods;
    }
    /// <summary>
    /// There are no comments for CreditCard in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CreditCardCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CreditCardCode")]
    [global::Microsoft.OData.Client.EntitySet("CreditCards")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CreditCard")]
    public partial class CreditCard : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CreditCard object.
        /// </summary>
        /// <param name="creditCardCode">Initial value of CreditCardCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CreditCard CreateCreditCard(int creditCardCode)
        {
            CreditCard creditCard = new CreditCard();
            creditCard.CreditCardCode = creditCardCode;
            return creditCard;
        }
        /// <summary>
        /// There are no comments for Property CreditCardCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditCardCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CreditCardCode is required.")]
        public virtual int CreditCardCode
        {
            get
            {
                return this._CreditCardCode;
            }
            set
            {
                this.OnCreditCardCodeChanging(value);
                this._CreditCardCode = value;
                this.OnCreditCardCodeChanged();
                this.OnPropertyChanged("CreditCardCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _CreditCardCode;
        partial void OnCreditCardCodeChanging(int value);
        partial void OnCreditCardCodeChanged();
        /// <summary>
        /// There are no comments for Property CreditCardName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditCardName")]
        public virtual string CreditCardName
        {
            get
            {
                return this._CreditCardName;
            }
            set
            {
                this.OnCreditCardNameChanging(value);
                this._CreditCardName = value;
                this.OnCreditCardNameChanged();
                this.OnPropertyChanged("CreditCardName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CreditCardName;
        partial void OnCreditCardNameChanging(string value);
        partial void OnCreditCardNameChanged();
        /// <summary>
        /// There are no comments for Property GLAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GLAccount")]
        public virtual string GLAccount
        {
            get
            {
                return this._GLAccount;
            }
            set
            {
                this.OnGLAccountChanging(value);
                this._GLAccount = value;
                this.OnGLAccountChanged();
                this.OnPropertyChanged("GLAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GLAccount;
        partial void OnGLAccountChanging(string value);
        partial void OnGLAccountChanged();
        /// <summary>
        /// There are no comments for Property Telephone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Telephone")]
        public virtual string Telephone
        {
            get
            {
                return this._Telephone;
            }
            set
            {
                this.OnTelephoneChanging(value);
                this._Telephone = value;
                this.OnTelephoneChanged();
                this.OnPropertyChanged("Telephone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Telephone;
        partial void OnTelephoneChanging(string value);
        partial void OnTelephoneChanged();
        /// <summary>
        /// There are no comments for Property CompanyID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CompanyID")]
        public virtual string CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                this.OnCompanyIDChanging(value);
                this._CompanyID = value;
                this.OnCompanyIDChanged();
                this.OnPropertyChanged("CompanyID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CompanyID;
        partial void OnCompanyIDChanging(string value);
        partial void OnCompanyIDChanged();
        /// <summary>
        /// There are no comments for Property CountryCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryCode")]
        public virtual string CountryCode
        {
            get
            {
                return this._CountryCode;
            }
            set
            {
                this.OnCountryCodeChanging(value);
                this._CountryCode = value;
                this.OnCountryCodeChanged();
                this.OnPropertyChanged("CountryCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryCode;
        partial void OnCountryCodeChanging(string value);
        partial void OnCountryCodeChanged();
        /// <summary>
        /// There are no comments for Property BusinessPartners in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPartners")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.BusinessPartner> BusinessPartners
        {
            get
            {
                return this._BusinessPartners;
            }
            set
            {
                this.OnBusinessPartnersChanging(value);
                this._BusinessPartners = value;
                this.OnBusinessPartnersChanged();
                this.OnPropertyChanged("BusinessPartners");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.BusinessPartner> _BusinessPartners = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.BusinessPartner>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnBusinessPartnersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.BusinessPartner> value);
        partial void OnBusinessPartnersChanged();
        /// <summary>
        /// There are no comments for Property ChartOfAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChartOfAccount")]
        public virtual global::SAPB1.ChartOfAccount ChartOfAccount
        {
            get
            {
                return this._ChartOfAccount;
            }
            set
            {
                this.OnChartOfAccountChanging(value);
                this._ChartOfAccount = value;
                this.OnChartOfAccountChanged();
                this.OnPropertyChanged("ChartOfAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.ChartOfAccount _ChartOfAccount;
        partial void OnChartOfAccountChanging(global::SAPB1.ChartOfAccount value);
        partial void OnChartOfAccountChanged();
        /// <summary>
        /// There are no comments for Property Country in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Country")]
        public virtual global::SAPB1.Country Country
        {
            get
            {
                return this._Country;
            }
            set
            {
                this.OnCountryChanging(value);
                this._Country = value;
                this.OnCountryChanged();
                this.OnPropertyChanged("Country");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.Country _Country;
        partial void OnCountryChanging(global::SAPB1.Country value);
        partial void OnCountryChanged();
        /// <summary>
        /// There are no comments for Property CreditPaymentMethods in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditPaymentMethods")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.CreditPaymentMethod> CreditPaymentMethods
        {
            get
            {
                return this._CreditPaymentMethods;
            }
            set
            {
                this.OnCreditPaymentMethodsChanging(value);
                this._CreditPaymentMethods = value;
                this.OnCreditPaymentMethodsChanged();
                this.OnPropertyChanged("CreditPaymentMethods");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.CreditPaymentMethod> _CreditPaymentMethods = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.CreditPaymentMethod>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnCreditPaymentMethodsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.CreditPaymentMethod> value);
        partial void OnCreditPaymentMethodsChanged();
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
