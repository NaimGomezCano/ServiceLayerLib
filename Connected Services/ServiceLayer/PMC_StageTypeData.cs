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
    /// There are no comments for PMC_StageTypeData in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PMC_StageTypeData")]
    public partial class PMC_StageTypeData : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property StageID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StageID")]
        public virtual global::System.Nullable<int> StageID
        {
            get
            {
                return this._StageID;
            }
            set
            {
                this.OnStageIDChanging(value);
                this._StageID = value;
                this.OnStageIDChanged();
                this.OnPropertyChanged("StageID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _StageID;
        partial void OnStageIDChanging(global::System.Nullable<int> value);
        partial void OnStageIDChanged();
        /// <summary>
        /// There are no comments for Property StageName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StageName")]
        public virtual string StageName
        {
            get
            {
                return this._StageName;
            }
            set
            {
                this.OnStageNameChanging(value);
                this._StageName = value;
                this.OnStageNameChanged();
                this.OnPropertyChanged("StageName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StageName;
        partial void OnStageNameChanging(string value);
        partial void OnStageNameChanged();
        /// <summary>
        /// There are no comments for Property StageDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("StageDescription")]
        public virtual string StageDescription
        {
            get
            {
                return this._StageDescription;
            }
            set
            {
                this.OnStageDescriptionChanging(value);
                this._StageDescription = value;
                this.OnStageDescriptionChanged();
                this.OnPropertyChanged("StageDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _StageDescription;
        partial void OnStageDescriptionChanging(string value);
        partial void OnStageDescriptionChanged();
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
