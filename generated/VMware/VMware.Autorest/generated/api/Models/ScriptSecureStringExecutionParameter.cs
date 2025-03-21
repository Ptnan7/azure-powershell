// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.VMware.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Extensions;

    /// <summary>a plain text value execution parameter</summary>
    public partial class ScriptSecureStringExecutionParameter :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IScriptSecureStringExecutionParameter,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IScriptSecureStringExecutionParameterInternal,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IScriptExecutionParameter"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IScriptExecutionParameter __scriptExecutionParameter = new Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.ScriptExecutionParameter();

        /// <summary>The parameter name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IScriptExecutionParameterInternal)__scriptExecutionParameter).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IScriptExecutionParameterInternal)__scriptExecutionParameter).Name = value ; }

        /// <summary>Backing field for <see cref="SecureValue" /> property.</summary>
        private System.Security.SecureString _secureValue;

        /// <summary>A secure value for the passed parameter, not to be stored in logs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Owned)]
        public System.Security.SecureString SecureValue { get => this._secureValue; set => this._secureValue = value; }

        /// <summary>script execution parameter type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.VMware.PropertyOrigin.Inherited)]
        public string Type { get => "SecureValue"; set => ((Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IScriptExecutionParameterInternal)__scriptExecutionParameter).Type = "SecureValue"; }

        /// <summary>Creates an new <see cref="ScriptSecureStringExecutionParameter" /> instance.</summary>
        public ScriptSecureStringExecutionParameter()
        {
            this.__scriptExecutionParameter.Type = "SecureValue";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__scriptExecutionParameter), __scriptExecutionParameter);
            await eventListener.AssertObjectIsValid(nameof(__scriptExecutionParameter), __scriptExecutionParameter);
        }
    }
    /// a plain text value execution parameter
    public partial interface IScriptSecureStringExecutionParameter :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IScriptExecutionParameter
    {
        /// <summary>A secure value for the passed parameter, not to be stored in logs</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.VMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A secure value for the passed parameter, not to be stored in logs",
        SerializedName = @"secureValue",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString SecureValue { get; set; }

    }
    /// a plain text value execution parameter
    internal partial interface IScriptSecureStringExecutionParameterInternal :
        Microsoft.Azure.PowerShell.Cmdlets.VMware.Models.IScriptExecutionParameterInternal
    {
        /// <summary>A secure value for the passed parameter, not to be stored in logs</summary>
        System.Security.SecureString SecureValue { get; set; }

    }
}