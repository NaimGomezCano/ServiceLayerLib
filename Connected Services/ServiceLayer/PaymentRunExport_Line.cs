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
    /// There are no comments for PaymentRunExport_Line in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentRunExport_Line")]
    public partial class PaymentRunExport_Line : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property RowNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RowNumber")]
        public virtual global::System.Nullable<int> RowNumber
        {
            get
            {
                return this._RowNumber;
            }
            set
            {
                this.OnRowNumberChanging(value);
                this._RowNumber = value;
                this.OnRowNumberChanged();
                this.OnPropertyChanged("RowNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _RowNumber;
        partial void OnRowNumberChanging(global::System.Nullable<int> value);
        partial void OnRowNumberChanged();
        /// <summary>
        /// There are no comments for Property DateOfPaymentRun in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateOfPaymentRun")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DateOfPaymentRun
        {
            get
            {
                return this._DateOfPaymentRun;
            }
            set
            {
                this.OnDateOfPaymentRunChanging(value);
                this._DateOfPaymentRun = value;
                this.OnDateOfPaymentRunChanged();
                this.OnPropertyChanged("DateOfPaymentRun");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DateOfPaymentRun;
        partial void OnDateOfPaymentRunChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDateOfPaymentRunChanged();
        /// <summary>
        /// There are no comments for Property PaymentWizardCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentWizardCode")]
        public virtual global::System.Nullable<int> PaymentWizardCode
        {
            get
            {
                return this._PaymentWizardCode;
            }
            set
            {
                this.OnPaymentWizardCodeChanging(value);
                this._PaymentWizardCode = value;
                this.OnPaymentWizardCodeChanged();
                this.OnPropertyChanged("PaymentWizardCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _PaymentWizardCode;
        partial void OnPaymentWizardCodeChanging(global::System.Nullable<int> value);
        partial void OnPaymentWizardCodeChanged();
        /// <summary>
        /// There are no comments for Property VendorNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorNumber")]
        public virtual string VendorNumber
        {
            get
            {
                return this._VendorNumber;
            }
            set
            {
                this.OnVendorNumberChanging(value);
                this._VendorNumber = value;
                this.OnVendorNumberChanged();
                this.OnPropertyChanged("VendorNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorNumber;
        partial void OnVendorNumberChanging(string value);
        partial void OnVendorNumberChanged();
        /// <summary>
        /// There are no comments for Property CustomerNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomerNumber")]
        public virtual string CustomerNumber
        {
            get
            {
                return this._CustomerNumber;
            }
            set
            {
                this.OnCustomerNumberChanging(value);
                this._CustomerNumber = value;
                this.OnCustomerNumberChanged();
                this.OnPropertyChanged("CustomerNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomerNumber;
        partial void OnCustomerNumberChanging(string value);
        partial void OnCustomerNumberChanged();
        /// <summary>
        /// There are no comments for Property PaymentMeans in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentMeans")]
        public virtual string PaymentMeans
        {
            get
            {
                return this._PaymentMeans;
            }
            set
            {
                this.OnPaymentMeansChanging(value);
                this._PaymentMeans = value;
                this.OnPaymentMeansChanged();
                this.OnPropertyChanged("PaymentMeans");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentMeans;
        partial void OnPaymentMeansChanging(string value);
        partial void OnPaymentMeansChanged();
        /// <summary>
        /// There are no comments for Property PaymentDocNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentDocNum")]
        public virtual global::System.Nullable<int> PaymentDocNum
        {
            get
            {
                return this._PaymentDocNum;
            }
            set
            {
                this.OnPaymentDocNumChanging(value);
                this._PaymentDocNum = value;
                this.OnPaymentDocNumChanged();
                this.OnPropertyChanged("PaymentDocNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _PaymentDocNum;
        partial void OnPaymentDocNumChanging(global::System.Nullable<int> value);
        partial void OnPaymentDocNumChanged();
        /// <summary>
        /// There are no comments for Property FiscalYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalYear")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> FiscalYear
        {
            get
            {
                return this._FiscalYear;
            }
            set
            {
                this.OnFiscalYearChanging(value);
                this._FiscalYear = value;
                this.OnFiscalYearChanged();
                this.OnPropertyChanged("FiscalYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _FiscalYear;
        partial void OnFiscalYearChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnFiscalYearChanged();
        /// <summary>
        /// There are no comments for Property VendorRefNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VendorRefNum")]
        public virtual string VendorRefNum
        {
            get
            {
                return this._VendorRefNum;
            }
            set
            {
                this.OnVendorRefNumChanging(value);
                this._VendorRefNum = value;
                this.OnVendorRefNumChanged();
                this.OnPropertyChanged("VendorRefNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VendorRefNum;
        partial void OnVendorRefNumChanging(string value);
        partial void OnVendorRefNumChanged();
        /// <summary>
        /// There are no comments for Property DocumentObjectType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentObjectType")]
        public virtual string DocumentObjectType
        {
            get
            {
                return this._DocumentObjectType;
            }
            set
            {
                this.OnDocumentObjectTypeChanging(value);
                this._DocumentObjectType = value;
                this.OnDocumentObjectTypeChanged();
                this.OnPropertyChanged("DocumentObjectType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentObjectType;
        partial void OnDocumentObjectTypeChanging(string value);
        partial void OnDocumentObjectTypeChanged();
        /// <summary>
        /// There are no comments for Property DocumentPostingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentPostingDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DocumentPostingDate
        {
            get
            {
                return this._DocumentPostingDate;
            }
            set
            {
                this.OnDocumentPostingDateChanging(value);
                this._DocumentPostingDate = value;
                this.OnDocumentPostingDateChanged();
                this.OnPropertyChanged("DocumentPostingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DocumentPostingDate;
        partial void OnDocumentPostingDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDocumentPostingDateChanged();
        /// <summary>
        /// There are no comments for Property DocumentTaxDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentTaxDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DocumentTaxDate
        {
            get
            {
                return this._DocumentTaxDate;
            }
            set
            {
                this.OnDocumentTaxDateChanging(value);
                this._DocumentTaxDate = value;
                this.OnDocumentTaxDateChanged();
                this.OnPropertyChanged("DocumentTaxDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DocumentTaxDate;
        partial void OnDocumentTaxDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDocumentTaxDateChanged();
        /// <summary>
        /// There are no comments for Property BPDebitPayableAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BPDebitPayableAccount")]
        public virtual string BPDebitPayableAccount
        {
            get
            {
                return this._BPDebitPayableAccount;
            }
            set
            {
                this.OnBPDebitPayableAccountChanging(value);
                this._BPDebitPayableAccount = value;
                this.OnBPDebitPayableAccountChanged();
                this.OnPropertyChanged("BPDebitPayableAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BPDebitPayableAccount;
        partial void OnBPDebitPayableAccountChanging(string value);
        partial void OnBPDebitPayableAccountChanged();
        /// <summary>
        /// There are no comments for Property DocumentCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentCurrency")]
        public virtual string DocumentCurrency
        {
            get
            {
                return this._DocumentCurrency;
            }
            set
            {
                this.OnDocumentCurrencyChanging(value);
                this._DocumentCurrency = value;
                this.OnDocumentCurrencyChanged();
                this.OnPropertyChanged("DocumentCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentCurrency;
        partial void OnDocumentCurrencyChanging(string value);
        partial void OnDocumentCurrencyChanged();
        /// <summary>
        /// There are no comments for Property DocumentRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentRate")]
        public virtual global::System.Nullable<double> DocumentRate
        {
            get
            {
                return this._DocumentRate;
            }
            set
            {
                this.OnDocumentRateChanging(value);
                this._DocumentRate = value;
                this.OnDocumentRateChanged();
                this.OnPropertyChanged("DocumentRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _DocumentRate;
        partial void OnDocumentRateChanging(global::System.Nullable<double> value);
        partial void OnDocumentRateChanged();
        /// <summary>
        /// There are no comments for Property DocumentTotal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentTotal")]
        public virtual global::System.Nullable<double> DocumentTotal
        {
            get
            {
                return this._DocumentTotal;
            }
            set
            {
                this.OnDocumentTotalChanging(value);
                this._DocumentTotal = value;
                this.OnDocumentTotalChanged();
                this.OnPropertyChanged("DocumentTotal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _DocumentTotal;
        partial void OnDocumentTotalChanging(global::System.Nullable<double> value);
        partial void OnDocumentTotalChanged();
        /// <summary>
        /// There are no comments for Property DocumentTotalFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentTotalFC")]
        public virtual global::System.Nullable<double> DocumentTotalFC
        {
            get
            {
                return this._DocumentTotalFC;
            }
            set
            {
                this.OnDocumentTotalFCChanging(value);
                this._DocumentTotalFC = value;
                this.OnDocumentTotalFCChanged();
                this.OnPropertyChanged("DocumentTotalFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _DocumentTotalFC;
        partial void OnDocumentTotalFCChanging(global::System.Nullable<double> value);
        partial void OnDocumentTotalFCChanged();
        /// <summary>
        /// There are no comments for Property DocumentTaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentTaxAmount")]
        public virtual global::System.Nullable<double> DocumentTaxAmount
        {
            get
            {
                return this._DocumentTaxAmount;
            }
            set
            {
                this.OnDocumentTaxAmountChanging(value);
                this._DocumentTaxAmount = value;
                this.OnDocumentTaxAmountChanged();
                this.OnPropertyChanged("DocumentTaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _DocumentTaxAmount;
        partial void OnDocumentTaxAmountChanging(global::System.Nullable<double> value);
        partial void OnDocumentTaxAmountChanged();
        /// <summary>
        /// There are no comments for Property DocumentTaxAmountFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentTaxAmountFC")]
        public virtual global::System.Nullable<double> DocumentTaxAmountFC
        {
            get
            {
                return this._DocumentTaxAmountFC;
            }
            set
            {
                this.OnDocumentTaxAmountFCChanging(value);
                this._DocumentTaxAmountFC = value;
                this.OnDocumentTaxAmountFCChanged();
                this.OnPropertyChanged("DocumentTaxAmountFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _DocumentTaxAmountFC;
        partial void OnDocumentTaxAmountFCChanging(global::System.Nullable<double> value);
        partial void OnDocumentTaxAmountFCChanged();
        /// <summary>
        /// There are no comments for Property DocumentRemarks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentRemarks")]
        public virtual string DocumentRemarks
        {
            get
            {
                return this._DocumentRemarks;
            }
            set
            {
                this.OnDocumentRemarksChanging(value);
                this._DocumentRemarks = value;
                this.OnDocumentRemarksChanged();
                this.OnPropertyChanged("DocumentRemarks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentRemarks;
        partial void OnDocumentRemarksChanging(string value);
        partial void OnDocumentRemarksChanged();
        /// <summary>
        /// There are no comments for Property DocumentPaymentTerms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentPaymentTerms")]
        public virtual global::System.Nullable<int> DocumentPaymentTerms
        {
            get
            {
                return this._DocumentPaymentTerms;
            }
            set
            {
                this.OnDocumentPaymentTermsChanging(value);
                this._DocumentPaymentTerms = value;
                this.OnDocumentPaymentTermsChanged();
                this.OnPropertyChanged("DocumentPaymentTerms");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DocumentPaymentTerms;
        partial void OnDocumentPaymentTermsChanging(global::System.Nullable<int> value);
        partial void OnDocumentPaymentTermsChanged();
        /// <summary>
        /// There are no comments for Property PaymentDocReference in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentDocReference")]
        public virtual string PaymentDocReference
        {
            get
            {
                return this._PaymentDocReference;
            }
            set
            {
                this.OnPaymentDocReferenceChanging(value);
                this._PaymentDocReference = value;
                this.OnPaymentDocReferenceChanged();
                this.OnPropertyChanged("PaymentDocReference");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentDocReference;
        partial void OnPaymentDocReferenceChanging(string value);
        partial void OnPaymentDocReferenceChanged();
        /// <summary>
        /// There are no comments for Property DocumentLocalCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentLocalCurrency")]
        public virtual string DocumentLocalCurrency
        {
            get
            {
                return this._DocumentLocalCurrency;
            }
            set
            {
                this.OnDocumentLocalCurrencyChanging(value);
                this._DocumentLocalCurrency = value;
                this.OnDocumentLocalCurrencyChanged();
                this.OnPropertyChanged("DocumentLocalCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentLocalCurrency;
        partial void OnDocumentLocalCurrencyChanging(string value);
        partial void OnDocumentLocalCurrencyChanged();
        /// <summary>
        /// There are no comments for Property PaymentTermsPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentTermsPeriod")]
        public virtual global::System.Nullable<int> PaymentTermsPeriod
        {
            get
            {
                return this._PaymentTermsPeriod;
            }
            set
            {
                this.OnPaymentTermsPeriodChanging(value);
                this._PaymentTermsPeriod = value;
                this.OnPaymentTermsPeriodChanged();
                this.OnPropertyChanged("PaymentTermsPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _PaymentTermsPeriod;
        partial void OnPaymentTermsPeriodChanging(global::System.Nullable<int> value);
        partial void OnPaymentTermsPeriodChanged();
        /// <summary>
        /// There are no comments for Property DocumentObjectTypeEx in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentObjectTypeEx")]
        public virtual string DocumentObjectTypeEx
        {
            get
            {
                return this._DocumentObjectTypeEx;
            }
            set
            {
                this.OnDocumentObjectTypeExChanging(value);
                this._DocumentObjectTypeEx = value;
                this.OnDocumentObjectTypeExChanged();
                this.OnPropertyChanged("DocumentObjectTypeEx");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentObjectTypeEx;
        partial void OnDocumentObjectTypeExChanging(string value);
        partial void OnDocumentObjectTypeExChanged();
        /// <summary>
        /// There are no comments for Property DocumentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentNumber")]
        public virtual global::System.Nullable<int> DocumentNumber
        {
            get
            {
                return this._DocumentNumber;
            }
            set
            {
                this.OnDocumentNumberChanging(value);
                this._DocumentNumber = value;
                this.OnDocumentNumberChanged();
                this.OnPropertyChanged("DocumentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DocumentNumber;
        partial void OnDocumentNumberChanging(global::System.Nullable<int> value);
        partial void OnDocumentNumberChanged();
        /// <summary>
        /// There are no comments for Property PaymentNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentNumber")]
        public virtual global::System.Nullable<int> PaymentNumber
        {
            get
            {
                return this._PaymentNumber;
            }
            set
            {
                this.OnPaymentNumberChanging(value);
                this._PaymentNumber = value;
                this.OnPaymentNumberChanged();
                this.OnPropertyChanged("PaymentNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _PaymentNumber;
        partial void OnPaymentNumberChanging(global::System.Nullable<int> value);
        partial void OnPaymentNumberChanged();
        /// <summary>
        /// There are no comments for Property PaymentOrderNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentOrderNum")]
        public virtual global::System.Nullable<int> PaymentOrderNum
        {
            get
            {
                return this._PaymentOrderNum;
            }
            set
            {
                this.OnPaymentOrderNumChanging(value);
                this._PaymentOrderNum = value;
                this.OnPaymentOrderNumChanged();
                this.OnPropertyChanged("PaymentOrderNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _PaymentOrderNum;
        partial void OnPaymentOrderNumChanging(global::System.Nullable<int> value);
        partial void OnPaymentOrderNumChanged();
        /// <summary>
        /// There are no comments for Property FreeText1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FreeText1")]
        public virtual string FreeText1
        {
            get
            {
                return this._FreeText1;
            }
            set
            {
                this.OnFreeText1Changing(value);
                this._FreeText1 = value;
                this.OnFreeText1Changed();
                this.OnPropertyChanged("FreeText1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FreeText1;
        partial void OnFreeText1Changing(string value);
        partial void OnFreeText1Changed();
        /// <summary>
        /// There are no comments for Property FreeText2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FreeText2")]
        public virtual string FreeText2
        {
            get
            {
                return this._FreeText2;
            }
            set
            {
                this.OnFreeText2Changing(value);
                this._FreeText2 = value;
                this.OnFreeText2Changed();
                this.OnPropertyChanged("FreeText2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FreeText2;
        partial void OnFreeText2Changing(string value);
        partial void OnFreeText2Changed();
        /// <summary>
        /// There are no comments for Property FreeText3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FreeText3")]
        public virtual string FreeText3
        {
            get
            {
                return this._FreeText3;
            }
            set
            {
                this.OnFreeText3Changing(value);
                this._FreeText3 = value;
                this.OnFreeText3Changed();
                this.OnPropertyChanged("FreeText3");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FreeText3;
        partial void OnFreeText3Changing(string value);
        partial void OnFreeText3Changed();
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
