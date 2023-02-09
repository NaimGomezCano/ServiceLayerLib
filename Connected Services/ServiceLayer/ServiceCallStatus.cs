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
    /// There are no comments for ServiceCallStatusSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceCallStatusSingle")]
    public partial class ServiceCallStatusSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ServiceCallStatus>
    {
        /// <summary>
        /// Initialize a new ServiceCallStatusSingle object.
        /// </summary>
        public ServiceCallStatusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ServiceCallStatusSingle object.
        /// </summary>
        public ServiceCallStatusSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ServiceCallStatusSingle object.
        /// </summary>
        public ServiceCallStatusSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ServiceCallStatus> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ServiceCalls in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceCalls")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.ServiceCall> ServiceCalls
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ServiceCalls == null))
                {
                    this._ServiceCalls = Context.CreateQuery<global::SAPB1.ServiceCall>(GetPath("ServiceCalls"));
                }
                return this._ServiceCalls;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.ServiceCall> _ServiceCalls;
    }
    /// <summary>
    /// There are no comments for ServiceCallStatus in the schema.
    /// </summary>
    /// <KeyProperties>
    /// StatusId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("StatusId")]
    [global::Microsoft.OData.Client.EntitySet("ServiceCallStatus")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceCallStatus")]
    public partial class ServiceCallStatus : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ServiceCallStatus object.
        /// </summary>
        /// <param name="statusId">Initial value of StatusId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ServiceCallStatus CreateServiceCallStatus(int statusId)
        {
            ServiceCallStatus serviceCallStatus = new ServiceCallStatus();
            serviceCallStatus.StatusId = statusId;
            return serviceCallStatus;
        }
        /// <summary>
        /// There are no comments for Property StatusId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StatusId")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "StatusId is required.")]
        public virtual int StatusId
        {
            get
            {
                return this._StatusId;
            }
            set
            {
                this.OnStatusIdChanging(value);
                this._StatusId = value;
                this.OnStatusIdChanged();
                this.OnPropertyChanged("StatusId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _StatusId;
        partial void OnStatusIdChanging(int value);
        partial void OnStatusIdChanged();
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
        /// There are no comments for Property Active in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Active")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Active
        {
            get
            {
                return this._Active;
            }
            set
            {
                this.OnActiveChanging(value);
                this._Active = value;
                this.OnActiveChanged();
                this.OnPropertyChanged("Active");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Active;
        partial void OnActiveChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnActiveChanged();
        /// <summary>
        /// There are no comments for Property ServiceCalls in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ServiceCalls")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ServiceCall> ServiceCalls
        {
            get
            {
                return this._ServiceCalls;
            }
            set
            {
                this.OnServiceCallsChanging(value);
                this._ServiceCalls = value;
                this.OnServiceCallsChanged();
                this.OnPropertyChanged("ServiceCalls");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ServiceCall> _ServiceCalls = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ServiceCall>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnServiceCallsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ServiceCall> value);
        partial void OnServiceCallsChanged();
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
