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
    /// There are no comments for VM_ThirdPartyValuesData in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("VM_ThirdPartyValuesData")]
    public partial class VM_ThirdPartyValuesData : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property AbsEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AbsEntry")]
        public virtual global::System.Nullable<int> AbsEntry
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
        private global::System.Nullable<int> _AbsEntry;
        partial void OnAbsEntryChanging(global::System.Nullable<int> value);
        partial void OnAbsEntryChanged();
        /// <summary>
        /// There are no comments for Property LineId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LineId")]
        public virtual global::System.Nullable<int> LineId
        {
            get
            {
                return this._LineId;
            }
            set
            {
                this.OnLineIdChanging(value);
                this._LineId = value;
                this.OnLineIdChanged();
                this.OnPropertyChanged("LineId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _LineId;
        partial void OnLineIdChanging(global::System.Nullable<int> value);
        partial void OnLineIdChanged();
        /// <summary>
        /// There are no comments for Property ThirdPartySystemId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ThirdPartySystemId")]
        public virtual global::System.Nullable<int> ThirdPartySystemId
        {
            get
            {
                return this._ThirdPartySystemId;
            }
            set
            {
                this.OnThirdPartySystemIdChanging(value);
                this._ThirdPartySystemId = value;
                this.OnThirdPartySystemIdChanged();
                this.OnPropertyChanged("ThirdPartySystemId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ThirdPartySystemId;
        partial void OnThirdPartySystemIdChanging(global::System.Nullable<int> value);
        partial void OnThirdPartySystemIdChanged();
        /// <summary>
        /// There are no comments for Property ThirdPartyValue in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ThirdPartyValue")]
        public virtual string ThirdPartyValue
        {
            get
            {
                return this._ThirdPartyValue;
            }
            set
            {
                this.OnThirdPartyValueChanging(value);
                this._ThirdPartyValue = value;
                this.OnThirdPartyValueChanged();
                this.OnPropertyChanged("ThirdPartyValue");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ThirdPartyValue;
        partial void OnThirdPartyValueChanging(string value);
        partial void OnThirdPartyValueChanged();
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