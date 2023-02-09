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
    /// There are no comments for AttributeGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AttributeGroupSingle")]
    public partial class AttributeGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<AttributeGroup>
    {
        /// <summary>
        /// Initialize a new AttributeGroupSingle object.
        /// </summary>
        public AttributeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AttributeGroupSingle object.
        /// </summary>
        public AttributeGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AttributeGroupSingle object.
        /// </summary>
        public AttributeGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<AttributeGroup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for AssetClasses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetClasses")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.AssetClass> AssetClasses
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._AssetClasses == null))
                {
                    this._AssetClasses = Context.CreateQuery<global::SAPB1.AssetClass>(GetPath("AssetClasses"));
                }
                return this._AssetClasses;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.AssetClass> _AssetClasses;
    }
    /// <summary>
    /// There are no comments for AttributeGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Code")]
    [global::Microsoft.OData.Client.EntitySet("AttributeGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("AttributeGroup")]
    public partial class AttributeGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new AttributeGroup object.
        /// </summary>
        /// <param name="code">Initial value of Code.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static AttributeGroup CreateAttributeGroup(int code)
        {
            AttributeGroup attributeGroup = new AttributeGroup();
            attributeGroup.Code = code;
            return attributeGroup;
        }
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Code is required.")]
        public virtual int Code
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
        private int _Code;
        partial void OnCodeChanging(int value);
        partial void OnCodeChanged();
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
        /// There are no comments for Property Locked in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Locked")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Locked
        {
            get
            {
                return this._Locked;
            }
            set
            {
                this.OnLockedChanging(value);
                this._Locked = value;
                this.OnLockedChanged();
                this.OnPropertyChanged("Locked");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Locked;
        partial void OnLockedChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnLockedChanged();
        /// <summary>
        /// There are no comments for Property AttributeGroupCollection in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AttributeGroupCollection")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.AttributeGroupLine> AttributeGroupCollection
        {
            get
            {
                return this._AttributeGroupCollection;
            }
            set
            {
                this.OnAttributeGroupCollectionChanging(value);
                this._AttributeGroupCollection = value;
                this.OnAttributeGroupCollectionChanged();
                this.OnPropertyChanged("AttributeGroupCollection");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.AttributeGroupLine> _AttributeGroupCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.AttributeGroupLine>();
        partial void OnAttributeGroupCollectionChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.AttributeGroupLine> value);
        partial void OnAttributeGroupCollectionChanged();
        /// <summary>
        /// There are no comments for Property AssetClasses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssetClasses")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.AssetClass> AssetClasses
        {
            get
            {
                return this._AssetClasses;
            }
            set
            {
                this.OnAssetClassesChanging(value);
                this._AssetClasses = value;
                this.OnAssetClassesChanged();
                this.OnPropertyChanged("AssetClasses");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.AssetClass> _AssetClasses = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.AssetClass>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnAssetClassesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.AssetClass> value);
        partial void OnAssetClassesChanged();
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