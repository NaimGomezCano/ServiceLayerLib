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
    /// There are no comments for BPVatExemptionsLine in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BPVatExemptionsLine")]
    public partial class BPVatExemptionsLine : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property AbsoluteEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AbsoluteEntry")]
        public virtual global::System.Nullable<int> AbsoluteEntry
        {
            get
            {
                return this._AbsoluteEntry;
            }
            set
            {
                this.OnAbsoluteEntryChanging(value);
                this._AbsoluteEntry = value;
                this.OnAbsoluteEntryChanged();
                this.OnPropertyChanged("AbsoluteEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _AbsoluteEntry;
        partial void OnAbsoluteEntryChanging(global::System.Nullable<int> value);
        partial void OnAbsoluteEntryChanged();
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
        /// There are no comments for Property ExemptionDocNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExemptionDocNum")]
        public virtual string ExemptionDocNum
        {
            get
            {
                return this._ExemptionDocNum;
            }
            set
            {
                this.OnExemptionDocNumChanging(value);
                this._ExemptionDocNum = value;
                this.OnExemptionDocNumChanged();
                this.OnPropertyChanged("ExemptionDocNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExemptionDocNum;
        partial void OnExemptionDocNumChanging(string value);
        partial void OnExemptionDocNumChanged();
        /// <summary>
        /// There are no comments for Property IssueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IssueDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> IssueDate
        {
            get
            {
                return this._IssueDate;
            }
            set
            {
                this.OnIssueDateChanging(value);
                this._IssueDate = value;
                this.OnIssueDateChanged();
                this.OnPropertyChanged("IssueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _IssueDate;
        partial void OnIssueDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnIssueDateChanged();
        /// <summary>
        /// There are no comments for Property IssueTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IssueTime")]
        public virtual global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> IssueTime
        {
            get
            {
                return this._IssueTime;
            }
            set
            {
                this.OnIssueTimeChanging(value);
                this._IssueTime = value;
                this.OnIssueTimeChanged();
                this.OnPropertyChanged("IssueTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> _IssueTime;
        partial void OnIssueTimeChanging(global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> value);
        partial void OnIssueTimeChanged();
        /// <summary>
        /// There are no comments for Property ExemptionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExemptionType")]
        public virtual global::System.Nullable<int> ExemptionType
        {
            get
            {
                return this._ExemptionType;
            }
            set
            {
                this.OnExemptionTypeChanging(value);
                this._ExemptionType = value;
                this.OnExemptionTypeChanged();
                this.OnPropertyChanged("ExemptionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ExemptionType;
        partial void OnExemptionTypeChanging(global::System.Nullable<int> value);
        partial void OnExemptionTypeChanged();
        /// <summary>
        /// There are no comments for Property ApplyAllItems in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApplyAllItems")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> ApplyAllItems
        {
            get
            {
                return this._ApplyAllItems;
            }
            set
            {
                this.OnApplyAllItemsChanging(value);
                this._ApplyAllItems = value;
                this.OnApplyAllItemsChanged();
                this.OnPropertyChanged("ApplyAllItems");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _ApplyAllItems;
        partial void OnApplyAllItemsChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnApplyAllItemsChanged();
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
        /// There are no comments for Property VATRate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VATRate")]
        public virtual global::System.Nullable<double> VATRate
        {
            get
            {
                return this._VATRate;
            }
            set
            {
                this.OnVATRateChanging(value);
                this._VATRate = value;
                this.OnVATRateChanged();
                this.OnPropertyChanged("VATRate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _VATRate;
        partial void OnVATRateChanging(global::System.Nullable<double> value);
        partial void OnVATRateChanged();
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
        /// There are no comments for Property AuthoritiesName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AuthoritiesName")]
        public virtual string AuthoritiesName
        {
            get
            {
                return this._AuthoritiesName;
            }
            set
            {
                this.OnAuthoritiesNameChanging(value);
                this._AuthoritiesName = value;
                this.OnAuthoritiesNameChanged();
                this.OnPropertyChanged("AuthoritiesName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AuthoritiesName;
        partial void OnAuthoritiesNameChanging(string value);
        partial void OnAuthoritiesNameChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidFrom")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _ValidFrom;
        partial void OnValidFromChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidTo")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _ValidTo;
        partial void OnValidToChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property VisualOrder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VisualOrder")]
        public virtual global::System.Nullable<int> VisualOrder
        {
            get
            {
                return this._VisualOrder;
            }
            set
            {
                this.OnVisualOrderChanging(value);
                this._VisualOrder = value;
                this.OnVisualOrderChanged();
                this.OnPropertyChanged("VisualOrder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _VisualOrder;
        partial void OnVisualOrderChanging(global::System.Nullable<int> value);
        partial void OnVisualOrderChanged();
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
