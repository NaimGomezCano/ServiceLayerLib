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
    /// There are no comments for CashFlowLineItemSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CashFlowLineItemSingle")]
    public partial class CashFlowLineItemSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CashFlowLineItem>
    {
        /// <summary>
        /// Initialize a new CashFlowLineItemSingle object.
        /// </summary>
        public CashFlowLineItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CashFlowLineItemSingle object.
        /// </summary>
        public CashFlowLineItemSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CashFlowLineItemSingle object.
        /// </summary>
        public CashFlowLineItemSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CashFlowLineItem> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CashFlowLineItem in the schema.
    /// </summary>
    /// <KeyProperties>
    /// LineItemID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("LineItemID")]
    [global::Microsoft.OData.Client.EntitySet("CashFlowLineItems")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CashFlowLineItem")]
    public partial class CashFlowLineItem : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CashFlowLineItem object.
        /// </summary>
        /// <param name="lineItemID">Initial value of LineItemID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CashFlowLineItem CreateCashFlowLineItem(int lineItemID)
        {
            CashFlowLineItem cashFlowLineItem = new CashFlowLineItem();
            cashFlowLineItem.LineItemID = lineItemID;
            return cashFlowLineItem;
        }
        /// <summary>
        /// There are no comments for Property LineItemID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineItemID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "LineItemID is required.")]
        public virtual int LineItemID
        {
            get
            {
                return this._LineItemID;
            }
            set
            {
                this.OnLineItemIDChanging(value);
                this._LineItemID = value;
                this.OnLineItemIDChanged();
                this.OnPropertyChanged("LineItemID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _LineItemID;
        partial void OnLineItemIDChanging(int value);
        partial void OnLineItemIDChanged();
        /// <summary>
        /// There are no comments for Property LineItemName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineItemName")]
        public virtual string LineItemName
        {
            get
            {
                return this._LineItemName;
            }
            set
            {
                this.OnLineItemNameChanging(value);
                this._LineItemName = value;
                this.OnLineItemNameChanged();
                this.OnPropertyChanged("LineItemName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LineItemName;
        partial void OnLineItemNameChanging(string value);
        partial void OnLineItemNameChanged();
        /// <summary>
        /// There are no comments for Property ActiveLineItem in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveLineItem")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> ActiveLineItem
        {
            get
            {
                return this._ActiveLineItem;
            }
            set
            {
                this.OnActiveLineItemChanging(value);
                this._ActiveLineItem = value;
                this.OnActiveLineItemChanged();
                this.OnPropertyChanged("ActiveLineItem");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _ActiveLineItem;
        partial void OnActiveLineItemChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnActiveLineItemChanged();
        /// <summary>
        /// There are no comments for Property ParentArticle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentArticle")]
        public virtual global::System.Nullable<int> ParentArticle
        {
            get
            {
                return this._ParentArticle;
            }
            set
            {
                this.OnParentArticleChanging(value);
                this._ParentArticle = value;
                this.OnParentArticleChanged();
                this.OnPropertyChanged("ParentArticle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ParentArticle;
        partial void OnParentArticleChanging(global::System.Nullable<int> value);
        partial void OnParentArticleChanged();
        /// <summary>
        /// There are no comments for Property Level in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Level")]
        public virtual global::System.Nullable<int> Level
        {
            get
            {
                return this._Level;
            }
            set
            {
                this.OnLevelChanging(value);
                this._Level = value;
                this.OnLevelChanged();
                this.OnPropertyChanged("Level");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Level;
        partial void OnLevelChanging(global::System.Nullable<int> value);
        partial void OnLevelChanged();
        /// <summary>
        /// There are no comments for Property Drawer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Drawer")]
        public virtual global::System.Nullable<int> Drawer
        {
            get
            {
                return this._Drawer;
            }
            set
            {
                this.OnDrawerChanging(value);
                this._Drawer = value;
                this.OnDrawerChanged();
                this.OnPropertyChanged("Drawer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Drawer;
        partial void OnDrawerChanging(global::System.Nullable<int> value);
        partial void OnDrawerChanged();
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
