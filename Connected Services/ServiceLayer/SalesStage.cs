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
    /// There are no comments for SalesStageSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SalesStageSingle")]
    public partial class SalesStageSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SalesStage>
    {
        /// <summary>
        /// Initialize a new SalesStageSingle object.
        /// </summary>
        public SalesStageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SalesStageSingle object.
        /// </summary>
        public SalesStageSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SalesStageSingle object.
        /// </summary>
        public SalesStageSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SalesStage> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for SalesOpportunities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesOpportunities")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.SalesOpportunities> SalesOpportunities
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._SalesOpportunities == null))
                {
                    this._SalesOpportunities = Context.CreateQuery<global::SAPB1.SalesOpportunities>(GetPath("SalesOpportunities"));
                }
                return this._SalesOpportunities;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::SAPB1.SalesOpportunities> _SalesOpportunities;
    }
    /// <summary>
    /// There are no comments for SalesStage in the schema.
    /// </summary>
    /// <KeyProperties>
    /// SequenceNo
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("SequenceNo")]
    [global::Microsoft.OData.Client.EntitySet("SalesStages")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SalesStage")]
    public partial class SalesStage : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new SalesStage object.
        /// </summary>
        /// <param name="sequenceNo">Initial value of SequenceNo.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static SalesStage CreateSalesStage(int sequenceNo)
        {
            SalesStage salesStage = new SalesStage();
            salesStage.SequenceNo = sequenceNo;
            return salesStage;
        }
        /// <summary>
        /// There are no comments for Property SequenceNo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SequenceNo")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "SequenceNo is required.")]
        public virtual int SequenceNo
        {
            get
            {
                return this._SequenceNo;
            }
            set
            {
                this.OnSequenceNoChanging(value);
                this._SequenceNo = value;
                this.OnSequenceNoChanged();
                this.OnPropertyChanged("SequenceNo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _SequenceNo;
        partial void OnSequenceNoChanging(int value);
        partial void OnSequenceNoChanged();
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
        /// There are no comments for Property Stageno in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Stageno")]
        public virtual global::System.Nullable<int> Stageno
        {
            get
            {
                return this._Stageno;
            }
            set
            {
                this.OnStagenoChanging(value);
                this._Stageno = value;
                this.OnStagenoChanged();
                this.OnPropertyChanged("Stageno");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _Stageno;
        partial void OnStagenoChanging(global::System.Nullable<int> value);
        partial void OnStagenoChanged();
        /// <summary>
        /// There are no comments for Property ClosingPercentage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ClosingPercentage")]
        public virtual global::System.Nullable<double> ClosingPercentage
        {
            get
            {
                return this._ClosingPercentage;
            }
            set
            {
                this.OnClosingPercentageChanging(value);
                this._ClosingPercentage = value;
                this.OnClosingPercentageChanged();
                this.OnPropertyChanged("ClosingPercentage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _ClosingPercentage;
        partial void OnClosingPercentageChanging(global::System.Nullable<double> value);
        partial void OnClosingPercentageChanged();
        /// <summary>
        /// There are no comments for Property Cancelled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Cancelled")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> Cancelled
        {
            get
            {
                return this._Cancelled;
            }
            set
            {
                this.OnCancelledChanging(value);
                this._Cancelled = value;
                this.OnCancelledChanged();
                this.OnPropertyChanged("Cancelled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _Cancelled;
        partial void OnCancelledChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnCancelledChanged();
        /// <summary>
        /// There are no comments for Property IsSales in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsSales")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IsSales
        {
            get
            {
                return this._IsSales;
            }
            set
            {
                this.OnIsSalesChanging(value);
                this._IsSales = value;
                this.OnIsSalesChanged();
                this.OnPropertyChanged("IsSales");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IsSales;
        partial void OnIsSalesChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIsSalesChanged();
        /// <summary>
        /// There are no comments for Property IsPurchasing in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsPurchasing")]
        public virtual global::System.Nullable<global::SAPB1.BoYesNoEnum> IsPurchasing
        {
            get
            {
                return this._IsPurchasing;
            }
            set
            {
                this.OnIsPurchasingChanging(value);
                this._IsPurchasing = value;
                this.OnIsPurchasingChanged();
                this.OnPropertyChanged("IsPurchasing");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.BoYesNoEnum> _IsPurchasing;
        partial void OnIsPurchasingChanging(global::System.Nullable<global::SAPB1.BoYesNoEnum> value);
        partial void OnIsPurchasingChanged();
        /// <summary>
        /// There are no comments for Property SalesOpportunities in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SalesOpportunities")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.SalesOpportunities> SalesOpportunities
        {
            get
            {
                return this._SalesOpportunities;
            }
            set
            {
                this.OnSalesOpportunitiesChanging(value);
                this._SalesOpportunities = value;
                this.OnSalesOpportunitiesChanged();
                this.OnPropertyChanged("SalesOpportunities");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.SalesOpportunities> _SalesOpportunities = new global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.SalesOpportunities>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnSalesOpportunitiesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::SAPB1.SalesOpportunities> value);
        partial void OnSalesOpportunitiesChanged();
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