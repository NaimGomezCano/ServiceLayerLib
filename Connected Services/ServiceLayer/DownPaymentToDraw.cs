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
    /// There are no comments for DownPaymentToDraw in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DownPaymentToDraw")]
    public partial class DownPaymentToDraw : global::System.ComponentModel.INotifyPropertyChanged
    {
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
        /// There are no comments for Property PostingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostingDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> PostingDate
        {
            get
            {
                return this._PostingDate;
            }
            set
            {
                this.OnPostingDateChanging(value);
                this._PostingDate = value;
                this.OnPostingDateChanged();
                this.OnPropertyChanged("PostingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _PostingDate;
        partial void OnPostingDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnPostingDateChanged();
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
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Details in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Details")]
        public virtual string Details
        {
            get
            {
                return this._Details;
            }
            set
            {
                this.OnDetailsChanging(value);
                this._Details = value;
                this.OnDetailsChanged();
                this.OnPropertyChanged("Details");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Details;
        partial void OnDetailsChanging(string value);
        partial void OnDetailsChanged();
        /// <summary>
        /// There are no comments for Property AmountToDraw in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AmountToDraw")]
        public virtual global::System.Nullable<double> AmountToDraw
        {
            get
            {
                return this._AmountToDraw;
            }
            set
            {
                this.OnAmountToDrawChanging(value);
                this._AmountToDraw = value;
                this.OnAmountToDrawChanged();
                this.OnPropertyChanged("AmountToDraw");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _AmountToDraw;
        partial void OnAmountToDrawChanging(global::System.Nullable<double> value);
        partial void OnAmountToDrawChanged();
        /// <summary>
        /// There are no comments for Property DownPaymentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DownPaymentType")]
        public virtual global::System.Nullable<global::SAPB1.DownPaymentTypeEnum> DownPaymentType
        {
            get
            {
                return this._DownPaymentType;
            }
            set
            {
                this.OnDownPaymentTypeChanging(value);
                this._DownPaymentType = value;
                this.OnDownPaymentTypeChanged();
                this.OnPropertyChanged("DownPaymentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.DownPaymentTypeEnum> _DownPaymentType;
        partial void OnDownPaymentTypeChanging(global::System.Nullable<global::SAPB1.DownPaymentTypeEnum> value);
        partial void OnDownPaymentTypeChanged();
        /// <summary>
        /// There are no comments for Property AmountToDrawFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AmountToDrawFC")]
        public virtual global::System.Nullable<double> AmountToDrawFC
        {
            get
            {
                return this._AmountToDrawFC;
            }
            set
            {
                this.OnAmountToDrawFCChanging(value);
                this._AmountToDrawFC = value;
                this.OnAmountToDrawFCChanged();
                this.OnPropertyChanged("AmountToDrawFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _AmountToDrawFC;
        partial void OnAmountToDrawFCChanging(global::System.Nullable<double> value);
        partial void OnAmountToDrawFCChanged();
        /// <summary>
        /// There are no comments for Property AmountToDrawSC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AmountToDrawSC")]
        public virtual global::System.Nullable<double> AmountToDrawSC
        {
            get
            {
                return this._AmountToDrawSC;
            }
            set
            {
                this.OnAmountToDrawSCChanging(value);
                this._AmountToDrawSC = value;
                this.OnAmountToDrawSCChanged();
                this.OnPropertyChanged("AmountToDrawSC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _AmountToDrawSC;
        partial void OnAmountToDrawSCChanging(global::System.Nullable<double> value);
        partial void OnAmountToDrawSCChanged();
        /// <summary>
        /// There are no comments for Property DocInternalID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocInternalID")]
        public virtual global::System.Nullable<int> DocInternalID
        {
            get
            {
                return this._DocInternalID;
            }
            set
            {
                this.OnDocInternalIDChanging(value);
                this._DocInternalID = value;
                this.OnDocInternalIDChanged();
                this.OnPropertyChanged("DocInternalID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DocInternalID;
        partial void OnDocInternalIDChanging(global::System.Nullable<int> value);
        partial void OnDocInternalIDChanged();
        /// <summary>
        /// There are no comments for Property RowNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RowNum")]
        public virtual global::System.Nullable<int> RowNum
        {
            get
            {
                return this._RowNum;
            }
            set
            {
                this.OnRowNumChanging(value);
                this._RowNum = value;
                this.OnRowNumChanged();
                this.OnPropertyChanged("RowNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _RowNum;
        partial void OnRowNumChanging(global::System.Nullable<int> value);
        partial void OnRowNumChanged();
        /// <summary>
        /// There are no comments for Property DocNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocNumber")]
        public virtual global::System.Nullable<int> DocNumber
        {
            get
            {
                return this._DocNumber;
            }
            set
            {
                this.OnDocNumberChanging(value);
                this._DocNumber = value;
                this.OnDocNumberChanged();
                this.OnPropertyChanged("DocNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DocNumber;
        partial void OnDocNumberChanging(global::System.Nullable<int> value);
        partial void OnDocNumberChanged();
        /// <summary>
        /// There are no comments for Property Tax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Tax")]
        public virtual global::System.Nullable<double> Tax
        {
            get
            {
                return this._Tax;
            }
            set
            {
                this.OnTaxChanging(value);
                this._Tax = value;
                this.OnTaxChanged();
                this.OnPropertyChanged("Tax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Tax;
        partial void OnTaxChanging(global::System.Nullable<double> value);
        partial void OnTaxChanged();
        /// <summary>
        /// There are no comments for Property TaxFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxFC")]
        public virtual global::System.Nullable<double> TaxFC
        {
            get
            {
                return this._TaxFC;
            }
            set
            {
                this.OnTaxFCChanging(value);
                this._TaxFC = value;
                this.OnTaxFCChanged();
                this.OnPropertyChanged("TaxFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _TaxFC;
        partial void OnTaxFCChanging(global::System.Nullable<double> value);
        partial void OnTaxFCChanged();
        /// <summary>
        /// There are no comments for Property TaxSC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaxSC")]
        public virtual global::System.Nullable<double> TaxSC
        {
            get
            {
                return this._TaxSC;
            }
            set
            {
                this.OnTaxSCChanging(value);
                this._TaxSC = value;
                this.OnTaxSCChanged();
                this.OnPropertyChanged("TaxSC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _TaxSC;
        partial void OnTaxSCChanging(global::System.Nullable<double> value);
        partial void OnTaxSCChanged();
        /// <summary>
        /// There are no comments for Property GrossAmountToDraw in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GrossAmountToDraw")]
        public virtual global::System.Nullable<double> GrossAmountToDraw
        {
            get
            {
                return this._GrossAmountToDraw;
            }
            set
            {
                this.OnGrossAmountToDrawChanging(value);
                this._GrossAmountToDraw = value;
                this.OnGrossAmountToDrawChanged();
                this.OnPropertyChanged("GrossAmountToDraw");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _GrossAmountToDraw;
        partial void OnGrossAmountToDrawChanging(global::System.Nullable<double> value);
        partial void OnGrossAmountToDrawChanged();
        /// <summary>
        /// There are no comments for Property GrossAmountToDrawFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GrossAmountToDrawFC")]
        public virtual global::System.Nullable<double> GrossAmountToDrawFC
        {
            get
            {
                return this._GrossAmountToDrawFC;
            }
            set
            {
                this.OnGrossAmountToDrawFCChanging(value);
                this._GrossAmountToDrawFC = value;
                this.OnGrossAmountToDrawFCChanged();
                this.OnPropertyChanged("GrossAmountToDrawFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _GrossAmountToDrawFC;
        partial void OnGrossAmountToDrawFCChanging(global::System.Nullable<double> value);
        partial void OnGrossAmountToDrawFCChanged();
        /// <summary>
        /// There are no comments for Property GrossAmountToDrawSC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GrossAmountToDrawSC")]
        public virtual global::System.Nullable<double> GrossAmountToDrawSC
        {
            get
            {
                return this._GrossAmountToDrawSC;
            }
            set
            {
                this.OnGrossAmountToDrawSCChanging(value);
                this._GrossAmountToDrawSC = value;
                this.OnGrossAmountToDrawSCChanged();
                this.OnPropertyChanged("GrossAmountToDrawSC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _GrossAmountToDrawSC;
        partial void OnGrossAmountToDrawSCChanging(global::System.Nullable<double> value);
        partial void OnGrossAmountToDrawSCChanged();
        /// <summary>
        /// There are no comments for Property IsGrossLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsGrossLine")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IsGrossLine
        {
            get
            {
                return this._IsGrossLine;
            }
            set
            {
                this.OnIsGrossLineChanging(value);
                this._IsGrossLine = value;
                this.OnIsGrossLineChanged();
                this.OnPropertyChanged("IsGrossLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IsGrossLine;
        partial void OnIsGrossLineChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIsGrossLineChanged();
        /// <summary>
        /// There are no comments for Property DownPaymentsToDrawDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DownPaymentsToDrawDetails")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.DownPaymentToDrawDetails> DownPaymentsToDrawDetails
        {
            get
            {
                return this._DownPaymentsToDrawDetails;
            }
            set
            {
                this.OnDownPaymentsToDrawDetailsChanging(value);
                this._DownPaymentsToDrawDetails = value;
                this.OnDownPaymentsToDrawDetailsChanged();
                this.OnPropertyChanged("DownPaymentsToDrawDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.DownPaymentToDrawDetails> _DownPaymentsToDrawDetails = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.DownPaymentToDrawDetails>();
        partial void OnDownPaymentsToDrawDetailsChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.DownPaymentToDrawDetails> value);
        partial void OnDownPaymentsToDrawDetailsChanged();
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
