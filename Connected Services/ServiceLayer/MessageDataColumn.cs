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
    /// There are no comments for MessageDataColumn in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("MessageDataColumn")]
    public partial class MessageDataColumn : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property ColumnName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ColumnName")]
        public virtual string ColumnName
        {
            get
            {
                return this._ColumnName;
            }
            set
            {
                this.OnColumnNameChanging(value);
                this._ColumnName = value;
                this.OnColumnNameChanged();
                this.OnPropertyChanged("ColumnName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ColumnName;
        partial void OnColumnNameChanging(string value);
        partial void OnColumnNameChanged();
        /// <summary>
        /// There are no comments for Property Link in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Link")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Link
        {
            get
            {
                return this._Link;
            }
            set
            {
                this.OnLinkChanging(value);
                this._Link = value;
                this.OnLinkChanged();
                this.OnPropertyChanged("Link");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Link;
        partial void OnLinkChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnLinkChanged();
        /// <summary>
        /// There are no comments for Property MessageDataLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MessageDataLines")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.MessageDataLine> MessageDataLines
        {
            get
            {
                return this._MessageDataLines;
            }
            set
            {
                this.OnMessageDataLinesChanging(value);
                this._MessageDataLines = value;
                this.OnMessageDataLinesChanged();
                this.OnPropertyChanged("MessageDataLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.MessageDataLine> _MessageDataLines = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.MessageDataLine>();
        partial void OnMessageDataLinesChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.MessageDataLine> value);
        partial void OnMessageDataLinesChanged();
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