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
    /// There are no comments for GetChangeLogParams in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("GetChangeLogParams")]
    public partial class GetChangeLogParams : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property PrimaryKey in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PrimaryKey")]
        public virtual string PrimaryKey
        {
            get
            {
                return this._PrimaryKey;
            }
            set
            {
                this.OnPrimaryKeyChanging(value);
                this._PrimaryKey = value;
                this.OnPrimaryKeyChanged();
                this.OnPropertyChanged("PrimaryKey");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PrimaryKey;
        partial void OnPrimaryKeyChanging(string value);
        partial void OnPrimaryKeyChanged();
        /// <summary>
        /// There are no comments for Property UDOObjectCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UDOObjectCode")]
        public virtual string UDOObjectCode
        {
            get
            {
                return this._UDOObjectCode;
            }
            set
            {
                this.OnUDOObjectCodeChanging(value);
                this._UDOObjectCode = value;
                this.OnUDOObjectCodeChanged();
                this.OnPropertyChanged("UDOObjectCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UDOObjectCode;
        partial void OnUDOObjectCodeChanging(string value);
        partial void OnUDOObjectCodeChanged();
        /// <summary>
        /// There are no comments for Property Object in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Object")]
        public virtual global::System.Nullable<global::SAPB1.BoChangeLogEnum> Object
        {
            get
            {
                return this._Object;
            }
            set
            {
                this.OnObjectChanging(value);
                this._Object = value;
                this.OnObjectChanged();
                this.OnPropertyChanged("Object");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoChangeLogEnum> _Object;
        partial void OnObjectChanging(global::System.Nullable<global::SAPB1.BoChangeLogEnum> value);
        partial void OnObjectChanged();
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
