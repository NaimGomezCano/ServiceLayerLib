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
    /// There are no comments for DocumentSpecialLine in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentSpecialLine")]
    public partial class DocumentSpecialLine : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property LineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNum")]
        public virtual global::System.Nullable<int> LineNum
        {
            get
            {
                return this._LineNum;
            }
            set
            {
                this.OnLineNumChanging(value);
                this._LineNum = value;
                this.OnLineNumChanged();
                this.OnPropertyChanged("LineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _LineNum;
        partial void OnLineNumChanging(global::System.Nullable<int> value);
        partial void OnLineNumChanged();
        /// <summary>
        /// There are no comments for Property AfterLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AfterLineNumber")]
        public virtual global::System.Nullable<int> AfterLineNumber
        {
            get
            {
                return this._AfterLineNumber;
            }
            set
            {
                this.OnAfterLineNumberChanging(value);
                this._AfterLineNumber = value;
                this.OnAfterLineNumberChanged();
                this.OnPropertyChanged("AfterLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _AfterLineNumber;
        partial void OnAfterLineNumberChanging(global::System.Nullable<int> value);
        partial void OnAfterLineNumberChanged();
        /// <summary>
        /// There are no comments for Property OrderNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrderNumber")]
        public virtual global::System.Nullable<int> OrderNumber
        {
            get
            {
                return this._OrderNumber;
            }
            set
            {
                this.OnOrderNumberChanging(value);
                this._OrderNumber = value;
                this.OnOrderNumberChanged();
                this.OnPropertyChanged("OrderNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _OrderNumber;
        partial void OnOrderNumberChanging(global::System.Nullable<int> value);
        partial void OnOrderNumberChanged();
        /// <summary>
        /// There are no comments for Property LineType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineType")]
        public virtual global::System.Nullable<global::SAPB1.BoDocSpecialLineType> LineType
        {
            get
            {
                return this._LineType;
            }
            set
            {
                this.OnLineTypeChanging(value);
                this._LineType = value;
                this.OnLineTypeChanged();
                this.OnPropertyChanged("LineType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoDocSpecialLineType> _LineType;
        partial void OnLineTypeChanging(global::System.Nullable<global::SAPB1.BoDocSpecialLineType> value);
        partial void OnLineTypeChanged();
        /// <summary>
        /// There are no comments for Property Subtotal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Subtotal")]
        public virtual global::System.Nullable<double> Subtotal
        {
            get
            {
                return this._Subtotal;
            }
            set
            {
                this.OnSubtotalChanging(value);
                this._Subtotal = value;
                this.OnSubtotalChanged();
                this.OnPropertyChanged("Subtotal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Subtotal;
        partial void OnSubtotalChanging(global::System.Nullable<double> value);
        partial void OnSubtotalChanged();
        /// <summary>
        /// There are no comments for Property LineText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineText")]
        public virtual string LineText
        {
            get
            {
                return this._LineText;
            }
            set
            {
                this.OnLineTextChanging(value);
                this._LineText = value;
                this.OnLineTextChanged();
                this.OnPropertyChanged("LineText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LineText;
        partial void OnLineTextChanging(string value);
        partial void OnLineTextChanged();
        /// <summary>
        /// There are no comments for Property SubtotalFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubtotalFC")]
        public virtual global::System.Nullable<double> SubtotalFC
        {
            get
            {
                return this._SubtotalFC;
            }
            set
            {
                this.OnSubtotalFCChanging(value);
                this._SubtotalFC = value;
                this.OnSubtotalFCChanged();
                this.OnPropertyChanged("SubtotalFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _SubtotalFC;
        partial void OnSubtotalFCChanging(global::System.Nullable<double> value);
        partial void OnSubtotalFCChanged();
        /// <summary>
        /// There are no comments for Property SubtotalSC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubtotalSC")]
        public virtual global::System.Nullable<double> SubtotalSC
        {
            get
            {
                return this._SubtotalSC;
            }
            set
            {
                this.OnSubtotalSCChanging(value);
                this._SubtotalSC = value;
                this.OnSubtotalSCChanged();
                this.OnPropertyChanged("SubtotalSC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _SubtotalSC;
        partial void OnSubtotalSCChanging(global::System.Nullable<double> value);
        partial void OnSubtotalSCChanged();
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
        /// There are no comments for Property Freight1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Freight1")]
        public virtual global::System.Nullable<double> Freight1
        {
            get
            {
                return this._Freight1;
            }
            set
            {
                this.OnFreight1Changing(value);
                this._Freight1 = value;
                this.OnFreight1Changed();
                this.OnPropertyChanged("Freight1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Freight1;
        partial void OnFreight1Changing(global::System.Nullable<double> value);
        partial void OnFreight1Changed();
        /// <summary>
        /// There are no comments for Property Freight1FC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Freight1FC")]
        public virtual global::System.Nullable<double> Freight1FC
        {
            get
            {
                return this._Freight1FC;
            }
            set
            {
                this.OnFreight1FCChanging(value);
                this._Freight1FC = value;
                this.OnFreight1FCChanged();
                this.OnPropertyChanged("Freight1FC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Freight1FC;
        partial void OnFreight1FCChanging(global::System.Nullable<double> value);
        partial void OnFreight1FCChanged();
        /// <summary>
        /// There are no comments for Property Freight1SC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Freight1SC")]
        public virtual global::System.Nullable<double> Freight1SC
        {
            get
            {
                return this._Freight1SC;
            }
            set
            {
                this.OnFreight1SCChanging(value);
                this._Freight1SC = value;
                this.OnFreight1SCChanged();
                this.OnPropertyChanged("Freight1SC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Freight1SC;
        partial void OnFreight1SCChanging(global::System.Nullable<double> value);
        partial void OnFreight1SCChanged();
        /// <summary>
        /// There are no comments for Property Freight2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Freight2")]
        public virtual global::System.Nullable<double> Freight2
        {
            get
            {
                return this._Freight2;
            }
            set
            {
                this.OnFreight2Changing(value);
                this._Freight2 = value;
                this.OnFreight2Changed();
                this.OnPropertyChanged("Freight2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Freight2;
        partial void OnFreight2Changing(global::System.Nullable<double> value);
        partial void OnFreight2Changed();
        /// <summary>
        /// There are no comments for Property Freight2FC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Freight2FC")]
        public virtual global::System.Nullable<double> Freight2FC
        {
            get
            {
                return this._Freight2FC;
            }
            set
            {
                this.OnFreight2FCChanging(value);
                this._Freight2FC = value;
                this.OnFreight2FCChanged();
                this.OnPropertyChanged("Freight2FC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Freight2FC;
        partial void OnFreight2FCChanging(global::System.Nullable<double> value);
        partial void OnFreight2FCChanged();
        /// <summary>
        /// There are no comments for Property Freight2SC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Freight2SC")]
        public virtual global::System.Nullable<double> Freight2SC
        {
            get
            {
                return this._Freight2SC;
            }
            set
            {
                this.OnFreight2SCChanging(value);
                this._Freight2SC = value;
                this.OnFreight2SCChanged();
                this.OnPropertyChanged("Freight2SC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Freight2SC;
        partial void OnFreight2SCChanging(global::System.Nullable<double> value);
        partial void OnFreight2SCChanged();
        /// <summary>
        /// There are no comments for Property Freight3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Freight3")]
        public virtual global::System.Nullable<double> Freight3
        {
            get
            {
                return this._Freight3;
            }
            set
            {
                this.OnFreight3Changing(value);
                this._Freight3 = value;
                this.OnFreight3Changed();
                this.OnPropertyChanged("Freight3");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Freight3;
        partial void OnFreight3Changing(global::System.Nullable<double> value);
        partial void OnFreight3Changed();
        /// <summary>
        /// There are no comments for Property Freight3FC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Freight3FC")]
        public virtual global::System.Nullable<double> Freight3FC
        {
            get
            {
                return this._Freight3FC;
            }
            set
            {
                this.OnFreight3FCChanging(value);
                this._Freight3FC = value;
                this.OnFreight3FCChanged();
                this.OnPropertyChanged("Freight3FC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Freight3FC;
        partial void OnFreight3FCChanging(global::System.Nullable<double> value);
        partial void OnFreight3FCChanged();
        /// <summary>
        /// There are no comments for Property Freight3SC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Freight3SC")]
        public virtual global::System.Nullable<double> Freight3SC
        {
            get
            {
                return this._Freight3SC;
            }
            set
            {
                this.OnFreight3SCChanging(value);
                this._Freight3SC = value;
                this.OnFreight3SCChanged();
                this.OnPropertyChanged("Freight3SC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Freight3SC;
        partial void OnFreight3SCChanging(global::System.Nullable<double> value);
        partial void OnFreight3SCChanged();
        /// <summary>
        /// There are no comments for Property GrossTotal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GrossTotal")]
        public virtual global::System.Nullable<double> GrossTotal
        {
            get
            {
                return this._GrossTotal;
            }
            set
            {
                this.OnGrossTotalChanging(value);
                this._GrossTotal = value;
                this.OnGrossTotalChanged();
                this.OnPropertyChanged("GrossTotal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _GrossTotal;
        partial void OnGrossTotalChanging(global::System.Nullable<double> value);
        partial void OnGrossTotalChanged();
        /// <summary>
        /// There are no comments for Property GrossTotalFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GrossTotalFC")]
        public virtual global::System.Nullable<double> GrossTotalFC
        {
            get
            {
                return this._GrossTotalFC;
            }
            set
            {
                this.OnGrossTotalFCChanging(value);
                this._GrossTotalFC = value;
                this.OnGrossTotalFCChanged();
                this.OnPropertyChanged("GrossTotalFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _GrossTotalFC;
        partial void OnGrossTotalFCChanging(global::System.Nullable<double> value);
        partial void OnGrossTotalFCChanged();
        /// <summary>
        /// There are no comments for Property GrossTotalSC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GrossTotalSC")]
        public virtual global::System.Nullable<double> GrossTotalSC
        {
            get
            {
                return this._GrossTotalSC;
            }
            set
            {
                this.OnGrossTotalSCChanging(value);
                this._GrossTotalSC = value;
                this.OnGrossTotalSCChanged();
                this.OnPropertyChanged("GrossTotalSC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _GrossTotalSC;
        partial void OnGrossTotalSCChanging(global::System.Nullable<double> value);
        partial void OnGrossTotalSCChanged();
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
