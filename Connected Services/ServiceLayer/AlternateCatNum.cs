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
    /// There are no comments for AlternateCatNumSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AlternateCatNumSingle")]
    public partial class AlternateCatNumSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AlternateCatNum>
    {
        /// <summary>
        /// Initialize a new AlternateCatNumSingle object.
        /// </summary>
        public AlternateCatNumSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AlternateCatNumSingle object.
        /// </summary>
        public AlternateCatNumSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AlternateCatNumSingle object.
        /// </summary>
        public AlternateCatNumSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AlternateCatNum> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Item in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Item")]
        public virtual global::SAPB1.ItemSingle Item
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Item == null))
                {
                    this._Item = new global::SAPB1.ItemSingle(this.Context, GetPath("Item"));
                }
                return this._Item;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.ItemSingle _Item;
        /// <summary>
        /// There are no comments for BusinessPartner in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPartner")]
        public virtual global::SAPB1.BusinessPartnerSingle BusinessPartner
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BusinessPartner == null))
                {
                    this._BusinessPartner = new global::SAPB1.BusinessPartnerSingle(this.Context, GetPath("BusinessPartner"));
                }
                return this._BusinessPartner;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BusinessPartnerSingle _BusinessPartner;
    }
    /// <summary>
    /// There are no comments for AlternateCatNum in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ItemCode
    /// CardCode
    /// Substitute
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ItemCode", "CardCode", "Substitute")]
    [global::Microsoft.OData.Client.EntitySet("AlternateCatNum")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AlternateCatNum")]
    public partial class AlternateCatNum : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AlternateCatNum object.
        /// </summary>
        /// <param name="itemCode">Initial value of ItemCode.</param>
        /// <param name="cardCode">Initial value of CardCode.</param>
        /// <param name="substitute">Initial value of Substitute.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AlternateCatNum CreateAlternateCatNum(string itemCode, string cardCode, string substitute)
        {
            AlternateCatNum alternateCatNum = new AlternateCatNum();
            alternateCatNum.ItemCode = itemCode;
            alternateCatNum.CardCode = cardCode;
            alternateCatNum.Substitute = substitute;
            return alternateCatNum;
        }
        /// <summary>
        /// There are no comments for Property ItemCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemCode is required.")]
        public virtual string ItemCode
        {
            get
            {
                return this._ItemCode;
            }
            set
            {
                this.OnItemCodeChanging(value);
                this._ItemCode = value;
                this.OnItemCodeChanged();
                this.OnPropertyChanged("ItemCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemCode;
        partial void OnItemCodeChanging(string value);
        partial void OnItemCodeChanged();
        /// <summary>
        /// There are no comments for Property CardCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CardCode")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "CardCode is required.")]
        public virtual string CardCode
        {
            get
            {
                return this._CardCode;
            }
            set
            {
                this.OnCardCodeChanging(value);
                this._CardCode = value;
                this.OnCardCodeChanged();
                this.OnPropertyChanged("CardCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CardCode;
        partial void OnCardCodeChanging(string value);
        partial void OnCardCodeChanged();
        /// <summary>
        /// There are no comments for Property Substitute in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Substitute")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Substitute is required.")]
        public virtual string Substitute
        {
            get
            {
                return this._Substitute;
            }
            set
            {
                this.OnSubstituteChanging(value);
                this._Substitute = value;
                this.OnSubstituteChanged();
                this.OnPropertyChanged("Substitute");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Substitute;
        partial void OnSubstituteChanging(string value);
        partial void OnSubstituteChanged();
        /// <summary>
        /// There are no comments for Property DisplayBPCatalogNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DisplayBPCatalogNumber")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> DisplayBPCatalogNumber
        {
            get
            {
                return this._DisplayBPCatalogNumber;
            }
            set
            {
                this.OnDisplayBPCatalogNumberChanging(value);
                this._DisplayBPCatalogNumber = value;
                this.OnDisplayBPCatalogNumberChanged();
                this.OnPropertyChanged("DisplayBPCatalogNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _DisplayBPCatalogNumber;
        partial void OnDisplayBPCatalogNumberChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnDisplayBPCatalogNumberChanged();
        /// <summary>
        /// There are no comments for Property IsDefault in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDefault")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IsDefault
        {
            get
            {
                return this._IsDefault;
            }
            set
            {
                this.OnIsDefaultChanging(value);
                this._IsDefault = value;
                this.OnIsDefaultChanged();
                this.OnPropertyChanged("IsDefault");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IsDefault;
        partial void OnIsDefaultChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIsDefaultChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Item in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Item")]
        public virtual global::SAPB1.Item Item
        {
            get
            {
                return this._Item;
            }
            set
            {
                this.OnItemChanging(value);
                this._Item = value;
                this.OnItemChanged();
                this.OnPropertyChanged("Item");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.Item _Item;
        partial void OnItemChanging(global::SAPB1.Item value);
        partial void OnItemChanged();
        /// <summary>
        /// There are no comments for Property BusinessPartner in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPartner")]
        public virtual global::SAPB1.BusinessPartner BusinessPartner
        {
            get
            {
                return this._BusinessPartner;
            }
            set
            {
                this.OnBusinessPartnerChanging(value);
                this._BusinessPartner = value;
                this.OnBusinessPartnerChanged();
                this.OnPropertyChanged("BusinessPartner");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BusinessPartner _BusinessPartner;
        partial void OnBusinessPartnerChanging(global::SAPB1.BusinessPartner value);
        partial void OnBusinessPartnerChanged();
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
