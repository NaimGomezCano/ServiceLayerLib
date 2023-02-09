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
    /// There are no comments for DeductionTaxSubGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionTaxSubGroupSingle")]
    public partial class DeductionTaxSubGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<DeductionTaxSubGroup>
    {
        /// <summary>
        /// Initialize a new DeductionTaxSubGroupSingle object.
        /// </summary>
        public DeductionTaxSubGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new DeductionTaxSubGroupSingle object.
        /// </summary>
        public DeductionTaxSubGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new DeductionTaxSubGroupSingle object.
        /// </summary>
        public DeductionTaxSubGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<DeductionTaxSubGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for DeductionTaxGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionTaxGroups")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.DeductionTaxGroup> DeductionTaxGroups
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._DeductionTaxGroups == null))
                {
                    this._DeductionTaxGroups = Context.CreateQuery<global::SAPB1.DeductionTaxGroup>(GetPath("DeductionTaxGroups"));
                }
                return this._DeductionTaxGroups;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.DeductionTaxGroup> _DeductionTaxGroups;
    }
    /// <summary>
    /// There are no comments for DeductionTaxSubGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// GroupCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("GroupCode")]
    [global::Microsoft.OData.Client.EntitySet("DeductionTaxSubGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionTaxSubGroup")]
    public partial class DeductionTaxSubGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new DeductionTaxSubGroup object.
        /// </summary>
        /// <param name="groupCode">Initial value of GroupCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static DeductionTaxSubGroup CreateDeductionTaxSubGroup(string groupCode)
        {
            DeductionTaxSubGroup deductionTaxSubGroup = new DeductionTaxSubGroup();
            deductionTaxSubGroup.GroupCode = groupCode;
            return deductionTaxSubGroup;
        }
        /// <summary>
        /// There are no comments for Property GroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GroupCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "GroupCode is required.")]
        public virtual string GroupCode
        {
            get
            {
                return this._GroupCode;
            }
            set
            {
                this.OnGroupCodeChanging(value);
                this._GroupCode = value;
                this.OnGroupCodeChanged();
                this.OnPropertyChanged("GroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupCode;
        partial void OnGroupCodeChanging(string value);
        partial void OnGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property GroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GroupName")]
        public virtual string GroupName
        {
            get
            {
                return this._GroupName;
            }
            set
            {
                this.OnGroupNameChanging(value);
                this._GroupName = value;
                this.OnGroupNameChanged();
                this.OnPropertyChanged("GroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _GroupName;
        partial void OnGroupNameChanging(string value);
        partial void OnGroupNameChanged();
        /// <summary>
        /// There are no comments for Property DeductionTaxGroups in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DeductionTaxGroups")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.DeductionTaxGroup> DeductionTaxGroups
        {
            get
            {
                return this._DeductionTaxGroups;
            }
            set
            {
                this.OnDeductionTaxGroupsChanging(value);
                this._DeductionTaxGroups = value;
                this.OnDeductionTaxGroupsChanged();
                this.OnPropertyChanged("DeductionTaxGroups");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.DeductionTaxGroup> _DeductionTaxGroups = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.DeductionTaxGroup>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnDeductionTaxGroupsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.DeductionTaxGroup> value);
        partial void OnDeductionTaxGroupsChanged();
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