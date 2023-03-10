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
    /// There are no comments for ItemImageSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemImageSingle")]
    public partial class ItemImageSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ItemImage>
    {
        /// <summary>
        /// Initialize a new ItemImageSingle object.
        /// </summary>
        public ItemImageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ItemImageSingle object.
        /// </summary>
        public ItemImageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ItemImageSingle object.
        /// </summary>
        public ItemImageSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ItemImage> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ItemImage in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ItemCode
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ItemCode")]
    [global::Microsoft.OData.Client.EntitySet("ItemImages")]
    [global::Microsoft.OData.Client.HasStream()]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemImage")]
    public partial class ItemImage : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ItemImage object.
        /// </summary>
        /// <param name="itemCode">Initial value of ItemCode.</param>
        /// <param name="picture">Initial value of Picture.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ItemImage CreateItemImage(string itemCode, string picture)
        {
            ItemImage itemImage = new ItemImage();
            itemImage.ItemCode = itemCode;
            itemImage.Picture = picture;
            return itemImage;
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
        /// There are no comments for Property Picture in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Picture")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Picture is required.")]
        public virtual string Picture
        {
            get
            {
                return this._Picture;
            }
            set
            {
                this.OnPictureChanging(value);
                this._Picture = value;
                this.OnPictureChanged();
                this.OnPropertyChanged("Picture");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Picture;
        partial void OnPictureChanging(string value);
        partial void OnPictureChanged();
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
