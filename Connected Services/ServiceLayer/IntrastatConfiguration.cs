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
    /// There are no comments for IntrastatConfigurationSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("IntrastatConfigurationSingle")]
    public partial class IntrastatConfigurationSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<IntrastatConfiguration>
    {
        /// <summary>
        /// Initialize a new IntrastatConfigurationSingle object.
        /// </summary>
        public IntrastatConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new IntrastatConfigurationSingle object.
        /// </summary>
        public IntrastatConfigurationSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new IntrastatConfigurationSingle object.
        /// </summary>
        public IntrastatConfigurationSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<IntrastatConfiguration> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for IntrastatConfiguration in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AbsEntry
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AbsEntry")]
    [global::Microsoft.OData.Client.EntitySet("IntrastatConfiguration")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("IntrastatConfiguration")]
    public partial class IntrastatConfiguration : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new IntrastatConfiguration object.
        /// </summary>
        /// <param name="absEntry">Initial value of AbsEntry.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static IntrastatConfiguration CreateIntrastatConfiguration(int absEntry)
        {
            IntrastatConfiguration intrastatConfiguration = new IntrastatConfiguration();
            intrastatConfiguration.AbsEntry = absEntry;
            return intrastatConfiguration;
        }
        /// <summary>
        /// There are no comments for Property AbsEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AbsEntry")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AbsEntry is required.")]
        public virtual int AbsEntry
        {
            get
            {
                return this._AbsEntry;
            }
            set
            {
                this.OnAbsEntryChanging(value);
                this._AbsEntry = value;
                this.OnAbsEntryChanged();
                this.OnPropertyChanged("AbsEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _AbsEntry;
        partial void OnAbsEntryChanging(int value);
        partial void OnAbsEntryChanged();
        /// <summary>
        /// There are no comments for Property ConfType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfType")]
        public virtual global::System.Nullable<global::SAPB1.IntrastatConfigurationEnum> ConfType
        {
            get
            {
                return this._ConfType;
            }
            set
            {
                this.OnConfTypeChanging(value);
                this._ConfType = value;
                this.OnConfTypeChanged();
                this.OnPropertyChanged("ConfType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.IntrastatConfigurationEnum> _ConfType;
        partial void OnConfTypeChanging(global::System.Nullable<global::SAPB1.IntrastatConfigurationEnum> value);
        partial void OnConfTypeChanged();
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        public virtual string Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                this.OnCodeChanging(value);
                this._Code = value;
                this.OnCodeChanged();
                this.OnPropertyChanged("Code");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Code;
        partial void OnCodeChanging(string value);
        partial void OnCodeChanged();
        /// <summary>
        /// There are no comments for Property Descr in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Descr")]
        public virtual string Descr
        {
            get
            {
                return this._Descr;
            }
            set
            {
                this.OnDescrChanging(value);
                this._Descr = value;
                this.OnDescrChanged();
                this.OnPropertyChanged("Descr");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Descr;
        partial void OnDescrChanging(string value);
        partial void OnDescrChanged();
        /// <summary>
        /// There are no comments for Property PrcstVal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrcstVal")]
        public virtual global::System.Nullable<double> PrcstVal
        {
            get
            {
                return this._PrcstVal;
            }
            set
            {
                this.OnPrcstValChanging(value);
                this._PrcstVal = value;
                this.OnPrcstValChanged();
                this.OnPropertyChanged("PrcstVal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _PrcstVal;
        partial void OnPrcstValChanging(global::System.Nullable<double> value);
        partial void OnPrcstValChanged();
        /// <summary>
        /// There are no comments for Property SuppUnit in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SuppUnit")]
        public virtual global::System.Nullable<int> SuppUnit
        {
            get
            {
                return this._SuppUnit;
            }
            set
            {
                this.OnSuppUnitChanging(value);
                this._SuppUnit = value;
                this.OnSuppUnitChanged();
                this.OnPropertyChanged("SuppUnit");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SuppUnit;
        partial void OnSuppUnitChanging(global::System.Nullable<int> value);
        partial void OnSuppUnitChanged();
        /// <summary>
        /// There are no comments for Property Export in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Export")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Export
        {
            get
            {
                return this._Export;
            }
            set
            {
                this.OnExportChanging(value);
                this._Export = value;
                this.OnExportChanged();
                this.OnPropertyChanged("Export");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Export;
        partial void OnExportChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnExportChanged();
        /// <summary>
        /// There are no comments for Property Import in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Import")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Import
        {
            get
            {
                return this._Import;
            }
            set
            {
                this.OnImportChanging(value);
                this._Import = value;
                this.OnImportChanged();
                this.OnPropertyChanged("Import");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Import;
        partial void OnImportChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnImportChanged();
        /// <summary>
        /// There are no comments for Property StatCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StatCode")]
        public virtual string StatCode
        {
            get
            {
                return this._StatCode;
            }
            set
            {
                this.OnStatCodeChanging(value);
                this._StatCode = value;
                this.OnStatCodeChanged();
                this.OnPropertyChanged("StatCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StatCode;
        partial void OnStatCodeChanging(string value);
        partial void OnStatCodeChanged();
        /// <summary>
        /// There are no comments for Property DateFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateFrom")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DateFrom
        {
            get
            {
                return this._DateFrom;
            }
            set
            {
                this.OnDateFromChanging(value);
                this._DateFrom = value;
                this.OnDateFromChanged();
                this.OnPropertyChanged("DateFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DateFrom;
        partial void OnDateFromChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDateFromChanged();
        /// <summary>
        /// There are no comments for Property DateTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateTo")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DateTo
        {
            get
            {
                return this._DateTo;
            }
            set
            {
                this.OnDateToChanging(value);
                this._DateTo = value;
                this.OnDateToChanged();
                this.OnPropertyChanged("DateTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DateTo;
        partial void OnDateToChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDateToChanged();
        /// <summary>
        /// There are no comments for Property Country in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Country")]
        public virtual string Country
        {
            get
            {
                return this._Country;
            }
            set
            {
                this.OnCountryChanging(value);
                this._Country = value;
                this.OnCountryChanged();
                this.OnPropertyChanged("Country");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Country;
        partial void OnCountryChanging(string value);
        partial void OnCountryChanged();
        /// <summary>
        /// There are no comments for Property ConfID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConfID")]
        public virtual string ConfID
        {
            get
            {
                return this._ConfID;
            }
            set
            {
                this.OnConfIDChanging(value);
                this._ConfID = value;
                this.OnConfIDChanged();
                this.OnPropertyChanged("ConfID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConfID;
        partial void OnConfIDChanging(string value);
        partial void OnConfIDChanged();
        /// <summary>
        /// There are no comments for Property TriangDeal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TriangDeal")]
        public virtual global::System.Nullable<global::SAPB1.IntrastatConfigurationTriangDealEnum> TriangDeal
        {
            get
            {
                return this._TriangDeal;
            }
            set
            {
                this.OnTriangDealChanging(value);
                this._TriangDeal = value;
                this.OnTriangDealChanged();
                this.OnPropertyChanged("TriangDeal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.IntrastatConfigurationTriangDealEnum> _TriangDeal;
        partial void OnTriangDealChanging(global::System.Nullable<global::SAPB1.IntrastatConfigurationTriangDealEnum> value);
        partial void OnTriangDealChanged();
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
