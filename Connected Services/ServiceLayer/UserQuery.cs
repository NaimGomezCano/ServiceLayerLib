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
    /// There are no comments for UserQuerySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("UserQuerySingle")]
    public partial class UserQuerySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<UserQuery>
    {
        /// <summary>
        /// Initialize a new UserQuerySingle object.
        /// </summary>
        public UserQuerySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new UserQuerySingle object.
        /// </summary>
        public UserQuerySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new UserQuerySingle object.
        /// </summary>
        public UserQuerySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<UserQuery> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for QueryCategory2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("QueryCategory2")]
        public virtual global::SAPB1.QueryCategorySingle QueryCategory2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._QueryCategory2 == null))
                {
                    this._QueryCategory2 = new global::SAPB1.QueryCategorySingle(this.Context, GetPath("QueryCategory2"));
                }
                return this._QueryCategory2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.QueryCategorySingle _QueryCategory2;
    }
    /// <summary>
    /// There are no comments for UserQuery in the schema.
    /// </summary>
    /// <KeyProperties>
    /// InternalKey
    /// QueryCategory
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("InternalKey", "QueryCategory")]
    [global::Microsoft.OData.Client.EntitySet("UserQueries")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("UserQuery")]
    public partial class UserQuery : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new UserQuery object.
        /// </summary>
        /// <param name="internalKey">Initial value of InternalKey.</param>
        /// <param name="queryCategory">Initial value of QueryCategory.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static UserQuery CreateUserQuery(int internalKey, int queryCategory)
        {
            UserQuery userQuery = new UserQuery();
            userQuery.InternalKey = internalKey;
            userQuery.QueryCategory = queryCategory;
            return userQuery;
        }
        /// <summary>
        /// There are no comments for Property InternalKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InternalKey")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InternalKey is required.")]
        public virtual int InternalKey
        {
            get
            {
                return this._InternalKey;
            }
            set
            {
                this.OnInternalKeyChanging(value);
                this._InternalKey = value;
                this.OnInternalKeyChanged();
                this.OnPropertyChanged("InternalKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _InternalKey;
        partial void OnInternalKeyChanging(int value);
        partial void OnInternalKeyChanged();
        /// <summary>
        /// There are no comments for Property QueryCategory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueryCategory")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QueryCategory is required.")]
        public virtual int QueryCategory
        {
            get
            {
                return this._QueryCategory;
            }
            set
            {
                this.OnQueryCategoryChanging(value);
                this._QueryCategory = value;
                this.OnQueryCategoryChanged();
                this.OnPropertyChanged("QueryCategory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _QueryCategory;
        partial void OnQueryCategoryChanging(int value);
        partial void OnQueryCategoryChanged();
        /// <summary>
        /// There are no comments for Property QueryDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueryDescription")]
        public virtual string QueryDescription
        {
            get
            {
                return this._QueryDescription;
            }
            set
            {
                this.OnQueryDescriptionChanging(value);
                this._QueryDescription = value;
                this.OnQueryDescriptionChanged();
                this.OnPropertyChanged("QueryDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QueryDescription;
        partial void OnQueryDescriptionChanging(string value);
        partial void OnQueryDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Query in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Query")]
        public virtual string Query
        {
            get
            {
                return this._Query;
            }
            set
            {
                this.OnQueryChanging(value);
                this._Query = value;
                this.OnQueryChanged();
                this.OnPropertyChanged("Query");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Query;
        partial void OnQueryChanging(string value);
        partial void OnQueryChanged();
        /// <summary>
        /// There are no comments for Property ProcedureAlias in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcedureAlias")]
        public virtual string ProcedureAlias
        {
            get
            {
                return this._ProcedureAlias;
            }
            set
            {
                this.OnProcedureAliasChanging(value);
                this._ProcedureAlias = value;
                this.OnProcedureAliasChanged();
                this.OnPropertyChanged("ProcedureAlias");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProcedureAlias;
        partial void OnProcedureAliasChanging(string value);
        partial void OnProcedureAliasChanged();
        /// <summary>
        /// There are no comments for Property ProcedureName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProcedureName")]
        public virtual string ProcedureName
        {
            get
            {
                return this._ProcedureName;
            }
            set
            {
                this.OnProcedureNameChanging(value);
                this._ProcedureName = value;
                this.OnProcedureNameChanged();
                this.OnPropertyChanged("ProcedureName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProcedureName;
        partial void OnProcedureNameChanging(string value);
        partial void OnProcedureNameChanged();
        /// <summary>
        /// There are no comments for Property QueryType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueryType")]
        public virtual global::System.Nullable<global::SAPB1.UserQueryTypeEnum> QueryType
        {
            get
            {
                return this._QueryType;
            }
            set
            {
                this.OnQueryTypeChanging(value);
                this._QueryType = value;
                this.OnQueryTypeChanged();
                this.OnPropertyChanged("QueryType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.UserQueryTypeEnum> _QueryType;
        partial void OnQueryTypeChanging(global::System.Nullable<global::SAPB1.UserQueryTypeEnum> value);
        partial void OnQueryTypeChanged();
        /// <summary>
        /// There are no comments for Property MenuCaption in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MenuCaption")]
        public virtual string MenuCaption
        {
            get
            {
                return this._MenuCaption;
            }
            set
            {
                this.OnMenuCaptionChanging(value);
                this._MenuCaption = value;
                this.OnMenuCaptionChanged();
                this.OnPropertyChanged("MenuCaption");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MenuCaption;
        partial void OnMenuCaptionChanging(string value);
        partial void OnMenuCaptionChanged();
        /// <summary>
        /// There are no comments for Property ParentMenuID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ParentMenuID")]
        public virtual global::System.Nullable<int> ParentMenuID
        {
            get
            {
                return this._ParentMenuID;
            }
            set
            {
                this.OnParentMenuIDChanging(value);
                this._ParentMenuID = value;
                this.OnParentMenuIDChanged();
                this.OnPropertyChanged("ParentMenuID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ParentMenuID;
        partial void OnParentMenuIDChanging(global::System.Nullable<int> value);
        partial void OnParentMenuIDChanged();
        /// <summary>
        /// There are no comments for Property MenuPosition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MenuPosition")]
        public virtual global::System.Nullable<int> MenuPosition
        {
            get
            {
                return this._MenuPosition;
            }
            set
            {
                this.OnMenuPositionChanging(value);
                this._MenuPosition = value;
                this.OnMenuPositionChanged();
                this.OnPropertyChanged("MenuPosition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _MenuPosition;
        partial void OnMenuPositionChanging(global::System.Nullable<int> value);
        partial void OnMenuPositionChanged();
        /// <summary>
        /// There are no comments for Property MenuUniqueID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MenuUniqueID")]
        public virtual string MenuUniqueID
        {
            get
            {
                return this._MenuUniqueID;
            }
            set
            {
                this.OnMenuUniqueIDChanging(value);
                this._MenuUniqueID = value;
                this.OnMenuUniqueIDChanged();
                this.OnPropertyChanged("MenuUniqueID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MenuUniqueID;
        partial void OnMenuUniqueIDChanging(string value);
        partial void OnMenuUniqueIDChanged();
        /// <summary>
        /// There are no comments for Property EnableMenuEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EnableMenuEntry")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> EnableMenuEntry
        {
            get
            {
                return this._EnableMenuEntry;
            }
            set
            {
                this.OnEnableMenuEntryChanging(value);
                this._EnableMenuEntry = value;
                this.OnEnableMenuEntryChanged();
                this.OnPropertyChanged("EnableMenuEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _EnableMenuEntry;
        partial void OnEnableMenuEntryChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnEnableMenuEntryChanged();
        /// <summary>
        /// There are no comments for Property QueryCategory2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueryCategory2")]
        public virtual global::SAPB1.QueryCategory QueryCategory2
        {
            get
            {
                return this._QueryCategory2;
            }
            set
            {
                this.OnQueryCategory2Changing(value);
                this._QueryCategory2 = value;
                this.OnQueryCategory2Changed();
                this.OnPropertyChanged("QueryCategory2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.QueryCategory _QueryCategory2;
        partial void OnQueryCategory2Changing(global::SAPB1.QueryCategory value);
        partial void OnQueryCategory2Changed();
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
