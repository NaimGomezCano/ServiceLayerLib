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
    /// There are no comments for ItemCycleCount in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemCycleCount")]
    public partial class ItemCycleCount : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property CycleCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CycleCode")]
        public virtual global::System.Nullable<int> CycleCode
        {
            get
            {
                return this._CycleCode;
            }
            set
            {
                this.OnCycleCodeChanging(value);
                this._CycleCode = value;
                this.OnCycleCodeChanged();
                this.OnPropertyChanged("CycleCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _CycleCode;
        partial void OnCycleCodeChanging(global::System.Nullable<int> value);
        partial void OnCycleCodeChanged();
        /// <summary>
        /// There are no comments for Property Alert in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Alert")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Alert
        {
            get
            {
                return this._Alert;
            }
            set
            {
                this.OnAlertChanging(value);
                this._Alert = value;
                this.OnAlertChanged();
                this.OnPropertyChanged("Alert");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Alert;
        partial void OnAlertChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnAlertChanged();
        /// <summary>
        /// There are no comments for Property NextCountingDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NextCountingDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> NextCountingDate
        {
            get
            {
                return this._NextCountingDate;
            }
            set
            {
                this.OnNextCountingDateChanging(value);
                this._NextCountingDate = value;
                this.OnNextCountingDateChanged();
                this.OnPropertyChanged("NextCountingDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _NextCountingDate;
        partial void OnNextCountingDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnNextCountingDateChanged();
        /// <summary>
        /// There are no comments for Property AlertTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AlertTime")]
        public virtual global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> AlertTime
        {
            get
            {
                return this._AlertTime;
            }
            set
            {
                this.OnAlertTimeChanging(value);
                this._AlertTime = value;
                this.OnAlertTimeChanged();
                this.OnPropertyChanged("AlertTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> _AlertTime;
        partial void OnAlertTimeChanging(global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> value);
        partial void OnAlertTimeChanged();
        /// <summary>
        /// There are no comments for Property DestinationUser in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DestinationUser")]
        public virtual global::System.Nullable<int> DestinationUser
        {
            get
            {
                return this._DestinationUser;
            }
            set
            {
                this.OnDestinationUserChanging(value);
                this._DestinationUser = value;
                this.OnDestinationUserChanged();
                this.OnPropertyChanged("DestinationUser");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DestinationUser;
        partial void OnDestinationUserChanging(global::System.Nullable<int> value);
        partial void OnDestinationUserChanged();
        /// <summary>
        /// There are no comments for Property WarehouseCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseCode")]
        public virtual string WarehouseCode
        {
            get
            {
                return this._WarehouseCode;
            }
            set
            {
                this.OnWarehouseCodeChanging(value);
                this._WarehouseCode = value;
                this.OnWarehouseCodeChanged();
                this.OnPropertyChanged("WarehouseCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarehouseCode;
        partial void OnWarehouseCodeChanging(string value);
        partial void OnWarehouseCodeChanged();
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
