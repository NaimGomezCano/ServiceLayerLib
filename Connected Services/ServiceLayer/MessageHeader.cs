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
    /// There are no comments for MessageHeader in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("MessageHeader")]
    public partial class MessageHeader : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        public virtual global::System.Nullable<int> Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                this.OnCodeChanging(value);
                this._Code = value;
                this.OnCodeChanged();
                this.OnPropertyChanged("Code");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Code;
        partial void OnCodeChanging(global::System.Nullable<int> value);
        partial void OnCodeChanged();
        /// <summary>
        /// There are no comments for Property Received in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Received")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Received
        {
            get
            {
                return this._Received;
            }
            set
            {
                this.OnReceivedChanging(value);
                this._Received = value;
                this.OnReceivedChanged();
                this.OnPropertyChanged("Received");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Received;
        partial void OnReceivedChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnReceivedChanged();
        /// <summary>
        /// There are no comments for Property Read in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Read")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Read
        {
            get
            {
                return this._Read;
            }
            set
            {
                this.OnReadChanging(value);
                this._Read = value;
                this.OnReadChanged();
                this.OnPropertyChanged("Read");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Read;
        partial void OnReadChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnReadChanged();
        /// <summary>
        /// There are no comments for Property ReceivedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReceivedDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> ReceivedDate
        {
            get
            {
                return this._ReceivedDate;
            }
            set
            {
                this.OnReceivedDateChanging(value);
                this._ReceivedDate = value;
                this.OnReceivedDateChanged();
                this.OnPropertyChanged("ReceivedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _ReceivedDate;
        partial void OnReceivedDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnReceivedDateChanged();
        /// <summary>
        /// There are no comments for Property ReceivedTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReceivedTime")]
        public virtual global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> ReceivedTime
        {
            get
            {
                return this._ReceivedTime;
            }
            set
            {
                this.OnReceivedTimeChanging(value);
                this._ReceivedTime = value;
                this.OnReceivedTimeChanged();
                this.OnPropertyChanged("ReceivedTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> _ReceivedTime;
        partial void OnReceivedTimeChanging(global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> value);
        partial void OnReceivedTimeChanged();
        /// <summary>
        /// There are no comments for Property SentDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SentDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> SentDate
        {
            get
            {
                return this._SentDate;
            }
            set
            {
                this.OnSentDateChanging(value);
                this._SentDate = value;
                this.OnSentDateChanged();
                this.OnPropertyChanged("SentDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _SentDate;
        partial void OnSentDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnSentDateChanged();
        /// <summary>
        /// There are no comments for Property SentTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SentTime")]
        public virtual global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> SentTime
        {
            get
            {
                return this._SentTime;
            }
            set
            {
                this.OnSentTimeChanging(value);
                this._SentTime = value;
                this.OnSentTimeChanged();
                this.OnPropertyChanged("SentTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> _SentTime;
        partial void OnSentTimeChanging(global::System.Nullable<global::Microsoft.OData.Edm.TimeOfDay> value);
        partial void OnSentTimeChanged();
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
