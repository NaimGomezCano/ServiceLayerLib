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
    /// There are no comments for PartnersSetupParams in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PartnersSetupParams")]
    public partial class PartnersSetupParams : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property PartnerID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PartnerID")]
        public virtual global::System.Nullable<int> PartnerID
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
        private global::System.Nullable<int> _PartnerID;
        partial void OnPartnerIDChanging(global::System.Nullable<int> value);
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
