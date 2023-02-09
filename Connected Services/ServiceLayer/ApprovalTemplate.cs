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
    /// There are no comments for ApprovalTemplateSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalTemplateSingle")]
    public partial class ApprovalTemplateSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ApprovalTemplate>
    {
        /// <summary>
        /// Initialize a new ApprovalTemplateSingle object.
        /// </summary>
        public ApprovalTemplateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ApprovalTemplateSingle object.
        /// </summary>
        public ApprovalTemplateSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ApprovalTemplateSingle object.
        /// </summary>
        public ApprovalTemplateSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ApprovalTemplate> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ApprovalRequests in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalRequests")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.ApprovalRequest> ApprovalRequests
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ApprovalRequests == null))
                {
                    this._ApprovalRequests = Context.CreateQuery<global::SAPB1.ApprovalRequest>(GetPath("ApprovalRequests"));
                }
                return this._ApprovalRequests;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.ApprovalRequest> _ApprovalRequests;
    }
    /// <summary>
    /// There are no comments for ApprovalTemplate in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Code")]
    [global::Microsoft.OData.Client.EntitySet("ApprovalTemplates")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalTemplate")]
    public partial class ApprovalTemplate : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ApprovalTemplate object.
        /// </summary>
        /// <param name="code">Initial value of Code.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ApprovalTemplate CreateApprovalTemplate(int code)
        {
            ApprovalTemplate approvalTemplate = new ApprovalTemplate();
            approvalTemplate.Code = code;
            return approvalTemplate;
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
        /// There are no comments for Property Remarks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Remarks")]
        public virtual string Remarks
        {
            get
            {
                return this._Remarks;
            }
            set
            {
                this.OnRemarksChanging(value);
                this._Remarks = value;
                this.OnRemarksChanged();
                this.OnPropertyChanged("Remarks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Remarks;
        partial void OnRemarksChanging(string value);
        partial void OnRemarksChanged();
        /// <summary>
        /// There are no comments for Property UseTerms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseTerms")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> UseTerms
        {
            get
            {
                return this._UseTerms;
            }
            set
            {
                this.OnUseTermsChanging(value);
                this._UseTerms = value;
                this.OnUseTermsChanged();
                this.OnPropertyChanged("UseTerms");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _UseTerms;
        partial void OnUseTermsChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnUseTermsChanged();
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
        /// There are no comments for Property IsActiveWhenUpdatingDocuments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsActiveWhenUpdatingDocuments")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IsActiveWhenUpdatingDocuments
        {
            get
            {
                return this._IsActiveWhenUpdatingDocuments;
            }
            set
            {
                this.OnIsActiveWhenUpdatingDocumentsChanging(value);
                this._IsActiveWhenUpdatingDocuments = value;
                this.OnIsActiveWhenUpdatingDocumentsChanged();
                this.OnPropertyChanged("IsActiveWhenUpdatingDocuments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IsActiveWhenUpdatingDocuments;
        partial void OnIsActiveWhenUpdatingDocumentsChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIsActiveWhenUpdatingDocumentsChanged();
        /// <summary>
        /// There are no comments for Property ApprovalTemplateUsers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalTemplateUsers")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateUser> ApprovalTemplateUsers
        {
            get
            {
                return this._ApprovalTemplateUsers;
            }
            set
            {
                this.OnApprovalTemplateUsersChanging(value);
                this._ApprovalTemplateUsers = value;
                this.OnApprovalTemplateUsersChanged();
                this.OnPropertyChanged("ApprovalTemplateUsers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateUser> _ApprovalTemplateUsers = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateUser>();
        partial void OnApprovalTemplateUsersChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateUser> value);
        partial void OnApprovalTemplateUsersChanged();
        /// <summary>
        /// There are no comments for Property ApprovalTemplateStages in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalTemplateStages")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateStage> ApprovalTemplateStages
        {
            get
            {
                return this._ApprovalTemplateStages;
            }
            set
            {
                this.OnApprovalTemplateStagesChanging(value);
                this._ApprovalTemplateStages = value;
                this.OnApprovalTemplateStagesChanged();
                this.OnPropertyChanged("ApprovalTemplateStages");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateStage> _ApprovalTemplateStages = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateStage>();
        partial void OnApprovalTemplateStagesChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateStage> value);
        partial void OnApprovalTemplateStagesChanged();
        /// <summary>
        /// There are no comments for Property ApprovalTemplateDocuments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalTemplateDocuments")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateDocument> ApprovalTemplateDocuments
        {
            get
            {
                return this._ApprovalTemplateDocuments;
            }
            set
            {
                this.OnApprovalTemplateDocumentsChanging(value);
                this._ApprovalTemplateDocuments = value;
                this.OnApprovalTemplateDocumentsChanged();
                this.OnPropertyChanged("ApprovalTemplateDocuments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateDocument> _ApprovalTemplateDocuments = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateDocument>();
        partial void OnApprovalTemplateDocumentsChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateDocument> value);
        partial void OnApprovalTemplateDocumentsChanged();
        /// <summary>
        /// There are no comments for Property ApprovalTemplateTerms in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalTemplateTerms")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateTerm> ApprovalTemplateTerms
        {
            get
            {
                return this._ApprovalTemplateTerms;
            }
            set
            {
                this.OnApprovalTemplateTermsChanging(value);
                this._ApprovalTemplateTerms = value;
                this.OnApprovalTemplateTermsChanged();
                this.OnPropertyChanged("ApprovalTemplateTerms");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateTerm> _ApprovalTemplateTerms = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateTerm>();
        partial void OnApprovalTemplateTermsChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateTerm> value);
        partial void OnApprovalTemplateTermsChanged();
        /// <summary>
        /// There are no comments for Property ApprovalTemplateQueries in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalTemplateQueries")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateQuery> ApprovalTemplateQueries
        {
            get
            {
                return this._ApprovalTemplateQueries;
            }
            set
            {
                this.OnApprovalTemplateQueriesChanging(value);
                this._ApprovalTemplateQueries = value;
                this.OnApprovalTemplateQueriesChanged();
                this.OnPropertyChanged("ApprovalTemplateQueries");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateQuery> _ApprovalTemplateQueries = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateQuery>();
        partial void OnApprovalTemplateQueriesChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalTemplateQuery> value);
        partial void OnApprovalTemplateQueriesChanged();
        /// <summary>
        /// There are no comments for Property ApprovalRequests in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalRequests")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ApprovalRequest> ApprovalRequests
        {
            get
            {
                return this._ApprovalRequests;
            }
            set
            {
                this.OnApprovalRequestsChanging(value);
                this._ApprovalRequests = value;
                this.OnApprovalRequestsChanged();
                this.OnPropertyChanged("ApprovalRequests");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ApprovalRequest> _ApprovalRequests = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ApprovalRequest>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnApprovalRequestsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ApprovalRequest> value);
        partial void OnApprovalRequestsChanged();
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