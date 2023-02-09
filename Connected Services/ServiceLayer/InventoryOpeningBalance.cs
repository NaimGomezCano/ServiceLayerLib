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
    /// There are no comments for InventoryOpeningBalanceSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryOpeningBalanceSingle")]
    public partial class InventoryOpeningBalanceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InventoryOpeningBalance>
    {
        /// <summary>
        /// Initialize a new InventoryOpeningBalanceSingle object.
        /// </summary>
        public InventoryOpeningBalanceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InventoryOpeningBalanceSingle object.
        /// </summary>
        public InventoryOpeningBalanceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InventoryOpeningBalanceSingle object.
        /// </summary>
        public InventoryOpeningBalanceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InventoryOpeningBalance> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BusinessPlace in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPlace")]
        public virtual global::SAPB1.BusinessPlaceSingle BusinessPlace
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BusinessPlace == null))
                {
                    this._BusinessPlace = new global::SAPB1.BusinessPlaceSingle(this.Context, GetPath("BusinessPlace"));
                }
                return this._BusinessPlace;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BusinessPlaceSingle _BusinessPlace;
        /// <summary>
        /// There are no comments for Attachments2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Attachments2")]
        public virtual global::SAPB1.Attachments2Single Attachments2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Attachments2 == null))
                {
                    this._Attachments2 = new global::SAPB1.Attachments2Single(this.Context, GetPath("Attachments2"));
                }
                return this._Attachments2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.Attachments2Single _Attachments2;
    }
    /// <summary>
    /// There are no comments for InventoryOpeningBalance in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DocumentEntry
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DocumentEntry")]
    [global::Microsoft.OData.Client.EntitySet("InventoryOpeningBalances")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryOpeningBalance")]
    public partial class InventoryOpeningBalance : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new InventoryOpeningBalance object.
        /// </summary>
        /// <param name="documentEntry">Initial value of DocumentEntry.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static InventoryOpeningBalance CreateInventoryOpeningBalance(int documentEntry)
        {
            InventoryOpeningBalance inventoryOpeningBalance = new InventoryOpeningBalance();
            inventoryOpeningBalance.DocumentEntry = documentEntry;
            return inventoryOpeningBalance;
        }
        /// <summary>
        /// There are no comments for Property DocumentEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentEntry")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DocumentEntry is required.")]
        public virtual int DocumentEntry
        {
            get
            {
                return this._DocumentEntry;
            }
            set
            {
                this.OnDocumentEntryChanging(value);
                this._DocumentEntry = value;
                this.OnDocumentEntryChanged();
                this.OnPropertyChanged("DocumentEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DocumentEntry;
        partial void OnDocumentEntryChanging(int value);
        partial void OnDocumentEntryChanged();
        /// <summary>
        /// There are no comments for Property PostingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostingDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> PostingDate
        {
            get
            {
                return this._PostingDate;
            }
            set
            {
                this.OnPostingDateChanging(value);
                this._PostingDate = value;
                this.OnPostingDateChanged();
                this.OnPropertyChanged("PostingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _PostingDate;
        partial void OnPostingDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnPostingDateChanged();
        /// <summary>
        /// There are no comments for Property DocumentDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DocumentDate
        {
            get
            {
                return this._DocumentDate;
            }
            set
            {
                this.OnDocumentDateChanging(value);
                this._DocumentDate = value;
                this.OnDocumentDateChanged();
                this.OnPropertyChanged("DocumentDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DocumentDate;
        partial void OnDocumentDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDocumentDateChanged();
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
        /// There are no comments for Property Series in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Series")]
        public virtual global::System.Nullable<int> Series
        {
            get
            {
                return this._Series;
            }
            set
            {
                this.OnSeriesChanging(value);
                this._Series = value;
                this.OnSeriesChanged();
                this.OnPropertyChanged("Series");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Series;
        partial void OnSeriesChanging(global::System.Nullable<int> value);
        partial void OnSeriesChanged();
        /// <summary>
        /// There are no comments for Property Reference2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Reference2")]
        public virtual string Reference2
        {
            get
            {
                return this._Reference2;
            }
            set
            {
                this.OnReference2Changing(value);
                this._Reference2 = value;
                this.OnReference2Changed();
                this.OnPropertyChanged("Reference2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Reference2;
        partial void OnReference2Changing(string value);
        partial void OnReference2Changed();
        /// <summary>
        /// There are no comments for Property Remarks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Remarks")]
        public virtual string Remarks
        {
            get
            {
                return this._Remarks;
            }
            set
            {
                this.OnRemarksChanging(value);
                this._Remarks = value;
                this.OnRemarksChanged();
                this.OnPropertyChanged("Remarks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Remarks;
        partial void OnRemarksChanging(string value);
        partial void OnRemarksChanged();
        /// <summary>
        /// There are no comments for Property BranchID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BranchID")]
        public virtual global::System.Nullable<int> BranchID
        {
            get
            {
                return this._BranchID;
            }
            set
            {
                this.OnBranchIDChanging(value);
                this._BranchID = value;
                this.OnBranchIDChanged();
                this.OnPropertyChanged("BranchID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BranchID;
        partial void OnBranchIDChanging(global::System.Nullable<int> value);
        partial void OnBranchIDChanged();
        /// <summary>
        /// There are no comments for Property PriceSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceSource")]
        public virtual global::System.Nullable<global::SAPB1.InventoryOpeningBalancePriceSourceEnum> PriceSource
        {
            get
            {
                return this._PriceSource;
            }
            set
            {
                this.OnPriceSourceChanging(value);
                this._PriceSource = value;
                this.OnPriceSourceChanged();
                this.OnPropertyChanged("PriceSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.InventoryOpeningBalancePriceSourceEnum> _PriceSource;
        partial void OnPriceSourceChanging(global::System.Nullable<global::SAPB1.InventoryOpeningBalancePriceSourceEnum> value);
        partial void OnPriceSourceChanged();
        /// <summary>
        /// There are no comments for Property PriceList in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceList")]
        public virtual global::System.Nullable<int> PriceList
        {
            get
            {
                return this._PriceList;
            }
            set
            {
                this.OnPriceListChanging(value);
                this._PriceList = value;
                this.OnPriceListChanged();
                this.OnPropertyChanged("PriceList");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _PriceList;
        partial void OnPriceListChanging(global::System.Nullable<int> value);
        partial void OnPriceListChanged();
        /// <summary>
        /// There are no comments for Property JournalRemark in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalRemark")]
        public virtual string JournalRemark
        {
            get
            {
                return this._JournalRemark;
            }
            set
            {
                this.OnJournalRemarkChanging(value);
                this._JournalRemark = value;
                this.OnJournalRemarkChanged();
                this.OnPropertyChanged("JournalRemark");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalRemark;
        partial void OnJournalRemarkChanging(string value);
        partial void OnJournalRemarkChanged();
        /// <summary>
        /// There are no comments for Property DocObjectCodeEx in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocObjectCodeEx")]
        public virtual string DocObjectCodeEx
        {
            get
            {
                return this._DocObjectCodeEx;
            }
            set
            {
                this.OnDocObjectCodeExChanging(value);
                this._DocObjectCodeEx = value;
                this.OnDocObjectCodeExChanged();
                this.OnPropertyChanged("DocObjectCodeEx");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocObjectCodeEx;
        partial void OnDocObjectCodeExChanging(string value);
        partial void OnDocObjectCodeExChanged();
        /// <summary>
        /// There are no comments for Property PeriodIndicator in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodIndicator")]
        public virtual string PeriodIndicator
        {
            get
            {
                return this._PeriodIndicator;
            }
            set
            {
                this.OnPeriodIndicatorChanging(value);
                this._PeriodIndicator = value;
                this.OnPeriodIndicatorChanged();
                this.OnPropertyChanged("PeriodIndicator");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PeriodIndicator;
        partial void OnPeriodIndicatorChanging(string value);
        partial void OnPeriodIndicatorChanged();
        /// <summary>
        /// There are no comments for Property FinancialPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FinancialPeriod")]
        public virtual global::System.Nullable<int> FinancialPeriod
        {
            get
            {
                return this._FinancialPeriod;
            }
            set
            {
                this.OnFinancialPeriodChanging(value);
                this._FinancialPeriod = value;
                this.OnFinancialPeriodChanged();
                this.OnPropertyChanged("FinancialPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _FinancialPeriod;
        partial void OnFinancialPeriodChanging(global::System.Nullable<int> value);
        partial void OnFinancialPeriodChanged();
        /// <summary>
        /// There are no comments for Property AttachmentEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttachmentEntry")]
        public virtual global::System.Nullable<int> AttachmentEntry
        {
            get
            {
                return this._AttachmentEntry;
            }
            set
            {
                this.OnAttachmentEntryChanging(value);
                this._AttachmentEntry = value;
                this.OnAttachmentEntryChanged();
                this.OnPropertyChanged("AttachmentEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _AttachmentEntry;
        partial void OnAttachmentEntryChanging(global::System.Nullable<int> value);
        partial void OnAttachmentEntryChanged();
        /// <summary>
        /// There are no comments for Property InventoryOpeningBalanceLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryOpeningBalanceLines")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.InventoryOpeningBalanceLine> InventoryOpeningBalanceLines
        {
            get
            {
                return this._InventoryOpeningBalanceLines;
            }
            set
            {
                this.OnInventoryOpeningBalanceLinesChanging(value);
                this._InventoryOpeningBalanceLines = value;
                this.OnInventoryOpeningBalanceLinesChanged();
                this.OnPropertyChanged("InventoryOpeningBalanceLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.InventoryOpeningBalanceLine> _InventoryOpeningBalanceLines = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.InventoryOpeningBalanceLine>();
        partial void OnInventoryOpeningBalanceLinesChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.InventoryOpeningBalanceLine> value);
        partial void OnInventoryOpeningBalanceLinesChanged();
        /// <summary>
        /// There are no comments for Property BusinessPlace in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPlace")]
        public virtual global::SAPB1.BusinessPlace BusinessPlace
        {
            get
            {
                return this._BusinessPlace;
            }
            set
            {
                this.OnBusinessPlaceChanging(value);
                this._BusinessPlace = value;
                this.OnBusinessPlaceChanged();
                this.OnPropertyChanged("BusinessPlace");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BusinessPlace _BusinessPlace;
        partial void OnBusinessPlaceChanging(global::SAPB1.BusinessPlace value);
        partial void OnBusinessPlaceChanged();
        /// <summary>
        /// There are no comments for Property Attachments2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Attachments2")]
        public virtual global::SAPB1.Attachments2 Attachments2
        {
            get
            {
                return this._Attachments2;
            }
            set
            {
                this.OnAttachments2Changing(value);
                this._Attachments2 = value;
                this.OnAttachments2Changed();
                this.OnPropertyChanged("Attachments2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.Attachments2 _Attachments2;
        partial void OnAttachments2Changing(global::SAPB1.Attachments2 value);
        partial void OnAttachments2Changed();
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
