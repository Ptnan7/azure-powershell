// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Extensions;

    /// <summary>Class representing the Kusto event grid connection properties.</summary>
    public partial class EventGridConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal
    {

        /// <summary>Backing field for <see cref="BlobStorageEventType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType? _blobStorageEventType;

        /// <summary>The name of blob storage event type to process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType? BlobStorageEventType { get => this._blobStorageEventType; set => this._blobStorageEventType = value; }

        /// <summary>Backing field for <see cref="ConsumerGroup" /> property.</summary>
        private string _consumerGroup;

        /// <summary>The event hub consumer group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string ConsumerGroup { get => this._consumerGroup; set => this._consumerGroup = value; }

        /// <summary>Backing field for <see cref="DataFormat" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat? _dataFormat;

        /// <summary>
        /// The data format of the message. Optionally the data format can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat? DataFormat { get => this._dataFormat; set => this._dataFormat = value; }

        /// <summary>Backing field for <see cref="DatabaseRouting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting? _databaseRouting;

        /// <summary>
        /// Indication for database routing information from the data connection, by default only database routing information is
        /// allowed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting? DatabaseRouting { get => this._databaseRouting; set => this._databaseRouting = value; }

        /// <summary>Backing field for <see cref="EventGridResourceId" /> property.</summary>
        private string _eventGridResourceId;

        /// <summary>
        /// The resource ID of the event grid that is subscribed to the storage account events.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string EventGridResourceId { get => this._eventGridResourceId; set => this._eventGridResourceId = value; }

        /// <summary>Backing field for <see cref="EventHubResourceId" /> property.</summary>
        private string _eventHubResourceId;

        /// <summary>The resource ID where the event grid is configured to send events.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string EventHubResourceId { get => this._eventHubResourceId; set => this._eventHubResourceId = value; }

        /// <summary>Backing field for <see cref="IgnoreFirstRecord" /> property.</summary>
        private bool? _ignoreFirstRecord;

        /// <summary>
        /// A Boolean value that, if set to true, indicates that ingestion should ignore the first record of every file
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public bool? IgnoreFirstRecord { get => this._ignoreFirstRecord; set => this._ignoreFirstRecord = value; }

        /// <summary>Backing field for <see cref="ManagedIdentityObjectId" /> property.</summary>
        private string _managedIdentityObjectId;

        /// <summary>The object ID of managedIdentityResourceId</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string ManagedIdentityObjectId { get => this._managedIdentityObjectId; }

        /// <summary>Backing field for <see cref="ManagedIdentityResourceId" /> property.</summary>
        private string _managedIdentityResourceId;

        /// <summary>
        /// The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub and storage
        /// account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string ManagedIdentityResourceId { get => this._managedIdentityResourceId; set => this._managedIdentityResourceId = value; }

        /// <summary>Backing field for <see cref="MappingRuleName" /> property.</summary>
        private string _mappingRuleName;

        /// <summary>
        /// The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string MappingRuleName { get => this._mappingRuleName; set => this._mappingRuleName = value; }

        /// <summary>Internal Acessors for ManagedIdentityObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal.ManagedIdentityObjectId { get => this._managedIdentityObjectId; set { {_managedIdentityObjectId = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IEventGridConnectionPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? _provisioningState;

        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="StorageAccountResourceId" /> property.</summary>
        private string _storageAccountResourceId;

        /// <summary>The resource ID of the storage account where the data resides.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string StorageAccountResourceId { get => this._storageAccountResourceId; set => this._storageAccountResourceId = value; }

        /// <summary>Backing field for <see cref="TableName" /> property.</summary>
        private string _tableName;

        /// <summary>
        /// The table where the data should be ingested. Optionally the table information can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string TableName { get => this._tableName; set => this._tableName = value; }

        /// <summary>Creates an new <see cref="EventGridConnectionProperties" /> instance.</summary>
        public EventGridConnectionProperties()
        {

        }
    }
    /// Class representing the Kusto event grid connection properties.
    public partial interface IEventGridConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IJsonSerializable
    {
        /// <summary>The name of blob storage event type to process.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of blob storage event type to process.",
        SerializedName = @"blobStorageEventType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType? BlobStorageEventType { get; set; }
        /// <summary>The event hub consumer group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The event hub consumer group.",
        SerializedName = @"consumerGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ConsumerGroup { get; set; }
        /// <summary>
        /// The data format of the message. Optionally the data format can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The data format of the message. Optionally the data format can be added to each message.",
        SerializedName = @"dataFormat",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat? DataFormat { get; set; }
        /// <summary>
        /// Indication for database routing information from the data connection, by default only database routing information is
        /// allowed
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indication for database routing information from the data connection, by default only database routing information is allowed",
        SerializedName = @"databaseRouting",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting? DatabaseRouting { get; set; }
        /// <summary>
        /// The resource ID of the event grid that is subscribed to the storage account events.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of the event grid that is subscribed to the storage account events.",
        SerializedName = @"eventGridResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string EventGridResourceId { get; set; }
        /// <summary>The resource ID where the event grid is configured to send events.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource ID where the event grid is configured to send events.",
        SerializedName = @"eventHubResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string EventHubResourceId { get; set; }
        /// <summary>
        /// A Boolean value that, if set to true, indicates that ingestion should ignore the first record of every file
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A Boolean value that, if set to true, indicates that ingestion should ignore the first record of every file",
        SerializedName = @"ignoreFirstRecord",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IgnoreFirstRecord { get; set; }
        /// <summary>The object ID of managedIdentityResourceId</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The object ID of managedIdentityResourceId",
        SerializedName = @"managedIdentityObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedIdentityObjectId { get;  }
        /// <summary>
        /// The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub and storage
        /// account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub and storage account.",
        SerializedName = @"managedIdentityResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedIdentityResourceId { get; set; }
        /// <summary>
        /// The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message.",
        SerializedName = @"mappingRuleName",
        PossibleTypes = new [] { typeof(string) })]
        string MappingRuleName { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioned state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>The resource ID of the storage account where the data resides.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The resource ID of the storage account where the data resides.",
        SerializedName = @"storageAccountResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string StorageAccountResourceId { get; set; }
        /// <summary>
        /// The table where the data should be ingested. Optionally the table information can be added to each message.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The table where the data should be ingested. Optionally the table information can be added to each message.",
        SerializedName = @"tableName",
        PossibleTypes = new [] { typeof(string) })]
        string TableName { get; set; }

    }
    /// Class representing the Kusto event grid connection properties.
    internal partial interface IEventGridConnectionPropertiesInternal

    {
        /// <summary>The name of blob storage event type to process.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.BlobStorageEventType? BlobStorageEventType { get; set; }
        /// <summary>The event hub consumer group.</summary>
        string ConsumerGroup { get; set; }
        /// <summary>
        /// The data format of the message. Optionally the data format can be added to each message.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat? DataFormat { get; set; }
        /// <summary>
        /// Indication for database routing information from the data connection, by default only database routing information is
        /// allowed
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.DatabaseRouting? DatabaseRouting { get; set; }
        /// <summary>
        /// The resource ID of the event grid that is subscribed to the storage account events.
        /// </summary>
        string EventGridResourceId { get; set; }
        /// <summary>The resource ID where the event grid is configured to send events.</summary>
        string EventHubResourceId { get; set; }
        /// <summary>
        /// A Boolean value that, if set to true, indicates that ingestion should ignore the first record of every file
        /// </summary>
        bool? IgnoreFirstRecord { get; set; }
        /// <summary>The object ID of managedIdentityResourceId</summary>
        string ManagedIdentityObjectId { get; set; }
        /// <summary>
        /// The resource ID of a managed identity (system or user assigned) to be used to authenticate with event hub and storage
        /// account.
        /// </summary>
        string ManagedIdentityResourceId { get; set; }
        /// <summary>
        /// The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message.
        /// </summary>
        string MappingRuleName { get; set; }
        /// <summary>The provisioned state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>The resource ID of the storage account where the data resides.</summary>
        string StorageAccountResourceId { get; set; }
        /// <summary>
        /// The table where the data should be ingested. Optionally the table information can be added to each message.
        /// </summary>
        string TableName { get; set; }

    }
}