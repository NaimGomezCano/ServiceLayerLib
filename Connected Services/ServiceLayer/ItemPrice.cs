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
    /// There are no comments for ItemPrice in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemPrice")]
    public partial class ItemPrice : global::System.ComponentModel.INotifyPropertyChanged
    {
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
        /// There are no comments for Property Price in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Price")]
        public virtual global::System.Nullable<double> Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this.OnPriceChanging(value);
                this._Price = value;
                this.OnPriceChanged();
                this.OnPropertyChanged("Price");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Price;
        partial void OnPriceChanging(global::System.Nullable<double> value);
        partial void OnPriceChanged();
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
        /// There are no comments for Property AdditionalPrice1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdditionalPrice1")]
        public virtual global::System.Nullable<double> AdditionalPrice1
        {
            get
            {
                return this._AdditionalPrice1;
            }
            set
            {
                this.OnAdditionalPrice1Changing(value);
                this._AdditionalPrice1 = value;
                this.OnAdditionalPrice1Changed();
                this.OnPropertyChanged("AdditionalPrice1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _AdditionalPrice1;
        partial void OnAdditionalPrice1Changing(global::System.Nullable<double> value);
        partial void OnAdditionalPrice1Changed();
        /// <summary>
        /// There are no comments for Property AdditionalCurrency1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdditionalCurrency1")]
        public virtual string AdditionalCurrency1
        {
            get
            {
                return this._AdditionalCurrency1;
            }
            set
            {
                this.OnAdditionalCurrency1Changing(value);
                this._AdditionalCurrency1 = value;
                this.OnAdditionalCurrency1Changed();
                this.OnPropertyChanged("AdditionalCurrency1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdditionalCurrency1;
        partial void OnAdditionalCurrency1Changing(string value);
        partial void OnAdditionalCurrency1Changed();
        /// <summary>
        /// There are no comments for Property AdditionalPrice2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdditionalPrice2")]
        public virtual global::System.Nullable<double> AdditionalPrice2
        {
            get
            {
                return this._AdditionalPrice2;
            }
            set
            {
                this.OnAdditionalPrice2Changing(value);
                this._AdditionalPrice2 = value;
                this.OnAdditionalPrice2Changed();
                this.OnPropertyChanged("AdditionalPrice2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _AdditionalPrice2;
        partial void OnAdditionalPrice2Changing(global::System.Nullable<double> value);
        partial void OnAdditionalPrice2Changed();
        /// <summary>
        /// There are no comments for Property AdditionalCurrency2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdditionalCurrency2")]
        public virtual string AdditionalCurrency2
        {
            get
            {
                return this._AdditionalCurrency2;
            }
            set
            {
                this.OnAdditionalCurrency2Changing(value);
                this._AdditionalCurrency2 = value;
                this.OnAdditionalCurrency2Changed();
                this.OnPropertyChanged("AdditionalCurrency2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdditionalCurrency2;
        partial void OnAdditionalCurrency2Changing(string value);
        partial void OnAdditionalCurrency2Changed();
        /// <summary>
        /// There are no comments for Property BasePriceList in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BasePriceList")]
        public virtual global::System.Nullable<int> BasePriceList
        {
            get
            {
                return this._BasePriceList;
            }
            set
            {
                this.OnBasePriceListChanging(value);
                this._BasePriceList = value;
                this.OnBasePriceListChanged();
                this.OnPropertyChanged("BasePriceList");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BasePriceList;
        partial void OnBasePriceListChanging(global::System.Nullable<int> value);
        partial void OnBasePriceListChanged();
        /// <summary>
        /// There are no comments for Property Factor in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Factor")]
        public virtual global::System.Nullable<double> Factor
        {
            get
            {
                return this._Factor;
            }
            set
            {
                this.OnFactorChanging(value);
                this._Factor = value;
                this.OnFactorChanged();
                this.OnPropertyChanged("Factor");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Factor;
        partial void OnFactorChanging(global::System.Nullable<double> value);
        partial void OnFactorChanged();
        /// <summary>
        /// There are no comments for Property UoMPrices in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UoMPrices")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.UoMPrice> UoMPrices
        {
            get
            {
                return this._UoMPrices;
            }
            set
            {
                this.OnUoMPricesChanging(value);
                this._UoMPrices = value;
                this.OnUoMPricesChanged();
                this.OnPropertyChanged("UoMPrices");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.UoMPrice> _UoMPrices = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.UoMPrice>();
        partial void OnUoMPricesChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.UoMPrice> value);
        partial void OnUoMPricesChanged();
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
