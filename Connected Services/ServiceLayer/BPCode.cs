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
    /// There are no comments for BPCode in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BPCode")]
    public partial class BPCode : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
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
        /// There are no comments for Property Debit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Debit")]
        public virtual global::System.Nullable<double> Debit
        {
            get
            {
                return this._Debit;
            }
            set
            {
                this.OnDebitChanging(value);
                this._Debit = value;
                this.OnDebitChanged();
                this.OnPropertyChanged("Debit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Debit;
        partial void OnDebitChanging(global::System.Nullable<double> value);
        partial void OnDebitChanged();
        /// <summary>
        /// There are no comments for Property Credit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Credit")]
        public virtual global::System.Nullable<double> Credit
        {
            get
            {
                return this._Credit;
            }
            set
            {
                this.OnCreditChanging(value);
                this._Credit = value;
                this.OnCreditChanged();
                this.OnPropertyChanged("Credit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Credit;
        partial void OnCreditChanging(global::System.Nullable<double> value);
        partial void OnCreditChanged();
        /// <summary>
        /// There are no comments for Property SystemDebit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SystemDebit")]
        public virtual global::System.Nullable<double> SystemDebit
        {
            get
            {
                return this._SystemDebit;
            }
            set
            {
                this.OnSystemDebitChanging(value);
                this._SystemDebit = value;
                this.OnSystemDebitChanged();
                this.OnPropertyChanged("SystemDebit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _SystemDebit;
        partial void OnSystemDebitChanging(global::System.Nullable<double> value);
        partial void OnSystemDebitChanged();
        /// <summary>
        /// There are no comments for Property SystemCredit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SystemCredit")]
        public virtual global::System.Nullable<double> SystemCredit
        {
            get
            {
                return this._SystemCredit;
            }
            set
            {
                this.OnSystemCreditChanging(value);
                this._SystemCredit = value;
                this.OnSystemCreditChanged();
                this.OnPropertyChanged("SystemCredit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _SystemCredit;
        partial void OnSystemCreditChanging(global::System.Nullable<double> value);
        partial void OnSystemCreditChanged();
        /// <summary>
        /// There are no comments for Property ForeignDebit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForeignDebit")]
        public virtual global::System.Nullable<double> ForeignDebit
        {
            get
            {
                return this._ForeignDebit;
            }
            set
            {
                this.OnForeignDebitChanging(value);
                this._ForeignDebit = value;
                this.OnForeignDebitChanged();
                this.OnPropertyChanged("ForeignDebit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _ForeignDebit;
        partial void OnForeignDebitChanging(global::System.Nullable<double> value);
        partial void OnForeignDebitChanged();
        /// <summary>
        /// There are no comments for Property ForeignCredit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForeignCredit")]
        public virtual global::System.Nullable<double> ForeignCredit
        {
            get
            {
                return this._ForeignCredit;
            }
            set
            {
                this.OnForeignCreditChanging(value);
                this._ForeignCredit = value;
                this.OnForeignCreditChanged();
                this.OnPropertyChanged("ForeignCredit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _ForeignCredit;
        partial void OnForeignCreditChanging(global::System.Nullable<double> value);
        partial void OnForeignCreditChanged();
        /// <summary>
        /// There are no comments for Property ForeignCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ForeignCurrency")]
        public virtual string ForeignCurrency
        {
            get
            {
                return this._ForeignCurrency;
            }
            set
            {
                this.OnForeignCurrencyChanging(value);
                this._ForeignCurrency = value;
                this.OnForeignCurrencyChanged();
                this.OnPropertyChanged("ForeignCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ForeignCurrency;
        partial void OnForeignCurrencyChanging(string value);
        partial void OnForeignCurrencyChanged();
        /// <summary>
        /// There are no comments for Property BpCtrlAcct in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BpCtrlAcct")]
        public virtual string BpCtrlAcct
        {
            get
            {
                return this._BpCtrlAcct;
            }
            set
            {
                this.OnBpCtrlAcctChanging(value);
                this._BpCtrlAcct = value;
                this.OnBpCtrlAcctChanged();
                this.OnPropertyChanged("BpCtrlAcct");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BpCtrlAcct;
        partial void OnBpCtrlAcctChanging(string value);
        partial void OnBpCtrlAcctChanged();
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