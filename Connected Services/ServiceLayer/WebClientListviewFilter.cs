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
    /// There are no comments for WebClientListviewFilterSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("WebClientListviewFilterSingle")]
    public partial class WebClientListviewFilterSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<WebClientListviewFilter>
    {
        /// <summary>
        /// Initialize a new WebClientListviewFilterSingle object.
        /// </summary>
        public WebClientListviewFilterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new WebClientListviewFilterSingle object.
        /// </summary>
        public WebClientListviewFilterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new WebClientListviewFilterSingle object.
        /// </summary>
        public WebClientListviewFilterSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<WebClientListviewFilter> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for WebClientListviewFilter in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Guid
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Guid")]
    [global::Microsoft.OData.Client.EntitySet("WebClientListviewFilters")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("WebClientListviewFilter")]
    public partial class WebClientListviewFilter : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new WebClientListviewFilter object.
        /// </summary>
        /// <param name="guid">Initial value of Guid.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static WebClientListviewFilter CreateWebClientListviewFilter(string guid)
        {
            WebClientListviewFilter webClientListviewFilter = new WebClientListviewFilter();
            webClientListviewFilter.Guid = guid;
            return webClientListviewFilter;
        }
        /// <summary>
        /// There are no comments for Property Guid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Guid")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Guid is required.")]
        public virtual string Guid
        {
            get
            {
                return this._Guid;
            }
            set
            {
                this.OnGuidChanging(value);
                this._Guid = value;
                this.OnGuidChanged();
                this.OnPropertyChanged("Guid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Guid;
        partial void OnGuidChanging(string value);
        partial void OnGuidChanged();
        /// <summary>
        /// There are no comments for Property UserId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("UserId")]
        public virtual global::System.Nullable<int> UserId
        {
            get
            {
                return this._UserId;
            }
            set
            {
                this.OnUserIdChanging(value);
                this._UserId = value;
                this.OnUserIdChanged();
                this.OnPropertyChanged("UserId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _UserId;
        partial void OnUserIdChanging(global::System.Nullable<int> value);
        partial void OnUserIdChanged();
        /// <summary>
        /// There are no comments for Property TableName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TableName")]
        public virtual string TableName
        {
            get
            {
                return this._TableName;
            }
            set
            {
                this.OnTableNameChanging(value);
                this._TableName = value;
                this.OnTableNameChanged();
                this.OnPropertyChanged("TableName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TableName;
        partial void OnTableNameChanging(string value);
        partial void OnTableNameChanged();
        /// <summary>
        /// There are no comments for Property FilterName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FilterName")]
        public virtual string FilterName
        {
            get
            {
                return this._FilterName;
            }
            set
            {
                this.OnFilterNameChanging(value);
                this._FilterName = value;
                this.OnFilterNameChanged();
                this.OnPropertyChanged("FilterName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FilterName;
        partial void OnFilterNameChanging(string value);
        partial void OnFilterNameChanged();
        /// <summary>
        /// There are no comments for Property WebClientListviewFilterConditions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WebClientListviewFilterConditions")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.WebClientListviewFilterCondition> WebClientListviewFilterConditions
        {
            get
            {
                return this._WebClientListviewFilterConditions;
            }
            set
            {
                this.OnWebClientListviewFilterConditionsChanging(value);
                this._WebClientListviewFilterConditions = value;
                this.OnWebClientListviewFilterConditionsChanged();
                this.OnPropertyChanged("WebClientListviewFilterConditions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.WebClientListviewFilterCondition> _WebClientListviewFilterConditions = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.WebClientListviewFilterCondition>();
        partial void OnWebClientListviewFilterConditionsChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.WebClientListviewFilterCondition> value);
        partial void OnWebClientListviewFilterConditionsChanged();
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