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
    /// There are no comments for ElectronicProtocol in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ElectronicProtocol")]
    public partial class ElectronicProtocol : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property ProtocolCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProtocolCode")]
        public virtual global::System.Nullable<global::SAPB1.ElectronicDocProtocolCodeEnum> ProtocolCode
        {
            get
            {
                return this._ProtocolCode;
            }
            set
            {
                this.OnProtocolCodeChanging(value);
                this._ProtocolCode = value;
                this.OnProtocolCodeChanged();
                this.OnPropertyChanged("ProtocolCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ElectronicDocProtocolCodeEnum> _ProtocolCode;
        partial void OnProtocolCodeChanging(global::System.Nullable<global::SAPB1.ElectronicDocProtocolCodeEnum> value);
        partial void OnProtocolCodeChanged();
        /// <summary>
        /// There are no comments for Property GenerationType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GenerationType")]
        public virtual global::System.Nullable<global::SAPB1.ElectronicDocGenTypeEnum> GenerationType
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
        private global::System.Nullable<global::SAPB1.ElectronicDocGenTypeEnum> _GenerationType;
        partial void OnGenerationTypeChanging(global::System.Nullable<global::SAPB1.ElectronicDocGenTypeEnum> value);
        partial void OnGenerationTypeChanged();
        /// <summary>
        /// There are no comments for Property MappingID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MappingID")]
        public virtual global::System.Nullable<int> MappingID
        {
            get
            {
                return this._MappingID;
            }
            set
            {
                this.OnMappingIDChanging(value);
                this._MappingID = value;
                this.OnMappingIDChanged();
                this.OnPropertyChanged("MappingID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _MappingID;
        partial void OnMappingIDChanging(global::System.Nullable<int> value);
        partial void OnMappingIDChanged();
        /// <summary>
        /// There are no comments for Property TestingMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TestingMode")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> TestingMode
        {
            get
            {
                return this._TestingMode;
            }
            set
            {
                this.OnTestingModeChanging(value);
                this._TestingMode = value;
                this.OnTestingModeChanged();
                this.OnPropertyChanged("TestingMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _TestingMode;
        partial void OnTestingModeChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnTestingModeChanged();
        /// <summary>
        /// There are no comments for Property Confirmation in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Confirmation")]
        public virtual string Confirmation
        {
            get
            {
                return this._Confirmation;
            }
            set
            {
                this.OnConfirmationChanging(value);
                this._Confirmation = value;
                this.OnConfirmationChanged();
                this.OnPropertyChanged("Confirmation");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Confirmation;
        partial void OnConfirmationChanging(string value);
        partial void OnConfirmationChanged();
        /// <summary>
        /// There are no comments for Property EDocType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EDocType")]
        public virtual global::System.Nullable<int> EDocType
        {
            get
            {
                return this._EDocType;
            }
            set
            {
                this.OnEDocTypeChanging(value);
                this._EDocType = value;
                this.OnEDocTypeChanged();
                this.OnPropertyChanged("EDocType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _EDocType;
        partial void OnEDocTypeChanging(global::System.Nullable<int> value);
        partial void OnEDocTypeChanged();
        /// <summary>
        /// There are no comments for Property CFDiCancellationReason in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CFDiCancellationReason")]
        public virtual string CFDiCancellationReason
        {
            get
            {
                return this._CFDiCancellationReason;
            }
            set
            {
                this.OnCFDiCancellationReasonChanging(value);
                this._CFDiCancellationReason = value;
                this.OnCFDiCancellationReasonChanged();
                this.OnPropertyChanged("CFDiCancellationReason");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CFDiCancellationReason;
        partial void OnCFDiCancellationReasonChanging(string value);
        partial void OnCFDiCancellationReasonChanged();
        /// <summary>
        /// There are no comments for Property CFDiCancellationResponse in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CFDiCancellationResponse")]
        public virtual string CFDiCancellationResponse
        {
            get
            {
                return this._CFDiCancellationResponse;
            }
            set
            {
                this.OnCFDiCancellationResponseChanging(value);
                this._CFDiCancellationResponse = value;
                this.OnCFDiCancellationResponseChanged();
                this.OnPropertyChanged("CFDiCancellationResponse");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CFDiCancellationResponse;
        partial void OnCFDiCancellationResponseChanging(string value);
        partial void OnCFDiCancellationResponseChanged();
        /// <summary>
        /// There are no comments for Property RelatedDocuments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RelatedDocuments")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.RelatedDocument> RelatedDocuments
        {
            get
            {
                return this._RelatedDocuments;
            }
            set
            {
                this.OnRelatedDocumentsChanging(value);
                this._RelatedDocuments = value;
                this.OnRelatedDocumentsChanged();
                this.OnPropertyChanged("RelatedDocuments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.RelatedDocument> _RelatedDocuments = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.RelatedDocument>();
        partial void OnRelatedDocumentsChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.RelatedDocument> value);
        partial void OnRelatedDocumentsChanged();
        /// <summary>
        /// There are no comments for Property EBooksRelevant in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EBooksRelevant")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> EBooksRelevant
        {
            get
            {
                return this._EBooksRelevant;
            }
            set
            {
                this.OnEBooksRelevantChanging(value);
                this._EBooksRelevant = value;
                this.OnEBooksRelevantChanged();
                this.OnPropertyChanged("EBooksRelevant");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _EBooksRelevant;
        partial void OnEBooksRelevantChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnEBooksRelevantChanged();
        /// <summary>
        /// There are no comments for Property EBooksMARK in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EBooksMARK")]
        public virtual string EBooksMARK
        {
            get
            {
                return this._EBooksMARK;
            }
            set
            {
                this.OnEBooksMARKChanging(value);
                this._EBooksMARK = value;
                this.OnEBooksMARKChanged();
                this.OnPropertyChanged("EBooksMARK");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EBooksMARK;
        partial void OnEBooksMARKChanging(string value);
        partial void OnEBooksMARKChanged();
        /// <summary>
        /// There are no comments for Property EBooksMARKofNegative in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EBooksMARKofNegative")]
        public virtual string EBooksMARKofNegative
        {
            get
            {
                return this._EBooksMARKofNegative;
            }
            set
            {
                this.OnEBooksMARKofNegativeChanging(value);
                this._EBooksMARKofNegative = value;
                this.OnEBooksMARKofNegativeChanged();
                this.OnPropertyChanged("EBooksMARKofNegative");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EBooksMARKofNegative;
        partial void OnEBooksMARKofNegativeChanging(string value);
        partial void OnEBooksMARKofNegativeChanged();
        /// <summary>
        /// There are no comments for Property EBooksInvoiceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EBooksInvoiceType")]
        public virtual string EBooksInvoiceType
        {
            get
            {
                return this._EBooksInvoiceType;
            }
            set
            {
                this.OnEBooksInvoiceTypeChanging(value);
                this._EBooksInvoiceType = value;
                this.OnEBooksInvoiceTypeChanged();
                this.OnPropertyChanged("EBooksInvoiceType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EBooksInvoiceType;
        partial void OnEBooksInvoiceTypeChanging(string value);
        partial void OnEBooksInvoiceTypeChanged();
        /// <summary>
        /// There are no comments for Property EBooksInvoiceTypeofNegative in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EBooksInvoiceTypeofNegative")]
        public virtual string EBooksInvoiceTypeofNegative
        {
            get
            {
                return this._EBooksInvoiceTypeofNegative;
            }
            set
            {
                this.OnEBooksInvoiceTypeofNegativeChanging(value);
                this._EBooksInvoiceTypeofNegative = value;
                this.OnEBooksInvoiceTypeofNegativeChanged();
                this.OnPropertyChanged("EBooksInvoiceTypeofNegative");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EBooksInvoiceTypeofNegative;
        partial void OnEBooksInvoiceTypeofNegativeChanging(string value);
        partial void OnEBooksInvoiceTypeofNegativeChanged();
        /// <summary>
        /// There are no comments for Property EBillingIRN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EBillingIRN")]
        public virtual string EBillingIRN
        {
            get
            {
                return this._EBillingIRN;
            }
            set
            {
                this.OnEBillingIRNChanging(value);
                this._EBillingIRN = value;
                this.OnEBillingIRNChanged();
                this.OnPropertyChanged("EBillingIRN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EBillingIRN;
        partial void OnEBillingIRNChanging(string value);
        partial void OnEBillingIRNChanged();
        /// <summary>
        /// There are no comments for Property EETPKP in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EETPKP")]
        public virtual string EETPKP
        {
            get
            {
                return this._EETPKP;
            }
            set
            {
                this.OnEETPKPChanging(value);
                this._EETPKP = value;
                this.OnEETPKPChanged();
                this.OnPropertyChanged("EETPKP");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EETPKP;
        partial void OnEETPKPChanging(string value);
        partial void OnEETPKPChanged();
        /// <summary>
        /// There are no comments for Property EETBKP in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EETBKP")]
        public virtual string EETBKP
        {
            get
            {
                return this._EETBKP;
            }
            set
            {
                this.OnEETBKPChanging(value);
                this._EETBKP = value;
                this.OnEETBKPChanged();
                this.OnPropertyChanged("EETBKP");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EETBKP;
        partial void OnEETBKPChanging(string value);
        partial void OnEETBKPChanged();
        /// <summary>
        /// There are no comments for Property SignatureInputMessage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SignatureInputMessage")]
        public virtual string SignatureInputMessage
        {
            get
            {
                return this._SignatureInputMessage;
            }
            set
            {
                this.OnSignatureInputMessageChanging(value);
                this._SignatureInputMessage = value;
                this.OnSignatureInputMessageChanged();
                this.OnPropertyChanged("SignatureInputMessage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SignatureInputMessage;
        partial void OnSignatureInputMessageChanging(string value);
        partial void OnSignatureInputMessageChanged();
        /// <summary>
        /// There are no comments for Property SignatureDigest in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SignatureDigest")]
        public virtual string SignatureDigest
        {
            get
            {
                return this._SignatureDigest;
            }
            set
            {
                this.OnSignatureDigestChanging(value);
                this._SignatureDigest = value;
                this.OnSignatureDigestChanged();
                this.OnPropertyChanged("SignatureDigest");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SignatureDigest;
        partial void OnSignatureDigestChanging(string value);
        partial void OnSignatureDigestChanged();
        /// <summary>
        /// There are no comments for Property FechaTimbrado in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FechaTimbrado")]
        public virtual string FechaTimbrado
        {
            get
            {
                return this._FechaTimbrado;
            }
            set
            {
                this.OnFechaTimbradoChanging(value);
                this._FechaTimbrado = value;
                this.OnFechaTimbradoChanged();
                this.OnPropertyChanged("FechaTimbrado");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FechaTimbrado;
        partial void OnFechaTimbradoChanging(string value);
        partial void OnFechaTimbradoChanged();
        /// <summary>
        /// There are no comments for Property SelloSAT in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SelloSAT")]
        public virtual string SelloSAT
        {
            get
            {
                return this._SelloSAT;
            }
            set
            {
                this.OnSelloSATChanging(value);
                this._SelloSAT = value;
                this.OnSelloSATChanged();
                this.OnPropertyChanged("SelloSAT");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SelloSAT;
        partial void OnSelloSATChanging(string value);
        partial void OnSelloSATChanged();
        /// <summary>
        /// There are no comments for Property PaymentMethod in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PaymentMethod")]
        public virtual string PaymentMethod
        {
            get
            {
                return this._PaymentMethod;
            }
            set
            {
                this.OnPaymentMethodChanging(value);
                this._PaymentMethod = value;
                this.OnPaymentMethodChanged();
                this.OnPropertyChanged("PaymentMethod");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PaymentMethod;
        partial void OnPaymentMethodChanging(string value);
        partial void OnPaymentMethodChanged();
        /// <summary>
        /// There are no comments for Property RfcProvCertif in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RfcProvCertif")]
        public virtual string RfcProvCertif
        {
            get
            {
                return this._RfcProvCertif;
            }
            set
            {
                this.OnRfcProvCertifChanging(value);
                this._RfcProvCertif = value;
                this.OnRfcProvCertifChanged();
                this.OnPropertyChanged("RfcProvCertif");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RfcProvCertif;
        partial void OnRfcProvCertifChanging(string value);
        partial void OnRfcProvCertifChanged();
        /// <summary>
        /// There are no comments for Property NoCertificadoSAT in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NoCertificadoSAT")]
        public virtual string NoCertificadoSAT
        {
            get
            {
                return this._NoCertificadoSAT;
            }
            set
            {
                this.OnNoCertificadoSATChanging(value);
                this._NoCertificadoSAT = value;
                this.OnNoCertificadoSATChanged();
                this.OnPropertyChanged("NoCertificadoSAT");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NoCertificadoSAT;
        partial void OnNoCertificadoSATChanging(string value);
        partial void OnNoCertificadoSATChanged();
        /// <summary>
        /// There are no comments for Property FPASequenceNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FPASequenceNumber")]
        public virtual global::System.Nullable<int> FPASequenceNumber
        {
            get
            {
                return this._FPASequenceNumber;
            }
            set
            {
                this.OnFPASequenceNumberChanging(value);
                this._FPASequenceNumber = value;
                this.OnFPASequenceNumberChanged();
                this.OnPropertyChanged("FPASequenceNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _FPASequenceNumber;
        partial void OnFPASequenceNumberChanging(global::System.Nullable<int> value);
        partial void OnFPASequenceNumberChanged();
        /// <summary>
        /// There are no comments for Property FPASendDateSDI in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FPASendDateSDI")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> FPASendDateSDI
        {
            get
            {
                return this._FPASendDateSDI;
            }
            set
            {
                this.OnFPASendDateSDIChanging(value);
                this._FPASendDateSDI = value;
                this.OnFPASendDateSDIChanged();
                this.OnPropertyChanged("FPASendDateSDI");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _FPASendDateSDI;
        partial void OnFPASendDateSDIChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnFPASendDateSDIChanged();
        /// <summary>
        /// There are no comments for Property FPAProgressivo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FPAProgressivo")]
        public virtual string FPAProgressivo
        {
            get
            {
                return this._FPAProgressivo;
            }
            set
            {
                this.OnFPAProgressivoChanging(value);
                this._FPAProgressivo = value;
                this.OnFPAProgressivoChanged();
                this.OnPropertyChanged("FPAProgressivo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FPAProgressivo;
        partial void OnFPAProgressivoChanging(string value);
        partial void OnFPAProgressivoChanged();
        /// <summary>
        /// There are no comments for Property ProtocolDescription in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ProtocolDescription")]
        public virtual string ProtocolDescription
        {
            get
            {
                return this._ProtocolDescription;
            }
            set
            {
                this.OnProtocolDescriptionChanging(value);
                this._ProtocolDescription = value;
                this.OnProtocolDescriptionChanged();
                this.OnPropertyChanged("ProtocolDescription");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ProtocolDescription;
        partial void OnProtocolDescriptionChanging(string value);
        partial void OnProtocolDescriptionChanged();
        /// <summary>
        /// There are no comments for Property CFDiExport in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CFDiExport")]
        public virtual string CFDiExport
        {
            get
            {
                return this._CFDiExport;
            }
            set
            {
                this.OnCFDiExportChanging(value);
                this._CFDiExport = value;
                this.OnCFDiExportChanged();
                this.OnPropertyChanged("CFDiExport");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CFDiExport;
        partial void OnCFDiExportChanging(string value);
        partial void OnCFDiExportChanged();
        /// <summary>
        /// There are no comments for Property CFDiCancellationReference in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CFDiCancellationReference")]
        public virtual string CFDiCancellationReference
        {
            get
            {
                return this._CFDiCancellationReference;
            }
            set
            {
                this.OnCFDiCancellationReferenceChanging(value);
                this._CFDiCancellationReference = value;
                this.OnCFDiCancellationReferenceChanged();
                this.OnPropertyChanged("CFDiCancellationReference");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CFDiCancellationReference;
        partial void OnCFDiCancellationReferenceChanging(string value);
        partial void OnCFDiCancellationReferenceChanged();
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