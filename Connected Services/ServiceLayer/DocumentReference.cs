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
    /// There are no comments for DocumentReference in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentReference")]
    public partial class DocumentReference : global::System.ComponentModel.INotifyPropertyChanged
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
        /// There are no comments for Property RefDocEntr in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefDocEntr")]
        public virtual global::System.Nullable<int> RefDocEntr
        {
            get
            {
                return this._RefDocEntr;
            }
            set
            {
                this.OnRefDocEntrChanging(value);
                this._RefDocEntr = value;
                this.OnRefDocEntrChanged();
                this.OnPropertyChanged("RefDocEntr");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _RefDocEntr;
        partial void OnRefDocEntrChanging(global::System.Nullable<int> value);
        partial void OnRefDocEntrChanged();
        /// <summary>
        /// There are no comments for Property RefDocNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefDocNum")]
        public virtual global::System.Nullable<int> RefDocNum
        {
            get
            {
                return this._RefDocNum;
            }
            set
            {
                this.OnRefDocNumChanging(value);
                this._RefDocNum = value;
                this.OnRefDocNumChanged();
                this.OnPropertyChanged("RefDocNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _RefDocNum;
        partial void OnRefDocNumChanging(global::System.Nullable<int> value);
        partial void OnRefDocNumChanged();
        /// <summary>
        /// There are no comments for Property ExtDocNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExtDocNum")]
        public virtual string ExtDocNum
        {
            get
            {
                return this._ExtDocNum;
            }
            set
            {
                this.OnExtDocNumChanging(value);
                this._ExtDocNum = value;
                this.OnExtDocNumChanged();
                this.OnPropertyChanged("ExtDocNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExtDocNum;
        partial void OnExtDocNumChanging(string value);
        partial void OnExtDocNumChanged();
        /// <summary>
        /// There are no comments for Property RefObjType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefObjType")]
        public virtual global::System.Nullable<global::SAPB1.ReferencedObjectTypeEnum> RefObjType
        {
            get
            {
                return this._RefObjType;
            }
            set
            {
                this.OnRefObjTypeChanging(value);
                this._RefObjType = value;
                this.OnRefObjTypeChanged();
                this.OnPropertyChanged("RefObjType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ReferencedObjectTypeEnum> _RefObjType;
        partial void OnRefObjTypeChanging(global::System.Nullable<global::SAPB1.ReferencedObjectTypeEnum> value);
        partial void OnRefObjTypeChanged();
        /// <summary>
        /// There are no comments for Property AccessKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccessKey")]
        public virtual string AccessKey
        {
            get
            {
                return this._AccessKey;
            }
            set
            {
                this.OnAccessKeyChanging(value);
                this._AccessKey = value;
                this.OnAccessKeyChanged();
                this.OnPropertyChanged("AccessKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccessKey;
        partial void OnAccessKeyChanging(string value);
        partial void OnAccessKeyChanged();
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
        /// There are no comments for Property IssuerCNPJ in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IssuerCNPJ")]
        public virtual string IssuerCNPJ
        {
            get
            {
                return this._IssuerCNPJ;
            }
            set
            {
                this.OnIssuerCNPJChanging(value);
                this._IssuerCNPJ = value;
                this.OnIssuerCNPJChanged();
                this.OnPropertyChanged("IssuerCNPJ");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IssuerCNPJ;
        partial void OnIssuerCNPJChanging(string value);
        partial void OnIssuerCNPJChanged();
        /// <summary>
        /// There are no comments for Property IssuerCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IssuerCode")]
        public virtual string IssuerCode
        {
            get
            {
                return this._IssuerCode;
            }
            set
            {
                this.OnIssuerCodeChanging(value);
                this._IssuerCode = value;
                this.OnIssuerCodeChanged();
                this.OnPropertyChanged("IssuerCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IssuerCode;
        partial void OnIssuerCodeChanging(string value);
        partial void OnIssuerCodeChanged();
        /// <summary>
        /// There are no comments for Property Model in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Model")]
        public virtual string Model
        {
            get
            {
                return this._Model;
            }
            set
            {
                this.OnModelChanging(value);
                this._Model = value;
                this.OnModelChanged();
                this.OnPropertyChanged("Model");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Model;
        partial void OnModelChanging(string value);
        partial void OnModelChanged();
        /// <summary>
        /// There are no comments for Property Series in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Series")]
        public virtual string Series
        {
            get
            {
                return this._Series;
            }
            set
            {
                this.OnSeriesChanging(value);
                this._Series = value;
                this.OnSeriesChanged();
                this.OnPropertyChanged("Series");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Series;
        partial void OnSeriesChanging(string value);
        partial void OnSeriesChanged();
        /// <summary>
        /// There are no comments for Property Number in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Number")]
        public virtual global::System.Nullable<int> Number
        {
            get
            {
                return this._Number;
            }
            set
            {
                this.OnNumberChanging(value);
                this._Number = value;
                this.OnNumberChanged();
                this.OnPropertyChanged("Number");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Number;
        partial void OnNumberChanging(global::System.Nullable<int> value);
        partial void OnNumberChanged();
        /// <summary>
        /// There are no comments for Property RefAccKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefAccKey")]
        public virtual string RefAccKey
        {
            get
            {
                return this._RefAccKey;
            }
            set
            {
                this.OnRefAccKeyChanging(value);
                this._RefAccKey = value;
                this.OnRefAccKeyChanged();
                this.OnPropertyChanged("RefAccKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RefAccKey;
        partial void OnRefAccKeyChanging(string value);
        partial void OnRefAccKeyChanged();
        /// <summary>
        /// There are no comments for Property RefAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RefAmount")]
        public virtual global::System.Nullable<double> RefAmount
        {
            get
            {
                return this._RefAmount;
            }
            set
            {
                this.OnRefAmountChanging(value);
                this._RefAmount = value;
                this.OnRefAmountChanged();
                this.OnPropertyChanged("RefAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _RefAmount;
        partial void OnRefAmountChanging(global::System.Nullable<double> value);
        partial void OnRefAmountChanged();
        /// <summary>
        /// There are no comments for Property SubSeries in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubSeries")]
        public virtual string SubSeries
        {
            get
            {
                return this._SubSeries;
            }
            set
            {
                this.OnSubSeriesChanging(value);
                this._SubSeries = value;
                this.OnSubSeriesChanged();
                this.OnPropertyChanged("SubSeries");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SubSeries;
        partial void OnSubSeriesChanging(string value);
        partial void OnSubSeriesChanged();
        /// <summary>
        /// There are no comments for Property Remark in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Remark")]
        public virtual string Remark
        {
            get
            {
                return this._Remark;
            }
            set
            {
                this.OnRemarkChanging(value);
                this._Remark = value;
                this.OnRemarkChanged();
                this.OnPropertyChanged("Remark");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Remark;
        partial void OnRemarkChanging(string value);
        partial void OnRemarkChanged();
        /// <summary>
        /// There are no comments for Property LinkRefTyp in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LinkRefTyp")]
        public virtual global::System.Nullable<global::SAPB1.LinkReferenceTypeEnum> LinkRefTyp
        {
            get
            {
                return this._LinkRefTyp;
            }
            set
            {
                this.OnLinkRefTypChanging(value);
                this._LinkRefTyp = value;
                this.OnLinkRefTypChanged();
                this.OnPropertyChanged("LinkRefTyp");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.LinkReferenceTypeEnum> _LinkRefTyp;
        partial void OnLinkRefTypChanging(global::System.Nullable<global::SAPB1.LinkReferenceTypeEnum> value);
        partial void OnLinkRefTypChanged();
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