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
    /// There are no comments for EcmActionDocParams in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EcmActionDocParams")]
    public partial class EcmActionDocParams : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Protocol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Protocol")]
        public virtual string Protocol
        {
            get
            {
                return this._Protocol;
            }
            set
            {
                this.OnProtocolChanging(value);
                this._Protocol = value;
                this.OnProtocolChanged();
                this.OnPropertyChanged("Protocol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Protocol;
        partial void OnProtocolChanging(string value);
        partial void OnProtocolChanged();
        /// <summary>
        /// There are no comments for Property SourceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceType")]
        public virtual string SourceType
        {
            get
            {
                return this._SourceType;
            }
            set
            {
                this.OnSourceTypeChanging(value);
                this._SourceType = value;
                this.OnSourceTypeChanged();
                this.OnPropertyChanged("SourceType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceType;
        partial void OnSourceTypeChanging(string value);
        partial void OnSourceTypeChanged();
        /// <summary>
        /// There are no comments for Property SourceObject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceObject")]
        public virtual global::System.Nullable<int> SourceObject
        {
            get
            {
                return this._SourceObject;
            }
            set
            {
                this.OnSourceObjectChanging(value);
                this._SourceObject = value;
                this.OnSourceObjectChanged();
                this.OnPropertyChanged("SourceObject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SourceObject;
        partial void OnSourceObjectChanging(global::System.Nullable<int> value);
        partial void OnSourceObjectChanged();
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
