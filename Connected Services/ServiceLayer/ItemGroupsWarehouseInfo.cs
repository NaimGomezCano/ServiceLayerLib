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
    /// There are no comments for ItemGroupsWarehouseInfo in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ItemGroupsWarehouseInfo")]
    public partial class ItemGroupsWarehouseInfo : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property ItmsGrpCod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItmsGrpCod")]
        public virtual global::System.Nullable<int> ItmsGrpCod
        {
            get
            {
                return this._ItmsGrpCod;
            }
            set
            {
                this.OnItmsGrpCodChanging(value);
                this._ItmsGrpCod = value;
                this.OnItmsGrpCodChanged();
                this.OnPropertyChanged("ItmsGrpCod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ItmsGrpCod;
        partial void OnItmsGrpCodChanging(global::System.Nullable<int> value);
        partial void OnItmsGrpCodChanged();
        /// <summary>
        /// There are no comments for Property WarehouseCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseCode")]
        public virtual string WarehouseCode
        {
            get
            {
                return this._WarehouseCode;
            }
            set
            {
                this.OnWarehouseCodeChanging(value);
                this._WarehouseCode = value;
                this.OnWarehouseCodeChanged();
                this.OnPropertyChanged("WarehouseCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WarehouseCode;
        partial void OnWarehouseCodeChanging(string value);
        partial void OnWarehouseCodeChanged();
        /// <summary>
        /// There are no comments for Property DefaultBin in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultBin")]
        public virtual global::System.Nullable<int> DefaultBin
        {
            get
            {
                return this._DefaultBin;
            }
            set
            {
                this.OnDefaultBinChanging(value);
                this._DefaultBin = value;
                this.OnDefaultBinChanged();
                this.OnPropertyChanged("DefaultBin");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DefaultBin;
        partial void OnDefaultBinChanging(global::System.Nullable<int> value);
        partial void OnDefaultBinChanged();
        /// <summary>
        /// There are no comments for Property DefaultBinEnforced in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultBinEnforced")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> DefaultBinEnforced
        {
            get
            {
                return this._DefaultBinEnforced;
            }
            set
            {
                this.OnDefaultBinEnforcedChanging(value);
                this._DefaultBinEnforced = value;
                this.OnDefaultBinEnforcedChanged();
                this.OnPropertyChanged("DefaultBinEnforced");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _DefaultBinEnforced;
        partial void OnDefaultBinEnforcedChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnDefaultBinEnforcedChanged();
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