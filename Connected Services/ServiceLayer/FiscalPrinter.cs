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
    /// There are no comments for FiscalPrinterSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalPrinterSingle")]
    public partial class FiscalPrinterSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalPrinter>
    {
        /// <summary>
        /// Initialize a new FiscalPrinterSingle object.
        /// </summary>
        public FiscalPrinterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new FiscalPrinterSingle object.
        /// </summary>
        public FiscalPrinterSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new FiscalPrinterSingle object.
        /// </summary>
        public FiscalPrinterSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<FiscalPrinter> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for POSDailySummary in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("POSDailySummary")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.POSDailySummary> POSDailySummary
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._POSDailySummary == null))
                {
                    this._POSDailySummary = Context.CreateQuery<global::SAPB1.POSDailySummary>(GetPath("POSDailySummary"));
                }
                return this._POSDailySummary;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.POSDailySummary> _POSDailySummary;
        /// <summary>
        /// There are no comments for NFModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("NFModel")]
        public virtual global::SAPB1.NFModelSingle NFModel
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._NFModel == null))
                {
                    this._NFModel = new global::SAPB1.NFModelSingle(this.Context, GetPath("NFModel"));
                }
                return this._NFModel;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.NFModelSingle _NFModel;
    }
    /// <summary>
    /// There are no comments for FiscalPrinter in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EquipmentNo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("EquipmentNo")]
    [global::Microsoft.OData.Client.EntitySet("FiscalPrinter")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalPrinter")]
    public partial class FiscalPrinter : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new FiscalPrinter object.
        /// </summary>
        /// <param name="equipmentNo">Initial value of EquipmentNo.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static FiscalPrinter CreateFiscalPrinter(string equipmentNo)
        {
            FiscalPrinter fiscalPrinter = new FiscalPrinter();
            fiscalPrinter.EquipmentNo = equipmentNo;
            return fiscalPrinter;
        }
        /// <summary>
        /// There are no comments for Property EquipmentNo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EquipmentNo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "EquipmentNo is required.")]
        public virtual string EquipmentNo
        {
            get
            {
                return this._EquipmentNo;
            }
            set
            {
                this.OnEquipmentNoChanging(value);
                this._EquipmentNo = value;
                this.OnEquipmentNoChanged();
                this.OnPropertyChanged("EquipmentNo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EquipmentNo;
        partial void OnEquipmentNoChanging(string value);
        partial void OnEquipmentNoChanged();
        /// <summary>
        /// There are no comments for Property Model in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Model")]
        public virtual string Model
        {
            get
            {
                return this._Model;
            }
            set
            {
                this.OnModelChanging(value);
                this._Model = value;
                this.OnModelChanged();
                this.OnPropertyChanged("Model");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Model;
        partial void OnModelChanging(string value);
        partial void OnModelChanged();
        /// <summary>
        /// There are no comments for Property ManufacturerSerialN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ManufacturerSerialN")]
        public virtual string ManufacturerSerialN
        {
            get
            {
                return this._ManufacturerSerialN;
            }
            set
            {
                this.OnManufacturerSerialNChanging(value);
                this._ManufacturerSerialN = value;
                this.OnManufacturerSerialNChanged();
                this.OnPropertyChanged("ManufacturerSerialN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ManufacturerSerialN;
        partial void OnManufacturerSerialNChanging(string value);
        partial void OnManufacturerSerialNChanged();
        /// <summary>
        /// There are no comments for Property RegisterNo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RegisterNo")]
        public virtual global::System.Nullable<int> RegisterNo
        {
            get
            {
                return this._RegisterNo;
            }
            set
            {
                this.OnRegisterNoChanging(value);
                this._RegisterNo = value;
                this.OnRegisterNoChanged();
                this.OnPropertyChanged("RegisterNo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _RegisterNo;
        partial void OnRegisterNoChanging(global::System.Nullable<int> value);
        partial void OnRegisterNoChanged();
        /// <summary>
        /// There are no comments for Property FiscalDocumentModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalDocumentModel")]
        public virtual string FiscalDocumentModel
        {
            get
            {
                return this._FiscalDocumentModel;
            }
            set
            {
                this.OnFiscalDocumentModelChanging(value);
                this._FiscalDocumentModel = value;
                this.OnFiscalDocumentModelChanged();
                this.OnPropertyChanged("FiscalDocumentModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FiscalDocumentModel;
        partial void OnFiscalDocumentModelChanging(string value);
        partial void OnFiscalDocumentModelChanged();
        /// <summary>
        /// There are no comments for Property FiscalPrintersParams in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FiscalPrintersParams")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.FiscalPrinterParams> FiscalPrintersParams
        {
            get
            {
                return this._FiscalPrintersParams;
            }
            set
            {
                this.OnFiscalPrintersParamsChanging(value);
                this._FiscalPrintersParams = value;
                this.OnFiscalPrintersParamsChanged();
                this.OnPropertyChanged("FiscalPrintersParams");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.FiscalPrinterParams> _FiscalPrintersParams = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.FiscalPrinterParams>();
        partial void OnFiscalPrintersParamsChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.FiscalPrinterParams> value);
        partial void OnFiscalPrintersParamsChanged();
        /// <summary>
        /// There are no comments for Property POSDailySummary in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("POSDailySummary")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.POSDailySummary> POSDailySummary
        {
            get
            {
                return this._POSDailySummary;
            }
            set
            {
                this.OnPOSDailySummaryChanging(value);
                this._POSDailySummary = value;
                this.OnPOSDailySummaryChanged();
                this.OnPropertyChanged("POSDailySummary");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.POSDailySummary> _POSDailySummary = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.POSDailySummary>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPOSDailySummaryChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.POSDailySummary> value);
        partial void OnPOSDailySummaryChanged();
        /// <summary>
        /// There are no comments for Property NFModel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NFModel")]
        public virtual global::SAPB1.NFModel NFModel
        {
            get
            {
                return this._NFModel;
            }
            set
            {
                this.OnNFModelChanging(value);
                this._NFModel = value;
                this.OnNFModelChanged();
                this.OnPropertyChanged("NFModel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.NFModel _NFModel;
        partial void OnNFModelChanging(global::SAPB1.NFModel value);
        partial void OnNFModelChanged();
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
