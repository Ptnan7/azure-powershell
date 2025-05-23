// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Extensions;

    /// <summary>List of Storage Movers.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.DoNotFormat]
    public partial class StorageMoverList :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IStorageMoverList,
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IStorageMoverListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IStorageMoverListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IStorageMover[] Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IStorageMoverListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>
        /// Request URL that can be used to query next page of containers. Returned when total number of requested containers exceed
        /// maximum page size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IStorageMover[] _value;

        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IStorageMover[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="StorageMoverList" /> instance.</summary>
        public StorageMoverList()
        {

        }
    }
    /// List of Storage Movers.
    public partial interface IStorageMoverList :
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Request URL that can be used to query next page of containers. Returned when total number of requested containers exceed
        /// maximum page size.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Request URL that can be used to query next page of containers. Returned when total number of requested containers exceed maximum page size.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }

        [Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IStorageMover) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IStorageMover[] Value { get;  }

    }
    /// List of Storage Movers.
    internal partial interface IStorageMoverListInternal

    {
        /// <summary>
        /// Request URL that can be used to query next page of containers. Returned when total number of requested containers exceed
        /// maximum page size.
        /// </summary>
        string NextLink { get; set; }

        Microsoft.Azure.PowerShell.Cmdlets.StorageMover.Models.Api20240701.IStorageMover[] Value { get; set; }

    }
}