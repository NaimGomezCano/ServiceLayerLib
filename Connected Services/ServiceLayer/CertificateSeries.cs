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
    /// There are no comments for CertificateSeriesSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CertificateSeriesSingle")]
    public partial class CertificateSeriesSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CertificateSeries>
    {
        /// <summary>
        /// Initialize a new CertificateSeriesSingle object.
        /// </summary>
        public CertificateSeriesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CertificateSeriesSingle object.
        /// </summary>
        public CertificateSeriesSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CertificateSeriesSingle object.
        /// </summary>
        public CertificateSeriesSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CertificateSeries> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Section2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Section2")]
        public virtual global::SAPB1.SectionSingle Section2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Section2 == null))
                {
                    this._Section2 = new global::SAPB1.SectionSingle(this.Context, GetPath("Section2"));
                }
                return this._Section2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.SectionSingle _Section2;
        /// <summary>
        /// There are no comments for WarehouseLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseLocation")]
        public virtual global::SAPB1.WarehouseLocationSingle WarehouseLocation
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WarehouseLocation == null))
                {
                    this._WarehouseLocation = new global::SAPB1.WarehouseLocationSingle(this.Context, GetPath("WarehouseLocation"));
                }
                return this._WarehouseLocation;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.WarehouseLocationSingle _WarehouseLocation;
    }
    /// <summary>
    /// There are no comments for CertificateSeries in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AbsEntry
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AbsEntry")]
    [global::Microsoft.OData.Client.EntitySet("CertificateSeries")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CertificateSeries")]
    public partial class CertificateSeries : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new CertificateSeries object.
        /// </summary>
        /// <param name="absEntry">Initial value of AbsEntry.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static CertificateSeries CreateCertificateSeries(int absEntry)
        {
            CertificateSeries certificateSeries = new CertificateSeries();
            certificateSeries.AbsEntry = absEntry;
            return certificateSeries;
        }
        /// <summary>
        /// There are no comments for Property AbsEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AbsEntry")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AbsEntry is required.")]
        public virtual int AbsEntry
        {
            get
            {
                return this._AbsEntry;
            }
            set
            {
                this.OnAbsEntryChanging(value);
                this._AbsEntry = value;
                this.OnAbsEntryChanged();
                this.OnPropertyChanged("AbsEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _AbsEntry;
        partial void OnAbsEntryChanging(int value);
        partial void OnAbsEntryChanged();
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        public virtual string Code
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
        private string _Code;
        partial void OnCodeChanging(string value);
        partial void OnCodeChanged();
        /// <summary>
        /// There are no comments for Property Section in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Section")]
        public virtual global::System.Nullable<int> Section
        {
            get
            {
                return this._Section;
            }
            set
            {
                this.OnSectionChanging(value);
                this._Section = value;
                this.OnSectionChanged();
                this.OnPropertyChanged("Section");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Section;
        partial void OnSectionChanging(global::System.Nullable<int> value);
        partial void OnSectionChanged();
        /// <summary>
        /// There are no comments for Property Location in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Location")]
        public virtual global::System.Nullable<int> Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this.OnLocationChanging(value);
                this._Location = value;
                this.OnLocationChanged();
                this.OnPropertyChanged("Location");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Location;
        partial void OnLocationChanging(global::System.Nullable<int> value);
        partial void OnLocationChanged();
        /// <summary>
        /// There are no comments for Property DefaultSeries in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DefaultSeries")]
        public virtual global::System.Nullable<int> DefaultSeries
        {
            get
            {
                return this._DefaultSeries;
            }
            set
            {
                this.OnDefaultSeriesChanging(value);
                this._DefaultSeries = value;
                this.OnDefaultSeriesChanged();
                this.OnPropertyChanged("DefaultSeries");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DefaultSeries;
        partial void OnDefaultSeriesChanging(global::System.Nullable<int> value);
        partial void OnDefaultSeriesChanged();
        /// <summary>
        /// There are no comments for Property SeriesLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SeriesLines")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.SeriesLine> SeriesLines
        {
            get
            {
                return this._SeriesLines;
            }
            set
            {
                this.OnSeriesLinesChanging(value);
                this._SeriesLines = value;
                this.OnSeriesLinesChanged();
                this.OnPropertyChanged("SeriesLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.SeriesLine> _SeriesLines = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.SeriesLine>();
        partial void OnSeriesLinesChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.SeriesLine> value);
        partial void OnSeriesLinesChanged();
        /// <summary>
        /// There are no comments for Property Section2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Section2")]
        public virtual global::SAPB1.Section Section2
        {
            get
            {
                return this._Section2;
            }
            set
            {
                this.OnSection2Changing(value);
                this._Section2 = value;
                this.OnSection2Changed();
                this.OnPropertyChanged("Section2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.Section _Section2;
        partial void OnSection2Changing(global::SAPB1.Section value);
        partial void OnSection2Changed();
        /// <summary>
        /// There are no comments for Property WarehouseLocation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WarehouseLocation")]
        public virtual global::SAPB1.WarehouseLocation WarehouseLocation
        {
            get
            {
                return this._WarehouseLocation;
            }
            set
            {
                this.OnWarehouseLocationChanging(value);
                this._WarehouseLocation = value;
                this.OnWarehouseLocationChanged();
                this.OnPropertyChanged("WarehouseLocation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.WarehouseLocation _WarehouseLocation;
        partial void OnWarehouseLocationChanging(global::SAPB1.WarehouseLocation value);
        partial void OnWarehouseLocationChanged();
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