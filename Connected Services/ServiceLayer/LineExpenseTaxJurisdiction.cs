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
    /// There are no comments for LineExpenseTaxJurisdiction in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("LineExpenseTaxJurisdiction")]
    public partial class LineExpenseTaxJurisdiction : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property JurisdictionCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JurisdictionCode")]
        public virtual string JurisdictionCode
        {
            get
            {
                return this._JurisdictionCode;
            }
            set
            {
                this.OnJurisdictionCodeChanging(value);
                this._JurisdictionCode = value;
                this.OnJurisdictionCodeChanged();
                this.OnPropertyChanged("JurisdictionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JurisdictionCode;
        partial void OnJurisdictionCodeChanging(string value);
        partial void OnJurisdictionCodeChanged();
        /// <summary>
        /// There are no comments for Property JurisdictionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JurisdictionType")]
        public virtual global::System.Nullable<int> JurisdictionType
        {
            get
            {
                return this._JurisdictionType;
            }
            set
            {
                this.OnJurisdictionTypeChanging(value);
                this._JurisdictionType = value;
                this.OnJurisdictionTypeChanged();
                this.OnPropertyChanged("JurisdictionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _JurisdictionType;
        partial void OnJurisdictionTypeChanging(global::System.Nullable<int> value);
        partial void OnJurisdictionTypeChanged();
        /// <summary>
        /// There are no comments for Property TaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxAmount")]
        public virtual global::System.Nullable<double> TaxAmount
        {
            get
            {
                return this._TaxAmount;
            }
            set
            {
                this.OnTaxAmountChanging(value);
                this._TaxAmount = value;
                this.OnTaxAmountChanged();
                this.OnPropertyChanged("TaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _TaxAmount;
        partial void OnTaxAmountChanging(global::System.Nullable<double> value);
        partial void OnTaxAmountChanged();
        /// <summary>
        /// There are no comments for Property TaxAmountSC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxAmountSC")]
        public virtual global::System.Nullable<double> TaxAmountSC
        {
            get
            {
                return this._TaxAmountSC;
            }
            set
            {
                this.OnTaxAmountSCChanging(value);
                this._TaxAmountSC = value;
                this.OnTaxAmountSCChanged();
                this.OnPropertyChanged("TaxAmountSC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _TaxAmountSC;
        partial void OnTaxAmountSCChanging(global::System.Nullable<double> value);
        partial void OnTaxAmountSCChanged();
        /// <summary>
        /// There are no comments for Property TaxAmountFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxAmountFC")]
        public virtual global::System.Nullable<double> TaxAmountFC
        {
            get
            {
                return this._TaxAmountFC;
            }
            set
            {
                this.OnTaxAmountFCChanging(value);
                this._TaxAmountFC = value;
                this.OnTaxAmountFCChanged();
                this.OnPropertyChanged("TaxAmountFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _TaxAmountFC;
        partial void OnTaxAmountFCChanging(global::System.Nullable<double> value);
        partial void OnTaxAmountFCChanged();
        /// <summary>
        /// There are no comments for Property TaxRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxRate")]
        public virtual global::System.Nullable<double> TaxRate
        {
            get
            {
                return this._TaxRate;
            }
            set
            {
                this.OnTaxRateChanging(value);
                this._TaxRate = value;
                this.OnTaxRateChanged();
                this.OnPropertyChanged("TaxRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _TaxRate;
        partial void OnTaxRateChanging(global::System.Nullable<double> value);
        partial void OnTaxRateChanged();
        /// <summary>
        /// There are no comments for Property DocEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocEntry")]
        public virtual global::System.Nullable<int> DocEntry
        {
            get
            {
                return this._DocEntry;
            }
            set
            {
                this.OnDocEntryChanging(value);
                this._DocEntry = value;
                this.OnDocEntryChanged();
                this.OnPropertyChanged("DocEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DocEntry;
        partial void OnDocEntryChanging(global::System.Nullable<int> value);
        partial void OnDocEntryChanged();
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
        /// There are no comments for Property RowSequence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RowSequence")]
        public virtual global::System.Nullable<int> RowSequence
        {
            get
            {
                return this._RowSequence;
            }
            set
            {
                this.OnRowSequenceChanging(value);
                this._RowSequence = value;
                this.OnRowSequenceChanged();
                this.OnPropertyChanged("RowSequence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _RowSequence;
        partial void OnRowSequenceChanging(global::System.Nullable<int> value);
        partial void OnRowSequenceChanged();
        /// <summary>
        /// There are no comments for Property ExternalCalcTaxRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalCalcTaxRate")]
        public virtual global::System.Nullable<double> ExternalCalcTaxRate
        {
            get
            {
                return this._ExternalCalcTaxRate;
            }
            set
            {
                this.OnExternalCalcTaxRateChanging(value);
                this._ExternalCalcTaxRate = value;
                this.OnExternalCalcTaxRateChanged();
                this.OnPropertyChanged("ExternalCalcTaxRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _ExternalCalcTaxRate;
        partial void OnExternalCalcTaxRateChanging(global::System.Nullable<double> value);
        partial void OnExternalCalcTaxRateChanged();
        /// <summary>
        /// There are no comments for Property ExternalCalcTaxAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalCalcTaxAmount")]
        public virtual global::System.Nullable<double> ExternalCalcTaxAmount
        {
            get
            {
                return this._ExternalCalcTaxAmount;
            }
            set
            {
                this.OnExternalCalcTaxAmountChanging(value);
                this._ExternalCalcTaxAmount = value;
                this.OnExternalCalcTaxAmountChanged();
                this.OnPropertyChanged("ExternalCalcTaxAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _ExternalCalcTaxAmount;
        partial void OnExternalCalcTaxAmountChanging(global::System.Nullable<double> value);
        partial void OnExternalCalcTaxAmountChanged();
        /// <summary>
        /// There are no comments for Property ExternalCalcTaxAmountFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalCalcTaxAmountFC")]
        public virtual global::System.Nullable<double> ExternalCalcTaxAmountFC
        {
            get
            {
                return this._ExternalCalcTaxAmountFC;
            }
            set
            {
                this.OnExternalCalcTaxAmountFCChanging(value);
                this._ExternalCalcTaxAmountFC = value;
                this.OnExternalCalcTaxAmountFCChanged();
                this.OnPropertyChanged("ExternalCalcTaxAmountFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _ExternalCalcTaxAmountFC;
        partial void OnExternalCalcTaxAmountFCChanging(global::System.Nullable<double> value);
        partial void OnExternalCalcTaxAmountFCChanged();
        /// <summary>
        /// There are no comments for Property ExternalCalcTaxAmountSC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalCalcTaxAmountSC")]
        public virtual global::System.Nullable<double> ExternalCalcTaxAmountSC
        {
            get
            {
                return this._ExternalCalcTaxAmountSC;
            }
            set
            {
                this.OnExternalCalcTaxAmountSCChanging(value);
                this._ExternalCalcTaxAmountSC = value;
                this.OnExternalCalcTaxAmountSCChanged();
                this.OnPropertyChanged("ExternalCalcTaxAmountSC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _ExternalCalcTaxAmountSC;
        partial void OnExternalCalcTaxAmountSCChanging(global::System.Nullable<double> value);
        partial void OnExternalCalcTaxAmountSCChanged();
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
