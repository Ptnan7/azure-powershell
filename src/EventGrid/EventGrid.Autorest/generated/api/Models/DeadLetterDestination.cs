// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>
    /// Information about the dead letter destination for an event subscription. To configure a deadletter destination, do not
    /// directly instantiate an object of this class. Instead, instantiate an object of a derived class. Currently, StorageBlobDeadLetterDestination
    /// is the only class that derives from this class.
    /// </summary>
    public partial class DeadLetterDestination :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterDestination,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterDestinationInternal
    {

        /// <summary>Backing field for <see cref="EndpointType" /> property.</summary>
        private string _endpointType= @"StorageBlob";

        /// <summary>Type of the endpoint for the dead letter destination</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string EndpointType { get => this._endpointType; }

        /// <summary>Internal Acessors for EndpointType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IDeadLetterDestinationInternal.EndpointType { get => this._endpointType; set { {_endpointType = value;} } }

        /// <summary>Creates an new <see cref="DeadLetterDestination" /> instance.</summary>
        public DeadLetterDestination()
        {

        }
    }
    /// Information about the dead letter destination for an event subscription. To configure a deadletter destination, do not
    /// directly instantiate an object of this class. Instead, instantiate an object of a derived class. Currently, StorageBlobDeadLetterDestination
    /// is the only class that derives from this class.
    public partial interface IDeadLetterDestination :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>Type of the endpoint for the dead letter destination</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Type of the endpoint for the dead letter destination",
        SerializedName = @"endpointType",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointType { get;  }

    }
    /// Information about the dead letter destination for an event subscription. To configure a deadletter destination, do not
    /// directly instantiate an object of this class. Instead, instantiate an object of a derived class. Currently, StorageBlobDeadLetterDestination
    /// is the only class that derives from this class.
    internal partial interface IDeadLetterDestinationInternal

    {
        /// <summary>Type of the endpoint for the dead letter destination</summary>
        string EndpointType { get; set; }

    }
}