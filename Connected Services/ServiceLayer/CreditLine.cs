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
    /// There are no comments for CreditLine in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CreditLine")]
    public partial class CreditLine : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property AbsId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AbsId")]
        public virtual global::System.Nullable<int> AbsId
        {
            get
            {
                return this._AbsId;
            }
            set
            {
                this.OnAbsIdChanging(value);
                this._AbsId = value;
                this.OnAbsIdChanged();
                this.OnPropertyChanged("AbsId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _AbsId;
        partial void OnAbsIdChanging(global::System.Nullable<int> value);
        partial void OnAbsIdChanged();
        /// <summary>
        /// There are no comments for Property CreditCard in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditCard")]
        public virtual global::System.Nullable<int> CreditCard
        {
            get
            {
                return this._CreditCard;
            }
            set
            {
                this.OnCreditCardChanging(value);
                this._CreditCard = value;
                this.OnCreditCardChanged();
                this.OnPropertyChanged("CreditCard");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _CreditCard;
        partial void OnCreditCardChanging(global::System.Nullable<int> value);
        partial void OnCreditCardChanged();
        /// <summary>
        /// There are no comments for Property VoucherNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VoucherNumber")]
        public virtual string VoucherNumber
        {
            get
            {
                return this._VoucherNumber;
            }
            set
            {
                this.OnVoucherNumberChanging(value);
                this._VoucherNumber = value;
                this.OnVoucherNumberChanged();
                this.OnPropertyChanged("VoucherNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VoucherNumber;
        partial void OnVoucherNumberChanging(string value);
        partial void OnVoucherNumberChanged();
        /// <summary>
        /// There are no comments for Property PaymentMethodCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentMethodCode")]
        public virtual global::System.Nullable<int> PaymentMethodCode
        {
            get
            {
                return this._PaymentMethodCode;
            }
            set
            {
                this.OnPaymentMethodCodeChanging(value);
                this._PaymentMethodCode = value;
                this.OnPaymentMethodCodeChanged();
                this.OnPropertyChanged("PaymentMethodCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _PaymentMethodCode;
        partial void OnPaymentMethodCodeChanging(global::System.Nullable<int> value);
        partial void OnPaymentMethodCodeChanged();
        /// <summary>
        /// There are no comments for Property PayDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PayDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> PayDate
        {
            get
            {
                return this._PayDate;
            }
            set
            {
                this.OnPayDateChanging(value);
                this._PayDate = value;
                this.OnPayDateChanged();
                this.OnPropertyChanged("PayDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _PayDate;
        partial void OnPayDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnPayDateChanged();
        /// <summary>
        /// There are no comments for Property Deposited in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Deposited")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Deposited
        {
            get
            {
                return this._Deposited;
            }
            set
            {
                this.OnDepositedChanging(value);
                this._Deposited = value;
                this.OnDepositedChanged();
                this.OnPropertyChanged("Deposited");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Deposited;
        partial void OnDepositedChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnDepositedChanged();
        /// <summary>
        /// There are no comments for Property NumOfPayments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NumOfPayments")]
        public virtual global::System.Nullable<int> NumOfPayments
        {
            get
            {
                return this._NumOfPayments;
            }
            set
            {
                this.OnNumOfPaymentsChanging(value);
                this._NumOfPayments = value;
                this.OnNumOfPaymentsChanged();
                this.OnPropertyChanged("NumOfPayments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _NumOfPayments;
        partial void OnNumOfPaymentsChanging(global::System.Nullable<int> value);
        partial void OnNumOfPaymentsChanged();
        /// <summary>
        /// There are no comments for Property Customer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Customer")]
        public virtual string Customer
        {
            get
            {
                return this._Customer;
            }
            set
            {
                this.OnCustomerChanging(value);
                this._Customer = value;
                this.OnCustomerChanged();
                this.OnPropertyChanged("Customer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Customer;
        partial void OnCustomerChanging(string value);
        partial void OnCustomerChanged();
        /// <summary>
        /// There are no comments for Property Reference in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Reference")]
        public virtual string Reference
        {
            get
            {
                return this._Reference;
            }
            set
            {
                this.OnReferenceChanging(value);
                this._Reference = value;
                this.OnReferenceChanged();
                this.OnPropertyChanged("Reference");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Reference;
        partial void OnReferenceChanging(string value);
        partial void OnReferenceChanged();
        /// <summary>
        /// There are no comments for Property Transferred in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Transferred")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Transferred
        {
            get
            {
                return this._Transferred;
            }
            set
            {
                this.OnTransferredChanging(value);
                this._Transferred = value;
                this.OnTransferredChanged();
                this.OnPropertyChanged("Transferred");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Transferred;
        partial void OnTransferredChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnTransferredChanged();
        /// <summary>
        /// There are no comments for Property Total in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Total")]
        public virtual global::System.Nullable<double> Total
        {
            get
            {
                return this._Total;
            }
            set
            {
                this.OnTotalChanging(value);
                this._Total = value;
                this.OnTotalChanged();
                this.OnPropertyChanged("Total");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Total;
        partial void OnTotalChanging(global::System.Nullable<double> value);
        partial void OnTotalChanged();
        /// <summary>
        /// There are no comments for Property CreditCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditCurrency")]
        public virtual string CreditCurrency
        {
            get
            {
                return this._CreditCurrency;
            }
            set
            {
                this.OnCreditCurrencyChanging(value);
                this._CreditCurrency = value;
                this.OnCreditCurrencyChanged();
                this.OnPropertyChanged("CreditCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CreditCurrency;
        partial void OnCreditCurrencyChanging(string value);
        partial void OnCreditCurrencyChanged();
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
