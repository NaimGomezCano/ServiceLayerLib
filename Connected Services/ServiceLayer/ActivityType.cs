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
    /// There are no comments for ActivityTypeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ActivityTypeSingle")]
    public partial class ActivityTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ActivityType>
    {
        /// <summary>
        /// Initialize a new ActivityTypeSingle object.
        /// </summary>
        public ActivityTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ActivityTypeSingle object.
        /// </summary>
        public ActivityTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ActivityTypeSingle object.
        /// </summary>
        public ActivityTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ActivityType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Activities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Activities")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.Activity> Activities
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Activities == null))
                {
                    this._Activities = Context.CreateQuery<global::SAPB1.Activity>(GetPath("Activities"));
                }
                return this._Activities;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.Activity> _Activities;
        /// <summary>
        /// There are no comments for ActivitySubjects in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivitySubjects")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.ActivitySubject> ActivitySubjects
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ActivitySubjects == null))
                {
                    this._ActivitySubjects = Context.CreateQuery<global::SAPB1.ActivitySubject>(GetPath("ActivitySubjects"));
                }
                return this._ActivitySubjects;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.ActivitySubject> _ActivitySubjects;
        /// <summary>
        /// There are no comments for Contacts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Contacts")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.Contact> Contacts
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Contacts == null))
                {
                    this._Contacts = Context.CreateQuery<global::SAPB1.Contact>(GetPath("Contacts"));
                }
                return this._Contacts;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.Contact> _Contacts;
    }
    /// <summary>
    /// There are no comments for ActivityType in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Code")]
    [global::Microsoft.OData.Client.EntitySet("ActivityTypes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ActivityType")]
    public partial class ActivityType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ActivityType object.
        /// </summary>
        /// <param name="code">Initial value of Code.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ActivityType CreateActivityType(int code)
        {
            ActivityType activityType = new ActivityType();
            activityType.Code = code;
            return activityType;
        }
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Code is required.")]
        public virtual int Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                this.OnCodeChanging(value);
                this._Code = value;
                this.OnCodeChanged();
                this.OnPropertyChanged("Code");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Code;
        partial void OnCodeChanging(int value);
        partial void OnCodeChanged();
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
        /// There are no comments for Property Activities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Activities")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Activity> Activities
        {
            get
            {
                return this._Activities;
            }
            set
            {
                this.OnActivitiesChanging(value);
                this._Activities = value;
                this.OnActivitiesChanged();
                this.OnPropertyChanged("Activities");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Activity> _Activities = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Activity>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnActivitiesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Activity> value);
        partial void OnActivitiesChanged();
        /// <summary>
        /// There are no comments for Property ActivitySubjects in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivitySubjects")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ActivitySubject> ActivitySubjects
        {
            get
            {
                return this._ActivitySubjects;
            }
            set
            {
                this.OnActivitySubjectsChanging(value);
                this._ActivitySubjects = value;
                this.OnActivitySubjectsChanged();
                this.OnPropertyChanged("ActivitySubjects");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ActivitySubject> _ActivitySubjects = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ActivitySubject>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnActivitySubjectsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ActivitySubject> value);
        partial void OnActivitySubjectsChanged();
        /// <summary>
        /// There are no comments for Property Contacts in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Contacts")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Contact> Contacts
        {
            get
            {
                return this._Contacts;
            }
            set
            {
                this.OnContactsChanging(value);
                this._Contacts = value;
                this.OnContactsChanged();
                this.OnPropertyChanged("Contacts");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Contact> _Contacts = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Contact>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnContactsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.Contact> value);
        partial void OnContactsChanged();
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
