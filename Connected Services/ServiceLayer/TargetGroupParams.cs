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
    /// There are no comments for TargetGroupParams in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TargetGroupParams")]
    public partial class TargetGroupParams : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property TargetGroupCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TargetGroupCode")]
        public virtual string TargetGroupCode
        {
            get
            {
                return this._TargetGroupCode;
            }
            set
            {
                this.OnTargetGroupCodeChanging(value);
                this._TargetGroupCode = value;
                this.OnTargetGroupCodeChanged();
                this.OnPropertyChanged("TargetGroupCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TargetGroupCode;
        partial void OnTargetGroupCodeChanging(string value);
        partial void OnTargetGroupCodeChanged();
        /// <summary>
        /// There are no comments for Property TargetGroupName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TargetGroupName")]
        public virtual string TargetGroupName
        {
            get
            {
                return this._TargetGroupName;
            }
            set
            {
                this.OnTargetGroupNameChanging(value);
                this._TargetGroupName = value;
                this.OnTargetGroupNameChanged();
                this.OnPropertyChanged("TargetGroupName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TargetGroupName;
        partial void OnTargetGroupNameChanging(string value);
        partial void OnTargetGroupNameChanged();
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
