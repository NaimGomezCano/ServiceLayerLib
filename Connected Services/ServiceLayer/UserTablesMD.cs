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
    /// There are no comments for UserTablesMDSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("UserTablesMDSingle")]
    public partial class UserTablesMDSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<UserTablesMD>
    {
        /// <summary>
        /// Initialize a new UserTablesMDSingle object.
        /// </summary>
        public UserTablesMDSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new UserTablesMDSingle object.
        /// </summary>
        public UserTablesMDSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new UserTablesMDSingle object.
        /// </summary>
        public UserTablesMDSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<UserTablesMD> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for UserFieldsMD in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("UserFieldsMD")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.UserFieldMD> UserFieldsMD
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._UserFieldsMD == null))
                {
                    this._UserFieldsMD = Context.CreateQuery<global::SAPB1.UserFieldMD>(GetPath("UserFieldsMD"));
                }
                return this._UserFieldsMD;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.UserFieldMD> _UserFieldsMD;
        /// <summary>
        /// There are no comments for UserObjectsMD in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("UserObjectsMD")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.UserObjectsMD> UserObjectsMD
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._UserObjectsMD == null))
                {
                    this._UserObjectsMD = Context.CreateQuery<global::SAPB1.UserObjectsMD>(GetPath("UserObjectsMD"));
                }
                return this._UserObjectsMD;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.UserObjectsMD> _UserObjectsMD;
    }
    /// <summary>
    /// There are no comments for UserTablesMD in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TableName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TableName")]
    [global::Microsoft.OData.Client.EntitySet("UserTablesMD")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("UserTablesMD")]
    public partial class UserTablesMD : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new UserTablesMD object.
        /// </summary>
        /// <param name="tableName">Initial value of TableName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static UserTablesMD CreateUserTablesMD(string tableName)
        {
            UserTablesMD userTablesMD = new UserTablesMD();
            userTablesMD.TableName = tableName;
            return userTablesMD;
        }
        /// <summary>
        /// There are no comments for Property TableName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TableName")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TableName is required.")]
        public virtual string TableName
        {
            get
            {
                return this._TableName;
            }
            set
            {
                this.OnTableNameChanging(value);
                this._TableName = value;
                this.OnTableNameChanged();
                this.OnPropertyChanged("TableName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TableName;
        partial void OnTableNameChanging(string value);
        partial void OnTableNameChanged();
        /// <summary>
        /// There are no comments for Property TableDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TableDescription")]
        public virtual string TableDescription
        {
            get
            {
                return this._TableDescription;
            }
            set
            {
                this.OnTableDescriptionChanging(value);
                this._TableDescription = value;
                this.OnTableDescriptionChanged();
                this.OnPropertyChanged("TableDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TableDescription;
        partial void OnTableDescriptionChanging(string value);
        partial void OnTableDescriptionChanged();
        /// <summary>
        /// There are no comments for Property TableType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TableType")]
        public virtual global::System.Nullable<global::SAPB1.BoUTBTableType> TableType
        {
            get
            {
                return this._TableType;
            }
            set
            {
                this.OnTableTypeChanging(value);
                this._TableType = value;
                this.OnTableTypeChanged();
                this.OnPropertyChanged("TableType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoUTBTableType> _TableType;
        partial void OnTableTypeChanging(global::System.Nullable<global::SAPB1.BoUTBTableType> value);
        partial void OnTableTypeChanged();
        /// <summary>
        /// There are no comments for Property Archivable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Archivable")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Archivable
        {
            get
            {
                return this._Archivable;
            }
            set
            {
                this.OnArchivableChanging(value);
                this._Archivable = value;
                this.OnArchivableChanged();
                this.OnPropertyChanged("Archivable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Archivable;
        partial void OnArchivableChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnArchivableChanged();
        /// <summary>
        /// There are no comments for Property ArchiveDateField in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ArchiveDateField")]
        public virtual string ArchiveDateField
        {
            get
            {
                return this._ArchiveDateField;
            }
            set
            {
                this.OnArchiveDateFieldChanging(value);
                this._ArchiveDateField = value;
                this.OnArchiveDateFieldChanged();
                this.OnPropertyChanged("ArchiveDateField");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ArchiveDateField;
        partial void OnArchiveDateFieldChanging(string value);
        partial void OnArchiveDateFieldChanged();
        /// <summary>
        /// There are no comments for Property DisplayMenu in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DisplayMenu")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> DisplayMenu
        {
            get
            {
                return this._DisplayMenu;
            }
            set
            {
                this.OnDisplayMenuChanging(value);
                this._DisplayMenu = value;
                this.OnDisplayMenuChanged();
                this.OnPropertyChanged("DisplayMenu");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _DisplayMenu;
        partial void OnDisplayMenuChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnDisplayMenuChanged();
        /// <summary>
        /// There are no comments for Property UserFieldsMD in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserFieldsMD")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.UserFieldMD> UserFieldsMD
        {
            get
            {
                return this._UserFieldsMD;
            }
            set
            {
                this.OnUserFieldsMDChanging(value);
                this._UserFieldsMD = value;
                this.OnUserFieldsMDChanged();
                this.OnPropertyChanged("UserFieldsMD");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.UserFieldMD> _UserFieldsMD = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.UserFieldMD>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnUserFieldsMDChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.UserFieldMD> value);
        partial void OnUserFieldsMDChanged();
        /// <summary>
        /// There are no comments for Property UserObjectsMD in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserObjectsMD")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.UserObjectsMD> UserObjectsMD
        {
            get
            {
                return this._UserObjectsMD;
            }
            set
            {
                this.OnUserObjectsMDChanging(value);
                this._UserObjectsMD = value;
                this.OnUserObjectsMDChanged();
                this.OnPropertyChanged("UserObjectsMD");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.UserObjectsMD> _UserObjectsMD = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.UserObjectsMD>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnUserObjectsMDChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.UserObjectsMD> value);
        partial void OnUserObjectsMDChanged();
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