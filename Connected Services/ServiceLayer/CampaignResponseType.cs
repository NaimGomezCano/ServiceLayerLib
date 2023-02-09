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
    /// There are no comments for CampaignResponseTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CampaignResponseTypeSingle")]
    public partial class CampaignResponseTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CampaignResponseType>
    {
        /// <summary>
        /// Initialize a new CampaignResponseTypeSingle object.
        /// </summary>
        public CampaignResponseTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CampaignResponseTypeSingle object.
        /// </summary>
        public CampaignResponseTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CampaignResponseTypeSingle object.
        /// </summary>
        public CampaignResponseTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CampaignResponseType> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CampaignResponseType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ResponseType
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ResponseType")]
    [global::Microsoft.OData.Client.EntitySet("CampaignResponseType")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CampaignResponseType")]
    public partial class CampaignResponseType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CampaignResponseType object.
        /// </summary>
        /// <param name="responseType">Initial value of ResponseType.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CampaignResponseType CreateCampaignResponseType(string responseType)
        {
            CampaignResponseType campaignResponseType = new CampaignResponseType();
            campaignResponseType.ResponseType = responseType;
            return campaignResponseType;
        }
        /// <summary>
        /// There are no comments for Property ResponseTypeDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResponseTypeDescription")]
        public virtual string ResponseTypeDescription
        {
            get
            {
                return this._ResponseTypeDescription;
            }
            set
            {
                this.OnResponseTypeDescriptionChanging(value);
                this._ResponseTypeDescription = value;
                this.OnResponseTypeDescriptionChanged();
                this.OnPropertyChanged("ResponseTypeDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResponseTypeDescription;
        partial void OnResponseTypeDescriptionChanging(string value);
        partial void OnResponseTypeDescriptionChanged();
        /// <summary>
        /// There are no comments for Property ResponseType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResponseType")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ResponseType is required.")]
        public virtual string ResponseType
        {
            get
            {
                return this._ResponseType;
            }
            set
            {
                this.OnResponseTypeChanging(value);
                this._ResponseType = value;
                this.OnResponseTypeChanged();
                this.OnPropertyChanged("ResponseType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ResponseType;
        partial void OnResponseTypeChanging(string value);
        partial void OnResponseTypeChanged();
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
