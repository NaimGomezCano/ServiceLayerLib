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
    /// There are no comments for ElectronicFileFormatSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ElectronicFileFormatSingle")]
    public partial class ElectronicFileFormatSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ElectronicFileFormat>
    {
        /// <summary>
        /// Initialize a new ElectronicFileFormatSingle object.
        /// </summary>
        public ElectronicFileFormatSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ElectronicFileFormatSingle object.
        /// </summary>
        public ElectronicFileFormatSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ElectronicFileFormatSingle object.
        /// </summary>
        public ElectronicFileFormatSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ElectronicFileFormat> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for ExportDeterminations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ExportDeterminations")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.ExportDetermination> ExportDeterminations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ExportDeterminations == null))
                {
                    this._ExportDeterminations = Context.CreateQuery<global::SAPB1.ExportDetermination>(GetPath("ExportDeterminations"));
                }
                return this._ExportDeterminations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.ExportDetermination> _ExportDeterminations;
        /// <summary>
        /// There are no comments for ImportDeterminations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ImportDeterminations")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.ImportDetermination> ImportDeterminations
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ImportDeterminations == null))
                {
                    this._ImportDeterminations = Context.CreateQuery<global::SAPB1.ImportDetermination>(GetPath("ImportDeterminations"));
                }
                return this._ImportDeterminations;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.ImportDetermination> _ImportDeterminations;
    }
    /// <summary>
    /// There are no comments for ElectronicFileFormat in the schema.
    /// </summary>
    /// <KeyProperties>
    /// FormatID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("FormatID")]
    [global::Microsoft.OData.Client.EntitySet("ElectronicFileFormats")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ElectronicFileFormat")]
    public partial class ElectronicFileFormat : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ElectronicFileFormat object.
        /// </summary>
        /// <param name="formatID">Initial value of FormatID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ElectronicFileFormat CreateElectronicFileFormat(int formatID)
        {
            ElectronicFileFormat electronicFileFormat = new ElectronicFileFormat();
            electronicFileFormat.FormatID = formatID;
            return electronicFileFormat;
        }
        /// <summary>
        /// There are no comments for Property FormatID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FormatID")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "FormatID is required.")]
        public virtual int FormatID
        {
            get
            {
                return this._FormatID;
            }
            set
            {
                this.OnFormatIDChanging(value);
                this._FormatID = value;
                this.OnFormatIDChanged();
                this.OnPropertyChanged("FormatID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _FormatID;
        partial void OnFormatIDChanging(int value);
        partial void OnFormatIDChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Description")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Version")]
        public virtual string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("Version");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property SchemaVersion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SchemaVersion")]
        public virtual string SchemaVersion
        {
            get
            {
                return this._SchemaVersion;
            }
            set
            {
                this.OnSchemaVersionChanging(value);
                this._SchemaVersion = value;
                this.OnSchemaVersionChanged();
                this.OnPropertyChanged("SchemaVersion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SchemaVersion;
        partial void OnSchemaVersionChanging(string value);
        partial void OnSchemaVersionChanged();
        /// <summary>
        /// There are no comments for Property OutputFilePath in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OutputFilePath")]
        public virtual string OutputFilePath
        {
            get
            {
                return this._OutputFilePath;
            }
            set
            {
                this.OnOutputFilePathChanging(value);
                this._OutputFilePath = value;
                this.OnOutputFilePathChanged();
                this.OnPropertyChanged("OutputFilePath");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OutputFilePath;
        partial void OnOutputFilePathChanging(string value);
        partial void OnOutputFilePathChanged();
        /// <summary>
        /// There are no comments for Property MenuName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MenuName")]
        public virtual string MenuName
        {
            get
            {
                return this._MenuName;
            }
            set
            {
                this.OnMenuNameChanging(value);
                this._MenuName = value;
                this.OnMenuNameChanged();
                this.OnPropertyChanged("MenuName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MenuName;
        partial void OnMenuNameChanging(string value);
        partial void OnMenuNameChanged();
        /// <summary>
        /// There are no comments for Property MenuPath in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MenuPath")]
        public virtual string MenuPath
        {
            get
            {
                return this._MenuPath;
            }
            set
            {
                this.OnMenuPathChanging(value);
                this._MenuPath = value;
                this.OnMenuPathChanged();
                this.OnPropertyChanged("MenuPath");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MenuPath;
        partial void OnMenuPathChanging(string value);
        partial void OnMenuPathChanged();
        /// <summary>
        /// There are no comments for Property ExportDeterminations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExportDeterminations")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ExportDetermination> ExportDeterminations
        {
            get
            {
                return this._ExportDeterminations;
            }
            set
            {
                this.OnExportDeterminationsChanging(value);
                this._ExportDeterminations = value;
                this.OnExportDeterminationsChanged();
                this.OnPropertyChanged("ExportDeterminations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ExportDetermination> _ExportDeterminations = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ExportDetermination>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnExportDeterminationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ExportDetermination> value);
        partial void OnExportDeterminationsChanged();
        /// <summary>
        /// There are no comments for Property ImportDeterminations in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ImportDeterminations")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ImportDetermination> ImportDeterminations
        {
            get
            {
                return this._ImportDeterminations;
            }
            set
            {
                this.OnImportDeterminationsChanging(value);
                this._ImportDeterminations = value;
                this.OnImportDeterminationsChanged();
                this.OnPropertyChanged("ImportDeterminations");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ImportDetermination> _ImportDeterminations = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ImportDetermination>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnImportDeterminationsChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.ImportDetermination> value);
        partial void OnImportDeterminationsChanged();
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