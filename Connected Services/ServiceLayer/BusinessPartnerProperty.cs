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
    /// There are no comments for BusinessPartnerPropertySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPartnerPropertySingle")]
    public partial class BusinessPartnerPropertySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BusinessPartnerProperty>
    {
        /// <summary>
        /// Initialize a new BusinessPartnerPropertySingle object.
        /// </summary>
        public BusinessPartnerPropertySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BusinessPartnerPropertySingle object.
        /// </summary>
        public BusinessPartnerPropertySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BusinessPartnerPropertySingle object.
        /// </summary>
        public BusinessPartnerPropertySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BusinessPartnerProperty> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for BusinessPartnerProperty in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PropertyCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PropertyCode")]
    [global::Microsoft.OData.Client.EntitySet("BusinessPartnerProperties")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPartnerProperty")]
    public partial class BusinessPartnerProperty : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BusinessPartnerProperty object.
        /// </summary>
        /// <param name="propertyCode">Initial value of PropertyCode.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BusinessPartnerProperty CreateBusinessPartnerProperty(int propertyCode)
        {
            BusinessPartnerProperty businessPartnerProperty = new BusinessPartnerProperty();
            businessPartnerProperty.PropertyCode = propertyCode;
            return businessPartnerProperty;
        }
        /// <summary>
        /// There are no comments for Property PropertyCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PropertyCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PropertyCode is required.")]
        public virtual int PropertyCode
        {
            get
            {
                return this._PropertyCode;
            }
            set
            {
                this.OnPropertyCodeChanging(value);
                this._PropertyCode = value;
                this.OnPropertyCodeChanged();
                this.OnPropertyChanged("PropertyCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PropertyCode;
        partial void OnPropertyCodeChanging(int value);
        partial void OnPropertyCodeChanged();
        /// <summary>
        /// There are no comments for Property PropertyName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PropertyName")]
        public virtual string PropertyName
        {
            get
            {
                return this._PropertyName;
            }
            set
            {
                this.OnPropertyNameChanging(value);
                this._PropertyName = value;
                this.OnPropertyNameChanged();
                this.OnPropertyChanged("PropertyName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PropertyName;
        partial void OnPropertyNameChanging(string value);
        partial void OnPropertyNameChanged();
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
