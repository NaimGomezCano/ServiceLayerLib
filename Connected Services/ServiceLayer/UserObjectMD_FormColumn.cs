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
    /// There are no comments for UserObjectMD_FormColumn in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("UserObjectMD_FormColumn")]
    public partial class UserObjectMD_FormColumn : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property FormColumnAlias in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FormColumnAlias")]
        public virtual string FormColumnAlias
        {
            get
            {
                return this._FormColumnAlias;
            }
            set
            {
                this.OnFormColumnAliasChanging(value);
                this._FormColumnAlias = value;
                this.OnFormColumnAliasChanged();
                this.OnPropertyChanged("FormColumnAlias");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FormColumnAlias;
        partial void OnFormColumnAliasChanging(string value);
        partial void OnFormColumnAliasChanged();
        /// <summary>
        /// There are no comments for Property FormColumnDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FormColumnDescription")]
        public virtual string FormColumnDescription
        {
            get
            {
                return this._FormColumnDescription;
            }
            set
            {
                this.OnFormColumnDescriptionChanging(value);
                this._FormColumnDescription = value;
                this.OnFormColumnDescriptionChanged();
                this.OnPropertyChanged("FormColumnDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FormColumnDescription;
        partial void OnFormColumnDescriptionChanging(string value);
        partial void OnFormColumnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property FormColumnNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FormColumnNumber")]
        public virtual global::System.Nullable<int> FormColumnNumber
        {
            get
            {
                return this._FormColumnNumber;
            }
            set
            {
                this.OnFormColumnNumberChanging(value);
                this._FormColumnNumber = value;
                this.OnFormColumnNumberChanged();
                this.OnPropertyChanged("FormColumnNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _FormColumnNumber;
        partial void OnFormColumnNumberChanging(global::System.Nullable<int> value);
        partial void OnFormColumnNumberChanged();
        /// <summary>
        /// There are no comments for Property SonNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SonNumber")]
        public virtual global::System.Nullable<int> SonNumber
        {
            get
            {
                return this._SonNumber;
            }
            set
            {
                this.OnSonNumberChanging(value);
                this._SonNumber = value;
                this.OnSonNumberChanged();
                this.OnPropertyChanged("SonNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SonNumber;
        partial void OnSonNumberChanging(global::System.Nullable<int> value);
        partial void OnSonNumberChanged();
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
        /// There are no comments for Property Editable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Editable")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Editable
        {
            get
            {
                return this._Editable;
            }
            set
            {
                this.OnEditableChanging(value);
                this._Editable = value;
                this.OnEditableChanged();
                this.OnPropertyChanged("Editable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Editable;
        partial void OnEditableChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnEditableChanged();
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
