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
    /// There are no comments for SingleUserConnectionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SingleUserConnectionSingle")]
    public partial class SingleUserConnectionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SingleUserConnection>
    {
        /// <summary>
        /// Initialize a new SingleUserConnectionSingle object.
        /// </summary>
        public SingleUserConnectionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SingleUserConnectionSingle object.
        /// </summary>
        public SingleUserConnectionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SingleUserConnectionSingle object.
        /// </summary>
        public SingleUserConnectionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SingleUserConnection> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SingleUserConnection in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Code
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Code")]
    [global::Microsoft.OData.Client.EntitySet("SingleUserConnections")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SingleUserConnection")]
    public partial class SingleUserConnection : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SingleUserConnection object.
        /// </summary>
        /// <param name="code">Initial value of Code.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SingleUserConnection CreateSingleUserConnection(int code)
        {
            SingleUserConnection singleUserConnection = new SingleUserConnection();
            singleUserConnection.Code = code;
            return singleUserConnection;
        }
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Code is required.")]
        public virtual int Code
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
        private int _Code;
        partial void OnCodeChanging(int value);
        partial void OnCodeChanged();
        /// <summary>
        /// There are no comments for Property Action in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Action")]
        public virtual global::System.Nullable<global::SAPB1.SingleUserConnectionActionEnum> Action
        {
            get
            {
                return this._Action;
            }
            set
            {
                this.OnActionChanging(value);
                this._Action = value;
                this.OnActionChanged();
                this.OnPropertyChanged("Action");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.SingleUserConnectionActionEnum> _Action;
        partial void OnActionChanging(global::System.Nullable<global::SAPB1.SingleUserConnectionActionEnum> value);
        partial void OnActionChanged();
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
