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
    /// There are no comments for NFModelParams in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("NFModelParams")]
    public partial class NFModelParams : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property AbsEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AbsEntry")]
        public virtual string AbsEntry
        {
            get
            {
                return this._AbsEntry;
            }
            set
            {
                this.OnAbsEntryChanging(value);
                this._AbsEntry = value;
                this.OnAbsEntryChanged();
                this.OnPropertyChanged("AbsEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AbsEntry;
        partial void OnAbsEntryChanging(string value);
        partial void OnAbsEntryChanged();
        /// <summary>
        /// There are no comments for Property NFMName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NFMName")]
        public virtual string NFMName
        {
            get
            {
                return this._NFMName;
            }
            set
            {
                this.OnNFMNameChanging(value);
                this._NFMName = value;
                this.OnNFMNameChanged();
                this.OnPropertyChanged("NFMName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NFMName;
        partial void OnNFMNameChanging(string value);
        partial void OnNFMNameChanged();
        /// <summary>
        /// There are no comments for Property NFMDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NFMDescription")]
        public virtual string NFMDescription
        {
            get
            {
                return this._NFMDescription;
            }
            set
            {
                this.OnNFMDescriptionChanging(value);
                this._NFMDescription = value;
                this.OnNFMDescriptionChanged();
                this.OnPropertyChanged("NFMDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NFMDescription;
        partial void OnNFMDescriptionChanging(string value);
        partial void OnNFMDescriptionChanged();
        /// <summary>
        /// There are no comments for Property NFMCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NFMCode")]
        public virtual string NFMCode
        {
            get
            {
                return this._NFMCode;
            }
            set
            {
                this.OnNFMCodeChanging(value);
                this._NFMCode = value;
                this.OnNFMCodeChanged();
                this.OnPropertyChanged("NFMCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NFMCode;
        partial void OnNFMCodeChanging(string value);
        partial void OnNFMCodeChanged();
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
