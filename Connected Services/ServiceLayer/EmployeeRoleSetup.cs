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
    /// There are no comments for EmployeeRoleSetupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeeRoleSetupSingle")]
    public partial class EmployeeRoleSetupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EmployeeRoleSetup>
    {
        /// <summary>
        /// Initialize a new EmployeeRoleSetupSingle object.
        /// </summary>
        public EmployeeRoleSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EmployeeRoleSetupSingle object.
        /// </summary>
        public EmployeeRoleSetupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EmployeeRoleSetupSingle object.
        /// </summary>
        public EmployeeRoleSetupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EmployeeRoleSetup> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for EmployeesInfo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeesInfo")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.EmployeeInfo> EmployeesInfo
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._EmployeesInfo == null))
                {
                    this._EmployeesInfo = Context.CreateQuery<global::SAPB1.EmployeeInfo>(GetPath("EmployeesInfo"));
                }
                return this._EmployeesInfo;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.EmployeeInfo> _EmployeesInfo;
    }
    /// <summary>
    /// There are no comments for EmployeeRoleSetup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TypeID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TypeID")]
    [global::Microsoft.OData.Client.EntitySet("EmployeeRolesSetup")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeeRoleSetup")]
    public partial class EmployeeRoleSetup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EmployeeRoleSetup object.
        /// </summary>
        /// <param name="typeID">Initial value of TypeID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EmployeeRoleSetup CreateEmployeeRoleSetup(int typeID)
        {
            EmployeeRoleSetup employeeRoleSetup = new EmployeeRoleSetup();
            employeeRoleSetup.TypeID = typeID;
            return employeeRoleSetup;
        }
        /// <summary>
        /// There are no comments for Property TypeID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TypeID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TypeID is required.")]
        public virtual int TypeID
        {
            get
            {
                return this._TypeID;
            }
            set
            {
                this.OnTypeIDChanging(value);
                this._TypeID = value;
                this.OnTypeIDChanged();
                this.OnPropertyChanged("TypeID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _TypeID;
        partial void OnTypeIDChanging(int value);
        partial void OnTypeIDChanged();
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
        /// There are no comments for Property EmployeesInfo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeesInfo")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.EmployeeInfo> EmployeesInfo
        {
            get
            {
                return this._EmployeesInfo;
            }
            set
            {
                this.OnEmployeesInfoChanging(value);
                this._EmployeesInfo = value;
                this.OnEmployeesInfoChanged();
                this.OnPropertyChanged("EmployeesInfo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.EmployeeInfo> _EmployeesInfo = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.EmployeeInfo>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnEmployeesInfoChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.EmployeeInfo> value);
        partial void OnEmployeesInfoChanged();
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