// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>Monitor resource update parameters.</summary>
    public partial class ElasticMonitorResourceUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticMonitorResourceUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticMonitorResourceUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticMonitorResourceUpdateParametersTags _tag;

        /// <summary>elastic monitor resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticMonitorResourceUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.ElasticMonitorResourceUpdateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="ElasticMonitorResourceUpdateParameters" /> instance.</summary>
        public ElasticMonitorResourceUpdateParameters()
        {

        }
    }
    /// Monitor resource update parameters.
    public partial interface IElasticMonitorResourceUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.IJsonSerializable
    {
        /// <summary>elastic monitor resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"elastic monitor resource tags.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticMonitorResourceUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticMonitorResourceUpdateParametersTags Tag { get; set; }

    }
    /// Monitor resource update parameters.
    internal partial interface IElasticMonitorResourceUpdateParametersInternal

    {
        /// <summary>elastic monitor resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IElasticMonitorResourceUpdateParametersTags Tag { get; set; }

    }
}