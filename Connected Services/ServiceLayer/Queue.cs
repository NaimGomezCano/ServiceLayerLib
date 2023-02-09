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
    /// There are no comments for QueueSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("QueueSingle")]
    public partial class QueueSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Queue>
    {
        /// <summary>
        /// Initialize a new QueueSingle object.
        /// </summary>
        public QueueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new QueueSingle object.
        /// </summary>
        public QueueSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new QueueSingle object.
        /// </summary>
        public QueueSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Queue> query)
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
        /// <summary>
        /// There are no comments for User in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("User")]
        public virtual global::SAPB1.UserSingle User
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._User == null))
                {
                    this._User = new global::SAPB1.UserSingle(this.Context, GetPath("User"));
                }
                return this._User;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.UserSingle _User;
    }
    /// <summary>
    /// There are no comments for Queue in the schema.
    /// </summary>
    /// <KeyProperties>
    /// QueueID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("QueueID")]
    [global::Microsoft.OData.Client.EntitySet("Queue")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Queue")]
    public partial class Queue : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Queue object.
        /// </summary>
        /// <param name="queueID">Initial value of QueueID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Queue CreateQueue(string queueID)
        {
            Queue queue = new Queue();
            queue.QueueID = queueID;
            return queue;
        }
        /// <summary>
        /// There are no comments for Property QueueID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueueID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "QueueID is required.")]
        public virtual string QueueID
        {
            get
            {
                return this._QueueID;
            }
            set
            {
                this.OnQueueIDChanging(value);
                this._QueueID = value;
                this.OnQueueIDChanged();
                this.OnPropertyChanged("QueueID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QueueID;
        partial void OnQueueIDChanging(string value);
        partial void OnQueueIDChanged();
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
        /// There are no comments for Property Inactive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Inactive")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Inactive
        {
            get
            {
                return this._Inactive;
            }
            set
            {
                this.OnInactiveChanging(value);
                this._Inactive = value;
                this.OnInactiveChanged();
                this.OnPropertyChanged("Inactive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Inactive;
        partial void OnInactiveChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnInactiveChanged();
        /// <summary>
        /// There are no comments for Property QueueManager in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueueManager")]
        public virtual global::System.Nullable<int> QueueManager
        {
            get
            {
                return this._QueueManager;
            }
            set
            {
                this.OnQueueManagerChanging(value);
                this._QueueManager = value;
                this.OnQueueManagerChanged();
                this.OnPropertyChanged("QueueManager");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _QueueManager;
        partial void OnQueueManagerChanging(global::System.Nullable<int> value);
        partial void OnQueueManagerChanged();
        /// <summary>
        /// There are no comments for Property QueueEmail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueueEmail")]
        public virtual string QueueEmail
        {
            get
            {
                return this._QueueEmail;
            }
            set
            {
                this.OnQueueEmailChanging(value);
                this._QueueEmail = value;
                this.OnQueueEmailChanged();
                this.OnPropertyChanged("QueueEmail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QueueEmail;
        partial void OnQueueEmailChanging(string value);
        partial void OnQueueEmailChanged();
        /// <summary>
        /// There are no comments for Property QueueMembers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueueMembers")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.QueueMember> QueueMembers
        {
            get
            {
                return this._QueueMembers;
            }
            set
            {
                this.OnQueueMembersChanging(value);
                this._QueueMembers = value;
                this.OnQueueMembersChanged();
                this.OnPropertyChanged("QueueMembers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.QueueMember> _QueueMembers = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.QueueMember>();
        partial void OnQueueMembersChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.QueueMember> value);
        partial void OnQueueMembersChanged();
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
        /// There are no comments for Property User in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("User")]
        public virtual global::SAPB1.User User
        {
            get
            {
                return this._User;
            }
            set
            {
                this.OnUserChanging(value);
                this._User = value;
                this.OnUserChanged();
                this.OnPropertyChanged("User");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.User _User;
        partial void OnUserChanging(global::SAPB1.User value);
        partial void OnUserChanged();
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