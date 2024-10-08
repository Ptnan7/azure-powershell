// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object containing profile update parameters.</summary>
    public partial class ProfilePropertiesUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesUpdateParametersInternal
    {

        /// <summary>Backing field for <see cref="LogScrubbing" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbing _logScrubbing;

        /// <summary>Defines rules to scrub sensitive fields in logs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbing LogScrubbing { get => (this._logScrubbing = this._logScrubbing ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.ProfileLogScrubbing()); set => this._logScrubbing = value; }

        /// <summary>List of log scrubbing rules applied to the Azure Front Door profile logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileScrubbingRules[] LogScrubbingRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbingInternal)LogScrubbing).ScrubbingRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbingInternal)LogScrubbing).ScrubbingRule = value ?? null /* arrayOf */; }

        /// <summary>State of the log scrubbing config. Default value is Enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileScrubbingState? LogScrubbingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbingInternal)LogScrubbing).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbingInternal)LogScrubbing).State = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileScrubbingState)""); }

        /// <summary>Internal Acessors for LogScrubbing</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbing Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesUpdateParametersInternal.LogScrubbing { get => (this._logScrubbing = this._logScrubbing ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.ProfileLogScrubbing()); set { {_logScrubbing = value;} } }

        /// <summary>Backing field for <see cref="OriginResponseTimeoutSecond" /> property.</summary>
        private int? _originResponseTimeoutSecond;

        /// <summary>
        /// Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public int? OriginResponseTimeoutSecond { get => this._originResponseTimeoutSecond; set => this._originResponseTimeoutSecond = value; }

        /// <summary>Creates an new <see cref="ProfilePropertiesUpdateParameters" /> instance.</summary>
        public ProfilePropertiesUpdateParameters()
        {

        }
    }
    /// The JSON object containing profile update parameters.
    public partial interface IProfilePropertiesUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>List of log scrubbing rules applied to the Azure Front Door profile logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of log scrubbing rules applied to the Azure Front Door profile logs.",
        SerializedName = @"scrubbingRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileScrubbingRules) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileScrubbingRules[] LogScrubbingRule { get; set; }
        /// <summary>State of the log scrubbing config. Default value is Enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of the log scrubbing config. Default value is Enabled.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileScrubbingState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileScrubbingState? LogScrubbingState { get; set; }
        /// <summary>
        /// Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.",
        SerializedName = @"originResponseTimeoutSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? OriginResponseTimeoutSecond { get; set; }

    }
    /// The JSON object containing profile update parameters.
    internal partial interface IProfilePropertiesUpdateParametersInternal

    {
        /// <summary>Defines rules to scrub sensitive fields in logs</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbing LogScrubbing { get; set; }
        /// <summary>List of log scrubbing rules applied to the Azure Front Door profile logs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileScrubbingRules[] LogScrubbingRule { get; set; }
        /// <summary>State of the log scrubbing config. Default value is Enabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileScrubbingState? LogScrubbingState { get; set; }
        /// <summary>
        /// Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.
        /// </summary>
        int? OriginResponseTimeoutSecond { get; set; }

    }
}