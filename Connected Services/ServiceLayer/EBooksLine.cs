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
    /// There are no comments for EBooksLine in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EBooksLine")]
    public partial class EBooksLine : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        public virtual global::System.Nullable<int> LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _LineNumber;
        partial void OnLineNumberChanging(global::System.Nullable<int> value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property NetValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NetValue")]
        public virtual global::System.Nullable<double> NetValue
        {
            get
            {
                return this._NetValue;
            }
            set
            {
                this.OnNetValueChanging(value);
                this._NetValue = value;
                this.OnNetValueChanged();
                this.OnPropertyChanged("NetValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _NetValue;
        partial void OnNetValueChanging(global::System.Nullable<double> value);
        partial void OnNetValueChanged();
        /// <summary>
        /// There are no comments for Property VatCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VatCategory")]
        public virtual global::System.Nullable<int> VatCategory
        {
            get
            {
                return this._VatCategory;
            }
            set
            {
                this.OnVatCategoryChanging(value);
                this._VatCategory = value;
                this.OnVatCategoryChanged();
                this.OnPropertyChanged("VatCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _VatCategory;
        partial void OnVatCategoryChanging(global::System.Nullable<int> value);
        partial void OnVatCategoryChanged();
        /// <summary>
        /// There are no comments for Property VatAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VatAmount")]
        public virtual global::System.Nullable<double> VatAmount
        {
            get
            {
                return this._VatAmount;
            }
            set
            {
                this.OnVatAmountChanging(value);
                this._VatAmount = value;
                this.OnVatAmountChanged();
                this.OnPropertyChanged("VatAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _VatAmount;
        partial void OnVatAmountChanging(global::System.Nullable<double> value);
        partial void OnVatAmountChanged();
        /// <summary>
        /// There are no comments for Property WithheldAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WithheldAmount")]
        public virtual global::System.Nullable<double> WithheldAmount
        {
            get
            {
                return this._WithheldAmount;
            }
            set
            {
                this.OnWithheldAmountChanging(value);
                this._WithheldAmount = value;
                this.OnWithheldAmountChanged();
                this.OnPropertyChanged("WithheldAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _WithheldAmount;
        partial void OnWithheldAmountChanging(global::System.Nullable<double> value);
        partial void OnWithheldAmountChanged();
        /// <summary>
        /// There are no comments for Property WithheldPercentCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WithheldPercentCategory")]
        public virtual global::System.Nullable<int> WithheldPercentCategory
        {
            get
            {
                return this._WithheldPercentCategory;
            }
            set
            {
                this.OnWithheldPercentCategoryChanging(value);
                this._WithheldPercentCategory = value;
                this.OnWithheldPercentCategoryChanged();
                this.OnPropertyChanged("WithheldPercentCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _WithheldPercentCategory;
        partial void OnWithheldPercentCategoryChanging(global::System.Nullable<int> value);
        partial void OnWithheldPercentCategoryChanged();
        /// <summary>
        /// There are no comments for Property ExpenseClassificationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseClassificationType")]
        public virtual global::System.Nullable<int> ExpenseClassificationType
        {
            get
            {
                return this._ExpenseClassificationType;
            }
            set
            {
                this.OnExpenseClassificationTypeChanging(value);
                this._ExpenseClassificationType = value;
                this.OnExpenseClassificationTypeChanged();
                this.OnPropertyChanged("ExpenseClassificationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ExpenseClassificationType;
        partial void OnExpenseClassificationTypeChanging(global::System.Nullable<int> value);
        partial void OnExpenseClassificationTypeChanged();
        /// <summary>
        /// There are no comments for Property ExpenseClassificationCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExpenseClassificationCategory")]
        public virtual global::System.Nullable<int> ExpenseClassificationCategory
        {
            get
            {
                return this._ExpenseClassificationCategory;
            }
            set
            {
                this.OnExpenseClassificationCategoryChanging(value);
                this._ExpenseClassificationCategory = value;
                this.OnExpenseClassificationCategoryChanged();
                this.OnPropertyChanged("ExpenseClassificationCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ExpenseClassificationCategory;
        partial void OnExpenseClassificationCategoryChanging(global::System.Nullable<int> value);
        partial void OnExpenseClassificationCategoryChanged();
        /// <summary>
        /// There are no comments for Property VATClassificationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VATClassificationType")]
        public virtual global::System.Nullable<int> VATClassificationType
        {
            get
            {
                return this._VATClassificationType;
            }
            set
            {
                this.OnVATClassificationTypeChanging(value);
                this._VATClassificationType = value;
                this.OnVATClassificationTypeChanged();
                this.OnPropertyChanged("VATClassificationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _VATClassificationType;
        partial void OnVATClassificationTypeChanging(global::System.Nullable<int> value);
        partial void OnVATClassificationTypeChanged();
        /// <summary>
        /// There are no comments for Property VATClassificationCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VATClassificationCategory")]
        public virtual global::System.Nullable<int> VATClassificationCategory
        {
            get
            {
                return this._VATClassificationCategory;
            }
            set
            {
                this.OnVATClassificationCategoryChanging(value);
                this._VATClassificationCategory = value;
                this.OnVATClassificationCategoryChanged();
                this.OnPropertyChanged("VATClassificationCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _VATClassificationCategory;
        partial void OnVATClassificationCategoryChanging(global::System.Nullable<int> value);
        partial void OnVATClassificationCategoryChanged();
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