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
    /// There are no comments for AssetClassLine in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("AssetClassLine")]
    public partial class AssetClassLine : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        public virtual string Code
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
        private string _Code;
        partial void OnCodeChanging(string value);
        partial void OnCodeChanged();
        /// <summary>
        /// There are no comments for Property LineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineNumber")]
        public virtual global::System.Nullable<int> LineNumber
        {
            get
            {
                return this._LineNumber;
            }
            set
            {
                this.OnLineNumberChanging(value);
                this._LineNumber = value;
                this.OnLineNumberChanged();
                this.OnPropertyChanged("LineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _LineNumber;
        partial void OnLineNumberChanging(global::System.Nullable<int> value);
        partial void OnLineNumberChanged();
        /// <summary>
        /// There are no comments for Property DepreciationAreaID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DepreciationAreaID")]
        public virtual string DepreciationAreaID
        {
            get
            {
                return this._DepreciationAreaID;
            }
            set
            {
                this.OnDepreciationAreaIDChanging(value);
                this._DepreciationAreaID = value;
                this.OnDepreciationAreaIDChanged();
                this.OnPropertyChanged("DepreciationAreaID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepreciationAreaID;
        partial void OnDepreciationAreaIDChanging(string value);
        partial void OnDepreciationAreaIDChanged();
        /// <summary>
        /// There are no comments for Property ActiveStatus in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveStatus")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> ActiveStatus
        {
            get
            {
                return this._ActiveStatus;
            }
            set
            {
                this.OnActiveStatusChanging(value);
                this._ActiveStatus = value;
                this.OnActiveStatusChanged();
                this.OnPropertyChanged("ActiveStatus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _ActiveStatus;
        partial void OnActiveStatusChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnActiveStatusChanged();
        /// <summary>
        /// There are no comments for Property AccountDetermination in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccountDetermination")]
        public virtual string AccountDetermination
        {
            get
            {
                return this._AccountDetermination;
            }
            set
            {
                this.OnAccountDeterminationChanging(value);
                this._AccountDetermination = value;
                this.OnAccountDeterminationChanged();
                this.OnPropertyChanged("AccountDetermination");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccountDetermination;
        partial void OnAccountDeterminationChanging(string value);
        partial void OnAccountDeterminationChanged();
        /// <summary>
        /// There are no comments for Property DepreciationTypeID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DepreciationTypeID")]
        public virtual string DepreciationTypeID
        {
            get
            {
                return this._DepreciationTypeID;
            }
            set
            {
                this.OnDepreciationTypeIDChanging(value);
                this._DepreciationTypeID = value;
                this.OnDepreciationTypeIDChanged();
                this.OnPropertyChanged("DepreciationTypeID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DepreciationTypeID;
        partial void OnDepreciationTypeIDChanging(string value);
        partial void OnDepreciationTypeIDChanged();
        /// <summary>
        /// There are no comments for Property UseLife in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UseLife")]
        public virtual global::System.Nullable<int> UseLife
        {
            get
            {
                return this._UseLife;
            }
            set
            {
                this.OnUseLifeChanging(value);
                this._UseLife = value;
                this.OnUseLifeChanged();
                this.OnPropertyChanged("UseLife");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _UseLife;
        partial void OnUseLifeChanging(global::System.Nullable<int> value);
        partial void OnUseLifeChanged();
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