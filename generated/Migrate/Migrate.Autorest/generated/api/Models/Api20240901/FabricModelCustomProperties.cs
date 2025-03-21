// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Fabric model custom properties.</summary>
    public partial class FabricModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IFabricModelCustomProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IFabricModelCustomPropertiesInternal
    {

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>Discriminator property for FabricModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Creates an new <see cref="FabricModelCustomProperties" /> instance.</summary>
        public FabricModelCustomProperties()
        {

        }
    }
    /// Fabric model custom properties.
    public partial interface IFabricModelCustomProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>Discriminator property for FabricModelCustomProperties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Discriminator property for FabricModelCustomProperties.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }

    }
    /// Fabric model custom properties.
    internal partial interface IFabricModelCustomPropertiesInternal

    {
        /// <summary>Discriminator property for FabricModelCustomProperties.</summary>
        string InstanceType { get; set; }

    }
}