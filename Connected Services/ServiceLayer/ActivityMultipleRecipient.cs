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
    /// There are no comments for ActivityMultipleRecipient in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ActivityMultipleRecipient")]
    public partial class ActivityMultipleRecipient : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property LineNumer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumer")]
        public virtual global::System.Nullable<int> LineNumer
        {
            get
            {
                return this._LineNumer;
            }
            set
            {
                this.OnLineNumerChanging(value);
                this._LineNumer = value;
                this.OnLineNumerChanged();
                this.OnPropertyChanged("LineNumer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _LineNumer;
        partial void OnLineNumerChanging(global::System.Nullable<int> value);
        partial void OnLineNumerChanged();
        /// <summary>
        /// There are no comments for Property RecipientType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecipientType")]
        public virtual global::System.Nullable<global::SAPB1.ActivityRecipientObjTypeEnum> RecipientType
        {
            get
            {
                return this._RecipientType;
            }
            set
            {
                this.OnRecipientTypeChanging(value);
                this._RecipientType = value;
                this.OnRecipientTypeChanged();
                this.OnPropertyChanged("RecipientType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ActivityRecipientObjTypeEnum> _RecipientType;
        partial void OnRecipientTypeChanging(global::System.Nullable<global::SAPB1.ActivityRecipientObjTypeEnum> value);
        partial void OnRecipientTypeChanged();
        /// <summary>
        /// There are no comments for Property RecipientCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecipientCode")]
        public virtual string RecipientCode
        {
            get
            {
                return this._RecipientCode;
            }
            set
            {
                this.OnRecipientCodeChanging(value);
                this._RecipientCode = value;
                this.OnRecipientCodeChanged();
                this.OnPropertyChanged("RecipientCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RecipientCode;
        partial void OnRecipientCodeChanging(string value);
        partial void OnRecipientCodeChanged();
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
