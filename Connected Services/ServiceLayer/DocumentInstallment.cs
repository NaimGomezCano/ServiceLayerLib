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
    /// There are no comments for DocumentInstallment in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentInstallment")]
    public partial class DocumentInstallment : global::System.ComponentModel.INotifyPropertyChanged
    {
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
        /// There are no comments for Property Percentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Percentage")]
        public virtual global::System.Nullable<double> Percentage
        {
            get
            {
                return this._Percentage;
            }
            set
            {
                this.OnPercentageChanging(value);
                this._Percentage = value;
                this.OnPercentageChanged();
                this.OnPropertyChanged("Percentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Percentage;
        partial void OnPercentageChanging(global::System.Nullable<double> value);
        partial void OnPercentageChanged();
        /// <summary>
        /// There are no comments for Property Total in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Total")]
        public virtual global::System.Nullable<double> Total
        {
            get
            {
                return this._Total;
            }
            set
            {
                this.OnTotalChanging(value);
                this._Total = value;
                this.OnTotalChanged();
                this.OnPropertyChanged("Total");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Total;
        partial void OnTotalChanging(global::System.Nullable<double> value);
        partial void OnTotalChanged();
        /// <summary>
        /// There are no comments for Property LastDunningDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LastDunningDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> LastDunningDate
        {
            get
            {
                return this._LastDunningDate;
            }
            set
            {
                this.OnLastDunningDateChanging(value);
                this._LastDunningDate = value;
                this.OnLastDunningDateChanged();
                this.OnPropertyChanged("LastDunningDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _LastDunningDate;
        partial void OnLastDunningDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnLastDunningDateChanged();
        /// <summary>
        /// There are no comments for Property DunningLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DunningLevel")]
        public virtual global::System.Nullable<int> DunningLevel
        {
            get
            {
                return this._DunningLevel;
            }
            set
            {
                this.OnDunningLevelChanging(value);
                this._DunningLevel = value;
                this.OnDunningLevelChanged();
                this.OnPropertyChanged("DunningLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DunningLevel;
        partial void OnDunningLevelChanging(global::System.Nullable<int> value);
        partial void OnDunningLevelChanged();
        /// <summary>
        /// There are no comments for Property TotalFC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TotalFC")]
        public virtual global::System.Nullable<double> TotalFC
        {
            get
            {
                return this._TotalFC;
            }
            set
            {
                this.OnTotalFCChanging(value);
                this._TotalFC = value;
                this.OnTotalFCChanged();
                this.OnPropertyChanged("TotalFC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _TotalFC;
        partial void OnTotalFCChanging(global::System.Nullable<double> value);
        partial void OnTotalFCChanged();
        /// <summary>
        /// There are no comments for Property InstallmentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InstallmentId")]
        public virtual global::System.Nullable<int> InstallmentId
        {
            get
            {
                return this._InstallmentId;
            }
            set
            {
                this.OnInstallmentIdChanging(value);
                this._InstallmentId = value;
                this.OnInstallmentIdChanged();
                this.OnPropertyChanged("InstallmentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _InstallmentId;
        partial void OnInstallmentIdChanging(global::System.Nullable<int> value);
        partial void OnInstallmentIdChanged();
        /// <summary>
        /// There are no comments for Property PaymentOrdered in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentOrdered")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> PaymentOrdered
        {
            get
            {
                return this._PaymentOrdered;
            }
            set
            {
                this.OnPaymentOrderedChanging(value);
                this._PaymentOrdered = value;
                this.OnPaymentOrderedChanged();
                this.OnPropertyChanged("PaymentOrdered");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _PaymentOrdered;
        partial void OnPaymentOrderedChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnPaymentOrderedChanged();
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
