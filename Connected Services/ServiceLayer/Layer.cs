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
    /// There are no comments for Layer in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("Layer")]
    public partial class Layer : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property TransactionSequenceNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TransactionSequenceNum")]
        public virtual global::System.Nullable<int> TransactionSequenceNum
        {
            get
            {
                return this._TransactionSequenceNum;
            }
            set
            {
                this.OnTransactionSequenceNumChanging(value);
                this._TransactionSequenceNum = value;
                this.OnTransactionSequenceNumChanged();
                this.OnPropertyChanged("TransactionSequenceNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _TransactionSequenceNum;
        partial void OnTransactionSequenceNumChanging(global::System.Nullable<int> value);
        partial void OnTransactionSequenceNumChanged();
        /// <summary>
        /// There are no comments for Property LayerID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LayerID")]
        public virtual global::System.Nullable<int> LayerID
        {
            get
            {
                return this._LayerID;
            }
            set
            {
                this.OnLayerIDChanging(value);
                this._LayerID = value;
                this.OnLayerIDChanged();
                this.OnPropertyChanged("LayerID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _LayerID;
        partial void OnLayerIDChanging(global::System.Nullable<int> value);
        partial void OnLayerIDChanged();
        /// <summary>
        /// There are no comments for Property DocNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocNumber")]
        public virtual string DocNumber
        {
            get
            {
                return this._DocNumber;
            }
            set
            {
                this.OnDocNumberChanging(value);
                this._DocNumber = value;
                this.OnDocNumberChanged();
                this.OnPropertyChanged("DocNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DocNumber;
        partial void OnDocNumberChanging(string value);
        partial void OnDocNumberChanged();
        /// <summary>
        /// There are no comments for Property DocType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DocType")]
        public virtual global::System.Nullable<global::SAPB1.TransTypesEnum> DocType
        {
            get
            {
                return this._DocType;
            }
            set
            {
                this.OnDocTypeChanging(value);
                this._DocType = value;
                this.OnDocTypeChanged();
                this.OnPropertyChanged("DocType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.TransTypesEnum> _DocType;
        partial void OnDocTypeChanging(global::System.Nullable<global::SAPB1.TransTypesEnum> value);
        partial void OnDocTypeChanged();
        /// <summary>
        /// There are no comments for Property EntryDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EntryDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> EntryDate
        {
            get
            {
                return this._EntryDate;
            }
            set
            {
                this.OnEntryDateChanging(value);
                this._EntryDate = value;
                this.OnEntryDateChanged();
                this.OnPropertyChanged("EntryDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _EntryDate;
        partial void OnEntryDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnEntryDateChanged();
        /// <summary>
        /// There are no comments for Property CurrentCost in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CurrentCost")]
        public virtual global::System.Nullable<double> CurrentCost
        {
            get
            {
                return this._CurrentCost;
            }
            set
            {
                this.OnCurrentCostChanging(value);
                this._CurrentCost = value;
                this.OnCurrentCostChanged();
                this.OnPropertyChanged("CurrentCost");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _CurrentCost;
        partial void OnCurrentCostChanging(global::System.Nullable<double> value);
        partial void OnCurrentCostChanged();
        /// <summary>
        /// There are no comments for Property OpenQty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OpenQty")]
        public virtual global::System.Nullable<double> OpenQty
        {
            get
            {
                return this._OpenQty;
            }
            set
            {
                this.OnOpenQtyChanging(value);
                this._OpenQty = value;
                this.OnOpenQtyChanged();
                this.OnPropertyChanged("OpenQty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _OpenQty;
        partial void OnOpenQtyChanging(global::System.Nullable<double> value);
        partial void OnOpenQtyChanged();
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
