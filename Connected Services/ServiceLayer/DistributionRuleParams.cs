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
    /// There are no comments for DistributionRuleParams in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DistributionRuleParams")]
    public partial class DistributionRuleParams : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property FactorCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FactorCode")]
        public virtual string FactorCode
        {
            get
            {
                return this._FactorCode;
            }
            set
            {
                this.OnFactorCodeChanging(value);
                this._FactorCode = value;
                this.OnFactorCodeChanged();
                this.OnPropertyChanged("FactorCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FactorCode;
        partial void OnFactorCodeChanging(string value);
        partial void OnFactorCodeChanged();
        /// <summary>
        /// There are no comments for Property FactorDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FactorDescription")]
        public virtual string FactorDescription
        {
            get
            {
                return this._FactorDescription;
            }
            set
            {
                this.OnFactorDescriptionChanging(value);
                this._FactorDescription = value;
                this.OnFactorDescriptionChanged();
                this.OnPropertyChanged("FactorDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FactorDescription;
        partial void OnFactorDescriptionChanging(string value);
        partial void OnFactorDescriptionChanged();
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
