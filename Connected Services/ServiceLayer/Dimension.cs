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
    /// There are no comments for DimensionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionSingle")]
    public partial class DimensionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Dimension>
    {
        /// <summary>
        /// Initialize a new DimensionSingle object.
        /// </summary>
        public DimensionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DimensionSingle object.
        /// </summary>
        public DimensionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DimensionSingle object.
        /// </summary>
        public DimensionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Dimension> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ProfitCenters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ProfitCenters")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.ProfitCenter> ProfitCenters
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ProfitCenters == null))
                {
                    this._ProfitCenters = Context.CreateQuery<global::SAPB1.ProfitCenter>(GetPath("ProfitCenters"));
                }
                return this._ProfitCenters;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.ProfitCenter> _ProfitCenters;
        /// <summary>
        /// There are no comments for DistributionRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DistributionRules")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.DistributionRule> DistributionRules
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DistributionRules == null))
                {
                    this._DistributionRules = Context.CreateQuery<global::SAPB1.DistributionRule>(GetPath("DistributionRules"));
                }
                return this._DistributionRules;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.DistributionRule> _DistributionRules;
    }
    /// <summary>
    /// There are no comments for Dimension in the schema.
    /// </summary>
    /// <KeyProperties>
    /// DimensionCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("DimensionCode")]
    [global::Microsoft.OData.Client.EntitySet("Dimensions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Dimension")]
    public partial class Dimension : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Dimension object.
        /// </summary>
        /// <param name="dimensionCode">Initial value of DimensionCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Dimension CreateDimension(int dimensionCode)
        {
            Dimension dimension = new Dimension();
            dimension.DimensionCode = dimensionCode;
            return dimension;
        }
        /// <summary>
        /// There are no comments for Property DimensionCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "DimensionCode is required.")]
        public virtual int DimensionCode
        {
            get
            {
                return this._DimensionCode;
            }
            set
            {
                this.OnDimensionCodeChanging(value);
                this._DimensionCode = value;
                this.OnDimensionCodeChanged();
                this.OnPropertyChanged("DimensionCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _DimensionCode;
        partial void OnDimensionCodeChanging(int value);
        partial void OnDimensionCodeChanged();
        /// <summary>
        /// There are no comments for Property DimensionName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionName")]
        public virtual string DimensionName
        {
            get
            {
                return this._DimensionName;
            }
            set
            {
                this.OnDimensionNameChanging(value);
                this._DimensionName = value;
                this.OnDimensionNameChanged();
                this.OnPropertyChanged("DimensionName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionName;
        partial void OnDimensionNameChanging(string value);
        partial void OnDimensionNameChanged();
        /// <summary>
        /// There are no comments for Property IsActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsActive")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                this.OnIsActiveChanging(value);
                this._IsActive = value;
                this.OnIsActiveChanged();
                this.OnPropertyChanged("IsActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IsActive;
        partial void OnIsActiveChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIsActiveChanged();
        /// <summary>
        /// There are no comments for Property DimensionDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DimensionDescription")]
        public virtual string DimensionDescription
        {
            get
            {
                return this._DimensionDescription;
            }
            set
            {
                this.OnDimensionDescriptionChanging(value);
                this._DimensionDescription = value;
                this.OnDimensionDescriptionChanged();
                this.OnPropertyChanged("DimensionDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DimensionDescription;
        partial void OnDimensionDescriptionChanging(string value);
        partial void OnDimensionDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ProfitCenters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProfitCenters")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ProfitCenter> ProfitCenters
        {
            get
            {
                return this._ProfitCenters;
            }
            set
            {
                this.OnProfitCentersChanging(value);
                this._ProfitCenters = value;
                this.OnProfitCentersChanged();
                this.OnPropertyChanged("ProfitCenters");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ProfitCenter> _ProfitCenters = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ProfitCenter>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnProfitCentersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ProfitCenter> value);
        partial void OnProfitCentersChanged();
        /// <summary>
        /// There are no comments for Property DistributionRules in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DistributionRules")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.DistributionRule> DistributionRules
        {
            get
            {
                return this._DistributionRules;
            }
            set
            {
                this.OnDistributionRulesChanging(value);
                this._DistributionRules = value;
                this.OnDistributionRulesChanged();
                this.OnPropertyChanged("DistributionRules");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.DistributionRule> _DistributionRules = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.DistributionRule>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDistributionRulesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.DistributionRule> value);
        partial void OnDistributionRulesChanged();
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
