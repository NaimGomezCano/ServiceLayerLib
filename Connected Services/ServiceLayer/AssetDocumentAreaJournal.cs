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
    /// There are no comments for AssetDocumentAreaJournal in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetDocumentAreaJournal")]
    public partial class AssetDocumentAreaJournal : global::System.ComponentModel.INotifyPropertyChanged
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
        /// There are no comments for Property DepreciationArea in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DepreciationArea")]
        public virtual string DepreciationArea
        {
            get
            {
                return this._DepreciationArea;
            }
            set
            {
                this.OnDepreciationAreaChanging(value);
                this._DepreciationArea = value;
                this.OnDepreciationAreaChanged();
                this.OnPropertyChanged("DepreciationArea");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepreciationArea;
        partial void OnDepreciationAreaChanging(string value);
        partial void OnDepreciationAreaChanged();
        /// <summary>
        /// There are no comments for Property JournalRemarks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JournalRemarks")]
        public virtual string JournalRemarks
        {
            get
            {
                return this._JournalRemarks;
            }
            set
            {
                this.OnJournalRemarksChanging(value);
                this._JournalRemarks = value;
                this.OnJournalRemarksChanged();
                this.OnPropertyChanged("JournalRemarks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _JournalRemarks;
        partial void OnJournalRemarksChanging(string value);
        partial void OnJournalRemarksChanged();
        /// <summary>
        /// There are no comments for Property TransactionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionNumber")]
        public virtual global::System.Nullable<int> TransactionNumber
        {
            get
            {
                return this._TransactionNumber;
            }
            set
            {
                this.OnTransactionNumberChanging(value);
                this._TransactionNumber = value;
                this.OnTransactionNumberChanged();
                this.OnPropertyChanged("TransactionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _TransactionNumber;
        partial void OnTransactionNumberChanging(global::System.Nullable<int> value);
        partial void OnTransactionNumberChanged();
        /// <summary>
        /// There are no comments for Property CancellationJournalRemarks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CancellationJournalRemarks")]
        public virtual string CancellationJournalRemarks
        {
            get
            {
                return this._CancellationJournalRemarks;
            }
            set
            {
                this.OnCancellationJournalRemarksChanging(value);
                this._CancellationJournalRemarks = value;
                this.OnCancellationJournalRemarksChanged();
                this.OnPropertyChanged("CancellationJournalRemarks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CancellationJournalRemarks;
        partial void OnCancellationJournalRemarksChanging(string value);
        partial void OnCancellationJournalRemarksChanged();
        /// <summary>
        /// There are no comments for Property CancellationTransactionNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CancellationTransactionNumber")]
        public virtual global::System.Nullable<int> CancellationTransactionNumber
        {
            get
            {
                return this._CancellationTransactionNumber;
            }
            set
            {
                this.OnCancellationTransactionNumberChanging(value);
                this._CancellationTransactionNumber = value;
                this.OnCancellationTransactionNumberChanged();
                this.OnPropertyChanged("CancellationTransactionNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _CancellationTransactionNumber;
        partial void OnCancellationTransactionNumberChanging(global::System.Nullable<int> value);
        partial void OnCancellationTransactionNumberChanged();
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
