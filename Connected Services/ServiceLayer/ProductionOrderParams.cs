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
    /// There are no comments for ProductionOrderParams in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ProductionOrderParams")]
    public partial class ProductionOrderParams : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property AbsoluteEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AbsoluteEntry")]
        public virtual global::System.Nullable<int> AbsoluteEntry
        {
            get
            {
                return this._AbsoluteEntry;
            }
            set
            {
                this.OnAbsoluteEntryChanging(value);
                this._AbsoluteEntry = value;
                this.OnAbsoluteEntryChanged();
                this.OnPropertyChanged("AbsoluteEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _AbsoluteEntry;
        partial void OnAbsoluteEntryChanging(global::System.Nullable<int> value);
        partial void OnAbsoluteEntryChanged();
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
