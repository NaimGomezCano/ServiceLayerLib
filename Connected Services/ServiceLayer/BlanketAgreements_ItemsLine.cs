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
    /// There are no comments for BlanketAgreements_ItemsLine in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BlanketAgreements_ItemsLine")]
    public partial class BlanketAgreements_ItemsLine : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property AgreementNo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AgreementNo")]
        public virtual global::System.Nullable<int> AgreementNo
        {
            get
            {
                return this._AgreementNo;
            }
            set
            {
                this.OnAgreementNoChanging(value);
                this._AgreementNo = value;
                this.OnAgreementNoChanged();
                this.OnPropertyChanged("AgreementNo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _AgreementNo;
        partial void OnAgreementNoChanging(global::System.Nullable<int> value);
        partial void OnAgreementNoChanged();
        /// <summary>
        /// There are no comments for Property AgreementRowNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AgreementRowNumber")]
        public virtual global::System.Nullable<int> AgreementRowNumber
        {
            get
            {
                return this._AgreementRowNumber;
            }
            set
            {
                this.OnAgreementRowNumberChanging(value);
                this._AgreementRowNumber = value;
                this.OnAgreementRowNumberChanged();
                this.OnPropertyChanged("AgreementRowNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _AgreementRowNumber;
        partial void OnAgreementRowNumberChanging(global::System.Nullable<int> value);
        partial void OnAgreementRowNumberChanged();
        /// <summary>
        /// There are no comments for Property ItemNo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemNo")]
        public virtual string ItemNo
        {
            get
            {
                return this._ItemNo;
            }
            set
            {
                this.OnItemNoChanging(value);
                this._ItemNo = value;
                this.OnItemNoChanged();
                this.OnPropertyChanged("ItemNo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNo;
        partial void OnItemNoChanging(string value);
        partial void OnItemNoChanged();
        /// <summary>
        /// There are no comments for Property ItemDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemDescription")]
        public virtual string ItemDescription
        {
            get
            {
                return this._ItemDescription;
            }
            set
            {
                this.OnItemDescriptionChanging(value);
                this._ItemDescription = value;
                this.OnItemDescriptionChanged();
                this.OnPropertyChanged("ItemDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemDescription;
        partial void OnItemDescriptionChanging(string value);
        partial void OnItemDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ItemGroup in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemGroup")]
        public virtual global::System.Nullable<int> ItemGroup
        {
            get
            {
                return this._ItemGroup;
            }
            set
            {
                this.OnItemGroupChanging(value);
                this._ItemGroup = value;
                this.OnItemGroupChanged();
                this.OnPropertyChanged("ItemGroup");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ItemGroup;
        partial void OnItemGroupChanging(global::System.Nullable<int> value);
        partial void OnItemGroupChanged();
        /// <summary>
        /// There are no comments for Property PlannedQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlannedQuantity")]
        public virtual global::System.Nullable<double> PlannedQuantity
        {
            get
            {
                return this._PlannedQuantity;
            }
            set
            {
                this.OnPlannedQuantityChanging(value);
                this._PlannedQuantity = value;
                this.OnPlannedQuantityChanged();
                this.OnPropertyChanged("PlannedQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _PlannedQuantity;
        partial void OnPlannedQuantityChanging(global::System.Nullable<double> value);
        partial void OnPlannedQuantityChanged();
        /// <summary>
        /// There are no comments for Property UnitPrice in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitPrice")]
        public virtual global::System.Nullable<double> UnitPrice
        {
            get
            {
                return this._UnitPrice;
            }
            set
            {
                this.OnUnitPriceChanging(value);
                this._UnitPrice = value;
                this.OnUnitPriceChanged();
                this.OnPropertyChanged("UnitPrice");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _UnitPrice;
        partial void OnUnitPriceChanging(global::System.Nullable<double> value);
        partial void OnUnitPriceChanged();
        /// <summary>
        /// There are no comments for Property PriceCurrency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PriceCurrency")]
        public virtual string PriceCurrency
        {
            get
            {
                return this._PriceCurrency;
            }
            set
            {
                this.OnPriceCurrencyChanging(value);
                this._PriceCurrency = value;
                this.OnPriceCurrencyChanged();
                this.OnPropertyChanged("PriceCurrency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PriceCurrency;
        partial void OnPriceCurrencyChanging(string value);
        partial void OnPriceCurrencyChanged();
        /// <summary>
        /// There are no comments for Property CumulativeQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CumulativeQuantity")]
        public virtual global::System.Nullable<double> CumulativeQuantity
        {
            get
            {
                return this._CumulativeQuantity;
            }
            set
            {
                this.OnCumulativeQuantityChanging(value);
                this._CumulativeQuantity = value;
                this.OnCumulativeQuantityChanged();
                this.OnPropertyChanged("CumulativeQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _CumulativeQuantity;
        partial void OnCumulativeQuantityChanging(global::System.Nullable<double> value);
        partial void OnCumulativeQuantityChanged();
        /// <summary>
        /// There are no comments for Property CumulativeAmountLC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CumulativeAmountLC")]
        public virtual global::System.Nullable<double> CumulativeAmountLC
        {
            get
            {
                return this._CumulativeAmountLC;
            }
            set
            {
                this.OnCumulativeAmountLCChanging(value);
                this._CumulativeAmountLC = value;
                this.OnCumulativeAmountLCChanged();
                this.OnPropertyChanged("CumulativeAmountLC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _CumulativeAmountLC;
        partial void OnCumulativeAmountLCChanging(global::System.Nullable<double> value);
        partial void OnCumulativeAmountLCChanged();
        /// <summary>
        /// There are no comments for Property CumulativeAmountFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CumulativeAmountFC")]
        public virtual global::System.Nullable<double> CumulativeAmountFC
        {
            get
            {
                return this._CumulativeAmountFC;
            }
            set
            {
                this.OnCumulativeAmountFCChanging(value);
                this._CumulativeAmountFC = value;
                this.OnCumulativeAmountFCChanged();
                this.OnPropertyChanged("CumulativeAmountFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _CumulativeAmountFC;
        partial void OnCumulativeAmountFCChanging(global::System.Nullable<double> value);
        partial void OnCumulativeAmountFCChanged();
        /// <summary>
        /// There are no comments for Property FreeText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FreeText")]
        public virtual string FreeText
        {
            get
            {
                return this._FreeText;
            }
            set
            {
                this.OnFreeTextChanging(value);
                this._FreeText = value;
                this.OnFreeTextChanged();
                this.OnPropertyChanged("FreeText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FreeText;
        partial void OnFreeTextChanging(string value);
        partial void OnFreeTextChanged();
        /// <summary>
        /// There are no comments for Property InventoryUoM in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InventoryUoM")]
        public virtual string InventoryUoM
        {
            get
            {
                return this._InventoryUoM;
            }
            set
            {
                this.OnInventoryUoMChanging(value);
                this._InventoryUoM = value;
                this.OnInventoryUoMChanged();
                this.OnPropertyChanged("InventoryUoM");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InventoryUoM;
        partial void OnInventoryUoMChanging(string value);
        partial void OnInventoryUoMChanged();
        /// <summary>
        /// There are no comments for Property PortionOfReturns in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PortionOfReturns")]
        public virtual global::System.Nullable<double> PortionOfReturns
        {
            get
            {
                return this._PortionOfReturns;
            }
            set
            {
                this.OnPortionOfReturnsChanging(value);
                this._PortionOfReturns = value;
                this.OnPortionOfReturnsChanged();
                this.OnPropertyChanged("PortionOfReturns");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _PortionOfReturns;
        partial void OnPortionOfReturnsChanging(global::System.Nullable<double> value);
        partial void OnPortionOfReturnsChanged();
        /// <summary>
        /// There are no comments for Property EndOfWarranty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EndOfWarranty")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> EndOfWarranty
        {
            get
            {
                return this._EndOfWarranty;
            }
            set
            {
                this.OnEndOfWarrantyChanging(value);
                this._EndOfWarranty = value;
                this.OnEndOfWarrantyChanged();
                this.OnPropertyChanged("EndOfWarranty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _EndOfWarranty;
        partial void OnEndOfWarrantyChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnEndOfWarrantyChanged();
        /// <summary>
        /// There are no comments for Property PlannedAmountLC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlannedAmountLC")]
        public virtual global::System.Nullable<double> PlannedAmountLC
        {
            get
            {
                return this._PlannedAmountLC;
            }
            set
            {
                this.OnPlannedAmountLCChanging(value);
                this._PlannedAmountLC = value;
                this.OnPlannedAmountLCChanged();
                this.OnPropertyChanged("PlannedAmountLC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _PlannedAmountLC;
        partial void OnPlannedAmountLCChanging(global::System.Nullable<double> value);
        partial void OnPlannedAmountLCChanged();
        /// <summary>
        /// There are no comments for Property PlannedAmountFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlannedAmountFC")]
        public virtual global::System.Nullable<double> PlannedAmountFC
        {
            get
            {
                return this._PlannedAmountFC;
            }
            set
            {
                this.OnPlannedAmountFCChanging(value);
                this._PlannedAmountFC = value;
                this.OnPlannedAmountFCChanged();
                this.OnPropertyChanged("PlannedAmountFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _PlannedAmountFC;
        partial void OnPlannedAmountFCChanging(global::System.Nullable<double> value);
        partial void OnPlannedAmountFCChanged();
        /// <summary>
        /// There are no comments for Property LineDiscount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineDiscount")]
        public virtual global::System.Nullable<double> LineDiscount
        {
            get
            {
                return this._LineDiscount;
            }
            set
            {
                this.OnLineDiscountChanging(value);
                this._LineDiscount = value;
                this.OnLineDiscountChanged();
                this.OnPropertyChanged("LineDiscount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _LineDiscount;
        partial void OnLineDiscountChanging(global::System.Nullable<double> value);
        partial void OnLineDiscountChanged();
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
        /// There are no comments for Property UoMCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UoMCode")]
        public virtual string UoMCode
        {
            get
            {
                return this._UoMCode;
            }
            set
            {
                this.OnUoMCodeChanging(value);
                this._UoMCode = value;
                this.OnUoMCodeChanged();
                this.OnPropertyChanged("UoMCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UoMCode;
        partial void OnUoMCodeChanging(string value);
        partial void OnUoMCodeChanged();
        /// <summary>
        /// There are no comments for Property UnitsOfMeasurement in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UnitsOfMeasurement")]
        public virtual global::System.Nullable<double> UnitsOfMeasurement
        {
            get
            {
                return this._UnitsOfMeasurement;
            }
            set
            {
                this.OnUnitsOfMeasurementChanging(value);
                this._UnitsOfMeasurement = value;
                this.OnUnitsOfMeasurementChanged();
                this.OnPropertyChanged("UnitsOfMeasurement");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _UnitsOfMeasurement;
        partial void OnUnitsOfMeasurementChanging(global::System.Nullable<double> value);
        partial void OnUnitsOfMeasurementChanged();
        /// <summary>
        /// There are no comments for Property UndeliveredCumulativeQuantity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UndeliveredCumulativeQuantity")]
        public virtual global::System.Nullable<double> UndeliveredCumulativeQuantity
        {
            get
            {
                return this._UndeliveredCumulativeQuantity;
            }
            set
            {
                this.OnUndeliveredCumulativeQuantityChanging(value);
                this._UndeliveredCumulativeQuantity = value;
                this.OnUndeliveredCumulativeQuantityChanged();
                this.OnPropertyChanged("UndeliveredCumulativeQuantity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _UndeliveredCumulativeQuantity;
        partial void OnUndeliveredCumulativeQuantityChanging(global::System.Nullable<double> value);
        partial void OnUndeliveredCumulativeQuantityChanged();
        /// <summary>
        /// There are no comments for Property UndeliveredCumulativeAmountLC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UndeliveredCumulativeAmountLC")]
        public virtual global::System.Nullable<double> UndeliveredCumulativeAmountLC
        {
            get
            {
                return this._UndeliveredCumulativeAmountLC;
            }
            set
            {
                this.OnUndeliveredCumulativeAmountLCChanging(value);
                this._UndeliveredCumulativeAmountLC = value;
                this.OnUndeliveredCumulativeAmountLCChanged();
                this.OnPropertyChanged("UndeliveredCumulativeAmountLC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _UndeliveredCumulativeAmountLC;
        partial void OnUndeliveredCumulativeAmountLCChanging(global::System.Nullable<double> value);
        partial void OnUndeliveredCumulativeAmountLCChanged();
        /// <summary>
        /// There are no comments for Property UndeliveredCumulativeAmountFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UndeliveredCumulativeAmountFC")]
        public virtual global::System.Nullable<double> UndeliveredCumulativeAmountFC
        {
            get
            {
                return this._UndeliveredCumulativeAmountFC;
            }
            set
            {
                this.OnUndeliveredCumulativeAmountFCChanging(value);
                this._UndeliveredCumulativeAmountFC = value;
                this.OnUndeliveredCumulativeAmountFCChanged();
                this.OnPropertyChanged("UndeliveredCumulativeAmountFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _UndeliveredCumulativeAmountFC;
        partial void OnUndeliveredCumulativeAmountFCChanging(global::System.Nullable<double> value);
        partial void OnUndeliveredCumulativeAmountFCChanged();
        /// <summary>
        /// There are no comments for Property ShippingType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShippingType")]
        public virtual global::System.Nullable<int> ShippingType
        {
            get
            {
                return this._ShippingType;
            }
            set
            {
                this.OnShippingTypeChanging(value);
                this._ShippingType = value;
                this.OnShippingTypeChanged();
                this.OnPropertyChanged("ShippingType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ShippingType;
        partial void OnShippingTypeChanging(global::System.Nullable<int> value);
        partial void OnShippingTypeChanged();
        /// <summary>
        /// There are no comments for Property Project in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Project")]
        public virtual string Project
        {
            get
            {
                return this._Project;
            }
            set
            {
                this.OnProjectChanging(value);
                this._Project = value;
                this.OnProjectChanged();
                this.OnPropertyChanged("Project");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Project;
        partial void OnProjectChanging(string value);
        partial void OnProjectChanged();
        /// <summary>
        /// There are no comments for Property TaxCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxCode")]
        public virtual string TaxCode
        {
            get
            {
                return this._TaxCode;
            }
            set
            {
                this.OnTaxCodeChanging(value);
                this._TaxCode = value;
                this.OnTaxCodeChanged();
                this.OnPropertyChanged("TaxCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaxCode;
        partial void OnTaxCodeChanging(string value);
        partial void OnTaxCodeChanged();
        /// <summary>
        /// There are no comments for Property TAXRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TAXRate")]
        public virtual global::System.Nullable<double> TAXRate
        {
            get
            {
                return this._TAXRate;
            }
            set
            {
                this.OnTAXRateChanging(value);
                this._TAXRate = value;
                this.OnTAXRateChanged();
                this.OnPropertyChanged("TAXRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _TAXRate;
        partial void OnTAXRateChanging(global::System.Nullable<double> value);
        partial void OnTAXRateChanged();
        /// <summary>
        /// There are no comments for Property PlannedVATAmountLC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlannedVATAmountLC")]
        public virtual global::System.Nullable<double> PlannedVATAmountLC
        {
            get
            {
                return this._PlannedVATAmountLC;
            }
            set
            {
                this.OnPlannedVATAmountLCChanging(value);
                this._PlannedVATAmountLC = value;
                this.OnPlannedVATAmountLCChanged();
                this.OnPropertyChanged("PlannedVATAmountLC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _PlannedVATAmountLC;
        partial void OnPlannedVATAmountLCChanging(global::System.Nullable<double> value);
        partial void OnPlannedVATAmountLCChanged();
        /// <summary>
        /// There are no comments for Property PlannedVATAmountFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PlannedVATAmountFC")]
        public virtual global::System.Nullable<double> PlannedVATAmountFC
        {
            get
            {
                return this._PlannedVATAmountFC;
            }
            set
            {
                this.OnPlannedVATAmountFCChanging(value);
                this._PlannedVATAmountFC = value;
                this.OnPlannedVATAmountFCChanged();
                this.OnPropertyChanged("PlannedVATAmountFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _PlannedVATAmountFC;
        partial void OnPlannedVATAmountFCChanging(global::System.Nullable<double> value);
        partial void OnPlannedVATAmountFCChanged();
        /// <summary>
        /// There are no comments for Property CumulativeVATAmountLC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CumulativeVATAmountLC")]
        public virtual global::System.Nullable<double> CumulativeVATAmountLC
        {
            get
            {
                return this._CumulativeVATAmountLC;
            }
            set
            {
                this.OnCumulativeVATAmountLCChanging(value);
                this._CumulativeVATAmountLC = value;
                this.OnCumulativeVATAmountLCChanged();
                this.OnPropertyChanged("CumulativeVATAmountLC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _CumulativeVATAmountLC;
        partial void OnCumulativeVATAmountLCChanging(global::System.Nullable<double> value);
        partial void OnCumulativeVATAmountLCChanged();
        /// <summary>
        /// There are no comments for Property CumulativeVATAmountFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CumulativeVATAmountFC")]
        public virtual global::System.Nullable<double> CumulativeVATAmountFC
        {
            get
            {
                return this._CumulativeVATAmountFC;
            }
            set
            {
                this.OnCumulativeVATAmountFCChanging(value);
                this._CumulativeVATAmountFC = value;
                this.OnCumulativeVATAmountFCChanged();
                this.OnPropertyChanged("CumulativeVATAmountFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _CumulativeVATAmountFC;
        partial void OnCumulativeVATAmountFCChanging(global::System.Nullable<double> value);
        partial void OnCumulativeVATAmountFCChanged();
        /// <summary>
        /// There are no comments for Property BlanketAgreements_DetailsLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BlanketAgreements_DetailsLines")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BlanketAgreements_DetailsLine> BlanketAgreements_DetailsLines
        {
            get
            {
                return this._BlanketAgreements_DetailsLines;
            }
            set
            {
                this.OnBlanketAgreements_DetailsLinesChanging(value);
                this._BlanketAgreements_DetailsLines = value;
                this.OnBlanketAgreements_DetailsLinesChanged();
                this.OnPropertyChanged("BlanketAgreements_DetailsLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BlanketAgreements_DetailsLine> _BlanketAgreements_DetailsLines = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BlanketAgreements_DetailsLine>();
        partial void OnBlanketAgreements_DetailsLinesChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BlanketAgreements_DetailsLine> value);
        partial void OnBlanketAgreements_DetailsLinesChanged();
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
