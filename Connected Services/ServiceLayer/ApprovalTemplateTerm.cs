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
    /// There are no comments for ApprovalTemplateTerm in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalTemplateTerm")]
    public partial class ApprovalTemplateTerm : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property ConditionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConditionType")]
        public virtual global::System.Nullable<global::SAPB1.ApprovalTemplateConditionTypeEnum> ConditionType
        {
            get
            {
                return this._ConditionType;
            }
            set
            {
                this.OnConditionTypeChanging(value);
                this._ConditionType = value;
                this.OnConditionTypeChanged();
                this.OnPropertyChanged("ConditionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ApprovalTemplateConditionTypeEnum> _ConditionType;
        partial void OnConditionTypeChanging(global::System.Nullable<global::SAPB1.ApprovalTemplateConditionTypeEnum> value);
        partial void OnConditionTypeChanged();
        /// <summary>
        /// There are no comments for Property OperationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OperationType")]
        public virtual global::System.Nullable<global::SAPB1.ApprovalTemplateOperationTypeEnum> OperationType
        {
            get
            {
                return this._OperationType;
            }
            set
            {
                this.OnOperationTypeChanging(value);
                this._OperationType = value;
                this.OnOperationTypeChanged();
                this.OnPropertyChanged("OperationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ApprovalTemplateOperationTypeEnum> _OperationType;
        partial void OnOperationTypeChanging(global::System.Nullable<global::SAPB1.ApprovalTemplateOperationTypeEnum> value);
        partial void OnOperationTypeChanged();
        /// <summary>
        /// There are no comments for Property Value in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Value")]
        public virtual string Value
        {
            get
            {
                return this._Value;
            }
            set
            {
                this.OnValueChanging(value);
                this._Value = value;
                this.OnValueChanged();
                this.OnPropertyChanged("Value");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Value;
        partial void OnValueChanging(string value);
        partial void OnValueChanged();
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
