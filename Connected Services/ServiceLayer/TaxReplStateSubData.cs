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
    /// There are no comments for TaxReplStateSubDataSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxReplStateSubDataSingle")]
    public partial class TaxReplStateSubDataSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TaxReplStateSubData>
    {
        /// <summary>
        /// Initialize a new TaxReplStateSubDataSingle object.
        /// </summary>
        public TaxReplStateSubDataSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TaxReplStateSubDataSingle object.
        /// </summary>
        public TaxReplStateSubDataSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TaxReplStateSubDataSingle object.
        /// </summary>
        public TaxReplStateSubDataSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TaxReplStateSubData> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TaxReplStateSubData in the schema.
    /// </summary>
    /// <KeyProperties>
    /// State
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("State")]
    [global::Microsoft.OData.Client.EntitySet("TaxReplStateSubs")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TaxReplStateSubData")]
    public partial class TaxReplStateSubData : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TaxReplStateSubData object.
        /// </summary>
        /// <param name="state">Initial value of State.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TaxReplStateSubData CreateTaxReplStateSubData(string state)
        {
            TaxReplStateSubData taxReplStateSubData = new TaxReplStateSubData();
            taxReplStateSubData.State = state;
            return taxReplStateSubData;
        }
        /// <summary>
        /// There are no comments for Property State in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("State")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "State is required.")]
        public virtual string State
        {
            get
            {
                return this._State;
            }
            set
            {
                this.OnStateChanging(value);
                this._State = value;
                this.OnStateChanged();
                this.OnPropertyChanged("State");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _State;
        partial void OnStateChanging(string value);
        partial void OnStateChanged();
        /// <summary>
        /// There are no comments for Property IEST in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IEST")]
        public virtual string IEST
        {
            get
            {
                return this._IEST;
            }
            set
            {
                this.OnIESTChanging(value);
                this._IEST = value;
                this.OnIESTChanged();
                this.OnPropertyChanged("IEST");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _IEST;
        partial void OnIESTChanging(string value);
        partial void OnIESTChanged();
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