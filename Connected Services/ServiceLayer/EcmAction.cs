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
    /// There are no comments for EcmAction in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("EcmAction")]
    public partial class EcmAction : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property ActionID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ActionID")]
        public virtual global::System.Nullable<int> ActionID
        {
            get
            {
                return this._ActionID;
            }
            set
            {
                this.OnActionIDChanging(value);
                this._ActionID = value;
                this.OnActionIDChanged();
                this.OnPropertyChanged("ActionID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ActionID;
        partial void OnActionIDChanging(global::System.Nullable<int> value);
        partial void OnActionIDChanged();
        /// <summary>
        /// There are no comments for Property Protocol in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Protocol")]
        public virtual string Protocol
        {
            get
            {
                return this._Protocol;
            }
            set
            {
                this.OnProtocolChanging(value);
                this._Protocol = value;
                this.OnProtocolChanged();
                this.OnPropertyChanged("Protocol");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Protocol;
        partial void OnProtocolChanging(string value);
        partial void OnProtocolChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::SAPB1.EcmActionTypeEnum> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("Type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.EcmActionTypeEnum> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::SAPB1.EcmActionTypeEnum> value);
        partial void OnTypeChanged();
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
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual global::System.Nullable<global::SAPB1.EcmActionStatusEnum> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.EcmActionStatusEnum> _Status;
        partial void OnStatusChanging(global::System.Nullable<global::SAPB1.EcmActionStatusEnum> value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property Message in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Message")]
        public virtual string Message
        {
            get
            {
                return this._Message;
            }
            set
            {
                this.OnMessageChanging(value);
                this._Message = value;
                this.OnMessageChanged();
                this.OnPropertyChanged("Message");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Message;
        partial void OnMessageChanging(string value);
        partial void OnMessageChanged();
        /// <summary>
        /// There are no comments for Property Environment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Environment")]
        public virtual global::System.Nullable<int> Environment
        {
            get
            {
                return this._Environment;
            }
            set
            {
                this.OnEnvironmentChanging(value);
                this._Environment = value;
                this.OnEnvironmentChanged();
                this.OnPropertyChanged("Environment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Environment;
        partial void OnEnvironmentChanging(global::System.Nullable<int> value);
        partial void OnEnvironmentChanged();
        /// <summary>
        /// There are no comments for Property BusinessPlace in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPlace")]
        public virtual global::System.Nullable<int> BusinessPlace
        {
            get
            {
                return this._BusinessPlace;
            }
            set
            {
                this.OnBusinessPlaceChanging(value);
                this._BusinessPlace = value;
                this.OnBusinessPlaceChanged();
                this.OnPropertyChanged("BusinessPlace");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BusinessPlace;
        partial void OnBusinessPlaceChanging(global::System.Nullable<int> value);
        partial void OnBusinessPlaceChanged();
        /// <summary>
        /// There are no comments for Property Submits in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Submits")]
        public virtual global::System.Nullable<int> Submits
        {
            get
            {
                return this._Submits;
            }
            set
            {
                this.OnSubmitsChanging(value);
                this._Submits = value;
                this.OnSubmitsChanged();
                this.OnPropertyChanged("Submits");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Submits;
        partial void OnSubmitsChanging(global::System.Nullable<int> value);
        partial void OnSubmitsChanged();
        /// <summary>
        /// There are no comments for Property ObjectID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ObjectID")]
        public virtual string ObjectID
        {
            get
            {
                return this._ObjectID;
            }
            set
            {
                this.OnObjectIDChanging(value);
                this._ObjectID = value;
                this.OnObjectIDChanged();
                this.OnPropertyChanged("ObjectID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ObjectID;
        partial void OnObjectIDChanging(string value);
        partial void OnObjectIDChanged();
        /// <summary>
        /// There are no comments for Property ReportID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ReportID")]
        public virtual string ReportID
        {
            get
            {
                return this._ReportID;
            }
            set
            {
                this.OnReportIDChanging(value);
                this._ReportID = value;
                this.OnReportIDChanged();
                this.OnPropertyChanged("ReportID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ReportID;
        partial void OnReportIDChanging(string value);
        partial void OnReportIDChanged();
        /// <summary>
        /// There are no comments for Property SourceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceType")]
        public virtual string SourceType
        {
            get
            {
                return this._SourceType;
            }
            set
            {
                this.OnSourceTypeChanging(value);
                this._SourceType = value;
                this.OnSourceTypeChanged();
                this.OnPropertyChanged("SourceType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceType;
        partial void OnSourceTypeChanging(string value);
        partial void OnSourceTypeChanged();
        /// <summary>
        /// There are no comments for Property SourceObject in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceObject")]
        public virtual global::System.Nullable<int> SourceObject
        {
            get
            {
                return this._SourceObject;
            }
            set
            {
                this.OnSourceObjectChanging(value);
                this._SourceObject = value;
                this.OnSourceObjectChanged();
                this.OnPropertyChanged("SourceObject");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SourceObject;
        partial void OnSourceObjectChanging(global::System.Nullable<int> value);
        partial void OnSourceObjectChanged();
        /// <summary>
        /// There are no comments for Property AssignedID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssignedID")]
        public virtual string AssignedID
        {
            get
            {
                return this._AssignedID;
            }
            set
            {
                this.OnAssignedIDChanging(value);
                this._AssignedID = value;
                this.OnAssignedIDChanged();
                this.OnPropertyChanged("AssignedID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AssignedID;
        partial void OnAssignedIDChanging(string value);
        partial void OnAssignedIDChanged();
        /// <summary>
        /// There are no comments for Property DocumentBatch in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentBatch")]
        public virtual string DocumentBatch
        {
            get
            {
                return this._DocumentBatch;
            }
            set
            {
                this.OnDocumentBatchChanging(value);
                this._DocumentBatch = value;
                this.OnDocumentBatchChanged();
                this.OnPropertyChanged("DocumentBatch");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocumentBatch;
        partial void OnDocumentBatchChanging(string value);
        partial void OnDocumentBatchChanged();
        /// <summary>
        /// There are no comments for Property DocumentBatchLine in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocumentBatchLine")]
        public virtual global::System.Nullable<int> DocumentBatchLine
        {
            get
            {
                return this._DocumentBatchLine;
            }
            set
            {
                this.OnDocumentBatchLineChanging(value);
                this._DocumentBatchLine = value;
                this.OnDocumentBatchLineChanged();
                this.OnPropertyChanged("DocumentBatchLine");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _DocumentBatchLine;
        partial void OnDocumentBatchLineChanging(global::System.Nullable<int> value);
        partial void OnDocumentBatchLineChanged();
        /// <summary>
        /// There are no comments for Property PeriodType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodType")]
        public virtual global::System.Nullable<global::SAPB1.EcmActionPeriodTypeEnum> PeriodType
        {
            get
            {
                return this._PeriodType;
            }
            set
            {
                this.OnPeriodTypeChanging(value);
                this._PeriodType = value;
                this.OnPeriodTypeChanged();
                this.OnPropertyChanged("PeriodType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.EcmActionPeriodTypeEnum> _PeriodType;
        partial void OnPeriodTypeChanging(global::System.Nullable<global::SAPB1.EcmActionPeriodTypeEnum> value);
        partial void OnPeriodTypeChanged();
        /// <summary>
        /// There are no comments for Property PeriodNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodNumber")]
        public virtual global::System.Nullable<int> PeriodNumber
        {
            get
            {
                return this._PeriodNumber;
            }
            set
            {
                this.OnPeriodNumberChanging(value);
                this._PeriodNumber = value;
                this.OnPeriodNumberChanged();
                this.OnPropertyChanged("PeriodNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _PeriodNumber;
        partial void OnPeriodNumberChanging(global::System.Nullable<int> value);
        partial void OnPeriodNumberChanged();
        /// <summary>
        /// There are no comments for Property PeriodYear in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodYear")]
        public virtual global::System.Nullable<int> PeriodYear
        {
            get
            {
                return this._PeriodYear;
            }
            set
            {
                this.OnPeriodYearChanging(value);
                this._PeriodYear = value;
                this.OnPeriodYearChanged();
                this.OnPropertyChanged("PeriodYear");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _PeriodYear;
        partial void OnPeriodYearChanging(global::System.Nullable<int> value);
        partial void OnPeriodYearChanged();
        /// <summary>
        /// There are no comments for Property PeriodDateFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodDateFrom")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> PeriodDateFrom
        {
            get
            {
                return this._PeriodDateFrom;
            }
            set
            {
                this.OnPeriodDateFromChanging(value);
                this._PeriodDateFrom = value;
                this.OnPeriodDateFromChanged();
                this.OnPropertyChanged("PeriodDateFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _PeriodDateFrom;
        partial void OnPeriodDateFromChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnPeriodDateFromChanged();
        /// <summary>
        /// There are no comments for Property PeriodDateTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PeriodDateTo")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> PeriodDateTo
        {
            get
            {
                return this._PeriodDateTo;
            }
            set
            {
                this.OnPeriodDateToChanging(value);
                this._PeriodDateTo = value;
                this.OnPeriodDateToChanged();
                this.OnPropertyChanged("PeriodDateTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _PeriodDateTo;
        partial void OnPeriodDateToChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnPeriodDateToChanged();
        /// <summary>
        /// There are no comments for Property IsRemoved in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsRemoved")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IsRemoved
        {
            get
            {
                return this._IsRemoved;
            }
            set
            {
                this.OnIsRemovedChanging(value);
                this._IsRemoved = value;
                this.OnIsRemovedChanged();
                this.OnPropertyChanged("IsRemoved");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IsRemoved;
        partial void OnIsRemovedChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIsRemovedChanged();
        /// <summary>
        /// There are no comments for Property IsCanceled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsCanceled")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IsCanceled
        {
            get
            {
                return this._IsCanceled;
            }
            set
            {
                this.OnIsCanceledChanging(value);
                this._IsCanceled = value;
                this.OnIsCanceledChanged();
                this.OnPropertyChanged("IsCanceled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IsCanceled;
        partial void OnIsCanceledChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIsCanceledChanged();
        /// <summary>
        /// There are no comments for Property GenerationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GenerationType")]
        public virtual global::System.Nullable<global::SAPB1.EcmActionGenerationTypeEnum> GenerationType
        {
            get
            {
                return this._GenerationType;
            }
            set
            {
                this.OnGenerationTypeChanging(value);
                this._GenerationType = value;
                this.OnGenerationTypeChanged();
                this.OnPropertyChanged("GenerationType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.EcmActionGenerationTypeEnum> _GenerationType;
        partial void OnGenerationTypeChanging(global::System.Nullable<global::SAPB1.EcmActionGenerationTypeEnum> value);
        partial void OnGenerationTypeChanged();
        /// <summary>
        /// There are no comments for Property U_B1SYS_XMLAmount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("U_B1SYS_XMLAmount")]
        public virtual global::System.Nullable<double> U_B1SYS_XMLAmount
        {
            get
            {
                return this._U_B1SYS_XMLAmount;
            }
            set
            {
                this.OnU_B1SYS_XMLAmountChanging(value);
                this._U_B1SYS_XMLAmount = value;
                this.OnU_B1SYS_XMLAmountChanged();
                this.OnPropertyChanged("U_B1SYS_XMLAmount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _U_B1SYS_XMLAmount;
        partial void OnU_B1SYS_XMLAmountChanging(global::System.Nullable<double> value);
        partial void OnU_B1SYS_XMLAmountChanged();
        /// <summary>
        /// There are no comments for Property U_B1SYS_SendDateINTM in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("U_B1SYS_SendDateINTM")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> U_B1SYS_SendDateINTM
        {
            get
            {
                return this._U_B1SYS_SendDateINTM;
            }
            set
            {
                this.OnU_B1SYS_SendDateINTMChanging(value);
                this._U_B1SYS_SendDateINTM = value;
                this.OnU_B1SYS_SendDateINTMChanged();
                this.OnPropertyChanged("U_B1SYS_SendDateINTM");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _U_B1SYS_SendDateINTM;
        partial void OnU_B1SYS_SendDateINTMChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnU_B1SYS_SendDateINTMChanged();
        /// <summary>
        /// There are no comments for Property U_B1SYS_ANN_AccMeth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("U_B1SYS_ANN_AccMeth")]
        public virtual string U_B1SYS_ANN_AccMeth
        {
            get
            {
                return this._U_B1SYS_ANN_AccMeth;
            }
            set
            {
                this.OnU_B1SYS_ANN_AccMethChanging(value);
                this._U_B1SYS_ANN_AccMeth = value;
                this.OnU_B1SYS_ANN_AccMethChanged();
                this.OnPropertyChanged("U_B1SYS_ANN_AccMeth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _U_B1SYS_ANN_AccMeth;
        partial void OnU_B1SYS_ANN_AccMethChanging(string value);
        partial void OnU_B1SYS_ANN_AccMethChanged();
        /// <summary>
        /// There are no comments for Property U_B1SYS_ANN_AccVal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("U_B1SYS_ANN_AccVal")]
        public virtual global::System.Nullable<double> U_B1SYS_ANN_AccVal
        {
            get
            {
                return this._U_B1SYS_ANN_AccVal;
            }
            set
            {
                this.OnU_B1SYS_ANN_AccValChanging(value);
                this._U_B1SYS_ANN_AccVal = value;
                this.OnU_B1SYS_ANN_AccValChanged();
                this.OnPropertyChanged("U_B1SYS_ANN_AccVal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _U_B1SYS_ANN_AccVal;
        partial void OnU_B1SYS_ANN_AccValChanging(global::System.Nullable<double> value);
        partial void OnU_B1SYS_ANN_AccValChanged();
        /// <summary>
        /// There are no comments for Property U_B1SYS_ANN_SntMeth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("U_B1SYS_ANN_SntMeth")]
        public virtual string U_B1SYS_ANN_SntMeth
        {
            get
            {
                return this._U_B1SYS_ANN_SntMeth;
            }
            set
            {
                this.OnU_B1SYS_ANN_SntMethChanging(value);
                this._U_B1SYS_ANN_SntMeth = value;
                this.OnU_B1SYS_ANN_SntMethChanged();
                this.OnPropertyChanged("U_B1SYS_ANN_SntMeth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _U_B1SYS_ANN_SntMeth;
        partial void OnU_B1SYS_ANN_SntMethChanging(string value);
        partial void OnU_B1SYS_ANN_SntMethChanged();
        /// <summary>
        /// There are no comments for Property U_B1SYS_ANN_SntVal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("U_B1SYS_ANN_SntVal")]
        public virtual global::System.Nullable<double> U_B1SYS_ANN_SntVal
        {
            get
            {
                return this._U_B1SYS_ANN_SntVal;
            }
            set
            {
                this.OnU_B1SYS_ANN_SntValChanging(value);
                this._U_B1SYS_ANN_SntVal = value;
                this.OnU_B1SYS_ANN_SntValChanged();
                this.OnPropertyChanged("U_B1SYS_ANN_SntVal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _U_B1SYS_ANN_SntVal;
        partial void OnU_B1SYS_ANN_SntValChanging(global::System.Nullable<double> value);
        partial void OnU_B1SYS_ANN_SntValChanged();
        /// <summary>
        /// There are no comments for Property DynamicProperties in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DynamicProperties")]
        public virtual global::System.Collections.Generic.IDictionary<string, object> DynamicProperties
        {
            get
            {
                return this._DynamicProperties;
            }
            set
            {
                this.OnDynamicPropertiesChanging(value);
                this._DynamicProperties = value;
                this.OnDynamicPropertiesChanged();
                this.OnPropertyChanged("DynamicProperties");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.Generic.IDictionary<string, object> _DynamicProperties = new global::System.Collections.Generic.Dictionary<string, object>();
        partial void OnDynamicPropertiesChanging(global::System.Collections.Generic.IDictionary<string, object> value);
        partial void OnDynamicPropertiesChanged();
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
