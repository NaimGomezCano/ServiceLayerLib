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
    /// There are no comments for OpenningBalanceAccount in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("OpenningBalanceAccount")]
    public partial class OpenningBalanceAccount : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property OpenBalanceAccount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OpenBalanceAccount")]
        public virtual string OpenBalanceAccount
        {
            get
            {
                return this._OpenBalanceAccount;
            }
            set
            {
                this.OnOpenBalanceAccountChanging(value);
                this._OpenBalanceAccount = value;
                this.OnOpenBalanceAccountChanged();
                this.OnPropertyChanged("OpenBalanceAccount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OpenBalanceAccount;
        partial void OnOpenBalanceAccountChanging(string value);
        partial void OnOpenBalanceAccountChanged();
        /// <summary>
        /// There are no comments for Property Date in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Date")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> Date
        {
            get
            {
                return this._Date;
            }
            set
            {
                this.OnDateChanging(value);
                this._Date = value;
                this.OnDateChanged();
                this.OnPropertyChanged("Date");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _Date;
        partial void OnDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDateChanged();
        /// <summary>
        /// There are no comments for Property Ref1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Ref1")]
        public virtual string Ref1
        {
            get
            {
                return this._Ref1;
            }
            set
            {
                this.OnRef1Changing(value);
                this._Ref1 = value;
                this.OnRef1Changed();
                this.OnPropertyChanged("Ref1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Ref1;
        partial void OnRef1Changing(string value);
        partial void OnRef1Changed();
        /// <summary>
        /// There are no comments for Property Ref2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Ref2")]
        public virtual string Ref2
        {
            get
            {
                return this._Ref2;
            }
            set
            {
                this.OnRef2Changing(value);
                this._Ref2 = value;
                this.OnRef2Changed();
                this.OnPropertyChanged("Ref2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Ref2;
        partial void OnRef2Changing(string value);
        partial void OnRef2Changed();
        /// <summary>
        /// There are no comments for Property Details in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Details")]
        public virtual string Details
        {
            get
            {
                return this._Details;
            }
            set
            {
                this.OnDetailsChanging(value);
                this._Details = value;
                this.OnDetailsChanged();
                this.OnPropertyChanged("Details");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Details;
        partial void OnDetailsChanging(string value);
        partial void OnDetailsChanged();
        /// <summary>
        /// There are no comments for Property BPLID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BPLID")]
        public virtual global::System.Nullable<int> BPLID
        {
            get
            {
                return this._BPLID;
            }
            set
            {
                this.OnBPLIDChanging(value);
                this._BPLID = value;
                this.OnBPLIDChanged();
                this.OnPropertyChanged("BPLID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BPLID;
        partial void OnBPLIDChanging(global::System.Nullable<int> value);
        partial void OnBPLIDChanged();
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
