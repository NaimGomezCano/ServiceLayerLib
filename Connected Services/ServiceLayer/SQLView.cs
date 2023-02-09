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
    /// There are no comments for SQLViewSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SQLViewSingle")]
    public partial class SQLViewSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SQLView>
    {
        /// <summary>
        /// Initialize a new SQLViewSingle object.
        /// </summary>
        public SQLViewSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SQLViewSingle object.
        /// </summary>
        public SQLViewSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SQLViewSingle object.
        /// </summary>
        public SQLViewSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SQLView> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SQLView in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Name
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Name")]
    [global::Microsoft.OData.Client.EntitySet("SQLViews")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SQLView")]
    public partial class SQLView : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SQLView object.
        /// </summary>
        /// <param name="name">Initial value of Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SQLView CreateSQLView(string name)
        {
            SQLView sQLView = new SQLView();
            sQLView.Name = name;
            return sQLView;
        }
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Name is required.")]
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
        /// There are no comments for Property DBType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DBType")]
        public virtual string DBType
        {
            get
            {
                return this._DBType;
            }
            set
            {
                this.OnDBTypeChanging(value);
                this._DBType = value;
                this.OnDBTypeChanged();
                this.OnPropertyChanged("DBType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DBType;
        partial void OnDBTypeChanging(string value);
        partial void OnDBTypeChanged();
        /// <summary>
        /// There are no comments for Property SchemaName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SchemaName")]
        public virtual string SchemaName
        {
            get
            {
                return this._SchemaName;
            }
            set
            {
                this.OnSchemaNameChanging(value);
                this._SchemaName = value;
                this.OnSchemaNameChanged();
                this.OnPropertyChanged("SchemaName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SchemaName;
        partial void OnSchemaNameChanging(string value);
        partial void OnSchemaNameChanged();
        /// <summary>
        /// There are no comments for Property CreateDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreateDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> CreateDate
        {
            get
            {
                return this._CreateDate;
            }
            set
            {
                this.OnCreateDateChanging(value);
                this._CreateDate = value;
                this.OnCreateDateChanged();
                this.OnPropertyChanged("CreateDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _CreateDate;
        partial void OnCreateDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnCreateDateChanged();
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
        /// <summary>
        /// There are no comments for Expose in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("Expose")]
        public virtual global::Microsoft.OData.Client.DataServiceActionQuery Expose()
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(this.Context, resource.EditLink.OriginalString.Trim('/') + "/SAPB1.Expose");
        }
        /// <summary>
        /// There are no comments for Unexpose in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("Unexpose")]
        public virtual global::Microsoft.OData.Client.DataServiceActionQuery Unexpose()
        {
            global::Microsoft.OData.Client.EntityDescriptor resource = Context.EntityTracker.TryGetEntityDescriptor(this);
            if (resource == null)
            {
                throw new global::System.Exception("cannot find entity");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuery(this.Context, resource.EditLink.OriginalString.Trim('/') + "/SAPB1.Unexpose");
        }
    }
}