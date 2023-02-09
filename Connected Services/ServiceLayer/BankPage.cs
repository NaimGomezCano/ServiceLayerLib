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
    /// There are no comments for BankPageSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BankPageSingle")]
    public partial class BankPageSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BankPage>
    {
        /// <summary>
        /// Initialize a new BankPageSingle object.
        /// </summary>
        public BankPageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BankPageSingle object.
        /// </summary>
        public BankPageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BankPageSingle object.
        /// </summary>
        public BankPageSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BankPage> query)
            : base(query) {}

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
        /// There are no comments for BusinessPartner in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPartner")]
        public virtual global::SAPB1.BusinessPartnerSingle BusinessPartner
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BusinessPartner == null))
                {
                    this._BusinessPartner = new global::SAPB1.BusinessPartnerSingle(this.Context, GetPath("BusinessPartner"));
                }
                return this._BusinessPartner;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BusinessPartnerSingle _BusinessPartner;
    }
    /// <summary>
    /// There are no comments for BankPage in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AccountCode
    /// Sequence
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AccountCode", "Sequence")]
    [global::Microsoft.OData.Client.EntitySet("BankPages")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BankPage")]
    public partial class BankPage : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BankPage object.
        /// </summary>
        /// <param name="accountCode">Initial value of AccountCode.</param>
        /// <param name="sequence">Initial value of Sequence.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BankPage CreateBankPage(string accountCode, int sequence)
        {
            BankPage bankPage = new BankPage();
            bankPage.AccountCode = accountCode;
            bankPage.Sequence = sequence;
            return bankPage;
        }
        /// <summary>
        /// There are no comments for Property AccountCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AccountCode is required.")]
        public virtual string AccountCode
        {
            get
            {
                return this._AccountCode;
            }
            set
            {
                this.OnAccountCodeChanging(value);
                this._AccountCode = value;
                this.OnAccountCodeChanged();
                this.OnPropertyChanged("AccountCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountCode;
        partial void OnAccountCodeChanging(string value);
        partial void OnAccountCodeChanged();
        /// <summary>
        /// There are no comments for Property Sequence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Sequence")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Sequence is required.")]
        public virtual int Sequence
        {
            get
            {
                return this._Sequence;
            }
            set
            {
                this.OnSequenceChanging(value);
                this._Sequence = value;
                this.OnSequenceChanged();
                this.OnPropertyChanged("Sequence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Sequence;
        partial void OnSequenceChanging(int value);
        partial void OnSequenceChanged();
        /// <summary>
        /// There are no comments for Property AccountName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountName")]
        public virtual string AccountName
        {
            get
            {
                return this._AccountName;
            }
            set
            {
                this.OnAccountNameChanging(value);
                this._AccountName = value;
                this.OnAccountNameChanged();
                this.OnPropertyChanged("AccountName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountName;
        partial void OnAccountNameChanging(string value);
        partial void OnAccountNameChanged();
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
        /// There are no comments for Property DueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DueDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this.OnDueDateChanging(value);
                this._DueDate = value;
                this.OnDueDateChanged();
                this.OnPropertyChanged("DueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DueDate;
        partial void OnDueDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDueDateChanged();
        /// <summary>
        /// There are no comments for Property Memo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Memo")]
        public virtual string Memo
        {
            get
            {
                return this._Memo;
            }
            set
            {
                this.OnMemoChanging(value);
                this._Memo = value;
                this.OnMemoChanged();
                this.OnPropertyChanged("Memo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Memo;
        partial void OnMemoChanging(string value);
        partial void OnMemoChanged();
        /// <summary>
        /// There are no comments for Property DebitAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DebitAmount")]
        public virtual global::System.Nullable<double> DebitAmount
        {
            get
            {
                return this._DebitAmount;
            }
            set
            {
                this.OnDebitAmountChanging(value);
                this._DebitAmount = value;
                this.OnDebitAmountChanged();
                this.OnPropertyChanged("DebitAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _DebitAmount;
        partial void OnDebitAmountChanging(global::System.Nullable<double> value);
        partial void OnDebitAmountChanged();
        /// <summary>
        /// There are no comments for Property CreditAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditAmount")]
        public virtual global::System.Nullable<double> CreditAmount
        {
            get
            {
                return this._CreditAmount;
            }
            set
            {
                this.OnCreditAmountChanging(value);
                this._CreditAmount = value;
                this.OnCreditAmountChanged();
                this.OnPropertyChanged("CreditAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _CreditAmount;
        partial void OnCreditAmountChanging(global::System.Nullable<double> value);
        partial void OnCreditAmountChanged();
        /// <summary>
        /// There are no comments for Property BankMatch in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BankMatch")]
        public virtual global::System.Nullable<int> BankMatch
        {
            get
            {
                return this._BankMatch;
            }
            set
            {
                this.OnBankMatchChanging(value);
                this._BankMatch = value;
                this.OnBankMatchChanged();
                this.OnPropertyChanged("BankMatch");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BankMatch;
        partial void OnBankMatchChanging(global::System.Nullable<int> value);
        partial void OnBankMatchChanged();
        /// <summary>
        /// There are no comments for Property DataSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DataSource")]
        public virtual string DataSource
        {
            get
            {
                return this._DataSource;
            }
            set
            {
                this.OnDataSourceChanging(value);
                this._DataSource = value;
                this.OnDataSourceChanged();
                this.OnPropertyChanged("DataSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DataSource;
        partial void OnDataSourceChanging(string value);
        partial void OnDataSourceChanged();
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
        /// There are no comments for Property ExternalCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalCode")]
        public virtual string ExternalCode
        {
            get
            {
                return this._ExternalCode;
            }
            set
            {
                this.OnExternalCodeChanging(value);
                this._ExternalCode = value;
                this.OnExternalCodeChanged();
                this.OnPropertyChanged("ExternalCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExternalCode;
        partial void OnExternalCodeChanging(string value);
        partial void OnExternalCodeChanged();
        /// <summary>
        /// There are no comments for Property CardCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CardCode")]
        public virtual string CardCode
        {
            get
            {
                return this._CardCode;
            }
            set
            {
                this.OnCardCodeChanging(value);
                this._CardCode = value;
                this.OnCardCodeChanged();
                this.OnPropertyChanged("CardCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CardCode;
        partial void OnCardCodeChanging(string value);
        partial void OnCardCodeChanged();
        /// <summary>
        /// There are no comments for Property CardName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CardName")]
        public virtual string CardName
        {
            get
            {
                return this._CardName;
            }
            set
            {
                this.OnCardNameChanging(value);
                this._CardName = value;
                this.OnCardNameChanged();
                this.OnPropertyChanged("CardName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CardName;
        partial void OnCardNameChanging(string value);
        partial void OnCardNameChanged();
        /// <summary>
        /// There are no comments for Property StatementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StatementNumber")]
        public virtual global::System.Nullable<int> StatementNumber
        {
            get
            {
                return this._StatementNumber;
            }
            set
            {
                this.OnStatementNumberChanging(value);
                this._StatementNumber = value;
                this.OnStatementNumberChanged();
                this.OnPropertyChanged("StatementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _StatementNumber;
        partial void OnStatementNumberChanging(global::System.Nullable<int> value);
        partial void OnStatementNumberChanged();
        /// <summary>
        /// There are no comments for Property InvoiceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceNumber")]
        public virtual string InvoiceNumber
        {
            get
            {
                return this._InvoiceNumber;
            }
            set
            {
                this.OnInvoiceNumberChanging(value);
                this._InvoiceNumber = value;
                this.OnInvoiceNumberChanged();
                this.OnPropertyChanged("InvoiceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceNumber;
        partial void OnInvoiceNumberChanging(string value);
        partial void OnInvoiceNumberChanged();
        /// <summary>
        /// There are no comments for Property PaymentCreated in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentCreated")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> PaymentCreated
        {
            get
            {
                return this._PaymentCreated;
            }
            set
            {
                this.OnPaymentCreatedChanging(value);
                this._PaymentCreated = value;
                this.OnPaymentCreatedChanged();
                this.OnPropertyChanged("PaymentCreated");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _PaymentCreated;
        partial void OnPaymentCreatedChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnPaymentCreatedChanged();
        /// <summary>
        /// There are no comments for Property VisualOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VisualOrder")]
        public virtual global::System.Nullable<int> VisualOrder
        {
            get
            {
                return this._VisualOrder;
            }
            set
            {
                this.OnVisualOrderChanging(value);
                this._VisualOrder = value;
                this.OnVisualOrderChanged();
                this.OnPropertyChanged("VisualOrder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _VisualOrder;
        partial void OnVisualOrderChanging(global::System.Nullable<int> value);
        partial void OnVisualOrderChanged();
        /// <summary>
        /// There are no comments for Property DocNumberType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocNumberType")]
        public virtual global::System.Nullable<global::SAPB1.BoBpsDocTypes> DocNumberType
        {
            get
            {
                return this._DocNumberType;
            }
            set
            {
                this.OnDocNumberTypeChanging(value);
                this._DocNumberType = value;
                this.OnDocNumberTypeChanged();
                this.OnPropertyChanged("DocNumberType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoBpsDocTypes> _DocNumberType;
        partial void OnDocNumberTypeChanging(global::System.Nullable<global::SAPB1.BoBpsDocTypes> value);
        partial void OnDocNumberTypeChanged();
        /// <summary>
        /// There are no comments for Property PaymentReference in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentReference")]
        public virtual string PaymentReference
        {
            get
            {
                return this._PaymentReference;
            }
            set
            {
                this.OnPaymentReferenceChanging(value);
                this._PaymentReference = value;
                this.OnPaymentReferenceChanged();
                this.OnPropertyChanged("PaymentReference");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentReference;
        partial void OnPaymentReferenceChanging(string value);
        partial void OnPaymentReferenceChanged();
        /// <summary>
        /// There are no comments for Property InvoiceNumberEx in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvoiceNumberEx")]
        public virtual string InvoiceNumberEx
        {
            get
            {
                return this._InvoiceNumberEx;
            }
            set
            {
                this.OnInvoiceNumberExChanging(value);
                this._InvoiceNumberEx = value;
                this.OnInvoiceNumberExChanged();
                this.OnPropertyChanged("InvoiceNumberEx");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvoiceNumberEx;
        partial void OnInvoiceNumberExChanging(string value);
        partial void OnInvoiceNumberExChanged();
        /// <summary>
        /// There are no comments for Property BICSwiftCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BICSwiftCode")]
        public virtual string BICSwiftCode
        {
            get
            {
                return this._BICSwiftCode;
            }
            set
            {
                this.OnBICSwiftCodeChanging(value);
                this._BICSwiftCode = value;
                this.OnBICSwiftCodeChanged();
                this.OnPropertyChanged("BICSwiftCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BICSwiftCode;
        partial void OnBICSwiftCodeChanging(string value);
        partial void OnBICSwiftCodeChanged();
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
        /// There are no comments for Property BusinessPartner in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPartner")]
        public virtual global::SAPB1.BusinessPartner BusinessPartner
        {
            get
            {
                return this._BusinessPartner;
            }
            set
            {
                this.OnBusinessPartnerChanging(value);
                this._BusinessPartner = value;
                this.OnBusinessPartnerChanged();
                this.OnPropertyChanged("BusinessPartner");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BusinessPartner _BusinessPartner;
        partial void OnBusinessPartnerChanging(global::SAPB1.BusinessPartner value);
        partial void OnBusinessPartnerChanged();
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