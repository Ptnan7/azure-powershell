// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    /// <summary>Script reference</summary>
    public partial class ScriptReference :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScriptReference,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.IScriptReferenceInternal
    {

        /// <summary>Backing field for <see cref="ScriptArgument" /> property.</summary>
        private string _scriptArgument;

        /// <summary>Optional command line arguments passed to the script to run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string ScriptArgument { get => this._scriptArgument; set => this._scriptArgument = value; }

        /// <summary>Backing field for <see cref="ScriptData" /> property.</summary>
        private string _scriptData;

        /// <summary>The location of scripts in the mounted volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string ScriptData { get => this._scriptData; set => this._scriptData = value; }

        /// <summary>Backing field for <see cref="ScriptSource" /> property.</summary>
        private string _scriptSource;

        /// <summary>The storage source of the script: workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string ScriptSource { get => this._scriptSource; set => this._scriptSource = value; }

        /// <summary>Backing field for <see cref="Timeout" /> property.</summary>
        private string _timeout;

        /// <summary>Optional time period passed to timeout command.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public string Timeout { get => this._timeout; set => this._timeout = value; }

        /// <summary>Creates an new <see cref="ScriptReference" /> instance.</summary>
        public ScriptReference()
        {

        }
    }
    /// Script reference
    public partial interface IScriptReference :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Optional command line arguments passed to the script to run.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional command line arguments passed to the script to run.",
        SerializedName = @"scriptArguments",
        PossibleTypes = new [] { typeof(string) })]
        string ScriptArgument { get; set; }
        /// <summary>The location of scripts in the mounted volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of scripts in the mounted volume.",
        SerializedName = @"scriptData",
        PossibleTypes = new [] { typeof(string) })]
        string ScriptData { get; set; }
        /// <summary>The storage source of the script: workspace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The storage source of the script: workspace.",
        SerializedName = @"scriptSource",
        PossibleTypes = new [] { typeof(string) })]
        string ScriptSource { get; set; }
        /// <summary>Optional time period passed to timeout command.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Optional time period passed to timeout command.",
        SerializedName = @"timeout",
        PossibleTypes = new [] { typeof(string) })]
        string Timeout { get; set; }

    }
    /// Script reference
    internal partial interface IScriptReferenceInternal

    {
        /// <summary>Optional command line arguments passed to the script to run.</summary>
        string ScriptArgument { get; set; }
        /// <summary>The location of scripts in the mounted volume.</summary>
        string ScriptData { get; set; }
        /// <summary>The storage source of the script: workspace.</summary>
        string ScriptSource { get; set; }
        /// <summary>Optional time period passed to timeout command.</summary>
        string Timeout { get; set; }

    }
}