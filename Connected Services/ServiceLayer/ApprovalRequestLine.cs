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
    /// There are no comments for ApprovalRequestLine in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ApprovalRequestLine")]
    public partial class ApprovalRequestLine : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property StageCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StageCode")]
        public virtual global::System.Nullable<int> StageCode
        {
            get
            {
                return this._StageCode;
            }
            set
            {
                this.OnStageCodeChanging(value);
                this._StageCode = value;
                this.OnStageCodeChanged();
                this.OnPropertyChanged("StageCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _StageCode;
        partial void OnStageCodeChanging(global::System.Nullable<int> value);
        partial void OnStageCodeChanged();
        /// <summary>
        /// There are no comments for Property UserID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserID")]
        public virtual global::System.Nullable<int> UserID
        {
            get
            {
                return this._UserID;
            }
            set
            {
                this.OnUserIDChanging(value);
                this._UserID = value;
                this.OnUserIDChanged();
                this.OnPropertyChanged("UserID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _UserID;
        partial void OnUserIDChanging(global::System.Nullable<int> value);
        partial void OnUserIDChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::SAPB1.BoApprovalRequestDecisionEnum> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoApprovalRequestDecisionEnum> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::SAPB1.BoApprovalRequestDecisionEnum> value);
        partial void OnStatusChanged();
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
        /// There are no comments for Property UpdateDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UpdateDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> UpdateDate
        {
            get
            {
                return this._UpdateDate;
            }
            set
            {
                this.OnUpdateDateChanging(value);
                this._UpdateDate = value;
                this.OnUpdateDateChanged();
                this.OnPropertyChanged("UpdateDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _UpdateDate;
        partial void OnUpdateDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnUpdateDateChanged();
        /// <summary>
        /// There are no comments for Property UpdateTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UpdateTime")]
        public virtual global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> UpdateTime
        {
            get
            {
                return this._UpdateTime;
            }
            set
            {
                this.OnUpdateTimeChanging(value);
                this._UpdateTime = value;
                this.OnUpdateTimeChanged();
                this.OnPropertyChanged("UpdateTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> _UpdateTime;
        partial void OnUpdateTimeChanging(global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> value);
        partial void OnUpdateTimeChanged();
        /// <summary>
        /// There are no comments for Property CreationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreationDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> CreationDate
        {
            get
            {
                return this._CreationDate;
            }
            set
            {
                this.OnCreationDateChanging(value);
                this._CreationDate = value;
                this.OnCreationDateChanged();
                this.OnPropertyChanged("CreationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _CreationDate;
        partial void OnCreationDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnCreationDateChanged();
        /// <summary>
        /// There are no comments for Property CreationTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CreationTime")]
        public virtual global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> CreationTime
        {
            get
            {
                return this._CreationTime;
            }
            set
            {
                this.OnCreationTimeChanging(value);
                this._CreationTime = value;
                this.OnCreationTimeChanged();
                this.OnPropertyChanged("CreationTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> _CreationTime;
        partial void OnCreationTimeChanging(global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> value);
        partial void OnCreationTimeChanged();
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
