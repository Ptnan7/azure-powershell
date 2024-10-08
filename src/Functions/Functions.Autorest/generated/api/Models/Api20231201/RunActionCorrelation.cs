// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>The workflow run action correlation properties.</summary>
    public partial class RunActionCorrelation :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunActionCorrelation,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunActionCorrelationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunCorrelation"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunCorrelation __runCorrelation = new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.RunCorrelation();

        /// <summary>Backing field for <see cref="ActionTrackingId" /> property.</summary>
        private string _actionTrackingId;

        /// <summary>The action tracking identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string ActionTrackingId { get => this._actionTrackingId; set => this._actionTrackingId = value; }

        /// <summary>The client keywords.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string[] ClientKeyword { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunCorrelationInternal)__runCorrelation).ClientKeyword; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunCorrelationInternal)__runCorrelation).ClientKeyword = value ?? null /* arrayOf */; }

        /// <summary>The client tracking identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inherited)]
        public string ClientTrackingId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunCorrelationInternal)__runCorrelation).ClientTrackingId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunCorrelationInternal)__runCorrelation).ClientTrackingId = value ?? null; }

        /// <summary>Creates an new <see cref="RunActionCorrelation" /> instance.</summary>
        public RunActionCorrelation()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__runCorrelation), __runCorrelation);
            await eventListener.AssertObjectIsValid(nameof(__runCorrelation), __runCorrelation);
        }
    }
    /// The workflow run action correlation properties.
    public partial interface IRunActionCorrelation :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunCorrelation
    {
        /// <summary>The action tracking identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The action tracking identifier.",
        SerializedName = @"actionTrackingId",
        PossibleTypes = new [] { typeof(string) })]
        string ActionTrackingId { get; set; }

    }
    /// The workflow run action correlation properties.
    internal partial interface IRunActionCorrelationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IRunCorrelationInternal
    {
        /// <summary>The action tracking identifier.</summary>
        string ActionTrackingId { get; set; }

    }
}