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
    /// There are no comments for BPVatExemptionsSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("BPVatExemptionsSingle")]
    public partial class BPVatExemptionsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<BPVatExemptions>
    {
        /// <summary>
        /// Initialize a new BPVatExemptionsSingle object.
        /// </summary>
        public BPVatExemptionsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new BPVatExemptionsSingle object.
        /// </summary>
        public BPVatExemptionsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new BPVatExemptionsSingle object.
        /// </summary>
        public BPVatExemptionsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<BPVatExemptions> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for BusinessPartner in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPartner")]
        public virtual global::SAPB1.BusinessPartnerSingle BusinessPartner
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._BusinessPartner == null))
                {
                    this._BusinessPartner = new global::SAPB1.BusinessPartnerSingle(this.Context, GetPath("BusinessPartner"));
                }
                return this._BusinessPartner;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BusinessPartnerSingle _BusinessPartner;
    }
    /// <summary>
    /// There are no comments for BPVatExemptions in the schema.
    /// </summary>
    /// <KeyProperties>
    /// AbsoluteEntry
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("AbsoluteEntry")]
    [global::Microsoft.OData.Client.EntitySet("BPVatExemptions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("BPVatExemptions")]
    public partial class BPVatExemptions : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new BPVatExemptions object.
        /// </summary>
        /// <param name="absoluteEntry">Initial value of AbsoluteEntry.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static BPVatExemptions CreateBPVatExemptions(int absoluteEntry)
        {
            BPVatExemptions bPVatExemptions = new BPVatExemptions();
            bPVatExemptions.AbsoluteEntry = absoluteEntry;
            return bPVatExemptions;
        }
        /// <summary>
        /// There are no comments for Property AbsoluteEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AbsoluteEntry")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "AbsoluteEntry is required.")]
        public virtual int AbsoluteEntry
        {
            get
            {
                return this._AbsoluteEntry;
            }
            set
            {
                this.OnAbsoluteEntryChanging(value);
                this._AbsoluteEntry = value;
                this.OnAbsoluteEntryChanged();
                this.OnPropertyChanged("AbsoluteEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _AbsoluteEntry;
        partial void OnAbsoluteEntryChanging(int value);
        partial void OnAbsoluteEntryChanged();
        /// <summary>
        /// There are no comments for Property BPCode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BPCode")]
        public virtual string BPCode
        {
            get
            {
                return this._BPCode;
            }
            set
            {
                this.OnBPCodeChanging(value);
                this._BPCode = value;
                this.OnBPCodeChanged();
                this.OnPropertyChanged("BPCode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _BPCode;
        partial void OnBPCodeChanging(string value);
        partial void OnBPCodeChanged();
        /// <summary>
        /// There are no comments for Property Remarks in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Remarks")]
        public virtual string Remarks
        {
            get
            {
                return this._Remarks;
            }
            set
            {
                this.OnRemarksChanging(value);
                this._Remarks = value;
                this.OnRemarksChanged();
                this.OnPropertyChanged("Remarks");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Remarks;
        partial void OnRemarksChanging(string value);
        partial void OnRemarksChanged();
        /// <summary>
        /// There are no comments for Property BPVatExemptionsLines in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BPVatExemptionsLines")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BPVatExemptionsLine> BPVatExemptionsLines
        {
            get
            {
                return this._BPVatExemptionsLines;
            }
            set
            {
                this.OnBPVatExemptionsLinesChanging(value);
                this._BPVatExemptionsLines = value;
                this.OnBPVatExemptionsLinesChanged();
                this.OnPropertyChanged("BPVatExemptionsLines");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BPVatExemptionsLine> _BPVatExemptionsLines = new global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BPVatExemptionsLine>();
        partial void OnBPVatExemptionsLinesChanging(global::System.Collections.ObjectModel.ObservableCollection<global::SAPB1.BPVatExemptionsLine> value);
        partial void OnBPVatExemptionsLinesChanged();
        /// <summary>
        /// There are no comments for Property BusinessPartner in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BusinessPartner")]
        public virtual global::SAPB1.BusinessPartner BusinessPartner
        {
            get
            {
                return this._BusinessPartner;
            }
            set
            {
                this.OnBusinessPartnerChanging(value);
                this._BusinessPartner = value;
                this.OnBusinessPartnerChanged();
                this.OnPropertyChanged("BusinessPartner");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.BusinessPartner _BusinessPartner;
        partial void OnBusinessPartnerChanging(global::SAPB1.BusinessPartner value);
        partial void OnBusinessPartnerChanged();
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