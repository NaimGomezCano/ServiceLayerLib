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
    /// There are no comments for ResourceCapacitySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ResourceCapacitySingle")]
    public partial class ResourceCapacitySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ResourceCapacity>
    {
        /// <summary>
        /// Initialize a new ResourceCapacitySingle object.
        /// </summary>
        public ResourceCapacitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ResourceCapacitySingle object.
        /// </summary>
        public ResourceCapacitySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ResourceCapacitySingle object.
        /// </summary>
        public ResourceCapacitySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ResourceCapacity> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Resource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Resource")]
        public virtual global::SAPB1.ResourceSingle Resource
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Resource == null))
                {
                    this._Resource = new global::SAPB1.ResourceSingle(this.Context, GetPath("Resource"));
                }
                return this._Resource;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.ResourceSingle _Resource;
        /// <summary>
        /// There are no comments for Warehouse2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Warehouse2")]
        public virtual global::SAPB1.WarehouseSingle Warehouse2
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Warehouse2 == null))
                {
                    this._Warehouse2 = new global::SAPB1.WarehouseSingle(this.Context, GetPath("Warehouse2"));
                }
                return this._Warehouse2;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.WarehouseSingle _Warehouse2;
    }
    /// <summary>
    /// There are no comments for ResourceCapacity in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.EntitySet("ResourceCapacities")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ResourceCapacity")]
    public partial class ResourceCapacity : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ResourceCapacity object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ResourceCapacity CreateResourceCapacity(int ID)
        {
            ResourceCapacity resourceCapacity = new ResourceCapacity();
            resourceCapacity.Id = ID;
            return resourceCapacity;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Id is required.")]
        public virtual int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
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
        /// There are no comments for Property Warehouse in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Warehouse")]
        public virtual string Warehouse
        {
            get
            {
                return this._Warehouse;
            }
            set
            {
                this.OnWarehouseChanging(value);
                this._Warehouse = value;
                this.OnWarehouseChanged();
                this.OnPropertyChanged("Warehouse");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Warehouse;
        partial void OnWarehouseChanging(string value);
        partial void OnWarehouseChanged();
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
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Type")]
        public virtual global::System.Nullable<global::SAPB1.ResourceCapacityTypeEnum> Type
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
        private global::System.Nullable<global::SAPB1.ResourceCapacityTypeEnum> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::SAPB1.ResourceCapacityTypeEnum> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property Capacity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Capacity")]
        public virtual global::System.Nullable<double> Capacity
        {
            get
            {
                return this._Capacity;
            }
            set
            {
                this.OnCapacityChanging(value);
                this._Capacity = value;
                this.OnCapacityChanged();
                this.OnPropertyChanged("Capacity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Capacity;
        partial void OnCapacityChanging(global::System.Nullable<double> value);
        partial void OnCapacityChanged();
        /// <summary>
        /// There are no comments for Property SourceType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceType")]
        public virtual global::System.Nullable<global::SAPB1.ResourceCapacitySourceTypeEnum> SourceType
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
        private global::System.Nullable<global::SAPB1.ResourceCapacitySourceTypeEnum> _SourceType;
        partial void OnSourceTypeChanging(global::System.Nullable<global::SAPB1.ResourceCapacitySourceTypeEnum> value);
        partial void OnSourceTypeChanged();
        /// <summary>
        /// There are no comments for Property SourceEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceEntry")]
        public virtual global::System.Nullable<int> SourceEntry
        {
            get
            {
                return this._SourceEntry;
            }
            set
            {
                this.OnSourceEntryChanging(value);
                this._SourceEntry = value;
                this.OnSourceEntryChanged();
                this.OnPropertyChanged("SourceEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SourceEntry;
        partial void OnSourceEntryChanging(global::System.Nullable<int> value);
        partial void OnSourceEntryChanged();
        /// <summary>
        /// There are no comments for Property SourceLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceLineNum")]
        public virtual global::System.Nullable<int> SourceLineNum
        {
            get
            {
                return this._SourceLineNum;
            }
            set
            {
                this.OnSourceLineNumChanging(value);
                this._SourceLineNum = value;
                this.OnSourceLineNumChanged();
                this.OnPropertyChanged("SourceLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _SourceLineNum;
        partial void OnSourceLineNumChanging(global::System.Nullable<int> value);
        partial void OnSourceLineNumChanged();
        /// <summary>
        /// There are no comments for Property BaseType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseType")]
        public virtual global::System.Nullable<global::SAPB1.ResourceCapacityBaseTypeEnum> BaseType
        {
            get
            {
                return this._BaseType;
            }
            set
            {
                this.OnBaseTypeChanging(value);
                this._BaseType = value;
                this.OnBaseTypeChanged();
                this.OnPropertyChanged("BaseType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ResourceCapacityBaseTypeEnum> _BaseType;
        partial void OnBaseTypeChanging(global::System.Nullable<global::SAPB1.ResourceCapacityBaseTypeEnum> value);
        partial void OnBaseTypeChanged();
        /// <summary>
        /// There are no comments for Property BaseEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseEntry")]
        public virtual global::System.Nullable<int> BaseEntry
        {
            get
            {
                return this._BaseEntry;
            }
            set
            {
                this.OnBaseEntryChanging(value);
                this._BaseEntry = value;
                this.OnBaseEntryChanged();
                this.OnPropertyChanged("BaseEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BaseEntry;
        partial void OnBaseEntryChanging(global::System.Nullable<int> value);
        partial void OnBaseEntryChanged();
        /// <summary>
        /// There are no comments for Property BaseLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("BaseLineNum")]
        public virtual global::System.Nullable<int> BaseLineNum
        {
            get
            {
                return this._BaseLineNum;
            }
            set
            {
                this.OnBaseLineNumChanging(value);
                this._BaseLineNum = value;
                this.OnBaseLineNumChanged();
                this.OnPropertyChanged("BaseLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _BaseLineNum;
        partial void OnBaseLineNumChanging(global::System.Nullable<int> value);
        partial void OnBaseLineNumChanged();
        /// <summary>
        /// There are no comments for Property Action in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Action")]
        public virtual global::System.Nullable<global::SAPB1.ResourceCapacityActionEnum> Action
        {
            get
            {
                return this._Action;
            }
            set
            {
                this.OnActionChanging(value);
                this._Action = value;
                this.OnActionChanged();
                this.OnPropertyChanged("Action");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ResourceCapacityActionEnum> _Action;
        partial void OnActionChanging(global::System.Nullable<global::SAPB1.ResourceCapacityActionEnum> value);
        partial void OnActionChanged();
        /// <summary>
        /// There are no comments for Property OwningType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OwningType")]
        public virtual global::System.Nullable<global::SAPB1.ResourceCapacityOwningTypeEnum> OwningType
        {
            get
            {
                return this._OwningType;
            }
            set
            {
                this.OnOwningTypeChanging(value);
                this._OwningType = value;
                this.OnOwningTypeChanged();
                this.OnPropertyChanged("OwningType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ResourceCapacityOwningTypeEnum> _OwningType;
        partial void OnOwningTypeChanging(global::System.Nullable<global::SAPB1.ResourceCapacityOwningTypeEnum> value);
        partial void OnOwningTypeChanged();
        /// <summary>
        /// There are no comments for Property OwningEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OwningEntry")]
        public virtual global::System.Nullable<int> OwningEntry
        {
            get
            {
                return this._OwningEntry;
            }
            set
            {
                this.OnOwningEntryChanging(value);
                this._OwningEntry = value;
                this.OnOwningEntryChanged();
                this.OnPropertyChanged("OwningEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _OwningEntry;
        partial void OnOwningEntryChanging(global::System.Nullable<int> value);
        partial void OnOwningEntryChanged();
        /// <summary>
        /// There are no comments for Property OwningLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OwningLineNum")]
        public virtual global::System.Nullable<int> OwningLineNum
        {
            get
            {
                return this._OwningLineNum;
            }
            set
            {
                this.OnOwningLineNumChanging(value);
                this._OwningLineNum = value;
                this.OnOwningLineNumChanged();
                this.OnPropertyChanged("OwningLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _OwningLineNum;
        partial void OnOwningLineNumChanging(global::System.Nullable<int> value);
        partial void OnOwningLineNumChanged();
        /// <summary>
        /// There are no comments for Property RevertedType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RevertedType")]
        public virtual global::System.Nullable<global::SAPB1.ResourceCapacityRevertedTypeEnum> RevertedType
        {
            get
            {
                return this._RevertedType;
            }
            set
            {
                this.OnRevertedTypeChanging(value);
                this._RevertedType = value;
                this.OnRevertedTypeChanged();
                this.OnPropertyChanged("RevertedType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ResourceCapacityRevertedTypeEnum> _RevertedType;
        partial void OnRevertedTypeChanging(global::System.Nullable<global::SAPB1.ResourceCapacityRevertedTypeEnum> value);
        partial void OnRevertedTypeChanged();
        /// <summary>
        /// There are no comments for Property RevertedEntry in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RevertedEntry")]
        public virtual global::System.Nullable<int> RevertedEntry
        {
            get
            {
                return this._RevertedEntry;
            }
            set
            {
                this.OnRevertedEntryChanging(value);
                this._RevertedEntry = value;
                this.OnRevertedEntryChanged();
                this.OnPropertyChanged("RevertedEntry");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _RevertedEntry;
        partial void OnRevertedEntryChanging(global::System.Nullable<int> value);
        partial void OnRevertedEntryChanged();
        /// <summary>
        /// There are no comments for Property RevertedLineNum in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RevertedLineNum")]
        public virtual global::System.Nullable<int> RevertedLineNum
        {
            get
            {
                return this._RevertedLineNum;
            }
            set
            {
                this.OnRevertedLineNumChanging(value);
                this._RevertedLineNum = value;
                this.OnRevertedLineNumChanged();
                this.OnPropertyChanged("RevertedLineNum");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _RevertedLineNum;
        partial void OnRevertedLineNumChanging(global::System.Nullable<int> value);
        partial void OnRevertedLineNumChanged();
        /// <summary>
        /// There are no comments for Property MemoSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MemoSource")]
        public virtual global::System.Nullable<global::SAPB1.ResourceCapacityMemoSourceEnum> MemoSource
        {
            get
            {
                return this._MemoSource;
            }
            set
            {
                this.OnMemoSourceChanging(value);
                this._MemoSource = value;
                this.OnMemoSourceChanged();
                this.OnPropertyChanged("MemoSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ResourceCapacityMemoSourceEnum> _MemoSource;
        partial void OnMemoSourceChanging(global::System.Nullable<global::SAPB1.ResourceCapacityMemoSourceEnum> value);
        partial void OnMemoSourceChanged();
        /// <summary>
        /// There are no comments for Property Memo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Memo")]
        public virtual string Memo
        {
            get
            {
                return this._Memo;
            }
            set
            {
                this.OnMemoChanging(value);
                this._Memo = value;
                this.OnMemoChanged();
                this.OnPropertyChanged("Memo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Memo;
        partial void OnMemoChanging(string value);
        partial void OnMemoChanged();
        /// <summary>
        /// There are no comments for Property SingleRunCapacity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SingleRunCapacity")]
        public virtual global::System.Nullable<double> SingleRunCapacity
        {
            get
            {
                return this._SingleRunCapacity;
            }
            set
            {
                this.OnSingleRunCapacityChanging(value);
                this._SingleRunCapacity = value;
                this.OnSingleRunCapacityChanged();
                this.OnPropertyChanged("SingleRunCapacity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _SingleRunCapacity;
        partial void OnSingleRunCapacityChanging(global::System.Nullable<double> value);
        partial void OnSingleRunCapacityChanged();
        /// <summary>
        /// There are no comments for Property SingleRunMemoSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SingleRunMemoSource")]
        public virtual global::System.Nullable<global::SAPB1.ResourceCapacityMemoSourceEnum> SingleRunMemoSource
        {
            get
            {
                return this._SingleRunMemoSource;
            }
            set
            {
                this.OnSingleRunMemoSourceChanging(value);
                this._SingleRunMemoSource = value;
                this.OnSingleRunMemoSourceChanged();
                this.OnPropertyChanged("SingleRunMemoSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ResourceCapacityMemoSourceEnum> _SingleRunMemoSource;
        partial void OnSingleRunMemoSourceChanging(global::System.Nullable<global::SAPB1.ResourceCapacityMemoSourceEnum> value);
        partial void OnSingleRunMemoSourceChanged();
        /// <summary>
        /// There are no comments for Property SingleRunMemo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SingleRunMemo")]
        public virtual string SingleRunMemo
        {
            get
            {
                return this._SingleRunMemo;
            }
            set
            {
                this.OnSingleRunMemoChanging(value);
                this._SingleRunMemo = value;
                this.OnSingleRunMemoChanged();
                this.OnPropertyChanged("SingleRunMemo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SingleRunMemo;
        partial void OnSingleRunMemoChanging(string value);
        partial void OnSingleRunMemoChanged();
        /// <summary>
        /// There are no comments for Property Resource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Resource")]
        public virtual global::SAPB1.Resource Resource
        {
            get
            {
                return this._Resource;
            }
            set
            {
                this.OnResourceChanging(value);
                this._Resource = value;
                this.OnResourceChanged();
                this.OnPropertyChanged("Resource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.Resource _Resource;
        partial void OnResourceChanging(global::SAPB1.Resource value);
        partial void OnResourceChanged();
        /// <summary>
        /// There are no comments for Property Warehouse2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Warehouse2")]
        public virtual global::SAPB1.Warehouse Warehouse2
        {
            get
            {
                return this._Warehouse2;
            }
            set
            {
                this.OnWarehouse2Changing(value);
                this._Warehouse2 = value;
                this.OnWarehouse2Changed();
                this.OnPropertyChanged("Warehouse2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::SAPB1.Warehouse _Warehouse2;
        partial void OnWarehouse2Changing(global::SAPB1.Warehouse value);
        partial void OnWarehouse2Changed();
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
