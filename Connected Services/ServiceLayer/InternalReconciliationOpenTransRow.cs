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
    /// There are no comments for InternalReconciliationOpenTransRow in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("InternalReconciliationOpenTransRow")]
    public partial class InternalReconciliationOpenTransRow : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Selected in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Selected")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Selected
        {
            get
            {
                return this._Selected;
            }
            set
            {
                this.OnSelectedChanging(value);
                this._Selected = value;
                this.OnSelectedChanged();
                this.OnPropertyChanged("Selected");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Selected;
        partial void OnSelectedChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnSelectedChanged();
        /// <summary>
        /// There are no comments for Property ShortName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShortName")]
        public virtual string ShortName
        {
            get
            {
                return this._ShortName;
            }
            set
            {
                this.OnShortNameChanging(value);
                this._ShortName = value;
                this.OnShortNameChanged();
                this.OnPropertyChanged("ShortName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShortName;
        partial void OnShortNameChanging(string value);
        partial void OnShortNameChanged();
        /// <summary>
        /// There are no comments for Property TransId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransId")]
        public virtual global::System.Nullable<int> TransId
        {
            get
            {
                return this._TransId;
            }
            set
            {
                this.OnTransIdChanging(value);
                this._TransId = value;
                this.OnTransIdChanged();
                this.OnPropertyChanged("TransId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _TransId;
        partial void OnTransIdChanging(global::System.Nullable<int> value);
        partial void OnTransIdChanged();
        /// <summary>
        /// There are no comments for Property TransRowId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransRowId")]
        public virtual global::System.Nullable<int> TransRowId
        {
            get
            {
                return this._TransRowId;
            }
            set
            {
                this.OnTransRowIdChanging(value);
                this._TransRowId = value;
                this.OnTransRowIdChanged();
                this.OnPropertyChanged("TransRowId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _TransRowId;
        partial void OnTransRowIdChanging(global::System.Nullable<int> value);
        partial void OnTransRowIdChanged();
        /// <summary>
        /// There are no comments for Property SrcObjTyp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SrcObjTyp")]
        public virtual string SrcObjTyp
        {
            get
            {
                return this._SrcObjTyp;
            }
            set
            {
                this.OnSrcObjTypChanging(value);
                this._SrcObjTyp = value;
                this.OnSrcObjTypChanged();
                this.OnPropertyChanged("SrcObjTyp");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SrcObjTyp;
        partial void OnSrcObjTypChanging(string value);
        partial void OnSrcObjTypChanged();
        /// <summary>
        /// There are no comments for Property SrcObjAbs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SrcObjAbs")]
        public virtual global::System.Nullable<int> SrcObjAbs
        {
            get
            {
                return this._SrcObjAbs;
            }
            set
            {
                this.OnSrcObjAbsChanging(value);
                this._SrcObjAbs = value;
                this.OnSrcObjAbsChanged();
                this.OnPropertyChanged("SrcObjAbs");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SrcObjAbs;
        partial void OnSrcObjAbsChanging(global::System.Nullable<int> value);
        partial void OnSrcObjAbsChanged();
        /// <summary>
        /// There are no comments for Property CreditOrDebit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreditOrDebit")]
        public virtual global::System.Nullable<global::SAPB1.CreditOrDebitEnum> CreditOrDebit
        {
            get
            {
                return this._CreditOrDebit;
            }
            set
            {
                this.OnCreditOrDebitChanging(value);
                this._CreditOrDebit = value;
                this.OnCreditOrDebitChanged();
                this.OnPropertyChanged("CreditOrDebit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.CreditOrDebitEnum> _CreditOrDebit;
        partial void OnCreditOrDebitChanging(global::System.Nullable<global::SAPB1.CreditOrDebitEnum> value);
        partial void OnCreditOrDebitChanged();
        /// <summary>
        /// There are no comments for Property ReconcileAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReconcileAmount")]
        public virtual global::System.Nullable<double> ReconcileAmount
        {
            get
            {
                return this._ReconcileAmount;
            }
            set
            {
                this.OnReconcileAmountChanging(value);
                this._ReconcileAmount = value;
                this.OnReconcileAmountChanged();
                this.OnPropertyChanged("ReconcileAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _ReconcileAmount;
        partial void OnReconcileAmountChanging(global::System.Nullable<double> value);
        partial void OnReconcileAmountChanged();
        /// <summary>
        /// There are no comments for Property CashDiscount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CashDiscount")]
        public virtual global::System.Nullable<double> CashDiscount
        {
            get
            {
                return this._CashDiscount;
            }
            set
            {
                this.OnCashDiscountChanging(value);
                this._CashDiscount = value;
                this.OnCashDiscountChanged();
                this.OnPropertyChanged("CashDiscount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _CashDiscount;
        partial void OnCashDiscountChanging(global::System.Nullable<double> value);
        partial void OnCashDiscountChanged();
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
