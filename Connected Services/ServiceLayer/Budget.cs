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
    /// There are no comments for BudgetSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetSingle")]
    public partial class BudgetSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Budget>
    {
        /// <summary>
        /// Initialize a new BudgetSingle object.
        /// </summary>
        public BudgetSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BudgetSingle object.
        /// </summary>
        public BudgetSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BudgetSingle object.
        /// </summary>
        public BudgetSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Budget> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BudgetDistribution in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetDistribution")]
        public virtual global::SAPB1.BudgetDistributionSingle BudgetDistribution
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetDistribution == null))
                {
                    this._BudgetDistribution = new global::SAPB1.BudgetDistributionSingle(this.Context, GetPath("BudgetDistribution"));
                }
                return this._BudgetDistribution;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BudgetDistributionSingle _BudgetDistribution;
        /// <summary>
        /// There are no comments for BudgetScenario2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetScenario2")]
        public virtual global::SAPB1.BudgetScenarioSingle BudgetScenario2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BudgetScenario2 == null))
                {
                    this._BudgetScenario2 = new global::SAPB1.BudgetScenarioSingle(this.Context, GetPath("BudgetScenario2"));
                }
                return this._BudgetScenario2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BudgetScenarioSingle _BudgetScenario2;
    }
    /// <summary>
    /// There are no comments for Budget in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Numerator
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Numerator")]
    [global::Microsoft.OData.Client.EntitySet("Budgets")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Budget")]
    public partial class Budget : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Budget object.
        /// </summary>
        /// <param name="numerator">Initial value of Numerator.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Budget CreateBudget(int numerator)
        {
            Budget budget = new Budget();
            budget.Numerator = numerator;
            return budget;
        }
        /// <summary>
        /// There are no comments for Property FutureAnnualExpensesCreditSys in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FutureAnnualExpensesCreditSys")]
        public virtual global::System.Nullable<double> FutureAnnualExpensesCreditSys
        {
            get
            {
                return this._FutureAnnualExpensesCreditSys;
            }
            set
            {
                this.OnFutureAnnualExpensesCreditSysChanging(value);
                this._FutureAnnualExpensesCreditSys = value;
                this.OnFutureAnnualExpensesCreditSysChanged();
                this.OnPropertyChanged("FutureAnnualExpensesCreditSys");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _FutureAnnualExpensesCreditSys;
        partial void OnFutureAnnualExpensesCreditSysChanging(global::System.Nullable<double> value);
        partial void OnFutureAnnualExpensesCreditSysChanged();
        /// <summary>
        /// There are no comments for Property FutureAnnualExpensesCreditLoc in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FutureAnnualExpensesCreditLoc")]
        public virtual global::System.Nullable<double> FutureAnnualExpensesCreditLoc
        {
            get
            {
                return this._FutureAnnualExpensesCreditLoc;
            }
            set
            {
                this.OnFutureAnnualExpensesCreditLocChanging(value);
                this._FutureAnnualExpensesCreditLoc = value;
                this.OnFutureAnnualExpensesCreditLocChanged();
                this.OnPropertyChanged("FutureAnnualExpensesCreditLoc");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _FutureAnnualExpensesCreditLoc;
        partial void OnFutureAnnualExpensesCreditLocChanging(global::System.Nullable<double> value);
        partial void OnFutureAnnualExpensesCreditLocChanged();
        /// <summary>
        /// There are no comments for Property FutureAnnualExpensesDebitSys in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FutureAnnualExpensesDebitSys")]
        public virtual global::System.Nullable<double> FutureAnnualExpensesDebitSys
        {
            get
            {
                return this._FutureAnnualExpensesDebitSys;
            }
            set
            {
                this.OnFutureAnnualExpensesDebitSysChanging(value);
                this._FutureAnnualExpensesDebitSys = value;
                this.OnFutureAnnualExpensesDebitSysChanged();
                this.OnPropertyChanged("FutureAnnualExpensesDebitSys");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _FutureAnnualExpensesDebitSys;
        partial void OnFutureAnnualExpensesDebitSysChanging(global::System.Nullable<double> value);
        partial void OnFutureAnnualExpensesDebitSysChanged();
        /// <summary>
        /// There are no comments for Property FutureAnnualExpensesDebitLoc in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FutureAnnualExpensesDebitLoc")]
        public virtual global::System.Nullable<double> FutureAnnualExpensesDebitLoc
        {
            get
            {
                return this._FutureAnnualExpensesDebitLoc;
            }
            set
            {
                this.OnFutureAnnualExpensesDebitLocChanging(value);
                this._FutureAnnualExpensesDebitLoc = value;
                this.OnFutureAnnualExpensesDebitLocChanged();
                this.OnPropertyChanged("FutureAnnualExpensesDebitLoc");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _FutureAnnualExpensesDebitLoc;
        partial void OnFutureAnnualExpensesDebitLocChanging(global::System.Nullable<double> value);
        partial void OnFutureAnnualExpensesDebitLocChanged();
        /// <summary>
        /// There are no comments for Property FutureAnnualRevenuesCredit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FutureAnnualRevenuesCredit")]
        public virtual global::System.Nullable<double> FutureAnnualRevenuesCredit
        {
            get
            {
                return this._FutureAnnualRevenuesCredit;
            }
            set
            {
                this.OnFutureAnnualRevenuesCreditChanging(value);
                this._FutureAnnualRevenuesCredit = value;
                this.OnFutureAnnualRevenuesCreditChanged();
                this.OnPropertyChanged("FutureAnnualRevenuesCredit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _FutureAnnualRevenuesCredit;
        partial void OnFutureAnnualRevenuesCreditChanging(global::System.Nullable<double> value);
        partial void OnFutureAnnualRevenuesCreditChanged();
        /// <summary>
        /// There are no comments for Property FutureAnnualRevenuesDebit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FutureAnnualRevenuesDebit")]
        public virtual global::System.Nullable<double> FutureAnnualRevenuesDebit
        {
            get
            {
                return this._FutureAnnualRevenuesDebit;
            }
            set
            {
                this.OnFutureAnnualRevenuesDebitChanging(value);
                this._FutureAnnualRevenuesDebit = value;
                this.OnFutureAnnualRevenuesDebitChanged();
                this.OnPropertyChanged("FutureAnnualRevenuesDebit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _FutureAnnualRevenuesDebit;
        partial void OnFutureAnnualRevenuesDebitChanging(global::System.Nullable<double> value);
        partial void OnFutureAnnualRevenuesDebitChanged();
        /// <summary>
        /// There are no comments for Property FutureRevenuesDebitSys in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FutureRevenuesDebitSys")]
        public virtual global::System.Nullable<double> FutureRevenuesDebitSys
        {
            get
            {
                return this._FutureRevenuesDebitSys;
            }
            set
            {
                this.OnFutureRevenuesDebitSysChanging(value);
                this._FutureRevenuesDebitSys = value;
                this.OnFutureRevenuesDebitSysChanged();
                this.OnPropertyChanged("FutureRevenuesDebitSys");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _FutureRevenuesDebitSys;
        partial void OnFutureRevenuesDebitSysChanging(global::System.Nullable<double> value);
        partial void OnFutureRevenuesDebitSysChanged();
        /// <summary>
        /// There are no comments for Property FutureRevenuesDebitLoc in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FutureRevenuesDebitLoc")]
        public virtual global::System.Nullable<double> FutureRevenuesDebitLoc
        {
            get
            {
                return this._FutureRevenuesDebitLoc;
            }
            set
            {
                this.OnFutureRevenuesDebitLocChanging(value);
                this._FutureRevenuesDebitLoc = value;
                this.OnFutureRevenuesDebitLocChanged();
                this.OnPropertyChanged("FutureRevenuesDebitLoc");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _FutureRevenuesDebitLoc;
        partial void OnFutureRevenuesDebitLocChanging(global::System.Nullable<double> value);
        partial void OnFutureRevenuesDebitLocChanged();
        /// <summary>
        /// There are no comments for Property ParentAccPercent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentAccPercent")]
        public virtual global::System.Nullable<double> ParentAccPercent
        {
            get
            {
                return this._ParentAccPercent;
            }
            set
            {
                this.OnParentAccPercentChanging(value);
                this._ParentAccPercent = value;
                this.OnParentAccPercentChanged();
                this.OnPropertyChanged("ParentAccPercent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _ParentAccPercent;
        partial void OnParentAccPercentChanging(global::System.Nullable<double> value);
        partial void OnParentAccPercentChanged();
        /// <summary>
        /// There are no comments for Property StartofFiscalYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartofFiscalYear")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> StartofFiscalYear
        {
            get
            {
                return this._StartofFiscalYear;
            }
            set
            {
                this.OnStartofFiscalYearChanging(value);
                this._StartofFiscalYear = value;
                this.OnStartofFiscalYearChanged();
                this.OnPropertyChanged("StartofFiscalYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _StartofFiscalYear;
        partial void OnStartofFiscalYearChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnStartofFiscalYearChanged();
        /// <summary>
        /// There are no comments for Property ParentAccountKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentAccountKey")]
        public virtual string ParentAccountKey
        {
            get
            {
                return this._ParentAccountKey;
            }
            set
            {
                this.OnParentAccountKeyChanging(value);
                this._ParentAccountKey = value;
                this.OnParentAccountKeyChanged();
                this.OnPropertyChanged("ParentAccountKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ParentAccountKey;
        partial void OnParentAccountKeyChanging(string value);
        partial void OnParentAccountKeyChanged();
        /// <summary>
        /// There are no comments for Property TotalAnnualBudgetDebitSys in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalAnnualBudgetDebitSys")]
        public virtual global::System.Nullable<double> TotalAnnualBudgetDebitSys
        {
            get
            {
                return this._TotalAnnualBudgetDebitSys;
            }
            set
            {
                this.OnTotalAnnualBudgetDebitSysChanging(value);
                this._TotalAnnualBudgetDebitSys = value;
                this.OnTotalAnnualBudgetDebitSysChanged();
                this.OnPropertyChanged("TotalAnnualBudgetDebitSys");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _TotalAnnualBudgetDebitSys;
        partial void OnTotalAnnualBudgetDebitSysChanging(global::System.Nullable<double> value);
        partial void OnTotalAnnualBudgetDebitSysChanged();
        /// <summary>
        /// There are no comments for Property BudgetBalanceDebitSys in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetBalanceDebitSys")]
        public virtual global::System.Nullable<double> BudgetBalanceDebitSys
        {
            get
            {
                return this._BudgetBalanceDebitSys;
            }
            set
            {
                this.OnBudgetBalanceDebitSysChanging(value);
                this._BudgetBalanceDebitSys = value;
                this.OnBudgetBalanceDebitSysChanged();
                this.OnPropertyChanged("BudgetBalanceDebitSys");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _BudgetBalanceDebitSys;
        partial void OnBudgetBalanceDebitSysChanging(global::System.Nullable<double> value);
        partial void OnBudgetBalanceDebitSysChanged();
        /// <summary>
        /// There are no comments for Property BudgetBalanceDebitLoc in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetBalanceDebitLoc")]
        public virtual global::System.Nullable<double> BudgetBalanceDebitLoc
        {
            get
            {
                return this._BudgetBalanceDebitLoc;
            }
            set
            {
                this.OnBudgetBalanceDebitLocChanging(value);
                this._BudgetBalanceDebitLoc = value;
                this.OnBudgetBalanceDebitLocChanged();
                this.OnPropertyChanged("BudgetBalanceDebitLoc");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _BudgetBalanceDebitLoc;
        partial void OnBudgetBalanceDebitLocChanging(global::System.Nullable<double> value);
        partial void OnBudgetBalanceDebitLocChanged();
        /// <summary>
        /// There are no comments for Property TotalAnnualBudgetDebitLoc in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalAnnualBudgetDebitLoc")]
        public virtual global::System.Nullable<double> TotalAnnualBudgetDebitLoc
        {
            get
            {
                return this._TotalAnnualBudgetDebitLoc;
            }
            set
            {
                this.OnTotalAnnualBudgetDebitLocChanging(value);
                this._TotalAnnualBudgetDebitLoc = value;
                this.OnTotalAnnualBudgetDebitLocChanged();
                this.OnPropertyChanged("TotalAnnualBudgetDebitLoc");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _TotalAnnualBudgetDebitLoc;
        partial void OnTotalAnnualBudgetDebitLocChanging(global::System.Nullable<double> value);
        partial void OnTotalAnnualBudgetDebitLocChanged();
        /// <summary>
        /// There are no comments for Property TotalAnnualBudgetCreditSys in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalAnnualBudgetCreditSys")]
        public virtual global::System.Nullable<double> TotalAnnualBudgetCreditSys
        {
            get
            {
                return this._TotalAnnualBudgetCreditSys;
            }
            set
            {
                this.OnTotalAnnualBudgetCreditSysChanging(value);
                this._TotalAnnualBudgetCreditSys = value;
                this.OnTotalAnnualBudgetCreditSysChanged();
                this.OnPropertyChanged("TotalAnnualBudgetCreditSys");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _TotalAnnualBudgetCreditSys;
        partial void OnTotalAnnualBudgetCreditSysChanging(global::System.Nullable<double> value);
        partial void OnTotalAnnualBudgetCreditSysChanged();
        /// <summary>
        /// There are no comments for Property TotalAnnualBudgetCreditLoc in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalAnnualBudgetCreditLoc")]
        public virtual global::System.Nullable<double> TotalAnnualBudgetCreditLoc
        {
            get
            {
                return this._TotalAnnualBudgetCreditLoc;
            }
            set
            {
                this.OnTotalAnnualBudgetCreditLocChanging(value);
                this._TotalAnnualBudgetCreditLoc = value;
                this.OnTotalAnnualBudgetCreditLocChanged();
                this.OnPropertyChanged("TotalAnnualBudgetCreditLoc");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _TotalAnnualBudgetCreditLoc;
        partial void OnTotalAnnualBudgetCreditLocChanging(global::System.Nullable<double> value);
        partial void OnTotalAnnualBudgetCreditLocChanged();
        /// <summary>
        /// There are no comments for Property BudgetBalanceCreditSys in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetBalanceCreditSys")]
        public virtual global::System.Nullable<double> BudgetBalanceCreditSys
        {
            get
            {
                return this._BudgetBalanceCreditSys;
            }
            set
            {
                this.OnBudgetBalanceCreditSysChanging(value);
                this._BudgetBalanceCreditSys = value;
                this.OnBudgetBalanceCreditSysChanged();
                this.OnPropertyChanged("BudgetBalanceCreditSys");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _BudgetBalanceCreditSys;
        partial void OnBudgetBalanceCreditSysChanging(global::System.Nullable<double> value);
        partial void OnBudgetBalanceCreditSysChanged();
        /// <summary>
        /// There are no comments for Property BudgetBalanceCreditLoc in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetBalanceCreditLoc")]
        public virtual global::System.Nullable<double> BudgetBalanceCreditLoc
        {
            get
            {
                return this._BudgetBalanceCreditLoc;
            }
            set
            {
                this.OnBudgetBalanceCreditLocChanging(value);
                this._BudgetBalanceCreditLoc = value;
                this.OnBudgetBalanceCreditLocChanged();
                this.OnPropertyChanged("BudgetBalanceCreditLoc");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _BudgetBalanceCreditLoc;
        partial void OnBudgetBalanceCreditLocChanging(global::System.Nullable<double> value);
        partial void OnBudgetBalanceCreditLocChanged();
        /// <summary>
        /// There are no comments for Property DivisionCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DivisionCode")]
        public virtual global::System.Nullable<int> DivisionCode
        {
            get
            {
                return this._DivisionCode;
            }
            set
            {
                this.OnDivisionCodeChanging(value);
                this._DivisionCode = value;
                this.OnDivisionCodeChanged();
                this.OnPropertyChanged("DivisionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DivisionCode;
        partial void OnDivisionCodeChanging(global::System.Nullable<int> value);
        partial void OnDivisionCodeChanged();
        /// <summary>
        /// There are no comments for Property AccountCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountCode")]
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
        /// There are no comments for Property BudgetScenario in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetScenario")]
        public virtual global::System.Nullable<int> BudgetScenario
        {
            get
            {
                return this._BudgetScenario;
            }
            set
            {
                this.OnBudgetScenarioChanging(value);
                this._BudgetScenario = value;
                this.OnBudgetScenarioChanged();
                this.OnPropertyChanged("BudgetScenario");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BudgetScenario;
        partial void OnBudgetScenarioChanging(global::System.Nullable<int> value);
        partial void OnBudgetScenarioChanged();
        /// <summary>
        /// There are no comments for Property BudgetLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetLines")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BudgetLine> BudgetLines
        {
            get
            {
                return this._BudgetLines;
            }
            set
            {
                this.OnBudgetLinesChanging(value);
                this._BudgetLines = value;
                this.OnBudgetLinesChanged();
                this.OnPropertyChanged("BudgetLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BudgetLine> _BudgetLines = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BudgetLine>();
        partial void OnBudgetLinesChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BudgetLine> value);
        partial void OnBudgetLinesChanged();
        /// <summary>
        /// There are no comments for Property BudgetCostAccountingLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetCostAccountingLines")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BudgetCostAccountingLine> BudgetCostAccountingLines
        {
            get
            {
                return this._BudgetCostAccountingLines;
            }
            set
            {
                this.OnBudgetCostAccountingLinesChanging(value);
                this._BudgetCostAccountingLines = value;
                this.OnBudgetCostAccountingLinesChanged();
                this.OnPropertyChanged("BudgetCostAccountingLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BudgetCostAccountingLine> _BudgetCostAccountingLines = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BudgetCostAccountingLine>();
        partial void OnBudgetCostAccountingLinesChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BudgetCostAccountingLine> value);
        partial void OnBudgetCostAccountingLinesChanged();
        /// <summary>
        /// There are no comments for Property BudgetDistribution in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetDistribution")]
        public virtual global::SAPB1.BudgetDistribution BudgetDistribution
        {
            get
            {
                return this._BudgetDistribution;
            }
            set
            {
                this.OnBudgetDistributionChanging(value);
                this._BudgetDistribution = value;
                this.OnBudgetDistributionChanged();
                this.OnPropertyChanged("BudgetDistribution");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BudgetDistribution _BudgetDistribution;
        partial void OnBudgetDistributionChanging(global::SAPB1.BudgetDistribution value);
        partial void OnBudgetDistributionChanged();
        /// <summary>
        /// There are no comments for Property BudgetScenario2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BudgetScenario2")]
        public virtual global::SAPB1.BudgetScenario BudgetScenario2
        {
            get
            {
                return this._BudgetScenario2;
            }
            set
            {
                this.OnBudgetScenario2Changing(value);
                this._BudgetScenario2 = value;
                this.OnBudgetScenario2Changed();
                this.OnPropertyChanged("BudgetScenario2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BudgetScenario _BudgetScenario2;
        partial void OnBudgetScenario2Changing(global::SAPB1.BudgetScenario value);
        partial void OnBudgetScenario2Changed();
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