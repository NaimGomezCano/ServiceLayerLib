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
    /// There are no comments for DiscountGroup in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountGroup")]
    public partial class DiscountGroup : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property ObjectEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ObjectEntry")]
        public virtual string ObjectEntry
        {
            get
            {
                return this._ObjectEntry;
            }
            set
            {
                this.OnObjectEntryChanging(value);
                this._ObjectEntry = value;
                this.OnObjectEntryChanged();
                this.OnPropertyChanged("ObjectEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ObjectEntry;
        partial void OnObjectEntryChanging(string value);
        partial void OnObjectEntryChanged();
        /// <summary>
        /// There are no comments for Property DiscountPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DiscountPercentage")]
        public virtual global::System.Nullable<double> DiscountPercentage
        {
            get
            {
                return this._DiscountPercentage;
            }
            set
            {
                this.OnDiscountPercentageChanging(value);
                this._DiscountPercentage = value;
                this.OnDiscountPercentageChanged();
                this.OnPropertyChanged("DiscountPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _DiscountPercentage;
        partial void OnDiscountPercentageChanging(global::System.Nullable<double> value);
        partial void OnDiscountPercentageChanged();
        /// <summary>
        /// There are no comments for Property BPCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BPCode")]
        public virtual string BPCode
        {
            get
            {
                return this._BPCode;
            }
            set
            {
                this.OnBPCodeChanging(value);
                this._BPCode = value;
                this.OnBPCodeChanged();
                this.OnPropertyChanged("BPCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BPCode;
        partial void OnBPCodeChanging(string value);
        partial void OnBPCodeChanged();
        /// <summary>
        /// There are no comments for Property BaseObjectType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseObjectType")]
        public virtual global::System.Nullable<global::SAPB1.DiscountGroupBaseObjectEnum> BaseObjectType
        {
            get
            {
                return this._BaseObjectType;
            }
            set
            {
                this.OnBaseObjectTypeChanging(value);
                this._BaseObjectType = value;
                this.OnBaseObjectTypeChanged();
                this.OnPropertyChanged("BaseObjectType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.DiscountGroupBaseObjectEnum> _BaseObjectType;
        partial void OnBaseObjectTypeChanging(global::System.Nullable<global::SAPB1.DiscountGroupBaseObjectEnum> value);
        partial void OnBaseObjectTypeChanged();
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
