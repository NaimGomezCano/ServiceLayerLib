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
    /// There are no comments for ApprovalStageSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalStageSingle")]
    public partial class ApprovalStageSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ApprovalStage>
    {
        /// <summary>
        /// Initialize a new ApprovalStageSingle object.
        /// </summary>
        public ApprovalStageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ApprovalStageSingle object.
        /// </summary>
        public ApprovalStageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ApprovalStageSingle object.
        /// </summary>
        public ApprovalStageSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ApprovalStage> query)
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
    /// There are no comments for ApprovalStage in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Code")]
    [global::Microsoft.OData.Client.EntitySet("ApprovalStages")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalStage")]
    public partial class ApprovalStage : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ApprovalStage object.
        /// </summary>
        /// <param name="code">Initial value of Code.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ApprovalStage CreateApprovalStage(int code)
        {
            ApprovalStage approvalStage = new ApprovalStage();
            approvalStage.Code = code;
            return approvalStage;
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
        /// There are no comments for Property NoOfApproversRequired in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NoOfApproversRequired")]
        public virtual global::System.Nullable<int> NoOfApproversRequired
        {
            get
            {
                return this._NoOfApproversRequired;
            }
            set
            {
                this.OnNoOfApproversRequiredChanging(value);
                this._NoOfApproversRequired = value;
                this.OnNoOfApproversRequiredChanged();
                this.OnPropertyChanged("NoOfApproversRequired");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _NoOfApproversRequired;
        partial void OnNoOfApproversRequiredChanging(global::System.Nullable<int> value);
        partial void OnNoOfApproversRequiredChanged();
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
        /// There are no comments for Property ApprovalStageApprovers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalStageApprovers")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalStageApprover> ApprovalStageApprovers
        {
            get
            {
                return this._ApprovalStageApprovers;
            }
            set
            {
                this.OnApprovalStageApproversChanging(value);
                this._ApprovalStageApprovers = value;
                this.OnApprovalStageApproversChanged();
                this.OnPropertyChanged("ApprovalStageApprovers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalStageApprover> _ApprovalStageApprovers = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalStageApprover>();
        partial void OnApprovalStageApproversChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.ApprovalStageApprover> value);
        partial void OnApprovalStageApproversChanged();
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
