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
    /// There are no comments for TrackingNoteSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("TrackingNoteSingle")]
    public partial class TrackingNoteSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TrackingNote>
    {
        /// <summary>
        /// Initialize a new TrackingNoteSingle object.
        /// </summary>
        public TrackingNoteSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TrackingNoteSingle object.
        /// </summary>
        public TrackingNoteSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TrackingNoteSingle object.
        /// </summary>
        public TrackingNoteSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TrackingNote> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for TrackingNote in the schema.
    /// </summary>
    /// <KeyProperties>
    /// TrackingNoteNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TrackingNoteNumber")]
    [global::Microsoft.OData.Client.EntitySet("TrackingNotes")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("TrackingNote")]
    public partial class TrackingNote : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TrackingNote object.
        /// </summary>
        /// <param name="trackingNoteNumber">Initial value of TrackingNoteNumber.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TrackingNote CreateTrackingNote(int trackingNoteNumber)
        {
            TrackingNote trackingNote = new TrackingNote();
            trackingNote.TrackingNoteNumber = trackingNoteNumber;
            return trackingNote;
        }
        /// <summary>
        /// There are no comments for Property TrackingNoteNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TrackingNoteNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TrackingNoteNumber is required.")]
        public virtual int TrackingNoteNumber
        {
            get
            {
                return this._TrackingNoteNumber;
            }
            set
            {
                this.OnTrackingNoteNumberChanging(value);
                this._TrackingNoteNumber = value;
                this.OnTrackingNoteNumberChanged();
                this.OnPropertyChanged("TrackingNoteNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _TrackingNoteNumber;
        partial void OnTrackingNoteNumberChanging(int value);
        partial void OnTrackingNoteNumberChanged();
        /// <summary>
        /// There are no comments for Property CCDNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CCDNumber")]
        public virtual string CCDNumber
        {
            get
            {
                return this._CCDNumber;
            }
            set
            {
                this.OnCCDNumberChanging(value);
                this._CCDNumber = value;
                this.OnCCDNumberChanged();
                this.OnPropertyChanged("CCDNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CCDNumber;
        partial void OnCCDNumberChanging(string value);
        partial void OnCCDNumberChanged();
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
        /// There are no comments for Property CustomsTerminal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CustomsTerminal")]
        public virtual string CustomsTerminal
        {
            get
            {
                return this._CustomsTerminal;
            }
            set
            {
                this.OnCustomsTerminalChanging(value);
                this._CustomsTerminal = value;
                this.OnCustomsTerminalChanged();
                this.OnPropertyChanged("CustomsTerminal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CustomsTerminal;
        partial void OnCustomsTerminalChanging(string value);
        partial void OnCustomsTerminalChanged();
        /// <summary>
        /// There are no comments for Property CountryOfOrigin in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CountryOfOrigin")]
        public virtual string CountryOfOrigin
        {
            get
            {
                return this._CountryOfOrigin;
            }
            set
            {
                this.OnCountryOfOriginChanging(value);
                this._CountryOfOrigin = value;
                this.OnCountryOfOriginChanged();
                this.OnPropertyChanged("CountryOfOrigin");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CountryOfOrigin;
        partial void OnCountryOfOriginChanging(string value);
        partial void OnCountryOfOriginChanged();
        /// <summary>
        /// There are no comments for Property IsDirectImport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDirectImport")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IsDirectImport
        {
            get
            {
                return this._IsDirectImport;
            }
            set
            {
                this.OnIsDirectImportChanging(value);
                this._IsDirectImport = value;
                this.OnIsDirectImportChanged();
                this.OnPropertyChanged("IsDirectImport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IsDirectImport;
        partial void OnIsDirectImportChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIsDirectImportChanged();
        /// <summary>
        /// There are no comments for Property TrackingNoteItemCollection in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TrackingNoteItemCollection")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.TrackingNoteItem> TrackingNoteItemCollection
        {
            get
            {
                return this._TrackingNoteItemCollection;
            }
            set
            {
                this.OnTrackingNoteItemCollectionChanging(value);
                this._TrackingNoteItemCollection = value;
                this.OnTrackingNoteItemCollectionChanged();
                this.OnPropertyChanged("TrackingNoteItemCollection");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.TrackingNoteItem> _TrackingNoteItemCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.TrackingNoteItem>();
        partial void OnTrackingNoteItemCollectionChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.TrackingNoteItem> value);
        partial void OnTrackingNoteItemCollectionChanged();
        /// <summary>
        /// There are no comments for Property TrackingNoteBrokerCollection in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TrackingNoteBrokerCollection")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.TrackingNoteBroker> TrackingNoteBrokerCollection
        {
            get
            {
                return this._TrackingNoteBrokerCollection;
            }
            set
            {
                this.OnTrackingNoteBrokerCollectionChanging(value);
                this._TrackingNoteBrokerCollection = value;
                this.OnTrackingNoteBrokerCollectionChanged();
                this.OnPropertyChanged("TrackingNoteBrokerCollection");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.TrackingNoteBroker> _TrackingNoteBrokerCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.TrackingNoteBroker>();
        partial void OnTrackingNoteBrokerCollectionChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.TrackingNoteBroker> value);
        partial void OnTrackingNoteBrokerCollectionChanged();
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
