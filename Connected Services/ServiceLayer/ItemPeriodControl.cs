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
    /// There are no comments for ItemPeriodControl in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemPeriodControl")]
    public partial class ItemPeriodControl : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property FiscalYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalYear")]
        public virtual string FiscalYear
        {
            get
            {
                return this._FiscalYear;
            }
            set
            {
                this.OnFiscalYearChanging(value);
                this._FiscalYear = value;
                this.OnFiscalYearChanged();
                this.OnPropertyChanged("FiscalYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalYear;
        partial void OnFiscalYearChanging(string value);
        partial void OnFiscalYearChanged();
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
        /// There are no comments for Property SubPeriod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubPeriod")]
        public virtual global::System.Nullable<int> SubPeriod
        {
            get
            {
                return this._SubPeriod;
            }
            set
            {
                this.OnSubPeriodChanging(value);
                this._SubPeriod = value;
                this.OnSubPeriodChanged();
                this.OnPropertyChanged("SubPeriod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SubPeriod;
        partial void OnSubPeriodChanging(global::System.Nullable<int> value);
        partial void OnSubPeriodChanged();
        /// <summary>
        /// There are no comments for Property DepreciationStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DepreciationStatus")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> DepreciationStatus
        {
            get
            {
                return this._DepreciationStatus;
            }
            set
            {
                this.OnDepreciationStatusChanging(value);
                this._DepreciationStatus = value;
                this.OnDepreciationStatusChanged();
                this.OnPropertyChanged("DepreciationStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _DepreciationStatus;
        partial void OnDepreciationStatusChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnDepreciationStatusChanged();
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
        /// There are no comments for Property ActualUnits in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActualUnits")]
        public virtual global::System.Nullable<int> ActualUnits
        {
            get
            {
                return this._ActualUnits;
            }
            set
            {
                this.OnActualUnitsChanging(value);
                this._ActualUnits = value;
                this.OnActualUnitsChanged();
                this.OnPropertyChanged("ActualUnits");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ActualUnits;
        partial void OnActualUnitsChanging(global::System.Nullable<int> value);
        partial void OnActualUnitsChanged();
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
