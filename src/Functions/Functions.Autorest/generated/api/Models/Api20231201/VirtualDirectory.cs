// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>Directory for virtual application.</summary>
    public partial class VirtualDirectory :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IVirtualDirectory,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IVirtualDirectoryInternal
    {

        /// <summary>Backing field for <see cref="PhysicalPath" /> property.</summary>
        private string _physicalPath;

        /// <summary>Physical path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string PhysicalPath { get => this._physicalPath; set => this._physicalPath = value; }

        /// <summary>Backing field for <see cref="VirtualPath" /> property.</summary>
        private string _virtualPath;

        /// <summary>Path to virtual application.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string VirtualPath { get => this._virtualPath; set => this._virtualPath = value; }

        /// <summary>Creates an new <see cref="VirtualDirectory" /> instance.</summary>
        public VirtualDirectory()
        {

        }
    }
    /// Directory for virtual application.
    public partial interface IVirtualDirectory :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>Physical path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Physical path.",
        SerializedName = @"physicalPath",
        PossibleTypes = new [] { typeof(string) })]
        string PhysicalPath { get; set; }
        /// <summary>Path to virtual application.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path to virtual application.",
        SerializedName = @"virtualPath",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualPath { get; set; }

    }
    /// Directory for virtual application.
    internal partial interface IVirtualDirectoryInternal

    {
        /// <summary>Physical path.</summary>
        string PhysicalPath { get; set; }
        /// <summary>Path to virtual application.</summary>
        string VirtualPath { get; set; }

    }
}