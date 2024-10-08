// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>IP Extended Community patchable properties.</summary>
    public partial class IPExtendedCommunityPatchableProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IIPExtendedCommunityPatchableProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IIPExtendedCommunityPatchablePropertiesInternal
    {

        /// <summary>Backing field for <see cref="IPExtendedCommunityRule" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IIPExtendedCommunityRule> _iPExtendedCommunityRule;

        /// <summary>List of IP Extended Community Rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IIPExtendedCommunityRule> IPExtendedCommunityRule { get => this._iPExtendedCommunityRule; set => this._iPExtendedCommunityRule = value; }

        /// <summary>Creates an new <see cref="IPExtendedCommunityPatchableProperties" /> instance.</summary>
        public IPExtendedCommunityPatchableProperties()
        {

        }
    }
    /// IP Extended Community patchable properties.
    public partial interface IIPExtendedCommunityPatchableProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable
    {
        /// <summary>List of IP Extended Community Rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of IP Extended Community Rules.",
        SerializedName = @"ipExtendedCommunityRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IIPExtendedCommunityRule) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IIPExtendedCommunityRule> IPExtendedCommunityRule { get; set; }

    }
    /// IP Extended Community patchable properties.
    internal partial interface IIPExtendedCommunityPatchablePropertiesInternal

    {
        /// <summary>List of IP Extended Community Rules.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IIPExtendedCommunityRule> IPExtendedCommunityRule { get; set; }

    }
}