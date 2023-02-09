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
    /// There are no comments for UserGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("UserGroupSingle")]
    public partial class UserGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<UserGroup>
    {
        /// <summary>
        /// Initialize a new UserGroupSingle object.
        /// </summary>
        public UserGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new UserGroupSingle object.
        /// </summary>
        public UserGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new UserGroupSingle object.
        /// </summary>
        public UserGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<UserGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for UserGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// UserGroupId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("UserGroupId")]
    [global::Microsoft.OData.Client.EntitySet("UserGroups")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("UserGroup")]
    public partial class UserGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new UserGroup object.
        /// </summary>
        /// <param name="userGroupId">Initial value of UserGroupId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static UserGroup CreateUserGroup(int userGroupId)
        {
            UserGroup userGroup = new UserGroup();
            userGroup.UserGroupId = userGroupId;
            return userGroup;
        }
        /// <summary>
        /// There are no comments for Property UserGroupId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserGroupId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "UserGroupId is required.")]
        public virtual int UserGroupId
        {
            get
            {
                return this._UserGroupId;
            }
            set
            {
                this.OnUserGroupIdChanging(value);
                this._UserGroupId = value;
                this.OnUserGroupIdChanged();
                this.OnPropertyChanged("UserGroupId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _UserGroupId;
        partial void OnUserGroupIdChanging(int value);
        partial void OnUserGroupIdChanged();
        /// <summary>
        /// There are no comments for Property UserGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserGroupName")]
        public virtual string UserGroupName
        {
            get
            {
                return this._UserGroupName;
            }
            set
            {
                this.OnUserGroupNameChanging(value);
                this._UserGroupName = value;
                this.OnUserGroupNameChanged();
                this.OnPropertyChanged("UserGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserGroupName;
        partial void OnUserGroupNameChanging(string value);
        partial void OnUserGroupNameChanged();
        /// <summary>
        /// There are no comments for Property UserGroupDec in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserGroupDec")]
        public virtual string UserGroupDec
        {
            get
            {
                return this._UserGroupDec;
            }
            set
            {
                this.OnUserGroupDecChanging(value);
                this._UserGroupDec = value;
                this.OnUserGroupDecChanged();
                this.OnPropertyChanged("UserGroupDec");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserGroupDec;
        partial void OnUserGroupDecChanging(string value);
        partial void OnUserGroupDecChanged();
        /// <summary>
        /// There are no comments for Property TPLId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TPLId")]
        public virtual global::System.Nullable<int> TPLId
        {
            get
            {
                return this._TPLId;
            }
            set
            {
                this.OnTPLIdChanging(value);
                this._TPLId = value;
                this.OnTPLIdChanged();
                this.OnPropertyChanged("TPLId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _TPLId;
        partial void OnTPLIdChanging(global::System.Nullable<int> value);
        partial void OnTPLIdChanged();
        /// <summary>
        /// There are no comments for Property StartDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StartDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> StartDate
        {
            get
            {
                return this._StartDate;
            }
            set
            {
                this.OnStartDateChanging(value);
                this._StartDate = value;
                this.OnStartDateChanged();
                this.OnPropertyChanged("StartDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _StartDate;
        partial void OnStartDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnStartDateChanged();
        /// <summary>
        /// There are no comments for Property DueDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DueDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DueDate
        {
            get
            {
                return this._DueDate;
            }
            set
            {
                this.OnDueDateChanging(value);
                this._DueDate = value;
                this.OnDueDateChanged();
                this.OnPropertyChanged("DueDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DueDate;
        partial void OnDueDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDueDateChanged();
        /// <summary>
        /// There are no comments for Property UserGroupType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserGroupType")]
        public virtual global::System.Nullable<global::SAPB1.UserGroupCategoryEnum> UserGroupType
        {
            get
            {
                return this._UserGroupType;
            }
            set
            {
                this.OnUserGroupTypeChanging(value);
                this._UserGroupType = value;
                this.OnUserGroupTypeChanged();
                this.OnPropertyChanged("UserGroupType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.UserGroupCategoryEnum> _UserGroupType;
        partial void OnUserGroupTypeChanging(global::System.Nullable<global::SAPB1.UserGroupCategoryEnum> value);
        partial void OnUserGroupTypeChanged();
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