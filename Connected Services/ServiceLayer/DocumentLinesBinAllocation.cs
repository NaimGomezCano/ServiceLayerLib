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
    /// There are no comments for DocumentLinesBinAllocation in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentLinesBinAllocation")]
    public partial class DocumentLinesBinAllocation : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property BinAbsEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BinAbsEntry")]
        public virtual global::System.Nullable<int> BinAbsEntry
        {
            get
            {
                return this._BinAbsEntry;
            }
            set
            {
                this.OnBinAbsEntryChanging(value);
                this._BinAbsEntry = value;
                this.OnBinAbsEntryChanged();
                this.OnPropertyChanged("BinAbsEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BinAbsEntry;
        partial void OnBinAbsEntryChanging(global::System.Nullable<int> value);
        partial void OnBinAbsEntryChanged();
        /// <summary>
        /// There are no comments for Property Quantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Quantity")]
        public virtual global::System.Nullable<double> Quantity
        {
            get
            {
                return this._Quantity;
            }
            set
            {
                this.OnQuantityChanging(value);
                this._Quantity = value;
                this.OnQuantityChanged();
                this.OnPropertyChanged("Quantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Quantity;
        partial void OnQuantityChanging(global::System.Nullable<double> value);
        partial void OnQuantityChanged();
        /// <summary>
        /// There are no comments for Property AllowNegativeQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AllowNegativeQuantity")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> AllowNegativeQuantity
        {
            get
            {
                return this._AllowNegativeQuantity;
            }
            set
            {
                this.OnAllowNegativeQuantityChanging(value);
                this._AllowNegativeQuantity = value;
                this.OnAllowNegativeQuantityChanged();
                this.OnPropertyChanged("AllowNegativeQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _AllowNegativeQuantity;
        partial void OnAllowNegativeQuantityChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnAllowNegativeQuantityChanged();
        /// <summary>
        /// There are no comments for Property SerialAndBatchNumbersBaseLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SerialAndBatchNumbersBaseLine")]
        public virtual global::System.Nullable<int> SerialAndBatchNumbersBaseLine
        {
            get
            {
                return this._SerialAndBatchNumbersBaseLine;
            }
            set
            {
                this.OnSerialAndBatchNumbersBaseLineChanging(value);
                this._SerialAndBatchNumbersBaseLine = value;
                this.OnSerialAndBatchNumbersBaseLineChanged();
                this.OnPropertyChanged("SerialAndBatchNumbersBaseLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SerialAndBatchNumbersBaseLine;
        partial void OnSerialAndBatchNumbersBaseLineChanging(global::System.Nullable<int> value);
        partial void OnSerialAndBatchNumbersBaseLineChanged();
        /// <summary>
        /// There are no comments for Property BaseLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseLineNumber")]
        public virtual global::System.Nullable<int> BaseLineNumber
        {
            get
            {
                return this._BaseLineNumber;
            }
            set
            {
                this.OnBaseLineNumberChanging(value);
                this._BaseLineNumber = value;
                this.OnBaseLineNumberChanged();
                this.OnPropertyChanged("BaseLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BaseLineNumber;
        partial void OnBaseLineNumberChanging(global::System.Nullable<int> value);
        partial void OnBaseLineNumberChanged();
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
