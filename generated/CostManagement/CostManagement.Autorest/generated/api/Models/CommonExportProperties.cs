// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Extensions;

    /// <summary>The common properties of the export.</summary>
    public partial class CommonExportProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICommonExportProperties,
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICommonExportPropertiesInternal
    {

        /// <summary>
        /// Array of column names to be included in the export. If not provided then the export will include all available columns.
        /// The available columns can vary by customer channel (see examples).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> ConfigurationColumn { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).ConfigurationColumn; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).ConfigurationColumn = value ?? null /* arrayOf */; }

        /// <summary>The granularity of rows in the export. Currently only 'Daily' is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string DataSetGranularity { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).DataSetGranularity; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).DataSetGranularity = value ?? null; }

        /// <summary>Backing field for <see cref="Definition" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinition _definition;

        /// <summary>Has the definition for the export.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinition Definition { get => (this._definition = this._definition ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ExportDefinition()); set => this._definition = value; }

        /// <summary>
        /// The time frame for pulling data for the export. If custom, then a specific time period must be provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string DefinitionTimeframe { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).Timeframe; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).Timeframe = value ; }

        /// <summary>
        /// The type of the export. Note that 'Usage' is equivalent to 'ActualCost' and is applicable to exports that do not yet provide
        /// data for charges or amortization for service reservations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string DefinitionType { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).Type = value ; }

        /// <summary>Backing field for <see cref="DeliveryInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfo _deliveryInfo;

        /// <summary>Has delivery information for the export.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfo DeliveryInfo { get => (this._deliveryInfo = this._deliveryInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ExportDeliveryInfo()); set => this._deliveryInfo = value; }

        /// <summary>
        /// The name of the container where exports will be uploaded. If the container does not exist it will be created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string DestinationContainer { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfoInternal)DeliveryInfo).DestinationContainer; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfoInternal)DeliveryInfo).DestinationContainer = value ; }

        /// <summary>
        /// The resource id of the storage account where exports will be delivered. This is not required if a sasToken and storageAccount
        /// are specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string DestinationResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfoInternal)DeliveryInfo).DestinationResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfoInternal)DeliveryInfo).DestinationResourceId = value ?? null; }

        /// <summary>The name of the directory where exports will be uploaded.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string DestinationRootFolderPath { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfoInternal)DeliveryInfo).DestinationRootFolderPath; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfoInternal)DeliveryInfo).DestinationRootFolderPath = value ?? null; }

        /// <summary>
        /// A SAS token for the storage account. For a restricted set of Azure customers this together with storageAccount can be
        /// specified instead of resourceId. Note: the value returned by the API for this property will always be obfuscated. Returning
        /// this same obfuscated value will not result in the SAS token being updated. To update this value a new SAS token must be
        /// specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string DestinationSasToken { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfoInternal)DeliveryInfo).DestinationSasToken; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfoInternal)DeliveryInfo).DestinationSasToken = value ?? null; }

        /// <summary>
        /// The storage account where exports will be uploaded. For a restricted set of Azure customers this together with sasToken
        /// can be specified instead of resourceId.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string DestinationStorageAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfoInternal)DeliveryInfo).DestinationStorageAccount; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfoInternal)DeliveryInfo).DestinationStorageAccount = value ?? null; }

        /// <summary>Backing field for <see cref="Format" /> property.</summary>
        private string _format;

        /// <summary>The format of the export being delivered. Currently only 'Csv' is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string Format { get => this._format; set => this._format = value; }

        /// <summary>Internal Acessors for DataSetConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDatasetConfiguration Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICommonExportPropertiesInternal.DataSetConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).DataSetConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).DataSetConfiguration = value; }

        /// <summary>Internal Acessors for Definition</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinition Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICommonExportPropertiesInternal.Definition { get => (this._definition = this._definition ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ExportDefinition()); set { {_definition = value;} } }

        /// <summary>Internal Acessors for DefinitionDataSet</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDataset Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICommonExportPropertiesInternal.DefinitionDataSet { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).DataSet; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).DataSet = value; }

        /// <summary>Internal Acessors for DefinitionTimePeriod</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportTimePeriod Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICommonExportPropertiesInternal.DefinitionTimePeriod { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).TimePeriod; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).TimePeriod = value; }

        /// <summary>Internal Acessors for DeliveryInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfo Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICommonExportPropertiesInternal.DeliveryInfo { get => (this._deliveryInfo = this._deliveryInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ExportDeliveryInfo()); set { {_deliveryInfo = value;} } }

        /// <summary>Internal Acessors for DeliveryInfoDestination</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryDestination Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICommonExportPropertiesInternal.DeliveryInfoDestination { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfoInternal)DeliveryInfo).Destination; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfoInternal)DeliveryInfo).Destination = value; }

        /// <summary>Internal Acessors for NextRunTimeEstimate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICommonExportPropertiesInternal.NextRunTimeEstimate { get => this._nextRunTimeEstimate; set { {_nextRunTimeEstimate = value;} } }

        /// <summary>Internal Acessors for RunHistory</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportExecutionListResult Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICommonExportPropertiesInternal.RunHistory { get => (this._runHistory = this._runHistory ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ExportExecutionListResult()); set { {_runHistory = value;} } }

        /// <summary>Internal Acessors for RunHistoryValue</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportExecution> Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ICommonExportPropertiesInternal.RunHistoryValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportExecutionListResultInternal)RunHistory).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportExecutionListResultInternal)RunHistory).Value = value; }

        /// <summary>Backing field for <see cref="NextRunTimeEstimate" /> property.</summary>
        private global::System.DateTime? _nextRunTimeEstimate;

        /// <summary>
        /// If the export has an active schedule, provides an estimate of the next execution time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public global::System.DateTime? NextRunTimeEstimate { get => this._nextRunTimeEstimate; }

        /// <summary>Backing field for <see cref="PartitionData" /> property.</summary>
        private bool? _partitionData;

        /// <summary>
        /// If set to true, exported data will be partitioned by size and placed in a blob directory together with a manifest file.
        /// Note: this option is currently available only for modern commerce scopes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public bool? PartitionData { get => this._partitionData; set => this._partitionData = value; }

        /// <summary>Backing field for <see cref="RunHistory" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportExecutionListResult _runHistory;

        /// <summary>If requested, has the most recent execution history for the export.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportExecutionListResult RunHistory { get => (this._runHistory = this._runHistory ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.ExportExecutionListResult()); set => this._runHistory = value; }

        /// <summary>A list of export executions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportExecution> RunHistoryValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportExecutionListResultInternal)RunHistory).Value; }

        /// <summary>The start date for export data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public global::System.DateTime? TimePeriodFrom { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).TimePeriodFrom; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).TimePeriodFrom = value ?? default(global::System.DateTime); }

        /// <summary>The end date for export data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public global::System.DateTime? TimePeriodTo { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).TimePeriodTo; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinitionInternal)Definition).TimePeriodTo = value ?? default(global::System.DateTime); }

        /// <summary>Creates an new <see cref="CommonExportProperties" /> instance.</summary>
        public CommonExportProperties()
        {

        }
    }
    /// The common properties of the export.
    public partial interface ICommonExportProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Array of column names to be included in the export. If not provided then the export will include all available columns.
        /// The available columns can vary by customer channel (see examples).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Array of column names to be included in the export. If not provided then the export will include all available columns. The available columns can vary by customer channel (see examples).",
        SerializedName = @"columns",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ConfigurationColumn { get; set; }
        /// <summary>The granularity of rows in the export. Currently only 'Daily' is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The granularity of rows in the export. Currently only 'Daily' is supported.",
        SerializedName = @"granularity",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PSArgumentCompleterAttribute("Daily")]
        string DataSetGranularity { get; set; }
        /// <summary>
        /// The time frame for pulling data for the export. If custom, then a specific time period must be provided.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The time frame for pulling data for the export. If custom, then a specific time period must be provided.",
        SerializedName = @"timeframe",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PSArgumentCompleterAttribute("MonthToDate", "BillingMonthToDate", "TheLastMonth", "TheLastBillingMonth", "WeekToDate", "Custom")]
        string DefinitionTimeframe { get; set; }
        /// <summary>
        /// The type of the export. Note that 'Usage' is equivalent to 'ActualCost' and is applicable to exports that do not yet provide
        /// data for charges or amortization for service reservations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of the export. Note that 'Usage' is equivalent to 'ActualCost' and is applicable to exports that do not yet provide data for charges or amortization for service reservations.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PSArgumentCompleterAttribute("Usage", "ActualCost", "AmortizedCost")]
        string DefinitionType { get; set; }
        /// <summary>
        /// The name of the container where exports will be uploaded. If the container does not exist it will be created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the container where exports will be uploaded. If the container does not exist it will be created.",
        SerializedName = @"container",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationContainer { get; set; }
        /// <summary>
        /// The resource id of the storage account where exports will be delivered. This is not required if a sasToken and storageAccount
        /// are specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The resource id of the storage account where exports will be delivered. This is not required if a sasToken and storageAccount are specified.",
        SerializedName = @"resourceId",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationResourceId { get; set; }
        /// <summary>The name of the directory where exports will be uploaded.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the directory where exports will be uploaded.",
        SerializedName = @"rootFolderPath",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationRootFolderPath { get; set; }
        /// <summary>
        /// A SAS token for the storage account. For a restricted set of Azure customers this together with storageAccount can be
        /// specified instead of resourceId. Note: the value returned by the API for this property will always be obfuscated. Returning
        /// this same obfuscated value will not result in the SAS token being updated. To update this value a new SAS token must be
        /// specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A SAS token for the storage account. For a restricted set of Azure customers this together with storageAccount can be specified instead of resourceId. Note: the value returned by the API for this property will always be obfuscated. Returning this same obfuscated value will not result in the SAS token being updated. To update this value a new SAS token must be specified.",
        SerializedName = @"sasToken",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationSasToken { get; set; }
        /// <summary>
        /// The storage account where exports will be uploaded. For a restricted set of Azure customers this together with sasToken
        /// can be specified instead of resourceId.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The storage account where exports will be uploaded. For a restricted set of Azure customers this together with sasToken can be specified instead of resourceId.",
        SerializedName = @"storageAccount",
        PossibleTypes = new [] { typeof(string) })]
        string DestinationStorageAccount { get; set; }
        /// <summary>The format of the export being delivered. Currently only 'Csv' is supported.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The format of the export being delivered. Currently only 'Csv' is supported.",
        SerializedName = @"format",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PSArgumentCompleterAttribute("Csv")]
        string Format { get; set; }
        /// <summary>
        /// If the export has an active schedule, provides an estimate of the next execution time.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"If the export has an active schedule, provides an estimate of the next execution time.",
        SerializedName = @"nextRunTimeEstimate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? NextRunTimeEstimate { get;  }
        /// <summary>
        /// If set to true, exported data will be partitioned by size and placed in a blob directory together with a manifest file.
        /// Note: this option is currently available only for modern commerce scopes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"If set to true, exported data will be partitioned by size and placed in a blob directory together with a manifest file. Note: this option is currently available only for modern commerce scopes.",
        SerializedName = @"partitionData",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PartitionData { get; set; }
        /// <summary>A list of export executions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"A list of export executions.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportExecution) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportExecution> RunHistoryValue { get;  }
        /// <summary>The start date for export data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The start date for export data.",
        SerializedName = @"from",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TimePeriodFrom { get; set; }
        /// <summary>The end date for export data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The end date for export data.",
        SerializedName = @"to",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TimePeriodTo { get; set; }

    }
    /// The common properties of the export.
    public partial interface ICommonExportPropertiesInternal

    {
        /// <summary>
        /// Array of column names to be included in the export. If not provided then the export will include all available columns.
        /// The available columns can vary by customer channel (see examples).
        /// </summary>
        System.Collections.Generic.List<string> ConfigurationColumn { get; set; }
        /// <summary>The export dataset configuration.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDatasetConfiguration DataSetConfiguration { get; set; }
        /// <summary>The granularity of rows in the export. Currently only 'Daily' is supported.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PSArgumentCompleterAttribute("Daily")]
        string DataSetGranularity { get; set; }
        /// <summary>Has the definition for the export.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDefinition Definition { get; set; }
        /// <summary>The definition for data in the export.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDataset DefinitionDataSet { get; set; }
        /// <summary>Has time period for pulling data for the export.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportTimePeriod DefinitionTimePeriod { get; set; }
        /// <summary>
        /// The time frame for pulling data for the export. If custom, then a specific time period must be provided.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PSArgumentCompleterAttribute("MonthToDate", "BillingMonthToDate", "TheLastMonth", "TheLastBillingMonth", "WeekToDate", "Custom")]
        string DefinitionTimeframe { get; set; }
        /// <summary>
        /// The type of the export. Note that 'Usage' is equivalent to 'ActualCost' and is applicable to exports that do not yet provide
        /// data for charges or amortization for service reservations.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PSArgumentCompleterAttribute("Usage", "ActualCost", "AmortizedCost")]
        string DefinitionType { get; set; }
        /// <summary>Has delivery information for the export.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryInfo DeliveryInfo { get; set; }
        /// <summary>Has destination for the export being delivered.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportDeliveryDestination DeliveryInfoDestination { get; set; }
        /// <summary>
        /// The name of the container where exports will be uploaded. If the container does not exist it will be created.
        /// </summary>
        string DestinationContainer { get; set; }
        /// <summary>
        /// The resource id of the storage account where exports will be delivered. This is not required if a sasToken and storageAccount
        /// are specified.
        /// </summary>
        string DestinationResourceId { get; set; }
        /// <summary>The name of the directory where exports will be uploaded.</summary>
        string DestinationRootFolderPath { get; set; }
        /// <summary>
        /// A SAS token for the storage account. For a restricted set of Azure customers this together with storageAccount can be
        /// specified instead of resourceId. Note: the value returned by the API for this property will always be obfuscated. Returning
        /// this same obfuscated value will not result in the SAS token being updated. To update this value a new SAS token must be
        /// specified.
        /// </summary>
        string DestinationSasToken { get; set; }
        /// <summary>
        /// The storage account where exports will be uploaded. For a restricted set of Azure customers this together with sasToken
        /// can be specified instead of resourceId.
        /// </summary>
        string DestinationStorageAccount { get; set; }
        /// <summary>The format of the export being delivered. Currently only 'Csv' is supported.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PSArgumentCompleterAttribute("Csv")]
        string Format { get; set; }
        /// <summary>
        /// If the export has an active schedule, provides an estimate of the next execution time.
        /// </summary>
        global::System.DateTime? NextRunTimeEstimate { get; set; }
        /// <summary>
        /// If set to true, exported data will be partitioned by size and placed in a blob directory together with a manifest file.
        /// Note: this option is currently available only for modern commerce scopes.
        /// </summary>
        bool? PartitionData { get; set; }
        /// <summary>If requested, has the most recent execution history for the export.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportExecutionListResult RunHistory { get; set; }
        /// <summary>A list of export executions.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.IExportExecution> RunHistoryValue { get; set; }
        /// <summary>The start date for export data.</summary>
        global::System.DateTime? TimePeriodFrom { get; set; }
        /// <summary>The end date for export data.</summary>
        global::System.DateTime? TimePeriodTo { get; set; }

    }
}