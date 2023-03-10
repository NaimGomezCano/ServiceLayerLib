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
    /// There are no comments for PartnersSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PartnersSetupSingle")]
    public partial class PartnersSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PartnersSetup>
    {
        /// <summary>
        /// Initialize a new PartnersSetupSingle object.
        /// </summary>
        public PartnersSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PartnersSetupSingle object.
        /// </summary>
        public PartnersSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PartnersSetupSingle object.
        /// </summary>
        public PartnersSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PartnersSetup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Relationship in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Relationship")]
        public virtual global::SAPB1.RelationshipSingle Relationship
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Relationship == null))
                {
                    this._Relationship = new global::SAPB1.RelationshipSingle(this.Context, GetPath("Relationship"));
                }
                return this._Relationship;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.RelationshipSingle _Relationship;
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
    /// There are no comments for PartnersSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PartnerID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartnerID")]
    [global::Microsoft.OData.Client.EntitySet("PartnersSetups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PartnersSetup")]
    public partial class PartnersSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PartnersSetup object.
        /// </summary>
        /// <param name="partnerID">Initial value of PartnerID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PartnersSetup CreatePartnersSetup(int partnerID)
        {
            PartnersSetup partnersSetup = new PartnersSetup();
            partnersSetup.PartnerID = partnerID;
            return partnersSetup;
        }
        /// <summary>
        /// There are no comments for Property PartnerID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PartnerID is required.")]
        public virtual int PartnerID
        {
            get
            {
                return this._PartnerID;
            }
            set
            {
                this.OnPartnerIDChanging(value);
                this._PartnerID = value;
                this.OnPartnerIDChanged();
                this.OnPropertyChanged("PartnerID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PartnerID;
        partial void OnPartnerIDChanging(int value);
        partial void OnPartnerIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property DefaultRelationship in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultRelationship")]
        public virtual global::System.Nullable<int> DefaultRelationship
        {
            get
            {
                return this._DefaultRelationship;
            }
            set
            {
                this.OnDefaultRelationshipChanging(value);
                this._DefaultRelationship = value;
                this.OnDefaultRelationshipChanged();
                this.OnPropertyChanged("DefaultRelationship");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DefaultRelationship;
        partial void OnDefaultRelationshipChanging(global::System.Nullable<int> value);
        partial void OnDefaultRelationshipChanged();
        /// <summary>
        /// There are no comments for Property RelatedBP in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RelatedBP")]
        public virtual string RelatedBP
        {
            get
            {
                return this._RelatedBP;
            }
            set
            {
                this.OnRelatedBPChanging(value);
                this._RelatedBP = value;
                this.OnRelatedBPChanged();
                this.OnPropertyChanged("RelatedBP");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RelatedBP;
        partial void OnRelatedBPChanging(string value);
        partial void OnRelatedBPChanged();
        /// <summary>
        /// There are no comments for Property Details in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Details")]
        public virtual string Details
        {
            get
            {
                return this._Details;
            }
            set
            {
                this.OnDetailsChanging(value);
                this._Details = value;
                this.OnDetailsChanged();
                this.OnPropertyChanged("Details");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Details;
        partial void OnDetailsChanging(string value);
        partial void OnDetailsChanged();
        /// <summary>
        /// There are no comments for Property Relationship in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Relationship")]
        public virtual global::SAPB1.Relationship Relationship
        {
            get
            {
                return this._Relationship;
            }
            set
            {
                this.OnRelationshipChanging(value);
                this._Relationship = value;
                this.OnRelationshipChanged();
                this.OnPropertyChanged("Relationship");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.Relationship _Relationship;
        partial void OnRelationshipChanging(global::SAPB1.Relationship value);
        partial void OnRelationshipChanged();
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
