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
    /// There are no comments for PMC_SubprojectTypeData in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PMC_SubprojectTypeData")]
    public partial class PMC_SubprojectTypeData : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property SubprojectTypeID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubprojectTypeID")]
        public virtual global::System.Nullable<int> SubprojectTypeID
        {
            get
            {
                return this._SubprojectTypeID;
            }
            set
            {
                this.OnSubprojectTypeIDChanging(value);
                this._SubprojectTypeID = value;
                this.OnSubprojectTypeIDChanged();
                this.OnPropertyChanged("SubprojectTypeID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SubprojectTypeID;
        partial void OnSubprojectTypeIDChanging(global::System.Nullable<int> value);
        partial void OnSubprojectTypeIDChanged();
        /// <summary>
        /// There are no comments for Property SubprojectTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubprojectTypeName")]
        public virtual string SubprojectTypeName
        {
            get
            {
                return this._SubprojectTypeName;
            }
            set
            {
                this.OnSubprojectTypeNameChanging(value);
                this._SubprojectTypeName = value;
                this.OnSubprojectTypeNameChanged();
                this.OnPropertyChanged("SubprojectTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SubprojectTypeName;
        partial void OnSubprojectTypeNameChanging(string value);
        partial void OnSubprojectTypeNameChanged();
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