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
    /// There are no comments for PMC_ActivityData in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PMC_ActivityData")]
    public partial class PMC_ActivityData : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property ActivityID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivityID")]
        public virtual global::System.Nullable<int> ActivityID
        {
            get
            {
                return this._ActivityID;
            }
            set
            {
                this.OnActivityIDChanging(value);
                this._ActivityID = value;
                this.OnActivityIDChanged();
                this.OnPropertyChanged("ActivityID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ActivityID;
        partial void OnActivityIDChanging(global::System.Nullable<int> value);
        partial void OnActivityIDChanged();
        /// <summary>
        /// There are no comments for Property ActivityType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivityType")]
        public virtual string ActivityType
        {
            get
            {
                return this._ActivityType;
            }
            set
            {
                this.OnActivityTypeChanging(value);
                this._ActivityType = value;
                this.OnActivityTypeChanged();
                this.OnPropertyChanged("ActivityType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ActivityType;
        partial void OnActivityTypeChanging(string value);
        partial void OnActivityTypeChanged();
        /// <summary>
        /// There are no comments for Property LaborItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LaborItem")]
        public virtual string LaborItem
        {
            get
            {
                return this._LaborItem;
            }
            set
            {
                this.OnLaborItemChanging(value);
                this._LaborItem = value;
                this.OnLaborItemChanged();
                this.OnPropertyChanged("LaborItem");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LaborItem;
        partial void OnLaborItemChanging(string value);
        partial void OnLaborItemChanged();
        /// <summary>
        /// There are no comments for Property IsChargeable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsChargeable")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IsChargeable
        {
            get
            {
                return this._IsChargeable;
            }
            set
            {
                this.OnIsChargeableChanging(value);
                this._IsChargeable = value;
                this.OnIsChargeableChanged();
                this.OnPropertyChanged("IsChargeable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IsChargeable;
        partial void OnIsChargeableChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIsChargeableChanged();
        /// <summary>
        /// There are no comments for Property IsAbsence in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsAbsence")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IsAbsence
        {
            get
            {
                return this._IsAbsence;
            }
            set
            {
                this.OnIsAbsenceChanging(value);
                this._IsAbsence = value;
                this.OnIsAbsenceChanged();
                this.OnPropertyChanged("IsAbsence");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IsAbsence;
        partial void OnIsAbsenceChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIsAbsenceChanged();
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
