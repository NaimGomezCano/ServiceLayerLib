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
    /// There are no comments for CheckLine in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CheckLine")]
    public partial class CheckLine : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property CheckKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckKey")]
        public virtual global::System.Nullable<int> CheckKey
        {
            get
            {
                return this._CheckKey;
            }
            set
            {
                this.OnCheckKeyChanging(value);
                this._CheckKey = value;
                this.OnCheckKeyChanged();
                this.OnPropertyChanged("CheckKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _CheckKey;
        partial void OnCheckKeyChanging(global::System.Nullable<int> value);
        partial void OnCheckKeyChanged();
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
        /// There are no comments for Property Bank in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Bank")]
        public virtual string Bank
        {
            get
            {
                return this._Bank;
            }
            set
            {
                this.OnBankChanging(value);
                this._Bank = value;
                this.OnBankChanged();
                this.OnPropertyChanged("Bank");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Bank;
        partial void OnBankChanging(string value);
        partial void OnBankChanged();
        /// <summary>
        /// There are no comments for Property Branch in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Branch")]
        public virtual string Branch
        {
            get
            {
                return this._Branch;
            }
            set
            {
                this.OnBranchChanging(value);
                this._Branch = value;
                this.OnBranchChanged();
                this.OnPropertyChanged("Branch");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Branch;
        partial void OnBranchChanging(string value);
        partial void OnBranchChanged();
        /// <summary>
        /// There are no comments for Property CashCheck in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CashCheck")]
        public virtual string CashCheck
        {
            get
            {
                return this._CashCheck;
            }
            set
            {
                this.OnCashCheckChanging(value);
                this._CashCheck = value;
                this.OnCashCheckChanged();
                this.OnPropertyChanged("CashCheck");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CashCheck;
        partial void OnCashCheckChanging(string value);
        partial void OnCashCheckChanged();
        /// <summary>
        /// There are no comments for Property CheckDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> CheckDate
        {
            get
            {
                return this._CheckDate;
            }
            set
            {
                this.OnCheckDateChanging(value);
                this._CheckDate = value;
                this.OnCheckDateChanged();
                this.OnPropertyChanged("CheckDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _CheckDate;
        partial void OnCheckDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnCheckDateChanged();
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
        /// There are no comments for Property CheckAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckAmount")]
        public virtual global::System.Nullable<double> CheckAmount
        {
            get
            {
                return this._CheckAmount;
            }
            set
            {
                this.OnCheckAmountChanging(value);
                this._CheckAmount = value;
                this.OnCheckAmountChanged();
                this.OnPropertyChanged("CheckAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _CheckAmount;
        partial void OnCheckAmountChanging(global::System.Nullable<double> value);
        partial void OnCheckAmountChanged();
        /// <summary>
        /// There are no comments for Property Deposited in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Deposited")]
        public virtual global::System.Nullable<global::SAPB1.BoDepositCheckEnum> Deposited
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
        private global::System.Nullable<global::SAPB1.BoDepositCheckEnum> _Deposited;
        partial void OnDepositedChanging(global::System.Nullable<global::SAPB1.BoDepositCheckEnum> value);
        partial void OnDepositedChanged();
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
        /// There are no comments for Property AccountNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountNumber")]
        public virtual string AccountNumber
        {
            get
            {
                return this._AccountNumber;
            }
            set
            {
                this.OnAccountNumberChanging(value);
                this._AccountNumber = value;
                this.OnAccountNumberChanged();
                this.OnPropertyChanged("AccountNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountNumber;
        partial void OnAccountNumberChanging(string value);
        partial void OnAccountNumberChanged();
        /// <summary>
        /// There are no comments for Property CheckCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CheckCurrency")]
        public virtual string CheckCurrency
        {
            get
            {
                return this._CheckCurrency;
            }
            set
            {
                this.OnCheckCurrencyChanging(value);
                this._CheckCurrency = value;
                this.OnCheckCurrencyChanged();
                this.OnPropertyChanged("CheckCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CheckCurrency;
        partial void OnCheckCurrencyChanging(string value);
        partial void OnCheckCurrencyChanged();
        /// <summary>
        /// There are no comments for Property FiscalID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalID")]
        public virtual string FiscalID
        {
            get
            {
                return this._FiscalID;
            }
            set
            {
                this.OnFiscalIDChanging(value);
                this._FiscalID = value;
                this.OnFiscalIDChanged();
                this.OnPropertyChanged("FiscalID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalID;
        partial void OnFiscalIDChanging(string value);
        partial void OnFiscalIDChanged();
        /// <summary>
        /// There are no comments for Property OriginallyIssuedBy in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OriginallyIssuedBy")]
        public virtual string OriginallyIssuedBy
        {
            get
            {
                return this._OriginallyIssuedBy;
            }
            set
            {
                this.OnOriginallyIssuedByChanging(value);
                this._OriginallyIssuedBy = value;
                this.OnOriginallyIssuedByChanged();
                this.OnPropertyChanged("OriginallyIssuedBy");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OriginallyIssuedBy;
        partial void OnOriginallyIssuedByChanging(string value);
        partial void OnOriginallyIssuedByChanged();
        /// <summary>
        /// There are no comments for Property RejectedByBank in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RejectedByBank")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> RejectedByBank
        {
            get
            {
                return this._RejectedByBank;
            }
            set
            {
                this.OnRejectedByBankChanging(value);
                this._RejectedByBank = value;
                this.OnRejectedByBankChanged();
                this.OnPropertyChanged("RejectedByBank");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _RejectedByBank;
        partial void OnRejectedByBankChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnRejectedByBankChanged();
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