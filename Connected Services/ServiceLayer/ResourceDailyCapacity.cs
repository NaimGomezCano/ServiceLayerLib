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
    /// There are no comments for ResourceDailyCapacity in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ResourceDailyCapacity")]
    public partial class ResourceDailyCapacity : global::System.ComponentModel.INotifyPropertyChanged
    {
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
        /// There are no comments for Property Weekday in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Weekday")]
        public virtual global::System.Nullable<global::SAPB1.ResourceDailyCapacityWeekdayEnum> Weekday
        {
            get
            {
                return this._Weekday;
            }
            set
            {
                this.OnWeekdayChanging(value);
                this._Weekday = value;
                this.OnWeekdayChanged();
                this.OnPropertyChanged("Weekday");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::SAPB1.ResourceDailyCapacityWeekdayEnum> _Weekday;
        partial void OnWeekdayChanging(global::System.Nullable<global::SAPB1.ResourceDailyCapacityWeekdayEnum> value);
        partial void OnWeekdayChanged();
        /// <summary>
        /// There are no comments for Property Factor1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Factor1")]
        public virtual global::System.Nullable<double> Factor1
        {
            get
            {
                return this._Factor1;
            }
            set
            {
                this.OnFactor1Changing(value);
                this._Factor1 = value;
                this.OnFactor1Changed();
                this.OnPropertyChanged("Factor1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Factor1;
        partial void OnFactor1Changing(global::System.Nullable<double> value);
        partial void OnFactor1Changed();
        /// <summary>
        /// There are no comments for Property Factor2 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Factor2")]
        public virtual global::System.Nullable<double> Factor2
        {
            get
            {
                return this._Factor2;
            }
            set
            {
                this.OnFactor2Changing(value);
                this._Factor2 = value;
                this.OnFactor2Changed();
                this.OnPropertyChanged("Factor2");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Factor2;
        partial void OnFactor2Changing(global::System.Nullable<double> value);
        partial void OnFactor2Changed();
        /// <summary>
        /// There are no comments for Property Factor3 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Factor3")]
        public virtual global::System.Nullable<double> Factor3
        {
            get
            {
                return this._Factor3;
            }
            set
            {
                this.OnFactor3Changing(value);
                this._Factor3 = value;
                this.OnFactor3Changed();
                this.OnPropertyChanged("Factor3");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Factor3;
        partial void OnFactor3Changing(global::System.Nullable<double> value);
        partial void OnFactor3Changed();
        /// <summary>
        /// There are no comments for Property Factor4 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Factor4")]
        public virtual global::System.Nullable<double> Factor4
        {
            get
            {
                return this._Factor4;
            }
            set
            {
                this.OnFactor4Changing(value);
                this._Factor4 = value;
                this.OnFactor4Changed();
                this.OnPropertyChanged("Factor4");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Factor4;
        partial void OnFactor4Changing(global::System.Nullable<double> value);
        partial void OnFactor4Changed();
        /// <summary>
        /// There are no comments for Property Total in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Total")]
        public virtual global::System.Nullable<double> Total
        {
            get
            {
                return this._Total;
            }
            set
            {
                this.OnTotalChanging(value);
                this._Total = value;
                this.OnTotalChanged();
                this.OnPropertyChanged("Total");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _Total;
        partial void OnTotalChanging(global::System.Nullable<double> value);
        partial void OnTotalChanged();
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
        /// There are no comments for Property SingleRun in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SingleRun")]
        public virtual global::System.Nullable<double> SingleRun
        {
            get
            {
                return this._SingleRun;
            }
            set
            {
                this.OnSingleRunChanging(value);
                this._SingleRun = value;
                this.OnSingleRunChanged();
                this.OnPropertyChanged("SingleRun");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<double> _SingleRun;
        partial void OnSingleRunChanging(global::System.Nullable<double> value);
        partial void OnSingleRunChanged();
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