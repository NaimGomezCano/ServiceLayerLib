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
    /// There are no comments for CashDiscountSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CashDiscountSingle")]
    public partial class CashDiscountSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CashDiscount>
    {
        /// <summary>
        /// Initialize a new CashDiscountSingle object.
        /// </summary>
        public CashDiscountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CashDiscountSingle object.
        /// </summary>
        public CashDiscountSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CashDiscountSingle object.
        /// </summary>
        public CashDiscountSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CashDiscount> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PaymentTermsTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentTermsTypes")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.PaymentTermsType> PaymentTermsTypes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PaymentTermsTypes == null))
                {
                    this._PaymentTermsTypes = Context.CreateQuery<global::SAPB1.PaymentTermsType>(GetPath("PaymentTermsTypes"));
                }
                return this._PaymentTermsTypes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.PaymentTermsType> _PaymentTermsTypes;
    }
    /// <summary>
    /// There are no comments for CashDiscount in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Code")]
    [global::Microsoft.OData.Client.EntitySet("CashDiscounts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CashDiscount")]
    public partial class CashDiscount : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CashDiscount object.
        /// </summary>
        /// <param name="code">Initial value of Code.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CashDiscount CreateCashDiscount(string code)
        {
            CashDiscount cashDiscount = new CashDiscount();
            cashDiscount.Code = code;
            return cashDiscount;
        }
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Code is required.")]
        public virtual string Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                this.OnCodeChanging(value);
                this._Code = value;
                this.OnCodeChanged();
                this.OnPropertyChanged("Code");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Code;
        partial void OnCodeChanging(string value);
        partial void OnCodeChanged();
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
        /// There are no comments for Property ByDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ByDate")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> ByDate
        {
            get
            {
                return this._ByDate;
            }
            set
            {
                this.OnByDateChanging(value);
                this._ByDate = value;
                this.OnByDateChanged();
                this.OnPropertyChanged("ByDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _ByDate;
        partial void OnByDateChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnByDateChanged();
        /// <summary>
        /// There are no comments for Property Freight in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Freight")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Freight
        {
            get
            {
                return this._Freight;
            }
            set
            {
                this.OnFreightChanging(value);
                this._Freight = value;
                this.OnFreightChanged();
                this.OnPropertyChanged("Freight");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Freight;
        partial void OnFreightChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnFreightChanged();
        /// <summary>
        /// There are no comments for Property Tax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Tax")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Tax
        {
            get
            {
                return this._Tax;
            }
            set
            {
                this.OnTaxChanging(value);
                this._Tax = value;
                this.OnTaxChanged();
                this.OnPropertyChanged("Tax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Tax;
        partial void OnTaxChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnTaxChanged();
        /// <summary>
        /// There are no comments for Property DiscountLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountLines")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.DiscountLine> DiscountLines
        {
            get
            {
                return this._DiscountLines;
            }
            set
            {
                this.OnDiscountLinesChanging(value);
                this._DiscountLines = value;
                this.OnDiscountLinesChanged();
                this.OnPropertyChanged("DiscountLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.DiscountLine> _DiscountLines = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.DiscountLine>();
        partial void OnDiscountLinesChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.DiscountLine> value);
        partial void OnDiscountLinesChanged();
        /// <summary>
        /// There are no comments for Property PaymentTermsTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentTermsTypes")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.PaymentTermsType> PaymentTermsTypes
        {
            get
            {
                return this._PaymentTermsTypes;
            }
            set
            {
                this.OnPaymentTermsTypesChanging(value);
                this._PaymentTermsTypes = value;
                this.OnPaymentTermsTypesChanged();
                this.OnPropertyChanged("PaymentTermsTypes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.PaymentTermsType> _PaymentTermsTypes = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.PaymentTermsType>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPaymentTermsTypesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.PaymentTermsType> value);
        partial void OnPaymentTermsTypesChanged();
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
