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
    /// There are no comments for AssetDepreciationGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetDepreciationGroupSingle")]
    public partial class AssetDepreciationGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AssetDepreciationGroup>
    {
        /// <summary>
        /// Initialize a new AssetDepreciationGroupSingle object.
        /// </summary>
        public AssetDepreciationGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AssetDepreciationGroupSingle object.
        /// </summary>
        public AssetDepreciationGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AssetDepreciationGroupSingle object.
        /// </summary>
        public AssetDepreciationGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AssetDepreciationGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Items in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Items")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.Item> Items
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Items == null))
                {
                    this._Items = Context.CreateQuery<global::SAPB1.Item>(GetPath("Items"));
                }
                return this._Items;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.Item> _Items;
    }
    /// <summary>
    /// There are no comments for AssetDepreciationGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Code")]
    [global::Microsoft.OData.Client.EntitySet("AssetDepreciationGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetDepreciationGroup")]
    public partial class AssetDepreciationGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AssetDepreciationGroup object.
        /// </summary>
        /// <param name="code">Initial value of Code.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AssetDepreciationGroup CreateAssetDepreciationGroup(string code)
        {
            AssetDepreciationGroup assetDepreciationGroup = new AssetDepreciationGroup();
            assetDepreciationGroup.Code = code;
            return assetDepreciationGroup;
        }
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Code is required.")]
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
        /// There are no comments for Property Group in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Group")]
        public virtual string Group
        {
            get
            {
                return this._Group;
            }
            set
            {
                this.OnGroupChanging(value);
                this._Group = value;
                this.OnGroupChanged();
                this.OnPropertyChanged("Group");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Group;
        partial void OnGroupChanging(string value);
        partial void OnGroupChanged();
        /// <summary>
        /// There are no comments for Property Items in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Items")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Item> Items
        {
            get
            {
                return this._Items;
            }
            set
            {
                this.OnItemsChanging(value);
                this._Items = value;
                this.OnItemsChanged();
                this.OnPropertyChanged("Items");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Item> _Items = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Item>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnItemsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Item> value);
        partial void OnItemsChanged();
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
