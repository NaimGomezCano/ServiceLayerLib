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
    /// There are no comments for Recipient in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("Recipient")]
    public partial class Recipient : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property UserCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserCode")]
        public virtual string UserCode
        {
            get
            {
                return this._UserCode;
            }
            set
            {
                this.OnUserCodeChanging(value);
                this._UserCode = value;
                this.OnUserCodeChanged();
                this.OnPropertyChanged("UserCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _UserCode;
        partial void OnUserCodeChanging(string value);
        partial void OnUserCodeChanged();
        /// <summary>
        /// There are no comments for Property UserType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserType")]
        public virtual global::System.Nullable<global::SAPB1.BoMsgRcpTypes> UserType
        {
            get
            {
                return this._UserType;
            }
            set
            {
                this.OnUserTypeChanging(value);
                this._UserType = value;
                this.OnUserTypeChanged();
                this.OnPropertyChanged("UserType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoMsgRcpTypes> _UserType;
        partial void OnUserTypeChanging(global::System.Nullable<global::SAPB1.BoMsgRcpTypes> value);
        partial void OnUserTypeChanged();
        /// <summary>
        /// There are no comments for Property NameTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NameTo")]
        public virtual string NameTo
        {
            get
            {
                return this._NameTo;
            }
            set
            {
                this.OnNameToChanging(value);
                this._NameTo = value;
                this.OnNameToChanged();
                this.OnPropertyChanged("NameTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NameTo;
        partial void OnNameToChanging(string value);
        partial void OnNameToChanged();
        /// <summary>
        /// There are no comments for Property SendEmail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SendEmail")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> SendEmail
        {
            get
            {
                return this._SendEmail;
            }
            set
            {
                this.OnSendEmailChanging(value);
                this._SendEmail = value;
                this.OnSendEmailChanged();
                this.OnPropertyChanged("SendEmail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _SendEmail;
        partial void OnSendEmailChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnSendEmailChanged();
        /// <summary>
        /// There are no comments for Property EmailAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EmailAddress")]
        public virtual string EmailAddress
        {
            get
            {
                return this._EmailAddress;
            }
            set
            {
                this.OnEmailAddressChanging(value);
                this._EmailAddress = value;
                this.OnEmailAddressChanged();
                this.OnPropertyChanged("EmailAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EmailAddress;
        partial void OnEmailAddressChanging(string value);
        partial void OnEmailAddressChanged();
        /// <summary>
        /// There are no comments for Property SendSMS in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SendSMS")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> SendSMS
        {
            get
            {
                return this._SendSMS;
            }
            set
            {
                this.OnSendSMSChanging(value);
                this._SendSMS = value;
                this.OnSendSMSChanged();
                this.OnPropertyChanged("SendSMS");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _SendSMS;
        partial void OnSendSMSChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnSendSMSChanged();
        /// <summary>
        /// There are no comments for Property CellularNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CellularNumber")]
        public virtual string CellularNumber
        {
            get
            {
                return this._CellularNumber;
            }
            set
            {
                this.OnCellularNumberChanging(value);
                this._CellularNumber = value;
                this.OnCellularNumberChanged();
                this.OnPropertyChanged("CellularNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CellularNumber;
        partial void OnCellularNumberChanging(string value);
        partial void OnCellularNumberChanged();
        /// <summary>
        /// There are no comments for Property SendFax in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SendFax")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> SendFax
        {
            get
            {
                return this._SendFax;
            }
            set
            {
                this.OnSendFaxChanging(value);
                this._SendFax = value;
                this.OnSendFaxChanged();
                this.OnPropertyChanged("SendFax");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _SendFax;
        partial void OnSendFaxChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnSendFaxChanged();
        /// <summary>
        /// There are no comments for Property FaxNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FaxNumber")]
        public virtual string FaxNumber
        {
            get
            {
                return this._FaxNumber;
            }
            set
            {
                this.OnFaxNumberChanging(value);
                this._FaxNumber = value;
                this.OnFaxNumberChanged();
                this.OnPropertyChanged("FaxNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FaxNumber;
        partial void OnFaxNumberChanging(string value);
        partial void OnFaxNumberChanged();
        /// <summary>
        /// There are no comments for Property SendInternal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SendInternal")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> SendInternal
        {
            get
            {
                return this._SendInternal;
            }
            set
            {
                this.OnSendInternalChanging(value);
                this._SendInternal = value;
                this.OnSendInternalChanged();
                this.OnPropertyChanged("SendInternal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _SendInternal;
        partial void OnSendInternalChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnSendInternalChanged();
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
