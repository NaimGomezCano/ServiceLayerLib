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
    /// There are no comments for PredefinedTextSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("PredefinedTextSingle")]
    public partial class PredefinedTextSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<PredefinedText>
    {
        /// <summary>
        /// Initialize a new PredefinedTextSingle object.
        /// </summary>
        public PredefinedTextSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new PredefinedTextSingle object.
        /// </summary>
        public PredefinedTextSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new PredefinedTextSingle object.
        /// </summary>
        public PredefinedTextSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<PredefinedText> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for PredefinedText in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Numerator
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Numerator")]
    [global::Microsoft.OData.Client.EntitySet("PredefinedTexts")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("PredefinedText")]
    public partial class PredefinedText : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new PredefinedText object.
        /// </summary>
        /// <param name="numerator">Initial value of Numerator.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static PredefinedText CreatePredefinedText(int numerator)
        {
            PredefinedText predefinedText = new PredefinedText();
            predefinedText.Numerator = numerator;
            return predefinedText;
        }
        /// <summary>
        /// There are no comments for Property Numerator in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Numerator")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Numerator is required.")]
        public virtual int Numerator
        {
            get
            {
                return this._Numerator;
            }
            set
            {
                this.OnNumeratorChanging(value);
                this._Numerator = value;
                this.OnNumeratorChanged();
                this.OnPropertyChanged("Numerator");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Numerator;
        partial void OnNumeratorChanging(int value);
        partial void OnNumeratorChanged();
        /// <summary>
        /// There are no comments for Property TextCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TextCode")]
        public virtual string TextCode
        {
            get
            {
                return this._TextCode;
            }
            set
            {
                this.OnTextCodeChanging(value);
                this._TextCode = value;
                this.OnTextCodeChanged();
                this.OnPropertyChanged("TextCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TextCode;
        partial void OnTextCodeChanging(string value);
        partial void OnTextCodeChanged();
        /// <summary>
        /// There are no comments for Property Text in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Text")]
        public virtual string Text
        {
            get
            {
                return this._Text;
            }
            set
            {
                this.OnTextChanging(value);
                this._Text = value;
                this.OnTextChanged();
                this.OnPropertyChanged("Text");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Text;
        partial void OnTextChanging(string value);
        partial void OnTextChanged();
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
