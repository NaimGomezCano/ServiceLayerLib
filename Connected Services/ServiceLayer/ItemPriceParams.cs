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
    /// There are no comments for ItemPriceParams in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemPriceParams")]
    public partial class ItemPriceParams : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Date in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Date")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                this.OnDateChanging(value);
                this._Date = value;
                this.OnDateChanged();
                this.OnPropertyChanged("Date");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _Date;
        partial void OnDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDateChanged();
        /// <summary>
        /// There are no comments for Property UoMEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UoMEntry")]
        public virtual global::System.Nullable<int> UoMEntry
        {
            get
            {
                return this._UoMEntry;
            }
            set
            {
                this.OnUoMEntryChanging(value);
                this._UoMEntry = value;
                this.OnUoMEntryChanged();
                this.OnPropertyChanged("UoMEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _UoMEntry;
        partial void OnUoMEntryChanging(global::System.Nullable<int> value);
        partial void OnUoMEntryChanged();
        /// <summary>
        /// There are no comments for Property BlanketAgreementNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BlanketAgreementNumber")]
        public virtual global::System.Nullable<int> BlanketAgreementNumber
        {
            get
            {
                return this._BlanketAgreementNumber;
            }
            set
            {
                this.OnBlanketAgreementNumberChanging(value);
                this._BlanketAgreementNumber = value;
                this.OnBlanketAgreementNumberChanged();
                this.OnPropertyChanged("BlanketAgreementNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BlanketAgreementNumber;
        partial void OnBlanketAgreementNumberChanging(global::System.Nullable<int> value);
        partial void OnBlanketAgreementNumberChanged();
        /// <summary>
        /// There are no comments for Property BlanketAgreementLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BlanketAgreementLine")]
        public virtual global::System.Nullable<int> BlanketAgreementLine
        {
            get
            {
                return this._BlanketAgreementLine;
            }
            set
            {
                this.OnBlanketAgreementLineChanging(value);
                this._BlanketAgreementLine = value;
                this.OnBlanketAgreementLineChanged();
                this.OnPropertyChanged("BlanketAgreementLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BlanketAgreementLine;
        partial void OnBlanketAgreementLineChanging(global::System.Nullable<int> value);
        partial void OnBlanketAgreementLineChanged();
        /// <summary>
        /// There are no comments for Property UoMQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UoMQuantity")]
        public virtual global::System.Nullable<double> UoMQuantity
        {
            get
            {
                return this._UoMQuantity;
            }
            set
            {
                this.OnUoMQuantityChanging(value);
                this._UoMQuantity = value;
                this.OnUoMQuantityChanged();
                this.OnPropertyChanged("UoMQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _UoMQuantity;
        partial void OnUoMQuantityChanging(global::System.Nullable<double> value);
        partial void OnUoMQuantityChanged();
        /// <summary>
        /// There are no comments for Property InventoryQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryQuantity")]
        public virtual global::System.Nullable<double> InventoryQuantity
        {
            get
            {
                return this._InventoryQuantity;
            }
            set
            {
                this.OnInventoryQuantityChanging(value);
                this._InventoryQuantity = value;
                this.OnInventoryQuantityChanged();
                this.OnPropertyChanged("InventoryQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _InventoryQuantity;
        partial void OnInventoryQuantityChanging(global::System.Nullable<double> value);
        partial void OnInventoryQuantityChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Currency")]
        public virtual string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this._Currency = value;
                this.OnCurrencyChanged();
                this.OnPropertyChanged("Currency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Currency;
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        /// <summary>
        /// There are no comments for Property ItemCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemCode")]
        public virtual string ItemCode
        {
            get
            {
                return this._ItemCode;
            }
            set
            {
                this.OnItemCodeChanging(value);
                this._ItemCode = value;
                this.OnItemCodeChanged();
                this.OnPropertyChanged("ItemCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemCode;
        partial void OnItemCodeChanging(string value);
        partial void OnItemCodeChanged();
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