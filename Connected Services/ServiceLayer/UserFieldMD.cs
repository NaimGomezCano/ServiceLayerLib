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
    /// There are no comments for UserFieldMDSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("UserFieldMDSingle")]
    public partial class UserFieldMDSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<UserFieldMD>
    {
        /// <summary>
        /// Initialize a new UserFieldMDSingle object.
        /// </summary>
        public UserFieldMDSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new UserFieldMDSingle object.
        /// </summary>
        public UserFieldMDSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new UserFieldMDSingle object.
        /// </summary>
        public UserFieldMDSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<UserFieldMD> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for UserTablesMD in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("UserTablesMD")]
        public virtual global::SAPB1.UserTablesMDSingle UserTablesMD
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._UserTablesMD == null))
                {
                    this._UserTablesMD = new global::SAPB1.UserTablesMDSingle(this.Context, GetPath("UserTablesMD"));
                }
                return this._UserTablesMD;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.UserTablesMDSingle _UserTablesMD;
    }
    /// <summary>
    /// There are no comments for UserFieldMD in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TableName
    /// FieldID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TableName", "FieldID")]
    [global::Microsoft.OData.Client.EntitySet("UserFieldsMD")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("UserFieldMD")]
    public partial class UserFieldMD : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new UserFieldMD object.
        /// </summary>
        /// <param name="tableName">Initial value of TableName.</param>
        /// <param name="fieldID">Initial value of FieldID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static UserFieldMD CreateUserFieldMD(string tableName, int fieldID)
        {
            UserFieldMD userFieldMD = new UserFieldMD();
            userFieldMD.TableName = tableName;
            userFieldMD.FieldID = fieldID;
            return userFieldMD;
        }
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
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::SAPB1.BoFieldTypes> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoFieldTypes> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::SAPB1.BoFieldTypes> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property Size in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Size")]
        public virtual global::System.Nullable<int> Size
        {
            get
            {
                return this._Size;
            }
            set
            {
                this.OnSizeChanging(value);
                this._Size = value;
                this.OnSizeChanged();
                this.OnPropertyChanged("Size");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Size;
        partial void OnSizeChanging(global::System.Nullable<int> value);
        partial void OnSizeChanged();
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
        /// There are no comments for Property SubType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubType")]
        public virtual global::System.Nullable<global::SAPB1.BoFldSubTypes> SubType
        {
            get
            {
                return this._SubType;
            }
            set
            {
                this.OnSubTypeChanging(value);
                this._SubType = value;
                this.OnSubTypeChanged();
                this.OnPropertyChanged("SubType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoFldSubTypes> _SubType;
        partial void OnSubTypeChanging(global::System.Nullable<global::SAPB1.BoFldSubTypes> value);
        partial void OnSubTypeChanged();
        /// <summary>
        /// There are no comments for Property LinkedTable in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LinkedTable")]
        public virtual string LinkedTable
        {
            get
            {
                return this._LinkedTable;
            }
            set
            {
                this.OnLinkedTableChanging(value);
                this._LinkedTable = value;
                this.OnLinkedTableChanged();
                this.OnPropertyChanged("LinkedTable");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LinkedTable;
        partial void OnLinkedTableChanging(string value);
        partial void OnLinkedTableChanged();
        /// <summary>
        /// There are no comments for Property DefaultValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultValue")]
        public virtual string DefaultValue
        {
            get
            {
                return this._DefaultValue;
            }
            set
            {
                this.OnDefaultValueChanging(value);
                this._DefaultValue = value;
                this.OnDefaultValueChanged();
                this.OnPropertyChanged("DefaultValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DefaultValue;
        partial void OnDefaultValueChanging(string value);
        partial void OnDefaultValueChanged();
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
        /// There are no comments for Property FieldID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FieldID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FieldID is required.")]
        public virtual int FieldID
        {
            get
            {
                return this._FieldID;
            }
            set
            {
                this.OnFieldIDChanging(value);
                this._FieldID = value;
                this.OnFieldIDChanged();
                this.OnPropertyChanged("FieldID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _FieldID;
        partial void OnFieldIDChanging(int value);
        partial void OnFieldIDChanged();
        /// <summary>
        /// There are no comments for Property EditSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EditSize")]
        public virtual global::System.Nullable<int> EditSize
        {
            get
            {
                return this._EditSize;
            }
            set
            {
                this.OnEditSizeChanging(value);
                this._EditSize = value;
                this.OnEditSizeChanged();
                this.OnPropertyChanged("EditSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _EditSize;
        partial void OnEditSizeChanging(global::System.Nullable<int> value);
        partial void OnEditSizeChanged();
        /// <summary>
        /// There are no comments for Property Mandatory in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Mandatory")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Mandatory
        {
            get
            {
                return this._Mandatory;
            }
            set
            {
                this.OnMandatoryChanging(value);
                this._Mandatory = value;
                this.OnMandatoryChanged();
                this.OnPropertyChanged("Mandatory");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Mandatory;
        partial void OnMandatoryChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnMandatoryChanged();
        /// <summary>
        /// There are no comments for Property LinkedUDO in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LinkedUDO")]
        public virtual string LinkedUDO
        {
            get
            {
                return this._LinkedUDO;
            }
            set
            {
                this.OnLinkedUDOChanging(value);
                this._LinkedUDO = value;
                this.OnLinkedUDOChanged();
                this.OnPropertyChanged("LinkedUDO");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LinkedUDO;
        partial void OnLinkedUDOChanging(string value);
        partial void OnLinkedUDOChanged();
        /// <summary>
        /// There are no comments for Property LinkedSystemObject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LinkedSystemObject")]
        public virtual global::System.Nullable<global::SAPB1.UDFLinkedSystemObjectTypesEnum> LinkedSystemObject
        {
            get
            {
                return this._LinkedSystemObject;
            }
            set
            {
                this.OnLinkedSystemObjectChanging(value);
                this._LinkedSystemObject = value;
                this.OnLinkedSystemObjectChanged();
                this.OnPropertyChanged("LinkedSystemObject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.UDFLinkedSystemObjectTypesEnum> _LinkedSystemObject;
        partial void OnLinkedSystemObjectChanging(global::System.Nullable<global::SAPB1.UDFLinkedSystemObjectTypesEnum> value);
        partial void OnLinkedSystemObjectChanged();
        /// <summary>
        /// There are no comments for Property ValidValuesMD in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ValidValuesMD")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ValidValueMD> ValidValuesMD
        {
            get
            {
                return this._ValidValuesMD;
            }
            set
            {
                this.OnValidValuesMDChanging(value);
                this._ValidValuesMD = value;
                this.OnValidValuesMDChanged();
                this.OnPropertyChanged("ValidValuesMD");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ValidValueMD> _ValidValuesMD = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ValidValueMD>();
        partial void OnValidValuesMDChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ValidValueMD> value);
        partial void OnValidValuesMDChanged();
        /// <summary>
        /// There are no comments for Property UserTablesMD in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserTablesMD")]
        public virtual global::SAPB1.UserTablesMD UserTablesMD
        {
            get
            {
                return this._UserTablesMD;
            }
            set
            {
                this.OnUserTablesMDChanging(value);
                this._UserTablesMD = value;
                this.OnUserTablesMDChanged();
                this.OnPropertyChanged("UserTablesMD");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.UserTablesMD _UserTablesMD;
        partial void OnUserTablesMDChanging(global::SAPB1.UserTablesMD value);
        partial void OnUserTablesMDChanged();
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
