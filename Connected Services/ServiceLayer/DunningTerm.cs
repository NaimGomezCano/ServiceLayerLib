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
    /// There are no comments for DunningTermSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DunningTermSingle")]
    public partial class DunningTermSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DunningTerm>
    {
        /// <summary>
        /// Initialize a new DunningTermSingle object.
        /// </summary>
        public DunningTermSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DunningTermSingle object.
        /// </summary>
        public DunningTermSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DunningTermSingle object.
        /// </summary>
        public DunningTermSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DunningTerm> query)
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
    }
    /// <summary>
    /// There are no comments for DunningTerm in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Code")]
    [global::Microsoft.OData.Client.EntitySet("DunningTerms")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DunningTerm")]
    public partial class DunningTerm : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DunningTerm object.
        /// </summary>
        /// <param name="code">Initial value of Code.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DunningTerm CreateDunningTerm(string code)
        {
            DunningTerm dunningTerm = new DunningTerm();
            dunningTerm.Code = code;
            return dunningTerm;
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
        /// There are no comments for Property GroupingMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GroupingMethod")]
        public virtual global::System.Nullable<global::SAPB1.GroupingMethodEnum> GroupingMethod
        {
            get
            {
                return this._GroupingMethod;
            }
            set
            {
                this.OnGroupingMethodChanging(value);
                this._GroupingMethod = value;
                this.OnGroupingMethodChanged();
                this.OnPropertyChanged("GroupingMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.GroupingMethodEnum> _GroupingMethod;
        partial void OnGroupingMethodChanging(global::System.Nullable<global::SAPB1.GroupingMethodEnum> value);
        partial void OnGroupingMethodChanged();
        /// <summary>
        /// There are no comments for Property DaysInYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DaysInYear")]
        public virtual global::System.Nullable<int> DaysInYear
        {
            get
            {
                return this._DaysInYear;
            }
            set
            {
                this.OnDaysInYearChanging(value);
                this._DaysInYear = value;
                this.OnDaysInYearChanged();
                this.OnPropertyChanged("DaysInYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DaysInYear;
        partial void OnDaysInYearChanging(global::System.Nullable<int> value);
        partial void OnDaysInYearChanged();
        /// <summary>
        /// There are no comments for Property DaysInMonth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DaysInMonth")]
        public virtual global::System.Nullable<int> DaysInMonth
        {
            get
            {
                return this._DaysInMonth;
            }
            set
            {
                this.OnDaysInMonthChanging(value);
                this._DaysInMonth = value;
                this.OnDaysInMonthChanged();
                this.OnPropertyChanged("DaysInMonth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DaysInMonth;
        partial void OnDaysInMonthChanging(global::System.Nullable<int> value);
        partial void OnDaysInMonthChanged();
        /// <summary>
        /// There are no comments for Property CalculateInterestMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CalculateInterestMethod")]
        public virtual global::System.Nullable<global::SAPB1.CalculateInterestMethodEnum> CalculateInterestMethod
        {
            get
            {
                return this._CalculateInterestMethod;
            }
            set
            {
                this.OnCalculateInterestMethodChanging(value);
                this._CalculateInterestMethod = value;
                this.OnCalculateInterestMethodChanged();
                this.OnPropertyChanged("CalculateInterestMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.CalculateInterestMethodEnum> _CalculateInterestMethod;
        partial void OnCalculateInterestMethodChanging(global::System.Nullable<global::SAPB1.CalculateInterestMethodEnum> value);
        partial void OnCalculateInterestMethodChanged();
        /// <summary>
        /// There are no comments for Property ExchangeRateSelect in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExchangeRateSelect")]
        public virtual global::System.Nullable<global::SAPB1.ExchangeRateSelectEnum> ExchangeRateSelect
        {
            get
            {
                return this._ExchangeRateSelect;
            }
            set
            {
                this.OnExchangeRateSelectChanging(value);
                this._ExchangeRateSelect = value;
                this.OnExchangeRateSelectChanged();
                this.OnPropertyChanged("ExchangeRateSelect");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ExchangeRateSelectEnum> _ExchangeRateSelect;
        partial void OnExchangeRateSelectChanging(global::System.Nullable<global::SAPB1.ExchangeRateSelectEnum> value);
        partial void OnExchangeRateSelectChanged();
        /// <summary>
        /// There are no comments for Property YearlyInterestRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("YearlyInterestRate")]
        public virtual global::System.Nullable<double> YearlyInterestRate
        {
            get
            {
                return this._YearlyInterestRate;
            }
            set
            {
                this.OnYearlyInterestRateChanging(value);
                this._YearlyInterestRate = value;
                this.OnYearlyInterestRateChanged();
                this.OnPropertyChanged("YearlyInterestRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _YearlyInterestRate;
        partial void OnYearlyInterestRateChanging(global::System.Nullable<double> value);
        partial void OnYearlyInterestRateChanged();
        /// <summary>
        /// There are no comments for Property LetterFee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LetterFee")]
        public virtual global::System.Nullable<double> LetterFee
        {
            get
            {
                return this._LetterFee;
            }
            set
            {
                this.OnLetterFeeChanging(value);
                this._LetterFee = value;
                this.OnLetterFeeChanged();
                this.OnPropertyChanged("LetterFee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _LetterFee;
        partial void OnLetterFeeChanging(global::System.Nullable<double> value);
        partial void OnLetterFeeChanged();
        /// <summary>
        /// There are no comments for Property LetterFeeCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LetterFeeCurrency")]
        public virtual string LetterFeeCurrency
        {
            get
            {
                return this._LetterFeeCurrency;
            }
            set
            {
                this.OnLetterFeeCurrencyChanging(value);
                this._LetterFeeCurrency = value;
                this.OnLetterFeeCurrencyChanged();
                this.OnPropertyChanged("LetterFeeCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LetterFeeCurrency;
        partial void OnLetterFeeCurrencyChanging(string value);
        partial void OnLetterFeeCurrencyChanged();
        /// <summary>
        /// There are no comments for Property MinimumBalance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MinimumBalance")]
        public virtual global::System.Nullable<double> MinimumBalance
        {
            get
            {
                return this._MinimumBalance;
            }
            set
            {
                this.OnMinimumBalanceChanging(value);
                this._MinimumBalance = value;
                this.OnMinimumBalanceChanged();
                this.OnPropertyChanged("MinimumBalance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _MinimumBalance;
        partial void OnMinimumBalanceChanging(global::System.Nullable<double> value);
        partial void OnMinimumBalanceChanged();
        /// <summary>
        /// There are no comments for Property MinimumBalanceCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MinimumBalanceCurrency")]
        public virtual string MinimumBalanceCurrency
        {
            get
            {
                return this._MinimumBalanceCurrency;
            }
            set
            {
                this.OnMinimumBalanceCurrencyChanging(value);
                this._MinimumBalanceCurrency = value;
                this.OnMinimumBalanceCurrencyChanged();
                this.OnPropertyChanged("MinimumBalanceCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MinimumBalanceCurrency;
        partial void OnMinimumBalanceCurrencyChanging(string value);
        partial void OnMinimumBalanceCurrencyChanged();
        /// <summary>
        /// There are no comments for Property IncludeInterest in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IncludeInterest")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IncludeInterest
        {
            get
            {
                return this._IncludeInterest;
            }
            set
            {
                this.OnIncludeInterestChanging(value);
                this._IncludeInterest = value;
                this.OnIncludeInterestChanged();
                this.OnPropertyChanged("IncludeInterest");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IncludeInterest;
        partial void OnIncludeInterestChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIncludeInterestChanged();
        /// <summary>
        /// There are no comments for Property ApplyHighestLetterTemplate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApplyHighestLetterTemplate")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> ApplyHighestLetterTemplate
        {
            get
            {
                return this._ApplyHighestLetterTemplate;
            }
            set
            {
                this.OnApplyHighestLetterTemplateChanging(value);
                this._ApplyHighestLetterTemplate = value;
                this.OnApplyHighestLetterTemplateChanged();
                this.OnPropertyChanged("ApplyHighestLetterTemplate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _ApplyHighestLetterTemplate;
        partial void OnApplyHighestLetterTemplateChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnApplyHighestLetterTemplateChanged();
        /// <summary>
        /// There are no comments for Property AutomaticPosting in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AutomaticPosting")]
        public virtual global::System.Nullable<global::SAPB1.AutomaticPostingEnum> AutomaticPosting
        {
            get
            {
                return this._AutomaticPosting;
            }
            set
            {
                this.OnAutomaticPostingChanging(value);
                this._AutomaticPosting = value;
                this.OnAutomaticPostingChanged();
                this.OnPropertyChanged("AutomaticPosting");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.AutomaticPostingEnum> _AutomaticPosting;
        partial void OnAutomaticPostingChanging(global::System.Nullable<global::SAPB1.AutomaticPostingEnum> value);
        partial void OnAutomaticPostingChanged();
        /// <summary>
        /// There are no comments for Property InterestAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InterestAccount")]
        public virtual string InterestAccount
        {
            get
            {
                return this._InterestAccount;
            }
            set
            {
                this.OnInterestAccountChanging(value);
                this._InterestAccount = value;
                this.OnInterestAccountChanged();
                this.OnPropertyChanged("InterestAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InterestAccount;
        partial void OnInterestAccountChanging(string value);
        partial void OnInterestAccountChanged();
        /// <summary>
        /// There are no comments for Property FeeAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FeeAccount")]
        public virtual string FeeAccount
        {
            get
            {
                return this._FeeAccount;
            }
            set
            {
                this.OnFeeAccountChanging(value);
                this._FeeAccount = value;
                this.OnFeeAccountChanged();
                this.OnPropertyChanged("FeeAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FeeAccount;
        partial void OnFeeAccountChanging(string value);
        partial void OnFeeAccountChanged();
        /// <summary>
        /// There are no comments for Property BaseDateSelect in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseDateSelect")]
        public virtual global::System.Nullable<global::SAPB1.BaseDateSelectEnum> BaseDateSelect
        {
            get
            {
                return this._BaseDateSelect;
            }
            set
            {
                this.OnBaseDateSelectChanging(value);
                this._BaseDateSelect = value;
                this.OnBaseDateSelectChanged();
                this.OnPropertyChanged("BaseDateSelect");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BaseDateSelectEnum> _BaseDateSelect;
        partial void OnBaseDateSelectChanging(global::System.Nullable<global::SAPB1.BaseDateSelectEnum> value);
        partial void OnBaseDateSelectChanged();
        /// <summary>
        /// There are no comments for Property DunningTermLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DunningTermLines")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.DunningTermLine> DunningTermLines
        {
            get
            {
                return this._DunningTermLines;
            }
            set
            {
                this.OnDunningTermLinesChanging(value);
                this._DunningTermLines = value;
                this.OnDunningTermLinesChanged();
                this.OnPropertyChanged("DunningTermLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.DunningTermLine> _DunningTermLines = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.DunningTermLine>();
        partial void OnDunningTermLinesChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.DunningTermLine> value);
        partial void OnDunningTermLinesChanged();
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
