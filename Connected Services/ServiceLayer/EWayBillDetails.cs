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
    /// There are no comments for EWayBillDetails in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EWayBillDetails")]
    public partial class EWayBillDetails : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property DocEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocEntry")]
        public virtual global::System.Nullable<int> DocEntry
        {
            get
            {
                return this._DocEntry;
            }
            set
            {
                this.OnDocEntryChanging(value);
                this._DocEntry = value;
                this.OnDocEntryChanged();
                this.OnPropertyChanged("DocEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DocEntry;
        partial void OnDocEntryChanging(global::System.Nullable<int> value);
        partial void OnDocEntryChanged();
        /// <summary>
        /// There are no comments for Property SupplyType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SupplyType")]
        public virtual global::System.Nullable<global::SAPB1.EWBSupplyTypeEnum> SupplyType
        {
            get
            {
                return this._SupplyType;
            }
            set
            {
                this.OnSupplyTypeChanging(value);
                this._SupplyType = value;
                this.OnSupplyTypeChanged();
                this.OnPropertyChanged("SupplyType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.EWBSupplyTypeEnum> _SupplyType;
        partial void OnSupplyTypeChanging(global::System.Nullable<global::SAPB1.EWBSupplyTypeEnum> value);
        partial void OnSupplyTypeChanged();
        /// <summary>
        /// There are no comments for Property SubType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubType")]
        public virtual global::System.Nullable<int> SubType
        {
            get
            {
                return this._SubType;
            }
            set
            {
                this.OnSubTypeChanging(value);
                this._SubType = value;
                this.OnSubTypeChanged();
                this.OnPropertyChanged("SubType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SubType;
        partial void OnSubTypeChanging(global::System.Nullable<int> value);
        partial void OnSubTypeChanged();
        /// <summary>
        /// There are no comments for Property DocumentType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentType")]
        public virtual string DocumentType
        {
            get
            {
                return this._DocumentType;
            }
            set
            {
                this.OnDocumentTypeChanging(value);
                this._DocumentType = value;
                this.OnDocumentTypeChanged();
                this.OnPropertyChanged("DocumentType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentType;
        partial void OnDocumentTypeChanging(string value);
        partial void OnDocumentTypeChanged();
        /// <summary>
        /// There are no comments for Property TransportationMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransportationMode")]
        public virtual global::System.Nullable<int> TransportationMode
        {
            get
            {
                return this._TransportationMode;
            }
            set
            {
                this.OnTransportationModeChanging(value);
                this._TransportationMode = value;
                this.OnTransportationModeChanged();
                this.OnPropertyChanged("TransportationMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _TransportationMode;
        partial void OnTransportationModeChanging(global::System.Nullable<int> value);
        partial void OnTransportationModeChanged();
        /// <summary>
        /// There are no comments for Property Distance in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Distance")]
        public virtual global::System.Nullable<double> Distance
        {
            get
            {
                return this._Distance;
            }
            set
            {
                this.OnDistanceChanging(value);
                this._Distance = value;
                this.OnDistanceChanged();
                this.OnPropertyChanged("Distance");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Distance;
        partial void OnDistanceChanging(global::System.Nullable<double> value);
        partial void OnDistanceChanged();
        /// <summary>
        /// There are no comments for Property TransporterDocNo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransporterDocNo")]
        public virtual string TransporterDocNo
        {
            get
            {
                return this._TransporterDocNo;
            }
            set
            {
                this.OnTransporterDocNoChanging(value);
                this._TransporterDocNo = value;
                this.OnTransporterDocNoChanged();
                this.OnPropertyChanged("TransporterDocNo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransporterDocNo;
        partial void OnTransporterDocNoChanging(string value);
        partial void OnTransporterDocNoChanged();
        /// <summary>
        /// There are no comments for Property TransporterDocDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransporterDocDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> TransporterDocDate
        {
            get
            {
                return this._TransporterDocDate;
            }
            set
            {
                this.OnTransporterDocDateChanging(value);
                this._TransporterDocDate = value;
                this.OnTransporterDocDateChanged();
                this.OnPropertyChanged("TransporterDocDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _TransporterDocDate;
        partial void OnTransporterDocDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnTransporterDocDateChanged();
        /// <summary>
        /// There are no comments for Property VehicleType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VehicleType")]
        public virtual string VehicleType
        {
            get
            {
                return this._VehicleType;
            }
            set
            {
                this.OnVehicleTypeChanging(value);
                this._VehicleType = value;
                this.OnVehicleTypeChanged();
                this.OnPropertyChanged("VehicleType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VehicleType;
        partial void OnVehicleTypeChanging(string value);
        partial void OnVehicleTypeChanged();
        /// <summary>
        /// There are no comments for Property VehicleNo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("VehicleNo")]
        public virtual string VehicleNo
        {
            get
            {
                return this._VehicleNo;
            }
            set
            {
                this.OnVehicleNoChanging(value);
                this._VehicleNo = value;
                this.OnVehicleNoChanged();
                this.OnPropertyChanged("VehicleNo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _VehicleNo;
        partial void OnVehicleNoChanging(string value);
        partial void OnVehicleNoChanged();
        /// <summary>
        /// There are no comments for Property EWayBillNo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EWayBillNo")]
        public virtual string EWayBillNo
        {
            get
            {
                return this._EWayBillNo;
            }
            set
            {
                this.OnEWayBillNoChanging(value);
                this._EWayBillNo = value;
                this.OnEWayBillNoChanged();
                this.OnPropertyChanged("EWayBillNo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EWayBillNo;
        partial void OnEWayBillNoChanging(string value);
        partial void OnEWayBillNoChanged();
        /// <summary>
        /// There are no comments for Property EWayBillDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EWayBillDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> EWayBillDate
        {
            get
            {
                return this._EWayBillDate;
            }
            set
            {
                this.OnEWayBillDateChanging(value);
                this._EWayBillDate = value;
                this.OnEWayBillDateChanged();
                this.OnPropertyChanged("EWayBillDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _EWayBillDate;
        partial void OnEWayBillDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnEWayBillDateChanged();
        /// <summary>
        /// There are no comments for Property BillFromName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillFromName")]
        public virtual string BillFromName
        {
            get
            {
                return this._BillFromName;
            }
            set
            {
                this.OnBillFromNameChanging(value);
                this._BillFromName = value;
                this.OnBillFromNameChanged();
                this.OnPropertyChanged("BillFromName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillFromName;
        partial void OnBillFromNameChanging(string value);
        partial void OnBillFromNameChanged();
        /// <summary>
        /// There are no comments for Property BillFromGSTIN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillFromGSTIN")]
        public virtual string BillFromGSTIN
        {
            get
            {
                return this._BillFromGSTIN;
            }
            set
            {
                this.OnBillFromGSTINChanging(value);
                this._BillFromGSTIN = value;
                this.OnBillFromGSTINChanged();
                this.OnPropertyChanged("BillFromGSTIN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillFromGSTIN;
        partial void OnBillFromGSTINChanging(string value);
        partial void OnBillFromGSTINChanged();
        /// <summary>
        /// There are no comments for Property BillFromStateGSTCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillFromStateGSTCode")]
        public virtual string BillFromStateGSTCode
        {
            get
            {
                return this._BillFromStateGSTCode;
            }
            set
            {
                this.OnBillFromStateGSTCodeChanging(value);
                this._BillFromStateGSTCode = value;
                this.OnBillFromStateGSTCodeChanged();
                this.OnPropertyChanged("BillFromStateGSTCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillFromStateGSTCode;
        partial void OnBillFromStateGSTCodeChanging(string value);
        partial void OnBillFromStateGSTCodeChanged();
        /// <summary>
        /// There are no comments for Property DispatchFromAddress1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DispatchFromAddress1")]
        public virtual string DispatchFromAddress1
        {
            get
            {
                return this._DispatchFromAddress1;
            }
            set
            {
                this.OnDispatchFromAddress1Changing(value);
                this._DispatchFromAddress1 = value;
                this.OnDispatchFromAddress1Changed();
                this.OnPropertyChanged("DispatchFromAddress1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DispatchFromAddress1;
        partial void OnDispatchFromAddress1Changing(string value);
        partial void OnDispatchFromAddress1Changed();
        /// <summary>
        /// There are no comments for Property DispatchFromAddress2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DispatchFromAddress2")]
        public virtual string DispatchFromAddress2
        {
            get
            {
                return this._DispatchFromAddress2;
            }
            set
            {
                this.OnDispatchFromAddress2Changing(value);
                this._DispatchFromAddress2 = value;
                this.OnDispatchFromAddress2Changed();
                this.OnPropertyChanged("DispatchFromAddress2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DispatchFromAddress2;
        partial void OnDispatchFromAddress2Changing(string value);
        partial void OnDispatchFromAddress2Changed();
        /// <summary>
        /// There are no comments for Property DispatchFromZipCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DispatchFromZipCode")]
        public virtual string DispatchFromZipCode
        {
            get
            {
                return this._DispatchFromZipCode;
            }
            set
            {
                this.OnDispatchFromZipCodeChanging(value);
                this._DispatchFromZipCode = value;
                this.OnDispatchFromZipCodeChanged();
                this.OnPropertyChanged("DispatchFromZipCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DispatchFromZipCode;
        partial void OnDispatchFromZipCodeChanging(string value);
        partial void OnDispatchFromZipCodeChanged();
        /// <summary>
        /// There are no comments for Property DispatchFromStateGSTCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DispatchFromStateGSTCode")]
        public virtual string DispatchFromStateGSTCode
        {
            get
            {
                return this._DispatchFromStateGSTCode;
            }
            set
            {
                this.OnDispatchFromStateGSTCodeChanging(value);
                this._DispatchFromStateGSTCode = value;
                this.OnDispatchFromStateGSTCodeChanged();
                this.OnPropertyChanged("DispatchFromStateGSTCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DispatchFromStateGSTCode;
        partial void OnDispatchFromStateGSTCodeChanging(string value);
        partial void OnDispatchFromStateGSTCodeChanged();
        /// <summary>
        /// There are no comments for Property BillToName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillToName")]
        public virtual string BillToName
        {
            get
            {
                return this._BillToName;
            }
            set
            {
                this.OnBillToNameChanging(value);
                this._BillToName = value;
                this.OnBillToNameChanged();
                this.OnPropertyChanged("BillToName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillToName;
        partial void OnBillToNameChanging(string value);
        partial void OnBillToNameChanged();
        /// <summary>
        /// There are no comments for Property BillToGSTIN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillToGSTIN")]
        public virtual string BillToGSTIN
        {
            get
            {
                return this._BillToGSTIN;
            }
            set
            {
                this.OnBillToGSTINChanging(value);
                this._BillToGSTIN = value;
                this.OnBillToGSTINChanged();
                this.OnPropertyChanged("BillToGSTIN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillToGSTIN;
        partial void OnBillToGSTINChanging(string value);
        partial void OnBillToGSTINChanged();
        /// <summary>
        /// There are no comments for Property BillToStateGSTCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BillToStateGSTCode")]
        public virtual string BillToStateGSTCode
        {
            get
            {
                return this._BillToStateGSTCode;
            }
            set
            {
                this.OnBillToStateGSTCodeChanging(value);
                this._BillToStateGSTCode = value;
                this.OnBillToStateGSTCodeChanged();
                this.OnPropertyChanged("BillToStateGSTCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BillToStateGSTCode;
        partial void OnBillToStateGSTCodeChanging(string value);
        partial void OnBillToStateGSTCodeChanged();
        /// <summary>
        /// There are no comments for Property ShipToAddress1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipToAddress1")]
        public virtual string ShipToAddress1
        {
            get
            {
                return this._ShipToAddress1;
            }
            set
            {
                this.OnShipToAddress1Changing(value);
                this._ShipToAddress1 = value;
                this.OnShipToAddress1Changed();
                this.OnPropertyChanged("ShipToAddress1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipToAddress1;
        partial void OnShipToAddress1Changing(string value);
        partial void OnShipToAddress1Changed();
        /// <summary>
        /// There are no comments for Property ShipToAddress2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipToAddress2")]
        public virtual string ShipToAddress2
        {
            get
            {
                return this._ShipToAddress2;
            }
            set
            {
                this.OnShipToAddress2Changing(value);
                this._ShipToAddress2 = value;
                this.OnShipToAddress2Changed();
                this.OnPropertyChanged("ShipToAddress2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipToAddress2;
        partial void OnShipToAddress2Changing(string value);
        partial void OnShipToAddress2Changed();
        /// <summary>
        /// There are no comments for Property ShipToZipCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipToZipCode")]
        public virtual string ShipToZipCode
        {
            get
            {
                return this._ShipToZipCode;
            }
            set
            {
                this.OnShipToZipCodeChanging(value);
                this._ShipToZipCode = value;
                this.OnShipToZipCodeChanged();
                this.OnPropertyChanged("ShipToZipCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipToZipCode;
        partial void OnShipToZipCodeChanging(string value);
        partial void OnShipToZipCodeChanged();
        /// <summary>
        /// There are no comments for Property ShipToStateGSTCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipToStateGSTCode")]
        public virtual string ShipToStateGSTCode
        {
            get
            {
                return this._ShipToStateGSTCode;
            }
            set
            {
                this.OnShipToStateGSTCodeChanging(value);
                this._ShipToStateGSTCode = value;
                this.OnShipToStateGSTCodeChanged();
                this.OnPropertyChanged("ShipToStateGSTCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipToStateGSTCode;
        partial void OnShipToStateGSTCodeChanging(string value);
        partial void OnShipToStateGSTCodeChanged();
        /// <summary>
        /// There are no comments for Property MainHSNEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MainHSNEntry")]
        public virtual global::System.Nullable<int> MainHSNEntry
        {
            get
            {
                return this._MainHSNEntry;
            }
            set
            {
                this.OnMainHSNEntryChanging(value);
                this._MainHSNEntry = value;
                this.OnMainHSNEntryChanged();
                this.OnPropertyChanged("MainHSNEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _MainHSNEntry;
        partial void OnMainHSNEntryChanging(global::System.Nullable<int> value);
        partial void OnMainHSNEntryChanged();
        /// <summary>
        /// There are no comments for Property DispatchFromPlace in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DispatchFromPlace")]
        public virtual string DispatchFromPlace
        {
            get
            {
                return this._DispatchFromPlace;
            }
            set
            {
                this.OnDispatchFromPlaceChanging(value);
                this._DispatchFromPlace = value;
                this.OnDispatchFromPlaceChanged();
                this.OnPropertyChanged("DispatchFromPlace");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DispatchFromPlace;
        partial void OnDispatchFromPlaceChanging(string value);
        partial void OnDispatchFromPlaceChanged();
        /// <summary>
        /// There are no comments for Property ShipToPlace in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShipToPlace")]
        public virtual string ShipToPlace
        {
            get
            {
                return this._ShipToPlace;
            }
            set
            {
                this.OnShipToPlaceChanging(value);
                this._ShipToPlace = value;
                this.OnShipToPlaceChanged();
                this.OnPropertyChanged("ShipToPlace");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShipToPlace;
        partial void OnShipToPlaceChanging(string value);
        partial void OnShipToPlaceChanged();
        /// <summary>
        /// There are no comments for Property TransporterID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransporterID")]
        public virtual string TransporterID
        {
            get
            {
                return this._TransporterID;
            }
            set
            {
                this.OnTransporterIDChanging(value);
                this._TransporterID = value;
                this.OnTransporterIDChanged();
                this.OnPropertyChanged("TransporterID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransporterID;
        partial void OnTransporterIDChanging(string value);
        partial void OnTransporterIDChanged();
        /// <summary>
        /// There are no comments for Property TransporterName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransporterName")]
        public virtual string TransporterName
        {
            get
            {
                return this._TransporterName;
            }
            set
            {
                this.OnTransporterNameChanging(value);
                this._TransporterName = value;
                this.OnTransporterNameChanged();
                this.OnPropertyChanged("TransporterName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TransporterName;
        partial void OnTransporterNameChanging(string value);
        partial void OnTransporterNameChanged();
        /// <summary>
        /// There are no comments for Property EWayBillExpirationDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EWayBillExpirationDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> EWayBillExpirationDate
        {
            get
            {
                return this._EWayBillExpirationDate;
            }
            set
            {
                this.OnEWayBillExpirationDateChanging(value);
                this._EWayBillExpirationDate = value;
                this.OnEWayBillExpirationDateChanged();
                this.OnPropertyChanged("EWayBillExpirationDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _EWayBillExpirationDate;
        partial void OnEWayBillExpirationDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnEWayBillExpirationDateChanged();
        /// <summary>
        /// There are no comments for Property TransporterEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransporterEntry")]
        public virtual global::System.Nullable<int> TransporterEntry
        {
            get
            {
                return this._TransporterEntry;
            }
            set
            {
                this.OnTransporterEntryChanging(value);
                this._TransporterEntry = value;
                this.OnTransporterEntryChanged();
                this.OnPropertyChanged("TransporterEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _TransporterEntry;
        partial void OnTransporterEntryChanging(global::System.Nullable<int> value);
        partial void OnTransporterEntryChanged();
        /// <summary>
        /// There are no comments for Property TransporterLineNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransporterLineNumber")]
        public virtual global::System.Nullable<int> TransporterLineNumber
        {
            get
            {
                return this._TransporterLineNumber;
            }
            set
            {
                this.OnTransporterLineNumberChanging(value);
                this._TransporterLineNumber = value;
                this.OnTransporterLineNumberChanged();
                this.OnPropertyChanged("TransporterLineNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _TransporterLineNumber;
        partial void OnTransporterLineNumberChanging(global::System.Nullable<int> value);
        partial void OnTransporterLineNumberChanged();
        /// <summary>
        /// There are no comments for Property TransactionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionType")]
        public virtual global::System.Nullable<global::SAPB1.EWBTransactionTypeEnum> TransactionType
        {
            get
            {
                return this._TransactionType;
            }
            set
            {
                this.OnTransactionTypeChanging(value);
                this._TransactionType = value;
                this.OnTransactionTypeChanged();
                this.OnPropertyChanged("TransactionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.EWBTransactionTypeEnum> _TransactionType;
        partial void OnTransactionTypeChanging(global::System.Nullable<global::SAPB1.EWBTransactionTypeEnum> value);
        partial void OnTransactionTypeChanged();
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