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
    /// There are no comments for BrazilBeverageIndexerSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilBeverageIndexerSingle")]
    public partial class BrazilBeverageIndexerSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BrazilBeverageIndexer>
    {
        /// <summary>
        /// Initialize a new BrazilBeverageIndexerSingle object.
        /// </summary>
        public BrazilBeverageIndexerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BrazilBeverageIndexerSingle object.
        /// </summary>
        public BrazilBeverageIndexerSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BrazilBeverageIndexerSingle object.
        /// </summary>
        public BrazilBeverageIndexerSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BrazilBeverageIndexer> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BrazilStringIndexer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilStringIndexer")]
        public virtual global::SAPB1.BrazilStringIndexerSingle BrazilStringIndexer
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BrazilStringIndexer == null))
                {
                    this._BrazilStringIndexer = new global::SAPB1.BrazilStringIndexerSingle(this.Context, GetPath("BrazilStringIndexer"));
                }
                return this._BrazilStringIndexer;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BrazilStringIndexerSingle _BrazilStringIndexer;
        /// <summary>
        /// There are no comments for BrazilNumericIndexer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilNumericIndexer")]
        public virtual global::SAPB1.BrazilNumericIndexerSingle BrazilNumericIndexer
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BrazilNumericIndexer == null))
                {
                    this._BrazilNumericIndexer = new global::SAPB1.BrazilNumericIndexerSingle(this.Context, GetPath("BrazilNumericIndexer"));
                }
                return this._BrazilNumericIndexer;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BrazilNumericIndexerSingle _BrazilNumericIndexer;
    }
    /// <summary>
    /// There are no comments for BrazilBeverageIndexer in the schema.
    /// </summary>
    /// <KeyProperties>
    /// BeverageID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("BeverageID")]
    [global::Microsoft.OData.Client.EntitySet("BrazilBeverageIndexers")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilBeverageIndexer")]
    public partial class BrazilBeverageIndexer : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BrazilBeverageIndexer object.
        /// </summary>
        /// <param name="beverageID">Initial value of BeverageID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BrazilBeverageIndexer CreateBrazilBeverageIndexer(int beverageID)
        {
            BrazilBeverageIndexer brazilBeverageIndexer = new BrazilBeverageIndexer();
            brazilBeverageIndexer.BeverageID = beverageID;
            return brazilBeverageIndexer;
        }
        /// <summary>
        /// There are no comments for Property BeverageGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BeverageGroupCode")]
        public virtual string BeverageGroupCode
        {
            get
            {
                return this._BeverageGroupCode;
            }
            set
            {
                this.OnBeverageGroupCodeChanging(value);
                this._BeverageGroupCode = value;
                this.OnBeverageGroupCodeChanged();
                this.OnPropertyChanged("BeverageGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BeverageGroupCode;
        partial void OnBeverageGroupCodeChanging(string value);
        partial void OnBeverageGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property BeverageTableCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BeverageTableCode")]
        public virtual string BeverageTableCode
        {
            get
            {
                return this._BeverageTableCode;
            }
            set
            {
                this.OnBeverageTableCodeChanging(value);
                this._BeverageTableCode = value;
                this.OnBeverageTableCodeChanged();
                this.OnPropertyChanged("BeverageTableCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BeverageTableCode;
        partial void OnBeverageTableCodeChanging(string value);
        partial void OnBeverageTableCodeChanged();
        /// <summary>
        /// There are no comments for Property BeverageCommercialBrandCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BeverageCommercialBrandCode")]
        public virtual global::System.Nullable<int> BeverageCommercialBrandCode
        {
            get
            {
                return this._BeverageCommercialBrandCode;
            }
            set
            {
                this.OnBeverageCommercialBrandCodeChanging(value);
                this._BeverageCommercialBrandCode = value;
                this.OnBeverageCommercialBrandCodeChanged();
                this.OnPropertyChanged("BeverageCommercialBrandCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BeverageCommercialBrandCode;
        partial void OnBeverageCommercialBrandCodeChanging(global::System.Nullable<int> value);
        partial void OnBeverageCommercialBrandCodeChanged();
        /// <summary>
        /// There are no comments for Property BeverageID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BeverageID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "BeverageID is required.")]
        public virtual int BeverageID
        {
            get
            {
                return this._BeverageID;
            }
            set
            {
                this.OnBeverageIDChanging(value);
                this._BeverageID = value;
                this.OnBeverageIDChanged();
                this.OnPropertyChanged("BeverageID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _BeverageID;
        partial void OnBeverageIDChanging(int value);
        partial void OnBeverageIDChanged();
        /// <summary>
        /// There are no comments for Property BrazilStringIndexer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilStringIndexer")]
        public virtual global::SAPB1.BrazilStringIndexer BrazilStringIndexer
        {
            get
            {
                return this._BrazilStringIndexer;
            }
            set
            {
                this.OnBrazilStringIndexerChanging(value);
                this._BrazilStringIndexer = value;
                this.OnBrazilStringIndexerChanged();
                this.OnPropertyChanged("BrazilStringIndexer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BrazilStringIndexer _BrazilStringIndexer;
        partial void OnBrazilStringIndexerChanging(global::SAPB1.BrazilStringIndexer value);
        partial void OnBrazilStringIndexerChanged();
        /// <summary>
        /// There are no comments for Property BrazilNumericIndexer in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BrazilNumericIndexer")]
        public virtual global::SAPB1.BrazilNumericIndexer BrazilNumericIndexer
        {
            get
            {
                return this._BrazilNumericIndexer;
            }
            set
            {
                this.OnBrazilNumericIndexerChanging(value);
                this._BrazilNumericIndexer = value;
                this.OnBrazilNumericIndexerChanged();
                this.OnPropertyChanged("BrazilNumericIndexer");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BrazilNumericIndexer _BrazilNumericIndexer;
        partial void OnBrazilNumericIndexerChanging(global::SAPB1.BrazilNumericIndexer value);
        partial void OnBrazilNumericIndexerChanged();
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