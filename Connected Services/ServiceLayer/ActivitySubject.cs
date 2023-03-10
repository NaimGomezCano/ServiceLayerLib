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
    /// There are no comments for ActivitySubjectSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ActivitySubjectSingle")]
    public partial class ActivitySubjectSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ActivitySubject>
    {
        /// <summary>
        /// Initialize a new ActivitySubjectSingle object.
        /// </summary>
        public ActivitySubjectSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ActivitySubjectSingle object.
        /// </summary>
        public ActivitySubjectSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ActivitySubjectSingle object.
        /// </summary>
        public ActivitySubjectSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ActivitySubject> query)
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
        /// There are no comments for ActivityType2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivityType2")]
        public virtual global::SAPB1.ActivityTypeSingle ActivityType2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ActivityType2 == null))
                {
                    this._ActivityType2 = new global::SAPB1.ActivityTypeSingle(this.Context, GetPath("ActivityType2"));
                }
                return this._ActivityType2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.ActivityTypeSingle _ActivityType2;
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
    /// There are no comments for ActivitySubject in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Code")]
    [global::Microsoft.OData.Client.EntitySet("ActivitySubjects")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ActivitySubject")]
    public partial class ActivitySubject : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ActivitySubject object.
        /// </summary>
        /// <param name="code">Initial value of Code.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ActivitySubject CreateActivitySubject(int code)
        {
            ActivitySubject activitySubject = new ActivitySubject();
            activitySubject.Code = code;
            return activitySubject;
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
        /// There are no comments for Property ActivityType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivityType")]
        public virtual global::System.Nullable<int> ActivityType
        {
            get
            {
                return this._ActivityType;
            }
            set
            {
                this.OnActivityTypeChanging(value);
                this._ActivityType = value;
                this.OnActivityTypeChanged();
                this.OnPropertyChanged("ActivityType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ActivityType;
        partial void OnActivityTypeChanging(global::System.Nullable<int> value);
        partial void OnActivityTypeChanged();
        /// <summary>
        /// There are no comments for Property IsActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsActive")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                this.OnIsActiveChanging(value);
                this._IsActive = value;
                this.OnIsActiveChanged();
                this.OnPropertyChanged("IsActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IsActive;
        partial void OnIsActiveChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIsActiveChanged();
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
        /// There are no comments for Property ActivityType2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActivityType2")]
        public virtual global::SAPB1.ActivityType ActivityType2
        {
            get
            {
                return this._ActivityType2;
            }
            set
            {
                this.OnActivityType2Changing(value);
                this._ActivityType2 = value;
                this.OnActivityType2Changed();
                this.OnPropertyChanged("ActivityType2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.ActivityType _ActivityType2;
        partial void OnActivityType2Changing(global::SAPB1.ActivityType value);
        partial void OnActivityType2Changed();
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
