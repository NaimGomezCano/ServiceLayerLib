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
    /// There are no comments for EmployeePositionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeePositionSingle")]
    public partial class EmployeePositionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<EmployeePosition>
    {
        /// <summary>
        /// Initialize a new EmployeePositionSingle object.
        /// </summary>
        public EmployeePositionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new EmployeePositionSingle object.
        /// </summary>
        public EmployeePositionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new EmployeePositionSingle object.
        /// </summary>
        public EmployeePositionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<EmployeePosition> query)
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
    /// There are no comments for EmployeePosition in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PositionID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PositionID")]
    [global::Microsoft.OData.Client.EntitySet("EmployeePosition")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("EmployeePosition")]
    public partial class EmployeePosition : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new EmployeePosition object.
        /// </summary>
        /// <param name="positionID">Initial value of PositionID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static EmployeePosition CreateEmployeePosition(int positionID)
        {
            EmployeePosition employeePosition = new EmployeePosition();
            employeePosition.PositionID = positionID;
            return employeePosition;
        }
        /// <summary>
        /// There are no comments for Property PositionID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PositionID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "PositionID is required.")]
        public virtual int PositionID
        {
            get
            {
                return this._PositionID;
            }
            set
            {
                this.OnPositionIDChanging(value);
                this._PositionID = value;
                this.OnPositionIDChanged();
                this.OnPropertyChanged("PositionID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PositionID;
        partial void OnPositionIDChanging(int value);
        partial void OnPositionIDChanged();
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